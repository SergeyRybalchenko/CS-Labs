using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SecondLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа #2");
            Console.WriteLine("Выполнил - Рыбальченко Сергей");

            Console.WriteLine("\n________________ФИГУРЫ____________________________________________________");

            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник A",
                Width = 15.2,
                Height = 13.7
            };

            Rectangle b = new Rectangle()
            {
                Name = "Прямоугольник B",
                Width = 5.1,
                Height = 2.8
            };

            Circle circle = new Circle()
            {
                Name = "Круг A",
                radius = 10.0
            };

            Square square = new Square()
            {
                Name = "Квадрат А",
                side = 10.0
            };

            Triangle triangle = new Triangle()
            {
                Name = "Треугольник А",
                Base = 10.0,
                Height = 5.0
            };

            Trapezoid trapezoid = new Trapezoid()
            {
                Name = "Трапеция А",
                SecondBase = 10.0,
                FirstBase = 5.0,
                Height = 6.0
            };

            Rhombus rhombus = new Rhombus()
            {
                Name = "Ромб А",
                FirstDiagonal = 10.0,
                SecondDiagonal = 5.0
            };

            Parallelogram parallelogram = new Parallelogram()
            {
                Name = "Параллелограмм A",
                Base = 5.0,
                Height = 3.0
            };

            RegularPentagon regularPentagon = new RegularPentagon()
            {
                Name = "Правильный пятиугольник A",
                Side = 5.0
            };

            RegularDecagon regularDecagon = new RegularDecagon()
            {
                Name = "Правильный десятиугольник А",
                Side = 5.0
            };

            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", a.Name, a.GetArea());
            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", b.Name, b.GetArea());
            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", circle.Name, circle.GetArea());
            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", square.Name, square.GetArea());
            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", triangle.Name, triangle.GetArea());
            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", trapezoid.Name, trapezoid.GetArea());
            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", rhombus.Name, rhombus.GetArea());
            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", parallelogram.Name, parallelogram.GetArea());
            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", regularPentagon.Name, regularPentagon.GetArea());
            Console.WriteLine("\n Название фигуры - {0}, площадь фигуры - {1}", regularDecagon.Name, regularDecagon.GetArea());
        }
    }
}