using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.Module
{
    public class TakeOff
    {
        public int DetailID { get; set; }

        public int ProductID { get; set; }

        public int StructureID { get; set; }

        public string StructureCode { get; set; }

        public string StructureName { get; set; }

        public string ProductName { get; set; }

        public string ProductBatchNumber { get; set; }

        public DateTime ProductionDate { get; set; }

        public DateTime ProductValidDate { get; set; }

        public int ProductAmount { get; set; }

        public string PackageSpec { get; set; }

        public string ProducerName { get; set; }

        public int Amount { get; set; }
    }
}
