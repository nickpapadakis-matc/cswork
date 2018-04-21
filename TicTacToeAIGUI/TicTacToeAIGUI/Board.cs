using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAIGUI
{
    public class Board
    {
        /// <summary>
        /// Most of the game logic is in this class. Checks board conditions, keeps the count
        /// and determines a winner or tie. Had to put the reset board method in the form1 class
        /// due to button text reasons. Had it in here for the console version
        /// </summary>
        string[] gameArray = new string[] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public string[] GameArray { get { return gameArray; } set { gameArray = value; } }
        int count = 0;
        public int Count { get { return count; } set { count = value; } }
        int[,] winningCombos = new int[,]   //2d array of winning combonations
        {   { 0, 1, 2 },
            { 0, 3, 6 },
            { 0, 4, 8 },
            { 1, 4, 7 },
            { 2, 4, 6 },
            { 2, 5, 8 },
            { 3, 4, 5 },
            { 6, 7, 8 } };
        public int[,] WinningCombos { get { return winningCombos; } }

        public Board()
        {

        }
        /// <summary>
        /// recieves a humanPlayer object and a computerPlayer object from the form1 class and
        /// does a check on the players bit array to see if it has met one of the winning combo requirements
        /// </summary>
        /// <returns> true if player has one of the winning combos, else it returns false</returns>
        public bool DetermineWin(HumanPlayer x, ComputerPlayer o)
        {
            const int ARRAYLENGTH = 8;
            const int INNERLENGTH = 3;
            int i = 0;
            bool winner = false;
            if(IsPlaying() == 0)
            {
                while (!winner && i < ARRAYLENGTH)
                {
                    int comboCount = 0;
                    for (int j = 0; j < INNERLENGTH; j++)
                    {
                        if (x.Pieces[winningCombos[i, j]] == true)
                        {
                            comboCount++;
                        }
                    }
                    if (comboCount == 3)
                    {
                        winner = true;
                    }
                    i++;
                }
            }
            else
            {
                while (!winner && i < ARRAYLENGTH)
                {
                    int comboCount = 0;
                    for (int j = 0; j < INNERLENGTH; j++)
                    {
                        if (o.Pieces[winningCombos[i, j]] == true)
                        {
                            comboCount++;
                        }
                    }
                    if (comboCount == 3)
                    {
                        winner = true;
                    }
                    i++;
                }
            }
            return winner;
        }
        /// <summary>
        /// checks the count to see if the board is open or full
        /// </summary>
        public bool IsFull()
        {
            if (count >= 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// checks to see if the move is valid based on the move sent from form1 class
        /// returns true if spot os open and false if not
        /// </summary>
        public bool ValidMove(int move)
        {
            if (gameArray[move] == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// if count is divisible by 2 with a remainder of 0 it returns true
        /// and it is the HumanPlayers turn, else it is false and it is the computers turn
        /// </summary>
        /// <returns></returns>
        public int IsPlaying()
        {
            int playerX = 0;
            int playerO = 1;
            if (count % 2 == 0)
            {
                return playerX;
            }
            else
            {
                return playerO;
            }
        }
    }
}
