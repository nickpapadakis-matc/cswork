using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAIGUI
{
    public class HumanPlayer : Player
    {
        public HumanPlayer()
            : base()
        {

        }
        /// <summary>
        /// takes the move from the form1 class based on which button was clicked and sets 
        /// the humanplayers bit array via that variable.
        /// </summary>
        public override int MakeMove(Board board, int move, HumanPlayer player)
        {
            pieces[move] = true;
            return move;
        }
    }
}
