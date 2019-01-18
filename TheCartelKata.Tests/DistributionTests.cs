using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCartelKata.Chain;

namespace TheCartelKata.Tests
{
    [TestClass]
    public class DistributionTests
    {
        [TestMethod]
        public void ShouldBeHandledByStreetDealerTest()
        {
            var streetDealer = new StreetDealer();
            streetDealer.Handle(200);
            Assert.AreEqual(streetDealer.Handled, true);
        }

        [TestMethod]
        public void ShouldBeHandledByDistributorTest()
        {
            var streetDealer = new StreetDealer();
            streetDealer.Handle(2000);
            Assert.AreEqual(streetDealer.Handled, false);
            Assert.AreEqual(streetDealer.Next.Handled, true);
        }

        [TestMethod]
        public void ShouldBeHandledByKingPinTest()
        {
            var streetDealer = new StreetDealer();
            streetDealer.Handle(20000);
            Assert.AreEqual(streetDealer.Handled, false);
            Assert.AreEqual(streetDealer.Next.Handled, false);
            Assert.AreEqual(streetDealer.Next.Next.Handled, true);
        }
    }
}
