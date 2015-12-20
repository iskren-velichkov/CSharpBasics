using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            System.Numerics.BigInteger fact2N = 1;
            System.Numerics.BigInteger factN1 = 1;
            System.Numerics.BigInteger factN = 1;
            System.Numerics.BigInteger result;
            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else if (n > 1 && n < 100)
            {
                for (int i = 1; i <= 2 * n; i++)
                {
                    fact2N *= i;
                    if (i <= (n + 1))
                    {
                        factN1 *= i;
                    }
                    if (i <= n)
                    {
                        factN *= i;
                    }
                }
                result = fact2N / (factN1 * factN);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
