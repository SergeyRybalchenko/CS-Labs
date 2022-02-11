using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSThirdLab
{
    internal class Rhombus : Figure
    {
        public double FirstDiagonal { get; set; }  
        public double SecondDiagonal { get; set; }

        public override double GetArea()
        {
            return FirstDiagonal + SecondDiagonal * 0.5;
        }

        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[4];
            points[0] = new Point((int)Position.X + 0, (int)Position.Y + (int)FirstDiagonal / 2);
            points[1] = new Point((int)Position.X + ((int)SecondDiagonal / 2), (int)Position.Y +  0);
            points[2] = new Point((int)Position.X + (int)SecondDiagonal, (int)Position.Y + ((int)FirstDiagonal / 2));
            points[3] = new Point((int)Position.X + ((int)SecondDiagonal / 2), (int)Position.Y + (int)FirstDiagonal);

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + FirstDiagonal / 2), (int)(Position.Y + SecondDiagonal / 2));
        }
    }
}
