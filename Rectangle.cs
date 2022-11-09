using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3
{
    internal class Rectangle : Geometry
    {
        public double _sideA { get; set; }
        public double _sideB { get; set; }

        public Rectangle()
        {
            _sideA = 3.5d;
            _sideB = 8;
        }
        public Rectangle(int sideA, int sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        public override double Area()
        {
            return Math.Round(_sideA * _sideB, 2);
        }
    }
}
