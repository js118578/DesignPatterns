using abs.factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test.abs.factory
{
    [TestClass]
    public class absfactorytest
    {
        [TestMethod]
        public void ShouldCreateACar()
        {
            var factory = new CarFactory();

            var car = factory.Create();

            Assert.AreEqual(4, car.wheels);

            Assert.AreEqual("I am a car", car.model);
        }

        [TestMethod]
        public void ShouldCreateAMotorcycle()
        {
            var factory = new MotorcycleFactory();

            var car = factory.Create();

            Assert.AreEqual(2, car.wheels);

            Assert.AreEqual("I am a motorcycle", car.model);
        }

        [TestMethod]
        public void ShouldCreateATruck()
        {
            var factory = new TruckFactory();

            var car = factory.Create();

            Assert.AreEqual(6, car.wheels);

            Assert.AreEqual("I am a truck", car.model);
        }
    }
}
