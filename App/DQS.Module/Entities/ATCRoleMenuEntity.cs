/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: ATCRoleMenuEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCRoleMenuEntity : EntityBase
	{
		public Guid RoleID
		{
			get { return (Guid)this.GetValue("RoleID"); } 
			set { this.SetValue("RoleID", value); } 
		}

		public string MenuCode
		{
			get { return (string)this.GetValue("MenuCode"); } 
			set { this.SetValue("MenuCode", value); } 
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

		public ATCRoleMenuEntity()
		{
			this.TableName = "ATC_RoleMenu";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("RoleID", ATCRoleMenuEntityFields.RoleID);
			this.Fields.Add("MenuCode", ATCRoleMenuEntityFields.MenuCode);
			this.Fields.Add("CreateUserID", ATCRoleMenuEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCRoleMenuEntityFields.CreateDate);
			this.Fields.Add("Reservation1", ATCRoleMenuEntityFields.Reservation1);
			this.Fields.Add("Reservation2", ATCRoleMenuEntityFields.Reservation2);
			this.Fields.Add("Reservation3", ATCRoleMenuEntityFields.Reservation3);
			this.Fields.Add("Reservation4", ATCRoleMenuEntityFields.Reservation4);
			this.Fields.Add("Reservation5", ATCRoleMenuEntityFields.Reservation5);
		}
	}

	#region ATCRoleMenuEntityFields

	public class ATCRoleMenuEntityFields
	{
		public static EntityField RoleID
		{
			get { return new EntityField("ATC_RoleMenu", 0, "RoleID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField MenuCode
		{
			get { return new EntityField("ATC_RoleMenu", 1, "MenuCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_RoleMenu", 2, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_RoleMenu", 3, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("ATC_RoleMenu", 4, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("ATC_RoleMenu", 5, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("ATC_RoleMenu", 6, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("ATC_RoleMenu", 7, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("ATC_RoleMenu", 8, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCRoleMenuEntityFields2

	public enum ATCRoleMenuEntityFields2
	{
		RoleID,

		MenuCode,

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
