using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////
            ///CODE Challenge//
            ///////////////////
            //try
            //{
            //    Console.Write("Trying...");
            //}
            //finally
            //{
            //    Console.Write("Finally executed.\n");
            //}

            int result = 0;

            Debug.WriteLine("Main method is running");

            try
            {
                Console.WriteLine("Please enter a number");
                int num2 = int.Parse(Console.ReadLine());
                int num1 = 2;

                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DON'T DIVIDE BY ZERO!! " + ex.Message);
                result = 10;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("DON'T USE TEXT, ONLY NUMBERS PLEASE!! " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("YOU USED A NUMBER TOO HIGH! " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                // This next line is only executed during "Debugging"
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                // Code to cleanup or finalize
                // ideal for cleaning up resources,
                // like closing file streams or database connections.

                Console.WriteLine("This always executes");
            }

            Console.WriteLine("Result: " + result);
            Console.ReadKey();



            //Console.WriteLine("Please enter your age");

            //// Non-static GetUserAge method
            ////Program program = new Program();            
            ////program.GetUserAge(Console.ReadLine());

            //// Static GetUserAge method
            //GetUserAge(Console.ReadLine());

            //Console.ReadKey();
        }

        static int GetUserAge(string input)
        {
            int age = 0;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age");
            }
            if (age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }
            return age;
        }
    }
}
