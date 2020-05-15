using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    public class Portfolio
    {
        Stocks stocks = new Stocks();
        IMessage message = new ConsoleMessage();
        Dictionary<string, Position> holdings = new Dictionary<string, Position>();
        public double Cash { get; private set; }
        public Portfolio(double cash)
        {
            this.Cash = cash;
        }

        public void Buy(string stockTicker, double quantity)
        {
            double price = stocks.GetQoute(stockTicker);
            double totalCost = price * quantity;
            if(Cash > totalCost)
            {
                if (holdings.ContainsKey(stockTicker))
                {
                    holdings[stockTicker].shares += quantity;
                }
                else
                {
                    Position position = new Position(new Stock(stockTicker, price), quantity);
                    holdings.Add(position.stock.Name, position);
                }
                
                
                Cash -= totalCost;
                message.displayMessage($"Bought {totalCost} worth of {stockTicker}\n Remaining balance {Cash}");
            }
            else
            {
                message.displayMessage("Not enough funds");
            }

            
        }

        public void Sell(string stockTicker, double quantity)
        {
            double price = stocks.GetQoute(stockTicker);
            double totalValue = price * quantity;
            if (checkHoldings(stockTicker, quantity))
            {
                Position position = new Position(new Stock(stockTicker, price), quantity);
                holdings.Add(position.stock.Name, position);
                Cash += totalValue;
                message.displayMessage($"Sold {totalValue} worth of {stockTicker}\n Remaining balance {Cash}");
            }
            else
            {
                message.displayMessage($"Not enough holdings. Tried to sell {quantity} " +
                    $"but only had {holdings[stockTicker].shares}");
            }
        }

        private bool checkHoldings(string stockTicker, double quantity)
        {
            return holdings.ContainsKey(stockTicker) && holdings[stockTicker].shares >= quantity;
        }

        public void PrintHoldings()
        {
            foreach(var holding in holdings)
            {
                Console.WriteLine($"{holding.Key} : {holding.Value.shares} ");
            }
        }



      
    }
    
}
