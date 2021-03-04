using System;

namespace Geometri_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(3);
            Console.WriteLine(square.Omkreds());
            Console.WriteLine(square.Areal());

            Rectangle rectangle = new Rectangle(2, 5);
            Console.WriteLine(rectangle.Areal());
            Console.WriteLine(rectangle.Omkreds());

            Trapez trapez = new Trapez(5, 9, 7, 10);
            Console.WriteLine(trapez.Omkreds());
            Console.WriteLine(trapez.Areal());

            Parallelogram paral = new Parallelogram(6, 1, 15);
            Console.WriteLine(paral.Areal());

            RightAngledTriangle right = new RightAngledTriangle(2, 6);

            Console.WriteLine(right.Areal());
            Console.WriteLine(right.Omkreds());
        }
    }
}
