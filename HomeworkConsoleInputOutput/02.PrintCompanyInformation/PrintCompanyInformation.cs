using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name:");
            string line = Console.ReadLine();
            string companyName = line;
            Console.Write("Company address:");
            line = Console.ReadLine();
            Console.Write("Phone number:");
            line = Console.ReadLine();
            Console.Write("Fax number:");
            line = Console.ReadLine();
            if (line == string.Empty)
            {
                line = "(no fax)";
                Console.WriteLine(line);
            }
            
            Console.Write("Web site:");
            line = Console.ReadLine();
            Console.Write("Manager first name:");
            line = Console.ReadLine();
            Console.Write("Manager last name:");
            line = Console.ReadLine();
            Console.Write("Manager age:");
            line = Console.ReadLine();
            Console.Write("Manager phone:");
        }
    }
}
