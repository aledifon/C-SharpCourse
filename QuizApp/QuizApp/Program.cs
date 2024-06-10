namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Questions
            string[] questions = new string[3];
            string[] answers = new string[3];

            //string[] userAnswers = new string[3];

            questions[0] = "What is the capital of Germany";
            answers[0] = "berlin";

            questions[1] = "What is 2+2";
            answers[1] = "4";

            questions[2] = "What color do yzou get by mixing blue and yellow";
            answers[2] = "green";

            int score = 0;            

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                //userAnswers[i] = Console.ReadLine();

                //if (userAnswers[i] == answers[i])
                if (Console.ReadLine().Trim().ToLower() == answers[i].ToLower())
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else                
                    Console.WriteLine($"Wrong, the correct answer is: {answers[i]} ");
                    //if (score>0) 
                    //    score--;                                    
            }

            if (score == 3)
                Console.WriteLine("\nExcellent all the answers are correct! \n" + $"Your final score is {score}/3");
            else if (score < 3 && score>0)
                Console.WriteLine($"\nThank you for participate in the quiz! \n" +$"Your final score is {score}/3");
            else
                Console.WriteLine($"\nOmg, all the answers were wrong :-(! \n" +$"Your final score is {score}/3");

            Console.ReadKey();
        }
    }
}
