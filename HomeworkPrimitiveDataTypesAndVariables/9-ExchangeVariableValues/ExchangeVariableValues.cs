using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before");
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

        }
    }
}
