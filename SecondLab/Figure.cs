using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SecondLab
{
    internal abstract class Figure
    {
        public string Name { get; set; }

        public abstract double GetArea();
    }
}
