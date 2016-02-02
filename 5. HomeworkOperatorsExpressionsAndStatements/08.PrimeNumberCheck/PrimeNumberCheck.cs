using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <=100; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            bool check = (count==2);
            Console.WriteLine(check);
        }
    }
}
