using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearts
{
    internal class Computer : Player
    {
        private string cpuName;

        private Hand computerHand;

        private int lastSuit;



        // constructor
        public Computer(Hand gameHand, string name) : base(gameHand, name)
        {
            // Call the base class constructor to initialize playerHand and playerName
            cpuName = name;
        }


        public void ComputerPlay(ListView playersCards, Card lastPlayedCard)
        {
            if (playersCards.Items.Count == 0)
            {
                // no card left in hand so we end
                return;
            }
            if (lastPlayedCard == null) // check if last played card is null, if it is, cpu selects a card to play
            {
                // for now, just select the first card
                playersCards.Items[0].Selected = true;
            }
            else
            {
                lastSuit = lastPlayedCard.getSuitInt();
                List<Card> cards = new List<Card>();
                Card candidateCard = null;

                // Loop throguh all cards in the list and check for a matching suit card to select first
                for (int i = 0; i < playersCards.Items.Count; i++)
                {
                    ListViewItem item = playersCards.Items[i];
                    Card card = item.Tag as Card;
                    // Check if theres a matching suit
                    if (card.getSuitInt() == lastSuit)
                    {
                        if (candidateCard != null)
                        {
                            if (card.getRankInt() < candidateCard.getRankInt())
                            {
                                candidateCard = card;
                                playersCards.SelectedItems.Clear();
                                playersCards.Items[i].Selected = true; // select new candidate
                            }
                        }
                        else
                        {
                            candidateCard = card;
                            playersCards.SelectedItems.Clear();
                            playersCards.Items[i].Selected = true; // select inital candidate
                        }
                    }
                }
                // No matching suit found, loop through again and search for best throwaway card
                for (int i = 0; i < playersCards.Items.Count; i++)
                {
                    ListViewItem item = playersCards.Items[i];
                    Card card = item.Tag as Card;

                    if (candidateCard != null)
                    {
                        if (card.getRankInt() < candidateCard.getRankInt())
                        {
                            candidateCard = card;
                            playersCards.SelectedItems.Clear();
                            playersCards.Items[i].Selected = true;
                        }
                    }
                    else
                    {
                        candidateCard = card;
                        playersCards.SelectedItems.Clear();
                        playersCards.Items[i].Selected = true;
                    }
                }
            }
        }
    }
}
