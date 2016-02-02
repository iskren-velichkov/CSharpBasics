using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object c = (a +" "+ b);
            Console.WriteLine(c);
            string d = c.ToString();
            Console.WriteLine(d);
        }
    }
}
