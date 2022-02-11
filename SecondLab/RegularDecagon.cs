using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SecondLab
{
    internal class RegularDecagon : Figure
    {
        public double Side { get; set; }

        public override double GetArea()
        {
            return Side * Side * 5 / 2 * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }
    }
}
