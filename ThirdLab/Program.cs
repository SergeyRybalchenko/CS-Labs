using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSThirdLab
{
    internal class Program
    {
        public static Figure[] figures =
        {
            new Rectangle()
            {
                Name = "Квадрат #1",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30,30),
                Width = 50, Height = 50
            },

            new Rectangle()
            {
                Name = "Квадрат #2",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(60,100),
                Width = 100, Height = 100
            },

            new Rectangle()
            {
                Name = "Квадрат #3",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(200,200),
                Width = 100, Height = 50
            },

            new Circle()
            {
                Name = "Круг",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(400, 300),
                radius = 50
            },

            new Triangle()
            {
                Name = "Треугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point (500, 50),
                Height = 50,
                Base = 50
            },

            new Rhombus()
            {
                Name = "Ромб",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point (500, 200),
                FirstDiagonal = 50,
                SecondDiagonal = 40
            }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа #3 - Полиморфизм");
            Console.WriteLine("Выполнил - Рыбальченко Сергей");
      
            Form frm = new Form()
            {
                Text = "Лабораторная работа #3 - Полиморфизм",
                Size = new System.Drawing.Size(800,600),
                StartPosition = FormStartPosition.CenterScreen
            };

            frm.Paint += Frm_Paint;

            Application.Run(frm);
        }

        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}
