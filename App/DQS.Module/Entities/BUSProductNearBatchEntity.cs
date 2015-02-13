/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSProductNearBatchEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSProductNearBatchEntity : EntityBase
	{
		public int NearID
		{
			get { return (int)this.GetValue("NearID"); } 
			set { this.SetValue("NearID", value); } 
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

		public string KeepLong
		{
			get { return (string)this.GetValue("KeepLong"); } 
			set { this.SetValue("KeepLong", value); } 
		}

		public int CurrentAmount
		{
			get { return (int)this.GetValue("CurrentAmount"); } 
			set { this.SetValue("CurrentAmount", value); } 
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

		public string NearRemrk
		{
			get { return (string)this.GetValue("NearRemrk"); } 
			set { this.SetValue("NearRemrk", value); } 
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

		public BUSProductNearBatchEntity()
		{
			this.TableName = "BUS_ProductNearBatch";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("NearID", BUSProductNearBatchEntityFields.NearID);
			this.Fields.Add("ProductID", BUSProductNearBatchEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSProductNearBatchEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSProductNearBatchEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSProductNearBatchEntityFields.ValidateDate);
			this.Fields.Add("KeepLong", BUSProductNearBatchEntityFields.KeepLong);
			this.Fields.Add("CurrentAmount", BUSProductNearBatchEntityFields.CurrentAmount);
			this.Fields.Add("CreateUserID", BUSProductNearBatchEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSProductNearBatchEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSProductNearBatchEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSProductNearBatchEntityFields.LastModifyDate);
			this.Fields.Add("NearRemrk", BUSProductNearBatchEntityFields.NearRemrk);
			this.Fields.Add("Reservation1", BUSProductNearBatchEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSProductNearBatchEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSProductNearBatchEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSProductNearBatchEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSProductNearBatchEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSProductNearBatchEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSProductNearBatchEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSProductNearBatchEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSProductNearBatchEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSProductNearBatchEntityFields.Reservation10);
		}
	}

	#region BUSProductNearBatchEntityFields

	public class BUSProductNearBatchEntityFields
	{
		public static EntityField NearID
		{
			get { return new EntityField("BUS_ProductNearBatch", 0, "NearID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ProductNearBatch", 1, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_ProductNearBatch", 2, "BatchNo", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_ProductNearBatch", 3, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_ProductNearBatch", 4, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField KeepLong
		{
			get { return new EntityField("BUS_ProductNearBatch", 5, "KeepLong", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CurrentAmount
		{
			get { return new EntityField("BUS_ProductNearBatch", 6, "CurrentAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ProductNearBatch", 7, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ProductNearBatch", 8, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ProductNearBatch", 9, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ProductNearBatch", 10, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField NearRemrk
		{
			get { return new EntityField("BUS_ProductNearBatch", 11, "NearRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ProductNearBatch", 12, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ProductNearBatch", 13, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ProductNearBatch", 14, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ProductNearBatch", 15, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ProductNearBatch", 16, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ProductNearBatch", 17, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ProductNearBatch", 18, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ProductNearBatch", 19, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ProductNearBatch", 20, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ProductNearBatch", 21, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSProductNearBatchEntityFields2

	public enum BUSProductNearBatchEntityFields2
	{
		NearID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		KeepLong,

		CurrentAmount,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		NearRemrk,

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
