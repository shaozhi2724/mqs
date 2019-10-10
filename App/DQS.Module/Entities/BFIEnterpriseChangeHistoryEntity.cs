/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-09-24 16:32:08
 *	Build Type: Entity
 *	Description: BFIEnterpriseChangeHistoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIEnterpriseChangeHistoryEntity : EntityBase
	{
		public int VersionNumber
		{
			get { return (int)this.GetValue("VersionNumber"); } 
			set { this.SetValue("VersionNumber", value); } 
		}

		public int EnterpriseID
		{
			get { return (int)this.GetValue("EnterpriseID"); } 
			set { this.SetValue("EnterpriseID", value); } 
		}

		public string EnterpriseCode
		{
			get { return (string)this.GetValue("EnterpriseCode"); } 
			set { this.SetValue("EnterpriseCode", value); } 
		}

		public string EnterpriseName
		{
			get { return (string)this.GetValue("EnterpriseName"); } 
			set { this.SetValue("EnterpriseName", value); } 
		}

		public string EnterpriseSpell
		{
			get { return (string)this.GetValue("EnterpriseSpell"); } 
			set { this.SetValue("EnterpriseSpell", value); } 
		}

		public string EnterpriseAddress
		{
			get { return (string)this.GetValue("EnterpriseAddress"); } 
			set { this.SetValue("EnterpriseAddress", value); } 
		}

		public string EnterprisePhone
		{
			get { return (string)this.GetValue("EnterprisePhone"); } 
			set { this.SetValue("EnterprisePhone", value); } 
		}

		public string EnterprisePostalCode
		{
			get { return (string)this.GetValue("EnterprisePostalCode"); } 
			set { this.SetValue("EnterprisePostalCode", value); } 
		}

		public string EnterpriseFaxNo
		{
			get { return (string)this.GetValue("EnterpriseFaxNo"); } 
			set { this.SetValue("EnterpriseFaxNo", value); } 
		}

		public string EnterpriseMail
		{
			get { return (string)this.GetValue("EnterpriseMail"); } 
			set { this.SetValue("EnterpriseMail", value); } 
		}

		public string EnterpriseWebSiteUrl
		{
			get { return (string)this.GetValue("EnterpriseWebSiteUrl"); } 
			set { this.SetValue("EnterpriseWebSiteUrl", value); } 
		}

		public string ContactPerson
		{
			get { return (string)this.GetValue("ContactPerson"); } 
			set { this.SetValue("ContactPerson", value); } 
		}

		public string ContactPersonSpell
		{
			get { return (string)this.GetValue("ContactPersonSpell"); } 
			set { this.SetValue("ContactPersonSpell", value); } 
		}

		public string ContactPhone
		{
			get { return (string)this.GetValue("ContactPhone"); } 
			set { this.SetValue("ContactPhone", value); } 
		}

		public string LegalPerson
		{
			get { return (string)this.GetValue("LegalPerson"); } 
			set { this.SetValue("LegalPerson", value); } 
		}

		public string LegalSpell
		{
			get { return (string)this.GetValue("LegalSpell"); } 
			set { this.SetValue("LegalSpell", value); } 
		}

		public string LegalPhone
		{
			get { return (string)this.GetValue("LegalPhone"); } 
			set { this.SetValue("LegalPhone", value); } 
		}

		public string OrganizationCode
		{
			get { return (string)this.GetValue("OrganizationCode"); } 
			set { this.SetValue("OrganizationCode", value); } 
		}

		public string RegisterAddress
		{
			get { return (string)this.GetValue("RegisterAddress"); } 
			set { this.SetValue("RegisterAddress", value); } 
		}

		public DateTime RegisterData
		{
			get { return (DateTime)this.GetValue("RegisterData"); } 
			set { this.SetValue("RegisterData", value); } 
		}

		public string RegisterCapital
		{
			get { return (string)this.GetValue("RegisterCapital"); } 
			set { this.SetValue("RegisterCapital", value); } 
		}

		public string RegisterLicenseNo
		{
			get { return (string)this.GetValue("RegisterLicenseNo"); } 
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
			get { return (string)this.GetValue("RegisterTaxNo"); } 
			set { this.SetValue("RegisterTaxNo", value); } 
		}

		public DateTime TaxValidateDate
		{
			get { return (DateTime)this.GetValue("TaxValidateDate"); } 
			set { this.SetValue("TaxValidateDate", value); } 
		}

		public string AccountBankName
		{
			get { return (string)this.GetValue("AccountBankName"); } 
			set { this.SetValue("AccountBankName", value); } 
		}

		public string AccountNo
		{
			get { return (string)this.GetValue("AccountNo"); } 
			set { this.SetValue("AccountNo", value); } 
		}

		public string AccountBankCode
		{
			get { return (string)this.GetValue("AccountBankCode"); } 
			set { this.SetValue("AccountBankCode", value); } 
		}

		public string BusinessRange
		{
			get { return (string)this.GetValue("BusinessRange"); } 
			set { this.SetValue("BusinessRange", value); } 
		}

		public string IndustryStyle
		{
			get { return (string)this.GetValue("IndustryStyle"); } 
			set { this.SetValue("IndustryStyle", value); } 
		}

		public string EnterpriseLevel
		{
			get { return (string)this.GetValue("EnterpriseLevel"); } 
			set { this.SetValue("EnterpriseLevel", value); } 
		}

		public string EnterpriseStyle
		{
			get { return (string)this.GetValue("EnterpriseStyle"); } 
			set { this.SetValue("EnterpriseStyle", value); } 
		}

		public string EnterpriseType
		{
			get { return (string)this.GetValue("EnterpriseType"); } 
			set { this.SetValue("EnterpriseType", value); } 
		}

		public string EmployeeNum
		{
			get { return (string)this.GetValue("EmployeeNum"); } 
			set { this.SetValue("EmployeeNum", value); } 
		}

		public string ParentEnterpriseID
		{
			get { return (string)this.GetValue("ParentEnterpriseID"); } 
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
			get { return (string)this.GetValue("EnterpriseRemark"); } 
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

		public string ChangeUserName
		{
			get { return (string)this.GetValue("ChangeUserName"); } 
			set { this.SetValue("ChangeUserName", value); } 
		}

		public DateTime ChangeDate
		{
			get { return (DateTime)this.GetValue("ChangeDate"); } 
			set { this.SetValue("ChangeDate", value); }
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

		public BFIEnterpriseChangeHistoryEntity()
		{
			this.TableName = "BFI_EnterpriseChangeHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("VersionNumber", BFIEnterpriseChangeHistoryEntityFields.VersionNumber);
			this.Fields.Add("EnterpriseID", BFIEnterpriseChangeHistoryEntityFields.EnterpriseID);
			this.Fields.Add("EnterpriseCode", BFIEnterpriseChangeHistoryEntityFields.EnterpriseCode);
			this.Fields.Add("EnterpriseName", BFIEnterpriseChangeHistoryEntityFields.EnterpriseName);
			this.Fields.Add("EnterpriseSpell", BFIEnterpriseChangeHistoryEntityFields.EnterpriseSpell);
			this.Fields.Add("EnterpriseAddress", BFIEnterpriseChangeHistoryEntityFields.EnterpriseAddress);
			this.Fields.Add("EnterprisePhone", BFIEnterpriseChangeHistoryEntityFields.EnterprisePhone);
			this.Fields.Add("EnterprisePostalCode", BFIEnterpriseChangeHistoryEntityFields.EnterprisePostalCode);
			this.Fields.Add("EnterpriseFaxNo", BFIEnterpriseChangeHistoryEntityFields.EnterpriseFaxNo);
			this.Fields.Add("EnterpriseMail", BFIEnterpriseChangeHistoryEntityFields.EnterpriseMail);
			this.Fields.Add("EnterpriseWebSiteUrl", BFIEnterpriseChangeHistoryEntityFields.EnterpriseWebSiteUrl);
			this.Fields.Add("ContactPerson", BFIEnterpriseChangeHistoryEntityFields.ContactPerson);
			this.Fields.Add("ContactPersonSpell", BFIEnterpriseChangeHistoryEntityFields.ContactPersonSpell);
			this.Fields.Add("ContactPhone", BFIEnterpriseChangeHistoryEntityFields.ContactPhone);
			this.Fields.Add("LegalPerson", BFIEnterpriseChangeHistoryEntityFields.LegalPerson);
			this.Fields.Add("LegalSpell", BFIEnterpriseChangeHistoryEntityFields.LegalSpell);
			this.Fields.Add("LegalPhone", BFIEnterpriseChangeHistoryEntityFields.LegalPhone);
			this.Fields.Add("OrganizationCode", BFIEnterpriseChangeHistoryEntityFields.OrganizationCode);
			this.Fields.Add("RegisterAddress", BFIEnterpriseChangeHistoryEntityFields.RegisterAddress);
			this.Fields.Add("RegisterData", BFIEnterpriseChangeHistoryEntityFields.RegisterData);
			this.Fields.Add("RegisterCapital", BFIEnterpriseChangeHistoryEntityFields.RegisterCapital);
			this.Fields.Add("RegisterLicenseNo", BFIEnterpriseChangeHistoryEntityFields.RegisterLicenseNo);
			this.Fields.Add("LicenseValidateDate", BFIEnterpriseChangeHistoryEntityFields.LicenseValidateDate);
			this.Fields.Add("TradeLicenseValidateDate", BFIEnterpriseChangeHistoryEntityFields.TradeLicenseValidateDate);
			this.Fields.Add("RegisterTaxNo", BFIEnterpriseChangeHistoryEntityFields.RegisterTaxNo);
			this.Fields.Add("TaxValidateDate", BFIEnterpriseChangeHistoryEntityFields.TaxValidateDate);
			this.Fields.Add("AccountBankName", BFIEnterpriseChangeHistoryEntityFields.AccountBankName);
			this.Fields.Add("AccountNo", BFIEnterpriseChangeHistoryEntityFields.AccountNo);
			this.Fields.Add("AccountBankCode", BFIEnterpriseChangeHistoryEntityFields.AccountBankCode);
			this.Fields.Add("BusinessRange", BFIEnterpriseChangeHistoryEntityFields.BusinessRange);
			this.Fields.Add("IndustryStyle", BFIEnterpriseChangeHistoryEntityFields.IndustryStyle);
			this.Fields.Add("EnterpriseLevel", BFIEnterpriseChangeHistoryEntityFields.EnterpriseLevel);
			this.Fields.Add("EnterpriseStyle", BFIEnterpriseChangeHistoryEntityFields.EnterpriseStyle);
			this.Fields.Add("EnterpriseType", BFIEnterpriseChangeHistoryEntityFields.EnterpriseType);
			this.Fields.Add("EmployeeNum", BFIEnterpriseChangeHistoryEntityFields.EmployeeNum);
			this.Fields.Add("ParentEnterpriseID", BFIEnterpriseChangeHistoryEntityFields.ParentEnterpriseID);
			this.Fields.Add("CreateUserID", BFIEnterpriseChangeHistoryEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIEnterpriseChangeHistoryEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIEnterpriseChangeHistoryEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIEnterpriseChangeHistoryEntityFields.LastModifyDate);
			this.Fields.Add("EnterpriseRemark", BFIEnterpriseChangeHistoryEntityFields.EnterpriseRemark);
			this.Fields.Add("Reservation1", BFIEnterpriseChangeHistoryEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIEnterpriseChangeHistoryEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIEnterpriseChangeHistoryEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIEnterpriseChangeHistoryEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIEnterpriseChangeHistoryEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIEnterpriseChangeHistoryEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIEnterpriseChangeHistoryEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIEnterpriseChangeHistoryEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIEnterpriseChangeHistoryEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIEnterpriseChangeHistoryEntityFields.Reservation10);
			this.Fields.Add("ChangeUserName", BFIEnterpriseChangeHistoryEntityFields.ChangeUserName);
            this.Fields.Add("ChangeDate", BFIEnterpriseChangeHistoryEntityFields.ChangeDate);
            this.Fields.Add("GSPValidateDate", BFIEnterpriseChangeHistoryEntityFields.GSPValidateDate);
            this.Fields.Add("LicenseYearValidateDate", BFIEnterpriseChangeHistoryEntityFields.LicenseYearValidateDate);
		}
	}

	#region BFIEnterpriseChangeHistoryEntityFields

	public class BFIEnterpriseChangeHistoryEntityFields
	{
		public static EntityField VersionNumber
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 0, "VersionNumber", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField EnterpriseID
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 1, "EnterpriseID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField EnterpriseCode
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 2, "EnterpriseCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField EnterpriseName
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 3, "EnterpriseName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField EnterpriseSpell
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 4, "EnterpriseSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseAddress
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 5, "EnterpriseAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterprisePhone
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 6, "EnterprisePhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterprisePostalCode
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 7, "EnterprisePostalCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseFaxNo
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 8, "EnterpriseFaxNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseMail
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 9, "EnterpriseMail", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseWebSiteUrl
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 10, "EnterpriseWebSiteUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContactPerson
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 11, "ContactPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContactPersonSpell
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 12, "ContactPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContactPhone
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 13, "ContactPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LegalPerson
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 14, "LegalPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LegalSpell
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 15, "LegalSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LegalPhone
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 16, "LegalPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField OrganizationCode
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 17, "OrganizationCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterAddress
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 18, "RegisterAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterData
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 19, "RegisterData", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField RegisterCapital
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 20, "RegisterCapital", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterLicenseNo
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 21, "RegisterLicenseNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LicenseValidateDate
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 22, "LicenseValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField TradeLicenseValidateDate
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 23, "TradeLicenseValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField RegisterTaxNo
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 24, "RegisterTaxNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TaxValidateDate
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 25, "TaxValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField AccountBankName
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 26, "AccountBankName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AccountNo
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 27, "AccountNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AccountBankCode
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 28, "AccountBankCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessRange
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 29, "BusinessRange", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IndustryStyle
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 30, "IndustryStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseLevel
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 31, "EnterpriseLevel", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseStyle
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 32, "EnterpriseStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseType
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 33, "EnterpriseType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EmployeeNum
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 34, "EmployeeNum", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ParentEnterpriseID
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 35, "ParentEnterpriseID", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 36, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 37, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 38, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 39, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField EnterpriseRemark
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 40, "EnterpriseRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 41, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 42, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 43, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 44, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 45, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 46, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 47, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 48, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 49, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 50, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ChangeUserName
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 51, "ChangeUserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ChangeDate
		{
			get { return new EntityField("BFI_EnterpriseChangeHistory", 52, "ChangeDate", SqlDbType.DateTime, false, false, false, false); }
        }

        public static EntityField GSPValidateDate
        {
            get { return new EntityField("BFI_EnterpriseChangeHistory", 53, "GSPValidateDate", SqlDbType.DateTime, false, false, false, true); }
        }

        public static EntityField LicenseYearValidateDate
        {
            get { return new EntityField("BFI_EnterpriseChangeHistory", 54, "LicenseYearValidateDate", SqlDbType.DateTime, false, false, false, true); }
        }

	}

	#endregion

	#region BFIEnterpriseChangeHistoryEntityFields2

	public enum BFIEnterpriseChangeHistoryEntityFields2
	{
		VersionNumber,

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

		ChangeUserName,

		ChangeDate,

        GSPValidateDate,

        LicenseYearValidateDate

	}

	#endregion

}
