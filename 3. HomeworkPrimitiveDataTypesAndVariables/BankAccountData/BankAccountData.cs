using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Jonny";
            string middleName = "Vivian";
            string lastName = "Bravo";
            double balance = 10200.30;
            string iban = "IBAN152SFO54945";
            long cadr1 = 2569844562;
            long cadr2 = 5698436952;
            long cadr3 = 8956325698;
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Middle name: {0}", middleName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Balance: {0}", balance);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Card1 number: {0}", cadr1);
            Console.WriteLine("Card2 number: {0}", cadr2);
            Console.WriteLine("Card3 number: {0}", cadr2);
        }
    }
}
