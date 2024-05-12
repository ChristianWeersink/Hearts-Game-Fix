using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts 
{
    /// <summary>
    /// Deck class that holds a list of card objects
    /// </summary>
    internal class Deck : HeartsInterface
    {

        /// <summary>
        /// List of Cards
        /// </summary>
        private List<Card> CardDeck = new List<Card>();

        /// <summary>
        /// Default Card for checking queen of spades
        /// </summary>
        public static Card QUEEN_OF_SPADES = new Card(Card.SPADES_VALUE, Card.QUEEN_VALUE, Card.DEFAULT_FACE_UP_VALUE);

        /// <summary>
        /// Default card for checking first player for each round
        /// </summary>
        public static Card TWO_OF_SPADES = new Card(Card.SPADES_VALUE, Card.TWO_VALUE, Card.DEFAULT_FACE_UP_VALUE);

        /// <summary>
        /// Creates Deck, writes to log
        /// </summary>
        public void createDeck()
        {
            CardDeck.Clear();

            DataLogging.LogWrite("Deck Created", "details_log.txt");
            for (int s = 1; s < 5; s++)
            {
                for (int r = 2; r <= 14; r += 2) // Start from rank 2 and increment by 2 until rank 14
                {
                    if ((r == 2 || r == 4 || r == 6 || r == 8 || r == 10 || r == 12 || r == 14))
                    {
                        Card cards = new Card(s, r, false);
                        CardDeck.Add(cards);
                    }
                }
            }
        } 

        /// <summary>
        /// Default constructor, creates empty deck
        /// </summary>
        public Deck() 
        {
            CardDeck = new List<Card>();
        }

        /// <summary>
        /// Paramertized constructor, creates deck using list
        /// </summary>
        /// <param name="cardDeck">List of cards to create deck from</param>
        public Deck(List<Card> cardDeck)
        {
            CardDeck = cardDeck;
        }

        public Card selectCard(int index)
        {
            Card aCard = CardDeck[index];
            return aCard;
        }

        /// <summary>
        /// Shuffles Deck, writes to log
        /// </summary>
        public void deckShuffle()
        {
            DataLogging.LogWrite("Deck Shuffled", "details_log.txt");
            Random shuffle = new Random();
            for (int s= 0; s < CardDeck.Count; s++)
            {
                int cards = shuffle.Next(CardDeck.Count -1);
                Card card = CardDeck[s];
                CardDeck[s] = CardDeck[cards];
                CardDeck[cards] = card;
            }
        }

        /// <summary>
        /// Deal card to both players, 1 at a time. Remove the card that was dealt from the deck
        /// </summary>
        /// <param name="player1Hand">First player to deal to</param> 
        /// <param name="player2Hand">Second player to deal to</param> 
        public void dealCards(Hand player1Hand, Hand player2Hand)
        {
            List<Card> tempDeck = new List<Card>(CardDeck); // make a copy of the deck to loop through - using a reference to the deck or the deck itself will throw an error as the loop cannot handel the size change when we remove the card from the deck
            bool player1 = true; // used to alternate player that recives the card
            DataLogging.LogWrite("Dealing Cards.", "details_log.txt");
            foreach (Card card in tempDeck)
            {
                if (player1)
                {
                    player1Hand.addCardToHand(card); // add card from the top of the deck to hand
                    player1 = false; // other player will recive card next loop
                }
                else
                {
                    player2Hand.addCardToHand(card);
                    player1 = true;
                }
                CardDeck.Remove(card); // remove card from deck

            }
        }
        /// <summary>
        /// Create a string of all the cards that are in the deck
        /// </summary>
        /// <returns>String value of the cards in the deck</returns>
        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach(Card card in CardDeck)
            {
                i++;
                sb.Append("Card # "+ i.ToString() +" "+ card.ToString() + ".\n");
            }
            string deckString = sb.ToString();

            return deckString;
        }
        public void Clear()
        {
            CardDeck.Clear();
        }



        /// <summary>
        /// Checks if the card passed in is queen of spades
        /// </summary>
        /// <param name="aCard">Card to check for QoS</param>
        /// <returns>true if it is a qos or false otherwise</returns>
        public static bool isQueenOfSpades(Card aCard)
        {
            bool isQueenOfSpades = false;
            if (aCard.getRankInt() == QUEEN_OF_SPADES.getRankInt() && aCard.getSuitInt() == QUEEN_OF_SPADES.getSuitInt())
            {
                isQueenOfSpades = true;
            }
            return isQueenOfSpades;
        }


        /// <summary>
        /// Checks if the card passed in is two of spades
        /// </summary>
        /// <param name="aCard">Card to check for ToS</param>
        /// <returns>true if it is a tos or false otherwise</returns>
        public static bool isTwoOfSpades(Card aCard)
        {
            bool isTwoOfSpades = false;
            if (aCard.getRankInt() == TWO_OF_SPADES.getRankInt() &&  aCard.getSuitInt() == TWO_OF_SPADES.getSuitInt())
            {
                isTwoOfSpades = true;
            }
            return isTwoOfSpades;
        }

        /// <summary>
        /// Take a Card and check if its of hearts suit
        /// </summary>
        /// <param name="aCard">Card to check</param>
        /// <returns>true if the card is hearts card false if not</returns>
        public static bool isHearts(Card aCard)
        {
            bool isHearts = false;
            if (aCard.getSuitInt() == Card.HEARTS_VALUE)
            {
                isHearts = true;
            }
            return isHearts;
        }


    }
}
