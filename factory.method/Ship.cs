using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.method
{
    public class Ship : Transport
    {
        public Ship()
        {
            TransportType = TransportType.Ship;
        }

        public override string doTransport()
        {
            return "I am transporting by Ship";
        }
    }
}
