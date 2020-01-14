using B2B.WebMVC.Helpers.EndPoints;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using B2B.WebMVC.Helpers;

using System.Threading.Tasks;
using System.Web.Security;
using System.Threading;
using System.Globalization;
using System.Web.Routing;
using B2B.SharedKernel;

namespace B2B.WebMVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Language(string lang = "", Uri url = null)
        {

            var cultureInfo = CultureInfo.CurrentCulture;

            var uri = url;

            var urlWithCurrentCulture = uri.Scheme + Uri.SchemeDelimiter + uri.Authority + "/" + cultureInfo.TwoLetterISOLanguageName;
            var urlWithNewCulture = uri.Scheme + Uri.SchemeDelimiter + uri.Authority + "/" + lang;

            var containsCulture = uri.ToString().Contains(urlWithCurrentCulture);

            var redirect = "";
            if (containsCulture)
            {
                // containsCulture TRUE ise /lang/ var
                // uri de /lang/ ile yeni /LANG/ replace olur
                redirect = uri.ToString().Replace(urlWithCurrentCulture, urlWithNewCulture);
            } else
            {
                // containsCulture FALSE ise /lang/ yok
                // redirect urlWithNewCulture + uri.PathAndQuery
                redirect = urlWithNewCulture + uri.PathAndQuery;
            }

            SessionClass.Session = lang;
            System.Web.HttpContext.Current.Response.Redirect(redirect);

            return RedirectToAction("Index", new { lang });
        }

    }
}