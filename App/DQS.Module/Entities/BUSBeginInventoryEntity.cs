/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSBeginInventoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;
namespace DQS.Module.Entities
{
    public class BUSBeginInventoryEntity : EntityBase
    {
		public int BeginInventoryID
		{
			get { return (int)this.GetValue("BeginInventoryID"); } 
			set { this.SetValue("BeginInventoryID", value); } 
		}
		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string ProductName
		{
            get { return (string)this.GetValue("ProductName"); }
            set { this.SetValue("ProductName", value); } 
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
		public decimal UnitPrice
		{
            get { return (decimal)this.GetValue("UnitPrice"); } 
			set { this.SetValue("UnitPrice", value); } 
		}
		public float TotalPrice
		{
			get { return (float)this.GetValue("TotalPrice"); } 
			set { this.SetValue("TotalPrice", value); } 
		}
        public int DepartmentID
		{
            get { return (int)this.GetValue("DepartmentID"); }
            set { this.SetValue("DepartmentID", value); } 
		}
        public string DepartmentName
		{
            get { return (string)this.GetValue("DepartmentName"); }
            set { this.SetValue("DepartmentName", value); } 
		}


        public BUSBeginInventoryEntity()
		{
            this.TableName = "BUS_BeginInventory";
			this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("BeginInventoryID", BUSBeginInventoryEntityFields.BeginInventoryID);
            this.Fields.Add("ProductID", BUSBeginInventoryEntityFields.ProductID);
            this.Fields.Add("ProductName", BUSBeginInventoryEntityFields.ProductName);
            this.Fields.Add("BatchNo", BUSBeginInventoryEntityFields.BatchNo);
            this.Fields.Add("ProduceDate", BUSBeginInventoryEntityFields.ProduceDate);
            this.Fields.Add("ValidateDate", BUSBeginInventoryEntityFields.ValidateDate);
            this.Fields.Add("SterilizationBatchNo", BUSBeginInventoryEntityFields.SterilizationBatchNo);
            this.Fields.Add("SterilizationDate", BUSBeginInventoryEntityFields.SterilizationDate);
            this.Fields.Add("Amount", BUSBeginInventoryEntityFields.Amount);
            this.Fields.Add("UnitPrice", BUSBeginInventoryEntityFields.UnitPrice);
            this.Fields.Add("DepartmentID", BUSBeginInventoryEntityFields.DepartmentID);
            this.Fields.Add("DepartmentName", BUSBeginInventoryEntityFields.DepartmentName);
		}
	}

    #region BUSBeginInventoryEntityFields

    public class BUSBeginInventoryEntityFields
    {
        public static EntityField BeginInventoryID
        {
            get { return new EntityField("BUS_BeginInventory", 0, "BeginInventoryID", SqlDbType.Int, true, true, true, false); }
        }
        public static EntityField ProductID
        {
            get { return new EntityField("BUS_BeginInventory", 1, "ProductID", SqlDbType.Int, false, false, false, true); }
        }
        public static EntityField ProductName
        {
            get { return new EntityField("BUS_BeginInventory", 2, "ProductName", SqlDbType.NVarChar, false, false, true, false); }
        }
        public static EntityField BatchNo
        {
            get { return new EntityField("BUS_BeginInventory", 3, "BatchNo", SqlDbType.NVarChar, false, false, true, false); }
        }
        public static EntityField ProduceDate
        {
            get { return new EntityField("BUS_BeginInventory", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
        }
        public static EntityField ValidateDate
        {
            get { return new EntityField("BUS_BeginInventory", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
        }
        public static EntityField SterilizationBatchNo
        {
            get { return new EntityField("BUS_BeginInventory", 6, "SterilizationBatchNo", SqlDbType.NVarChar, false, false, true, false); }
        }
        public static EntityField SterilizationDate
        {
            get { return new EntityField("BUS_BeginInventory", 7, "SterilizationDate", SqlDbType.DateTime, false, false, false, true); }
        }
        public static EntityField Amount
        {
            get { return new EntityField("BUS_BeginInventory", 8, "Amount", SqlDbType.Int, false, false, false, true); }
        }
        public static EntityField UnitPrice
        {
            get { return new EntityField("BUS_BeginInventory", 9, "UnitPrice", SqlDbType.Decimal, false, false, false, true); }
        }
        public static EntityField TotalPrice
        {
            get { return new EntityField("BUS_BeginInventory", 10, "TotalPrice", SqlDbType.Float, false, false, false, true); }
        }
        public static EntityField DepartmentID
        {
            get { return new EntityField("BUS_BeginInventory", 11, "DepartmentID", SqlDbType.Int, false, false, false, true); }
        }
        public static EntityField DepartmentName
        {
            get { return new EntityField("BUS_BeginInventory", 12, "DepartmentName", SqlDbType.NVarChar, false, false, false, true); }
        }
	}

	#endregion

    #region BUSBeginInventoryEntityFields2

    public enum BUSBeginInventoryEntityFields2
    {
        BeginInventoryID,

        ProductID,

        ProductName,

        BatchNo,

        ProduceDate,

        ValidateDate,

        SterilizationBatchNo,

        SterilizationDate,

        Amount,

        UnitPrice,

        TotalPrice,

        DepartmentID,

        DepartmentName
	}

	#endregion

}
