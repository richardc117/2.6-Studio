using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6_Studio
{
    class Circle
    {
        const double pi = 3.14;
        public double radius { get; set; }
        public double area;

        public void GetArea()
        {
            area = pi * radius * radius;
        }
    }
}
