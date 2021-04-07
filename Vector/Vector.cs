using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vector
{
    class Vector
    { 

        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }

        private double _x;
        private double _y;
        private double _z;

        public double X => _x;
        public double Y => _y;
        public double Z => _z;



        public Vector(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        

        public double CalculateDistance()
        {
            double d = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2) + Math.Pow(_z, 2));
            return d;
        }

        public static double ScalarProduct(Vector a, Vector b)
        {
            double r =( (b.X * a.X) + 
                        (b.Y * a.Y) + 
                        (b.Z * a.Z) );
            return r;
        }

        public static Vector CrossProduct(Vector a, Vector b)
        {
            Vector r = new Vector((a.Y * b.Z) - (a.Z * b.Y),(a.Z * b.X) - (a.X * b.Z), (a.X * b.Y) - (a.Y * b.X));
            return r;
        }

        public static double CalculateAngle(Vector a, Vector b)
        {
            double r = ScalarProduct(a, b);
            double g = a.CalculateDistance();
            double e = b.CalculateDistance();
            double t = g * e;
            return r / t;
            
        }

        public static Vector Sum(Vector a, Vector b)
        {
            Vector r = new Vector((a.X + b.X), (a.Y + b.Y), (a.Z + b.Z));
            return r;
        }

        public static Vector Sub(Vector a, Vector b)
        {
            Vector r = new Vector((a.X - b.X), (a.Y - b.Y), (a.Z - b.Z));
            return r;
        }
    }

    
}
