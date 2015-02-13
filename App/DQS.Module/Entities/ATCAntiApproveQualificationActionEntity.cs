/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-06-16 22:40:38
 *	Build Type: Entity
 *	Description: ATCAntiApproveQualificationActionEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCAntiApproveQualificationActionEntity : EntityBase
	{
		public Guid ActionID
		{
			get { return (Guid)this.GetValue("ActionID"); } 
			set { this.SetValue("ActionID", value); } 
		}

		public Guid AntiApproveID
		{
			get { return (Guid)this.GetValue("AntiApproveID"); } 
			set { this.SetValue("AntiApproveID", value); } 
		}

		public int QualificationID
		{
			get { return (int)this.GetValue("QualificationID"); } 
			set { this.SetValue("QualificationID", value); } 
		}

		public string QualificationCode
		{
			get { return (string)this.GetValue("QualificationCode"); } 
			set { this.SetValue("QualificationCode", value); } 
		}

		public string QualificationName
		{
			get { return (string)this.GetValue("QualificationName"); } 
			set { this.SetValue("QualificationName", value); } 
		}

		public string QualificationBelong
		{
			get { return (string)this.GetValue("QualificationBelong"); } 
			set { this.SetValue("QualificationBelong", value); } 
		}

		public int BelongID
		{
			get { return (int)this.GetValue("BelongID"); } 
			set { this.SetValue("BelongID", value); } 
		}

		public int Action
		{
			get { return (int)this.GetValue("Action"); } 
			set { this.SetValue("Action", value); } 
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

		public string ActionRemark
		{
			get { return (string)this.GetValue("ActionRemark"); } 
			set { this.SetValue("ActionRemark", value); } 
		}

		public ATCAntiApproveQualificationActionEntity()
		{
			this.TableName = "ATC_AntiApproveQualificationAction";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ActionID", ATCAntiApproveQualificationActionEntityFields.ActionID);
			this.Fields.Add("AntiApproveID", ATCAntiApproveQualificationActionEntityFields.AntiApproveID);
			this.Fields.Add("QualificationID", ATCAntiApproveQualificationActionEntityFields.QualificationID);
			this.Fields.Add("QualificationCode", ATCAntiApproveQualificationActionEntityFields.QualificationCode);
			this.Fields.Add("QualificationName", ATCAntiApproveQualificationActionEntityFields.QualificationName);
			this.Fields.Add("QualificationBelong", ATCAntiApproveQualificationActionEntityFields.QualificationBelong);
			this.Fields.Add("BelongID", ATCAntiApproveQualificationActionEntityFields.BelongID);
			this.Fields.Add("Action", ATCAntiApproveQualificationActionEntityFields.Action);
			this.Fields.Add("CreateUserID", ATCAntiApproveQualificationActionEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCAntiApproveQualificationActionEntityFields.CreateDate);
			this.Fields.Add("ActionRemark", ATCAntiApproveQualificationActionEntityFields.ActionRemark);
		}
	}

	#region ATCAntiApproveQualificationActionEntityFields

	public class ATCAntiApproveQualificationActionEntityFields
	{
		public static EntityField ActionID
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 0, "ActionID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField AntiApproveID
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 1, "AntiApproveID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField QualificationID
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 2, "QualificationID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField QualificationCode
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 3, "QualificationCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField QualificationName
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 4, "QualificationName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField QualificationBelong
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 5, "QualificationBelong", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BelongID
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 6, "BelongID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField Action
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 7, "Action", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ActionRemark
		{
			get { return new EntityField("ATC_AntiApproveQualificationAction", 10, "ActionRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCAntiApproveQualificationActionEntityFields2

	public enum ATCAntiApproveQualificationActionEntityFields2
	{
		ActionID,

		AntiApproveID,

		QualificationID,

		QualificationCode,

		QualificationName,

		QualificationBelong,

		BelongID,

		Action,

		CreateUserID,

		CreateDate,

		ActionRemark,

	}

	#endregion

}
