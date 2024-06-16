using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    internal class Quiz
    {
        // Field
        private Questions[] _questions;

        private int _score=0;

        // Constructor
        public Quiz(Questions[] questions) 
        {
            this._questions = questions;
        }

        // Public Methods
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!" + "\n\n");            

            foreach (var question in _questions)
            {
                Console.WriteLine("Question " + (question.Id + 1) + ":\n");
                DisplayQuestion(question);                                

                if (question.IsCorrectAnswer(GetUserChoice()))
                {
                    _score++;
                    Console.WriteLine("Correct!\n\n");
                }
                else
                    Console.WriteLine($"Wrong! The correct answer was {question.Answers[question.CorrectAnswerIndex-1]} \n\n");
            }            
            DisplayResults();
        }        
        // Private Methods
        private void DisplayQuestion(Questions question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();                                                       
            Console.WriteLine(question.QuestionText + "\n\t");            

            // Foreach Loop iterations
            int i = 0;
            foreach (var answer in question.Answers)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;        // changes the text color
                Console.Write("   ");
                Console.Write(++i);
                Console.ResetColor();                               // resets the foreground (text) color
                Console.WriteLine(". " + answer + "\n");
            }

            //For - Loop iterations
            //for (int i = 0; i < question.Answers.Length; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.Write("   ");
            //    Console.Write(i + 1);
            //    Console.ResetColor();
            //    Console.WriteLine(". " + question.Answers[i] + "\n");
            //}

        }
        private void DisplayResults() 
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length} questions!\n");

            double percentage = (double)_score / _questions.Length;            

            //if (_score == _questions.Length)
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You got all the questions right!");
            }
            //else if (_score > 0)
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Not bad! Try it harder next time.!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Omg! You still need to practice a lot");
            }
            Console.ResetColor();
        }
        private int GetUserChoice()
        {
            bool parsedOk = false;
            int answerChosen = 0;
            while (!parsedOk)
            {
                parsedOk = (int.TryParse(Console.ReadLine(), out answerChosen)) &&
                           (answerChosen <= 4 && answerChosen >= 1);

                if (!parsedOk)
                    Console.WriteLine("Invalid choice. Please insert a number between 1-4");
                else
                    Console.WriteLine("Your answer (number): " + answerChosen);
            }

            return answerChosen;
        }
    }
}
