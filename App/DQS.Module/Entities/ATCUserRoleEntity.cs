/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: ATCUserRoleEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCUserRoleEntity : EntityBase
	{
		public Guid RoleID
		{
			get { return (Guid)this.GetValue("RoleID"); } 
			set { this.SetValue("RoleID", value); } 
		}

		public Guid UserID
		{
			get { return (Guid)this.GetValue("UserID"); } 
			set { this.SetValue("UserID", value); } 
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

		public ATCUserRoleEntity()
		{
			this.TableName = "ATC_UserRole";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("RoleID", ATCUserRoleEntityFields.RoleID);
			this.Fields.Add("UserID", ATCUserRoleEntityFields.UserID);
			this.Fields.Add("CreateUserID", ATCUserRoleEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCUserRoleEntityFields.CreateDate);
			this.Fields.Add("Reservation1", ATCUserRoleEntityFields.Reservation1);
			this.Fields.Add("Reservation2", ATCUserRoleEntityFields.Reservation2);
			this.Fields.Add("Reservation3", ATCUserRoleEntityFields.Reservation3);
			this.Fields.Add("Reservation4", ATCUserRoleEntityFields.Reservation4);
			this.Fields.Add("Reservation5", ATCUserRoleEntityFields.Reservation5);
		}
	}

	#region ATCUserRoleEntityFields

	public class ATCUserRoleEntityFields
	{
		public static EntityField RoleID
		{
			get { return new EntityField("ATC_UserRole", 0, "RoleID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField UserID
		{
			get { return new EntityField("ATC_UserRole", 1, "UserID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_UserRole", 2, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_UserRole", 3, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("ATC_UserRole", 4, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("ATC_UserRole", 5, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("ATC_UserRole", 6, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("ATC_UserRole", 7, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("ATC_UserRole", 8, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCUserRoleEntityFields2

	public enum ATCUserRoleEntityFields2
	{
		RoleID,

		UserID,

		CreateUserID,

		CreateDate,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
