using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? a = null;
            Console.WriteLine(a);
            double? b = null;
            Console.WriteLine(b);

            a= 11;
            Console.WriteLine(a);

            //int? test = new int ();
            //Console.WriteLine(test);
        }
       
    }
}
