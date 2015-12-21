using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2FloatOrDouble
{
    class CheckFloatOrDouble
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            decimal d = decimal.Parse(Console.ReadLine());
            float a = Convert.ToSingle(d);
            Console.WriteLine("as a float  is: {0}", a);
            double b = Convert.ToDouble(d);
            Console.WriteLine("as a double is: {0}", b);
            decimal A = Convert.ToDecimal(a);
            //Console.WriteLine(A);
            decimal B = Convert.ToDecimal(b);
           // Console.WriteLine(B);
            if (Math.Abs(A - B) == 0)
                Console.WriteLine("float and double are Equal - It is OK to use float");
            else
                Console.WriteLine("float and double are NOT Equal !!! - you must use double");
            

        }
    }
}
