using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public interface IBuilder
    {
        void CreateWheels();
        void CreateModel();
        IVehicle Create();
    }
}
