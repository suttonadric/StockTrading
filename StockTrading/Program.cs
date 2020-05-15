using System;

namespace StockTrading
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock ibmStock = new Stock("IBM", 99.2);
            Portfolio port = new Portfolio(100000);

            port.Buy("IBM",2);

            port.PrintHoldings();
           
        }
    }
}
