using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TicTacToeAIGUI
{
    public abstract class Player
    {/// <summary>
     /// comments are in console version
     /// </summary>
        protected BitArray pieces;
        public BitArray Pieces { get { return pieces; } set { pieces = value; } }

        public Player()
        {
            pieces = new BitArray(9, false);
        }

        public abstract int MakeMove(Board board, int move, HumanPlayer player);
    }
}
