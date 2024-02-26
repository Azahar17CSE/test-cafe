using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public struct Vector
    {
        public double X {  get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y,
                Z = v1.Z + v2.Z

            };
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector
            {
                X = v1.X - v2.X,
                Y = v1.Y - v2.Y,
                Z = v1.Z - v2.Z

            };
        }
        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector
            {
                X = v1.Y * v2.Z-v1.Z*v2.Y,
                Y = v1.Z * v2.X-v1.X*v2.Z,
                Z = v1.X * v2.Y-v1.Y*v2.X
                
            };
        }
        public static Vector operator /(Vector v1, double scalar)
        {

            return new Vector
            {
                X = v1.X / scalar,
                Y = v1.Y / scalar,
                Z = v1.Z / scalar
            };
        }
        public override string ToString() => $"{X}, {Y}, {Z}";

    }
}
