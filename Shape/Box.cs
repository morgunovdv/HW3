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
        private double _freeVolume;
        private List<Shape> _shapes = new List<Shape>();
        

        public Box(double h)
        {
            _h = h;
            _freeVolume = Volume();
        }

        private void PrintShapesInfo()
        {
            ;
        }




        public bool Add(Shape shape)
        {
            

            if (_freeVolume > shape.Volume())
            {
                _freeVolume -= shape.Volume();
                _shapes.Add(shape);

                Console.WriteLine($"Оставшийся объем коробки {_freeVolume}, {shape} ");
                return true;
            } 
            else
            {
                Console.WriteLine("Фигура не вмещается");
                return false;
            }
        }

        public override double Volume()
        {
            double V = Math.Pow(_h, 3);
            return V;
        }

        public override string ToString()
        {
            return "Куб";
        }
    }
}
