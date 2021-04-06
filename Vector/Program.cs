using System;
using System.Collections.Generic;

namespace Vector
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Vector a = new Vector(2, 4, 10);
            Vector b = new Vector(6, 10, 15);

            a.vectors.Add(a);
            a.vectors.Add(b);

            int e = a.CalculateDistanceVector();
            int g = a.ScalarProduct();
            string h = a.CrossProduct();
            string j = a.SumSub();


            Console.WriteLine($"Длинна вектора: {e}");
            Console.WriteLine($"Произведение с другим вектором: {h}");
            Console.WriteLine($"Скалярное произведение: {g}");
            Console.WriteLine(j);

            Console.ReadKey();
        }
    }
}
