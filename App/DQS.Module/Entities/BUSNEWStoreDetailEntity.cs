/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2015-06-14 10:34
 *	Build Type: Entity
 *	Description: BUSNEWStoreDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;


namespace DQS.Module.Entities
{
    public class BUSNEWStoreDetailEntity : EntityBase
    {
        public int StoreDetailID
		{
            get { return (int)this.GetValue("StoreDetailID"); }
            set { this.SetValue("StoreDetailID", value); }
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

        public string ProductName
        {
            get { return (string)this.GetValue("ProductName"); }
            set { this.SetValue("ProductName", value); }
        }

        public string PackageSpec
        {
            get { return (string)this.GetValue("PackageSpec"); }
            set { this.SetValue("PackageSpec", value); }
        }

        public string ProducerName
        {
            get { return (string)this.GetValue("ProducerName"); }
            set { this.SetValue("ProducerName", value); }
        }

        public int InStoreBillID
        {
            get { return (int)this.GetValue("InStoreBillID"); }
            set { this.SetValue("InStoreBillID", value); }
        }

        public string InStoreCode
        {
            get { return (string)this.GetValue("InStoreCode"); }
            set { this.SetValue("InStoreCode", value); }
        }

        public DateTime InStoreDate
        {
            get { return (DateTime)this.GetValue("InStoreDate"); }
            set { this.SetValue("InStoreDate", value); }
        }

        public int UpDealerID
        {
            get { return (int)this.GetValue("UpDealerID"); }
            set { this.SetValue("UpDealerID", value); }
        }

        public string UpDealerName
        {
            get { return (string)this.GetValue("UpDealerName"); }
            set { this.SetValue("UpDealerName", value); }
        }

        public int InAmount
        {
            get { return (int)this.GetValue("InAmount"); }
            set { this.SetValue("InAmount", value); }
        }

        public double InUnitPrice
        {
            get { return (double)this.GetValue("InUnitPrice"); }
            set { this.SetValue("InUnitPrice", value); }
        }

        public int DepartmentID
        {
            get { return (int)this.GetValue("DepartmentID"); }
            set { this.SetValue("DepartmentID", value); }
        }

        public int OutStoreBillID
        {
            get { return (int)this.GetValue("OutStoreBillID"); }
            set { this.SetValue("OutStoreBillID", value); }
        }

        public string OutStoreCode
        {
            get { return (string)this.GetValue("OutStoreCode"); }
            set { this.SetValue("OutStoreCode", value); }
        }

        public DateTime OutStoreDate
        {
            get { return (DateTime)this.GetValue("OutStoreDate"); }
            set { this.SetValue("OutStoreDate", value); }
        }

        public int DownDealerID
        {
            get { return (int)this.GetValue("DownDealerID"); }
            set { this.SetValue("DownDealerID", value); }
        }

        public string DownDealerName
        {
            get { return (string)this.GetValue("DownDealerName"); }
            set { this.SetValue("DownDealerName", value); }
        }

        public int OutAmount
		{
            get { return (int)this.GetValue("OutAmount"); }
            set { this.SetValue("OutAmount", value); } 
		}

        public double OutUnitPrice
		{
            get { return (double)this.GetValue("OutUnitPrice"); }
            set { this.SetValue("OutUnitPrice", value); } 
		}

        public int Amount
		{
            get { return (int)this.GetValue("Amount"); }
            set { this.SetValue("Amount", value); } 
		}

        public string Operator
		{
            get { return (string)this.GetValue("Operator"); }
            set { this.SetValue("Operator", value); } 
		}

        public string BuildBillUserName
		{
            get { return (string)this.GetValue("BuildBillUserName"); }
            set { this.SetValue("BuildBillUserName", value); } 
		}

        public DateTime CuringDate
        {
            get { return (DateTime)this.GetValue("CuringDate"); }
            set { this.SetValue("CuringDate", value); }
        }

		public BUSNEWStoreDetailEntity()
		{
            this.TableName = "BUS_NEWStoreDetail";
			this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("StoreDetailID", BUSNEWStoreDetailEntityFields.StoreDetailID);
            this.Fields.Add("ProductID", BUSNEWStoreDetailEntityFields.ProductID);
            this.Fields.Add("BatchNo", BUSNEWStoreDetailEntityFields.BatchNo);
            this.Fields.Add("ProduceDate", BUSNEWStoreDetailEntityFields.ProduceDate);
            this.Fields.Add("ValidateDate", BUSNEWStoreDetailEntityFields.ValidateDate);
            this.Fields.Add("ProductName", BUSNEWStoreDetailEntityFields.ProductName);
            this.Fields.Add("PackageSpec", BUSNEWStoreDetailEntityFields.PackageSpec);
            this.Fields.Add("ProducerName", BUSNEWStoreDetailEntityFields.ProducerName);
            this.Fields.Add("InStoreBillID", BUSNEWStoreDetailEntityFields.InStoreBillID);
            this.Fields.Add("InStoreCode", BUSNEWStoreDetailEntityFields.InStoreCode);
            this.Fields.Add("InStoreDate", BUSNEWStoreDetailEntityFields.InStoreDate);
            this.Fields.Add("UpDealerID", BUSNEWStoreDetailEntityFields.UpDealerID);
            this.Fields.Add("UpDealerName", BUSNEWStoreDetailEntityFields.UpDealerName);
            this.Fields.Add("InAmount", BUSNEWStoreDetailEntityFields.InAmount);
            this.Fields.Add("InUnitPrice", BUSNEWStoreDetailEntityFields.InUnitPrice);
            this.Fields.Add("DepartmentID", BUSNEWStoreDetailEntityFields.DepartmentID);
            this.Fields.Add("OutStoreBillID", BUSNEWStoreDetailEntityFields.OutStoreBillID);
            this.Fields.Add("OutStoreCode", BUSNEWStoreDetailEntityFields.OutStoreCode);
            this.Fields.Add("OutStoreDate", BUSNEWStoreDetailEntityFields.OutStoreDate);
            this.Fields.Add("DownDealerID", BUSNEWStoreDetailEntityFields.DownDealerID);
            this.Fields.Add("DownDealerName", BUSNEWStoreDetailEntityFields.DownDealerName);
            this.Fields.Add("OutAmount", BUSNEWStoreDetailEntityFields.OutAmount);
            this.Fields.Add("OutUnitPrice", BUSNEWStoreDetailEntityFields.OutUnitPrice);
            this.Fields.Add("Amount", BUSNEWStoreDetailEntityFields.Amount);
            this.Fields.Add("Operator", BUSNEWStoreDetailEntityFields.Operator);
            this.Fields.Add("BuildBillUserName", BUSNEWStoreDetailEntityFields.BuildBillUserName);
            this.Fields.Add("CuringDate", BUSNEWStoreDetailEntityFields.CuringDate);
		}
	}

    #region BUSNEWStoreDetailEntityFields

    public class BUSNEWStoreDetailEntityFields
	{
        public static EntityField StoreDetailID
		{
            get { return new EntityField("BUS_NEWStoreDetail", 0, "StoreDetailID", SqlDbType.Int, true, true, true, false); }
		}

        public static EntityField ProductID
		{
            get { return new EntityField("BUS_NEWStoreDetail", 1, "ProductID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField BatchNo
		{
            get { return new EntityField("BUS_NEWStoreDetail", 2, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ProduceDate
		{
            get { return new EntityField("BUS_NEWStoreDetail", 3, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField ValidateDate
		{
            get { return new EntityField("BUS_NEWStoreDetail", 4, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField ProductName
		{
            get { return new EntityField("BUS_NEWStoreDetail", 5, "ProductName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField PackageSpec
		{
            get { return new EntityField("BUS_NEWStoreDetail", 6, "PackageSpec", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ProducerName
		{
            get { return new EntityField("BUS_NEWStoreDetail", 7, "ProducerName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField InStoreBillID
		{
            get { return new EntityField("BUS_NEWStoreDetail", 8, "InStoreBillID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField InStoreCode
		{
            get { return new EntityField("BUS_NEWStoreDetail", 9, "InStoreCode", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField InStoreDate
		{
            get { return new EntityField("BUS_NEWStoreDetail", 10, "InStoreDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField UpDealerID
		{
            get { return new EntityField("BUS_NEWStoreDetail", 11, "UpDealerID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField UpDealerName
		{
            get { return new EntityField("BUS_NEWStoreDetail", 12, "UpDealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField InAmount
		{
            get { return new EntityField("BUS_NEWStoreDetail", 13, "InAmount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField InUnitPrice
		{
            get { return new EntityField("BUS_NEWStoreDetail", 14, "InUnitPrice", SqlDbType.Float, false, false, false, true); }
		}

        public static EntityField DepartmentID
		{
            get { return new EntityField("BUS_NEWStoreDetail", 15, "DepartmentID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField OutStoreBillID
		{
            get { return new EntityField("BUS_NEWStoreDetail", 16, "OutStoreBillID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField OutStoreCode
		{
            get { return new EntityField("BUS_NEWStoreDetail", 17, "OutStoreCode", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField OutStoreDate
		{
            get { return new EntityField("BUS_NEWStoreDetail", 18, "OutStoreDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField DownDealerID
		{
            get { return new EntityField("BUS_NEWStoreDetail", 19, "DownDealerID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField DownDealerName
		{
            get { return new EntityField("BUS_NEWStoreDetail", 20, "DownDealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField OutAmount
		{
            get { return new EntityField("BUS_NEWStoreDetail", 21, "OutAmount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField OutUnitPrice
		{
            get { return new EntityField("BUS_NEWStoreDetail", 22, "OutUnitPrice", SqlDbType.Float, false, false, false, true); }
		}

        public static EntityField Amount
		{
            get { return new EntityField("BUS_NEWStoreDetail", 23, "Amount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField Operator
		{
            get { return new EntityField("BUS_NEWStoreDetail", 24, "Operator", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField BuildBillUserName
		{
            get { return new EntityField("BUS_NEWStoreDetail", 25, "BuildBillUserName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField CuringDate
		{
            get { return new EntityField("BUS_NEWStoreDetail", 26, "CuringDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

    #region BUSNEWStoreDetailEntityFields2

    public enum BUSNEWStoreDetailEntityFields2
	{
        StoreDetailID,
        
        ProductID,
        
        BatchNo,
        
        ProduceDate,
        
        ValidateDate,
        
        ProductName,
        
        PackageSpec,
        
        ProducerName,
        
        InStoreBillID,
        
        InStoreCode,
        
        InStoreDate,
        
        UpDealerID,
        
        UpDealerName,
        
        InAmount,
        
        InUnitPrice,
        
        DepartmentID,
        
        OutStoreBillID,
        
        OutStoreCode,
        
        OutStoreDate,
        
        DownDealerID,
        
        DownDealerName,
        
        OutAmount,
        
        OutUnitPrice,
        
        Amount,
        
        Operator,
        
        BuildBillUserName,

        CuringDate

	}

	#endregion

}
