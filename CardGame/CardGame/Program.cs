using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\rohit\OneDrive\Desktop\testLog\log.txt");
            File.WriteAllText(@"C:\Users\rohit\OneDrive\Desktop\testLog\log.txt", text);

            Console.WriteLine("Welcome lets play. What is your name?:");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much did you bring to spend:");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}! Would you like to join a game fo 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "yaeh" || answer == "yse")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.IsActive = true;
                while(player.IsActive && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
                
            }
            Console.WriteLine("Feel free to look around. Bye for now!");
            Console.ReadLine();
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

        }

    }
}
