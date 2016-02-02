using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            int count = 0;
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (a < 0)
                {
                    count++;
                }
                else if (b < 0)
                {
                    count++;
                }
                else if (c < 0)
                {
                    count++;
                }
                if (count % 2 != 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}
