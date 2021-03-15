using System;
using System.Collections.Generic;
using InheritanceConsoleApp.Models;

namespace InheritanceConsoleApp
{
    class Program
    {


        static void Main(string[] args)
        {
            School();
        }

        public static void School()
        {
            Teacher uffe = new Teacher("Ulf", "0123456", 39);

            Student ali = new Student("Ali", "321654", 34);
            Student sven = new Student("Sven", "7878654", 24);
            Student ola = new Student("Ola", "987654", 21);

            ali.Subjects.Add("C++");
            ali.Subjects.Add("C#");
            ali.Subjects.Add("HTML");

            uffe.Students.Add(ali);
            uffe.Students.Add(sven);
            uffe.Students.Add(ola);

            List<Person> schoolPeopleList = new List<Person>();

            schoolPeopleList.Add(uffe);
            schoolPeopleList.Add(ali);
            schoolPeopleList.Add(ola);
            schoolPeopleList.Add(sven);

            foreach (Person itemInList in schoolPeopleList)
            {
                if (itemInList is Student)//hide
                {
                    Console.WriteLine((itemInList as Student).ToString());
                }
                else
                {
                    Console.WriteLine(itemInList);//override
                }
            }

        }

        public static void ShapesAndCo()
        {
            /*
             1. Shape       - width & height
             2. Square      - Area = length^2
             3. Triangle    - Area = ½ × b × h
             4. Cube        - Area, Volyum = Length^3
            */

            Shape shape = new Shape(1.0, 1.0);

            Console.WriteLine(shape);

            Square square = new Square(2.5);

            Console.WriteLine(square);
        }
    }
}
