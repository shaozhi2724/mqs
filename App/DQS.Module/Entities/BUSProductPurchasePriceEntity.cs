/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-05-04 00:22:26
 *	Build Type: Entity
 *	Description: BUSProductPurchasePriceEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSProductPurchasePriceEntity : EntityBase
	{
		public int ProductPurchasePriceID
		{
			get { return (int)this.GetValue("ProductPurchasePriceID"); } 
			set { this.SetValue("ProductPurchasePriceID", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
		}

		public int PurchaseBillID
		{
			get { return (int)this.GetValue("PurchaseBillID"); } 
			set { this.SetValue("PurchaseBillID", value); } 
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

		public double PurchasePrice
		{
			get { return (double)this.GetValue("PurchasePrice"); } 
			set { this.SetValue("PurchasePrice", value); } 
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

		public BUSProductPurchasePriceEntity()
		{
			this.TableName = "BUS_ProductPurchasePrice";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ProductPurchasePriceID", BUSProductPurchasePriceEntityFields.ProductPurchasePriceID);
			this.Fields.Add("DealerID", BUSProductPurchasePriceEntityFields.DealerID);
			this.Fields.Add("PurchaseBillID", BUSProductPurchasePriceEntityFields.PurchaseBillID);
			this.Fields.Add("ProductID", BUSProductPurchasePriceEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSProductPurchasePriceEntityFields.BatchNo);
			this.Fields.Add("PurchasePrice", BUSProductPurchasePriceEntityFields.PurchasePrice);
			this.Fields.Add("CreateUserID", BUSProductPurchasePriceEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSProductPurchasePriceEntityFields.CreateDate);
		}
	}

	#region BUSProductPurchasePriceEntityFields

	public class BUSProductPurchasePriceEntityFields
	{
		public static EntityField ProductPurchasePriceID
		{
			get { return new EntityField("BUS_ProductPurchasePrice", 0, "ProductPurchasePriceID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_ProductPurchasePrice", 1, "DealerID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField PurchaseBillID
		{
			get { return new EntityField("BUS_ProductPurchasePrice", 2, "PurchaseBillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ProductPurchasePrice", 3, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_ProductPurchasePrice", 4, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PurchasePrice
		{
			get { return new EntityField("BUS_ProductPurchasePrice", 5, "PurchasePrice", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ProductPurchasePrice", 6, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ProductPurchasePrice", 7, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

	#region BUSProductPurchasePriceEntityFields2

	public enum BUSProductPurchasePriceEntityFields2
	{
		ProductPurchasePriceID,

		DealerID,

		PurchaseBillID,

		ProductID,

		BatchNo,

		PurchasePrice,

		CreateUserID,

		CreateDate,

	}

	#endregion

}
