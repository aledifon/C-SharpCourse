namespace WeatherStationSimulator
{    
    internal class Program
    {
        static string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };

        static double GetAverageTemp(int[] temp)
        {
            ////Solution A
            //int sum = 0;
            //foreach (var item in temp)
            //    sum += item;
            //return sum / temp.Length;

            // Solution B (LINQ)
            return temp.Average();
        }

        static int GetMaxTemp(int[] temp)
        {
            // Solution A
            //int max = temp[0];
            //foreach (var item in temp)
            //{
            //    if (item > max) max = item;
            //}
            //return max;

            // Solution B (LINQ)
            return temp.Max();
        }

        static int GetMinTemp(int[] temp)
        {
            // Solution A
            //int min = temp[0];
            //foreach (var item in temp)
            //{
            //    if (item < min) min = item;
            //}
            //return min;

            // Solution B (LINQ)
            return temp.Min();
        }

        static string GetMostCommonCondition(string[] wCond)
        {
            int[] conditionsOcurrences = new int[conditions.Length];            

            //Reset the conditions Ocurrences array
            for (int i = 0; i < conditionsOcurrences.Length; i++)
                conditionsOcurrences[i] = 0;

            //Increments the corresponding Conditions Ocurrences array
            for (int i = 0; i < wCond.Length; i++)            
                conditionsOcurrences[Array.IndexOf(conditions, wCond[i])]++;

            //Get the most common weather condition
            int mostCommonIndex = 0;
            for (int i = 0;i < conditionsOcurrences.Length; i++)
            {
                if (conditionsOcurrences[i] > conditionsOcurrences[mostCommonIndex])
                    mostCommonIndex = i;
            }
            return conditions[mostCommonIndex];            
        }
                 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine()); 
            
            int[] temperature = new int[days];
            
            //Console.WriteLine(Conditions.Rainy.ToString());            
            string[] weatherConditions = new string[days];

            Random random = new Random();  

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            //Show the higest temp
            Console.WriteLine("\nThe hightest temperature of these " + days + " days has been " + GetMaxTemp(temperature) + "°");
            //Show the lowest temp
            Console.WriteLine("\nThe lowest temperature of these " + days + " days has been " + GetMinTemp(temperature) + "°");
            //Show the average temp
            Console.WriteLine("\nThe average temperature of these " + days + " days has been " + GetAverageTemp(temperature) + "°");
            //Show the most common weather condition
            Console.WriteLine("\nThe most part ot the time of these " + days + " days the weather has been " + GetMostCommonCondition(weatherConditions));

            Console.ReadKey();
            //arrays, random gen, for loops, methods, 
        }
    }
}
