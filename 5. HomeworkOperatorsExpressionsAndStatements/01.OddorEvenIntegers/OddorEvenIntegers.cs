using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddorEvenIntegers
{
    class OddorEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("the number is: ");
            int n = int.Parse(Console.ReadLine());
            bool result = (n%2==1);
            Console.WriteLine(result);
        }
    }
}
