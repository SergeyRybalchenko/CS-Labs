using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SecondLab
{
    internal class Triangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; } 

        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
