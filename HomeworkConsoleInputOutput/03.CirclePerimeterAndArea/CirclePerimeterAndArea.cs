using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            double pi = 3.14159265359;
            Console.Write("enter r: ");
            string str = Console.ReadLine();
            double radius;
            if (double.TryParse(str, out radius) && radius>0)
            {
                //Console.WriteLine("Valid number: {0}", radius);
                Console.WriteLine("Circle Perimeter: {0:F2}", 2*pi*radius);
                Console.WriteLine("Circle Radius: {0:F2}", pi*radius*radius);
            }
            else
            {
                Console.WriteLine("Invalid number: {0}", str);
            }
        }
    }
}
