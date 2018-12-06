using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public abstract class Game
    {
        public string Dealer { get; set; }
        public int score { get; set; }
        public List<string> Players { get; set; }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
