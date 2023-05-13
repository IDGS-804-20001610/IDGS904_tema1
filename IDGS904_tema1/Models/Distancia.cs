﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Distancia
    {
        public int x1 { get; set; }
        public int y1 { get; set; }

        public int x2 { get; set; }
        public int y2 { get; set; }
        public double Res { get; set; }

        public double Distance()
        {
            return Math.Sqrt(Math.Pow(x2-x1,2)+(Math.Pow(y2-y1,2)));
        }
    }
}