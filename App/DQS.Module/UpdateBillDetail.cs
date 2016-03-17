using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.Module
{
    public class UpdateBillDetail
    {
        public int DetailID { get; set; }

        public int ProductID { get; set; }

        public string BatchNo { get; set; }

        public int Amount { get; set; }

        public double UnitPrice { get; set; }

        public double TradePrice { get; set; }

        public double RetailPrice { get; set; }

        public double TotalPrice { get; set; }

        public int NoAmount { get; set; }

        public int InStoreID { get; set; }

    }
}
