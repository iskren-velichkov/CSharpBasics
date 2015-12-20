using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter n (1 ≤ n ≤ 20): ");
            string input = Console.ReadLine();
            int n;
            if ((int.TryParse(input, out n)) && 1 <= n && n <= 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j <i+n; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
