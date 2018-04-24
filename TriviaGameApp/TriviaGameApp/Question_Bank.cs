using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TriviaGameApp
{
    class Question_Bank
    {
        string fileName = "questions.txt";
        const int NUMBER_OF_ANSWERS = 4;
        const int NUMBER_OF_QUESTIONS = 5;
        Question_Unit[] questionBank = new Question_Unit[NUMBER_OF_QUESTIONS];
        public Question_Bank()
        {

        }

        public void ReadQuestionFile()
        {
            try
            {
                using (StreamReader readFile = new StreamReader(fileName))
                {
                    for (int i = 0; i < NUMBER_OF_QUESTIONS; i++)
                    {
                        questionBank[i] = new Question_Unit();
                        questionBank[i].Question = readFile.ReadLine();
                        for (int j = 0; j < NUMBER_OF_ANSWERS; j++)
                        {
                            questionBank[i].Answers[j] = readFile.ReadLine();
                        }
                        questionBank[i].CorrectAnswer = readFile.ReadLine();
                        questionBank[i].Explination = readFile.ReadLine();
                    }
                
                }               
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went terribly wrong" + e.Message);
                
            }         
        }

        public string GetQuestion(int index)
        {
            return "\t\t" + questionBank[index].Question;
        }

        public string GetAnswers(int index)
        {
            string answers = "";
            for(int i = 0; i < NUMBER_OF_ANSWERS; i++)
            {
                switch (i)
                {
                    case 0:
                        answers += "\t\tA. " + questionBank[index].Answers[i] + "\n"; 
                        break;
                    case 1:
                        answers += "\t\tB. " + questionBank[index].Answers[i] + "\n"; 
                        break;
                    case 2:
                        answers += "\t\tC. " + questionBank[index].Answers[i] + "\n";
                        break;
                    case 3:
                        answers += "\t\tD. " + questionBank[index].Answers[i] + "\n"; ;
                        break;
                }
            }
            return answers;
        }

        public string CorrectAnswer(int index)
        {
            return questionBank[index].CorrectAnswer;
        }

        public string Explination(int index)
        {
            return "\t\t" + questionBank[index].Explination;
        }
    }
}
