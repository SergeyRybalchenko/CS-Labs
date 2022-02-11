using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SecondLab
{
    internal class Circle : Figure
    {
        public double radius { get; set; }

        public override double GetArea()
        {
            return radius*radius*3.14;
        }
    }
}
