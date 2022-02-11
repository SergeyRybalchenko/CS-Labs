using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SecondLab
{
    internal class RegularPentagon : Figure
    {
        public double Side { get; set; }
        public override double GetArea()
        {
            return Side * Side / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(5));
        }
    }
}
