using System;
using InheritanceConsoleApp.Models;

namespace InheritanceConsoleApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Person person = new Person("ulf","0123456", 39);

            Console.WriteLine(person);
        }

        public void School()
        {
            Teacher uffe = new Teacher();

            uffe.Name = "Ulf";
            uffe.Phone = "0123456";
            uffe.Age = 39;

            

            Console.WriteLine(uffe);
        }

        public void ShapesAndCo()
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
