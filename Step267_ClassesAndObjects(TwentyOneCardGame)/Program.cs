using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step267_ClassesAndObjects_TwentyOneCardGame_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;
            //Console.ReadLine();



            Deck deck = new Deck();
            deck.Shuffle(times: 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
