namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2DDeclaration = new int[3, 3];
            // [0] [0] [0]
            // [0] [0] [0]
            // [0] [0] [0]

            int[,,] array3DDeclaration = new int[3, 3, 3];

            // initialized 3D array
            string[,,] simple3DArray =
            {
                {
                    {"000", "001" },
                    {"010", "011" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                }
            };

            //assign a value
            Console.WriteLine(simple3DArray[0, 1, 0]);

            //int[,] array2DInitialized = {{1,2}, {3,4}};
            //// [1] [2]  //row 0
            //// [3] [4]  //row 1

            //string[,] ticTacToeField =
            //{
            //    {"O","X","X"},
            //    {"O","O","X" },
            //    {"X","X","O" }
            //};

            //string[,] understandingIndexes =
            //{
            //    {"0,0","0,1","0,2"},
            //    {"1,0","1,1","1,2" },
            //    {"2,0","2.1","2.2" }
            //};

            ////Console.WriteLine(ticTacToeField[1,2]);

            //foreach (var item in understandingIndexes)
            //    Console.WriteLine(item);

            //Console.WriteLine(array2DInitialized[1,0]);

            //array2DInitialized[0, 0] = 5;

            //Console.WriteLine(array2DInitialized[1, 0]);

            // declare an array
            //int[] myIntArray = new int[5];            
            //int[] myIntArray = [0,1,2,3,5];
            //string[] weekDays = ["Mon","Tue","Wed","Thd","Fry","Sat","Sun"];

            ////Console.WriteLine("Today is " + weekDays[0]);

            //foreach (var item in weekDays)            
            //    Console.WriteLine(item);            

            // Initialize array and print each number using a foreach loop
            int[] myArray = [1, 2, 3, 4, 5];

            foreach (var item in myArray)
                Console.WriteLine(item);

            Console.ReadLine();

        }
    }
}
