using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.InsideCircleOutsideRectangle
{
    class InsideCircleOutsideRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x, y: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r2 = 1.5*1.5;
            bool check1 = ((Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= r2);
            Console.WriteLine(check1);
            bool check2 = ((x > -1 && x < 5) && (y >= -1 && y <= 1));
            Console.WriteLine(check2);
            string result = (check1 == true && check2 == false ? "yes" : "no");
            Console.WriteLine(result);
        }
    }
}
