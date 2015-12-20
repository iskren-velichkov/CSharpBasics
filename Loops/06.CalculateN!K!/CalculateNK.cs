using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateN_K_
{
    class CalculateNK
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n, k: ");
            string input = Console.ReadLine();
            int n;
            int k;
            int factorialN = 1;
            int factorialK = 1;
            double result;
            bool checkN = int.TryParse(input, out n);
            input = Console.ReadLine();
            bool checkK = int.TryParse(input, out k);
            if (checkK && checkN && k < n && k > 1 && k < 100 && n > 1 && n < 100)
            {
                for (int i = 2; i <= n; i++)
                {
                    factorialN *= i;
                    if (k >= i)
                    {
                        factorialK *= i;
                    }
                }
                result = factorialN / factorialK;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
