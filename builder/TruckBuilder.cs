using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class TruckBuilder : IBuilder
    {
        private IVehicle Truck;
        public IVehicle Create()
        {
            Truck = new Truck();
            CreateWheels();
            CreateModel();
            return Truck;
        }

        public void CreateModel()
        {
            Truck.Model = "I am a truck.";
        }

        public void CreateWheels()
        {
            Truck.Wheels = 6;
        }
    }
}
