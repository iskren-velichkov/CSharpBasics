using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("trapezoid a, b, h:");
            string line = Console.ReadLine(); 
            double a = double.Parse(line);
            line = Console.ReadLine();
            double b = double.Parse(line);
            line = Console.ReadLine();
            double h = double.Parse(line);
            double area = ((a + b) / 2) * h;
            Console.WriteLine(area);

        }
    }
}
