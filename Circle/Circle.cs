using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Circle           //Class
    {
        public float _pi = 3.141f;
        public int _radius;


     
        public Circle(float Pi, int Rad)    //Constructor
        {
            _pi = Pi;
            _radius = Rad;
            
        }
              
        public void getArea()       //method
        {                      
            Console.WriteLine("Arean är: {0}",_radius * _radius * _pi);
        }
    }        
}
