// See https://aka.ms/new-console-template for more information
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Enter something!");

// datatype variableName = initial value;
//int myNumber = 0;


//Console.WriteLine("myNumber = " + myNumber);

// takes the user input and stores it
Console.WriteLine("Give me the 1st number");
//string str = Console.ReadLine();
//double test = double.Parse(str, CultureInfo.InvariantCulture);

bool userInput1Parsed = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double userinput1);
Console.WriteLine("Give me the 2nd number");
bool userInput2Parsed = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double userinput2);

if (userInput1Parsed & userInput2Parsed)
    // string concatenation  
    Console.WriteLine(userinput1.ToString(CultureInfo.InvariantCulture) + " + " + 
                    userinput2.ToString(CultureInfo.InvariantCulture) + " = " + 
                    (Math.Round(userinput1 + userinput2,2)).ToString(CultureInfo.InvariantCulture));

    // string interpolation
    //Console.WriteLine($" {userinput1} + {userinput2} = {userinput1 + userinput2}");
else
    Console.WriteLine("int.TryParse failed");

Console.ReadKey();

/////////////////////
// Shorter version///
/////////////////////
//Console.WriteLine("Give me the 1st & 2nd number");
//if (int.TryParse(Console.ReadLine(), out int userinput1) &
//    int.TryParse(Console.ReadLine(), out int userinput2))
//{
//    sum = userinput1 + userinput2;
//    Console.WriteLine(userinput1 + " + " + userinput2 + " = " + sum);
//}
//else
//    Console.WriteLine("int.TryParse failed");

//Console.ReadKey();