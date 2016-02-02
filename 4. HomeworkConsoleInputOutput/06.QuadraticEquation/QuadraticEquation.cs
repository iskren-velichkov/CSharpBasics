using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax2 + bx + c = 0 - enter a, b, and c");
            string input = Console.ReadLine();
            double a = double.Parse(input);
            input = Console.ReadLine();
            double b = double.Parse(input);
            input = Console.ReadLine();
            double c = double.Parse(input);
            double d = b * b - 4 * a * c;
            double dSqrt = Math.Sqrt(d);
            if (d > 0)
            {
                double x1 = (-b - dSqrt)/(2*a);
                double x2 = (-b + dSqrt)/(2*a);
                Console.WriteLine("x1 = {0} and x2 = {1}", x1, x2);
            }
            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
            if (d == 0)
            {
                double x1 = (-b / (2 * a));
                Console.WriteLine("Repeated roots : {0}", x1);
            }
        }
    }
}
