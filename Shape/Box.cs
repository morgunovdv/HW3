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

        public Box(double h)
        {
            _h = h;
            _freeVolume = Volume();
        }

        

        public bool Add(Shape shape)
        {
            //List<Shape> shapes = new List<Shape>();


            //while (Volume()> shape.Volume())
            //{
            //    
            //   
            //    
            //    break;
            //}

            

            if (_freeVolume > shape.Volume())
            {
                _freeVolume -= shape.Volume();
                //shapes.Add(shape);
                Console.WriteLine($"Оставшийся объем коробки {_freeVolume}");
                
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

        

    }
}
