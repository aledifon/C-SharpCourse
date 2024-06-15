namespace ClassesApp
{
    // Access Modifier internal
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car("A3","Audi",false);
            //car3.Drive();

            //// accesing the public static variable NumberOfCars of the Car Class
            //Console.WriteLine("Number of cars produced: " + Car.NumberOfCars);            

            // Reading a private read-only field

            Customer customer = new Customer();
            Customer customer2 = new Customer("John Doe");
            Customer customer3 = new Customer();

            Console.WriteLine("The 1st Customer ID is " + customer.Id + "\n");
            Console.WriteLine("The 2nd Customer ID is " + customer2.Id + "\n");
            Console.WriteLine("The 3rd Customer ID is " + customer3.Id + "\n");

            customer.GetDetails();
            customer2.GetDetails();
            customer3.GetDetails();

            Console.ReadKey();
        }


    }
}
