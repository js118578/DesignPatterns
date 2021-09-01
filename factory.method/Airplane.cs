using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.method
{
    public class Airplane : Transport
    {
        public Airplane()
        {
            TransportType = TransportType.Airplane;
        }

        public override string doTransport()
        {
            return "I am transporting by Airplane";
        }
    }
}
