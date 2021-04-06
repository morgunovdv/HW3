using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Polygon
    {

        public List<Point> _points = new List<Point>();

        public string GetName()
        {
            string name;

            if (_points.Count == 3)
            {
               name = "Треугольник";
            }
            else if (_points.Count == 4)
            {
               name = "Четырехугольник";
            }
            else if (_points.Count == 5)
            {
               name = "Пятиугольник";
            }
            else
            {
               name =  "Данной фигуры нет в природе";
            }

            return name;
        }



        public Polygon(Point x, Point y, Point z)
        {
            _points.Add(x);
            _points.Add(y);
            _points.Add(z);
        }

        public Polygon(Point x, Point y, Point z, Point i) : this (x,y,z)
        {
            _points.Add(i);
        }

        public Polygon(Point x, Point y, Point z, Point i, Point m) : this (x,y,z,i)
        {
            _points.Add(m);
        }

        public double Perimeter()
        {
            int n = _points.Count;
            double sum = 0;
            for (int i=0; i<n-1; i++)
            {
                sum = sum + GetDistance(_points[i], _points[i+1]);
            }
            sum = sum + GetDistance(_points[0], _points[n-1]);
            
            return sum;
        }

        private double GetDistance(Point x, Point y)
        {
            double d = Math.Sqrt(Math.Pow((x.X - y.X), 2) + Math.Pow((x.Y - y.Y), 2));
            return d;
        }
    }
}
