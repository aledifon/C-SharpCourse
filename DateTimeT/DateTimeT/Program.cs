namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = new DateTime(1988,5,31);

            //Console.WriteLine("My birthday is {0}", dateTime);

            //// Write today on screen
            //Console.WriteLine(DateTime.Today);
            //// Write current time on screen
            //Console.WriteLine(DateTime.Now);

            //// Write current time on screen
            //Console.WriteLine("Tomorrow will be the {0}", GetTomorrow(DateTime.Now));
            //Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);

            //Console.WriteLine("The 1st day of the year is {0}",GetFirstDayOfYear(1999));

            //int days = DateTime.DaysInMonth(2000, 2);
            //Console.WriteLine("Days in Feb 2000: {0}", days);
            //days = DateTime.DaysInMonth(2001, 2);
            //Console.WriteLine("Days in Feb 2001: {0}", days);
            //days = DateTime.DaysInMonth(2004, 2);
            //Console.WriteLine("Days in Feb 2004: {0}", days);

            //DateTime now = DateTime.Now;
            //Console.WriteLine("Minute: {0}", now.Minute);

            //// display the time in this structure x o'clock and y minutes and z seconds
            //Console.WriteLine("{0} o'clock and {1} minutes and {2} seconds",now.Hour,now.Minute,now.Second);

            //Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            //string input = Console.ReadLine();
            //if (DateTime.TryParse(input, out dateTime) && dateTime<now)
            //{
            //    Console.WriteLine(dateTime);
            //    TimeSpan daysPassed = now.Subtract(dateTime);
            //    Console.WriteLine("Days passed since: {0}",daysPassed.Days);
            //}               
            //else
            //    Console.WriteLine("Wrong input");

            DateTime now = DateTime.Now;
            DateTime dateTime; // = new DateTime();

            Console.WriteLine("Please enter your birth date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime) && dateTime < now)
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("You are {0} days old", daysPassed.Days);
            }
            else
                Console.WriteLine("Wrong input");

            Console.ReadKey();
        }

        static DateTime GetTomorrow(DateTime day)
        {
            return day.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year,1,1);
        }
        
    }
}
