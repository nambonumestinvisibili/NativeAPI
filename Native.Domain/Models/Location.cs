﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.Models
{
    public class Location : Entity
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public City City { get; set; }
    }
}
