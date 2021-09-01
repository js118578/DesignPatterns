using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abs.factory
{
    public class Truck : IVehicle
    {
        public int wheels { get; set; }
        public string model { get; set; }
    }
}
