using System;
using System.Collections.Generic;

namespace Vector
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Random x = new Random();
            double x1 = Convert.ToDouble(x.Next(10, 26));
            double x2 = Convert.ToDouble(x.Next(10, 26));
            Random y = new Random();
            double y1 = Convert.ToDouble(y.Next(10, 26));
            double y2 = Convert.ToDouble(y.Next(10, 26));
            Random z = new Random();
            double z1 = Convert.ToDouble(z.Next(10, 26));
            double z2 = Convert.ToDouble(z.Next(10, 26));

            Vector a = new Vector(x1, y1, z1);
            Vector b = new Vector(x2, y2, z2);  

            double e = a.CalculateDistance();
            double d = b.CalculateDistance();
            double g = Vector.ScalarProduct(a,b);
            Vector h = Vector.CrossProduct(a, b);
            Vector j = Vector.Sum(a, b);
            Vector t = Vector.Sub(a, b);


            Console.WriteLine($"Исходный вектор А: {a}");
            Console.WriteLine($"Исходный вектор Б: {b}");
            Console.WriteLine("=======================");
            Console.WriteLine($"Длина вектора А: {e}");
            Console.WriteLine($"Длина вектора Б: {d}");
            Console.WriteLine($"Векторное произведение: {h}");
            Console.WriteLine($"Скалярное произведение: {g}");
            Console.WriteLine($"Сумма векторов: {j}");
            Console.WriteLine($"Разность векторов: {t}");

            Console.ReadKey();
        }
    }
}
