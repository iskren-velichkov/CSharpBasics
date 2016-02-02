using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = int.Parse(Console.ReadLine());
            int productOdd = 1;
            int productEven = 1;
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    productEven *= numbers[i];
                }
                else
                {
                    productOdd *= numbers[i];
                }
            }
            Console.WriteLine(productOdd);
            Console.WriteLine(productEven);
            if (productEven == productOdd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", productOdd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", productOdd);
                Console.WriteLine("even_product = {0}", productEven);
            }
        }
    }
}
