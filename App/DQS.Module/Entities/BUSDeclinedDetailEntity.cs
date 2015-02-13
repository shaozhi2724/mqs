/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-30 11:33:47
 *	Build Type: Entity
 *	Description: BUSDeclinedDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSDeclinedDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int DeclinedID
		{
			get { return (int)this.GetValue("DeclinedID"); } 
			set { this.SetValue("DeclinedID", value); } 
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

		public int DeclinedAmount
		{
			get { return (int)this.GetValue("DeclinedAmount"); } 
			set { this.SetValue("DeclinedAmount", value); } 
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

		public BUSDeclinedDetailEntity()
		{
			this.TableName = "BUS_DeclinedDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSDeclinedDetailEntityFields.DetailID);
			this.Fields.Add("DeclinedID", BUSDeclinedDetailEntityFields.DeclinedID);
			this.Fields.Add("ProductID", BUSDeclinedDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSDeclinedDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSDeclinedDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSDeclinedDetailEntityFields.ValidateDate);
			this.Fields.Add("Amount", BUSDeclinedDetailEntityFields.Amount);
			this.Fields.Add("DeclinedAmount", BUSDeclinedDetailEntityFields.DeclinedAmount);
			this.Fields.Add("CreateUserID", BUSDeclinedDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSDeclinedDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSDeclinedDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSDeclinedDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSDeclinedDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSDeclinedDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSDeclinedDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSDeclinedDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSDeclinedDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSDeclinedDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSDeclinedDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSDeclinedDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSDeclinedDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSDeclinedDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSDeclinedDetailEntityFields.Reservation10);
		}
	}

	#region BUSDeclinedDetailEntityFields

	public class BUSDeclinedDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_DeclinedDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField DeclinedID
		{
			get { return new EntityField("BUS_DeclinedDetail", 1, "DeclinedID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_DeclinedDetail", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_DeclinedDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_DeclinedDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_DeclinedDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_DeclinedDetail", 6, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DeclinedAmount
		{
			get { return new EntityField("BUS_DeclinedDetail", 7, "DeclinedAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_DeclinedDetail", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_DeclinedDetail", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_DeclinedDetail", 10, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_DeclinedDetail", 11, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_DeclinedDetail", 12, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_DeclinedDetail", 13, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_DeclinedDetail", 14, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_DeclinedDetail", 15, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_DeclinedDetail", 16, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_DeclinedDetail", 17, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_DeclinedDetail", 18, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_DeclinedDetail", 19, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_DeclinedDetail", 20, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_DeclinedDetail", 21, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_DeclinedDetail", 22, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSDeclinedDetailEntityFields2

	public enum BUSDeclinedDetailEntityFields2
	{
		DetailID,

		DeclinedID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		Amount,

		DeclinedAmount,

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
