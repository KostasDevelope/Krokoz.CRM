using System;
using Krokoz.CRM.BL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Krokoz.CRM.Business.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            landingPageRepository = new LandingPageRepository();
        }

        private ILandingPageRepository landingPageRepository;

        [TestMethod]
        public void TestMethod1()
        {
            var model = landingPageRepository.GatAllLoggingLanding();
            Assert.IsNotNull(model);
        }
    }
}
