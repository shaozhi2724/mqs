/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: ATCUserQueryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCUserQueryEntity : EntityBase
	{
		public Guid UserID
		{
			get { return (Guid)this.GetValue("UserID"); } 
			set { this.SetValue("UserID", value); } 
		}

		public string PageCode
		{
			get { return (string)this.GetValue("PageCode"); } 
			set { this.SetValue("PageCode", value); } 
		}

		public string QueryField
		{
			get { return (string)this.GetValue("QueryField"); } 
			set { this.SetValue("QueryField", value); } 
		}

		public string QueryValue
		{
			get { return (string)this.GetValue("QueryValue"); } 
			set { this.SetValue("QueryValue", value); } 
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

		public ATCUserQueryEntity()
		{
			this.TableName = "ATC_UserQuery";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("UserID", ATCUserQueryEntityFields.UserID);
			this.Fields.Add("PageCode", ATCUserQueryEntityFields.PageCode);
			this.Fields.Add("QueryField", ATCUserQueryEntityFields.QueryField);
			this.Fields.Add("QueryValue", ATCUserQueryEntityFields.QueryValue);
			this.Fields.Add("CreateUserID", ATCUserQueryEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCUserQueryEntityFields.CreateDate);
			this.Fields.Add("Reservation1", ATCUserQueryEntityFields.Reservation1);
			this.Fields.Add("Reservation2", ATCUserQueryEntityFields.Reservation2);
			this.Fields.Add("Reservation3", ATCUserQueryEntityFields.Reservation3);
			this.Fields.Add("Reservation4", ATCUserQueryEntityFields.Reservation4);
			this.Fields.Add("Reservation5", ATCUserQueryEntityFields.Reservation5);
		}
	}

	#region ATCUserQueryEntityFields

	public class ATCUserQueryEntityFields
	{
		public static EntityField UserID
		{
			get { return new EntityField("ATC_UserQuery", 0, "UserID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField PageCode
		{
			get { return new EntityField("ATC_UserQuery", 1, "PageCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField QueryField
		{
			get { return new EntityField("ATC_UserQuery", 2, "QueryField", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField QueryValue
		{
			get { return new EntityField("ATC_UserQuery", 3, "QueryValue", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_UserQuery", 4, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_UserQuery", 5, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("ATC_UserQuery", 6, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("ATC_UserQuery", 7, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("ATC_UserQuery", 8, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("ATC_UserQuery", 9, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("ATC_UserQuery", 10, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCUserQueryEntityFields2

	public enum ATCUserQueryEntityFields2
	{
		UserID,

		PageCode,

		QueryField,

		QueryValue,

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
