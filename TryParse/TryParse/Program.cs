namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an instance of the Random class
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            Console.WriteLine("Guess the number");


            Console.WriteLine("Give me a number");
            string inputString = Console.ReadLine();
            int num1=0;

            bool isNumber = int.TryParse(inputString, out num1 );

            if (isNumber)
            {
                if (num1 == randomNumber)
                    Console.WriteLine("You guessed right!");
                else
                    Console.WriteLine("You guessed wrong, try again!");
                //Console.WriteLine("User entered number +1 " + ++num1);
            }
            else
                Console.WriteLine("Please enter a number the next time");

            Console.ReadKey();
        }
    }
}
