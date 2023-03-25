namespace StockExchangeMonitor
{
    public class Monitor
    {
        public delegate void PriceChange(int price);
        public PriceChange PriceChangeHandler { get; set; }

        // имитация деятельности 
        public void Start()
        {
            while (true)
            {
                int bankOfAmericaPrice = (new Random()).Next(100);
                PriceChangeHandler(bankOfAmericaPrice);
                Thread.Sleep(2000);
            }
        }
    }
}