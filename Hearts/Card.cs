using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    internal class Card
    {
        #region Attributes
        /// <summary>
        /// String represeting the card's suit
        /// </summary>
        private string suitString;
        /// <summary>
        /// String representing the card's rank
        /// </summary>
        private string rankString;
        /// <summary>
        /// Integer representing the card's suit as a number. 1 Spade, 2 Clubs, 3 Diamonds, 4 Hearts
        /// </summary>
        private int suitInt;
        /// <summary>
        /// Integer representing the card's rank as a number. 
        /// Two is rank 2, Queen is rank 12, Ace is rank 14
        /// </summary>
        private int rankInt;

        /// <summary>
        /// Facing value of the card. Face up is true and face down is false
        /// </summary>
        private Boolean faceUp;

        #endregion

        #region Constants

        /// <summary>
        /// Value to show in game for a card that is face down
        /// </summary>
        public const string HIDDEN_VALUE = "?";


        /// <summary>
        /// Default card rank string value
        /// </summary>
        public string DEFAULT_RANK_STRING = "two";

        /// <summary>
        /// Hearts value of queen of spades
        /// </summary>
        public const int QUEEN_OF_SPADES_POINTS = 13;



        /// <summary>
        /// Default card suit string value
        /// </summary>
        public const string DEFUALT_SUIT_STRING = "spades";
        /// <summary>
        /// Default card rank integer value
        /// </summary>
        public const int DEFAULT_RANK_INT = 2;
        /// <summary>
        /// Default card suit integer value
        /// </summary>
        public const int DEFAULT_SUIT_INT = 1;

        /// <summary>
        /// Integer value of spades suit
        /// </summary>
        public const int SPADES_VALUE = 1;
        /// <summary>
        /// Integer value of clubs suit
        /// </summary>
        public const int CLUBS_VALUE = 2;
        
        /// <summary>
        /// Integer value of diamonds suit
        /// </summary>
        public const int DIAMONDS_VALUE = 3;
        /// <summary>
        /// Integer value of hearts suit
        /// </summary>
        public const int HEARTS_VALUE = 4;

        /// <summary>
        /// Value of card rank 2
        /// </summary>
        public const int TWO_VALUE = 2;

        /// <summary>
        /// Value of card rank queen
        /// </summary>
        public const int QUEEN_VALUE = 12;
        /// <summary>
        /// default facing position of a card
        /// </summary>
        public const Boolean DEFAULT_FACE_UP_VALUE = true;


        #endregion


        /// <summary>
        /// Paramerized constructor for card
        /// </summary>
        /// <param name="suit">Suit integer for creating a card</param>
        /// <param name="rank">Rank integer for creating a card</param>
        /// <param name="facing">Face up value of card</param>
        public Card(int suit, int rank, Boolean facing) 
        {
            setFaceUp(facing);
            setSuitInt(suit);
            setRankInt(rank);

            if (rankInt == 2)
            {
                setRankString("2");

            }else if (rankInt == 4)
            {
                setRankString("4");

            }else if (rankInt == 6)
            {
                setRankString("6");

            }else if(rankInt == 8)
            {
                setRankString("8");

            }else if (rankInt == 10)
            {
                setRankString("10");

            }else if (rankInt == 12)
            {
                setRankString("Queen");

            }else if (rankInt == 14)
            {
                setRankString("Ace");
            }
           

            if(suitInt == SPADES_VALUE)
            {
                setSuitString("Spades");
            }else if(suitInt == CLUBS_VALUE)
            {
                setSuitString("Clubs");
            }else if(suitInt == HEARTS_VALUE)
            {
                setSuitString("Hearts");
            }else if (suitInt == DIAMONDS_VALUE)
            {
                setSuitString("Diamonds");
            }

        }

        #region Getters/Setters
        /// <summary>
        /// get face up value of the card
        /// </summary>
        /// <returns>True if the card is face up false if not</returns>
        public Boolean isFaceUp()
        {
            return faceUp;
        }
        /// <summary>
        /// Set facing value of the card
        /// </summary>
        /// <param name="facing">Facing boolean for card to set</param>
        public void setFaceUp(Boolean facing)
        {
            faceUp = facing;
        }

        /// <summary>
        /// Get the string value of the card suit
        /// </summary>
        /// <returns>String representing suit of the card</returns>
        public string getSuitString()
        {
            return suitString;
        }
        /// <summary>
        /// Get the rank string value of the card
        /// </summary>
        /// <returns>String representing the rank of the card</returns>
        public string getRankString()
        {
            return rankString;
        }

        /// <summary>
        /// Get integer for card rank
        /// </summary>
        /// <returns>Integer representing the cards rank</returns>
        public int getRankInt() 
        {
            return rankInt;
        }

        /// <summary>
        /// Get the integer for card suit
        /// </summary>
        /// <returns>Integer representing the cards suit</returns>
        public int getSuitInt()
        {
            return suitInt;
        }

        /// <summary>
        /// Set the string of the cards suit
        /// </summary>
        /// <param name="suit">String to set suit for</param>
        public void setSuitString(string suit)
        {
            this.suitString = suit;
        }

        /// <summary>
        /// Set rank string for cards rank
        /// </summary>
        /// <param name="rank">String of rank to set</param>
        public void setRankString(string rank)
        {
            this.rankString = rank;
        }

        /// <summary>
        /// Sets the suit integer for card
        /// </summary>
        /// <param name="suit">suit integer to set</param>
        public void setSuitInt(int suit)
        {
            this.suitInt = suit;
        }

        /// <summary>
        /// Set the rank integer for the card
        /// </summary>
        /// <param name="rank">Rank integer to set</param>
        public void setRankInt(int rank)
        {
            this.rankInt = rank;
        }

        #endregion

        

        /// <summary>
        /// Get suit and rank of card and create a string stating them
        /// </summary>
        /// <returns>String with card details</returns>
        override
        public string ToString()
        {
            return getRankString() + " of " + getSuitString();
        }


    }
}
