/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-30 14:36:50
 *	Build Type: Entity
 *	Description: BUSProductLockedEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSProductLockedEntity : EntityBase
	{
		public int LockedID
		{
			get { return (int)this.GetValue("LockedID"); } 
			set { this.SetValue("LockedID", value); } 
		}

		public string LockedCode
		{
			get { return (string)this.GetValue("LockedCode"); } 
			set { this.SetValue("LockedCode", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string LockedUser
		{
			get { return (string)this.GetValue("LockedUser"); } 
			set { this.SetValue("LockedUser", value); } 
		}

		public string LockedUserSpell
		{
			get { return (string)this.GetValue("LockedUserSpell"); } 
			set { this.SetValue("LockedUserSpell", value); } 
		}

		public DateTime LockedDate
		{
			get { return (DateTime)this.GetValue("LockedDate"); } 
			set { this.SetValue("LockedDate", value); } 
		}

		public bool IsLockedBatch
		{
			get { return (bool)this.GetValue("IsLockedBatch"); } 
			set { this.SetValue("IsLockedBatch", value); } 
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

		public int LockedAmount
		{
			get { return (int)this.GetValue("LockedAmount"); } 
			set { this.SetValue("LockedAmount", value); } 
		}

		public bool IsUnLocked
		{
			get { return (bool)this.GetValue("IsUnLocked"); } 
			set { this.SetValue("IsUnLocked", value); } 
		}

		public string UnLockedUser
		{
			get { return (string)this.GetValue("UnLockedUser"); } 
			set { this.SetValue("UnLockedUser", value); } 
		}

		public string UnLockedUserSpell
		{
			get { return (string)this.GetValue("UnLockedUserSpell"); } 
			set { this.SetValue("UnLockedUserSpell", value); } 
		}

		public DateTime UnLockedDate
		{
			get { return (DateTime)this.GetValue("UnLockedDate"); } 
			set { this.SetValue("UnLockedDate", value); } 
		}

		public string DealResult
		{
			get { return (string)this.GetValue("DealResult"); } 
			set { this.SetValue("DealResult", value); } 
		}

		public int LockedStatusID
		{
			get { return (int)this.GetValue("LockedStatusID"); } 
			set { this.SetValue("LockedStatusID", value); } 
		}

		public string LockedStatus
		{
			get { return (string)this.GetValue("LockedStatus"); } 
			set { this.SetValue("LockedStatus", value); } 
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

		public string LockedRemark
		{
			get { return (string)this.GetValue("LockedRemark"); } 
			set { this.SetValue("LockedRemark", value); } 
		}

        public int InStoreID
        {
            get { return (int)this.GetValue("InStoreID"); }
            set { this.SetValue("InStoreID", value); }
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

		public BUSProductLockedEntity()
		{
			this.TableName = "BUS_ProductLocked";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("LockedID", BUSProductLockedEntityFields.LockedID);
			this.Fields.Add("LockedCode", BUSProductLockedEntityFields.LockedCode);
			this.Fields.Add("ProductID", BUSProductLockedEntityFields.ProductID);
			this.Fields.Add("LockedUser", BUSProductLockedEntityFields.LockedUser);
			this.Fields.Add("LockedUserSpell", BUSProductLockedEntityFields.LockedUserSpell);
			this.Fields.Add("LockedDate", BUSProductLockedEntityFields.LockedDate);
			this.Fields.Add("IsLockedBatch", BUSProductLockedEntityFields.IsLockedBatch);
			this.Fields.Add("BatchNo", BUSProductLockedEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSProductLockedEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSProductLockedEntityFields.ValidateDate);
			this.Fields.Add("LockedAmount", BUSProductLockedEntityFields.LockedAmount);
			this.Fields.Add("IsUnLocked", BUSProductLockedEntityFields.IsUnLocked);
			this.Fields.Add("UnLockedUser", BUSProductLockedEntityFields.UnLockedUser);
			this.Fields.Add("UnLockedUserSpell", BUSProductLockedEntityFields.UnLockedUserSpell);
			this.Fields.Add("UnLockedDate", BUSProductLockedEntityFields.UnLockedDate);
			this.Fields.Add("DealResult", BUSProductLockedEntityFields.DealResult);
			this.Fields.Add("LockedStatusID", BUSProductLockedEntityFields.LockedStatusID);
			this.Fields.Add("LockedStatus", BUSProductLockedEntityFields.LockedStatus);
			this.Fields.Add("CreateUserID", BUSProductLockedEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSProductLockedEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSProductLockedEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSProductLockedEntityFields.LastModifyDate);
			this.Fields.Add("LockedRemark", BUSProductLockedEntityFields.LockedRemark);
            this.Fields.Add("InStoreID", BUSProductLockedEntityFields.InStoreID);
			this.Fields.Add("Reservation1", BUSProductLockedEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSProductLockedEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSProductLockedEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSProductLockedEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSProductLockedEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSProductLockedEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSProductLockedEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSProductLockedEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSProductLockedEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSProductLockedEntityFields.Reservation10);
		}
	}

	#region BUSProductLockedEntityFields

	public class BUSProductLockedEntityFields
	{
		public static EntityField LockedID
		{
			get { return new EntityField("BUS_ProductLocked", 0, "LockedID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField LockedCode
		{
			get { return new EntityField("BUS_ProductLocked", 1, "LockedCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ProductLocked", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField LockedUser
		{
			get { return new EntityField("BUS_ProductLocked", 3, "LockedUser", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LockedUserSpell
		{
			get { return new EntityField("BUS_ProductLocked", 4, "LockedUserSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LockedDate
		{
			get { return new EntityField("BUS_ProductLocked", 5, "LockedDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField IsLockedBatch
		{
			get { return new EntityField("BUS_ProductLocked", 6, "IsLockedBatch", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_ProductLocked", 7, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_ProductLocked", 8, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_ProductLocked", 9, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LockedAmount
		{
			get { return new EntityField("BUS_ProductLocked", 10, "LockedAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField IsUnLocked
		{
			get { return new EntityField("BUS_ProductLocked", 11, "IsUnLocked", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField UnLockedUser
		{
			get { return new EntityField("BUS_ProductLocked", 12, "UnLockedUser", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField UnLockedUserSpell
		{
			get { return new EntityField("BUS_ProductLocked", 13, "UnLockedUserSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField UnLockedDate
		{
			get { return new EntityField("BUS_ProductLocked", 14, "UnLockedDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DealResult
		{
			get { return new EntityField("BUS_ProductLocked", 15, "DealResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LockedStatusID
		{
			get { return new EntityField("BUS_ProductLocked", 16, "LockedStatusID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField LockedStatus
		{
			get { return new EntityField("BUS_ProductLocked", 17, "LockedStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ProductLocked", 18, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ProductLocked", 19, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ProductLocked", 20, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ProductLocked", 21, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LockedRemark
		{
			get { return new EntityField("BUS_ProductLocked", 22, "LockedRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField InStoreID
		{
            get { return new EntityField("BUS_ProductLocked", 23, "InStoreID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ProductLocked", 24, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ProductLocked", 25, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ProductLocked", 26, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ProductLocked", 27, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ProductLocked", 28, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ProductLocked", 29, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ProductLocked", 30, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ProductLocked", 31, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ProductLocked", 32, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ProductLocked", 33, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSProductLockedEntityFields2

	public enum BUSProductLockedEntityFields2
	{
		LockedID,

		LockedCode,

		ProductID,

		LockedUser,

		LockedUserSpell,

		LockedDate,

		IsLockedBatch,

		BatchNo,

		ProduceDate,

		ValidateDate,

		LockedAmount,

		IsUnLocked,

		UnLockedUser,

		UnLockedUserSpell,

		UnLockedDate,

		DealResult,

		LockedStatusID,

		LockedStatus,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		LockedRemark,

        InStoreID,

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
