/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: ATCUserEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCUserEntity : EntityBase
	{
		public Guid UserID
		{
			get { return (Guid)this.GetValue("UserID"); } 
			set { this.SetValue("UserID", value); } 
		}

		public string UserCode
		{
			get { return (string)this.GetValue("UserCode"); } 
			set { this.SetValue("UserCode", value); } 
		}

		public string UserName
		{
			get { return (string)this.GetValue("UserName"); } 
			set { this.SetValue("UserName", value); } 
		}

		public string UserSpell
		{
			get { return (string)this.GetValue("UserSpell"); } 
			set { this.SetValue("UserSpell", value); } 
		}

		public string UserPassword
		{
			get { return (string)this.GetValue("UserPassword"); } 
			set { this.SetValue("UserPassword", value); } 
		}

		public int UserStatus
		{
			get { return (int)this.GetValue("UserStatus"); } 
			set { this.SetValue("UserStatus", value); } 
		}

		public int EmployeeID
		{
			get { return (int)this.GetValue("EmployeeID"); } 
			set { this.SetValue("EmployeeID", value); } 
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

		public string UserRemark
		{
			get { return (string)this.GetValue("UserRemark"); } 
			set { this.SetValue("UserRemark", value); } 
		}

        public bool UseInternalProductPrice
		{
            get { return (bool)this.GetValue("UseInternalProductPrice"); }
            set { this.SetValue("UseInternalProductPrice", value); } 
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

		public ATCUserEntity()
		{
			this.TableName = "ATC_User";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("UserID", ATCUserEntityFields.UserID);
			this.Fields.Add("UserCode", ATCUserEntityFields.UserCode);
			this.Fields.Add("UserName", ATCUserEntityFields.UserName);
			this.Fields.Add("UserSpell", ATCUserEntityFields.UserSpell);
			this.Fields.Add("UserPassword", ATCUserEntityFields.UserPassword);
			this.Fields.Add("UserStatus", ATCUserEntityFields.UserStatus);
			this.Fields.Add("EmployeeID", ATCUserEntityFields.EmployeeID);
			this.Fields.Add("CreateUserID", ATCUserEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCUserEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", ATCUserEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", ATCUserEntityFields.LastModifyDate);
			this.Fields.Add("UserRemark", ATCUserEntityFields.UserRemark);
            this.Fields.Add("UseInternalProductPrice", ATCUserEntityFields.UseInternalProductPrice);
			this.Fields.Add("Reservation1", ATCUserEntityFields.Reservation1);
			this.Fields.Add("Reservation2", ATCUserEntityFields.Reservation2);
			this.Fields.Add("Reservation3", ATCUserEntityFields.Reservation3);
			this.Fields.Add("Reservation4", ATCUserEntityFields.Reservation4);
			this.Fields.Add("Reservation5", ATCUserEntityFields.Reservation5);
		}
	}

	#region ATCUserEntityFields

	public class ATCUserEntityFields
	{
		public static EntityField UserID
		{
			get { return new EntityField("ATC_User", 0, "UserID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField UserCode
		{
			get { return new EntityField("ATC_User", 1, "UserCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField UserName
		{
			get { return new EntityField("ATC_User", 2, "UserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField UserSpell
		{
			get { return new EntityField("ATC_User", 3, "UserSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField UserPassword
		{
			get { return new EntityField("ATC_User", 4, "UserPassword", SqlDbType.NChar, false, false, false, false); }
		}

		public static EntityField UserStatus
		{
			get { return new EntityField("ATC_User", 5, "UserStatus", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField EmployeeID
		{
			get { return new EntityField("ATC_User", 6, "EmployeeID", SqlDbType.Int, false, false, true, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_User", 7, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_User", 8, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("ATC_User", 9, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("ATC_User", 10, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField UserRemark
		{
			get { return new EntityField("ATC_User", 11, "UserRemark", SqlDbType.NVarChar, false, false, false, true); }
		}
        public static EntityField UseInternalProductPrice
		{
            get { return new EntityField("ATC_User", 12, "UseInternalProductPrice", SqlDbType.Bit, false, false, false, false); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("ATC_User", 13, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("ATC_User", 14, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("ATC_User", 15, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("ATC_User", 16, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("ATC_User", 17, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCUserEntityFields2

	public enum ATCUserEntityFields2
	{
		UserID,

		UserCode,

		UserName,

		UserSpell,

		UserPassword,

		UserStatus,

		EmployeeID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		UserRemark,

        UseInternalProductPrice,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
