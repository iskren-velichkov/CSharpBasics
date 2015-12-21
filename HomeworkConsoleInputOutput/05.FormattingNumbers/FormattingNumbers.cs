using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int a = int.Parse(line);
            line = Console.ReadLine();
            double b = double.Parse(line);
            line = Console.ReadLine();
            double c = double.Parse(line);
            string a1 = Convert.ToString(a, 2);
            Console.WriteLine("|{0,-10:X}|{1}|{2,10:F1}|{3,-10:F3}|" ,a, a1.PadLeft(10, '0'), b, c);
        }
    }
}
