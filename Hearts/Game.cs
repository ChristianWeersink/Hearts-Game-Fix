using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearts
{
    public partial class HeartsForm : Form
    {
        /// <summary>
        /// File for logging that gets cleared each time the form is loaded
        /// </summary>
        string tempFile = "details_log.txt";
        string permFile = "winner_log.txt";
        Deck aDeck = new Deck();
        Player player1 = new Player(new Hand(), "Player 1");
        Player player2 = new Player(new Hand(), "Player 2");
        Card player1SelectedCard;
        Card player2SelectedCard;
        Card winningCard;
        Card cardInPlay;
        bool player1PlayedFirst = false;

        private const int POINTS_TO_WIN = 30;

        public HeartsForm()
        {
            InitializeComponent();
            DataLogging.ClearLog(tempFile);
            resetForm();
        }

        public void resetForm()
        {
            lvPlayerHand1.Items.Clear(); // clear list views
            lvPlayerHand2.Items.Clear();
            player1.playerHand.removeAllFromHand(); //remove card objects from hand
            player2.playerHand.removeAllFromHand();
            aDeck.Clear(); // empty deck
            aDeck.createDeck(); // create new standard deck
            aDeck.deckShuffle();
            player1.setHeartsCount(0); // reset hp count
            player2.setHeartsCount(0);
            Turn.turnsPlayed = 0;
            Turn.turnCount = 0;
            lTurnCounter.Text = "0";
            bDeal.Enabled = true;
            player1PlayedFirst = false;
            player1SelectedCard = null;
            player2SelectedCard = null;
            lvPlayerHand1.SelectedItems.Clear();
            lvPlayerHand2.SelectedItems.Clear();
            player1Play.Enabled = false;
            player2Play.Enabled = false;
            lblPlayer1Card.Text = "";
            lblPlayer2Card.Text = "";
            lblWinner.Text = "";
            //Reset current score
            lScore1.Text = "0";
            lScore2.Text = "0";
            cbP1Computer.Enabled = true;
            cbP2Computer.Enabled = true;
            bDeal.Select();

        }

        public void resetGameScore()
        {
           // lScore1.Text = "0";
            //lScore2.Text = "0";


            lblWinner.Text = "";

        }

        private void HeartsForm_Load(object sender, EventArgs e)
        {

        }

        private void lScore_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Main function of program. Plays a card for the player and depending on if the other player has played or not, determines a turn winner, or determines playable cards for the player. Also checks for game winner in the case that all cards have been played.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void player1Play_Click(object sender, EventArgs e)
        {
            if (lvPlayerHand1.SelectedItems.Count > 0) // if any items are selected

            {
                player1SelectedCard = player1.playCard(lvPlayerHand1); // set selected card to the card selected on the list view
                DataLogging.LogWrite("Player 1 played " + player1SelectedCard.ToString(), tempFile);
                lblPlayer1Card.Text = "Player 1 played " + player1SelectedCard.ToString();

                // set up player 2 hand for next turn and disable player 1 hand
                player1.playerHand.hideHand();
                player2.playerHand.revealHand();
                lvPlayerHand2.Enabled = true;
                lvPlayerHand1.Enabled = false;
                player1Play.Enabled = false;
                player2Play.Enabled = true;



                if(Turn.turnsPlayed == 2) // if both players have played this turn
                {
                    Turn.turnCount++; // turn counter is increased
                    lTurnCounter.Text = Turn.turnCount.ToString();
                    cardInPlay = null; // no card is in play
                    turnWinner(); // determine turn winner and set up hands accordingly
                }
                else // player 1 played first this turn
                {
                    player1PlayedFirst = true;
                    // set up player 2 hand
                    player2.playerHand.revealHand();
                    cardInPlay = player1SelectedCard;
                    player2.playerHand.AddHandToListView(lvPlayerHand2, cardInPlay); // adds only playable cards to hand
                    player1.playerHand.AddHandToListView(lvPlayerHand1); // update player 1 hand list 
                    lvPlayerHand2.Items[0].Selected = true; // select first card on player 2s hand for them
                    player2Play.Select();
                }
                
            }
            else // no items are selected yell at player
            {
                MessageBox.Show("You must select a card!");
            }
        }


        /// <summary>
        /// See player1Play_Click
        /// </summary>
        private void player2Play_Click(object sender, EventArgs e)
        {
            if (lvPlayerHand2.SelectedItems.Count > 0) // if any items are selected
            {
                player2SelectedCard = player2.playCard(lvPlayerHand2);// set selected card to the card selected on the list view
                DataLogging.LogWrite("Player 2 played " + player2SelectedCard.ToString(), tempFile);
                lblPlayer2Card.Text = "Player 2 played " + player2SelectedCard.ToString();
                player2.playerHand.hideHand();
                player1.playerHand.revealHand();
                lvPlayerHand1.Enabled = true;
                lvPlayerHand2.Enabled = false;
                player2Play.Enabled = false;
                player1Play.Enabled = true;

                // If both players have played a card this turn
                if (Turn.turnsPlayed == 2)
                {
                    // change turn counter on the form
                    Turn.turnCount++;
                    lTurnCounter.Text = Turn.turnCount.ToString();
                    cardInPlay = null;
                    turnWinner();

                }
                else
                {
                    player1PlayedFirst = false;
                    player1.playerHand.revealHand();
                    cardInPlay = player2SelectedCard;
                    player1.playerHand.AddHandToListView(lvPlayerHand1, cardInPlay); // adds only playable cards to hand

                    player2.playerHand.AddHandToListView(lvPlayerHand2); // update player 2's hand
                    lvPlayerHand1.Items[0].Selected = true; // select player 1's first card for them
                    player1Play.Select();
                }
                

            }

            else
            {
                MessageBox.Show("You must select a card!");
            }

        }

        private void lvPlayerHand1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPlayerHand1.SelectedItems.Count == 1)
            {
                player1SelectedCard = lvPlayerHand1.SelectedItems[0].Tag as Card;
            }
        }

        private void lvPlayerHand2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPlayerHand2.SelectedItems.Count == 1)
            {
                player2SelectedCard = lvPlayerHand2.SelectedItems[0].Tag as Card;
            }
        }

        private void bDeal_Click(object sender, EventArgs e)
        {

            //disable computer player selection

            cbP1Computer.Enabled = false;
            cbP2Computer.Enabled = false;



            aDeck.dealCards(player1.playerHand, player2.playerHand);
            bDeal.Enabled = false;
            if (Turn.firstTurn(player1, player2) == 1)
            {
                lvPlayerHand1.Enabled = true;
                lvPlayerHand2.Enabled = false;
                player2Play.Enabled = false;
                player1Play.Enabled = true;
                player1.playerHand.revealHand(); // set hand visible on form if it's their turn
                DataLogging.LogWrite("Player 1 has two of spades, they play first", tempFile);
                player2.playerHand.AddHandToListView(lvPlayerHand2);
                player1.playerHand.AddHandToListView(lvPlayerHand1);
                lvPlayerHand1.Items[0].Selected = true;
                player1Play.Select();


            }
            else if (Turn.firstTurn(player1, player2) == 2)
            {
                lvPlayerHand1.Enabled = false;
                player1Play.Enabled = false;
                lvPlayerHand2.Enabled = true;
                player2Play.Enabled = true;
                player2.playerHand.revealHand();
                DataLogging.LogWrite("Player 2 has two of spades, they play first", tempFile);
                player2.playerHand.AddHandToListView(lvPlayerHand2);
                player1.playerHand.AddHandToListView(lvPlayerHand1);
                lvPlayerHand2.Items[0].Selected = true;
                player2Play.Select();
            }
            else
            {
                MessageBox.Show("ERROR: TWO OF SPADES NOT FOUND, RESET GAME");
            }

            
        }

    

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataLogging.LogWrite("GAME RESET", tempFile);
            resetForm();
            
        }

   


        /// <summary>
        /// Nifty helper function to determine winner, add those points to the players heart count and clean up for the next turn
        /// </summary>
        private void turnWinner()
        {
            winningCard = Turn.winningCard(player1SelectedCard, player2SelectedCard, player1PlayedFirst);
            // clear the text displaying what card was played by each player
            lblPlayer1Card.Text = "";
            lblPlayer2Card.Text = "";
            // player 2 won that turn
            if (player2SelectedCard.getRankInt() == winningCard.getRankInt() && player2SelectedCard.getSuitInt() == winningCard.getSuitInt())
            {
                DataLogging.LogWrite(winningCard.ToString()+" is trump, Player 2 goes first next turn", tempFile);
                // player 2 won, they go first next round.
                lvPlayerHand2.Enabled = true;
                
                player2Play.Enabled = true;
                lvPlayerHand1.Enabled = false;
                player1Play.Enabled = false;

                player2.playerHand.revealHand();
                player1.playerHand.hideHand();
                player2.playerHand.AddHandToListView(lvPlayerHand2);
                player1.playerHand.AddHandToListView(lvPlayerHand1); // update player 1's hand
                if (lvPlayerHand2.Items.Count > 0)
                {
                    lvPlayerHand2.Items[0].Selected = true;// if player 2 hand has at least 1 card, select the card
                    player2Play.Select();
                }
                
                // check if points are earned
                if (Deck.isHearts(winningCard))
                {
                    DataLogging.LogWrite(winningCard.ToString() + " is hearts, Player 2 gets a point", tempFile);
                    player2.incrementHearts();
                    lScore2.Text = player2.getHeartsCount().ToString();
                }
                else if (Deck.isQueenOfSpades(winningCard))
                {
                    DataLogging.LogWrite(winningCard.ToString() + " is queen of spades, Player 2 gets 13 points", tempFile);
                    player2.incrementHeartsBy5();
                    lScore2.Text = player2.getHeartsCount().ToString();
                }

                if (Deck.isHearts(player1SelectedCard)) {
                    DataLogging.LogWrite(player1SelectedCard.ToString() + " is hearts, Player 2 gets a point", tempFile);
                    player2.incrementHearts();
                    lScore2.Text = player2.getHeartsCount().ToString();
                }

                else if (Deck.isQueenOfSpades(player1SelectedCard))
                {
                    DataLogging.LogWrite(player1SelectedCard.ToString() + " is queen of spades, Player 2 gets 13 points", tempFile);
                    player2.incrementHeartsBy5();
                    lScore2.Text = player2.getHeartsCount().ToString();
                }
            }
            // player 1 won that turn
            else if (player1SelectedCard.getRankInt() == winningCard.getRankInt() && player1SelectedCard.getSuitInt() == winningCard.getSuitInt())
            {
                DataLogging.LogWrite(winningCard.ToString() + " is trump, Player 1 goes first next turn", tempFile);
                lvPlayerHand1.Enabled = true;
                player1Play.Enabled = true;
                lvPlayerHand2.Enabled = false;
                player2Play.Enabled = false;
                player2.playerHand.hideHand();
                player1.playerHand.revealHand();
                player1.playerHand.AddHandToListView(lvPlayerHand1);
                player2.playerHand.AddHandToListView(lvPlayerHand2); // update player 2's hand
                if (lvPlayerHand1.Items.Count > 0) // if player 1 hand has at least 1 card, select the card
                {
                    lvPlayerHand1.Items[0].Selected = true;
                    player1Play.Select();
                }
                if (Deck.isHearts(winningCard))
                {
                    player1.incrementHearts();
                    lScore1.Text = player1.getHeartsCount().ToString();
                    DataLogging.LogWrite(winningCard.ToString() + " is hearts, Player 1 gets a point", tempFile);
                }
                else if (Deck.isQueenOfSpades(winningCard))
                {
                    player1.incrementHeartsBy5();
                    lScore1.Text = player1.getHeartsCount().ToString();
                    DataLogging.LogWrite(winningCard.ToString() + " is queen of spades, Player 1 gets 13 points", tempFile);
                }

                if (Deck.isHearts(player2SelectedCard))
                {
                    player1.incrementHearts();
                    lScore1.Text = player1.getHeartsCount().ToString();
                    DataLogging.LogWrite(player2SelectedCard.ToString() + " is hearts, Player 1 gets a point", tempFile);
                }

                else if (Deck.isQueenOfSpades(player2SelectedCard))
                {
                    player1.incrementHeartsBy5();
                    lScore1.Text = player1.getHeartsCount().ToString();
                    DataLogging.LogWrite(player2SelectedCard.ToString() + " is queen of spades, Player 1 gets 13 points", tempFile);
                }
            }
            
            lScore2.Text = player2.getHeartsCount().ToString();
            lScore1.Text = player1.getHeartsCount().ToString();



            // Check if any player has points to win
            if (Turn.turnCount == 14 && (player1.getHeartsCount() >= POINTS_TO_WIN || (player2.getHeartsCount() >= POINTS_TO_WIN))) {
                Turn.turnCount = 0;
                lTurnCounter.Text = Turn.turnCount.ToString();
                lvPlayerHand1.Enabled = false;
                lvPlayerHand2.Enabled = false;
                player1Play.Enabled = false;
                player2Play.Enabled = false;
                bDeal.Enabled = false;
                btnReset.Select();
                DataLogging.LogWrite("Hand complete, checking for winner", tempFile);

                // check if both player's score are above the points to win
                if (int.Parse(lScore2.Text) >= POINTS_TO_WIN && int.Parse(lScore1.Text) >= POINTS_TO_WIN)
                {
                    // both player's scores are over points to win, check who has a higher score
                    if (int.Parse(lScore1.Text) > int.Parse(lScore2.Text))
                    {
                        lblWinner.Text = "Player 1 Wins";
                        DataLogging.LogWrite("Player 1 Won", permFile);
                        DataLogging.LogWrite("Player 1 Won", tempFile);
                    }
                    else if (int.Parse(lScore1.Text) < int.Parse(lScore2.Text))
                    {
                        lblWinner.Text = "Player 2 Wins";
                        DataLogging.LogWrite("Player 2 Won", permFile);
                        DataLogging.LogWrite("Player 2 Won", tempFile);
                    }
                    else if (int.Parse(lScore1.Text) == int.Parse(lScore2.Text))
                    {
                        lblWinner.Text = "Tie";
                        DataLogging.LogWrite("Game Tie", permFile);
                        DataLogging.LogWrite("Game Tie", tempFile);
                    }

                }

                // check if player 2 won
                else if (player1.getHeartsCount() >= POINTS_TO_WIN) 
                {
                    lblWinner.Text = "Player 2 Wins";
                    DataLogging.LogWrite("Player 2 Won", permFile);
                    DataLogging.LogWrite("Player 2 Won", tempFile);
                }

                //check if player 1 won
                else if (player2.getHeartsCount() >= POINTS_TO_WIN)
                {
                    lblWinner.Text = "Player 1 Wins";
                    DataLogging.LogWrite("Player 1 Won", permFile);
                    DataLogging.LogWrite("Player 1 Won", tempFile);
                }

                
            }
            // no player has one this round, re-enable deal and reset turn count
            else if (Turn.turnCount == 14 && (int.Parse(lScore1.Text) < POINTS_TO_WIN && (int.Parse(lScore2.Text) < POINTS_TO_WIN)))
            {
                DataLogging.LogWrite("No winner this round, deal next hand", tempFile);
                Turn.turnCount = 0;
                lTurnCounter.Text = Turn.turnCount.ToString();
                aDeck.createDeck();
                bDeal.Enabled = true;
                bDeal.Select();
                lvPlayerHand1.Enabled = false;
                lvPlayerHand2.Enabled = false;
                player1Play.Enabled = false;
                player2Play.Enabled = false;
            }
        }


         


        private void cbP1Computer_CheckedChanged_1(object sender, EventArgs e)
        {
            // If cbP1Computer is checked, disable cbP1Human
            if (cbP1Computer.Checked)
            {
                cbP2Computer.Enabled = false;
                //cbP1Computer.Enabled = false;
            }
            else
            {
                cbP2Computer.Enabled = true;
            }
        }

    

        private void cbP2Computer_CheckedChanged_1(object sender, EventArgs e)
        {
            // If cbP2Computer is checked, disable cbP2Human
            if (cbP2Computer.Checked)
            {
                cbP1Computer.Enabled = false;
                //cbP2Computer.Enabled = false;
            }
            else
            {
                cbP1Computer.Enabled = true;
            }
        
        }

        private void tsmbHow_Click(object sender, EventArgs e)
        {
            HowToPlay htpform = new HowToPlay();
            htpform.Show(this);
        }

        private void tsmbRules_Click(object sender, EventArgs e)
        {
            Rules ruleform = new Rules();
            ruleform.Show(this);
        }

        private void tsmbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmbTemp_Click(object sender, EventArgs e)
        {
            TempFile tfile = new TempFile();

            tfile.filePathTemp = "details_log.txt";

            tfile.Show(this);
        }

        private void tsmbPerm_Click(object sender, EventArgs e)
        {
            PermFile pfile = new PermFile();

            pfile.filePathPerm = "winner_log.txt";

            pfile.Show(this);
        }
    }
}
