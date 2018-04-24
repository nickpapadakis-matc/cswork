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

        public void PlayGame()
        {
            bool playAgain = true;
            do
            {
                Play();
                Console.WriteLine("\n\t\tPress [Y] or type [Yes] to play again");
                if (Console.ReadLine().ToUpper().Substring(0, 1) == "Y")
                    playAgain = true;
                else
                    playAgain = false;

            } while (playAgain);
        }

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
                  Console.WriteLine("\t\t" + asterick);
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
    }
}
