using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAIGUI
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer()
           : base()
        {

        }
        /// <summary>
        /// First checks to make sure the check varable is -1, then goes into the first
        /// for loop to check if the computer can win on this move. If it is true
        /// the returned move for that spot is returned back to the game class as 
        /// the computers move and check is set to 0 getting out of the method.
        /// Next if this is false, check stays -1 and we go into the next for loop
        /// checking if the human player can win on the next move, if this is true we return 
        /// the move blocking their winning option and check is set to 0 getting out
        /// of the method. Lastly if neither of these are true check stays -1 
        /// and we go into a while loop where we set move to the next available open
        /// spot on the board in our moveArray list of possible moves. whew... I still
        /// havent been able to beat this thing...
        /// </summary>
        /// <returns>move</returns>
        public override int MakeMove(Board board, int move, HumanPlayer x)
        {
            int index = 0;
            move = 0;
            int check = -1;
            int[] moveArray = new int[] { 4, 0, 2, 6, 8, 1, 3, 5, 7 };
            //checking if computer can win on next turn
            if (check == -1)
            {
                for (int i = 0; i < 8; i++)
                {

                    if (pieces[board.WinningCombos[i, 0]] == true && pieces[board.WinningCombos[i, 1]] == true && board.ValidMove(board.WinningCombos[i, 2]) && check == -1)
                    {
                        move = board.WinningCombos[i, 2];
                        pieces[move] = true;
                        check = 0;
                    }
                    else if (pieces[board.WinningCombos[i, 0]] == true && pieces[board.WinningCombos[i, 2]] == true && board.ValidMove(board.WinningCombos[i, 1]) && check == -1)
                    {
                        move = board.WinningCombos[i, 1];
                        pieces[move] = true;
                        check = 0;
                    }
                    else if (pieces[board.WinningCombos[i, 1]] == true && pieces[board.WinningCombos[i, 2]] == true && board.ValidMove(board.WinningCombos[i, 0]) && check == -1)
                    {
                        move = board.WinningCombos[i, 0];
                        pieces[move] = true;
                        check = 0;
                    }
                }
            }
            //checking if human can win on next turn and blocking
            if (check == -1)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (x.Pieces[board.WinningCombos[i, 0]] == true && x.Pieces[board.WinningCombos[i, 1]] == true && board.ValidMove(board.WinningCombos[i, 2]) && check == -1)
                    {
                        move = board.WinningCombos[i, 2];
                        pieces[move] = true;
                        check = 0;
                    }
                    else if (x.Pieces[board.WinningCombos[i, 0]] == true && x.Pieces[board.WinningCombos[i, 2]] == true && board.ValidMove(board.WinningCombos[i, 1]) && check == -1)
                    {
                        move = board.WinningCombos[i, 1];
                        pieces[move] = true;
                        check = 0;
                    }
                    else if (x.Pieces[board.WinningCombos[i, 1]] == true && x.Pieces[board.WinningCombos[i, 2]] == true && board.ValidMove(board.WinningCombos[i, 0]) && check == -1)
                    {
                        move = board.WinningCombos[i, 0];
                        pieces[move] = true;
                        check = 0;
                    }
                }
            }
            //if neither of the above we find the next open spot based on out moveArray list
            while (check == -1 && index < moveArray.Length)
            {
                if (board.ValidMove(moveArray[index]))
                {
                    move = moveArray[index];
                    pieces[move] = true;
                    check = 0;
                }
                index++;
            }

            return move;
        }
    }
}
