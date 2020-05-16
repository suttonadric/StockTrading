using System;
using System.IO;
using System.Net;

namespace StockTrading
{
	/// <summary>
	/// Using https://finnhub.io/docs/api
	/// </summary>
	public class FinnHubQuery : IQouteProvider
	{
		public FinnHubQuery()
		{
		}
		//requests.get('https://finnhub.io/api/v1/quote?symbol=AAPL&token=')
		public double GetQoute(string stockTicker)
		{
			string sURL = $"https://finnhub.io/api/v1/quote?symbol={stockTicker}&token=bqvurs7rh5rbirao31g0";
			Console.WriteLine(sURL);
			WebRequest wrGETURL = WebRequest.Create(sURL);

			Stream objStream;
			objStream = wrGETURL.GetResponse().GetResponseStream();

			StreamReader objReader = new StreamReader(objStream);

			string sLine = "";
			int i = 0;

			while (sLine != null)
			{
				i++;
				sLine = objReader.ReadLine();
				if (sLine != null)
					Console.WriteLine("{0}:{1}", i, sLine);
			}
			return 0;


		}
	}
}
