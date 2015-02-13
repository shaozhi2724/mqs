/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-06-12 17:07:50
 *	Build Type: Entity
 *	Description: ATCAntiApproveEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCAntiApproveEntity : EntityBase
	{
		public Guid AntiApproveID
		{
			get { return (Guid)this.GetValue("AntiApproveID"); } 
			set { this.SetValue("AntiApproveID", value); } 
		}

		public string AntiApproveTitle
		{
			get { return (string)this.GetValue("AntiApproveTitle"); } 
			set { this.SetValue("AntiApproveTitle", value); } 
		}

		public int AntiApproveItemID
		{
			get { return (int)this.GetValue("AntiApproveItemID"); } 
			set { this.SetValue("AntiApproveItemID", value); } 
		}

		public string AntiApproveItemName
		{
			get { return (string)this.GetValue("AntiApproveItemName"); } 
			set { this.SetValue("AntiApproveItemName", value); } 
		}

		public string AntiApproveItemCode
		{
			get { return (string)this.GetValue("AntiApproveItemCode"); } 
			set { this.SetValue("AntiApproveItemCode", value); } 
		}

		public string DocumentCode
		{
			get { return (string)this.GetValue("DocumentCode"); } 
			set { this.SetValue("DocumentCode", value); } 
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

		public Guid CreateUserID
		{
			get { return (Guid)this.GetValue("CreateUserID"); } 
			set { this.SetValue("CreateUserID", value); } 
		}

		public string RequestPerson
		{
			get { return (string)this.GetValue("RequestPerson"); } 
			set { this.SetValue("RequestPerson", value); } 
		}

		public DateTime CreateDate
		{
			get { return (DateTime)this.GetValue("CreateDate"); } 
			set { this.SetValue("CreateDate", value); } 
		}

		public Guid ApproveUserID
		{
			get { return (Guid)this.GetValue("ApproveUserID"); } 
			set { this.SetValue("ApproveUserID", value); } 
		}

		public string ApprovePerson
		{
			get { return (string)this.GetValue("ApprovePerson"); } 
			set { this.SetValue("ApprovePerson", value); } 
		}

		public DateTime ApproveDate
		{
			get { return (DateTime)this.GetValue("ApproveDate"); } 
			set { this.SetValue("ApproveDate", value); } 
		}

		public ATCAntiApproveEntity()
		{
			this.TableName = "ATC_AntiApprove";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("AntiApproveID", ATCAntiApproveEntityFields.AntiApproveID);
			this.Fields.Add("AntiApproveTitle", ATCAntiApproveEntityFields.AntiApproveTitle);
			this.Fields.Add("AntiApproveItemID", ATCAntiApproveEntityFields.AntiApproveItemID);
			this.Fields.Add("AntiApproveItemName", ATCAntiApproveEntityFields.AntiApproveItemName);
			this.Fields.Add("AntiApproveItemCode", ATCAntiApproveEntityFields.AntiApproveItemCode);
			this.Fields.Add("DocumentCode", ATCAntiApproveEntityFields.DocumentCode);
			this.Fields.Add("StatusID", ATCAntiApproveEntityFields.StatusID);
			this.Fields.Add("StatusName", ATCAntiApproveEntityFields.StatusName);
			this.Fields.Add("CreateUserID", ATCAntiApproveEntityFields.CreateUserID);
			this.Fields.Add("RequestPerson", ATCAntiApproveEntityFields.RequestPerson);
			this.Fields.Add("CreateDate", ATCAntiApproveEntityFields.CreateDate);
			this.Fields.Add("ApproveUserID", ATCAntiApproveEntityFields.ApproveUserID);
			this.Fields.Add("ApprovePerson", ATCAntiApproveEntityFields.ApprovePerson);
			this.Fields.Add("ApproveDate", ATCAntiApproveEntityFields.ApproveDate);
		}
	}

	#region ATCAntiApproveEntityFields

	public class ATCAntiApproveEntityFields
	{
		public static EntityField AntiApproveID
		{
			get { return new EntityField("ATC_AntiApprove", 0, "AntiApproveID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField AntiApproveTitle
		{
			get { return new EntityField("ATC_AntiApprove", 1, "AntiApproveTitle", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField AntiApproveItemID
		{
			get { return new EntityField("ATC_AntiApprove", 2, "AntiApproveItemID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField AntiApproveItemName
		{
			get { return new EntityField("ATC_AntiApprove", 3, "AntiApproveItemName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField AntiApproveItemCode
		{
			get { return new EntityField("ATC_AntiApprove", 4, "AntiApproveItemCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField DocumentCode
		{
			get { return new EntityField("ATC_AntiApprove", 5, "DocumentCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField StatusID
		{
			get { return new EntityField("ATC_AntiApprove", 6, "StatusID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField StatusName
		{
			get { return new EntityField("ATC_AntiApprove", 7, "StatusName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_AntiApprove", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField RequestPerson
		{
			get { return new EntityField("ATC_AntiApprove", 9, "RequestPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_AntiApprove", 10, "CreateDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField ApproveUserID
		{
			get { return new EntityField("ATC_AntiApprove", 11, "ApproveUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField ApprovePerson
		{
			get { return new EntityField("ATC_AntiApprove", 12, "ApprovePerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ApproveDate
		{
			get { return new EntityField("ATC_AntiApprove", 13, "ApproveDate", SqlDbType.DateTime, false, false, false, true); }
		}

	}

	#endregion

	#region ATCAntiApproveEntityFields2

	public enum ATCAntiApproveEntityFields2
	{
		AntiApproveID,

		AntiApproveTitle,

		AntiApproveItemID,

		AntiApproveItemName,

		AntiApproveItemCode,

		DocumentCode,

		StatusID,

		StatusName,

		CreateUserID,

		RequestPerson,

		CreateDate,

		ApproveUserID,

		ApprovePerson,

		ApproveDate,

	}

	#endregion

}
