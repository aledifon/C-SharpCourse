using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    internal class Questions
    {
        // Static Fields
        private static int nextId = 0;        


        // Read-Only Properties
        public int Id {get;}
        
        public string QuestionText { get; }

        public string[] Answers { get; }

        public int CorrectAnswerIndex { get;}


        // Constructor
        public Questions(string questionText, string[] answers, int correctAnswerIndex)
        {
            Id = nextId++;          

            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return choice == CorrectAnswerIndex;
        }

    }
}
