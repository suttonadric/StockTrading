namespace StockTrading
{
    internal class Position
    {
        public Stock stock { get; set; }
        public double shares { get; set; }

        public Position(Stock stock, double shares)
        {
            this.stock = stock;
            this.shares = shares;
        }
        public void AddShares(double shares)
        {
            this.shares += shares;
        }
      
    }
}