using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub4
{
    internal class Truck : Car
    {
        public Truck(string name, string color, int speed, int capaciy) : base(name, color, speed)
        {
            this.capacity = capaciy; 
        }
    }
}
