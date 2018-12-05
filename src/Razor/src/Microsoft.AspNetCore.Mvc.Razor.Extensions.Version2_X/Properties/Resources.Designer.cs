// <auto-generated />
namespace Microsoft.AspNetCore.Mvc.Razor.Extensions.Version2_X
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Mvc.Razor.Extensions.Version2_X.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get => GetString("ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
            => GetString("ArgumentCannotBeNullOrEmpty");

        /// <summary>
        /// Inject a service from the application's service container into a property.
        /// </summary>
        internal static string InjectDirective_Description
        {
            get => GetString("InjectDirective_Description");
        }

        /// <summary>
        /// Inject a service from the application's service container into a property.
        /// </summary>
        internal static string FormatInjectDirective_Description()
            => GetString("InjectDirective_Description");

        /// <summary>
        /// The name of the property.
        /// </summary>
        internal static string InjectDirective_MemberToken_Description
        {
            get => GetString("InjectDirective_MemberToken_Description");
        }

        /// <summary>
        /// The name of the property.
        /// </summary>
        internal static string FormatInjectDirective_MemberToken_Description()
            => GetString("InjectDirective_MemberToken_Description");

        /// <summary>
        /// PropertyName
        /// </summary>
        internal static string InjectDirective_MemberToken_Name
        {
            get => GetString("InjectDirective_MemberToken_Name");
        }

        /// <summary>
        /// PropertyName
        /// </summary>
        internal static string FormatInjectDirective_MemberToken_Name()
            => GetString("InjectDirective_MemberToken_Name");

        /// <summary>
        /// The type of the service to inject.
        /// </summary>
        internal static string InjectDirective_TypeToken_Description
        {
            get => GetString("InjectDirective_TypeToken_Description");
        }

        /// <summary>
        /// The type of the service to inject.
        /// </summary>
        internal static string FormatInjectDirective_TypeToken_Description()
            => GetString("InjectDirective_TypeToken_Description");

        /// <summary>
        /// TypeName
        /// </summary>
        internal static string InjectDirective_TypeToken_Name
        {
            get => GetString("InjectDirective_TypeToken_Name");
        }

        /// <summary>
        /// TypeName
        /// </summary>
        internal static string FormatInjectDirective_TypeToken_Name()
            => GetString("InjectDirective_TypeToken_Name");

        /// <summary>
        /// Specify the view or page model for the page.
        /// </summary>
        internal static string ModelDirective_Description
        {
            get => GetString("ModelDirective_Description");
        }

        /// <summary>
        /// Specify the view or page model for the page.
        /// </summary>
        internal static string FormatModelDirective_Description()
            => GetString("ModelDirective_Description");

        /// <summary>
        /// The model type.
        /// </summary>
        internal static string ModelDirective_TypeToken_Description
        {
            get => GetString("ModelDirective_TypeToken_Description");
        }

        /// <summary>
        /// The model type.
        /// </summary>
        internal static string FormatModelDirective_TypeToken_Description()
            => GetString("ModelDirective_TypeToken_Description");

        /// <summary>
        /// TypeName
        /// </summary>
        internal static string ModelDirective_TypeToken_Name
        {
            get => GetString("ModelDirective_TypeToken_Name");
        }

        /// <summary>
        /// TypeName
        /// </summary>
        internal static string FormatModelDirective_TypeToken_Name()
            => GetString("ModelDirective_TypeToken_Name");

        /// <summary>
        /// The 'inherits' keyword is not allowed when a '{0}' keyword is used.
        /// </summary>
        internal static string MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword
        {
            get => GetString("MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword");
        }

        /// <summary>
        /// The 'inherits' keyword is not allowed when a '{0}' keyword is used.
        /// </summary>
        internal static string FormatMvcRazorCodeParser_CannotHaveModelAndInheritsKeyword(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("MvcRazorCodeParser_CannotHaveModelAndInheritsKeyword"), p0);

        /// <summary>
        /// A property name must be specified when using the '{0}' statement. Format for a '{0}' statement is '@{0} &lt;Type Name&gt; &lt;Property Name&gt;'.
        /// </summary>
        internal static string MvcRazorCodeParser_InjectDirectivePropertyNameRequired
        {
            get => GetString("MvcRazorCodeParser_InjectDirectivePropertyNameRequired");
        }

        /// <summary>
        /// A property name must be specified when using the '{0}' statement. Format for a '{0}' statement is '@{0} &lt;Type Name&gt; &lt;Property Name&gt;'.
        /// </summary>
        internal static string FormatMvcRazorCodeParser_InjectDirectivePropertyNameRequired(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("MvcRazorCodeParser_InjectDirectivePropertyNameRequired"), p0);

        /// <summary>
        /// The '{0}' keyword must be followed by a type name on the same line.
        /// </summary>
        internal static string MvcRazorCodeParser_KeywordMustBeFollowedByTypeName
        {
            get => GetString("MvcRazorCodeParser_KeywordMustBeFollowedByTypeName");
        }

        /// <summary>
        /// The '{0}' keyword must be followed by a type name on the same line.
        /// </summary>
        internal static string FormatMvcRazorCodeParser_KeywordMustBeFollowedByTypeName(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("MvcRazorCodeParser_KeywordMustBeFollowedByTypeName"), p0);

        /// <summary>
        /// Only one '{0}' statement is allowed in a file.
        /// </summary>
        internal static string MvcRazorCodeParser_OnlyOneModelStatementIsAllowed
        {
            get => GetString("MvcRazorCodeParser_OnlyOneModelStatementIsAllowed");
        }

        /// <summary>
        /// Only one '{0}' statement is allowed in a file.
        /// </summary>
        internal static string FormatMvcRazorCodeParser_OnlyOneModelStatementIsAllowed(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("MvcRazorCodeParser_OnlyOneModelStatementIsAllowed"), p0);

        /// <summary>
        /// Invalid tag helper property '{0}.{1}'. Dictionary values must not be of type '{2}'.
        /// </summary>
        internal static string MvcRazorParser_InvalidPropertyType
        {
            get => GetString("MvcRazorParser_InvalidPropertyType");
        }

        /// <summary>
        /// Invalid tag helper property '{0}.{1}'. Dictionary values must not be of type '{2}'.
        /// </summary>
        internal static string FormatMvcRazorParser_InvalidPropertyType(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("MvcRazorParser_InvalidPropertyType"), p0, p1, p2);

        /// <summary>
        /// Specify the base namespace for the page.
        /// </summary>
        internal static string NamespaceDirective_Description
        {
            get => GetString("NamespaceDirective_Description");
        }

        /// <summary>
        /// Specify the base namespace for the page.
        /// </summary>
        internal static string FormatNamespaceDirective_Description()
            => GetString("NamespaceDirective_Description");

        /// <summary>
        /// The namespace for the page.
        /// </summary>
        internal static string NamespaceDirective_NamespaceToken_Description
        {
            get => GetString("NamespaceDirective_NamespaceToken_Description");
        }

        /// <summary>
        /// The namespace for the page.
        /// </summary>
        internal static string FormatNamespaceDirective_NamespaceToken_Description()
            => GetString("NamespaceDirective_NamespaceToken_Description");

        /// <summary>
        /// Namespace
        /// </summary>
        internal static string NamespaceDirective_NamespaceToken_Name
        {
            get => GetString("NamespaceDirective_NamespaceToken_Name");
        }

        /// <summary>
        /// Namespace
        /// </summary>
        internal static string FormatNamespaceDirective_NamespaceToken_Name()
            => GetString("NamespaceDirective_NamespaceToken_Name");

        /// <summary>
        /// The '@{0}' directive specified in {1} file will not be imported. The directive must appear at the top of each Razor cshtml file.
        /// </summary>
        internal static string PageDirectiveCannotBeImported
        {
            get => GetString("PageDirectiveCannotBeImported");
        }

        /// <summary>
        /// The '@{0}' directive specified in {1} file will not be imported. The directive must appear at the top of each Razor cshtml file.
        /// </summary>
        internal static string FormatPageDirectiveCannotBeImported(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("PageDirectiveCannotBeImported"), p0, p1);

        /// <summary>
        /// The '@{0}' directive must exist at the top of the file. Only comments and whitespace are allowed before the '@{0}' directive.
        /// </summary>
        internal static string PageDirectiveMustExistAtTheTopOfFile
        {
            get => GetString("PageDirectiveMustExistAtTheTopOfFile");
        }

        /// <summary>
        /// The '@{0}' directive must exist at the top of the file. Only comments and whitespace are allowed before the '@{0}' directive.
        /// </summary>
        internal static string FormatPageDirectiveMustExistAtTheTopOfFile(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("PageDirectiveMustExistAtTheTopOfFile"), p0);

        /// <summary>
        /// Mark the page as a Razor Page.
        /// </summary>
        internal static string PageDirective_Description
        {
            get => GetString("PageDirective_Description");
        }

        /// <summary>
        /// Mark the page as a Razor Page.
        /// </summary>
        internal static string FormatPageDirective_Description()
            => GetString("PageDirective_Description");

        /// <summary>
        /// An optional route template for the page.
        /// </summary>
        internal static string PageDirective_RouteToken_Description
        {
            get => GetString("PageDirective_RouteToken_Description");
        }

        /// <summary>
        /// An optional route template for the page.
        /// </summary>
        internal static string FormatPageDirective_RouteToken_Description()
            => GetString("PageDirective_RouteToken_Description");

        /// <summary>
        /// RouteTemplate
        /// </summary>
        internal static string PageDirective_RouteToken_Name
        {
            get => GetString("PageDirective_RouteToken_Name");
        }

        /// <summary>
        /// RouteTemplate
        /// </summary>
        internal static string FormatPageDirective_RouteToken_Name()
            => GetString("PageDirective_RouteToken_Name");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
