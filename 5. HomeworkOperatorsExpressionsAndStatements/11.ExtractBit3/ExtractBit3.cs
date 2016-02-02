using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractBit3
{
    class ExtractBit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = int.Parse(Console.ReadLine());
            int nr3 = n >> 3;
            int bit = nr3 & 1;
            Console.WriteLine(bit);
        }
    }
}
