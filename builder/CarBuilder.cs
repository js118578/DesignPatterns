using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class CarBuilder : IBuilder
    {
        private IVehicle car;
        public IVehicle Create()
        {
            car = new Car();
            CreateWheels();
            CreateModel();
            return car;
        }

        public void CreateModel()
        {
            car.Model = "I am a car.";
        }

        public void CreateWheels()
        {
            car.Wheels = 4;
        }
    }
}
