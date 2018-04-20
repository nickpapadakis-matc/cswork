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
        public override int MakeMove(Board board, int move, HumanPlayer player)
        {
            pieces[move] = true;
            return move;
        }
    }
}
