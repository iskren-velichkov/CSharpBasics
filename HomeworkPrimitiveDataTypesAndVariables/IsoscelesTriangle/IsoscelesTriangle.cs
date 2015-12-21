using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char copyR = '\u00A9';
            Console.WriteLine(copyR);
            //
            string triangle = @"
   ©
  © ©
 ©   ©
© © © ©
";
            Console.WriteLine(triangle);
            Console.WriteLine("   {0}", copyR);
            Console.WriteLine("  {0} {0}", copyR);
            Console.WriteLine(" {0}   {0}", copyR);
            Console.WriteLine("{0} {0} {0} {0}", copyR);

        }
    }
}
