using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 1;
            int temp = 0;
            if (n == 0)
            {
                Console.WriteLine(" ");
            }
            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.Write("0, ");
                for (int i = 2; i <= n; i++)
                {
                    Console.Write("{0}, ", num2);
                    temp = num1;
                    num1 = num2;
                    num2 = temp + num1;
                }
            }
        }
    }
}
