using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DeckOf52Cards
{
    class PrDeckOf52Cardsogram
    {
        static void Main(string[] args)
        {
            //clubs ♠
            //diamonds ♦
            //hearts ♥
            //spades ♣
            //for (int i = 2; i <= 10; i++)
            //{
            //    Console.WriteLine("{0}♠ {0}♦ {0}♥ {0}♣", i);
            //}
            //Console.WriteLine("J♠ J♦ J♥ J♣");
            //Console.WriteLine("Q♠ Q♦ Q♥ Q♣");
            //Console.WriteLine("K♠ K♦ K♥ K♣");
            //Console.WriteLine("A♠ A♦ A♥ A♣");

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int[] colors = { 3, 4, 5, 6 };

            foreach (var card in cards)
            {
                foreach (var color in colors)
                {
                    Console.Write(card);
                    Console.Write("{0} ", (char)color);
                }

                Console.WriteLine();
            }
        }
    }
}