using System;

namespace factory.method
{
    public abstract class Transport
    {
        public TransportType TransportType { get; set; }
        public abstract string doTransport();
    }

    public enum TransportType
    {
        Motorcycle,
        Car,
        Airplane,
        Ship
    }
}
