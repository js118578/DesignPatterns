using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abs.factory
{
    public class CarFactory : IFactory
    {
        public IVehicle Create()
        {
            return new Car 
            { 
                wheels = 4,
                model = "I am a car"
            };
        }
    }
}
