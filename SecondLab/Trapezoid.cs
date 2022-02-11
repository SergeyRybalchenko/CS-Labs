using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SecondLab
{
    internal class Trapezoid : Figure
    {
        public double FirstBase { get; set; } 
        public double SecondBase { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (FirstBase + SecondBase) * 0.5 * Height;
        }
    }
}
