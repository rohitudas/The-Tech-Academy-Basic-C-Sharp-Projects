using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = Deck.Cards.First().ToString() + "\n";
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\rohit\source\repos\The-Tech-Academy-Basic-C-Sharp-Projects\CardGame\CardGame\Log\logt.txt", true))
            {
                file.WriteLine(card);
                file.WriteLine(DateTime.Now);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
