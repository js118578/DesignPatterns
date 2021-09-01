using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.method
{
    public class Motorcycle : Transport
    {
        public Motorcycle()
        {
            TransportType = TransportType.Motorcycle;
        }

        public override string doTransport()
        {
            return "I am transporting by Motorcycle";
        }
    }
}
