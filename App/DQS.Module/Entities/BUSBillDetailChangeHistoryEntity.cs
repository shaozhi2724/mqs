/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-05 23:42:26
 *	Build Type: Entity
 *	Description: BUSBillDetailChangeHistoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSBillDetailChangeHistoryEntity : EntityBase
	{
		public int DetailHistoryID
		{
			get { return (int)this.GetValue("DetailHistoryID"); } 
			set { this.SetValue("DetailHistoryID", value); } 
		}

		public Guid BillHistoryID
		{
			get { return (Guid)this.GetValue("BillHistoryID"); } 
			set { this.SetValue("BillHistoryID", value); } 
		}

		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int BillID
		{
			get { return (int)this.GetValue("BillID"); } 
			set { this.SetValue("BillID", value); } 
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

		public double UnitPrice
		{
			get { return (double)this.GetValue("UnitPrice"); } 
			set { this.SetValue("UnitPrice", value); } 
		}

		public double TotalPrice
		{
			get { return (double)this.GetValue("TotalPrice"); } 
			set { this.SetValue("TotalPrice", value); } 
		}

		public double TradePrice
		{
			get { return (double)this.GetValue("TradePrice"); } 
			set { this.SetValue("TradePrice", value); } 
		}

		public double RetailPrice
		{
			get { return (double)this.GetValue("RetailPrice"); } 
			set { this.SetValue("RetailPrice", value); } 
		}

		public Guid CreateUserID
		{
			get { return (Guid)this.GetValue("CreateUserID"); } 
			set { this.SetValue("CreateUserID", value); } 
		}

		public DateTime CreateDate
		{
			get { return (DateTime)this.GetValue("CreateDate"); } 
			set { this.SetValue("CreateDate", value); } 
		}

		public Guid LastModifyUserID
		{
			get { return (Guid)this.GetValue("LastModifyUserID"); } 
			set { this.SetValue("LastModifyUserID", value); } 
		}

		public DateTime LastModifyDate
		{
			get { return (DateTime)this.GetValue("LastModifyDate"); } 
			set { this.SetValue("LastModifyDate", value); } 
		}

		public string DetailRemark
		{
			get { return (string)this.GetValue("DetailRemark"); } 
			set { this.SetValue("DetailRemark", value); } 
		}

		public int StoreAmount
		{
			get { return (int)this.GetValue("StoreAmount"); } 
			set { this.SetValue("StoreAmount", value); } 
		}

		public string Reservation1
		{
			get { return (string)this.GetValue("Reservation1"); } 
			set { this.SetValue("Reservation1", value); } 
		}

		public string Reservation2
		{
			get { return (string)this.GetValue("Reservation2"); } 
			set { this.SetValue("Reservation2", value); } 
		}

		public string Reservation3
		{
			get { return (string)this.GetValue("Reservation3"); } 
			set { this.SetValue("Reservation3", value); } 
		}

		public string Reservation4
		{
			get { return (string)this.GetValue("Reservation4"); } 
			set { this.SetValue("Reservation4", value); } 
		}

		public string Reservation5
		{
			get { return (string)this.GetValue("Reservation5"); } 
			set { this.SetValue("Reservation5", value); } 
		}

		public string Reservation6
		{
			get { return (string)this.GetValue("Reservation6"); } 
			set { this.SetValue("Reservation6", value); } 
		}

		public string Reservation7
		{
			get { return (string)this.GetValue("Reservation7"); } 
			set { this.SetValue("Reservation7", value); } 
		}

		public string Reservation8
		{
			get { return (string)this.GetValue("Reservation8"); } 
			set { this.SetValue("Reservation8", value); } 
		}

		public string Reservation9
		{
			get { return (string)this.GetValue("Reservation9"); } 
			set { this.SetValue("Reservation9", value); } 
		}

		public string Reservation10
		{
			get { return (string)this.GetValue("Reservation10"); } 
			set { this.SetValue("Reservation10", value); } 
		}

		public BUSBillDetailChangeHistoryEntity()
		{
			this.TableName = "BUS_BillDetailChangeHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailHistoryID", BUSBillDetailChangeHistoryEntityFields.DetailHistoryID);
			this.Fields.Add("BillHistoryID", BUSBillDetailChangeHistoryEntityFields.BillHistoryID);
			this.Fields.Add("DetailID", BUSBillDetailChangeHistoryEntityFields.DetailID);
			this.Fields.Add("BillID", BUSBillDetailChangeHistoryEntityFields.BillID);
			this.Fields.Add("ProductID", BUSBillDetailChangeHistoryEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSBillDetailChangeHistoryEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSBillDetailChangeHistoryEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSBillDetailChangeHistoryEntityFields.ValidateDate);
			this.Fields.Add("Amount", BUSBillDetailChangeHistoryEntityFields.Amount);
			this.Fields.Add("UnitPrice", BUSBillDetailChangeHistoryEntityFields.UnitPrice);
			this.Fields.Add("TotalPrice", BUSBillDetailChangeHistoryEntityFields.TotalPrice);
			this.Fields.Add("TradePrice", BUSBillDetailChangeHistoryEntityFields.TradePrice);
			this.Fields.Add("RetailPrice", BUSBillDetailChangeHistoryEntityFields.RetailPrice);
			this.Fields.Add("CreateUserID", BUSBillDetailChangeHistoryEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSBillDetailChangeHistoryEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSBillDetailChangeHistoryEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSBillDetailChangeHistoryEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSBillDetailChangeHistoryEntityFields.DetailRemark);
			this.Fields.Add("StoreAmount", BUSBillDetailChangeHistoryEntityFields.StoreAmount);
			this.Fields.Add("Reservation1", BUSBillDetailChangeHistoryEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSBillDetailChangeHistoryEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSBillDetailChangeHistoryEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSBillDetailChangeHistoryEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSBillDetailChangeHistoryEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSBillDetailChangeHistoryEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSBillDetailChangeHistoryEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSBillDetailChangeHistoryEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSBillDetailChangeHistoryEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSBillDetailChangeHistoryEntityFields.Reservation10);
		}
	}

	#region BUSBillDetailChangeHistoryEntityFields

	public class BUSBillDetailChangeHistoryEntityFields
	{
		public static EntityField DetailHistoryID
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 0, "DetailHistoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BillHistoryID
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 1, "BillHistoryID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField DetailID
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 2, "DetailID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 3, "BillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 4, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 5, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 6, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 7, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 8, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField UnitPrice
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 9, "UnitPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField TotalPrice
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 10, "TotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField TradePrice
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 11, "TradePrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField RetailPrice
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 12, "RetailPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 13, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 14, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 15, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 16, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 17, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreAmount
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 18, "StoreAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 19, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 20, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 21, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 22, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 23, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 24, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 25, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 26, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 27, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_BillDetailChangeHistory", 28, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSBillDetailChangeHistoryEntityFields2

	public enum BUSBillDetailChangeHistoryEntityFields2
	{
		DetailHistoryID,

		BillHistoryID,

		DetailID,

		BillID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		Amount,

		UnitPrice,

		TotalPrice,

		TradePrice,

		RetailPrice,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		DetailRemark,

		StoreAmount,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

		Reservation6,

		Reservation7,

		Reservation8,

		Reservation9,

		Reservation10,

	}

	#endregion

}
