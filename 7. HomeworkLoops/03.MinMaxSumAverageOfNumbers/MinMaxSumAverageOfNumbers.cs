using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAverageOfNumbers
{
    class MinMaxSumAverageOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n:");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
                // Console.WriteLine(sum);
            }
            // Console.WriteLine(string.Join(", ",numbers));
            Console.WriteLine("mni: {0}", numbers.Min());
            Console.WriteLine("max: {0}", numbers.Max());
            Console.WriteLine("sum: {0}", sum);
            double avarage = ((double)sum / n);
            Console.WriteLine("avarage: {0:F2}", avarage);
        }
    }
}

