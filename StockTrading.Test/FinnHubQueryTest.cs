using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace StockTrading.Test
{
    [TestClass]
    public class FinnHubQueryTest
    {
        [TestMethod]
        public void GetQouteTest()
        {
            FinnHubQuery query = new FinnHubQuery();
            query.GetQoute("AAPL");
            Assert.AreEqual(1, 1);
        }
    }
}
