/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-23 16:33:19
 *	Build Type: Entity
 *	Description: BUSUnqualifiedStoreDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSUnqualifiedStoreDetailEntity : EntityBase
	{
		public int StoreDetailID
		{
			get { return (int)this.GetValue("StoreDetailID"); } 
			set { this.SetValue("StoreDetailID", value); } 
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

		public int CreateStoreID
		{
			get { return (int)this.GetValue("CreateStoreID"); } 
			set { this.SetValue("CreateStoreID", value); } 
		}

		public string CreateStoreCode
		{
			get { return (string)this.GetValue("CreateStoreCode"); } 
			set { this.SetValue("CreateStoreCode", value); } 
		}

		public int LastStoreID
		{
			get { return (int)this.GetValue("LastStoreID"); } 
			set { this.SetValue("LastStoreID", value); } 
		}

		public string LastStoreCode
		{
			get { return (string)this.GetValue("LastStoreCode"); } 
			set { this.SetValue("LastStoreCode", value); } 
		}

		public DateTime LastCuringDate
		{
			get { return (DateTime)this.GetValue("LastCuringDate"); } 
			set { this.SetValue("LastCuringDate", value); } 
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

		public BUSUnqualifiedStoreDetailEntity()
		{
			this.TableName = "BUS_UnqualifiedStoreDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("StoreDetailID", BUSUnqualifiedStoreDetailEntityFields.StoreDetailID);
			this.Fields.Add("ProductID", BUSUnqualifiedStoreDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSUnqualifiedStoreDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSUnqualifiedStoreDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSUnqualifiedStoreDetailEntityFields.ValidateDate);
			this.Fields.Add("Amount", BUSUnqualifiedStoreDetailEntityFields.Amount);
			this.Fields.Add("CreateStoreID", BUSUnqualifiedStoreDetailEntityFields.CreateStoreID);
			this.Fields.Add("CreateStoreCode", BUSUnqualifiedStoreDetailEntityFields.CreateStoreCode);
			this.Fields.Add("LastStoreID", BUSUnqualifiedStoreDetailEntityFields.LastStoreID);
			this.Fields.Add("LastStoreCode", BUSUnqualifiedStoreDetailEntityFields.LastStoreCode);
			this.Fields.Add("LastCuringDate", BUSUnqualifiedStoreDetailEntityFields.LastCuringDate);
			this.Fields.Add("CreateUserID", BUSUnqualifiedStoreDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSUnqualifiedStoreDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSUnqualifiedStoreDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSUnqualifiedStoreDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSUnqualifiedStoreDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSUnqualifiedStoreDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSUnqualifiedStoreDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSUnqualifiedStoreDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSUnqualifiedStoreDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSUnqualifiedStoreDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSUnqualifiedStoreDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSUnqualifiedStoreDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSUnqualifiedStoreDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSUnqualifiedStoreDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSUnqualifiedStoreDetailEntityFields.Reservation10);
		}
	}

	#region BUSUnqualifiedStoreDetailEntityFields

	public class BUSUnqualifiedStoreDetailEntityFields
	{
		public static EntityField StoreDetailID
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 0, "StoreDetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 1, "ProductID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 2, "BatchNo", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 3, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 4, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 5, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateStoreID
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 6, "CreateStoreID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateStoreCode
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 7, "CreateStoreCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LastStoreID
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 8, "LastStoreID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField LastStoreCode
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 9, "LastStoreCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LastCuringDate
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 10, "LastCuringDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 11, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 12, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 13, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 14, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 15, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 16, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 17, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 18, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 19, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 20, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 21, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 22, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 23, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 24, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_UnqualifiedStoreDetail", 25, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSUnqualifiedStoreDetailEntityFields2

	public enum BUSUnqualifiedStoreDetailEntityFields2
	{
		StoreDetailID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		Amount,

		CreateStoreID,

		CreateStoreCode,

		LastStoreID,

		LastStoreCode,

		LastCuringDate,

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
