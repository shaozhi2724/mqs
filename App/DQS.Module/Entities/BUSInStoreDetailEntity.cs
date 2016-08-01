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
    public class BUSInStoreDetailEntity : EntityBase
    {

        public int DetailID
		{
            get { return (int)this.GetValue("DetailID"); }
            set { this.SetValue("DetailID", value); }
        }

        public int InStoreID
        {
            get { return (int)this.GetValue("InStoreID"); }
            set { this.SetValue("InStoreID", value); }
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

        public decimal InUnitPrice
        {
            get { return (decimal)this.GetValue("InUnitPrice"); }
            set { this.SetValue("InUnitPrice", value); }
        }

        public decimal InTotalPrice
        {
            get { return (decimal)this.GetValue("InTotalPrice"); }
            set { this.SetValue("InTotalPrice", value); }
        }

        public decimal ViewPrice
        {
            get { return (decimal)this.GetValue("ViewPrice"); }
            set { this.SetValue("ViewPrice", value); }
        }

        public int Tax
        {
            get { return (int)this.GetValue("Tax"); }
            set { this.SetValue("Tax", value); }
        }

        public int DepartmentID
        {
            get { return (int)this.GetValue("DepartmentID"); }
            set { this.SetValue("DepartmentID", value); }
        }

        public DateTime CuringDate
        {
            get { return (DateTime)this.GetValue("CuringDate"); }
            set { this.SetValue("CuringDate", value); }
        }

        public BUSInStoreDetailEntity()
		{
            this.TableName = "BUS_InStoreDetail";
			this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("DetailID", BUSInStoreDetailEntityFields.DetailID);
            this.Fields.Add("InStoreID", BUSInStoreDetailEntityFields.InStoreID);
            this.Fields.Add("InStoreCode", BUSInStoreDetailEntityFields.InStoreCode);
            this.Fields.Add("InStoreDate", BUSInStoreDetailEntityFields.InStoreDate);
            this.Fields.Add("ProductID", BUSInStoreDetailEntityFields.ProductID);
            this.Fields.Add("ProductCode", BUSInStoreDetailEntityFields.ProductCode);
            this.Fields.Add("ProductName", BUSInStoreDetailEntityFields.ProductName);
            this.Fields.Add("PackageSpec", BUSInStoreDetailEntityFields.PackageSpec);
            this.Fields.Add("ProducerName", BUSInStoreDetailEntityFields.ProducerName);
            this.Fields.Add("BatchNo", BUSInStoreDetailEntityFields.BatchNo);
            this.Fields.Add("ProduceDate", BUSInStoreDetailEntityFields.ProduceDate);
            this.Fields.Add("ValidateDate", BUSInStoreDetailEntityFields.ValidateDate);
            this.Fields.Add("UpDealerID", BUSInStoreDetailEntityFields.UpDealerID);
            this.Fields.Add("UpDealerName", BUSInStoreDetailEntityFields.UpDealerName);
            this.Fields.Add("InAmount", BUSInStoreDetailEntityFields.InAmount);
            this.Fields.Add("InUnitPrice", BUSInStoreDetailEntityFields.InUnitPrice);
            this.Fields.Add("InTotalPrice", BUSInStoreDetailEntityFields.InTotalPrice);
            this.Fields.Add("ViewPrice", BUSInStoreDetailEntityFields.ViewPrice);
            this.Fields.Add("Tax", BUSInStoreDetailEntityFields.Tax);
            this.Fields.Add("DepartmentID", BUSInStoreDetailEntityFields.DepartmentID);
            this.Fields.Add("CuringDate", BUSInStoreDetailEntityFields.CuringDate);
		}
	}

    #region BUSInStoreDetailEntityFields

    public class BUSInStoreDetailEntityFields
	{

        public static EntityField DetailID
		{
            get { return new EntityField("BUS_InStoreDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

        public static EntityField InStoreID
        {
            get { return new EntityField("BUS_InStoreDetail", 1, "InStoreID", SqlDbType.Int, false, false, true, true); }
        }

        public static EntityField InStoreCode
        {
            get { return new EntityField("BUS_InStoreDetail", 2, "InStoreCode", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField InStoreDate
        {
            get { return new EntityField("BUS_InStoreDetail", 3, "InStoreDate", SqlDbType.DateTime, false, false, false, true); }
        }

        public static EntityField ProductID
		{
            get { return new EntityField("BUS_InStoreDetail", 4, "ProductID", SqlDbType.Int, false, false, false, true); }
        }

        public static EntityField ProductCode
        {
            get { return new EntityField("BUS_InStoreDetail", 5, "ProductCode", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField ProductName
        {
            get { return new EntityField("BUS_InStoreDetail", 6, "ProductName", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField PackageSpec
        {
            get { return new EntityField("BUS_InStoreDetail", 7, "PackageSpec", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField ProducerName
        {
            get { return new EntityField("BUS_InStoreDetail", 8, "ProducerName", SqlDbType.NVarChar, false, false, false, true); }
        }

        public static EntityField BatchNo
		{
            get { return new EntityField("BUS_InStoreDetail", 9, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ProduceDate
		{
            get { return new EntityField("BUS_InStoreDetail", 10, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField ValidateDate
		{
            get { return new EntityField("BUS_InStoreDetail", 11, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField UpDealerID
		{
            get { return new EntityField("BUS_InStoreDetail", 12, "UpDealerID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField UpDealerName
		{
            get { return new EntityField("BUS_InStoreDetail", 13, "UpDealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField InAmount
		{
            get { return new EntityField("BUS_InStoreDetail", 14, "InAmount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField InUnitPrice
		{
            get { return new EntityField("BUS_InStoreDetail", 15, "InUnitPrice", SqlDbType.Decimal, false, false, false, true); }
		}

        public static EntityField InTotalPrice
		{
            get { return new EntityField("BUS_InStoreDetail", 16, "InTotalPrice", SqlDbType.Decimal, false, false, false, true); }
		}

        public static EntityField ViewPrice
		{
            get { return new EntityField("BUS_InStoreDetail", 17, "ViewPrice", SqlDbType.Decimal, false, false, false, true); }
		}

        public static EntityField Tax
		{
            get { return new EntityField("BUS_InStoreDetail", 18, "Tax", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField DepartmentID
		{
            get { return new EntityField("BUS_InStoreDetail", 19, "DepartmentID", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField CuringDate
		{
            get { return new EntityField("BUS_InStoreDetail", 20, "CuringDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

    #region BUSInStoreDetailEntityFields2

    public enum BUSInStoreDetailEntityFields2
	{
        DetailID,
        
        InStoreID,
        
        InStoreCode,
        
        InStoreDate,
        
        ProductID,
        
        ProductCode,
        
        ProductName,
        
        PackageSpec,
        
        ProducerName,
        
        BatchNo,
        
        ProduceDate,
        
        ValidateDate,
        
        UpDealerID,
        
        UpDealerName,
        
        InAmount,
        
        InUnitPrice,

        InTotalPrice,

        ViewPrice,

        Tax,
        
        DepartmentID,

        CuringDate

	}

	#endregion

}
