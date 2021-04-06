using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vector
{
    class Vector
    {
        public List<Vector> vectors = new List<Vector>();
        private int _x;
        private int _y;
        private int _z;

        public Vector(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        

        public int CalculateDistanceVector()
        {
            double d = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2) + Math.Pow(_z, 2));
            return Convert.ToInt32(d);
        }

        public int ScalarProduct()
        {
            int r =( (vectors[0]._x * vectors[1]._x) + 
                     (vectors[0]._y * vectors[1]._y) + 
                     (vectors[0]._z * vectors[1]._z) );
            return r;
        }

        public string CrossProduct()
        {
            string r = $"{(vectors[0]._y * vectors[1]._z) - (vectors[0]._z * vectors[1]._y)}, " +
                       $"{(vectors[0]._z * vectors[1]._x) - (vectors[0]._x * vectors[1]._z)}, " +
                       $"{(vectors[0]._x * vectors[1]._y) - (vectors[0]._y * vectors[1]._x)}";
            return r;
        }

        public string SumSub()
        {
            string r = ($"Суммы векторов: {vectors[0]._x + vectors[1]._x}, {vectors[0]._y + vectors[1]._y}, {vectors[0]._z + vectors[1]._z}. \nРазность векторов: {vectors[0]._x - vectors[1]._x}, {vectors[0]._y - vectors[1]._y}, {vectors[0]._z - vectors[1]._z}");

            return r;
        }   
    }
}
