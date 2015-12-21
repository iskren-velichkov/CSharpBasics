using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose a type: ");
            int user = int.Parse(Console.ReadLine());
            switch (user)
            {
                case 1:
                    Console.Write("enter a integer:");
                    int input1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(input1 + 1);
                    break;
                case 2:
                    Console.Write("enter a double:");
                    double input2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(input2 + 1);
                    break;
                case 3:
                    Console.WriteLine("enter a string: ");
                    string input3 = Console.ReadLine();
                    Console.WriteLine("{0}*", input3);
                    break;
                default: Console.WriteLine("invalid input"); break;
            }
        }
    }
}
