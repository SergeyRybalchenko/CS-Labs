using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSThirdLab

{
    internal class Square : Figure
    {
        public double side { get; set; }

        public override double GetArea()
        {
            return side * side;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + side / 2), (int)(Position.Y + side / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)(side), (int)(side));
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
