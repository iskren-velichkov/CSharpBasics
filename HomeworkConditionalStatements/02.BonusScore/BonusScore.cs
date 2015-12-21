using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int score;
            int result;
            bool check = int.TryParse(input, out score);
            if (check==true && score >0 && score <10)
            {
                if (score >= 1 && score <= 3)
                {
                    result = 10 * score;
                    Console.WriteLine(result);
                }
                else if (score >= 4 && score <= 6)
                {
                    result = 100 * score;
                    Console.WriteLine(result);
                }
                else if (score >= 7 && score <= 9)
                {
                    result = 1000 * score;
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("invalid input or score");
            }
        }
    }
}
