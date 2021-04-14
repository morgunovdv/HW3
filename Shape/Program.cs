using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            Random y = new Random();

            double x1 = Convert.ToDouble(x.Next(10, 26));
            double y1 = Convert.ToDouble(y.Next(10, 26));

            Random rnd = new Random();
            double boxrnd = Convert.ToDouble(rnd.Next(1,101));

            
            Box box = new Box(boxrnd);



            Console.WriteLine("Выберите фигуру. \n 1) Пирамида \n 2) Цилиндр");
            int figures = int.Parse(Console.ReadLine());

            
                switch (figures)
                {
                    case 1:
                        Pyramid pyramid = new Pyramid(x1, y1);
                        double p = pyramid.Volume();

                        box.Add(pyramid);
                        Console.WriteLine($"Площадь пирамиды {p}");
                        break;

                    case 2:
                        Cylinder cylinder = new Cylinder(x1, y1);
                        double c = cylinder.Volume();

                        box.Add(cylinder);
                        Console.WriteLine($"Площадь цилиндра {c}");
                        break;

                    case 3:
                        Ball ball = new Ball(x1);
                        double s = ball.Volume();

                        box.Add(ball);
                        Console.WriteLine($"Радиус шара {s}");
                        break;

                    default:
                        Console.WriteLine("Фигура не выбрана");
                        break;
                
                
                }

            double b = box.Volume();

            Console.WriteLine($"Объем коробки {b}");

            Console.ReadKey();
        }
    }
}
