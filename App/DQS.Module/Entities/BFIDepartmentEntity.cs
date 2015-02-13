/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BFIDepartmentEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIDepartmentEntity : EntityBase
	{
		public int DepartmentID
		{
			get { return (int)this.GetValue("DepartmentID"); } 
			set { this.SetValue("DepartmentID", value); } 
		}

		public string DepartmentCode
		{
			get { return (string)this.GetValue("DepartmentCode"); } 
			set { this.SetValue("DepartmentCode", value); } 
		}

		public string DepartmentName
		{
			get { return (string)this.GetValue("DepartmentName"); } 
			set { this.SetValue("DepartmentName", value); } 
		}

		public string DepartmentSpell
		{
			get { return (string)this.GetValue("DepartmentSpell"); } 
			set { this.SetValue("DepartmentSpell", value); } 
		}

		public string DepartmentLeader
		{
			get { return (string)this.GetValue("DepartmentLeader"); } 
			set { this.SetValue("DepartmentLeader", value); } 
		}

		public string LeaderSpell
		{
			get { return (string)this.GetValue("LeaderSpell"); } 
			set { this.SetValue("LeaderSpell", value); } 
		}

		public string LeaderPhone
		{
			get { return (string)this.GetValue("LeaderPhone"); } 
			set { this.SetValue("LeaderPhone", value); } 
		}

		public string DepartmentDuty
		{
			get { return (string)this.GetValue("DepartmentDuty"); } 
			set { this.SetValue("DepartmentDuty", value); } 
		}

		public int EnterpriseID
		{
			get { return (int)this.GetValue("EnterpriseID"); } 
			set { this.SetValue("EnterpriseID", value); } 
		}

		public int ParentDepartmentID
		{
			get { return (int)this.GetValue("ParentDepartmentID"); } 
			set { this.SetValue("ParentDepartmentID", value); } 
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

		public string DepartmentRemark
		{
			get { return (string)this.GetValue("DepartmentRemark"); } 
			set { this.SetValue("DepartmentRemark", value); } 
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

		public BFIDepartmentEntity()
		{
			this.TableName = "BFI_Department";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DepartmentID", BFIDepartmentEntityFields.DepartmentID);
			this.Fields.Add("DepartmentCode", BFIDepartmentEntityFields.DepartmentCode);
			this.Fields.Add("DepartmentName", BFIDepartmentEntityFields.DepartmentName);
			this.Fields.Add("DepartmentSpell", BFIDepartmentEntityFields.DepartmentSpell);
			this.Fields.Add("DepartmentLeader", BFIDepartmentEntityFields.DepartmentLeader);
			this.Fields.Add("LeaderSpell", BFIDepartmentEntityFields.LeaderSpell);
			this.Fields.Add("LeaderPhone", BFIDepartmentEntityFields.LeaderPhone);
			this.Fields.Add("DepartmentDuty", BFIDepartmentEntityFields.DepartmentDuty);
			this.Fields.Add("EnterpriseID", BFIDepartmentEntityFields.EnterpriseID);
			this.Fields.Add("ParentDepartmentID", BFIDepartmentEntityFields.ParentDepartmentID);
			this.Fields.Add("CreateUserID", BFIDepartmentEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIDepartmentEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIDepartmentEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIDepartmentEntityFields.LastModifyDate);
			this.Fields.Add("DepartmentRemark", BFIDepartmentEntityFields.DepartmentRemark);
			this.Fields.Add("Reservation1", BFIDepartmentEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIDepartmentEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIDepartmentEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIDepartmentEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIDepartmentEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIDepartmentEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIDepartmentEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIDepartmentEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIDepartmentEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIDepartmentEntityFields.Reservation10);
		}
	}

	#region BFIDepartmentEntityFields

	public class BFIDepartmentEntityFields
	{
		public static EntityField DepartmentID
		{
			get { return new EntityField("BFI_Department", 0, "DepartmentID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField DepartmentCode
		{
			get { return new EntityField("BFI_Department", 1, "DepartmentCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField DepartmentName
		{
			get { return new EntityField("BFI_Department", 2, "DepartmentName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField DepartmentSpell
		{
			get { return new EntityField("BFI_Department", 3, "DepartmentSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DepartmentLeader
		{
			get { return new EntityField("BFI_Department", 4, "DepartmentLeader", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LeaderSpell
		{
			get { return new EntityField("BFI_Department", 5, "LeaderSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LeaderPhone
		{
			get { return new EntityField("BFI_Department", 6, "LeaderPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DepartmentDuty
		{
			get { return new EntityField("BFI_Department", 7, "DepartmentDuty", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseID
		{
			get { return new EntityField("BFI_Department", 8, "EnterpriseID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ParentDepartmentID
		{
			get { return new EntityField("BFI_Department", 9, "ParentDepartmentID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_Department", 10, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_Department", 11, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_Department", 12, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_Department", 13, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DepartmentRemark
		{
			get { return new EntityField("BFI_Department", 14, "DepartmentRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_Department", 15, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_Department", 16, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_Department", 17, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_Department", 18, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_Department", 19, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_Department", 20, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_Department", 21, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_Department", 22, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_Department", 23, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_Department", 24, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIDepartmentEntityFields2

	public enum BFIDepartmentEntityFields2
	{
		DepartmentID,

		DepartmentCode,

		DepartmentName,

		DepartmentSpell,

		DepartmentLeader,

		LeaderSpell,

		LeaderPhone,

		DepartmentDuty,

		EnterpriseID,

		ParentDepartmentID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		DepartmentRemark,

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
