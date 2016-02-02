using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n, p, v: ");
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            
            if ( v == 0)
            {
                int mask = ~(1 << p);      // p to 0
                int result = n & mask;     
                Console.WriteLine(result); 
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            }
            if (v ==1)
            {
                int mask = 1 << p;          // p to 1
                int result = n | mask;      
                Console.WriteLine(result);  
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            }
        }
    }
}
