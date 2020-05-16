using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StockTrading.Test
{
    [TestClass]
    public class PortfolioTests
    {
        Portfolio port;
        [TestInitialize]
        public void Setup(){
             port = new Portfolio(10000);
        }

        [TestMethod]
        public void ConstructorTest()
        {

            Assert.AreEqual(10000, port.Cash);
        }

        [TestMethod]
        public void BuyTest(){

        }
    }
}
