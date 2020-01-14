using System;
using System.Globalization;
using System.Web.Mvc;

namespace B2B.WebMVC.Helpers
{
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// Extension method to handle localized URL using a dedicated, multi-language custom route.
        /// for additional info, read the following post:
        /// https://www.ryadel.com/en/setup-a-multi-language-website-using-asp-net-mvc/
        /// </summary>
        public static string Action(
            this UrlHelper helper,
            string actionName,
            string controllerName,
            object routeValues,
            CultureInfo cultureInfo)
        {
            // fallback if cultureInfo is NULL
            if (cultureInfo == null) cultureInfo = CultureInfo.CurrentCulture;

            var uri = System.Web.HttpContext.Current.Request.Url;

            var urlWithCulture = uri.Scheme + Uri.SchemeDelimiter + uri.Authority + "/" + cultureInfo.TwoLetterISOLanguageName;

            var containsCulture = uri.ToString().Contains(urlWithCulture);

            // arrange a "localized" controllerName to be handled with a dedicated localization-aware route.
            string localizedControllerName = containsCulture
                ? String.Format("/{0}", controllerName)
                : String.Format("{0}/{1}", cultureInfo.TwoLetterISOLanguageName, controllerName);

            // build the Action
            return helper.Action(
                actionName,
                localizedControllerName,
                routeValues);
        }
    }
}