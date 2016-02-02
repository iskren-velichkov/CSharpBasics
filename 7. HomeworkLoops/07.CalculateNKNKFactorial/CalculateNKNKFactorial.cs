using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateNKNKFactorial
{
    //using System; ???
    //System.Numerics
    

    class CalculateNKNKFactorial
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("n, k: ");
            string input = Console.ReadLine();
            int n;
            int k;
            System.Numerics.BigInteger factorialN = 1;
            System.Numerics.BigInteger factorialK = 1;
            //int diff = n - k;
            System.Numerics.BigInteger factorialDiff = 1;
            System.Numerics.BigInteger result;
            bool checkN = int.TryParse(input, out n);
            input = Console.ReadLine();
            bool checkK = int.TryParse(input, out k);
            if (checkK && checkN && k < n && k > 1 && k < 100 && n > 1 && n < 100)
            {
                int diff = n - k;
                for (int i = 2; i <= n; i++)
                {
                    factorialN *= i;
                    if (k >= i)
                    {
                        factorialK *= i;
                    }
                    if (diff >= i)
                    {
                        factorialDiff *= i;
                    }
                }
                //Console.WriteLine(factorialN);
                //Console.WriteLine(factorialK);
                //Console.WriteLine(factorialDiff);
                result = factorialN / (factorialK*factorialDiff);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
