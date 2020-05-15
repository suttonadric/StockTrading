using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StockTrading.Test
{
    [TestClass]
    public class PortfolioTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Portfolio port = new Portfolio(10000);
            Assert.AreEqual(10000, port.Cash);
        }
    }
}
