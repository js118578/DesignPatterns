using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class VehicleBuilder
    {
        public IVehicle CreateCar()
        {
            IBuilder carbuilder = new CarBuilder();
            return carbuilder.Create();
        }
        public IVehicle CreateMotorcycle()
        {
            IBuilder motorcyclebuilder = new MotorcycleBuilder();
            return motorcyclebuilder.Create();
        }
        public IVehicle CreateTruck()
        {
            IBuilder truckbuilder = new TruckBuilder();
            return truckbuilder.Create();
        }
    }
}
