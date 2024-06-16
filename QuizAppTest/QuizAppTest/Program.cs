namespace QuizAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Questions[] questions = new Questions[] 
            {                
                new Questions("What is the capital of France?",                         // Question Text
                             ["Paris","London","Rome","Berlin"],                        // Answers Array
                            //new string[] {"Paris","London","Rome","Berlin"},          // Alternative way of Answer array initialization
                             1),                                                        // CorrectAnswerIndex    
                new Questions("What is 2 + 2",
                            ["3","4","5","6"],
                            2),
                new Questions("Who wrote 'Hamlet'",
                            ["Goethe","Shakespeare","Austen","Dickens"],
                             2)
            };

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();

            Console.ReadKey();
        }
    }
}
