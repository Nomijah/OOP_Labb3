using System;

namespace OOP_Labb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry a = new Rectangle();
            Geometry b = new Circle();
            Geometry c = new Square();

            Console.WriteLine("Rectangle area: " + a.Area() + " cm2");
            Console.WriteLine("Circle area: " + b.Area() + " cm2");
            Console.WriteLine("Square area: " + c.Area() + " cm2");
        }
    }
}
