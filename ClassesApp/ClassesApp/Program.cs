﻿namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an Object of the Class Car
            // Creating an instance of the Class Car
            Car audi = new Car("Audi","A3",false);
            Car bmw = new Car("BMW","i7",true);            

            // GETTING BRAND
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);

            Console.ReadKey();
        }
    }
}
