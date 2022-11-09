using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb3
{
    internal class Square : Geometry
    {
        public double _side { get; set; }

        public Square()
        {
            _side = 5.8d;
        }
        public Square(double side)
        {
            _side = side;
        }

        public override double Area()
        {
            return Math.Round(_side * _side, 2);
        }
    }
}
