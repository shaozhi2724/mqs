/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-11-21 10:52:50
 *	Build Type: Entity
 *	Description: ATCApproveNotificationEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCApproveNotificationEntity : EntityBase
	{
		public int ApproveNotificationID
		{
			get { return (int)this.GetValue("ApproveNotificationID"); } 
			set { this.SetValue("ApproveNotificationID", value); } 
		}

		public string ApproveCode
		{
			get { return (string)this.GetValue("ApproveCode"); } 
			set { this.SetValue("ApproveCode", value); } 
		}

		public Guid OwnerUserID
		{
			get { return (Guid)this.GetValue("OwnerUserID"); } 
			set { this.SetValue("OwnerUserID", value); } 
		}

		public string Message
		{
			get { return (string)this.GetValue("Message"); } 
			set { this.SetValue("Message", value); } 
		}

		public Guid CreateUserID
		{
			get { return (Guid)this.GetValue("CreateUserID"); } 
			set { this.SetValue("CreateUserID", value); } 
		}

		public string CreateUserName
		{
			get { return (string)this.GetValue("CreateUserName"); } 
			set { this.SetValue("CreateUserName", value); } 
		}

		public DateTime CreateDate
		{
			get { return (DateTime)this.GetValue("CreateDate"); } 
			set { this.SetValue("CreateDate", value); } 
		}

		public bool IsRead
		{
			get { return (bool)this.GetValue("IsRead"); } 
			set { this.SetValue("IsRead", value); } 
		}

		public DateTime ReadTime
		{
			get { return (DateTime)this.GetValue("ReadTime"); } 
			set { this.SetValue("ReadTime", value); } 
		}

		public string FormClass
		{
			get { return (string)this.GetValue("FormClass"); } 
			set { this.SetValue("FormClass", value); } 
		}

		public int TargetID
		{
			get { return (int)this.GetValue("TargetID"); } 
			set { this.SetValue("TargetID", value); } 
		}

		public string TargetCode
		{
			get { return (string)this.GetValue("TargetCode"); } 
			set { this.SetValue("TargetCode", value); } 
		}

		public ATCApproveNotificationEntity()
		{
			this.TableName = "ATC_ApproveNotification";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ApproveNotificationID", ATCApproveNotificationEntityFields.ApproveNotificationID);
			this.Fields.Add("ApproveCode", ATCApproveNotificationEntityFields.ApproveCode);
			this.Fields.Add("OwnerUserID", ATCApproveNotificationEntityFields.OwnerUserID);
			this.Fields.Add("Message", ATCApproveNotificationEntityFields.Message);
			this.Fields.Add("CreateUserID", ATCApproveNotificationEntityFields.CreateUserID);
			this.Fields.Add("CreateUserName", ATCApproveNotificationEntityFields.CreateUserName);
			this.Fields.Add("CreateDate", ATCApproveNotificationEntityFields.CreateDate);
			this.Fields.Add("IsRead", ATCApproveNotificationEntityFields.IsRead);
			this.Fields.Add("ReadTime", ATCApproveNotificationEntityFields.ReadTime);
			this.Fields.Add("FormClass", ATCApproveNotificationEntityFields.FormClass);
			this.Fields.Add("TargetID", ATCApproveNotificationEntityFields.TargetID);
			this.Fields.Add("TargetCode", ATCApproveNotificationEntityFields.TargetCode);
		}
	}

	#region ATCApproveNotificationEntityFields

	public class ATCApproveNotificationEntityFields
	{
		public static EntityField ApproveNotificationID
		{
			get { return new EntityField("ATC_ApproveNotification", 0, "ApproveNotificationID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ApproveCode
		{
			get { return new EntityField("ATC_ApproveNotification", 1, "ApproveCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField OwnerUserID
		{
			get { return new EntityField("ATC_ApproveNotification", 2, "OwnerUserID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField Message
		{
			get { return new EntityField("ATC_ApproveNotification", 3, "Message", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_ApproveNotification", 4, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField CreateUserName
		{
			get { return new EntityField("ATC_ApproveNotification", 5, "CreateUserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_ApproveNotification", 6, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField IsRead
		{
			get { return new EntityField("ATC_ApproveNotification", 7, "IsRead", SqlDbType.Bit, false, false, false, false); }
		}

		public static EntityField ReadTime
		{
			get { return new EntityField("ATC_ApproveNotification", 8, "ReadTime", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField FormClass
		{
			get { return new EntityField("ATC_ApproveNotification", 9, "FormClass", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField TargetID
		{
			get { return new EntityField("ATC_ApproveNotification", 10, "TargetID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField TargetCode
		{
			get { return new EntityField("ATC_ApproveNotification", 11, "TargetCode", SqlDbType.NVarChar, false, false, false, false); }
		}

	}

	#endregion

	#region ATCApproveNotificationEntityFields2

	public enum ATCApproveNotificationEntityFields2
	{
		ApproveNotificationID,

		ApproveCode,

		OwnerUserID,

		Message,

		CreateUserID,

		CreateUserName,

		CreateDate,

		IsRead,

		ReadTime,

		FormClass,

		TargetID,

		TargetCode,

	}

	#endregion

}
