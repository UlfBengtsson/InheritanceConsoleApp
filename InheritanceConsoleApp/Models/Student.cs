using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConsoleApp.Models
{
    internal class Student : Person
    {
        public List<string> Subjects { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Student(string name, string phone, int age) : base(name, phone, age) 
        {
            Subjects = new List<string>();
            Teachers = new List<Teacher>();
        }

        public new string ToString()//hides
        {
            return base.ToString() + $" Subjects: {Subjects.Count} Teachers: {Teachers.Count}";
        }
    }
}
