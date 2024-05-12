namespace Hearts
{
    partial class HeartsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lvPlayerHand1 = new System.Windows.Forms.ListView();
            this.Suit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.lHand1 = new System.Windows.Forms.Label();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.lHand2 = new System.Windows.Forms.Label();
            this.lvPlayerHand2 = new System.Windows.Forms.ListView();
            this.Suit2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rank2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lTurn = new System.Windows.Forms.Label();
            this.lTurnCounter = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.lPlayerScore1 = new System.Windows.Forms.Label();
            this.lPlayerScore2 = new System.Windows.Forms.Label();
            this.lScore1 = new System.Windows.Forms.Label();
            this.lScore2 = new System.Windows.Forms.Label();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.gbTurn = new System.Windows.Forms.GroupBox();
            this.bDeal = new System.Windows.Forms.Button();
            this.player1Play = new System.Windows.Forms.Button();
            this.player2Play = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlayer1Card = new System.Windows.Forms.Label();
            this.lblPlayer2Card = new System.Windows.Forms.Label();
            this.cbP1Computer = new System.Windows.Forms.CheckBox();
            this.cbP2Computer = new System.Windows.Forms.CheckBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsHelpButton = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmbHow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbRules = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbTemp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbPerm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            this.gbScore.SuspendLayout();
            this.gbTurn.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPlayerHand1
            // 
            this.lvPlayerHand1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvPlayerHand1.AllowColumnReorder = true;
            this.lvPlayerHand1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Suit,
            this.Rank});
            this.lvPlayerHand1.FullRowSelect = true;
            this.lvPlayerHand1.HideSelection = false;
            this.lvPlayerHand1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvPlayerHand1.Location = new System.Drawing.Point(5, 52);
            this.lvPlayerHand1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPlayerHand1.MultiSelect = false;
            this.lvPlayerHand1.Name = "lvPlayerHand1";
            this.lvPlayerHand1.Size = new System.Drawing.Size(249, 377);
            this.lvPlayerHand1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lvPlayerHand1, "Player 1\'s Hand");
            this.lvPlayerHand1.UseCompatibleStateImageBehavior = false;
            this.lvPlayerHand1.View = System.Windows.Forms.View.Details;
            this.lvPlayerHand1.SelectedIndexChanged += new System.EventHandler(this.lvPlayerHand1_SelectedIndexChanged);
            // 
            // Suit
            // 
            this.Suit.Text = "Suit";
            this.Suit.Width = 62;
            // 
            // Rank
            // 
            this.Rank.Text = "Rank";
            this.Rank.Width = 71;
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.lHand1);
            this.gbPlayer1.Controls.Add(this.lvPlayerHand1);
            this.gbPlayer1.Location = new System.Drawing.Point(12, 11);
            this.gbPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlayer1.Size = new System.Drawing.Size(261, 434);
            this.gbPlayer1.TabIndex = 1;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player 1";
            // 
            // lHand1
            // 
            this.lHand1.AutoSize = true;
            this.lHand1.Location = new System.Drawing.Point(5, 33);
            this.lHand1.Name = "lHand1";
            this.lHand1.Size = new System.Drawing.Size(92, 16);
            this.lHand1.TabIndex = 0;
            this.lHand1.Text = "Player 1 Hand";
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.lHand2);
            this.gbPlayer2.Controls.Add(this.lvPlayerHand2);
            this.gbPlayer2.Location = new System.Drawing.Point(279, 11);
            this.gbPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlayer2.Size = new System.Drawing.Size(264, 434);
            this.gbPlayer2.TabIndex = 3;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player 2";
            // 
            // lHand2
            // 
            this.lHand2.AutoSize = true;
            this.lHand2.Location = new System.Drawing.Point(5, 33);
            this.lHand2.Name = "lHand2";
            this.lHand2.Size = new System.Drawing.Size(92, 16);
            this.lHand2.TabIndex = 0;
            this.lHand2.Text = "Player 2 Hand";
            // 
            // lvPlayerHand2
            // 
            this.lvPlayerHand2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Suit2,
            this.Rank2});
            this.lvPlayerHand2.FullRowSelect = true;
            this.lvPlayerHand2.HideSelection = false;
            this.lvPlayerHand2.Location = new System.Drawing.Point(6, 52);
            this.lvPlayerHand2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPlayerHand2.Name = "lvPlayerHand2";
            this.lvPlayerHand2.Size = new System.Drawing.Size(252, 377);
            this.lvPlayerHand2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lvPlayerHand2, "Player 2\'s Hand");
            this.lvPlayerHand2.UseCompatibleStateImageBehavior = false;
            this.lvPlayerHand2.View = System.Windows.Forms.View.Details;
            this.lvPlayerHand2.SelectedIndexChanged += new System.EventHandler(this.lvPlayerHand2_SelectedIndexChanged);
            // 
            // Suit2
            // 
            this.Suit2.Text = "Suit";
            this.Suit2.Width = 71;
            // 
            // Rank2
            // 
            this.Rank2.Text = "Rank";
            this.Rank2.Width = 85;
            // 
            // lTurn
            // 
            this.lTurn.AutoSize = true;
            this.lTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTurn.Location = new System.Drawing.Point(5, 18);
            this.lTurn.Name = "lTurn";
            this.lTurn.Size = new System.Drawing.Size(69, 29);
            this.lTurn.TabIndex = 0;
            this.lTurn.Text = "Turn:";
            // 
            // lTurnCounter
            // 
            this.lTurnCounter.AutoSize = true;
            this.lTurnCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTurnCounter.Location = new System.Drawing.Point(20, 48);
            this.lTurnCounter.Name = "lTurnCounter";
            this.lTurnCounter.Size = new System.Drawing.Size(35, 38);
            this.lTurnCounter.TabIndex = 1;
            this.lTurnCounter.Text = "0";
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(40, 18);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(64, 25);
            this.lScore.TabIndex = 0;
            this.lScore.Text = "Score";
            this.lScore.Click += new System.EventHandler(this.lScore_Click);
            // 
            // lPlayerScore1
            // 
            this.lPlayerScore1.AutoSize = true;
            this.lPlayerScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerScore1.Location = new System.Drawing.Point(15, 62);
            this.lPlayerScore1.Name = "lPlayerScore1";
            this.lPlayerScore1.Size = new System.Drawing.Size(89, 25);
            this.lPlayerScore1.TabIndex = 1;
            this.lPlayerScore1.Text = "Player 1:";
            // 
            // lPlayerScore2
            // 
            this.lPlayerScore2.AutoSize = true;
            this.lPlayerScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerScore2.Location = new System.Drawing.Point(15, 89);
            this.lPlayerScore2.Name = "lPlayerScore2";
            this.lPlayerScore2.Size = new System.Drawing.Size(89, 25);
            this.lPlayerScore2.TabIndex = 2;
            this.lPlayerScore2.Text = "Player 2:";
            // 
            // lScore1
            // 
            this.lScore1.AutoSize = true;
            this.lScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore1.Location = new System.Drawing.Point(109, 62);
            this.lScore1.Name = "lScore1";
            this.lScore1.Size = new System.Drawing.Size(23, 25);
            this.lScore1.TabIndex = 3;
            this.lScore1.Text = "0";
            // 
            // lScore2
            // 
            this.lScore2.AutoSize = true;
            this.lScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore2.Location = new System.Drawing.Point(109, 89);
            this.lScore2.Name = "lScore2";
            this.lScore2.Size = new System.Drawing.Size(23, 25);
            this.lScore2.TabIndex = 4;
            this.lScore2.Text = "0";
            // 
            // gbScore
            // 
            this.gbScore.Controls.Add(this.lScore);
            this.gbScore.Controls.Add(this.lScore2);
            this.gbScore.Controls.Add(this.lPlayerScore1);
            this.gbScore.Controls.Add(this.lScore1);
            this.gbScore.Controls.Add(this.lPlayerScore2);
            this.gbScore.Location = new System.Drawing.Point(549, 11);
            this.gbScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbScore.Name = "gbScore";
            this.gbScore.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbScore.Size = new System.Drawing.Size(147, 138);
            this.gbScore.TabIndex = 11;
            this.gbScore.TabStop = false;
            // 
            // gbTurn
            // 
            this.gbTurn.Controls.Add(this.lTurn);
            this.gbTurn.Controls.Add(this.lTurnCounter);
            this.gbTurn.Location = new System.Drawing.Point(701, 11);
            this.gbTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTurn.Name = "gbTurn";
            this.gbTurn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTurn.Size = new System.Drawing.Size(85, 138);
            this.gbTurn.TabIndex = 12;
            this.gbTurn.TabStop = false;
            // 
            // bDeal
            // 
            this.bDeal.BackColor = System.Drawing.SystemColors.Info;
            this.bDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeal.Location = new System.Drawing.Point(549, 155);
            this.bDeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDeal.Name = "bDeal";
            this.bDeal.Size = new System.Drawing.Size(237, 86);
            this.bDeal.TabIndex = 5;
            this.bDeal.Text = "Deal";
            this.toolTip1.SetToolTip(this.bDeal, "Click to deal hands");
            this.bDeal.UseVisualStyleBackColor = false;
            this.bDeal.Click += new System.EventHandler(this.bDeal_Click);
            // 
            // player1Play
            // 
            this.player1Play.Location = new System.Drawing.Point(101, 452);
            this.player1Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player1Play.Name = "player1Play";
            this.player1Play.Size = new System.Drawing.Size(75, 23);
            this.player1Play.TabIndex = 2;
            this.player1Play.Text = "Play Card";
            this.toolTip1.SetToolTip(this.player1Play, "Player 1: Click to Play Card");
            this.player1Play.UseVisualStyleBackColor = true;
            this.player1Play.Click += new System.EventHandler(this.player1Play_Click);
            // 
            // player2Play
            // 
            this.player2Play.Location = new System.Drawing.Point(366, 452);
            this.player2Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player2Play.Name = "player2Play";
            this.player2Play.Size = new System.Drawing.Size(75, 23);
            this.player2Play.TabIndex = 4;
            this.player2Play.Text = "Play Card";
            this.toolTip1.SetToolTip(this.player2Play, "Player 2: Click to Play Card");
            this.player2Play.UseVisualStyleBackColor = true;
            this.player2Play.Click += new System.EventHandler(this.player2Play_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(622, 256);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 28);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Game";
            this.toolTip1.SetToolTip(this.btnReset, "Click to start a new game");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPlayer1Card
            // 
            this.lblPlayer1Card.AutoSize = true;
            this.lblPlayer1Card.Location = new System.Drawing.Point(17, 494);
            this.lblPlayer1Card.Name = "lblPlayer1Card";
            this.lblPlayer1Card.Size = new System.Drawing.Size(108, 16);
            this.lblPlayer1Card.TabIndex = 9;
            this.lblPlayer1Card.Text = "Player 1 Played: ";
            // 
            // lblPlayer2Card
            // 
            this.lblPlayer2Card.AutoSize = true;
            this.lblPlayer2Card.Location = new System.Drawing.Point(286, 494);
            this.lblPlayer2Card.Name = "lblPlayer2Card";
            this.lblPlayer2Card.Size = new System.Drawing.Size(108, 16);
            this.lblPlayer2Card.TabIndex = 10;
            this.lblPlayer2Card.Text = "Player 2 Played: ";
            // 
            // cbP1Computer
            // 
            this.cbP1Computer.AutoSize = true;
            this.cbP1Computer.Location = new System.Drawing.Point(569, 356);
            this.cbP1Computer.Name = "cbP1Computer";
            this.cbP1Computer.Size = new System.Drawing.Size(145, 20);
            this.cbP1Computer.TabIndex = 7;
            this.cbP1Computer.Text = "Player 1 : Computer";
            this.toolTip1.SetToolTip(this.cbP1Computer, "Check to make Player 1 a computer player");
            this.cbP1Computer.UseVisualStyleBackColor = true;
            this.cbP1Computer.CheckedChanged += new System.EventHandler(this.cbP1Computer_CheckedChanged_1);
            // 
            // cbP2Computer
            // 
            this.cbP2Computer.AutoSize = true;
            this.cbP2Computer.Location = new System.Drawing.Point(569, 391);
            this.cbP2Computer.Name = "cbP2Computer";
            this.cbP2Computer.Size = new System.Drawing.Size(145, 20);
            this.cbP2Computer.TabIndex = 8;
            this.cbP2Computer.Text = "Player 2 : Computer";
            this.toolTip1.SetToolTip(this.cbP2Computer, "Check to make Player 2 a computer player");
            this.cbP2Computer.UseVisualStyleBackColor = true;
            this.cbP2Computer.CheckedChanged += new System.EventHandler(this.cbP2Computer_CheckedChanged_1);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(550, 474);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(225, 25);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "Player 1 is the winner!";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelpButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsHelpButton
            // 
            this.tsHelpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsHelpButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmbHow,
            this.tsmbRules,
            this.tsmbTemp,
            this.tsmbPerm,
            this.tsmbExit});
            this.tsHelpButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsHelpButton.Name = "tsHelpButton";
            this.tsHelpButton.Size = new System.Drawing.Size(60, 28);
            this.tsHelpButton.Text = "Help";
            this.tsHelpButton.ToolTipText = "Click for Information";
            // 
            // tsmbHow
            // 
            this.tsmbHow.Name = "tsmbHow";
            this.tsmbHow.Size = new System.Drawing.Size(235, 26);
            this.tsmbHow.Text = "How To Play";
            this.tsmbHow.ToolTipText = "How to play Hearts";
            this.tsmbHow.Click += new System.EventHandler(this.tsmbHow_Click);
            // 
            // tsmbRules
            // 
            this.tsmbRules.Name = "tsmbRules";
            this.tsmbRules.Size = new System.Drawing.Size(235, 26);
            this.tsmbRules.Text = "Rules";
            this.tsmbRules.ToolTipText = "View game rules";
            this.tsmbRules.Click += new System.EventHandler(this.tsmbRules_Click);
            // 
            // tsmbTemp
            // 
            this.tsmbTemp.Name = "tsmbTemp";
            this.tsmbTemp.Size = new System.Drawing.Size(235, 26);
            this.tsmbTemp.Text = "Temporary Game Log";
            this.tsmbTemp.ToolTipText = "View log of current game";
            this.tsmbTemp.Click += new System.EventHandler(this.tsmbTemp_Click);
            // 
            // tsmbPerm
            // 
            this.tsmbPerm.Name = "tsmbPerm";
            this.tsmbPerm.Size = new System.Drawing.Size(235, 26);
            this.tsmbPerm.Text = "Game History Log";
            this.tsmbPerm.ToolTipText = "View game history";
            this.tsmbPerm.Click += new System.EventHandler(this.tsmbPerm_Click);
            // 
            // tsmbExit
            // 
            this.tsmbExit.Name = "tsmbExit";
            this.tsmbExit.Size = new System.Drawing.Size(235, 26);
            this.tsmbExit.Text = "Exit Game";
            this.tsmbExit.ToolTipText = "Exit Game Here";
            this.tsmbExit.Click += new System.EventHandler(this.tsmbExit_Click);
            // 
            // HeartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 563);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.cbP2Computer);
            this.Controls.Add(this.cbP1Computer);
            this.Controls.Add(this.lblPlayer2Card);
            this.Controls.Add(this.lblPlayer1Card);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.player2Play);
            this.Controls.Add(this.player1Play);
            this.Controls.Add(this.bDeal);
            this.Controls.Add(this.gbTurn);
            this.Controls.Add(this.gbScore);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 610);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(870, 610);
            this.Name = "HeartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hearts";
            this.Load += new System.EventHandler(this.HeartsForm_Load);
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            this.gbScore.ResumeLayout(false);
            this.gbScore.PerformLayout();
            this.gbTurn.ResumeLayout(false);
            this.gbTurn.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvPlayerHand1;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.Label lHand1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.Label lHand2;
        private System.Windows.Forms.ListView lvPlayerHand2;
        private System.Windows.Forms.Label lTurn;
        private System.Windows.Forms.Label lTurnCounter;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lPlayerScore1;
        private System.Windows.Forms.Label lPlayerScore2;
        private System.Windows.Forms.Label lScore1;
        private System.Windows.Forms.Label lScore2;
        private System.Windows.Forms.GroupBox gbScore;
        private System.Windows.Forms.GroupBox gbTurn;
        private System.Windows.Forms.Button bDeal;
        private System.Windows.Forms.Button player1Play;
        private System.Windows.Forms.Button player2Play;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ColumnHeader Suit;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader Suit2;
        private System.Windows.Forms.ColumnHeader Rank2;
        private System.Windows.Forms.Label lblPlayer1Card;
        private System.Windows.Forms.Label lblPlayer2Card;
        private System.Windows.Forms.CheckBox cbP1Computer;
        private System.Windows.Forms.CheckBox cbP2Computer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tsHelpButton;
        private System.Windows.Forms.ToolStripMenuItem tsmbHow;
        private System.Windows.Forms.ToolStripMenuItem tsmbRules;
        private System.Windows.Forms.ToolStripMenuItem tsmbTemp;
        private System.Windows.Forms.ToolStripMenuItem tsmbPerm;
        private System.Windows.Forms.ToolStripMenuItem tsmbExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

