namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car Class Examples

            //// Creating an Object of the Class Car
            //// Creating an instance of the Class Car
            //Car audi = new Car("Audi","A3",false);
            //Car bmw = new Car("BMW","i7",true);            

            //// GETTING BRAND
            //Console.WriteLine("Brand is " + audi.Brand);
            //Console.WriteLine("Brand is " + bmw.Brand);

            // Customer Class Examples

            Customer earl = new Customer("Earl");
            //Console.WriteLine("Name of Customer is " + earl.Name);

            Customer frankTheTank = new Customer("FrankTheTank", "MainStreet 1", "5551234567");
            ////Console.WriteLine("Name of Customer is " + frankTheTank.Name +
            ////                  "\nAddress of customer is " + frankTheTank.Address +
            ////                  "\nContact number of customer is " + frankTheTank.ContactNumber);

            //Customer myCustomer = new Customer();
            //Console.WriteLine("Please enter the customer name:");
            //myCustomer.Name = Console.ReadLine();

            //Console.WriteLine("Details about customer "+ myCustomer.Name);

            // Car Class Methods Example

            //Car myAudi = new Car("A3","Audi",false);
            //myAudi.Drive();

            //Car myBmw = new Car("i7", "BMW", true);
            //myBmw.Drive();


            //Another Method Example

            Customer myCustomer = new Customer();
            myCustomer.SetDetails("Frank", "MainStreet 2", "555657657865");

            Console.WriteLine("My Customer is " + myCustomer.Name
                              + " and he lives in " + myCustomer.Address);

            Console.WriteLine("earl is " + earl.Name
                              + " and he lives in " + earl.Address);

            Console.ReadKey();
        }
    }
}
