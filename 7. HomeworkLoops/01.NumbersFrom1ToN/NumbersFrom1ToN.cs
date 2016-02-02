using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            string line = Console.ReadLine();
            int n;
            bool input = int.TryParse(line, out n);
            if (input && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", i);
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
