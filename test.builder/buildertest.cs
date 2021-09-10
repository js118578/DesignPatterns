using builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test.builder
{
    [TestClass]
    public class buildertest
    {
        [TestMethod]
        public void ShouldCreateCar()
        {
            var builder = new VehicleBuilder();

            var car = builder.CreateCar();

            Assert.AreEqual("I am a car.", car.Model);

            Assert.AreEqual(4, car.Wheels);
        }
        [TestMethod]
        public void ShouldCreateMotorcycle()
        {
            var builder = new VehicleBuilder();

            var motorcycle = builder.CreateMotorcycle();

            Assert.AreEqual("I am a motorcycle.", motorcycle.Model);

            Assert.AreEqual(2, motorcycle.Wheels);
        }
        [TestMethod]
        public void ShouldCreateTruck()
        {
            var builder = new VehicleBuilder();

            var truck = builder.CreateTruck();

            Assert.AreEqual("I am a truck.", truck.Model);

            Assert.AreEqual(6, truck.Wheels);
        }
    }
}
