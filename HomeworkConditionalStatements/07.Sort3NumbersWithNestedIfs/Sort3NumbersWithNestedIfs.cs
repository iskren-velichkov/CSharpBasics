using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.Write("{0} ", a);
                if (b > c)
                {
                    Console.WriteLine("{0} {1}", b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1}", c, b);
                }
            }
            if (b > a && b > c)
            {
                Console.Write("{0} ", b);
                if (a > c)
                {
                    Console.WriteLine("{0} {1}", a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1}", c, a);
                }
            }
            if (c > a && c > b)
            {
                Console.Write("{0} ", c);
                if (a > b)
                {
                    Console.WriteLine("{0} {1}", a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1}", b, a);
                }
            }
        }
    }
}
