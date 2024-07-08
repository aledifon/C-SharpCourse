using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListApp
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { Name = "Apple", Price = 0.80},
                new Product { Name = "Banana", Price = 0.30},
                new Product { Name = "Cherry", Price = 3.80}

            };

            products.Add(new Product { Name = "Berries", Price = 2.99});

            Console.WriteLine("Available Products: ");

            foreach (Product product in products)              
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");            

            Console.WriteLine();
            Console.WriteLine();


            //LIST INITIALIZING & LIST ADDING/REMOVING ITEMS EXAMPLES

            //// Declaring List (without initializing)
            ////List<string> colors = new List<string>();
            ////colors.Add("red");
            ////colors.Add("blue");
            ////colors.Add("green");
            ////colors.Add("red");

            //// Declaring a list and initializing
            //List<string> colors = ["red", "blue", "green", "red"];

            //colors.Add("blue");

            //Console.WriteLine("Current colors in the color list!");
            //foreach (string color in colors)
            //    Console.WriteLine(color);

            //// Remove all "red" elements in the list

            //// Alternative way with do-while loop
            ////bool isDeletingSuccesful;
            ////do
            ////{
            ////    isDeletingSuccesful = colors.Remove("red");
            ////}while (isDeletingSuccesful);                

            //// Predicated way
            ////colors.RemoveAll(str => str == "red");

            //// Show the New List without "red" colors
            //Console.WriteLine("Current colors in the color list!");
            //foreach (string color in colors)
            //    Console.WriteLine(color);

            // Predicate example

            List<int> numbers = new List<int>() {10,5,15,3,9,25,18};

            Console.WriteLine("Unsorted List");
            foreach (int number in numbers)
                Console.WriteLine(number);

            bool hasLargeNumber = numbers.Any(x => x > 30);
            
            if (hasLargeNumber)
                Console.WriteLine("There are large numbers in the numbers list");
            else
                Console.WriteLine("No large numbers in the list");

            /*
             In C#, a delegate is like a pointer or a reference to a method.
            It allows you to pass methods as arguments to other methods,
            store them in variables, and call them later.
            This is useful when you want your code to be flexible and
            able to handle different behaviors that aren't predetermined

             */


            // Define the predicate to check if a number is greater than 10
            Predicate<int> isGreaterThanTen = x => x > 10;

            // This will return a list of numbers that are 10 or higher
            List<int> higherTen = numbers.FindAll(isGreaterThanTen);

            Console.WriteLine("All numbers 10 and higher in our list");
            foreach (var item in higherTen)           
                Console.WriteLine(item);
            
            //numbers.Sort();
            //Console.WriteLine("Sorted List");
            //foreach (int number in numbers)            
            //    Console.WriteLine(number);
            
            Console.ReadKey();

            // A lambda expression consists of 2 Parts
            // 1. Parameters
            // 2. Expresssion or Statement Blok

            // Parameters are written on the left side of =>
            // (this symbol is read as "goes to" or "becomes"
            // The expression or action to perform is on the right side.

            //This reads as:
            //"Take an input x and turn it into x multiplied by x."
            //x => x * x;

            static int Squaring(int num1)
            {
                return num1 * num1;
            }


        }
    }
}
