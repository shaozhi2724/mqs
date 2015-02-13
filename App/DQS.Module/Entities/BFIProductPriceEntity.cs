/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-08-29 09:47:28
 *	Build Type: Entity
 *	Description: BFIProductPriceEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIProductPriceEntity : EntityBase
	{
		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public int PriceID
		{
			get { return (int)this.GetValue("PriceID"); } 
			set { this.SetValue("PriceID", value); } 
		}

		public double Price
		{
			get { return (double)this.GetValue("Price"); } 
			set { this.SetValue("Price", value); } 
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

		public string PriceRemrk
		{
			get { return (string)this.GetValue("PriceRemrk"); } 
			set { this.SetValue("PriceRemrk", value); } 
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

		public BFIProductPriceEntity()
		{
			this.TableName = "BFI_ProductPrice";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ProductID", BFIProductPriceEntityFields.ProductID);
			this.Fields.Add("PriceID", BFIProductPriceEntityFields.PriceID);
			this.Fields.Add("Price", BFIProductPriceEntityFields.Price);
			this.Fields.Add("CreateUserID", BFIProductPriceEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIProductPriceEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIProductPriceEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIProductPriceEntityFields.LastModifyDate);
			this.Fields.Add("PriceRemrk", BFIProductPriceEntityFields.PriceRemrk);
			this.Fields.Add("Reservation1", BFIProductPriceEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIProductPriceEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIProductPriceEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIProductPriceEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIProductPriceEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIProductPriceEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIProductPriceEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIProductPriceEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIProductPriceEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIProductPriceEntityFields.Reservation10);
		}
	}

	#region BFIProductPriceEntityFields

	public class BFIProductPriceEntityFields
	{
		public static EntityField ProductID
		{
			get { return new EntityField("BFI_ProductPrice", 0, "ProductID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField PriceID
		{
			get { return new EntityField("BFI_ProductPrice", 1, "PriceID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField Price
		{
			get { return new EntityField("BFI_ProductPrice", 2, "Price", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_ProductPrice", 3, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_ProductPrice", 4, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_ProductPrice", 5, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_ProductPrice", 6, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField PriceRemrk
		{
			get { return new EntityField("BFI_ProductPrice", 7, "PriceRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_ProductPrice", 8, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_ProductPrice", 9, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_ProductPrice", 10, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_ProductPrice", 11, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_ProductPrice", 12, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_ProductPrice", 13, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_ProductPrice", 14, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_ProductPrice", 15, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_ProductPrice", 16, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_ProductPrice", 17, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIProductPriceEntityFields2

	public enum BFIProductPriceEntityFields2
	{
		ProductID,

		PriceID,

		Price,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		PriceRemrk,

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
