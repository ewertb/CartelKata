using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCartelKata.Factory;

namespace TheCartelKata.Tests
{
    [TestClass]
    public class PropertyTests
    {
        [TestMethod]
        public void RuralPropertyShouldProduceMarijuanaTest()
        {
            var ruralProperty = new RuralProperty(new Marijuana(), 600, PropertyFactory.RuralTimeUnits, PropertyFactory.RuralWeightUnits);
            Assert.AreEqual(ruralProperty.Drug.Name, "Marijuana");
        }

        [TestMethod]
        public void JunglePropertyShouldProduceCocaineTest()
        {
            var jungleProperty = new JungleProperty(new Cocaine(), 600, PropertyFactory.JungleTimeUnits, PropertyFactory.JungleWeightUnits);
            Assert.AreEqual(jungleProperty.Drug.Name, "Cocaine");
        }

        [TestMethod]
        public void UrbanPropertyShouldProduceMdmaTest()
        {
            var urbanProperty = new UrbanProperty(new Mdma(), 600, PropertyFactory.UrbanTimeUnits, PropertyFactory.UrbanWeightUnits);
            Assert.AreEqual(urbanProperty.Drug.Name, "MDMA");
        }
    }
}
