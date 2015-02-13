/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSProductLoseBatchEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSProductLoseBatchEntity : EntityBase
	{
		public int LoseID
		{
			get { return (int)this.GetValue("LoseID"); } 
			set { this.SetValue("LoseID", value); } 
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

		public bool IsDeal
		{
			get { return (bool)this.GetValue("IsDeal"); } 
			set { this.SetValue("IsDeal", value); } 
		}

		public string DealResult
		{
			get { return (string)this.GetValue("DealResult"); } 
			set { this.SetValue("DealResult", value); } 
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

		public string LoseRemrk
		{
			get { return (string)this.GetValue("LoseRemrk"); } 
			set { this.SetValue("LoseRemrk", value); } 
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

		public BUSProductLoseBatchEntity()
		{
			this.TableName = "BUS_ProductLoseBatch";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("LoseID", BUSProductLoseBatchEntityFields.LoseID);
			this.Fields.Add("ProductID", BUSProductLoseBatchEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSProductLoseBatchEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSProductLoseBatchEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSProductLoseBatchEntityFields.ValidateDate);
			this.Fields.Add("KeepLong", BUSProductLoseBatchEntityFields.KeepLong);
			this.Fields.Add("CurrentAmount", BUSProductLoseBatchEntityFields.CurrentAmount);
			this.Fields.Add("IsDeal", BUSProductLoseBatchEntityFields.IsDeal);
			this.Fields.Add("DealResult", BUSProductLoseBatchEntityFields.DealResult);
			this.Fields.Add("CreateUserID", BUSProductLoseBatchEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSProductLoseBatchEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSProductLoseBatchEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSProductLoseBatchEntityFields.LastModifyDate);
			this.Fields.Add("LoseRemrk", BUSProductLoseBatchEntityFields.LoseRemrk);
			this.Fields.Add("Reservation1", BUSProductLoseBatchEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSProductLoseBatchEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSProductLoseBatchEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSProductLoseBatchEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSProductLoseBatchEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSProductLoseBatchEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSProductLoseBatchEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSProductLoseBatchEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSProductLoseBatchEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSProductLoseBatchEntityFields.Reservation10);
		}
	}

	#region BUSProductLoseBatchEntityFields

	public class BUSProductLoseBatchEntityFields
	{
		public static EntityField LoseID
		{
			get { return new EntityField("BUS_ProductLoseBatch", 0, "LoseID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ProductLoseBatch", 1, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_ProductLoseBatch", 2, "BatchNo", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_ProductLoseBatch", 3, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_ProductLoseBatch", 4, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField KeepLong
		{
			get { return new EntityField("BUS_ProductLoseBatch", 5, "KeepLong", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CurrentAmount
		{
			get { return new EntityField("BUS_ProductLoseBatch", 6, "CurrentAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField IsDeal
		{
			get { return new EntityField("BUS_ProductLoseBatch", 7, "IsDeal", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField DealResult
		{
			get { return new EntityField("BUS_ProductLoseBatch", 8, "DealResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ProductLoseBatch", 9, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ProductLoseBatch", 10, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ProductLoseBatch", 11, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ProductLoseBatch", 12, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LoseRemrk
		{
			get { return new EntityField("BUS_ProductLoseBatch", 13, "LoseRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ProductLoseBatch", 14, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ProductLoseBatch", 15, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ProductLoseBatch", 16, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ProductLoseBatch", 17, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ProductLoseBatch", 18, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ProductLoseBatch", 19, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ProductLoseBatch", 20, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ProductLoseBatch", 21, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ProductLoseBatch", 22, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ProductLoseBatch", 23, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSProductLoseBatchEntityFields2

	public enum BUSProductLoseBatchEntityFields2
	{
		LoseID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		KeepLong,

		CurrentAmount,

		IsDeal,

		DealResult,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		LoseRemrk,

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
