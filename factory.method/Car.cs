using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.method
{
    public class Car : Transport
    {
        public Car()
        {
            TransportType = TransportType.Car;
        }

        public override string doTransport()
        {
            return "I am transporting by Car";
        }
    }
}
