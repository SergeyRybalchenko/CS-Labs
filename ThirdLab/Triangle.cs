using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSThirdLab
{
    internal class Triangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; } 

        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }

        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[3];
            points[0] = new Point((int)Position.X + 0, (int)Position.Y + 0);
            points[1] = new Point((int)Position.X + 0, (int)Position.Y + (int)this.Height);
            points[2] = new Point((int)Position.X + (int)this.Base, Position.Y + (int)this.Height);

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Base / 2), (int)(Position.Y + Height / 2));
        }
    }
}
