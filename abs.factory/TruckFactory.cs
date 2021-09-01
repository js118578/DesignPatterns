using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abs.factory
{
    public class TruckFactory : IFactory
    {
        public IVehicle Create()
        {
            return new Truck
            {
                wheels = 6,
                model = "I am a truck"
            };
        }
    }
}
