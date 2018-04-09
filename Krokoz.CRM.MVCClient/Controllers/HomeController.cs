using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Krokoz.CRM.BL.Repositories;

namespace Krokoz.CRM.MVCClient.Controllers
{
    public class HomeController : BaseController
    {
        private ILandingPageRepository landingPageRepository;

        public HomeController(ILandingPageRepository landingPageRepository)
        {
            this.landingPageRepository = landingPageRepository;
        }

        public HomeController()
        {
            this.landingPageRepository = new LandingPageRepository();
        }

        public ActionResult Index()
        {
            var model = this.landingPageRepository.GatAllLoggingLanding();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}