using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConsoleApp.Models
{
    internal class Student : Person
    {
        public List<string> Subjects { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
