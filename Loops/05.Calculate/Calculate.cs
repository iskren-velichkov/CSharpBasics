using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n, x: ");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1;
            decimal factorial = 1;
            decimal delitel = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                delitel *= x;
                sum = sum + (factorial / delitel);
            }
            //Console.WriteLine(factorial);
            Console.WriteLine("{0:F5}",sum);
        }
    }
}
