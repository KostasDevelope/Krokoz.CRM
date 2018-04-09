using System;
using System.Linq;
using Krokoz.CRM.BL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Krokoz.CRM.Business.Tests
{
    [TestClass]
    public class UnitTestLandingPageRepository
    {
        public UnitTestLandingPageRepository()
        {
            landingPageRepository = new LandingPageRepository();
        }
        private ILandingPageRepository landingPageRepository;

        [TestMethod]
        public void TestGatAllLoggingLanding()
        {
            var model = landingPageRepository.GatAllLoggingLanding();
            var collection =  model.ToList();
            Assert.IsNotNull(model);
            Assert.IsTrue(collection.Count != 0);
        }
    }
}
