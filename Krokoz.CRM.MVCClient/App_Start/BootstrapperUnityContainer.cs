using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Krokoz.CRM.BL.Repositories;
using Krokoz.CRM.MVCClient.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Unity;
using Unity.AspNet.Mvc;


namespace Krokoz.CRM.MVCClient
{
    public class BootstrapperUnityContainer
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<ILandingPageRepository, LandingPageRepository>();
            container.RegisterType<IdentityUser, ApplicationUser>();

            RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {

        }

    }
}