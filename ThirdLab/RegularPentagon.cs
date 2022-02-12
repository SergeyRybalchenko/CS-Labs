using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSThirdLab
{
    internal class RegularPentagon : Figure
    {
        public double Side { get; set; }
        public double Radius { get; set; } 
        public override double GetArea()
        {
            return Side * Side / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(5));
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y));
        }

        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[5];
            //Create 5 points
            for (int a = 0; a < 5; a++)
            {
                points[a] = new Point(
                    (int)(Position.X + Radius * (float)Math.Cos(a * 72 * Math.PI / 180f)),
                    (int)(Position.Y + Radius * (float)Math.Sin(a * 72 * Math.PI / 180f)));
            }

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
