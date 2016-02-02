using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.Write("a time in format “hh:mm tt”: ");

            string input = Console.ReadLine();
            DateTime currenttime;
            DateTime start = DateTime.Parse("1:00 PM");
            DateTime end = DateTime.Parse("3:00 AM");
            if (DateTime.TryParse(input, out currenttime))
            {
                if ((currenttime >= start) || (currenttime <= end))
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
