﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class Motorcycle : IVehicle
    {
        public int Wheels { get; set; }
        public string Model { get; set; }
    }
}
