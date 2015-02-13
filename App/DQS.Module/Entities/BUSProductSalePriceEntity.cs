/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-05-04 00:22:26
 *	Build Type: Entity
 *	Description: BUSProductSalePriceEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSProductSalePriceEntity : EntityBase
	{
		public int ProductSalePriceID
		{
			get { return (int)this.GetValue("ProductSalePriceID"); } 
			set { this.SetValue("ProductSalePriceID", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
		}

		public int SaleBillID
		{
			get { return (int)this.GetValue("SaleBillID"); } 
			set { this.SetValue("SaleBillID", value); } 
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

		public double SalePrice
		{
			get { return (double)this.GetValue("SalePrice"); } 
			set { this.SetValue("SalePrice", value); } 
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

		public BUSProductSalePriceEntity()
		{
			this.TableName = "BUS_ProductSalePrice";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ProductSalePriceID", BUSProductSalePriceEntityFields.ProductSalePriceID);
			this.Fields.Add("DealerID", BUSProductSalePriceEntityFields.DealerID);
			this.Fields.Add("SaleBillID", BUSProductSalePriceEntityFields.SaleBillID);
			this.Fields.Add("ProductID", BUSProductSalePriceEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSProductSalePriceEntityFields.BatchNo);
			this.Fields.Add("SalePrice", BUSProductSalePriceEntityFields.SalePrice);
			this.Fields.Add("CreateUserID", BUSProductSalePriceEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSProductSalePriceEntityFields.CreateDate);
		}
	}

	#region BUSProductSalePriceEntityFields

	public class BUSProductSalePriceEntityFields
	{
		public static EntityField ProductSalePriceID
		{
			get { return new EntityField("BUS_ProductSalePrice", 0, "ProductSalePriceID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_ProductSalePrice", 1, "DealerID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField SaleBillID
		{
			get { return new EntityField("BUS_ProductSalePrice", 2, "SaleBillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ProductSalePrice", 3, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_ProductSalePrice", 4, "BatchNo", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField SalePrice
		{
			get { return new EntityField("BUS_ProductSalePrice", 5, "SalePrice", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ProductSalePrice", 6, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ProductSalePrice", 7, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

	#region BUSProductSalePriceEntityFields2

	public enum BUSProductSalePriceEntityFields2
	{
		ProductSalePriceID,

		DealerID,

		SaleBillID,

		ProductID,

		BatchNo,

		SalePrice,

		CreateUserID,

		CreateDate,

	}

	#endregion

}
