using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class SpaceShip<T> where T : class, new()
    {
        public T Speed { get; set; }
        public abstract object CloneShip();

        public SpaceShip(T speed)
        {
            Speed = speed;
        }
    }
}
