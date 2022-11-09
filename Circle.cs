using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3
{
    internal class Circle : Geometry
    {
        public double _radius { get; set; }

        public Circle()
        {
            _radius = 3.7d;
        }
        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return Math.Round(_radius * _radius * 3.14d, 2);
        }
    }
}
