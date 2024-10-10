namespace EventsApp
{
    public delegate void TemperatureChangeHandler(string message);    

    // Event publisher
    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler OnRaiseTemperatureChanged;
        public event TemperatureChangeHandler OnDropTemperatureChanged;

        private int _temperature;
        public int Temperature 
        {   get { return _temperature; }
            set
            {
                _temperature = value;
                if (_temperature > 30)
                {
                    //_temperature= (int)(_temperature * 1.8) + 32;

                    // RAISE EVENT!!                    
                    RaiseTemperatureChangedEvent("Temperature is above threshold!");
                }
                else if (_temperature < 10) 
                {
                    // DROP EVENT!!                    
                    DropTemperatureChangedEvent("Temperature is below threshold!");
                }
            } 
        }

        //// Class constructor
        //public TemperatureMonitor(int temperature)
        //{
        //    Temperature=temperature;
        //}

        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnRaiseTemperatureChanged?.Invoke(message);
        }
        protected virtual void DropTemperatureChangedEvent(string message)
        {
            OnDropTemperatureChanged?.Invoke(message);
        }

    }

    // Event subscriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine("Temperature System Handler\nTemperature Alert!: " + message);
        }
    }

    public class CoolingSystemAlert
    {
        public void OnRaiseTemperatureChanged(string message)
        {
            Console.WriteLine("Cooling System Handler\nTemperature Alert!: " + 
                                message + "\n" + "Enabling Cooling system");
        }

        public void OnDropTemperatureChanged(string message)
        {
            Console.WriteLine("Cooling System Handler\nTemperature Alert!: " +
                                message + "\n" + "Disabling Cooling system");
        }
    }

    public class PhoneMessagesHandler
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine("Phone System Handler\nTemperature alert!: " + message);
        }        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            CoolingSystemAlert coolingSystem = new CoolingSystemAlert();
            PhoneMessagesHandler phoneMessages = new PhoneMessagesHandler();

            monitor.OnRaiseTemperatureChanged += alert.OnTemperatureChanged;
            monitor.OnRaiseTemperatureChanged += coolingSystem.OnRaiseTemperatureChanged;
            monitor.OnRaiseTemperatureChanged += phoneMessages.OnTemperatureChanged;

            monitor.OnDropTemperatureChanged += alert.OnTemperatureChanged;
            monitor.OnDropTemperatureChanged += coolingSystem.OnDropTemperatureChanged;
            monitor.OnDropTemperatureChanged += phoneMessages.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        } 
    }
}
