/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-06-16 18:46:03
 *	Build Type: Entity
 *	Description: ATCAntiApproveQualificationDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCAntiApproveQualificationDetailEntity : EntityBase
	{
		public Guid DetailID
		{
			get { return (Guid)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
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

		public string CertificateStyle
		{
			get { return (string)this.GetValue("CertificateStyle"); } 
			set { this.SetValue("CertificateStyle", value); } 
		}

		public string CertificateNo
		{
			get { return (string)this.GetValue("CertificateNo"); } 
			set { this.SetValue("CertificateNo", value); } 
		}

		public string IssuingAuthority
		{
			get { return (string)this.GetValue("IssuingAuthority"); } 
			set { this.SetValue("IssuingAuthority", value); } 
		}

		public DateTime IssuingDate
		{
			get { return (DateTime)this.GetValue("IssuingDate"); } 
			set { this.SetValue("IssuingDate", value); } 
		}

		public DateTime ValidateDate
		{
			get { return (DateTime)this.GetValue("ValidateDate"); } 
			set { this.SetValue("ValidateDate", value); } 
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

		public string BelongTable
		{
			get { return (string)this.GetValue("BelongTable"); } 
			set { this.SetValue("BelongTable", value); } 
		}

		public string BelongFieldName
		{
			get { return (string)this.GetValue("BelongFieldName"); } 
			set { this.SetValue("BelongFieldName", value); } 
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

		public string QualificationRemark
		{
			get { return (string)this.GetValue("QualificationRemark"); } 
			set { this.SetValue("QualificationRemark", value); } 
		}

		public ATCAntiApproveQualificationDetailEntity()
		{
			this.TableName = "ATC_AntiApproveQualificationDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", ATCAntiApproveQualificationDetailEntityFields.DetailID);
			this.Fields.Add("AntiApproveID", ATCAntiApproveQualificationDetailEntityFields.AntiApproveID);
			this.Fields.Add("QualificationID", ATCAntiApproveQualificationDetailEntityFields.QualificationID);
			this.Fields.Add("QualificationCode", ATCAntiApproveQualificationDetailEntityFields.QualificationCode);
			this.Fields.Add("QualificationName", ATCAntiApproveQualificationDetailEntityFields.QualificationName);
			this.Fields.Add("CertificateStyle", ATCAntiApproveQualificationDetailEntityFields.CertificateStyle);
			this.Fields.Add("CertificateNo", ATCAntiApproveQualificationDetailEntityFields.CertificateNo);
			this.Fields.Add("IssuingAuthority", ATCAntiApproveQualificationDetailEntityFields.IssuingAuthority);
			this.Fields.Add("IssuingDate", ATCAntiApproveQualificationDetailEntityFields.IssuingDate);
			this.Fields.Add("ValidateDate", ATCAntiApproveQualificationDetailEntityFields.ValidateDate);
			this.Fields.Add("QualificationBelong", ATCAntiApproveQualificationDetailEntityFields.QualificationBelong);
			this.Fields.Add("BelongID", ATCAntiApproveQualificationDetailEntityFields.BelongID);
			this.Fields.Add("BelongTable", ATCAntiApproveQualificationDetailEntityFields.BelongTable);
			this.Fields.Add("BelongFieldName", ATCAntiApproveQualificationDetailEntityFields.BelongFieldName);
			this.Fields.Add("CreateUserID", ATCAntiApproveQualificationDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCAntiApproveQualificationDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", ATCAntiApproveQualificationDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", ATCAntiApproveQualificationDetailEntityFields.LastModifyDate);
			this.Fields.Add("QualificationRemark", ATCAntiApproveQualificationDetailEntityFields.QualificationRemark);
		}
	}

	#region ATCAntiApproveQualificationDetailEntityFields

	public class ATCAntiApproveQualificationDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 0, "DetailID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField AntiApproveID
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 1, "AntiApproveID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField QualificationID
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 2, "QualificationID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField QualificationCode
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 3, "QualificationCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField QualificationName
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 4, "QualificationName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CertificateStyle
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 5, "CertificateStyle", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CertificateNo
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 6, "CertificateNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IssuingAuthority
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 7, "IssuingAuthority", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IssuingDate
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 8, "IssuingDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 9, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField QualificationBelong
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 10, "QualificationBelong", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BelongID
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 11, "BelongID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BelongTable
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 12, "BelongTable", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BelongFieldName
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 13, "BelongFieldName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 14, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 15, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 16, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 17, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField QualificationRemark
		{
			get { return new EntityField("ATC_AntiApproveQualificationDetail", 18, "QualificationRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCAntiApproveQualificationDetailEntityFields2

	public enum ATCAntiApproveQualificationDetailEntityFields2
	{
		DetailID,

		AntiApproveID,

		QualificationID,

		QualificationCode,

		QualificationName,

		CertificateStyle,

		CertificateNo,

		IssuingAuthority,

		IssuingDate,

		ValidateDate,

		QualificationBelong,

		BelongID,

		BelongTable,

		BelongFieldName,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		QualificationRemark,

	}

	#endregion

}
