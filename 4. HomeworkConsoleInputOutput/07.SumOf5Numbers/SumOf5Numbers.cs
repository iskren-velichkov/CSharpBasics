using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("enter 5 numbers: ");
            string [] numbers = Console.ReadLine().Split();
            double sum = 0;
            for (int i = 0; i <= 4; i++)
            {
                sum += Convert.ToDouble(numbers[i]);
            }
            Console.WriteLine("the sum is: {0}", sum);
        }
    }
}
