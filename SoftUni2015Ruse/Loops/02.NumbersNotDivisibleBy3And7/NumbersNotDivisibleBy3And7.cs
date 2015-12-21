using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            string line = Console.ReadLine();
            int n;
            bool input = int.TryParse(line, out n);
            if (input && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.Write("{0} ", i);
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
