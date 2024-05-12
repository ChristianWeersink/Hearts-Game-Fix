using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{

    //03-24: Maybe change to public? We'll see.
    internal class Player
    {
        public Hand playerHand;
        private int heartsCount;
        private string playerName;

        public const int DEFAULT_HEART_AMOUNT = 0;

        public Player()
        {

        }

        /// <summary>
        /// Constructor for a player
        /// </summary>
        /// <param name="playerHand">Hand object for the player to hold</param>
        /// <param name="playerName">Name for player</param>
        public Player(Hand playerHand, string playerName)
        {
            setPlayerHand(playerHand);
            setHeartsCount(DEFAULT_HEART_AMOUNT);
            setPlayerName(playerName);
        }

        public void setPlayerHand(Hand playerHand)
        {
            this.playerHand = playerHand;
        }

        public void setHeartsCount(int heartsCount)
        {
            this.heartsCount = heartsCount;
        }

        public void setPlayerName(string playerName)
        {
            this.playerName = playerName;
        }

        public int getHeartsCount()
        {
            return this.heartsCount;
        }

        public string getPlayerName()
        {
            return this.playerName;
        }

        public Hand getHand()
        {
            return this.playerHand;
        }



        public void incrementHearts()
        {
            this.heartsCount++;
        }

        public void incrementHeartsBy5()
        {
            this.heartsCount += Card.QUEEN_OF_SPADES_POINTS;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="alistView"></param>
        /// <returns></returns>
        public Card playCard(System.Windows.Forms.ListView alistView)
        {
            Turn.turnsPlayed++;
            Card aCard = null;
            if (alistView.SelectedItems.Count == 1)
            {
                aCard = alistView.SelectedItems[0].Tag as Card;
                playerHand.removeCardFromHand(aCard);

                alistView.Items.Remove(alistView.SelectedItems[0]); // remove selected card
                alistView.SelectedItems.Clear(); // clear selected index

            }
            return aCard;
        }

    }
}
