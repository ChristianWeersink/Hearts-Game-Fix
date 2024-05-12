using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    internal class Computer : Player
    {
        private int computerNum;

        private Hand computerHand;

        private int lastSuit;



        // constructor
        // creates new computer player with player number and the player's hand
        public Computer(int num, Hand gameHand)
        {
            computerNum = num;
            computerHand = gameHand;
        }

        public void ComputerPlay(Computer player, Card lastPlayedCard)
        {
            
            lastSuit = lastPlayedCard.getSuitInt();


            // Checks what suit the last card played was
            if(lastSuit == 1)
            {

            }else if(lastSuit == 2)
            {

            }else if (lastSuit == 3)
            {

            }else if (lastSuit == 4)
            {

            }


        }

    }
}
