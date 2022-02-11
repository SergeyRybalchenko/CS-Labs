using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SecondLab
{
    internal class Rhombus : Figure
    {
        public double FirstDiagonal { get; set; }  
        public double SecondDiagonal { get; set; }

        public override double GetArea()
        {
            return FirstDiagonal + SecondDiagonal * 0.5;
        }
    }
}
