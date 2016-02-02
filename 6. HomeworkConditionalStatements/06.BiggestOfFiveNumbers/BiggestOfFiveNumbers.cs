using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BiggestOfFiveNumbers
{
    class BiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double biggest;
            if (a > b && a > c && a > d && a > e)
            {
                biggest = a;
                Console.WriteLine(biggest);
            }
            if (b > a && b > c && b > d && b > e)
            {
                biggest = b;
                Console.WriteLine(biggest);
            }
            if (c > a && c > b && c > d && c > e)
            {
                biggest = c;
                Console.WriteLine(biggest);
            }
            if (d > a && d > b && d > c && d > e)
            {
                biggest = d;
                Console.WriteLine(biggest);
            }
            if (e > a && e > b && e > c && e > d)
            {
                biggest = e;
                Console.WriteLine(biggest);
            }
            
        }
    }
}
