using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.Module
{
    public class SaleViewDetail
    {
        public int InStoreDetailID { get; set; }

        public int ProductID { get; set; }

        public string BatchNo { get; set; }

        public DateTime ProduceDate { get; set; }

        public DateTime ValidateDate { get; set; }

        public string SterilizationBatchNo { get; set; }

        public DateTime SterilizationDate { get; set; }

        public int OutAmount { get; set; }

        public int Amount { get; set; }

        public double UnitPrice { get; set; }

        public double TotalPrice { get; set; }

        public double TradePrice { get; set; }

        public double RetailPrice { get; set; }

        public string Reservation1 { get; set; }

        public string isPrint { get; set; }

    }
}
