import '@dotnet/jsinterop';
import './GlobalExports';
import * as signalR from '@aspnet/signalr';
import { MessagePackHubProtocol } from '@aspnet/signalr-protocol-msgpack';
import { fetchBootConfigAsync, loadEmbeddedResourcesAsync, shouldAutoStart } from './BootCommon';
import { CircuitHandler } from './Platform/Circuits/CircuitHandler';
import { AutoReconnectCircuitHandler } from './Platform/Circuits/AutoReconnectCircuitHandler';
import RenderQueue from './Platform/Circuits/RenderQueue';
import { ConsoleLogger } from './Platform/Logging/Loggers';
import { LogLevel, ILogger } from './Platform/Logging/ILogger';
import { discoverPrerenderedCircuits, startCircuit } from './Platform/Circuits/CircuitManager';


type SignalRBuilder = (builder: signalR.HubConnectionBuilder) => void;
interface BlazorOptions {
  configureSignalR?: SignalRBuilder,
};

let renderingFailed = false;
let started = false;

async function boot(options?: BlazorOptions): Promise<void> {

  if (started) {
    throw new Error('Blazor has already started.');
  }
  started = true;

  // For development.
  // Simply put a break point here and modify the log level during
  // development to get traces.
  // In the future we will allow for users to configure this.
  const logger = new ConsoleLogger(LogLevel.Error);

  logger.log(LogLevel.Information, 'Booting blazor.');

  const circuitHandlers: CircuitHandler[] = [new AutoReconnectCircuitHandler(logger)];
  window['Blazor'].circuitHandlers = circuitHandlers;

  // In the background, start loading the boot config and any embedded resources
  const embeddedResourcesPromise = fetchBootConfigAsync().then(bootConfig => {
    return loadEmbeddedResourcesAsync(bootConfig);
  });

  // pass options.configureSignalR to configure the signalR.HubConnectionBuilder
  const configureSignalR = (options && options.configureSignalR) || null;
  const initialConnection = await initializeConnection(configureSignalR, circuitHandlers, logger);

  const circuits = discoverPrerenderedCircuits(document);
  for (let i = 0; i < circuits.length; i++) {
    const circuit = circuits[i];
    for (let j = 0; j < circuit.components.length; j++) {
      const component = circuit.components[j];
      component.initialize();
    }
  }

  // Ensure any embedded resources have been loaded before starting the app
  await embeddedResourcesPromise;

  const circuit = await startCircuit(initialConnection);

  if (!circuit) {
    logger.log(LogLevel.Information, 'No preregistered components to render.');
  }

  const reconnect = async (): Promise<boolean> => {
    if (renderingFailed) {
      // We can't reconnect after a failure, so exit early.
      return false;
    }
    const reconnection = await initializeConnection(configureSignalR, circuitHandlers, logger);
    const results = await Promise.all(circuits.map(circuit => circuit.reconnect(reconnection)));

    if (reconnectionFailed(results)) {
      return false;
    }

    circuitHandlers.forEach(h => h.onConnectionUp && h.onConnectionUp());
    return true;
  };

  window['Blazor'].reconnect = reconnect;

  const reconnectTask = reconnect();

  if (circuit) {
    circuits.push(circuit);
  }

  await reconnectTask;

  function reconnectionFailed(results: boolean[]): boolean {
    return !results.reduce((current, next) => current && next, true);
  }
}

async function initializeConnection(configureSignalR: SignalRBuilder | null, circuitHandlers: CircuitHandler[], logger: ILogger): Promise<signalR.HubConnection> {

  const hubProtocol = new MessagePackHubProtocol();
  (hubProtocol as any).name = 'blazorpack';

  const connectionBuilder = new signalR.HubConnectionBuilder()
    .withUrl('_blazor')
    .withHubProtocol(hubProtocol);

  if (configureSignalR) {
    configureSignalR(connectionBuilder);
  }

  const connection = connectionBuilder.build();

  connection.on('JS.BeginInvokeJS', DotNet.jsCallDispatcher.beginInvokeJSFromDotNet);
  connection.on('JS.RenderBatch', (browserRendererId: number, batchId: number, batchData: Uint8Array) => {
    logger.log(LogLevel.Information, `Received render batch for ${browserRendererId} with id ${batchId} and ${batchData.byteLength} bytes.`);

    const queue = RenderQueue.getOrCreateQueue(browserRendererId, logger);

    queue.processBatch(batchId, batchData, connection);
  });

  connection.onclose(error => !renderingFailed && circuitHandlers.forEach(h => h.onConnectionDown && h.onConnectionDown(error)));
  connection.on('JS.Error', error => unhandledError(connection, error, logger));

  window['Blazor']._internal.forceCloseConnection = () => connection.stop();

  try {
    await connection.start();
  } catch (ex) {
    unhandledError(connection, ex, logger);
  }

  DotNet.attachDispatcher({
    beginInvokeDotNetFromJS: (callId, assemblyName, methodIdentifier, dotNetObjectId, argsJson) => {
      connection.send('BeginInvokeDotNetFromJS', callId ? callId.toString() : null, assemblyName, methodIdentifier, dotNetObjectId || 0, argsJson);
    },
  });

  return connection;
}

function unhandledError(connection: signalR.HubConnection, err: Error, logger: ILogger): void {
  logger.log(LogLevel.Error, err);

  // Disconnect on errors.
  //
  // Trying to call methods on the connection after its been closed will throw.
  if (connection) {
    renderingFailed = true;
    connection.stop();
  }
}

window['Blazor'].start = boot;
if (shouldAutoStart()) {
  boot();
}
