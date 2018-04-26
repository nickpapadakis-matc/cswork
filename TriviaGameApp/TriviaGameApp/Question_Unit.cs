using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGameApp
{
    class Question_Unit
    {
        /// <summary>
        /// Class made to store read in file data and return it via instances of this class
        /// </summary>
        string question;
        string[] answers = new string[4];
        string correctAnswer;
        string explination;
        public string Question { get { return question; } set { question = value; } }
        public string[] Answers { get { return answers; } set { answers = value; } }
        public string CorrectAnswer { get { return correctAnswer; } set { correctAnswer = value; } }
        public string Explination { get { return explination; } set { explination = value; } }

        public Question_Unit()  
        {

        }

    }
}
