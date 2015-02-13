/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSReviewEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSReviewEntity : EntityBase
	{
		public int ReviewID
		{
			get { return (int)this.GetValue("ReviewID"); } 
			set { this.SetValue("ReviewID", value); } 
		}

		public string ReviewCode
		{
			get { return (string)this.GetValue("ReviewCode"); } 
			set { this.SetValue("ReviewCode", value); } 
		}

		public DateTime ReviewDate
		{
			get { return (DateTime)this.GetValue("ReviewDate"); } 
			set { this.SetValue("ReviewDate", value); } 
		}

		public string ReviewPerson
		{
			get { return (string)this.GetValue("ReviewPerson"); } 
			set { this.SetValue("ReviewPerson", value); } 
		}

		public string ReviewPersonSpell
		{
			get { return (string)this.GetValue("ReviewPersonSpell"); } 
			set { this.SetValue("ReviewPersonSpell", value); } 
		}

		public int StatusID
		{
			get { return (int)this.GetValue("StatusID"); } 
			set { this.SetValue("StatusID", value); } 
		}

		public string StatusName
		{
			get { return (string)this.GetValue("StatusName"); } 
			set { this.SetValue("StatusName", value); } 
		}

		public string StatusSpell
		{
			get { return (string)this.GetValue("StatusSpell"); } 
			set { this.SetValue("StatusSpell", value); } 
		}

		public int SaleBillID
		{
			get { return (int)this.GetValue("SaleBillID"); } 
			set { this.SetValue("SaleBillID", value); } 
		}

		public string SaleBillCode
		{
			get { return (string)this.GetValue("SaleBillCode"); } 
			set { this.SetValue("SaleBillCode", value); } 
		}

		public int StoreOutID
		{
			get { return (int)this.GetValue("StoreOutID"); } 
			set { this.SetValue("StoreOutID", value); } 
		}

		public string StoreOutCode
		{
			get { return (string)this.GetValue("StoreOutCode"); } 
			set { this.SetValue("StoreOutCode", value); } 
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

		public string ReviewRemark
		{
			get { return (string)this.GetValue("ReviewRemark"); } 
			set { this.SetValue("ReviewRemark", value); } 
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

		public BUSReviewEntity()
		{
			this.TableName = "BUS_Review";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ReviewID", BUSReviewEntityFields.ReviewID);
			this.Fields.Add("ReviewCode", BUSReviewEntityFields.ReviewCode);
			this.Fields.Add("ReviewDate", BUSReviewEntityFields.ReviewDate);
			this.Fields.Add("ReviewPerson", BUSReviewEntityFields.ReviewPerson);
			this.Fields.Add("ReviewPersonSpell", BUSReviewEntityFields.ReviewPersonSpell);
			this.Fields.Add("StatusID", BUSReviewEntityFields.StatusID);
			this.Fields.Add("StatusName", BUSReviewEntityFields.StatusName);
			this.Fields.Add("StatusSpell", BUSReviewEntityFields.StatusSpell);
			this.Fields.Add("SaleBillID", BUSReviewEntityFields.SaleBillID);
			this.Fields.Add("SaleBillCode", BUSReviewEntityFields.SaleBillCode);
			this.Fields.Add("StoreOutID", BUSReviewEntityFields.StoreOutID);
			this.Fields.Add("StoreOutCode", BUSReviewEntityFields.StoreOutCode);
			this.Fields.Add("CreateUserID", BUSReviewEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSReviewEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSReviewEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSReviewEntityFields.LastModifyDate);
			this.Fields.Add("ReviewRemark", BUSReviewEntityFields.ReviewRemark);
			this.Fields.Add("Reservation1", BUSReviewEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSReviewEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSReviewEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSReviewEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSReviewEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSReviewEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSReviewEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSReviewEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSReviewEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSReviewEntityFields.Reservation10);
		}
	}

	#region BUSReviewEntityFields

	public class BUSReviewEntityFields
	{
		public static EntityField ReviewID
		{
			get { return new EntityField("BUS_Review", 0, "ReviewID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ReviewCode
		{
			get { return new EntityField("BUS_Review", 1, "ReviewCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ReviewDate
		{
			get { return new EntityField("BUS_Review", 2, "ReviewDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ReviewPerson
		{
			get { return new EntityField("BUS_Review", 3, "ReviewPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReviewPersonSpell
		{
			get { return new EntityField("BUS_Review", 4, "ReviewPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StatusID
		{
			get { return new EntityField("BUS_Review", 5, "StatusID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StatusName
		{
			get { return new EntityField("BUS_Review", 6, "StatusName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StatusSpell
		{
			get { return new EntityField("BUS_Review", 7, "StatusSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SaleBillID
		{
			get { return new EntityField("BUS_Review", 8, "SaleBillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField SaleBillCode
		{
			get { return new EntityField("BUS_Review", 9, "SaleBillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreOutID
		{
			get { return new EntityField("BUS_Review", 10, "StoreOutID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StoreOutCode
		{
			get { return new EntityField("BUS_Review", 11, "StoreOutCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_Review", 12, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_Review", 13, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_Review", 14, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_Review", 15, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ReviewRemark
		{
			get { return new EntityField("BUS_Review", 16, "ReviewRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_Review", 17, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_Review", 18, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_Review", 19, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_Review", 20, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_Review", 21, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_Review", 22, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_Review", 23, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_Review", 24, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_Review", 25, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_Review", 26, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSReviewEntityFields2

	public enum BUSReviewEntityFields2
	{
		ReviewID,

		ReviewCode,

		ReviewDate,

		ReviewPerson,

		ReviewPersonSpell,

		StatusID,

		StatusName,

		StatusSpell,

		SaleBillID,

		SaleBillCode,

		StoreOutID,

		StoreOutCode,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		ReviewRemark,

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
