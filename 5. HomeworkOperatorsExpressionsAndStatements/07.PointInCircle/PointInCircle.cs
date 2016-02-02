using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x, y: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool check = (x*x+y*y<2*2);
            Console.WriteLine(check);
        }
    }
}
