using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        public List<Card> Cards { get; set; }
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string> { "Clubs", "Hearts", "Diamonds", "Spades" };

            List<string> Faces = new List<string>()
                {
                    "Two","Three", "Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King","Ace"

                };
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);

                }
            }

        }

        public Deck Shuffle(Deck deck, int ShuffleTimes = 1)
        {

            for(int i = 0; i < ShuffleTimes;i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    

                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
           
            return deck;

        }

        

    }
}
