using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abs.factory
{
    public class MotorcycleFactory : IFactory
    {
        public IVehicle Create()
        {
            return new Motorcycle
            {
                wheels = 2,
                model = "I am a motorcycle"
            };
        }
    }
}
