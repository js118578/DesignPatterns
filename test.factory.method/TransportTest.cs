using factory.method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test.factory.method
{
    [TestClass]
    public class TransportTest
    {
        [TestMethod]
        public void ShouldTransportByMotorcycle()
        {
            var transport = new Motorcycle();

            Assert.AreEqual(TransportType.Motorcycle, transport.TransportType);

            Assert.AreEqual("I am transporting by Motorcycle", transport.doTransport());
        }

        [TestMethod]
        public void ShouldTransportByCar()
        {
            var transport = new Car();

            Assert.AreEqual(TransportType.Car, transport.TransportType);

            Assert.AreEqual("I am transporting by Car", transport.doTransport());
        }

        [TestMethod]
        public void ShouldTransportByAirplane()
        {
            var transport = new Airplane();

            Assert.AreEqual(TransportType.Airplane, transport.TransportType);

            Assert.AreEqual("I am transporting by Airplane", transport.doTransport());
        }

        [TestMethod]
        public void ShouldTransportByShip()
        {
            var transport = new Ship();

            Assert.AreEqual(TransportType.Ship, transport.TransportType);

            Assert.AreEqual("I am transporting by Ship", transport.doTransport());
        }
    }
}
