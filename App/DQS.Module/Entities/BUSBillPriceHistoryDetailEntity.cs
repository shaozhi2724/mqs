/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-15 11:09:47
 *	Build Type: Entity
 *	Description: BUSBillPriceHistoryDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSBillPriceHistoryDetailEntity : EntityBase
	{
		public int BillPriceHistoryDetailID
		{
			get { return (int)this.GetValue("BillPriceHistoryDetailID"); } 
			set { this.SetValue("BillPriceHistoryDetailID", value); } 
		}

		public int BillPriceHistoryID
		{
			get { return (int)this.GetValue("BillPriceHistoryID"); } 
			set { this.SetValue("BillPriceHistoryID", value); } 
		}

		public int BillID
		{
			get { return (int)this.GetValue("BillID"); } 
			set { this.SetValue("BillID", value); } 
		}

		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string BatchNo
		{
			get { return (string)this.GetValue("BatchNo"); } 
			set { this.SetValue("BatchNo", value); } 
		}

		public DateTime ProduceDate
		{
			get { return (DateTime)this.GetValue("ProduceDate"); } 
			set { this.SetValue("ProduceDate", value); } 
		}

		public DateTime ValidateDate
		{
			get { return (DateTime)this.GetValue("ValidateDate"); } 
			set { this.SetValue("ValidateDate", value); } 
		}

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
		}

		public double OldUnitPrice
		{
			get { return (double)this.GetValue("OldUnitPrice"); } 
			set { this.SetValue("OldUnitPrice", value); } 
		}

		public double OldTotalPrice
		{
			get { return (double)this.GetValue("OldTotalPrice"); } 
			set { this.SetValue("OldTotalPrice", value); } 
		}

		public double OldTradePrice
		{
			get { return (double)this.GetValue("OldTradePrice"); } 
			set { this.SetValue("OldTradePrice", value); } 
		}

		public double OldRetailPrice
		{
			get { return (double)this.GetValue("OldRetailPrice"); } 
			set { this.SetValue("OldRetailPrice", value); } 
		}

		public double AdjustPrice
		{
			get { return (double)this.GetValue("AdjustPrice"); } 
			set { this.SetValue("AdjustPrice", value); } 
		}

		public double AdjustTotalPrice
		{
			get { return (double)this.GetValue("AdjustTotalPrice"); } 
			set { this.SetValue("AdjustTotalPrice", value); } 
		}

		public double NewUnitPrice
		{
			get { return (double)this.GetValue("NewUnitPrice"); } 
			set { this.SetValue("NewUnitPrice", value); } 
		}

		public double NewTotalPrice
		{
			get { return (double)this.GetValue("NewTotalPrice"); } 
			set { this.SetValue("NewTotalPrice", value); } 
		}

		public double NewTradePrice
		{
			get { return (double)this.GetValue("NewTradePrice"); } 
			set { this.SetValue("NewTradePrice", value); } 
		}

		public double NewRetailPrice
		{
			get { return (double)this.GetValue("NewRetailPrice"); } 
			set { this.SetValue("NewRetailPrice", value); } 
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

        public int OldAmount
		{
            get { return (int)this.GetValue("OldAmount"); }
            set { this.SetValue("OldAmount", value); } 
		}

		public BUSBillPriceHistoryDetailEntity()
		{
			this.TableName = "BUS_BillPriceHistoryDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("BillPriceHistoryDetailID", BUSBillPriceHistoryDetailEntityFields.BillPriceHistoryDetailID);
			this.Fields.Add("BillPriceHistoryID", BUSBillPriceHistoryDetailEntityFields.BillPriceHistoryID);
			this.Fields.Add("BillID", BUSBillPriceHistoryDetailEntityFields.BillID);
			this.Fields.Add("DetailID", BUSBillPriceHistoryDetailEntityFields.DetailID);
			this.Fields.Add("ProductID", BUSBillPriceHistoryDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSBillPriceHistoryDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSBillPriceHistoryDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSBillPriceHistoryDetailEntityFields.ValidateDate);
			this.Fields.Add("Amount", BUSBillPriceHistoryDetailEntityFields.Amount);
			this.Fields.Add("OldUnitPrice", BUSBillPriceHistoryDetailEntityFields.OldUnitPrice);
			this.Fields.Add("OldTotalPrice", BUSBillPriceHistoryDetailEntityFields.OldTotalPrice);
			this.Fields.Add("OldTradePrice", BUSBillPriceHistoryDetailEntityFields.OldTradePrice);
			this.Fields.Add("OldRetailPrice", BUSBillPriceHistoryDetailEntityFields.OldRetailPrice);
			this.Fields.Add("AdjustPrice", BUSBillPriceHistoryDetailEntityFields.AdjustPrice);
			this.Fields.Add("AdjustTotalPrice", BUSBillPriceHistoryDetailEntityFields.AdjustTotalPrice);
			this.Fields.Add("NewUnitPrice", BUSBillPriceHistoryDetailEntityFields.NewUnitPrice);
			this.Fields.Add("NewTotalPrice", BUSBillPriceHistoryDetailEntityFields.NewTotalPrice);
			this.Fields.Add("NewTradePrice", BUSBillPriceHistoryDetailEntityFields.NewTradePrice);
			this.Fields.Add("NewRetailPrice", BUSBillPriceHistoryDetailEntityFields.NewRetailPrice);
			this.Fields.Add("CreateUserName", BUSBillPriceHistoryDetailEntityFields.CreateUserName);
			this.Fields.Add("CreateDate", BUSBillPriceHistoryDetailEntityFields.CreateDate);
            this.Fields.Add("OldAmount", BUSBillPriceHistoryDetailEntityFields.OldAmount);
		}
	}

	#region BUSBillPriceHistoryDetailEntityFields

	public class BUSBillPriceHistoryDetailEntityFields
	{
		public static EntityField BillPriceHistoryDetailID
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 0, "BillPriceHistoryDetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BillPriceHistoryID
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 1, "BillPriceHistoryID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 2, "BillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField DetailID
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 3, "DetailID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 4, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 5, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 6, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 7, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 8, "Amount", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField OldUnitPrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 9, "OldUnitPrice", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField OldTotalPrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 10, "OldTotalPrice", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField OldTradePrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 11, "OldTradePrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField OldRetailPrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 12, "OldRetailPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField AdjustPrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 13, "AdjustPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField AdjustTotalPrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 14, "AdjustTotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField NewUnitPrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 15, "NewUnitPrice", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField NewTotalPrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 16, "NewTotalPrice", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField NewTradePrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 17, "NewTradePrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField NewRetailPrice
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 18, "NewRetailPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField CreateUserName
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 19, "CreateUserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_BillPriceHistoryDetail", 20, "CreateDate", SqlDbType.DateTime, false, false, false, false); }
		}

        public static EntityField OldAmount
		{
            get { return new EntityField("BUS_BillPriceHistoryDetail", 21, "OldAmount", SqlDbType.Int, false, false, false, false); }
		}

	}

	#endregion

	#region BUSBillPriceHistoryDetailEntityFields2

	public enum BUSBillPriceHistoryDetailEntityFields2
	{
		BillPriceHistoryDetailID,

		BillPriceHistoryID,

		BillID,

		DetailID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		Amount,

		OldUnitPrice,

		OldTotalPrice,

		OldTradePrice,

		OldRetailPrice,

		AdjustPrice,

		AdjustTotalPrice,

		NewUnitPrice,

		NewTotalPrice,

		NewTradePrice,

		NewRetailPrice,

		CreateUserName,

		CreateDate,

        OldAmount,

	}

	#endregion

}
