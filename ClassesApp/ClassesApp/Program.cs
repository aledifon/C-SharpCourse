namespace ClassesApp
{
    // Access Modifier internal
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3","Audi",false);
            car3.Drive();

            // accesing the public static variable NumberOfCars of the Car Class
            Console.WriteLine("Number of cars produced: " + Car.NumberOfCars);            
            
            Console.ReadKey();
        }


    }
}
