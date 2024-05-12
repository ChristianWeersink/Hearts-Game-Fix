using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hearts
{
    // test 2
    internal class Hand

        //03-24: NEED DEAL FUNCTION TO CONTINUE HAND
    {
  
        /// <summary>
        /// List of card for the hand
        /// </summary>
        private List <Card> hand;

        /// <summary>
        /// Param constructor
        /// </summary>
        /// <param name="drawnCards"></param>
        public Hand(List<Card> drawnCards) 
        {
            hand = drawnCards;
        }
        /// <summary>
        /// Default constrcutor
        /// </summary>
        public Hand()
        {
            hand = new List<Card>();
        }
        
        /// <summary>
        /// Add cards from hand to given list view. If face up value is true card will show Card.HIDDEN_VALUE or "?"
        /// </summary>
        /// <param name="listview">List view to add cards to</param>
        public void AddHandToListView(System.Windows.Forms.ListView listview)
        {
            listview.Items.Clear();
            foreach (Card card in hand)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = card; // sets the list view item as a card object, so we can treat the list view item as a card object
                if (!card.isFaceUp())
                {
                    ListViewSubItem subItem = new ListViewSubItem(item, Card.HIDDEN_VALUE);
                    item.SubItems.Insert(0, subItem);
                    subItem = new ListViewSubItem(item, Card.HIDDEN_VALUE);
                    item.SubItems.Insert(1, subItem);
                    listview.Items.Add(item);
                }
                else
                {
                    ListViewSubItem subItem = new ListViewSubItem(item, card.getSuitString());
                    item.SubItems.Insert(0, subItem);
                    subItem = new ListViewSubItem(item, card.getRankString());
                    item.SubItems.Insert(1, subItem);
                    listview.Items.Add(item);
                }
            }
        }


        /// <summary>
        /// Overloaded version of AddHandToListView that adds all the cards from the playes hand onto the list view after checking if the suit matches the card in play. Used for game logic to determine which cards should be hidden from player view.
        /// </summary>
        /// <param name="listview">List view to add cards to</param>
        /// <param name="cardInPlay">Card to check suit of before adding cards to list view</param>
        public void AddHandToListView(System.Windows.Forms.ListView listview, Card cardInPlay)
        {
            // Counter for cards not added
            int cardsNotAdded = 0;
            // Clear all cards from listview first
            listview.Items.Clear();
            foreach (Card card in hand)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = card; // sets the list view item as a card object, so we can treat the list view item as a card object
                if (!card.isFaceUp()) // if the card attribute is face down, just add the card
                {
                    ListViewSubItem subItem = new ListViewSubItem(item, Card.HIDDEN_VALUE);
                    item.SubItems.Insert(0, subItem);
                    subItem = new ListViewSubItem(item, Card.HIDDEN_VALUE);
                    item.SubItems.Insert(1, subItem);
                    listview.Items.Add(item);
                }
                else if(card.getSuitInt() != cardInPlay.getSuitInt())
                {
                    cardsNotAdded++;
                }
                else
                {
                    ListViewSubItem subItem = new ListViewSubItem(item, card.getSuitString());
                    item.SubItems.Insert(0, subItem);
                    subItem = new ListViewSubItem(item, card.getRankString());
                    item.SubItems.Insert(1, subItem);
                    listview.Items.Add(item);

                }
            }
            if(cardsNotAdded >= hand.Count)
            {
                AddHandToListView(listview);
            }

        }



        /// <summary>
        /// Adds the passed card to the hand
        /// </summary>
        /// <param name="card"> Card to be added to hand</param>
        public void addCardToHand(Card card)
        {
            this.hand.Add(card);
        }

        /// <summary>
        /// Set the face up value of all cars in the hand to the opposite of what it currently is
        /// </summary>
        public void revealOrHideHand()
        {
            foreach (Card card in  this.hand)
            {
                if (card.isFaceUp())
                {
                    card.setFaceUp(false);
                }
                else
                {
                    card.setFaceUp(true);
                }
                
            }
        }

        /// <summary>
        /// Sets all the face up values of the cards in the hand to true
        /// </summary>
        public void revealHand()
        {
            foreach (Card card in this.hand)
            {
                card.setFaceUp(true);
            }
        }

        /// <summary>
        /// Sets all the face up values of the cards in the hand to false
        /// </summary>
        public void hideHand()
        {
            foreach (Card card in this.hand)
            {
                card.setFaceUp(false);
            }
        }

        /// <summary>
        /// Remove passed in card from hand
        /// </summary>
        /// <param name="card">card to remove from hand</param>
        public void removeCardFromHand(Card card)
        {
            hand.Remove(card);
        }
        
 
        /// <summary>
        /// Remove all cards from hand
        /// </summary>
        public void removeAllFromHand()
        {
            hand.Clear();
        }

        /// <summary>
        /// Counts all cards in the hand for forloops 
        /// </summary>
        /// <returns>integer of number of cards in hand</returns>
        public int count()
        {
            int cardCount = hand.Count;
            return cardCount;
        }

        /// <summary>
        /// gets a card from the hand based on index
        /// </summary>
        /// <param name="i">Integer of card to get from the list</param>
        /// <returns></returns>
        public Card getCardFromHand(int i)
        {
            Card card = hand[i];
            return card;
        }


    }
}
