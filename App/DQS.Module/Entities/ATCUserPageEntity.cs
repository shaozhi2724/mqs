/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-12-02 14:37:00
 *	Build Type: Entity
 *	Description: ATCUserPageEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCUserPageEntity : EntityBase
	{
		public Guid UserID
		{
			get { return (Guid)this.GetValue("UserID"); } 
			set { this.SetValue("UserID", value); } 
		}

		public string DocumentCode
		{
			get { return (string)this.GetValue("DocumentCode"); } 
			set { this.SetValue("DocumentCode", value); } 
		}

		public Guid ApprovalUserID
		{
			get { return (Guid)this.GetValue("ApprovalUserID"); } 
			set { this.SetValue("ApprovalUserID", value); } 
		}

		public bool IsWhole
		{
			get { return (bool)this.GetValue("IsWhole"); } 
			set { this.SetValue("IsWhole", value); } 
		}

		public int ApprovalSort
		{
			get { return (int)this.GetValue("ApprovalSort"); } 
			set { this.SetValue("ApprovalSort", value); } 
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

		public ATCUserPageEntity()
		{
			this.TableName = "ATC_UserPage";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("UserID", ATCUserPageEntityFields.UserID);
			this.Fields.Add("DocumentCode", ATCUserPageEntityFields.DocumentCode);
			this.Fields.Add("ApprovalUserID", ATCUserPageEntityFields.ApprovalUserID);
			this.Fields.Add("IsWhole", ATCUserPageEntityFields.IsWhole);
			this.Fields.Add("ApprovalSort", ATCUserPageEntityFields.ApprovalSort);
			this.Fields.Add("CreateUserID", ATCUserPageEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCUserPageEntityFields.CreateDate);
			this.Fields.Add("Reservation1", ATCUserPageEntityFields.Reservation1);
			this.Fields.Add("Reservation2", ATCUserPageEntityFields.Reservation2);
			this.Fields.Add("Reservation3", ATCUserPageEntityFields.Reservation3);
			this.Fields.Add("Reservation4", ATCUserPageEntityFields.Reservation4);
			this.Fields.Add("Reservation5", ATCUserPageEntityFields.Reservation5);
		}
	}

	#region ATCUserPageEntityFields

	public class ATCUserPageEntityFields
	{
		public static EntityField UserID
		{
			get { return new EntityField("ATC_UserPage", 0, "UserID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField DocumentCode
		{
			get { return new EntityField("ATC_UserPage", 1, "DocumentCode", SqlDbType.NVarChar, true, false, true, false); }
		}

		public static EntityField ApprovalUserID
		{
			get { return new EntityField("ATC_UserPage", 2, "ApprovalUserID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField IsWhole
		{
			get { return new EntityField("ATC_UserPage", 3, "IsWhole", SqlDbType.Bit, false, false, false, false); }
		}

		public static EntityField ApprovalSort
		{
			get { return new EntityField("ATC_UserPage", 4, "ApprovalSort", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_UserPage", 5, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_UserPage", 6, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("ATC_UserPage", 7, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("ATC_UserPage", 8, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("ATC_UserPage", 9, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("ATC_UserPage", 10, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("ATC_UserPage", 11, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCUserPageEntityFields2

	public enum ATCUserPageEntityFields2
	{
		UserID,

		DocumentCode,

		ApprovalUserID,

		IsWhole,

		ApprovalSort,

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
