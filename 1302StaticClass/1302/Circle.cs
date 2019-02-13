using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1302
{
    sealed class Circle
    {

        // non-static room
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // static room
        public static double PIE = 3.14159;
        public static double dollar_rate;
        // this is static constructor
        static Circle()
        {
            Console.WriteLine("Hello world");
            dollar_rate = 3.78;
        }

        public void Draw()
        {

        }
    }
}
