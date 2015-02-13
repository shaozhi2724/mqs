/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-11-25 16:32:43
 *	Build Type: Entity
 *	Description: ATCRolePageEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCRolePageEntity : EntityBase
	{
		public Guid RoleID
		{
			get { return (Guid)this.GetValue("RoleID"); } 
			set { this.SetValue("RoleID", value); } 
		}

		public string PageCode
		{
			get { return (string)this.GetValue("PageCode"); } 
			set { this.SetValue("PageCode", value); } 
		}

		public string FunctionCode
		{
			get { return (string)this.GetValue("FunctionCode"); } 
			set { this.SetValue("FunctionCode", value); } 
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

		public ATCRolePageEntity()
		{
			this.TableName = "ATC_RolePage";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("RoleID", ATCRolePageEntityFields.RoleID);
			this.Fields.Add("PageCode", ATCRolePageEntityFields.PageCode);
			this.Fields.Add("FunctionCode", ATCRolePageEntityFields.FunctionCode);
			this.Fields.Add("CreateUserID", ATCRolePageEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCRolePageEntityFields.CreateDate);
			this.Fields.Add("Reservation1", ATCRolePageEntityFields.Reservation1);
			this.Fields.Add("Reservation2", ATCRolePageEntityFields.Reservation2);
			this.Fields.Add("Reservation3", ATCRolePageEntityFields.Reservation3);
			this.Fields.Add("Reservation4", ATCRolePageEntityFields.Reservation4);
			this.Fields.Add("Reservation5", ATCRolePageEntityFields.Reservation5);
		}
	}

	#region ATCRolePageEntityFields

	public class ATCRolePageEntityFields
	{
		public static EntityField RoleID
		{
			get { return new EntityField("ATC_RolePage", 0, "RoleID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField PageCode
		{
			get { return new EntityField("ATC_RolePage", 1, "PageCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField FunctionCode
		{
			get { return new EntityField("ATC_RolePage", 2, "FunctionCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_RolePage", 3, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_RolePage", 4, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("ATC_RolePage", 5, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("ATC_RolePage", 6, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("ATC_RolePage", 7, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("ATC_RolePage", 8, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("ATC_RolePage", 9, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCRolePageEntityFields2

	public enum ATCRolePageEntityFields2
	{
		RoleID,

		PageCode,

		FunctionCode,

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
