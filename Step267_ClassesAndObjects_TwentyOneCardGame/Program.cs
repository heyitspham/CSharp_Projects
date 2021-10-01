using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Step267_Casino_TwentyOneCardGame;
using Step267_Casino_TwentyOneCardGame.TwentyOne;

namespace Step267_ClassesAndObjects_TwentyOneCardGame
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

            //Deck deck = new Deck();
            //deck.Shuffle(times: 3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine($"{card.Face} of {card.Suit}");
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();


            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Administrator\source\repos\Basic_CSharp_Projects\Step267_Casino_TwentyOneCardGame\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }

                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}
