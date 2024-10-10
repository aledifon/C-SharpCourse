namespace EventsApp
{
    // Using the Generic Delegate EventHandler<TEventArgs>

    //public delegate void TemperatureChangeHandler(string message);    

    public class TemperatureChangedEventArgs : EventArgs
    {
        // Property holding the temperature
        public int Temperature { get; }

        // Constructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }


    // Event publisher
    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        //public event TemperatureChangeHandler OnRaiseTemperatureChanged;        

        private int _temperature;
        public int Temperature 
        {   get { return _temperature; }
            set
            {
                //_temperature = value;

                //if (_temperature > 30)
                if (_temperature != value)
                {
                    _temperature = value;                    
                    // RAISE EVENT!!                    
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }                
            } 
        }

        //// Class constructor
        //public TemperatureMonitor(int temperature)
        //{
        //    Temperature=temperature;
        //}

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Letting every subscriber know!
            TemperatureChanged?.Invoke(this,e);
        }        
    }

    // Event subscriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature} sender is : {sender}");
        }
    }

    public class TempCoolingAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Temp Cooling Alert: temperature is {e.Temperature} sender is : {sender}");
        }
    }

    //public class CoolingSystemAlert
    //{
    //    public void OnRaiseTemperatureChanged(string message)
    //    {
    //        Console.WriteLine("Cooling System Handler\nTemperature Alert!: " + 
    //                            message + "\n" + "Enabling Cooling system");
    //    }
    //    //public void OnDropTemperatureChanged(string message)
    //    //{
    //    //    Console.WriteLine("Cooling System Handler\nTemperature Alert!: " +
    //    //                        message + "\n" + "Disabling Cooling system");
    //    //}
    //}

    //public class PhoneMessagesHandler
    //{
    //    public void OnTemperatureChanged(string message)
    //    {
    //        Console.WriteLine("Phone System Handler\nTemperature alert!: " + message);
    //    }        
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TempCoolingAlert alert2 = new TempCoolingAlert();
            //CoolingSystemAlert coolingSystem = new CoolingSystemAlert();
            //PhoneMessagesHandler phoneMessages = new PhoneMessagesHandler();

            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += alert2.OnTemperatureChanged;
            //monitor.OnRaiseTemperatureChanged += coolingSystem.OnRaiseTemperatureChanged;
            //monitor.OnRaiseTemperatureChanged += phoneMessages.OnTemperatureChanged;

            //monitor.OnDropTemperatureChanged += alert.OnTemperatureChanged;
            //monitor.OnDropTemperatureChanged += coolingSystem.OnDropTemperatureChanged;
            //monitor.OnDropTemperatureChanged += phoneMessages.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        } 
    }
}
