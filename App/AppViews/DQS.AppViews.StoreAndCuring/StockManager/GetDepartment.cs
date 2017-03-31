using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public class GetDepartment
    {
        public int departmentID { get; set; }

        public string departmentName { get; set; }
    }

    public class StoreDetail
    {
        public int StoreDetailID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string PackageSpec { get; set; }
        public string ProducerName { get; set; }
        public string BatchNo { get; set; }
        public string DepartmentName { get; set; }
        public int Amount { get; set; }

        public StoreDetail() { }

        public StoreDetail(int storeDetailID, string productCode, string productName, string packageSpec, string producerName, string batchNo,
            string departmentName, int amount)
        {
            this.StoreDetailID = storeDetailID;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.PackageSpec = packageSpec;
            this.ProducerName = producerName;
            this.BatchNo = batchNo;
            this.DepartmentName = departmentName;
            this.Amount = amount;
        }
    }
}
