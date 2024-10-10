namespace StockPriceAlertAdvanceEx
{
    public delegate void StockPriceChangedHandler(string message);
    public class Stock
    {
        public event StockPriceChangedHandler OnStockPriceChanged;

        private decimal _price;
        private decimal _threshold;

        // TODO: Implement the Price property with event triggering
        public decimal Price 
        { 
            get { return _price; } 
            set 
            { 
                _price = value;                
                if (_price < _threshold)
                {
                    // TRIGGER EVENT if price drops below the threshold
                    RaiseStockPriceChangedEvent("Stock Alert: Stock price is below threshold!");
                }
                else
                {
                    Console.WriteLine($"No alert for {_price}");
                }
            } 
        }

        // TODO: Implement the Threshold property
        public decimal Threshold 
        {
            get { return _threshold; }
            set { _threshold = value; }            
        }
        
        // TODO: Implement the RaiseStockPriceChangedEvent method
        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            OnStockPriceChanged?.Invoke(message);
        }
    }

    public class StockAlert
    {
        // TODO: Implement the OnStockPriceChanged method
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {            
            TestStockPriceAlerts();
        }
        static void TestStockPriceAlerts()
        {
            // TODO: Implement the stock price alert test 
            Stock stock = new Stock();                  // Event Publisher instance
            StockAlert stockAlert = new StockAlert();   // Event Subscriber instance
            stock.OnStockPriceChanged += stockAlert.OnStockPriceChanged;

            stock.Threshold = 120;

            stock.Price = 150;
            stock.Price = 130;
            stock.Price = 110;
            Console.ReadKey();
        }
    }
}
