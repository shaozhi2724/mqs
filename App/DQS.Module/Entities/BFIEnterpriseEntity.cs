/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BFIEnterpriseEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIEnterpriseEntity : EntityBase
	{
		public int EnterpriseID
		{
			get { return (int)this.GetValue("EnterpriseID"); } 
			set { this.SetValue("EnterpriseID", value); } 
		}

		public string EnterpriseCode
		{
            get { return (IsNullField("EnterpriseCode")) ? null : (string)this.GetValue("EnterpriseCode"); } 
			set { this.SetValue("EnterpriseCode", value); } 
		}

		public string EnterpriseName
		{
            get { return (IsNullField("EnterpriseName")) ? null : (string)this.GetValue("EnterpriseName"); } 
			set { this.SetValue("EnterpriseName", value); } 
		}

		public string EnterpriseSpell
		{
            get { return (IsNullField("EnterpriseSpell")) ? null : (string)this.GetValue("EnterpriseSpell"); } 
			set { this.SetValue("EnterpriseSpell", value); } 
		}

		public string EnterpriseAddress
		{
            get { return (IsNullField("EnterpriseAddress")) ? null : (string)this.GetValue("EnterpriseAddress"); } 
			set { this.SetValue("EnterpriseAddress", value); } 
		}

		public string EnterprisePhone
		{
            get { return (IsNullField("EnterprisePhone")) ? null : (string)this.GetValue("EnterprisePhone"); } 
			set { this.SetValue("EnterprisePhone", value); } 
		}

		public string EnterprisePostalCode
		{
            get { return (IsNullField("EnterprisePostalCode")) ? null : (string)this.GetValue("EnterprisePostalCode"); } 
			set { this.SetValue("EnterprisePostalCode", value); } 
		}

		public string EnterpriseFaxNo
		{
            get { return (IsNullField("EnterpriseFaxNo")) ? null : (string)this.GetValue("EnterpriseFaxNo"); } 
			set { this.SetValue("EnterpriseFaxNo", value); } 
		}

		public string EnterpriseMail
		{
            get { return (IsNullField("EnterpriseMail")) ? null : (string)this.GetValue("EnterpriseMail"); } 
			set { this.SetValue("EnterpriseMail", value); } 
		}

		public string EnterpriseWebSiteUrl
		{
            get { return (IsNullField("EnterpriseWebSiteUrl")) ? null : (string)this.GetValue("EnterpriseWebSiteUrl"); } 
			set { this.SetValue("EnterpriseWebSiteUrl", value); } 
		}

		public string ContactPerson
		{
            get { return (IsNullField("ContactPerson")) ? null : (string)this.GetValue("ContactPerson"); } 
			set { this.SetValue("ContactPerson", value); } 
		}

		public string ContactPersonSpell
		{
            get { return (IsNullField("ContactPersonSpell")) ? null : (string)this.GetValue("ContactPersonSpell"); } 
			set { this.SetValue("ContactPersonSpell", value); } 
		}

		public string ContactPhone
		{
            get { return (IsNullField("ContactPhone")) ? null : (string)this.GetValue("ContactPhone"); } 
			set { this.SetValue("ContactPhone", value); } 
		}

		public string LegalPerson
		{
            get { return (IsNullField("LegalPerson")) ? null : (string)this.GetValue("LegalPerson"); } 
			set { this.SetValue("LegalPerson", value); } 
		}

		public string LegalSpell
		{
            get { return (IsNullField("LegalSpell")) ? null : (string)this.GetValue("LegalSpell"); } 
			set { this.SetValue("LegalSpell", value); } 
		}

		public string LegalPhone
		{
            get { return (IsNullField("LegalPhone")) ? null : (string)this.GetValue("LegalPhone"); } 
			set { this.SetValue("LegalPhone", value); } 
		}

		public string OrganizationCode
		{
            get { return (IsNullField("OrganizationCode")) ? null : (string)this.GetValue("OrganizationCode"); } 
			set { this.SetValue("OrganizationCode", value); } 
		}

		public string RegisterAddress
		{
            get { return (IsNullField("RegisterAddress")) ? null : (string)this.GetValue("RegisterAddress"); } 
			set { this.SetValue("RegisterAddress", value); } 
		}

		public DateTime RegisterData
		{
			get { return (DateTime)this.GetValue("RegisterData"); } 
			set { this.SetValue("RegisterData", value); } 
		}

		public string RegisterCapital
		{
            get { return (IsNullField("RegisterCapital")) ? null : (string)this.GetValue("RegisterCapital"); } 
			set { this.SetValue("RegisterCapital", value); } 
		}

		public string RegisterLicenseNo
		{
            get { return (IsNullField("RegisterLicenseNo")) ? null : (string)this.GetValue("RegisterLicenseNo"); } 
			set { this.SetValue("RegisterLicenseNo", value); } 
		}

		public DateTime LicenseValidateDate
		{
			get { return (DateTime)this.GetValue("LicenseValidateDate"); } 
			set { this.SetValue("LicenseValidateDate", value); } 
		}

        public DateTime TradeLicenseValidateDate
		{
            get { return (DateTime)this.GetValue("TradeLicenseValidateDate"); }
            set { this.SetValue("TradeLicenseValidateDate", value); } 
		}

		public string RegisterTaxNo
		{
            get { return (IsNullField("RegisterTaxNo")) ? null : (string)this.GetValue("RegisterTaxNo"); } 
			set { this.SetValue("RegisterTaxNo", value); } 
		}

		public DateTime TaxValidateDate
		{
			get { return (DateTime)this.GetValue("TaxValidateDate"); } 
			set { this.SetValue("TaxValidateDate", value); } 
		}

		public string AccountBankName
		{
            get { return (IsNullField("AccountBankName")) ? null : (string)this.GetValue("AccountBankName"); } 
			set { this.SetValue("AccountBankName", value); } 
		}

		public string AccountNo
		{
            get { return (IsNullField("AccountNo")) ? null : (string)this.GetValue("AccountNo"); } 
			set { this.SetValue("AccountNo", value); } 
		}

		public string AccountBankCode
		{
            get { return (IsNullField("AccountBankCode")) ? null : (string)this.GetValue("AccountBankCode"); } 
			set { this.SetValue("AccountBankCode", value); } 
		}

		public string BusinessRange
		{
            get { return (IsNullField("BusinessRange")) ? null : (string)this.GetValue("BusinessRange"); } 
			set { this.SetValue("BusinessRange", value); } 
		}

		public string IndustryStyle
		{
            get { return (IsNullField("IndustryStyle")) ? null : (string)this.GetValue("IndustryStyle"); } 
			set { this.SetValue("IndustryStyle", value); } 
		}

		public string EnterpriseLevel
		{
            get { return (IsNullField("EnterpriseLevel")) ? null : (string)this.GetValue("EnterpriseLevel"); } 
			set { this.SetValue("EnterpriseLevel", value); } 
		}

		public string EnterpriseStyle
		{
            get { return (IsNullField("EnterpriseStyle")) ? null : (string)this.GetValue("EnterpriseStyle"); } 
			set { this.SetValue("EnterpriseStyle", value); } 
		}

		public string EnterpriseType
		{
            get { return (IsNullField("EnterpriseType")) ? null : (string)this.GetValue("EnterpriseType"); } 
			set { this.SetValue("EnterpriseType", value); } 
		}

		public string EmployeeNum
		{
            get { return (IsNullField("EmployeeNum")) ? null : (string)this.GetValue("EmployeeNum"); } 
			set { this.SetValue("EmployeeNum", value); } 
		}

		public string ParentEnterpriseID
		{
            get { return (IsNullField("ParentEnterpriseID")) ? null : (string)this.GetValue("ParentEnterpriseID"); } 
			set { this.SetValue("ParentEnterpriseID", value); } 
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

		public string EnterpriseRemark
		{
            get { return (IsNullField("EnterpriseRemark")) ? null : (string)this.GetValue("EnterpriseRemark"); } 
			set { this.SetValue("EnterpriseRemark", value); } 
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

        public DateTime GSPValidateDate
		{
            get { return (DateTime)this.GetValue("GSPValidateDate"); }
            set { this.SetValue("GSPValidateDate", value); } 
		}

        public DateTime LicenseYearValidateDate
		{
            get { return (DateTime)this.GetValue("LicenseYearValidateDate"); }
            set { this.SetValue("LicenseYearValidateDate", value); } 
		}

		public BFIEnterpriseEntity()
		{
			this.TableName = "BFI_Enterprise";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("EnterpriseID", BFIEnterpriseEntityFields.EnterpriseID);
			this.Fields.Add("EnterpriseCode", BFIEnterpriseEntityFields.EnterpriseCode);
			this.Fields.Add("EnterpriseName", BFIEnterpriseEntityFields.EnterpriseName);
			this.Fields.Add("EnterpriseSpell", BFIEnterpriseEntityFields.EnterpriseSpell);
			this.Fields.Add("EnterpriseAddress", BFIEnterpriseEntityFields.EnterpriseAddress);
			this.Fields.Add("EnterprisePhone", BFIEnterpriseEntityFields.EnterprisePhone);
			this.Fields.Add("EnterprisePostalCode", BFIEnterpriseEntityFields.EnterprisePostalCode);
			this.Fields.Add("EnterpriseFaxNo", BFIEnterpriseEntityFields.EnterpriseFaxNo);
			this.Fields.Add("EnterpriseMail", BFIEnterpriseEntityFields.EnterpriseMail);
			this.Fields.Add("EnterpriseWebSiteUrl", BFIEnterpriseEntityFields.EnterpriseWebSiteUrl);
			this.Fields.Add("ContactPerson", BFIEnterpriseEntityFields.ContactPerson);
			this.Fields.Add("ContactPersonSpell", BFIEnterpriseEntityFields.ContactPersonSpell);
			this.Fields.Add("ContactPhone", BFIEnterpriseEntityFields.ContactPhone);
			this.Fields.Add("LegalPerson", BFIEnterpriseEntityFields.LegalPerson);
			this.Fields.Add("LegalSpell", BFIEnterpriseEntityFields.LegalSpell);
			this.Fields.Add("LegalPhone", BFIEnterpriseEntityFields.LegalPhone);
			this.Fields.Add("OrganizationCode", BFIEnterpriseEntityFields.OrganizationCode);
			this.Fields.Add("RegisterAddress", BFIEnterpriseEntityFields.RegisterAddress);
			this.Fields.Add("RegisterData", BFIEnterpriseEntityFields.RegisterData);
			this.Fields.Add("RegisterCapital", BFIEnterpriseEntityFields.RegisterCapital);
			this.Fields.Add("RegisterLicenseNo", BFIEnterpriseEntityFields.RegisterLicenseNo);
			this.Fields.Add("LicenseValidateDate", BFIEnterpriseEntityFields.LicenseValidateDate);
            this.Fields.Add("TradeLicenseValidateDate", BFIEnterpriseEntityFields.TradeLicenseValidateDate);
			this.Fields.Add("RegisterTaxNo", BFIEnterpriseEntityFields.RegisterTaxNo);
			this.Fields.Add("TaxValidateDate", BFIEnterpriseEntityFields.TaxValidateDate);
			this.Fields.Add("AccountBankName", BFIEnterpriseEntityFields.AccountBankName);
			this.Fields.Add("AccountNo", BFIEnterpriseEntityFields.AccountNo);
			this.Fields.Add("AccountBankCode", BFIEnterpriseEntityFields.AccountBankCode);
			this.Fields.Add("BusinessRange", BFIEnterpriseEntityFields.BusinessRange);
			this.Fields.Add("IndustryStyle", BFIEnterpriseEntityFields.IndustryStyle);
			this.Fields.Add("EnterpriseLevel", BFIEnterpriseEntityFields.EnterpriseLevel);
			this.Fields.Add("EnterpriseStyle", BFIEnterpriseEntityFields.EnterpriseStyle);
			this.Fields.Add("EnterpriseType", BFIEnterpriseEntityFields.EnterpriseType);
			this.Fields.Add("EmployeeNum", BFIEnterpriseEntityFields.EmployeeNum);
			this.Fields.Add("ParentEnterpriseID", BFIEnterpriseEntityFields.ParentEnterpriseID);
			this.Fields.Add("CreateUserID", BFIEnterpriseEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIEnterpriseEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIEnterpriseEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIEnterpriseEntityFields.LastModifyDate);
			this.Fields.Add("EnterpriseRemark", BFIEnterpriseEntityFields.EnterpriseRemark);
			this.Fields.Add("Reservation1", BFIEnterpriseEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIEnterpriseEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIEnterpriseEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIEnterpriseEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIEnterpriseEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIEnterpriseEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIEnterpriseEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIEnterpriseEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIEnterpriseEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIEnterpriseEntityFields.Reservation10);
            this.Fields.Add("GSPValidateDate", BFIEnterpriseEntityFields.GSPValidateDate);
            this.Fields.Add("LicenseYearValidateDate", BFIEnterpriseEntityFields.LicenseYearValidateDate);
		}
	}

	#region BFIEnterpriseEntityFields

	public class BFIEnterpriseEntityFields
	{
		public static EntityField EnterpriseID
		{
			get { return new EntityField("BFI_Enterprise", 0, "EnterpriseID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField EnterpriseCode
		{
			get { return new EntityField("BFI_Enterprise", 1, "EnterpriseCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField EnterpriseName
		{
			get { return new EntityField("BFI_Enterprise", 2, "EnterpriseName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField EnterpriseSpell
		{
			get { return new EntityField("BFI_Enterprise", 3, "EnterpriseSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseAddress
		{
			get { return new EntityField("BFI_Enterprise", 4, "EnterpriseAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterprisePhone
		{
			get { return new EntityField("BFI_Enterprise", 5, "EnterprisePhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterprisePostalCode
		{
			get { return new EntityField("BFI_Enterprise", 6, "EnterprisePostalCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseFaxNo
		{
			get { return new EntityField("BFI_Enterprise", 7, "EnterpriseFaxNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseMail
		{
			get { return new EntityField("BFI_Enterprise", 8, "EnterpriseMail", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseWebSiteUrl
		{
			get { return new EntityField("BFI_Enterprise", 9, "EnterpriseWebSiteUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContactPerson
		{
			get { return new EntityField("BFI_Enterprise", 10, "ContactPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContactPersonSpell
		{
			get { return new EntityField("BFI_Enterprise", 11, "ContactPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContactPhone
		{
			get { return new EntityField("BFI_Enterprise", 12, "ContactPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LegalPerson
		{
			get { return new EntityField("BFI_Enterprise", 13, "LegalPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LegalSpell
		{
			get { return new EntityField("BFI_Enterprise", 14, "LegalSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LegalPhone
		{
			get { return new EntityField("BFI_Enterprise", 15, "LegalPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField OrganizationCode
		{
			get { return new EntityField("BFI_Enterprise", 16, "OrganizationCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterAddress
		{
			get { return new EntityField("BFI_Enterprise", 17, "RegisterAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterData
		{
			get { return new EntityField("BFI_Enterprise", 18, "RegisterData", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField RegisterCapital
		{
			get { return new EntityField("BFI_Enterprise", 19, "RegisterCapital", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterLicenseNo
		{
			get { return new EntityField("BFI_Enterprise", 20, "RegisterLicenseNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LicenseValidateDate
		{
			get { return new EntityField("BFI_Enterprise", 21, "LicenseValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField TradeLicenseValidateDate
		{
            get { return new EntityField("BFI_Enterprise", 22, "TradeLicenseValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField RegisterTaxNo
		{
			get { return new EntityField("BFI_Enterprise", 23, "RegisterTaxNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TaxValidateDate
		{
			get { return new EntityField("BFI_Enterprise", 24, "TaxValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField AccountBankName
		{
			get { return new EntityField("BFI_Enterprise", 25, "AccountBankName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AccountNo
		{
			get { return new EntityField("BFI_Enterprise", 26, "AccountNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AccountBankCode
		{
			get { return new EntityField("BFI_Enterprise", 27, "AccountBankCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessRange
		{
			get { return new EntityField("BFI_Enterprise", 28, "BusinessRange", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IndustryStyle
		{
			get { return new EntityField("BFI_Enterprise", 29, "IndustryStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseLevel
		{
			get { return new EntityField("BFI_Enterprise", 30, "EnterpriseLevel", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseStyle
		{
			get { return new EntityField("BFI_Enterprise", 31, "EnterpriseStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseType
		{
			get { return new EntityField("BFI_Enterprise", 32, "EnterpriseType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EmployeeNum
		{
			get { return new EntityField("BFI_Enterprise", 33, "EmployeeNum", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ParentEnterpriseID
		{
			get { return new EntityField("BFI_Enterprise", 34, "ParentEnterpriseID", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_Enterprise", 35, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_Enterprise", 36, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_Enterprise", 37, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_Enterprise", 38, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField EnterpriseRemark
		{
			get { return new EntityField("BFI_Enterprise", 39, "EnterpriseRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_Enterprise", 40, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_Enterprise", 41, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_Enterprise", 42, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_Enterprise", 43, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_Enterprise", 44, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_Enterprise", 45, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_Enterprise", 46, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_Enterprise", 47, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_Enterprise", 48, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_Enterprise", 49, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField GSPValidateDate
		{
            get { return new EntityField("BFI_Enterprise", 50, "GSPValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField LicenseYearValidateDate
		{
            get { return new EntityField("BFI_Enterprise", 51, "LicenseYearValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}
	}

	#endregion

	#region BFIEnterpriseEntityFields2

	public enum BFIEnterpriseEntityFields2
	{
		EnterpriseID,

		EnterpriseCode,

		EnterpriseName,

		EnterpriseSpell,

		EnterpriseAddress,

		EnterprisePhone,

		EnterprisePostalCode,

		EnterpriseFaxNo,

		EnterpriseMail,

		EnterpriseWebSiteUrl,

		ContactPerson,

		ContactPersonSpell,

		ContactPhone,

		LegalPerson,

		LegalSpell,

		LegalPhone,

		OrganizationCode,

		RegisterAddress,

		RegisterData,

		RegisterCapital,

		RegisterLicenseNo,

		LicenseValidateDate,

        TradeLicenseValidateDate,

		RegisterTaxNo,

		TaxValidateDate,

		AccountBankName,

		AccountNo,

		AccountBankCode,

		BusinessRange,

		IndustryStyle,

		EnterpriseLevel,

		EnterpriseStyle,

		EnterpriseType,

		EmployeeNum,

		ParentEnterpriseID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		EnterpriseRemark,

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

        GSPValidateDate,

        LicenseYearValidateDate
	}

	#endregion

}
