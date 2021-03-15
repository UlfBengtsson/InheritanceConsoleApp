using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConsoleApp.Models
{
    internal class Teacher : Person
    {
        public List<string> Subjects { get; set; }
        public List<Student> Students { get; set; }
    }
}
