using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B2B.WebMVC.Helpers
{
    public class AuthorizeUserAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var token = filterContext.HttpContext.Session["token"];
            if (token == null)
            {
                filterContext.Result = new RedirectResult(string.Format("/Account/SignIn?targetUrl={0}", filterContext.HttpContext.Request.Url.AbsolutePath));
            }
        }
    }
}