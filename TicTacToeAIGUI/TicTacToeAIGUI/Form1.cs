using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeAIGUI
{
    public partial class Form1 : Form
    {
        int userMove = 0;
        Board board = new Board();
        HumanPlayer x = new HumanPlayer();
        ComputerPlayer o = new ComputerPlayer();
        public Form1()
        {
            InitializeComponent();
            ResetBoard();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            String buttonSender = ((Button)sender).Name;
            Button buttonText = btnTLeft; //has to be assigned at start of method, will change in switch statement
            switch (buttonSender)
            {
                case "btnTLeft":
                    userMove = 0;
                    buttonText = btnTLeft;
                    break;
                case "btnTMiddle":
                    userMove = 1;
                    buttonText = btnTMiddle;
                    break;
                case "btnTRight":
                    userMove = 2;
                    buttonText = btnTRight;
                    break;
                case "btnCLeft":
                    userMove = 3;
                    buttonText = btnCLeft;
                    break;
                case "btnCMiddle":
                    userMove = 4;
                    buttonText = btnCMiddle;
                    break;
                case "btnCRight":
                    userMove = 5;
                    buttonText = btnCRight;
                    break;
                case "btnBLeft":
                    userMove = 6;
                    buttonText = btnBLeft;
                    break;
                case "btnBMiddle":
                    userMove = 7;
                    buttonText = btnBMiddle;
                    break;
                case "btnBRight":
                    userMove = 8;
                    buttonText = btnBRight;
                    break;
            }
            if (!board.ValidMove(userMove))
            {
                MessageBox.Show("Please Select a open spot");
                board.Count--;
            }
            else if(board.IsPlaying() == 0)
            {
                HumanPlaying(buttonText);
             
            }

                ComputerPlaying(buttonText);
            
            
            if (board.IsFull())
            {
                MessageBox.Show("The result of the game is tie!");
                ResetBoard();
            }
        }

        public void HumanPlaying(Button b)
        {
                board.GameArray[userMove] = "X";
                b.Text = board.GameArray[userMove];
                x.MakeMove(board, userMove, x);
                if (board.DetermineWin(x, o))
                {
                    MessageBox.Show("*Player X is the winner*");
                    ResetBoard();
                }
                board.Count++;
        }

        public void ComputerPlaying(Button b)
        {
          
            userMove = o.MakeMove(board, userMove, x);
            switch (userMove)
            {
                case 0:
                    b = btnTLeft;
                    break;
                case 1:
                    b = btnTMiddle;
                    break;
                case 2:
                    b = btnTRight;
                    break;
                case 3:
                    b = btnCLeft;
                    break;
                case 4:
                    b = btnCMiddle;
                    break;
                case 5:
                    b = btnCRight;
                    break;
                case 6:
                    b = btnBLeft;
                    break;
                case 7:
                    b = btnBMiddle;
                    break;
                case 8:
                    b = btnBRight;
                    break;
            }
           
            board.GameArray[userMove] = "O";
            b.Text = board.GameArray[userMove];
            if (board.DetermineWin(x, o))
            {
                MessageBox.Show("Player O is the winner!");
                ResetBoard();
                board.Count--;
            }           //i know this is weird, but its the only way i could get it to work
                        //these forms apps are very touchy with counts
                board.Count++;  
        }

        public void ResetBoard()
        {
            for (int i = 0; i < board.GameArray.Length; i++)
            {
                board.GameArray[i] = " ";
            }
            btnBMiddle.Text = " ";
            btnBLeft.Text = " ";
            btnBRight.Text = " ";
            btnCMiddle.Text = " ";
            btnCLeft.Text = " ";
            btnCRight.Text = " ";
            btnTMiddle.Text = " ";
            btnTLeft.Text = " ";
            btnTRight.Text = " ";
            board.Count = 0;
            for (int i = 0; i < x.Pieces.Length; i++)
            {
                x.Pieces[i] = false;
                o.Pieces[i] = false;
            }
        }
    }
    
}
