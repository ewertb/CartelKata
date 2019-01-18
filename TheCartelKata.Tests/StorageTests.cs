using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCartelKata.Enum;
using TheCartelKata.Factory;
using TheCartelKata.Strategy.Storage;

namespace TheCartelKata.Tests
{
    [TestClass]
    public class StorageTests
    {
        [TestMethod]
        public void RuralPropertyShouldUseMarijuanaStorageTest()
        {
            var ruralProperty = new RuralProperty(new Marijuana(), 600, PropertyFactory.RuralTimeUnits, PropertyFactory.RuralWeightUnits);
            Assert.AreEqual(ruralProperty.Storage.GetType(), typeof(MarijuanaStorage));
        }

        [TestMethod]
        public void JunglePropertyShouldUseCocaineRawStorageTest()
        {
            var jungleProperty = new JungleProperty(new Cocaine(), 600, PropertyFactory.JungleTimeUnits, PropertyFactory.JungleWeightUnits);
            jungleProperty.Drug.State = Enum.State.Raw;
            jungleProperty.Storage = StorageFactory.Storage[jungleProperty.Drug.GetType()](jungleProperty);
            Assert.AreEqual(jungleProperty.Storage.GetType(), typeof(CocaineRawStorage));
        }

        [TestMethod]
        public void JunglePropertyShouldUseCocaineCutStorageTest()
        {
            var jungleProperty = new JungleProperty(new Cocaine { State = State.Cut, Cut = Cut.Medium }, 600, PropertyFactory.JungleTimeUnits, PropertyFactory.JungleWeightUnits);
            Assert.AreEqual(jungleProperty.Storage.GetType(), typeof(CocaineCutStorage));
        }

        [TestMethod]
        public void UrbanPropertyShouldUseMdmaStorageTest()
        {
            var urbanProperty = new UrbanProperty(new Mdma(), 600, PropertyFactory.UrbanTimeUnits, PropertyFactory.UrbanWeightUnits);
            Assert.AreEqual(urbanProperty.Storage.GetType(), typeof(MdmaStorage));
        }

        [TestMethod]
        public void RuralStorageFor3000kgMarijuanaShouldEqual300000Test()
        {
            var ruralProperty = new RuralProperty(new Marijuana(), 600, PropertyFactory.RuralTimeUnits, PropertyFactory.RuralWeightUnits);
            ruralProperty.Produce(15);
            Assert.AreEqual(ruralProperty.Storage.GetPrice(), 300000);
        }

        [TestMethod]
        public void JungleStorageFor642857kgRawCocaineShouldEqual642857142Test()
        {
            var jungleProperty = new JungleProperty(new Cocaine(), 600, PropertyFactory.JungleTimeUnits, PropertyFactory.JungleWeightUnits);
            jungleProperty.Produce(15);
            Assert.AreEqual(jungleProperty.Storage.GetPrice().ToString("#0.00"), "642857142,86");
        }

        [TestMethod]
        public void JungleStorageFor642857kgCutCocaineShouldEqual642857142Test()
        {
            var jungleProperty = new JungleProperty(new Cocaine { State = State.Cut, Cut = Cut.Medium }, 600, PropertyFactory.JungleTimeUnits, PropertyFactory.JungleWeightUnits);
            jungleProperty.Produce(15);
            Assert.AreEqual(jungleProperty.Storage.GetPrice().ToString("#0.00"), "900000000,00");
        }

        [TestMethod]
        public void UrbanStorageFor6428PillsMdmaShouldEqual64285Test()
        {
            var urbanProperty = new UrbanProperty(new Mdma(), 60, PropertyFactory.UrbanTimeUnits, PropertyFactory.UrbanWeightUnits);
            urbanProperty.Produce(15);
            Assert.AreEqual(urbanProperty.Storage.GetPrice().ToString("#0.00"), "64285,71");
        }
    }
}
