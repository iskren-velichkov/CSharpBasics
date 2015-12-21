using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 numbers");
            string line = Console.ReadLine();
            double a = double.Parse(line);
            line = Console.ReadLine();
            double b = double.Parse(line);
            line = Console.ReadLine();
            double c = double.Parse(line);
            double sum = a + b + c;
            Console.WriteLine("the sum is: {0}", sum);
        }
    }
}
