using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n, p: ");
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int nRighTp = n >> p;
            int bit = nRighTp & 1;
            bool check = (bit==1);
            Console.WriteLine(check);
        }
    }
}
