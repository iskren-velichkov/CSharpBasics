using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggestOf3Numbers
{
    class BiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double a;
            double b;
            double c;
            double check;
            double biggest;
            bool aInt = double.TryParse(input, out a);
            input = Console.ReadLine();
            bool bInt = double.TryParse(input, out b);
            input = Console.ReadLine();
            bool cInt = double.TryParse(input, out c);
            if (aInt && bInt && cInt)
            {
                if (a > b)
                {
                    check = a;
                }
                else
                {
                    check = b;
                }
                if (check > c)
                {
                    biggest = check;
                }
                else
                {
                    biggest = c;
                }
                Console.WriteLine(biggest);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
