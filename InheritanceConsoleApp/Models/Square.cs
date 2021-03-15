using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConsoleApp.Models
{
    internal class Square : Shape
    {

        public double Area
        {
            get
            {
                return Width * Height;
            } 
        }

        public Square(double length) : base(length, length) {}

        public override string ToString()
        {
            return "Square - " + base.ToString() + " & Area: " + Area;
        }

    }
}
