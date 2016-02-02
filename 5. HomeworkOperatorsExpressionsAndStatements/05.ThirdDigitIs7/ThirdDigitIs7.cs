using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = int.Parse(Console.ReadLine());
            int digit3 = (n / 100) % 10;
            Console.WriteLine(digit3);
            bool check = (digit3 == 7);
            Console.WriteLine(check);
        }
    }
}
