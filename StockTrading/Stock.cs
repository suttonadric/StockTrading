using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    class Stock
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Stock(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        
    }
}
