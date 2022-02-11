using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SecondLab
{
    internal class Square : Figure
    {
        public double side { get; set; }

        public override double GetArea()
        {
            return side * side;
        }
    }
}
