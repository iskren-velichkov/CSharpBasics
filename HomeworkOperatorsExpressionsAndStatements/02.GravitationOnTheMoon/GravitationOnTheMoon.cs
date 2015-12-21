using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.Write("weight on the Earth: ");
            double earth = double.Parse(Console.ReadLine());
            double moon = earth * 0.17;
            Console.WriteLine(moon);
        }
    }
}
