using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccountManagement
{  
    // this class represents information of an Stock
    public class Stock
    {
        public String name { get; set; }
        public int NumberOfShares { get; set; }
        public int SharePrice { get; set; }
        public int StockPrice { get; set; }

        // string representation of Stock class
        public override string ToString()
        {
            return String.Format("Name: {0}\nPrice: {1}\nNumber of Shares: {2}", name, SharePrice, NumberOfShares);
        }
    }

    // this class contains the list of stocks and total stock price
    public class StockPortfolio
    {
        public int grandTotal { get; set; }
        public List<Stock> StockList;
    }
}