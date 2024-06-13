namespace WeatherStationSimulator
{    
    internal class Program
    {
        static string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };

        static double GetAverageTemp(int[] temp)
        {
            // Solution A
            double sum = 0;
            foreach (var item in temp)
                sum += item;
            return sum / temp.Length;

            // Solution B
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    sum += temp[i];
            //}
            //return sum / temp.Length;

            // Solution C (LINQ)
            //return temp.Average();
        }

        static int GetMaxTemp(int[] temp)
        {
            // Solution A
            int max = temp[0];
            foreach (var item in temp)
            {
                if (item > max) max = item;
            }
            return max;

            // Solution B
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    if (temp[i] > max)  max = temp[i];
            //}
            //return max;

            // Solution C (LINQ)
            //return temp.Max();
        }

        static int GetMinTemp(int[] temp)
        {
            // Solution A
            int min = temp[0];
            foreach (var item in temp)
            {
                if (item < min) min = item;
            }
            return min;

            // Solution B
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    if (temp[i] < min)  min = temp[i];
            //}
            //return min;

            // Solution C (LINQ)
            //return temp.Min();
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
            //Console.WriteLine("\nThe hightest temperature of these " + days + " days has been " + GetMaxTemp(temperature) + "°");
            Console.WriteLine("\nThe hightest temperature of these " + days + " days has been " + temperature.Max() + "°");
            //Show the lowest temp
            //Console.WriteLine("\nThe lowest temperature of these " + days + " days has been " + GetMinTemp(temperature) + "°");
            Console.WriteLine("\nThe lowest temperature of these " + days + " days has been " + temperature.Min() + "°");
            //Show the average temp
            //Console.WriteLine("\nThe average temperature of these " + days + " days has been " + GetAverageTemp(temperature) + "°");
            Console.WriteLine("\nThe average temperature of these " + days + " days has been " + temperature.Average() + "°");
            //Show the most common weather condition            
            Console.WriteLine("\nThe most part ot the time of these " + days + " days the weather has been " + GetMostCommonCondition(weatherConditions));

            Console.ReadKey();
            //arrays, random gen, for loops, methods, 
        }
    }
}
