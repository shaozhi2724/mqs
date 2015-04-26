using ORMSCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DQS.Module.Entities
{
    public class BUSOnlyBillDetailEntity : EntityBase
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

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
		}

		public double PUnitPrice
		{
			get { return (double)this.GetValue("PUnitPrice"); } 
			set { this.SetValue("PUnitPrice", value); } 
		}

		public double SUnitPrice
		{
			get { return (double)this.GetValue("SUnitPrice"); } 
			set { this.SetValue("SUnitPrice", value); } 
		}

		public double PTotalPrice
		{
			get { return (double)this.GetValue("PTotalPrice"); } 
			set { this.SetValue("PTotalPrice", value); } 
		}

		public double STotalPrice
		{
			get { return (double)this.GetValue("STotalPrice"); } 
			set { this.SetValue("STotalPrice", value); } 
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

		public BUSOnlyBillDetailEntity()
		{
			this.TableName = "BUS_OnlyBillDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSOnlyBillDetailEntityFields.DetailID);
            this.Fields.Add("BillID", BUSOnlyBillDetailEntityFields.BillID);
            this.Fields.Add("ProductID", BUSOnlyBillDetailEntityFields.ProductID);
            this.Fields.Add("BatchNo", BUSOnlyBillDetailEntityFields.BatchNo);
            this.Fields.Add("ProduceDate", BUSOnlyBillDetailEntityFields.ProduceDate);
            this.Fields.Add("ValidateDate", BUSOnlyBillDetailEntityFields.ValidateDate);
            this.Fields.Add("Amount", BUSOnlyBillDetailEntityFields.Amount);
            this.Fields.Add("PUnitPrice", BUSOnlyBillDetailEntityFields.PUnitPrice);
            this.Fields.Add("SUnitPrice", BUSOnlyBillDetailEntityFields.SUnitPrice);
            this.Fields.Add("PTotalPrice", BUSOnlyBillDetailEntityFields.PTotalPrice);
            this.Fields.Add("STotalPrice", BUSOnlyBillDetailEntityFields.STotalPrice);
            this.Fields.Add("TradePrice", BUSOnlyBillDetailEntityFields.TradePrice);
            this.Fields.Add("RetailPrice", BUSOnlyBillDetailEntityFields.RetailPrice);
            this.Fields.Add("CreateUserID", BUSOnlyBillDetailEntityFields.CreateUserID);
            this.Fields.Add("CreateDate", BUSOnlyBillDetailEntityFields.CreateDate);
            this.Fields.Add("LastModifyUserID", BUSOnlyBillDetailEntityFields.LastModifyUserID);
            this.Fields.Add("LastModifyDate", BUSOnlyBillDetailEntityFields.LastModifyDate);
            this.Fields.Add("DetailRemark", BUSOnlyBillDetailEntityFields.DetailRemark);
		}
	}

	#region BUSOnlyBillDetailEntityFields

	public class BUSOnlyBillDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_OnlyBillDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BillID
		{
            get { return new EntityField("BUS_OnlyBillDetail", 1, "BillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
            get { return new EntityField("BUS_OnlyBillDetail", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
            get { return new EntityField("BUS_OnlyBillDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
            get { return new EntityField("BUS_OnlyBillDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
            get { return new EntityField("BUS_OnlyBillDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
            get { return new EntityField("BUS_OnlyBillDetail", 6, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PUnitPrice
		{
            get { return new EntityField("BUS_OnlyBillDetail", 7, "PUnitPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField SUnitPrice
		{
            get { return new EntityField("BUS_OnlyBillDetail", 8, "SUnitPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField PTotalPrice
		{
            get { return new EntityField("BUS_OnlyBillDetail", 9, "PTotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField STotalPrice
		{
            get { return new EntityField("BUS_OnlyBillDetail", 10, "STotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField TradePrice
		{
            get { return new EntityField("BUS_OnlyBillDetail", 11, "TradePrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField RetailPrice
		{
            get { return new EntityField("BUS_OnlyBillDetail", 12, "RetailPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
            get { return new EntityField("BUS_OnlyBillDetail", 13, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
            get { return new EntityField("BUS_OnlyBillDetail", 14, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
            get { return new EntityField("BUS_OnlyBillDetail", 15, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
            get { return new EntityField("BUS_OnlyBillDetail", 16, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_OnlyBillDetail", 17, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

    #region BUSOnlyBillDetailEntityFields2

    public enum BUSOnlyBillDetailEntityFields2
	{
		DetailID,

		BillID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		Amount,

		UnitPrice,

		PTotalPrice,

		STotalPrice,

		PTradePrice,

		STradePrice,

		RetailPrice,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		DetailRemark,

	}

	#endregion
}
