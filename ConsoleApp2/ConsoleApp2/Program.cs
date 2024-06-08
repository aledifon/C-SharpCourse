namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // implicit conversion

            int myInt = 1323450983;
            double myDouble = myInt;

            long myLong = myInt;
            myLong = 132343;

            // explicit conversion
            int myInt3;
            double myDouble3 = 13.5;
            myInt3 = (int)myDouble3;
            //Console.WriteLine(myInt3);


            int myInt2 = (int)myLong;
            myInt2 = (int)myDouble;
            //Console.WriteLine(myInt2);

            float myFloat = 123.1243f;
            myDouble = 13.22323232323;

            myFloat = (float)myDouble;

            //Console.WriteLine(myFloat);


            //Conversion Helpers Parse and Convert

            string numberString = "123";
            int result = int.Parse(numberString);


            string myBoolString = "true";
            bool myBool = Convert.ToBoolean(myBoolString);
            //bool myBool = bool.Parse(myBoolString);

            //Console.WriteLine("myBool is " + myBool);

            // implicitely typed variable
            var myFauvoriteGenre = "LitRPGs";

            var myFavouriteNumber = 13;

            var yourFavouriteNumber = 14;

            int ourNumbersCombined = myFavouriteNumber + yourFavouriteNumber;



            Console.ReadKey();

        }
    } 
}
