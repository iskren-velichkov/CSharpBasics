using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n and p: ");
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int nRighTp = n >> p;
            int bit = nRighTp & 1;
            Console.WriteLine(bit);
        }
    }
}
