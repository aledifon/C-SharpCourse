namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer myCustomer = new Customer();

            // The DoSomeCustomerStuffs method is static and cannot be called on Objects
            //myCustomer.DoSomeCustomerStuffs();

            MyMethod();
            
            Console.ReadKey();
        }

        // In C#, the static keyword is used to declare
        // members of a class that belong to the class itself
        // rather than to any specific instance of the class

        static void MyMethod()
        {
            Console.WriteLine("My Method");
        }
    }
}
