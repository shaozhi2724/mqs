/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BFIQualificationEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIQualificationEntity : EntityBase
	{
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

		public string QualificationSpell
		{
			get { return (string)this.GetValue("QualificationSpell"); } 
			set { this.SetValue("QualificationSpell", value); } 
		}

		public string CertificateStyle
		{
			get { return (string)this.GetValue("CertificateStyle"); } 
			set { this.SetValue("CertificateStyle", value); } 
		}

		public string CertificateSpell
		{
			get { return (string)this.GetValue("CertificateSpell"); } 
			set { this.SetValue("CertificateSpell", value); } 
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

		public string Reservation6
		{
			get { return (string)this.GetValue("Reservation6"); } 
			set { this.SetValue("Reservation6", value); } 
		}

		public string Reservation7
		{
			get { return (string)this.GetValue("Reservation7"); } 
			set { this.SetValue("Reservation7", value); } 
		}

		public string Reservation8
		{
			get { return (string)this.GetValue("Reservation8"); } 
			set { this.SetValue("Reservation8", value); } 
		}

		public string Reservation9
		{
			get { return (string)this.GetValue("Reservation9"); } 
			set { this.SetValue("Reservation9", value); } 
		}

		public string Reservation10
		{
			get { return (string)this.GetValue("Reservation10"); } 
			set { this.SetValue("Reservation10", value); } 
		}

		public BFIQualificationEntity()
		{
			this.TableName = "BFI_Qualification";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("QualificationID", BFIQualificationEntityFields.QualificationID);
			this.Fields.Add("QualificationCode", BFIQualificationEntityFields.QualificationCode);
			this.Fields.Add("QualificationName", BFIQualificationEntityFields.QualificationName);
			this.Fields.Add("QualificationSpell", BFIQualificationEntityFields.QualificationSpell);
			this.Fields.Add("CertificateStyle", BFIQualificationEntityFields.CertificateStyle);
			this.Fields.Add("CertificateSpell", BFIQualificationEntityFields.CertificateSpell);
			this.Fields.Add("CertificateNo", BFIQualificationEntityFields.CertificateNo);
			this.Fields.Add("IssuingAuthority", BFIQualificationEntityFields.IssuingAuthority);
			this.Fields.Add("IssuingDate", BFIQualificationEntityFields.IssuingDate);
			this.Fields.Add("ValidateDate", BFIQualificationEntityFields.ValidateDate);
			this.Fields.Add("QualificationBelong", BFIQualificationEntityFields.QualificationBelong);
			this.Fields.Add("BelongID", BFIQualificationEntityFields.BelongID);
			this.Fields.Add("BelongTable", BFIQualificationEntityFields.BelongTable);
			this.Fields.Add("BelongFieldName", BFIQualificationEntityFields.BelongFieldName);
			this.Fields.Add("CreateUserID", BFIQualificationEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIQualificationEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIQualificationEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIQualificationEntityFields.LastModifyDate);
			this.Fields.Add("QualificationRemark", BFIQualificationEntityFields.QualificationRemark);
			this.Fields.Add("Reservation1", BFIQualificationEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIQualificationEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIQualificationEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIQualificationEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIQualificationEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIQualificationEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIQualificationEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIQualificationEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIQualificationEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIQualificationEntityFields.Reservation10);
		}
	}

	#region BFIQualificationEntityFields

	public class BFIQualificationEntityFields
	{
		public static EntityField QualificationID
		{
			get { return new EntityField("BFI_Qualification", 0, "QualificationID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField QualificationCode
		{
			get { return new EntityField("BFI_Qualification", 1, "QualificationCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField QualificationName
		{
			get { return new EntityField("BFI_Qualification", 2, "QualificationName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField QualificationSpell
		{
			get { return new EntityField("BFI_Qualification", 3, "QualificationSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CertificateStyle
		{
			get { return new EntityField("BFI_Qualification", 4, "CertificateStyle", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CertificateSpell
		{
			get { return new EntityField("BFI_Qualification", 5, "CertificateSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CertificateNo
		{
			get { return new EntityField("BFI_Qualification", 6, "CertificateNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IssuingAuthority
		{
			get { return new EntityField("BFI_Qualification", 7, "IssuingAuthority", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IssuingDate
		{
			get { return new EntityField("BFI_Qualification", 8, "IssuingDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BFI_Qualification", 9, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField QualificationBelong
		{
			get { return new EntityField("BFI_Qualification", 10, "QualificationBelong", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BelongID
		{
			get { return new EntityField("BFI_Qualification", 11, "BelongID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BelongTable
		{
			get { return new EntityField("BFI_Qualification", 12, "BelongTable", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BelongFieldName
		{
			get { return new EntityField("BFI_Qualification", 13, "BelongFieldName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_Qualification", 14, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_Qualification", 15, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_Qualification", 16, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_Qualification", 17, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField QualificationRemark
		{
			get { return new EntityField("BFI_Qualification", 18, "QualificationRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_Qualification", 19, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_Qualification", 20, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_Qualification", 21, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_Qualification", 22, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_Qualification", 23, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_Qualification", 24, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_Qualification", 25, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_Qualification", 26, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_Qualification", 27, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_Qualification", 28, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIQualificationEntityFields2

	public enum BFIQualificationEntityFields2
	{
		QualificationID,

		QualificationCode,

		QualificationName,

		QualificationSpell,

		CertificateStyle,

		CertificateSpell,

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

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

		Reservation6,

		Reservation7,

		Reservation8,

		Reservation9,

		Reservation10,

	}

	#endregion

}
