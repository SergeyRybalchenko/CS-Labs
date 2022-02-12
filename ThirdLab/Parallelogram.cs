using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSThirdLab
{
    internal class Parallelogram : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Base * Height;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Base / 2), (int)(Position.Y + Height / 2));
        }

        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[4];

            points[0] = new Point((int)Position.X + 0, (int)Position.Y + 0);
            points[3] = new Point((int)Position.X + (int)Base, (int)Position.Y + 0);
            points[1] = new Point((int)Position.X + 10, (int)Position.Y + (int)Height);
            points[2] = new Point((int)Position.X + (int)Base + 10, (int)Position.Y + (int)Height);

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
