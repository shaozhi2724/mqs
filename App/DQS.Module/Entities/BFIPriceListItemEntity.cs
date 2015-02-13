/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2015-01-25 18:11:10
 *	Build Type: Entity
 *	Description: BFIPriceListItemEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIPriceListItemEntity : EntityBase
	{
		public int PriceListItemId
		{
			get { return (int)this.GetValue("PriceListItemId"); } 
			set { this.SetValue("PriceListItemId", value); } 
		}

		public int Sequence
		{
			get { return (int)this.GetValue("Sequence"); } 
			set { this.SetValue("Sequence", value); } 
		}

		public string PriceListItemName
		{
			get { return (string)this.GetValue("PriceListItemName"); } 
			set { this.SetValue("PriceListItemName", value); } 
		}

		public int CompanyID
		{
			get { return (int)this.GetValue("CompanyID"); } 
			set { this.SetValue("CompanyID", value); } 
		}

		public string ProductCategory
		{
			get { return (string)this.GetValue("ProductCategory"); } 
			set { this.SetValue("ProductCategory", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public int BasePriceCategoryID
		{
			get { return (int)this.GetValue("BasePriceCategoryID"); } 
			set { this.SetValue("BasePriceCategoryID", value); } 
		}

		public string BasePriceCategoryName
		{
			get { return (string)this.GetValue("BasePriceCategoryName"); } 
			set { this.SetValue("BasePriceCategoryName", value); } 
		}

		public double PriceDiscount
		{
			get { return (double)this.GetValue("PriceDiscount"); } 
			set { this.SetValue("PriceDiscount", value); } 
		}

		public double PriceSurcharge
		{
			get { return (double)this.GetValue("PriceSurcharge"); } 
			set { this.SetValue("PriceSurcharge", value); } 
		}

		public double PriceRound
		{
			get { return (double)this.GetValue("PriceRound"); } 
			set { this.SetValue("PriceRound", value); } 
		}

		public int MinQuantity
		{
			get { return (int)this.GetValue("MinQuantity"); } 
			set { this.SetValue("MinQuantity", value); } 
		}

		public int PriceVersionID
		{
			get { return (int)this.GetValue("PriceVersionID"); } 
			set { this.SetValue("PriceVersionID", value); } 
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

		public BFIPriceListItemEntity()
		{
			this.TableName = "BFI_PriceListItem";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("PriceListItemId", BFIPriceListItemEntityFields.PriceListItemId);
			this.Fields.Add("Sequence", BFIPriceListItemEntityFields.Sequence);
			this.Fields.Add("PriceListItemName", BFIPriceListItemEntityFields.PriceListItemName);
			this.Fields.Add("CompanyID", BFIPriceListItemEntityFields.CompanyID);
			this.Fields.Add("ProductCategory", BFIPriceListItemEntityFields.ProductCategory);
			this.Fields.Add("ProductID", BFIPriceListItemEntityFields.ProductID);
			this.Fields.Add("BasePriceCategoryID", BFIPriceListItemEntityFields.BasePriceCategoryID);
			this.Fields.Add("BasePriceCategoryName", BFIPriceListItemEntityFields.BasePriceCategoryName);
			this.Fields.Add("PriceDiscount", BFIPriceListItemEntityFields.PriceDiscount);
			this.Fields.Add("PriceSurcharge", BFIPriceListItemEntityFields.PriceSurcharge);
			this.Fields.Add("PriceRound", BFIPriceListItemEntityFields.PriceRound);
			this.Fields.Add("MinQuantity", BFIPriceListItemEntityFields.MinQuantity);
			this.Fields.Add("PriceVersionID", BFIPriceListItemEntityFields.PriceVersionID);
			this.Fields.Add("CreateUserID", BFIPriceListItemEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIPriceListItemEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIPriceListItemEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIPriceListItemEntityFields.LastModifyDate);
		}
	}

	#region BFIPriceListItemEntityFields

	public class BFIPriceListItemEntityFields
	{
		public static EntityField PriceListItemId
		{
			get { return new EntityField("BFI_PriceListItem", 0, "PriceListItemId", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField Sequence
		{
			get { return new EntityField("BFI_PriceListItem", 1, "Sequence", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField PriceListItemName
		{
			get { return new EntityField("BFI_PriceListItem", 2, "PriceListItemName", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField CompanyID
		{
			get { return new EntityField("BFI_PriceListItem", 3, "CompanyID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ProductCategory
		{
			get { return new EntityField("BFI_PriceListItem", 4, "ProductCategory", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BFI_PriceListItem", 5, "ProductID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BasePriceCategoryID
		{
			get { return new EntityField("BFI_PriceListItem", 6, "BasePriceCategoryID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BasePriceCategoryName
		{
			get { return new EntityField("BFI_PriceListItem", 7, "BasePriceCategoryName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField PriceDiscount
		{
			get { return new EntityField("BFI_PriceListItem", 8, "PriceDiscount", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField PriceSurcharge
		{
			get { return new EntityField("BFI_PriceListItem", 9, "PriceSurcharge", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField PriceRound
		{
			get { return new EntityField("BFI_PriceListItem", 10, "PriceRound", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField MinQuantity
		{
			get { return new EntityField("BFI_PriceListItem", 11, "MinQuantity", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PriceVersionID
		{
			get { return new EntityField("BFI_PriceListItem", 12, "PriceVersionID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_PriceListItem", 13, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_PriceListItem", 14, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_PriceListItem", 15, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_PriceListItem", 16, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

	#region BFIPriceListItemEntityFields2

	public enum BFIPriceListItemEntityFields2
	{
		PriceListItemId,

		Sequence,

		PriceListItemName,

		CompanyID,

		ProductCategory,

		ProductID,

		BasePriceCategoryID,

		BasePriceCategoryName,

		PriceDiscount,

		PriceSurcharge,

		PriceRound,

		MinQuantity,

		PriceVersionID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

	}

	#endregion

}
