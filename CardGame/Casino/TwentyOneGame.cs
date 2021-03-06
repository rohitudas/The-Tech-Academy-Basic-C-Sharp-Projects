﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interface;

namespace Casino.TwentyOne
{
    public class TwentyOneGame: Game,IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(Dealer.Deck,3);

            foreach(Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.Write("Place your bet:");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer || bet < 0)
                    {
                        Console.WriteLine("Please enter Valid Digits without loose change or negative amount");
                        if (bet < 0) validAnswer = false;
                    }
                }
                
                bool sucessfullyBet = player.Bet(bet);
                if (!sucessfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i =0; i <2; i++)
            {
                Console.WriteLine("Dealing");
                foreach(Player player in Players)
                {
                    Console.Write("{0}:",player.Name);
                    Dealer.Deal(player.Hand);
                    if ( i == 1)
                    {
                        bool BlackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (BlackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer Has BlackJack! Everyone loses");
                        foreach (KeyValuePair<Player,int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your Cards are:");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write(" {0}",card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! you lose your bet of {1}. Your balance is now {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("DO you want to play agian?");
                        answer = Console.ReadLine().ToLower();
                        if(answer =="yes"||answer=="yea"||answer == "yeah")
                        {
                            player.IsActive = true;
                            return;
                        }
                        else
                        {
                            player.IsActive = false;
                            return;
                        }
                    }
                }
            }
            Dealer.istBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.istBusted)
            {
                Console.WriteLine("Dealer is Hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.istBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
                if (Dealer.istBusted)
                {
                    Console.WriteLine("Dealer Busted!");
                    foreach (KeyValuePair<Player,int> entry in Bets)
                    {
                        Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                        Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                        Dealer.Balance -= entry.Value;
                    }
                    return;
                }
            }
            foreach(Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if(playerWon == true)
                {
                    Console.Write("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Console.WriteLine(" Your balance is {0}", player.Balance);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];

                }
                Console.WriteLine("Play Again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.IsActive = true;
                }
                else
                {
                    player.IsActive = false;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
