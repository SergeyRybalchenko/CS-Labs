using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSThirdLab
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

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + FirstBase / 2), (int)(Position.Y + Height / 2));
        }

        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[4];

            points[3] = new Point((int)Position.X + 0, (int)Position.Y + 0);
            points[2] = new Point((int)Position.X, (int)Position.Y + (int)Height);
            points[1] = new Point((int)Position.X + (int)SecondBase, (int)Position.Y + (int)Height);
            points[0] = new Point((int)Position.X + (int) + (int)FirstBase, (int)Position.Y + 0);

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}