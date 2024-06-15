namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.SetDetails("Denis", "MainStreet 1");

            Customer customer1 = new Customer();

            Console.WriteLine("contactnumber of Frank is " + customer1.ContactNumber);
            

            Console.WriteLine(customer.Name + "\n" + customer.Address + "\n" + customer.ContactNumber);
            Console.ReadKey();
        }
    }
}
