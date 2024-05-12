using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hearts
{
    /// <summary>
    /// most game logic will be determined by turn methods
    /// class is static, we do not neet to create an object for the turn
    /// </summary>
    internal static class Turn
    {
        /// <summary>
        /// Turn counter that goes to 14 when both players have played all of their cards
        /// </summary>
        public static int turnCount = 0;
        /// <summary>
        /// Counter up to two to check when both players have played a card
        /// </summary>
        public static int turnsPlayed = 0;

        /// <summary>
        /// Determine first player for the round
        /// </summary>
        /// <param name="player1">First player to check hand for</param>
        /// <param name="player2"> second player to check hand for</param>
        /// <returns>1 if first player's hand contians 2 of spades, 2 if 2nd player's hand does, and 0 if neither contain two of spades</returns>
        public static int firstTurn(Player player1, Player player2)
        {
            int playersTurn = 0;
            for (int i = 0; i < player1.playerHand.count(); i++)
            {
                if (Deck.isTwoOfSpades(player1.playerHand.getCardFromHand(i))) {
                    playersTurn = 1; 

                }
                else if (Deck.isTwoOfSpades(player2.playerHand.getCardFromHand(i)))
                {
                    playersTurn = 2;
                   
                }
            }
            return playersTurn;
        }


        /// <summary>
        /// Determine turn "winner", being the player with the trump card
        /// </summary>
        /// <param name="player1Card">Card selected by player 1 to check</param>
        /// <param name="player2Card">Card selected by player 2 to check</param>
        /// <returns>1 if player1 card is winner, 2 if player 2 card is winner, 0 if no card was found to be the winner</returns>
        public static Card winningCard(Card player1Card, Card player2Card, bool player1PlayedFirst)
        {
            Card winningCard = null;
            int player1Rank = player1Card.getRankInt();
            int player2Rank = player2Card.getRankInt();
            int player1Suit = player1Card.getSuitInt();
            int player2Suit = player2Card.getSuitInt();

            if(player1Suit == player2Suit)
            {
                if (player1Rank > player2Rank) // check if player 1 card rank is higher
                {
                    winningCard = player1Card;
                }
                else if (player1Rank < player2Rank) // check if player 2 card rank is higher
                {
                    winningCard = player2Card;
                }
            }
            else if(player1Suit != player2Suit)
            {
                if (player1PlayedFirst)
                {
                    winningCard = player1Card;
                }
                else if (!player1PlayedFirst)
                {
                    winningCard = player2Card;
                }
                else
                {
                    winningCard = null;
                }
            }
             else
             {
                winningCard = null;
             }
            turnsPlayed = 0; // reset number of players that have played this round
            
            return winningCard;
        }

        

        

    }
}
