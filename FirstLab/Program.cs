using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа #1 - Инкапсуляций");
            Console.WriteLine("Выполнил - Сергей Рыбальченко ВИС-32");
            Console.WriteLine("\n______________ Комплексные числа _______________\n");
            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };
            Complex c = new Complex() { Real = 1, Imag = 0.3 };
            Complex d = new Complex() { Real = 2, Imag = 0.5 };

            a.Add(b);
            b.Substract(a);
            c.Multiply(d);
            d.Divide(c);

            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);
            Console.WriteLine("c = {0} + {1}i", c.Real, c.Imag);
            Console.WriteLine("d = {0} + {1}i", d.Real, d.Imag);

            Console.WriteLine("\n______________ Студенты _______________\n");

            Student first = new Student() { Faculty = "Информатика", Course = 3, Age = 19, Name = "Антон", Surname = "Антонов" };
            Student second = new Student() { Faculty = "Экономика", Course = 2, Age = 18, Name = "Матвей", Surname = "Матвеев" };
            Student third = new Student() { Faculty = "Математика", Course = 1, Age = 17, Name = "Валентин", Surname = "Валентинов" };

            first.Add(second);
            second.AddTwo(first, third);

            Console.WriteLine("Имя - {0}, Фамилия - {1}, Возраст - {2}, Курс - {3}, Факультет - {4}", first.Name, first.Surname, first.Age, first.Course, first.Faculty);
            Console.WriteLine("Имя - {0}, Фамилия - {1}, Возраст - {2}, Курс - {3}, Факультет - {4}", second.Name, second.Surname, second.Age, second.Course, second.Faculty);
        }
    }
}
