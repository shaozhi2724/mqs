/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2015-06-14 10:34
 *	Build Type: Entity
 *	Description: BUSInStoreDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;


namespace DQS.Module.Entities
{
    public class BUSOutStoreDetailEntity : EntityBase
    {
        
        public int DetailID
		{
            get { return (int)this.GetValue("DetailID"); }
            set { this.SetValue("DetailID", value); }
        }

        public int OutStoreID
        {
            get { return (int)this.GetValue("OutStoreID"); }
            set { this.SetValue("OutStoreID", value); }
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

        public int ProductID
        {
            get { return (int)this.GetValue("ProductID"); }
            set { this.SetValue("ProductID", value); }
        }

        public string ProductCode
        {
            get { return (string)this.GetValue("ProductCode"); }
            set { this.SetValue("ProductCode", value); }
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

        public int Tax
        {
            get { return (int)this.GetValue("Tax"); }
            set { this.SetValue("Tax", value); }
        }

        public BUSOutStoreDetailEntity()
		{
            this.TableName = "BUS_OutStoreDetail";
			this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("DetailID", BUSOutStoreDetailEntityFields.DetailID);
            this.Fields.Add("OutStoreID", BUSOutStoreDetailEntityFields.OutStoreID);
            this.Fields.Add("OutStoreCode", BUSOutStoreDetailEntityFields.OutStoreCode);
            this.Fields.Add("OutStoreDate", BUSOutStoreDetailEntityFields.OutStoreDate);
            this.Fields.Add("ProductID", BUSOutStoreDetailEntityFields.ProductID);
            this.Fields.Add("ProductCode", BUSOutStoreDetailEntityFields.ProductCode);
            this.Fields.Add("ProductName", BUSOutStoreDetailEntityFields.ProductName);
            this.Fields.Add("PackageSpec", BUSOutStoreDetailEntityFields.PackageSpec);
            this.Fields.Add("ProducerName", BUSOutStoreDetailEntityFields.ProducerName);
            this.Fields.Add("BatchNo", BUSOutStoreDetailEntityFields.BatchNo);
            this.Fields.Add("ProduceDate", BUSOutStoreDetailEntityFields.ProduceDate);
            this.Fields.Add("ValidateDate", BUSOutStoreDetailEntityFields.ValidateDate);
            this.Fields.Add("DownDealerID", BUSOutStoreDetailEntityFields.DownDealerID);
            this.Fields.Add("DownDealerName", BUSOutStoreDetailEntityFields.DownDealerName);
            this.Fields.Add("OutAmount", BUSOutStoreDetailEntityFields.OutAmount);
            this.Fields.Add("OutUnitPrice", BUSOutStoreDetailEntityFields.OutUnitPrice);
            this.Fields.Add("Operator", BUSOutStoreDetailEntityFields.Operator);
            this.Fields.Add("BuildBillUserName", BUSOutStoreDetailEntityFields.BuildBillUserName);
            this.Fields.Add("Tax", BUSOutStoreDetailEntityFields.Tax);
		}
	}

    #region BUSOutStoreDetailEntityFields

    public class BUSOutStoreDetailEntityFields
	{

        public static EntityField DetailID
		{
            get { return new EntityField("BUS_OutStoreDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

        public static EntityField OutStoreID
        {
            get { return new EntityField("BUS_OutStoreDetail", 1, "OutStoreID", SqlDbType.Int, false, false, false, true); }
        }

        public static EntityField OutStoreCode
        {
            get { return new EntityField("BUS_OutStoreDetail", 2, "OutStoreCode", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField OutStoreDate
        {
            get { return new EntityField("BUS_OutStoreDetail", 3, "OutStoreDate", SqlDbType.DateTime, false, false, false, true); }
        }

        public static EntityField ProductID
		{
            get { return new EntityField("BUS_OutStoreDetail", 4, "ProductID", SqlDbType.Int, false, false, false, true); }
        }

        public static EntityField ProductCode
        {
            get { return new EntityField("BUS_OutStoreDetail", 5, "ProductCode", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField ProductName
        {
            get { return new EntityField("BUS_OutStoreDetail", 6, "ProductName", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField PackageSpec
        {
            get { return new EntityField("BUS_OutStoreDetail", 7, "PackageSpec", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField ProducerName
        {
            get { return new EntityField("BUS_OutStoreDetail", 8, "ProducerName", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField BatchNo
		{
            get { return new EntityField("BUS_OutStoreDetail", 9, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ProduceDate
		{
            get { return new EntityField("BUS_OutStoreDetail", 10, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField ValidateDate
		{
            get { return new EntityField("BUS_OutStoreDetail", 11, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField DownDealerID
		{
            get { return new EntityField("BUS_OutStoreDetail", 12, "DownDealerID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField DownDealerName
		{
            get { return new EntityField("BUS_OutStoreDetail", 13, "DownDealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField OutAmount
		{
            get { return new EntityField("BUS_OutStoreDetail", 14, "OutAmount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField OutUnitPrice
		{
            get { return new EntityField("BUS_OutStoreDetail", 15, "OutUnitPrice", SqlDbType.Float, false, false, false, true); }
		}

        public static EntityField Operator
		{
            get { return new EntityField("BUS_OutStoreDetail", 16, "Operator", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField BuildBillUserName
		{
            get { return new EntityField("BUS_OutStoreDetail", 17, "BuildBillUserName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField Tax
		{
            get { return new EntityField("BUS_OutStoreDetail", 18, "Tax", SqlDbType.Int, false, false, false, true); }
		}

	}

	#endregion

    #region BUSOutStoreDetailEntityFields2

    public enum BUSOutStoreDetailEntityFields2
	{
        DetailID,
        
        OutStoreID,
        
        OutStoreCode,
        
        OutStoreDate,
        
        ProductID,
        
        ProductCode,
        
        ProductName,
        
        PackageSpec,
        
        ProducerName,
        
        BatchNo,
        
        ProduceDate,
        
        ValidateDate,
        
        DownDealerID,
        
        DownDealerName,
        
        OutAmount,
        
        OutUnitPrice,
        
        Operator,
        
        BuildBillUserName,

        Tax

	}

	#endregion

}
