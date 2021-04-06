using System;
using System.Collections.Generic;

namespace HW3
{
    class Program
    {

        static void Main(string[] args)
        {
            Point x = new Point(30, 40, "X");
            Point y = new Point(60, 80, "Y");
            Point z = new Point(90, 110, "Z");


            Polygon triangle = new Polygon(x, y, z);

            string name = triangle.GetName();
            double perimetr = triangle.Perimeter();

            Console.WriteLine($"Ваша фигура: {name} и его периметр равен: {perimetr}");
            Console.ReadKey();

        }
    }
}
