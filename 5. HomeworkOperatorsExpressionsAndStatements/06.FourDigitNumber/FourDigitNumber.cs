using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4digit number: ");
            int n = int.Parse(Console.ReadLine());
            int n4 = n % 10;
            Console.WriteLine(n4);
            int n3 = (n/10) % 10;
            Console.WriteLine(n3);
            int n2 = (n/100) % 10;
            Console.WriteLine(n2);
            int n1 = (n/1000) % 10;
            Console.WriteLine(n1);
            int sum = n1 + n2 + n3 + n4;
            Console.WriteLine("sum of digits: {0}", sum);
            Console.WriteLine("{0}{1}{2}{3}", n4, n3, n2, n1);
            Console.WriteLine("{0}{1}{2}{3}", n4, n1, n2, n3);
            Console.WriteLine("{0}{1}{2}{3}", n1, n3, n2, n4);
        }
    }
}
