namespace DelegatesAndEvents
{
    //public delegate void LogHandler(string message);

    //public class Logger
    //{
    //    public void LogToConsole(string message)
    //    {
    //        Console.WriteLine("Console Log: " + message);
    //    }

    //    public void LogToFile(string message)
    //    {
    //        Console.WriteLine("File log: " + message);
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {

            //Logger logger = new Logger();
            //LogHandler logHandler = logger.LogToConsole;
            //logHandler("Logging to console");

            //logHandler = logger.LogToFile;
            //logHandler("Log some stuff");

            int[] intArray = { 1, 2, 3, 4, 5};
            string[] stringArray = { "One", "Two", "Three", "Four"};

            // Generic method calls
            PrintArray(intArray);
            PrintArray(stringArray);
            Console.ReadKey();
        }

        // GENERICS example

        public static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        // This method replaces the two previous methods by using generics "T"
        // "T" replaces any datatype

        // a generic method, that accepts a generic datatype
        public static void PrintArray<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
