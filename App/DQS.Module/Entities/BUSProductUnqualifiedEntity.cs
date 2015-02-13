/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-28 18:02:39
 *	Build Type: Entity
 *	Description: BUSProductUnqualifiedEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSProductUnqualifiedEntity : EntityBase
	{
		public int UnqualifiedID
		{
			get { return (int)this.GetValue("UnqualifiedID"); } 
			set { this.SetValue("UnqualifiedID", value); } 
		}

		public string UnqualifiedCode
		{
			get { return (string)this.GetValue("UnqualifiedCode"); } 
			set { this.SetValue("UnqualifiedCode", value); } 
		}

		public string UnqualifiedCause
		{
			get { return (string)this.GetValue("UnqualifiedCause"); } 
			set { this.SetValue("UnqualifiedCause", value); } 
		}

		public string Blame
		{
			get { return (string)this.GetValue("Blame"); } 
			set { this.SetValue("Blame", value); } 
		}

		public string BlameSpell
		{
			get { return (string)this.GetValue("BlameSpell"); } 
			set { this.SetValue("BlameSpell", value); } 
		}

		public bool IsCutAmount
		{
			get { return (bool)this.GetValue("IsCutAmount"); } 
			set { this.SetValue("IsCutAmount", value); } 
		}

		public string DealSuggestion
		{
			get { return (string)this.GetValue("DealSuggestion"); } 
			set { this.SetValue("DealSuggestion", value); } 
		}

		public int UnqualifiedStatusID
		{
			get { return (int)this.GetValue("UnqualifiedStatusID"); } 
			set { this.SetValue("UnqualifiedStatusID", value); } 
		}

		public string UnqualifiedStatus
		{
			get { return (string)this.GetValue("UnqualifiedStatus"); } 
			set { this.SetValue("UnqualifiedStatus", value); } 
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

		public string UnqualifiedRemark
		{
			get { return (string)this.GetValue("UnqualifiedRemark"); } 
			set { this.SetValue("UnqualifiedRemark", value); } 
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

		public BUSProductUnqualifiedEntity()
		{
			this.TableName = "BUS_ProductUnqualified";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("UnqualifiedID", BUSProductUnqualifiedEntityFields.UnqualifiedID);
			this.Fields.Add("UnqualifiedCode", BUSProductUnqualifiedEntityFields.UnqualifiedCode);
			this.Fields.Add("UnqualifiedCause", BUSProductUnqualifiedEntityFields.UnqualifiedCause);
			this.Fields.Add("Blame", BUSProductUnqualifiedEntityFields.Blame);
			this.Fields.Add("BlameSpell", BUSProductUnqualifiedEntityFields.BlameSpell);
			this.Fields.Add("IsCutAmount", BUSProductUnqualifiedEntityFields.IsCutAmount);
			this.Fields.Add("DealSuggestion", BUSProductUnqualifiedEntityFields.DealSuggestion);
			this.Fields.Add("UnqualifiedStatusID", BUSProductUnqualifiedEntityFields.UnqualifiedStatusID);
			this.Fields.Add("UnqualifiedStatus", BUSProductUnqualifiedEntityFields.UnqualifiedStatus);
			this.Fields.Add("CreateUserID", BUSProductUnqualifiedEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSProductUnqualifiedEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSProductUnqualifiedEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSProductUnqualifiedEntityFields.LastModifyDate);
			this.Fields.Add("UnqualifiedRemark", BUSProductUnqualifiedEntityFields.UnqualifiedRemark);
			this.Fields.Add("Reservation1", BUSProductUnqualifiedEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSProductUnqualifiedEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSProductUnqualifiedEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSProductUnqualifiedEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSProductUnqualifiedEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSProductUnqualifiedEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSProductUnqualifiedEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSProductUnqualifiedEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSProductUnqualifiedEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSProductUnqualifiedEntityFields.Reservation10);
		}
	}

	#region BUSProductUnqualifiedEntityFields

	public class BUSProductUnqualifiedEntityFields
	{
		public static EntityField UnqualifiedID
		{
			get { return new EntityField("BUS_ProductUnqualified", 0, "UnqualifiedID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField UnqualifiedCode
		{
			get { return new EntityField("BUS_ProductUnqualified", 1, "UnqualifiedCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField UnqualifiedCause
		{
			get { return new EntityField("BUS_ProductUnqualified", 2, "UnqualifiedCause", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Blame
		{
			get { return new EntityField("BUS_ProductUnqualified", 3, "Blame", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BlameSpell
		{
			get { return new EntityField("BUS_ProductUnqualified", 4, "BlameSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsCutAmount
		{
			get { return new EntityField("BUS_ProductUnqualified", 5, "IsCutAmount", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField DealSuggestion
		{
			get { return new EntityField("BUS_ProductUnqualified", 6, "DealSuggestion", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField UnqualifiedStatusID
		{
			get { return new EntityField("BUS_ProductUnqualified", 7, "UnqualifiedStatusID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField UnqualifiedStatus
		{
			get { return new EntityField("BUS_ProductUnqualified", 8, "UnqualifiedStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ProductUnqualified", 9, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ProductUnqualified", 10, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ProductUnqualified", 11, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ProductUnqualified", 12, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField UnqualifiedRemark
		{
			get { return new EntityField("BUS_ProductUnqualified", 13, "UnqualifiedRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ProductUnqualified", 14, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ProductUnqualified", 15, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ProductUnqualified", 16, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ProductUnqualified", 17, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ProductUnqualified", 18, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ProductUnqualified", 19, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ProductUnqualified", 20, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ProductUnqualified", 21, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ProductUnqualified", 22, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ProductUnqualified", 23, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSProductUnqualifiedEntityFields2

	public enum BUSProductUnqualifiedEntityFields2
	{
		UnqualifiedID,

		UnqualifiedCode,

		UnqualifiedCause,

		Blame,

		BlameSpell,

		IsCutAmount,

		DealSuggestion,

		UnqualifiedStatusID,

		UnqualifiedStatus,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		UnqualifiedRemark,

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
