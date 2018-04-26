using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGameApp
{
    class Controller
    {
        public Controller()
        {

        }
        /// <summary>
        /// game loop to let user replay the quiz
        /// </summary>
        public void PlayGame()
        {
            bool playAgain = true;
            do
            {
                GameDirections();
                Console.ReadLine();
                Play();
                Console.WriteLine("\n\t\tPress [Y] or type [Yes] to play again");
                if (Console.ReadLine().ToUpper().Substring(0, 1) == "Y")
                    playAgain = true;
                else
                    playAgain = false;

            } while (playAgain);
        }
        /// <summary>
        /// method that runs the quiz. Makes a QuestionBank object and calls its methods
        /// to get question and answers using a for loop to determine what question/answer combo to get
        /// </summary>
        public void Play()
        {
            string userAnswer = "";
            Question_Bank qBank = new Question_Bank();
            qBank.ReadQuestionFile();
            int count = 0;
            string asterick = "*********************************";
              for (int i = 0; i < 5; i++)
              {
                  Console.Clear();
                  Console.WriteLine("\n\t\t" + asterick);
                  Console.WriteLine("\n\t\tQuestions " + (i + 1) + ": ");
                  Console.WriteLine("\t\t" + asterick);
                  Console.WriteLine(qBank.GetQuestion(i));
                  Console.WriteLine(qBank.GetAnswers(i));
                  Console.Write("\n\t\tPlease enter your answer using the associated letter");
                  userAnswer = Console.ReadLine().ToUpper();
                  if (userAnswer == qBank.CorrectAnswer(i))
                  {
                      Console.WriteLine("\t\t" + asterick);
                      Console.WriteLine("\n\t\tThat is correct!!!");
                      Console.WriteLine(qBank.Explination(i));
                    count++;
                  }
                  else
                  {
                      Console.WriteLine("\n\t\tSorry that was incorrect. The correct answer was " + qBank.CorrectAnswer(i));
                      Console.WriteLine(qBank.Explination(i));
                  }
                  if(i < 4)
                  {
                      Console.WriteLine("\n\t\tPress enter to go to the next question.");
                      Console.WriteLine("\t\t" + asterick);
                  }
                  else
                  {
                      Console.WriteLine("\n\t\tYou got " + count + " correct!");
                      Console.WriteLine("\n\t\tThanks for playing!!!");
                      Console.WriteLine("\t\t" + asterick);
                  }
                  Console.ReadLine();
              }      
        }
        public void GameDirections()
        {
            string asterick = "*********************************";

            Console.WriteLine("\n\tTRIVIA GAME");
            Console.WriteLine("\n\t" + asterick);
            Console.WriteLine("\tThis app will ask you a multiple choice question");
            Console.WriteLine("\tAnswer by entering the assoiciated letter followed by the [ENTER] key");
            Console.WriteLine("\tHope you enjoy the quiz");
            Console.WriteLine("\tGoodLuck");
            Console.WriteLine("\tPress any key to continue");
            Console.WriteLine("\n\t" + asterick);
        }
    }
}
