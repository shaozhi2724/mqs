/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: ATCRoleEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCRoleEntity : EntityBase
	{
		public Guid RoleID
		{
			get { return (Guid)this.GetValue("RoleID"); } 
			set { this.SetValue("RoleID", value); } 
		}

		public string RoleCode
		{
			get { return (string)this.GetValue("RoleCode"); } 
			set { this.SetValue("RoleCode", value); } 
		}

		public string RoleName
		{
			get { return (string)this.GetValue("RoleName"); } 
			set { this.SetValue("RoleName", value); } 
		}

		public string RoleSpell
		{
			get { return (string)this.GetValue("RoleSpell"); } 
			set { this.SetValue("RoleSpell", value); } 
		}

		public int RoleStatus
		{
			get { return (int)this.GetValue("RoleStatus"); } 
			set { this.SetValue("RoleStatus", value); } 
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

		public string RoleRemark
		{
			get { return (string)this.GetValue("RoleRemark"); } 
			set { this.SetValue("RoleRemark", value); } 
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

		public ATCRoleEntity()
		{
			this.TableName = "ATC_Role";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("RoleID", ATCRoleEntityFields.RoleID);
			this.Fields.Add("RoleCode", ATCRoleEntityFields.RoleCode);
			this.Fields.Add("RoleName", ATCRoleEntityFields.RoleName);
			this.Fields.Add("RoleSpell", ATCRoleEntityFields.RoleSpell);
			this.Fields.Add("RoleStatus", ATCRoleEntityFields.RoleStatus);
			this.Fields.Add("CreateUserID", ATCRoleEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCRoleEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", ATCRoleEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", ATCRoleEntityFields.LastModifyDate);
			this.Fields.Add("RoleRemark", ATCRoleEntityFields.RoleRemark);
			this.Fields.Add("Reservation1", ATCRoleEntityFields.Reservation1);
			this.Fields.Add("Reservation2", ATCRoleEntityFields.Reservation2);
			this.Fields.Add("Reservation3", ATCRoleEntityFields.Reservation3);
			this.Fields.Add("Reservation4", ATCRoleEntityFields.Reservation4);
			this.Fields.Add("Reservation5", ATCRoleEntityFields.Reservation5);
		}
	}

	#region ATCRoleEntityFields

	public class ATCRoleEntityFields
	{
		public static EntityField RoleID
		{
			get { return new EntityField("ATC_Role", 0, "RoleID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField RoleCode
		{
			get { return new EntityField("ATC_Role", 1, "RoleCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField RoleName
		{
			get { return new EntityField("ATC_Role", 2, "RoleName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField RoleSpell
		{
			get { return new EntityField("ATC_Role", 3, "RoleSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RoleStatus
		{
			get { return new EntityField("ATC_Role", 4, "RoleStatus", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_Role", 5, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_Role", 6, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("ATC_Role", 7, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("ATC_Role", 8, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField RoleRemark
		{
			get { return new EntityField("ATC_Role", 9, "RoleRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("ATC_Role", 10, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("ATC_Role", 11, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("ATC_Role", 12, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("ATC_Role", 13, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("ATC_Role", 14, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCRoleEntityFields2

	public enum ATCRoleEntityFields2
	{
		RoleID,

		RoleCode,

		RoleName,

		RoleSpell,

		RoleStatus,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		RoleRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
