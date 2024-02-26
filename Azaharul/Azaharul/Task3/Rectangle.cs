using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Rectangle:IShape
    {
        public double W { get; set; }
        public double H { get; set; }

        public Rectangle(double w, double h)
        {
            W = w;
            H = h;
        }

        public double CalculateArea()
        {
            return W * H;
        }

        public double CalculatePerimeter()
        {
            return 2 * (W + H);
        }

    }
}
