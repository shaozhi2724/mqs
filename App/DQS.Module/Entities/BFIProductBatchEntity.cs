/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BFIProductBatchEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIProductBatchEntity : EntityBase
	{
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

		public string KeepLong
		{
			get { return (string)this.GetValue("KeepLong"); } 
			set { this.SetValue("KeepLong", value); } 
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

		public BFIProductBatchEntity()
		{
			this.TableName = "BFI_ProductBatch";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ProductID", BFIProductBatchEntityFields.ProductID);
			this.Fields.Add("BatchNo", BFIProductBatchEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BFIProductBatchEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BFIProductBatchEntityFields.ValidateDate);
			this.Fields.Add("KeepLong", BFIProductBatchEntityFields.KeepLong);
			this.Fields.Add("CreateUserID", BFIProductBatchEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIProductBatchEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIProductBatchEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIProductBatchEntityFields.LastModifyDate);
			this.Fields.Add("PriceRemrk", BFIProductBatchEntityFields.PriceRemrk);
			this.Fields.Add("Reservation1", BFIProductBatchEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIProductBatchEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIProductBatchEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIProductBatchEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIProductBatchEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIProductBatchEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIProductBatchEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIProductBatchEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIProductBatchEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIProductBatchEntityFields.Reservation10);
		}
	}

	#region BFIProductBatchEntityFields

	public class BFIProductBatchEntityFields
	{
		public static EntityField ProductID
		{
			get { return new EntityField("BFI_ProductBatch", 0, "ProductID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BFI_ProductBatch", 1, "BatchNo", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BFI_ProductBatch", 2, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BFI_ProductBatch", 3, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField KeepLong
		{
			get { return new EntityField("BFI_ProductBatch", 4, "KeepLong", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_ProductBatch", 5, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_ProductBatch", 6, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_ProductBatch", 7, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_ProductBatch", 8, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField PriceRemrk
		{
			get { return new EntityField("BFI_ProductBatch", 9, "PriceRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_ProductBatch", 10, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_ProductBatch", 11, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_ProductBatch", 12, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_ProductBatch", 13, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_ProductBatch", 14, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_ProductBatch", 15, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_ProductBatch", 16, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_ProductBatch", 17, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_ProductBatch", 18, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_ProductBatch", 19, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIProductBatchEntityFields2

	public enum BFIProductBatchEntityFields2
	{
		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		KeepLong,

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
