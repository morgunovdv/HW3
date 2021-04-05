using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Polygon
    {

        private List<Point> _points = new List<Point>();

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

        //public int GetPerimetr()
        //{
        //    int p = a + b + c;
        //}

        private int GetDistance()
        {
            double a = Math.Sqrt(Math.Pow((_points[0].X - _points[1].X), 2) + Math.Pow((_points[0].Y - _points[1].Y), 2));

            return a;
        } 

        



    }
}
