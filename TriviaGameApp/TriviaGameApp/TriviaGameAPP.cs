using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoDLL;

namespace TriviaGameApp
{
    class TriviaGameAPP
    {
        static void Main(string[] args)
        {
            string assignment = "Trivia Game";
            Console.WriteLine(Info.DisplayInfo(assignment));
            Controller c = new Controller();
            c.PlayGame();

        }
    }
}
