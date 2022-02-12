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
                Name = "Квадрат",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(50,200),
                Width = 100, Height = 50
            },

            new Circle()
            {
                Name = "Круг",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(70, 100),
                radius = 50
            },

            new Triangle()
            {
                Name = "Треугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point (200, 100),
                Height = 50,
                Base = 50
            },

            new Rhombus()
            {
                Name = "Ромб",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point (200, 200),
                FirstDiagonal = 50,
                SecondDiagonal = 40
            }, 

            new Square()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point (300, 100),
                side = 50
            },

            new Parallelogram()
            {
                Name = "Параллелограмм",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point (300, 200),
                Base = 50,
                Height = 50
            }, 
            
            new RegularPentagon()
            {
                Name = "Правильный пятиугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point (100, 350),
                Side = 50,
                Radius = 50
            },

            new RegularDecagon()
            {
                Name = "Правильный десятиугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point (250, 350),
                Side = 50,
                Radius = 50
            },

            new Trapezoid()
            {
                Name = "Трапеция",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point (350, 350),
                FirstBase = 50,
                SecondBase = 30,
                Height = 50
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
