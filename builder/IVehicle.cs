using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public interface IVehicle
    {
        int Wheels { get; set; }
        string Model { get; set; }
    }
}
