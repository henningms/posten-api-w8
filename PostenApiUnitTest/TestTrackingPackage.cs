using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace PostenApiUnitTest
{
    [TestClass]
    public class TestTrackingPackage
    {
        [TestMethod]
        public async Task TestPackageIsDelivered()
        {
            var package = await PostenApi.Service.Tracking.Track("CT303699219NO");

            Assert.IsNotNull(package);
            Assert.AreEqual("DELIVERED", package.ConsignmentSet.First().PackageSets.First().Events.First().Status);
        }
    }
}
