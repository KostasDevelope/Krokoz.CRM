using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Krokoz.CRM.BL.Repositories;

namespace Krokoz.CRM.MVCClient.Controllers
{
    public class BaseController : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            LoggingPage(requestContext);
        }

        protected void LoggingPage(RequestContext requestContext)
        {
            ILandingPageRepository landingPageRepository = new LandingPageRepository();
            var identity = requestContext.HttpContext.User.Identity;
            var userName = identity.IsAuthenticated ? identity.Name : string.Empty;
            var previousPage = Session["PreviousPage"] as string;
            if (!string.IsNullOrEmpty(previousPage))
            {
                landingPageRepository.InsertLoggingLanding(userName, previousPage, 2);
            }
            var absoluteUri = requestContext.HttpContext.Request.Url.AbsoluteUri;
            Session["PreviousPage"] = absoluteUri;
            landingPageRepository.InsertLoggingLanding(userName, absoluteUri, 1);
        }
    }
}
