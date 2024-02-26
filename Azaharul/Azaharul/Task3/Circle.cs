﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Circle:IShape
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public double CalculateArea()
        {
            return 3.1416 * Math.Pow(R, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * 3.1416 * R;
        }
    }
}
