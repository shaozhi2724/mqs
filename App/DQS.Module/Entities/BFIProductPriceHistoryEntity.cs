/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-02-11 18:17:01
 *	Build Type: Entity
 *	Description: BFIProductPriceHistoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIProductPriceHistoryEntity : EntityBase
	{
		public int HistoryID
		{
			get { return (int)this.GetValue("HistoryID"); } 
			set { this.SetValue("HistoryID", value); } 
		}

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

		public double OldPrice
		{
			get { return (double)this.GetValue("OldPrice"); } 
			set { this.SetValue("OldPrice", value); } 
		}

		public double NewPrice
		{
			get { return (double)this.GetValue("NewPrice"); } 
			set { this.SetValue("NewPrice", value); } 
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

		public BFIProductPriceHistoryEntity()
		{
			this.TableName = "BFI_ProductPriceHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("HistoryID", BFIProductPriceHistoryEntityFields.HistoryID);
			this.Fields.Add("ProductID", BFIProductPriceHistoryEntityFields.ProductID);
			this.Fields.Add("PriceID", BFIProductPriceHistoryEntityFields.PriceID);
			this.Fields.Add("OldPrice", BFIProductPriceHistoryEntityFields.OldPrice);
			this.Fields.Add("NewPrice", BFIProductPriceHistoryEntityFields.NewPrice);
			this.Fields.Add("CreateUserID", BFIProductPriceHistoryEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIProductPriceHistoryEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIProductPriceHistoryEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIProductPriceHistoryEntityFields.LastModifyDate);
			this.Fields.Add("PriceRemrk", BFIProductPriceHistoryEntityFields.PriceRemrk);
			this.Fields.Add("Reservation1", BFIProductPriceHistoryEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIProductPriceHistoryEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIProductPriceHistoryEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIProductPriceHistoryEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIProductPriceHistoryEntityFields.Reservation5);
		}
	}

	#region BFIProductPriceHistoryEntityFields

	public class BFIProductPriceHistoryEntityFields
	{
		public static EntityField HistoryID
		{
			get { return new EntityField("BFI_ProductPriceHistory", 0, "HistoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BFI_ProductPriceHistory", 1, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField PriceID
		{
			get { return new EntityField("BFI_ProductPriceHistory", 2, "PriceID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField OldPrice
		{
			get { return new EntityField("BFI_ProductPriceHistory", 3, "OldPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField NewPrice
		{
			get { return new EntityField("BFI_ProductPriceHistory", 4, "NewPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_ProductPriceHistory", 5, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_ProductPriceHistory", 6, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_ProductPriceHistory", 7, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_ProductPriceHistory", 8, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField PriceRemrk
		{
			get { return new EntityField("BFI_ProductPriceHistory", 9, "PriceRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_ProductPriceHistory", 10, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_ProductPriceHistory", 11, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_ProductPriceHistory", 12, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_ProductPriceHistory", 13, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_ProductPriceHistory", 14, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIProductPriceHistoryEntityFields2

	public enum BFIProductPriceHistoryEntityFields2
	{
		HistoryID,

		ProductID,

		PriceID,

		OldPrice,

		NewPrice,

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

	}

	#endregion

}
