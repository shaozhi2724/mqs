/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-10 17:38:10
 *	Build Type: Entity
 *	Description: BUSBillPriceHistoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSBillPriceHistoryEntity : EntityBase
	{
		public int BillPriceHistoryID
		{
			get { return (int)this.GetValue("BillPriceHistoryID"); } 
			set { this.SetValue("BillPriceHistoryID", value); } 
		}

		public string BillPriceHistoryCode
		{
			get { return (string)this.GetValue("BillPriceHistoryCode"); } 
			set { this.SetValue("BillPriceHistoryCode", value); } 
		}

		public int BillID
		{
			get { return (int)this.GetValue("BillID"); } 
			set { this.SetValue("BillID", value); } 
		}

		public string BillCode
		{
			get { return (string)this.GetValue("BillCode"); } 
			set { this.SetValue("BillCode", value); } 
		}

		public string DealerCode
		{
			get { return (string)this.GetValue("DealerCode"); } 
			set { this.SetValue("DealerCode", value); } 
		}

		public string DealerName
		{
			get { return (string)this.GetValue("DealerName"); } 
			set { this.SetValue("DealerName", value); } 
		}

		public int ProductAmount
		{
			get { return (int)this.GetValue("ProductAmount"); } 
			set { this.SetValue("ProductAmount", value); } 
		}

		public double OldTotalPrice
		{
			get { return (double)this.GetValue("OldTotalPrice"); } 
			set { this.SetValue("OldTotalPrice", value); } 
		}

		public double NewTotalPrice
		{
			get { return (double)this.GetValue("NewTotalPrice"); } 
			set { this.SetValue("NewTotalPrice", value); } 
		}

		public string PriceHistoryRemark
		{
			get { return (string)this.GetValue("PriceHistoryRemark"); } 
			set { this.SetValue("PriceHistoryRemark", value); }
        }

        public int BillStatus
        {
            get { return (int)this.GetValue("BillStatus"); }
            set { this.SetValue("BillStatus", value); }
        }

        public string BillStatusName
        {
            get { return (string)this.GetValue("BillStatusName"); }
            set { this.SetValue("BillStatusName", value); }
        }

		public string CreateUserName
		{
			get { return (string)this.GetValue("CreateUserName"); } 
			set { this.SetValue("CreateUserName", value); } 
		}

		public DateTime CreateDate
		{
			get { return (DateTime)this.GetValue("CreateDate"); } 
			set { this.SetValue("CreateDate", value); } 
		}

		public BUSBillPriceHistoryEntity()
		{
			this.TableName = "BUS_BillPriceHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("BillPriceHistoryID", BUSBillPriceHistoryEntityFields.BillPriceHistoryID);
			this.Fields.Add("BillPriceHistoryCode", BUSBillPriceHistoryEntityFields.BillPriceHistoryCode);
			this.Fields.Add("BillID", BUSBillPriceHistoryEntityFields.BillID);
			this.Fields.Add("BillCode", BUSBillPriceHistoryEntityFields.BillCode);
			this.Fields.Add("DealerCode", BUSBillPriceHistoryEntityFields.DealerCode);
			this.Fields.Add("DealerName", BUSBillPriceHistoryEntityFields.DealerName);
			this.Fields.Add("ProductAmount", BUSBillPriceHistoryEntityFields.ProductAmount);
			this.Fields.Add("OldTotalPrice", BUSBillPriceHistoryEntityFields.OldTotalPrice);
			this.Fields.Add("NewTotalPrice", BUSBillPriceHistoryEntityFields.NewTotalPrice);
			this.Fields.Add("PriceHistoryRemark", BUSBillPriceHistoryEntityFields.PriceHistoryRemark);
            this.Fields.Add("BillStatus", BUSBillPriceHistoryEntityFields.BillStatus);
            this.Fields.Add("BillStatusName", BUSBillPriceHistoryEntityFields.BillStatusName);
			this.Fields.Add("CreateUserName", BUSBillPriceHistoryEntityFields.CreateUserName);
			this.Fields.Add("CreateDate", BUSBillPriceHistoryEntityFields.CreateDate);
		}
	}

	#region BUSBillPriceHistoryEntityFields

	public class BUSBillPriceHistoryEntityFields
	{
		public static EntityField BillPriceHistoryID
		{
			get { return new EntityField("BUS_BillPriceHistory", 0, "BillPriceHistoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BillPriceHistoryCode
		{
			get { return new EntityField("BUS_BillPriceHistory", 1, "BillPriceHistoryCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_BillPriceHistory", 2, "BillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_BillPriceHistory", 3, "BillCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_BillPriceHistory", 4, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_BillPriceHistory", 5, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductAmount
		{
			get { return new EntityField("BUS_BillPriceHistory", 6, "ProductAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField OldTotalPrice
		{
			get { return new EntityField("BUS_BillPriceHistory", 7, "OldTotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField NewTotalPrice
		{
			get { return new EntityField("BUS_BillPriceHistory", 8, "NewTotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField PriceHistoryRemark
		{
			get { return new EntityField("BUS_BillPriceHistory", 9, "PriceHistoryRemark", SqlDbType.NVarChar, false, false, false, false); }
        }

        public static EntityField BillStatus
        {
            get { return new EntityField("BUS_BillPriceHistory", 10, "BillStatus", SqlDbType.Int, false, false, false, false); }
        }

        public static EntityField BillStatusName
        {
            get { return new EntityField("BUS_BillPriceHistory", 11, "BillStatusName", SqlDbType.NVarChar, false, false, false, false); }
        }

		public static EntityField CreateUserName
		{
			get { return new EntityField("BUS_BillPriceHistory", 12, "CreateUserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_BillPriceHistory", 13, "CreateDate", SqlDbType.DateTime, false, false, false, false); }
		}

	}

	#endregion

	#region BUSBillPriceHistoryEntityFields2

	public enum BUSBillPriceHistoryEntityFields2
	{
		BillPriceHistoryID,

		BillPriceHistoryCode,

		BillID,

		BillCode,

		DealerCode,

		DealerName,

		ProductAmount,

		OldTotalPrice,

		NewTotalPrice,

		PriceHistoryRemark,

        BillStatus,

        BillStatusName,

		CreateUserName,

		CreateDate,

	}

	#endregion

}
