using System;
using System.Collections.Generic;

namespace ZooBreakout.Models 
{
    public class Deck
    {
        public List<int> Cards { get; set; } = new List<int>();

        // constructor for infinite play
        public Deck(int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++) 
            {
                Random r = new Random();
                Cards.Add(r.Next(0, 2));
            }
        }

        // constructor used for the first and second round razor pages
        public Deck(int roundpage, int round)
        {
            if (roundpage == 1)
            {
                switch(round)
                {
                    case 0:
                        Cards = new List<int> {0, 1, 1, 1, 1}; break;
                    case 1:
                        Cards = new List<int> {0, 1, 1, 0, 0}; break;
                    case 2:
                        Cards = new List<int> {0, 0, 1, 0, 1}; break;
                    case 3:
                        Cards = new List<int> {0, 0, 0, 0, 0}; break;
                    case 4:
                        Cards = new List<int> {0, 1, 1, 1, 0}; break;
                    default: break;
                }
            }
            else
            {
                switch(round)
                {
                    case 0:
                        Cards = new List<int> {0, 1, 1, 1, 1, 0, 0}; break;
                    case 1:
                        Cards = new List<int> {0, 1, 1, 0, 0, 1, 0}; break;
                    case 2:
                        Cards = new List<int> {0, 0, 0, 0, 1, 0, 1}; break;
                    case 3:
                        Cards = new List<int> {0, 0, 0, 0, 0, 0, 0}; break;
                    case 4:
                        Cards = new List<int> {0, 1, 1, 1, 0, 0, 0}; break;
                    default: break;
                }
            }
        }

        public void ChangeCard(int card)
        {
            if (Cards[card] == 0)
            {
                Cards[card] = 2;
                if (card != 0)
                {
                    if (Cards[card-1] != 2)
                        Cards[card-1] = 1 - Cards[card-1];
                }
                if (card != Cards.Count-1)
                {
                    if (Cards[card+1] != 2)
                        Cards[card+1] = 1 - Cards[card+1];
                }
            }
        }

        private bool DeckEmpty()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                if (Cards[i] == 0 || Cards[i] == 1)
                    return false;
            }
            return true;
        }

        public bool CheckWin()
        {
            return DeckEmpty();
        }

        public bool WinPossible(int option)
        {
            int faceUp = 0;
            for (int i = 0; i < Cards.Count; i++)
            {
                if (Cards[i] == 0)
                    faceUp++;
            }
            if (option == 1)
                return (faceUp % 2 != 0 && faceUp != 0);
            else
                return (faceUp != 0);
        }

        public void PrintDeck()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                Console.WriteLine(Cards[i]);
            }
        }
    }
}