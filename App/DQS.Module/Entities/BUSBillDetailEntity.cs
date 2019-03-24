/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-17 22:22:22
 *	Build Type: Entity
 *	Description: BUSBillDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSBillDetailEntity : EntityBase
	{
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

        public string SterilizationBatchNo
		{
            get { return (string)this.GetValue("SterilizationBatchNo"); }
            set { this.SetValue("SterilizationBatchNo", value); } 
		}

        public DateTime SterilizationDate
		{
            get { return (DateTime)this.GetValue("SterilizationDate"); }
            set { this.SetValue("SterilizationDate", value); } 
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

        public double InUnitPrice
        {
            get { return (double)this.GetValue("InUnitPrice"); }
            set { this.SetValue("InUnitPrice", value); }
        }

		public BUSBillDetailEntity()
		{
			this.TableName = "BUS_BillDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSBillDetailEntityFields.DetailID);
			this.Fields.Add("BillID", BUSBillDetailEntityFields.BillID);
			this.Fields.Add("ProductID", BUSBillDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSBillDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSBillDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSBillDetailEntityFields.ValidateDate);
            this.Fields.Add("SterilizationBatchNo", BUSBillDetailEntityFields.SterilizationBatchNo);
            this.Fields.Add("SterilizationDate", BUSBillDetailEntityFields.SterilizationDate);
			this.Fields.Add("Amount", BUSBillDetailEntityFields.Amount);
			this.Fields.Add("UnitPrice", BUSBillDetailEntityFields.UnitPrice);
			this.Fields.Add("TotalPrice", BUSBillDetailEntityFields.TotalPrice);
			this.Fields.Add("TradePrice", BUSBillDetailEntityFields.TradePrice);
			this.Fields.Add("RetailPrice", BUSBillDetailEntityFields.RetailPrice);
			this.Fields.Add("CreateUserID", BUSBillDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSBillDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSBillDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSBillDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSBillDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSBillDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSBillDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSBillDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSBillDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSBillDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSBillDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSBillDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSBillDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSBillDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSBillDetailEntityFields.Reservation10);
            this.Fields.Add("InUnitPrice", BUSBillDetailEntityFields.InUnitPrice);
		}
	}

	#region BUSBillDetailEntityFields

	public class BUSBillDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_BillDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_BillDetail", 1, "BillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_BillDetail", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_BillDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_BillDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_BillDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField SterilizationBatchNo
		{
            get { return new EntityField("BUS_BillDetail", 6, "SterilizationBatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField SterilizationDate
		{
            get { return new EntityField("BUS_BillDetail", 7, "SterilizationDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_BillDetail", 8, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField UnitPrice
		{
			get { return new EntityField("BUS_BillDetail", 9, "UnitPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField TotalPrice
		{
			get { return new EntityField("BUS_BillDetail", 10, "TotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField TradePrice
		{
			get { return new EntityField("BUS_BillDetail", 11, "TradePrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField RetailPrice
		{
			get { return new EntityField("BUS_BillDetail", 12, "RetailPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_BillDetail", 13, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_BillDetail", 14, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_BillDetail", 15, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_BillDetail", 16, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_BillDetail", 17, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_BillDetail", 18, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_BillDetail", 19, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_BillDetail", 20, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_BillDetail", 21, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_BillDetail", 22, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_BillDetail", 23, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_BillDetail", 24, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_BillDetail", 25, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_BillDetail", 26, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_BillDetail", 27, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField InUnitPrice
		{
            get { return new EntityField("BUS_BillDetail", 28, "InUnitPrice", SqlDbType.Float, false, false, false, true); }
		}

	}

	#endregion

	#region BUSBillDetailEntityFields2

	public enum BUSBillDetailEntityFields2
	{
		DetailID,

		BillID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,
        
        SterilizationBatchNo,
        
        SterilizationDate,

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

        InUnitPrice,

	}

	#endregion

}
