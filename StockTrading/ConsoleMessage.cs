using System;
using System.Collections.Generic;
using System.Text;

namespace StockTrading
{
    class ConsoleMessage : IMessage
    {
        public void displayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
