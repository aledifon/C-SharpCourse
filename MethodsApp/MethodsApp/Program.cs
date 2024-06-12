using System.Runtime.CompilerServices;

namespace MethodsApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            // Methods are structured like this
            // modifer returnType MethodName(Parameters{
            // code block
            // }

            int myresult;
                                    
            int AddTwoValues(int value1, int value2)
            {
                int result = value1 + value2;       
                myresult = result;
                return result;
            }

            int SubstractTwoValues(int value1, int value2)
            {
                int result = value1 - value2;
                myresult = result;
                return result;
            }

            //int num1 = int.Parse(Console.ReadLine());

            //int myResult = AddTwoValues(num1, 2);

            //Console.WriteLine("Result is " + myResult);

            Console.WriteLine("This is outside of the method");
            Console.ReadKey();

        }
    }
}
