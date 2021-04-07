using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Box : Shape
    {
        private double _h;

        public Box(double h)
        {
            _h = h;
        }

        public bool Add(Shape shape)
        {
            

            if (Volume() > shape.Volume())
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public override double Volume()
        {
            double V = Math.Pow(_h, 3);
            return V;
        }
    }
}
