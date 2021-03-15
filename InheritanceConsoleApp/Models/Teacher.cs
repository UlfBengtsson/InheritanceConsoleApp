using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConsoleApp.Models
{
    internal class Teacher : Person
    {
        public List<string> Subjects { get; set; }
        public List<Student> Students { get; set; }

        public Teacher(string name, string phone, int age) : base(name, phone, age)
        {
            Subjects = new List<string>();
            Students = new List<Student>();
        }

        public override string ToString()//allways overrides
        {
            return base.ToString() + $" Subjects: {Subjects.Count} Students: {Students.Count}";
        }
    }
}
