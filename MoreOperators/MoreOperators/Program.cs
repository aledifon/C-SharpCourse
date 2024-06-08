namespace MoreOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int num = 10;
            double price = 19.95;
            string name = "Frank";

            //Interpolation
            Console.WriteLine($"The number is {num}");

            //Concatenation
            Console.WriteLine("The number is " + num);


            //String formatting
            Console.WriteLine("The number is {0}, and the price is {1}" +
                            " and the name is {2}", num, price, name);

            //Console.WriteLine("Hello{0}{1}World!", '\n','\t');

            Console.ReadKey();
        }
    }
}
