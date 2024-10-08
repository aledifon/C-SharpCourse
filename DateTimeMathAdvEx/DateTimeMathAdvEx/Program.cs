namespace DateTimeMathAdvEx
{
    public struct Event
    {
        public DateTime StartDate;
        public DateTime EndDate;

        public double GetDuration()
        {            
            return EndDate.Subtract(StartDate).Days;
        }

        public bool IsOverlapping(Event otherEvent)
        {
            if (otherEvent.StartDate > EndDate ||
                otherEvent.EndDate < StartDate)
                return false;            
            else              
                return true;            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Event event1 = new Event();
            event1.StartDate = new DateTime(2024,07,01);
            event1.EndDate = new DateTime(2024, 07,10);
            Event event2 = new Event();
            event2.StartDate = new DateTime(2024, 07, 05);
            event2.EndDate = new DateTime(2024, 07, 15);

            Console.WriteLine("Event 1 Duration: {0} days",event1.GetDuration());
            Console.WriteLine("Event 2 Duration: {0} days",event2.GetDuration());
            Console.WriteLine("Events Overlap: {0}",event1.IsOverlapping(event2));
            
            Console.ReadKey();
        }
    }
}
