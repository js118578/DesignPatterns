using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class MotorcycleBuilder : IBuilder
    {
        private IVehicle Motorcycle;
        public IVehicle Create()
        {
            Motorcycle = new Motorcycle();
            CreateWheels();
            CreateModel();
            return Motorcycle;
        }

        public void CreateModel()
        {
            Motorcycle.Model = "I am a motorcycle.";
        }

        public void CreateWheels()
        {
            Motorcycle.Wheels = 2;
        }
    }
}
