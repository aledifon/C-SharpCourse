namespace LogicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;            

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());            

            if (age >= 18)            
                Console.WriteLine("Go to party in the club");            
            else if (age >= 13)
            {
                Console.WriteLine("Are you with your parents? Answer with y or n");
                string isWithParents = Console.ReadLine();
                if (isWithParents == "y")
                    Console.WriteLine("Go to party in the club with your parents");
                else
                    Console.WriteLine("Not party for you today");
            }
            else
                Console.WriteLine("Go party in kindergarten");

            Console.ReadKey();

            /*
            bool isRainy = true;
            bool hasUmbrella = true;

            // Logical Operators
            // AND &&
            // OR ||
            // NOT !

            if (!isRainy || hasUmbrella)
            {
                Console.WriteLine("I'm not getting wet");                
            }
            Console.WriteLine("Ay ok");
            Console.ReadKey();
            */
        }
    }
}
