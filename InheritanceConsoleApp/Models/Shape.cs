using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConsoleApp.Models
{
    internal class Shape
    {
        //width & height
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"width: {Width} & height: {Height}";
        }
    }
}
