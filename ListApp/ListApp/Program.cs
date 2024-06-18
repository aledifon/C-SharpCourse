namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring List (without initializing)
            //List<string> colors = new List<string>();
            //colors.Add("red");
            //colors.Add("blue");
            //colors.Add("green");
            //colors.Add("red");

            // Declaring a list and initializing
            List<string> colors = ["red", "blue", "green", "red"];

            colors.Add("blue");

            Console.WriteLine("Current colors in the color list!");
            foreach (string color in colors)
                Console.WriteLine(color);

            // Remove all "red" elements in the list

            // Alternative way with do-while loop
            //bool isDeletingSuccesful;
            //do
            //{
            //    isDeletingSuccesful = colors.Remove("red");
            //}while (isDeletingSuccesful);                

            // Predicated way
            //colors.RemoveAll(str => str == "red");

            // Show the New List without "red" colors
            Console.WriteLine("Current colors in the color list!");
            foreach (string color in colors)
                Console.WriteLine(color);

            Console.ReadKey();
        }
    }
}
