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
        /// comments are in console version
        /// </summary>
        string[] gameArray = new string[] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public string[] GameArray { get { return gameArray; } set { gameArray = value; } }
        int count = 0;
        public int Count { get { return count; } set { count = value; } }
        int[,] winningCombos = new int[,]
        { { 0, 1, 2 },
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
