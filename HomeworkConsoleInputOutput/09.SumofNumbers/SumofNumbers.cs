using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumofNumbers
{
    class SumofNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("sum: {0}",sum);
        }
    }
}
