/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-30 11:33:47
 *	Build Type: Entity
 *	Description: BUSReceiveDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSReceiveDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int ReceiveID
		{
			get { return (int)this.GetValue("ReceiveID"); } 
			set { this.SetValue("ReceiveID", value); } 
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

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
		}

		public int ReceiveAmount
		{
			get { return (int)this.GetValue("ReceiveAmount"); } 
			set { this.SetValue("ReceiveAmount", value); } 
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

		public string DetailRemark
		{
			get { return (string)this.GetValue("DetailRemark"); } 
			set { this.SetValue("DetailRemark", value); } 
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

		public BUSReceiveDetailEntity()
		{
			this.TableName = "BUS_ReceiveDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSReceiveDetailEntityFields.DetailID);
			this.Fields.Add("ReceiveID", BUSReceiveDetailEntityFields.ReceiveID);
			this.Fields.Add("ProductID", BUSReceiveDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSReceiveDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSReceiveDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSReceiveDetailEntityFields.ValidateDate);
			this.Fields.Add("Amount", BUSReceiveDetailEntityFields.Amount);
			this.Fields.Add("ReceiveAmount", BUSReceiveDetailEntityFields.ReceiveAmount);
			this.Fields.Add("CreateUserID", BUSReceiveDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSReceiveDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSReceiveDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSReceiveDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSReceiveDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSReceiveDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSReceiveDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSReceiveDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSReceiveDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSReceiveDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSReceiveDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSReceiveDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSReceiveDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSReceiveDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSReceiveDetailEntityFields.Reservation10);
		}
	}

	#region BUSReceiveDetailEntityFields

	public class BUSReceiveDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_ReceiveDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ReceiveID
		{
			get { return new EntityField("BUS_ReceiveDetail", 1, "ReceiveID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ReceiveDetail", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_ReceiveDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_ReceiveDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_ReceiveDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_ReceiveDetail", 6, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReceiveAmount
		{
			get { return new EntityField("BUS_ReceiveDetail", 7, "ReceiveAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ReceiveDetail", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ReceiveDetail", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ReceiveDetail", 10, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ReceiveDetail", 11, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_ReceiveDetail", 12, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ReceiveDetail", 13, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ReceiveDetail", 14, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ReceiveDetail", 15, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ReceiveDetail", 16, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ReceiveDetail", 17, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ReceiveDetail", 18, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ReceiveDetail", 19, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ReceiveDetail", 20, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ReceiveDetail", 21, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ReceiveDetail", 22, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSReceiveDetailEntityFields2

	public enum BUSReceiveDetailEntityFields2
	{
		DetailID,

		ReceiveID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		Amount,

		ReceiveAmount,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		DetailRemark,

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
