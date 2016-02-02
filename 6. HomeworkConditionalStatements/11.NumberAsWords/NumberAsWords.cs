using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number 0-999");
            string input = Console.ReadLine();
            int number;
            string word;
            if (int.TryParse(input, out number))
            {
                if (number >= 0 && number <= 999)
                {
                    if (number >= 100)
                    {
                        int hundreds = number / 100;
                        //Console.WriteLine(a);
                        switch (hundreds)
                        {
                            case 1: Console.Write("One hundred and "); break;
                            case 2: Console.Write("Two hundred and "); break;
                            case 3: Console.Write("Three hundred and "); break;
                            case 4: Console.Write("Four hundred and "); break;
                            case 5: Console.Write("Five hundred and "); break;
                            case 6: Console.Write("Six hundred and "); break;
                            case 7: Console.Write("Seven hundred and "); break;
                            case 8: Console.Write("Eight hundred and "); break;
                            case 9: Console.Write("Nine hundred and "); break;
                        }
                        number = number % 100;
                       // Console.WriteLine(number);
                    }
                    if (number >= 20)
                    {
                        int tens = number / 10;
                        //Console.WriteLine(a);
                        switch (tens)
                        {
                            case 2: Console.Write("twenty "); break;
                            case 3: Console.Write("thirty "); break;
                            case 4: Console.Write("fourty "); break;
                            case 5: Console.Write("fivety "); break;
                            case 6: Console.Write("sixty "); break;
                            case 7: Console.Write("seventy "); break;
                            case 8: Console.Write("eightty "); break;
                            case 9: Console.Write("ninety "); break;
                        }
                        number = number % 10;
                        //Console.WriteLine(number);
                    }
                    if (number < 20)
                    {
                        int tens = number / 10;
                        //Console.WriteLine(a);
                        switch (number)
                        {
                            case 1: Console.Write("0ne"); break;
                            case 2: Console.Write("two"); break;
                            case 3: Console.Write("three"); break;
                            case 4: Console.Write("four"); break;
                            case 5: Console.Write("five"); break;
                            case 6: Console.Write("six"); break;
                            case 7: Console.Write("seven"); break;
                            case 8: Console.Write("eight"); break;
                            case 9: Console.Write("nine"); break;
                            case 10: Console.Write("ten"); break;
                            case 11: Console.Write("eleven"); break;
                            case 12: Console.Write("twelve"); break;
                            case 13: Console.Write("thirteen"); break;
                            case 14: Console.Write("fourteen"); break;
                            case 15: Console.Write("fiveteen"); break;
                            case 16: Console.Write("sixteen"); break;
                            case 17: Console.Write("seventeen"); break;
                            case 18: Console.Write("eighteen"); break;
                            case 19: Console.Write("nineteen"); break;
                        }
                        Console.WriteLine();
                       
                    }
                }
                else
                {
                    Console.WriteLine("number not in range");
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
