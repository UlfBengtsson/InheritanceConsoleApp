using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConsoleApp.Models
{
    internal class Person
    {
        private static int idCounter = 0;
        
        public readonly int id;
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public Person()
        {
            id = ++idCounter;
        }

        public Person(string name, string phone, int age) : this()
        {
            Name = name;
            Phone = phone;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id:{id} name:{Name} age: {Age} phone: {Phone}";
        }
    }
}
