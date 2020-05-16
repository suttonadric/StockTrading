using System;

namespace StockTrading
{

	public interface IQouteProvider
	{
		public double GetQoute(string stockTicker);
	}
}