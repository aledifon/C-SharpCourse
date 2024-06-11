namespace LoopsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The For Loop

            // in strings \ is an "Escape character"
            // \n stands for "new line"
            // \r - carriage return

            //string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

            //for (int counter = 10; counter >= 0; counter--) 
            //{
            //    Console.Clear();
            //    Console.WriteLine("Counter is " + counter);
            //    Console.WriteLine(rocket);
            //    rocket = "\r\n" + rocket;
            //    Thread.Sleep(1000);
            //}
            //Console.WriteLine("The rocket has landed!");

            //Console.ReadKey();

            // The while loop

            //Random random = new Random(); 

            //int secretNumber = random.Next(1,101) ;
            //int counter = 0;
            //int userGuess = 0;

            //Console.WriteLine("Guess the number I'm thinking of between 1 and 100");            

            //while (userGuess != secretNumber)
            //{
            //    counter++;
            //    Console.WriteLine("Enter your guess");
            //    userGuess = int.Parse(Console.ReadLine());
            //    if (userGuess < secretNumber)
            //        Console.WriteLine("Too low! Try again");
            //    else if (userGuess > secretNumber)
            //        Console.WriteLine("Too high! Try again");
            //    else
            //        Console.WriteLine("Congratulations! You guessed the number right! It took you " + counter + " tries!");                
            //}            

            //Console.ReadKey();

            // ADVENTURE GAME

            //Console.WriteLine("Welcome to the Adventure Game!");
            //Console.WriteLine("Enter your character's name: ");
            //string playerName = Console.ReadLine();
            //Console.WriteLine("Choose your character type (Warrior, Wizad, Archer)");
            //string characterType = Console.ReadLine();

            //Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of a dark forest");
            //Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");
            //string choice1 = Console.ReadLine();

            //if (choice1.ToLower() == "enter")
            //    Console.WriteLine("You bravely enter the forest");
            //else
            //    Console.WriteLine("You decide to camp out and wait for daylight");

            //bool gamesContinues = true;

            //while (gamesContinues)
            //{
            //    Console.WriteLine("You come to fork in the road. Go left or right?");
            //    string direction = Console.ReadLine();
            //    if (direction.ToLower() == "left")
            //    {
            //        Console.WriteLine("You find a treasure chest!");
            //        gamesContinues = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You encounter a wild beast!");
            //        Console.WriteLine("Flight or flee? (fight/flee)");
            //        string fightChoice = Console.ReadLine();
            //        if (fightChoice.ToLower() == "fight")
            //        {
            //            Random random = new Random();
            //            int luck = random.Next(1, 11);
            //            if (luck > 5)
            //            {
            //                Console.WriteLine("You beat the wild beast!");
            //                if (luck > 8)
            //                {
            //                    Console.WriteLine("The wild beast dropped a treasure!");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("The beast attacked you where you didn't expect it!");
            //                Console.WriteLine("It rammed it's tusks into your chest and you bleed out!");
            //                gamesContinues = false;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Game Over!");
            //Console.WriteLine("Thank you for playing the game!");
            //Console.ReadKey();


            //int currentScore;
            //int counter = 0;
            //int sum=0;            

            //// do-while loop is a post-test loop

            //do
            //{                
            //    Console.WriteLine("Enter your students score. Enter -1 to finish!");
            //    currentScore = int.Parse(Console.ReadLine());
            //    if (currentScore != -1)
            //    {
            //        sum = sum + currentScore;
            //        counter++;
            //    }                    
            //} while (currentScore != -1);

            //int average = sum / counter;

            //Console.WriteLine("The students score average is " + average);
            //Console.ReadKey();


            // break AND continue KEYWORDS
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
                if (i == 2)
                {
                    //Console.WriteLine("I've had enough");
                    //break;
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
