namespace OldStyle
{
    internal class Program
    {
        // Field (or instance variable) - sometimes even called global variables
        static int myResult;

        static void Main(string[] args)
        {
            // Methods are structured like this
            // modifer returnType MethodName(Parameters{
            // code block
            // }            

            int num1 = int.Parse(Console.ReadLine());

            myResult = AddTwoValues(num1, 2);
            Console.WriteLine("Result is " + myResult);
            Console.ReadKey();                        
        }
        static int AddTwoValues(int value1, int value2)
        {
            myResult = value1 + value2;                
            return myResult;
        }

        static int SubstractTwoValues(int value1, int value2)
        {
            myResult = value1 - value2;            
            return myResult;
        }
    }
}
