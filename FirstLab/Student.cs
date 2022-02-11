using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public string Faculty { get; set; }

        public void Add(Student s)
        {
            Name += s.Name;
            Surname += s.Surname;
            Age += s.Age;
            Course += s.Course;
            Faculty += s.Faculty;
        }

        public void AddTwo(Student s, Student s1)
        {
            Name += s.Name + s1.Name;
            Surname += s.Surname + s1.Surname;
            Age += s.Age + s1.Age;
            Course += s.Course + s1.Course;
            Faculty += s.Faculty + s1.Faculty;
        }
    }
}
