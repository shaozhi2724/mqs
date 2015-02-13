/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-12 14:51:39
 *	Build Type: Entity
 *	Description: BFIDealerEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIDealerEntity : EntityBase
	{
		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
		}

		public string DealerCode
		{
			get { return (string)this.GetValue("DealerCode"); } 
			set { this.SetValue("DealerCode", value); } 
		}

		public string DealerName
		{
			get { return (string)this.GetValue("DealerName"); } 
			set { this.SetValue("DealerName", value); } 
		}

		public string DealerSpell
		{
			get { return (string)this.GetValue("DealerSpell"); } 
			set { this.SetValue("DealerSpell", value); } 
		}
        public string DealerArea
        {
            get { return IsNullField("DealerArea") ? string.Empty : (string)this.GetValue("DealerArea"); }
            set { this.SetValue("DealerArea", value); }
        }
		public string DealerProvince
		{
			get { return (string)this.GetValue("DealerProvince"); } 
			set { this.SetValue("DealerProvince", value); } 
		}

		public string DealerCity
		{
			get { return (string)this.GetValue("DealerCity"); } 
			set { this.SetValue("DealerCity", value); } 
		}

		public string DealerCounty
		{
			get { return (string)this.GetValue("DealerCounty"); } 
			set { this.SetValue("DealerCounty", value); } 
		}

		public string DealerAddress
		{
			get { return (string)this.GetValue("DealerAddress"); } 
			set { this.SetValue("DealerAddress", value); } 
		}

		public string DealerPhone
		{
			get { return (string)this.GetValue("DealerPhone"); } 
			set { this.SetValue("DealerPhone", value); } 
		}

		public string DealerPostalCode
		{
			get { return (string)this.GetValue("DealerPostalCode"); } 
			set { this.SetValue("DealerPostalCode", value); } 
		}

		public string DealerFaxNo
		{
			get { return (string)this.GetValue("DealerFaxNo"); } 
			set { this.SetValue("DealerFaxNo", value); } 
		}

		public string DealerMail
		{
			get { return (string)this.GetValue("DealerMail"); } 
			set { this.SetValue("DealerMail", value); } 
		}

		public string DealerWebSiteUrl
		{
			get { return (string)this.GetValue("DealerWebSiteUrl"); } 
			set { this.SetValue("DealerWebSiteUrl", value); } 
		}

		public string BusinessPerson
		{
			get { return (string)this.GetValue("BusinessPerson"); } 
			set { this.SetValue("BusinessPerson", value); } 
		}

		public string BusinessPersonSpell
		{
			get { return (string)this.GetValue("BusinessPersonSpell"); } 
			set { this.SetValue("BusinessPersonSpell", value); } 
		}

		public string BusinessPhone
		{
			get { return (string)this.GetValue("BusinessPhone"); } 
			set { this.SetValue("BusinessPhone", value); } 
		}

		public string DealerLeader
		{
			get { return (string)this.GetValue("DealerLeader"); } 
			set { this.SetValue("DealerLeader", value); } 
		}

		public string LeaderSpell
		{
			get { return (string)this.GetValue("LeaderSpell"); } 
			set { this.SetValue("LeaderSpell", value); } 
		}

		public string LeaderPhone
		{
			get { return (string)this.GetValue("LeaderPhone"); } 
			set { this.SetValue("LeaderPhone", value); } 
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

		public DateTime? RegisterData
		{
            get { return (IsNullField("RegisterData")) ? null : (DateTime?)this.GetValue("RegisterData"); }
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

		public string DealerLevel
		{
			get { return (string)this.GetValue("DealerLevel"); } 
			set { this.SetValue("DealerLevel", value); } 
		}

		public string DealerStyle
		{
			get { return IsNullField("DealerStyle") ? string.Empty : (string)this.GetValue("DealerStyle"); } 
			set { this.SetValue("DealerStyle", value); } 
		}

		public string DealerType
		{
            get { return IsNullField("DealerType") ? string.Empty : (string)this.GetValue("DealerType"); } 
			set { this.SetValue("DealerType", value); } 
		}

		public string EmployeeNum
		{
			get { return (string)this.GetValue("EmployeeNum"); } 
			set { this.SetValue("EmployeeNum", value); } 
		}

		public int ParentDealerID
		{
			get { return (int)this.GetValue("ParentDealerID"); } 
			set { this.SetValue("ParentDealerID", value); } 
		}

		public int EnterpriseID
		{
			get { return (int)this.GetValue("EnterpriseID"); } 
			set { this.SetValue("EnterpriseID", value); } 
		}

		public int BusinessStatus
		{
			get { return (int)this.GetValue("BusinessStatus"); } 
			set { this.SetValue("BusinessStatus", value); } 
		}

		public string DealerStatus
		{
			get { return (string)this.GetValue("DealerStatus"); } 
			set { this.SetValue("DealerStatus", value); } 
		}

		public int PurchasePriceListID
		{
            get
            {
                return IsNullField("PurchasePriceListID") ? 1 : (int)this.GetValue("PurchasePriceListID");
            }
            set
            {
                this.SetValue("PurchasePriceListID", value);
            } 
		}

		public int SalePriceListID
		{
            get
            {
                return IsNullField("SalePriceListID") ? 2 : (int)this.GetValue("SalePriceListID");
            }
            set
            {
                this.SetValue("SalePriceListID", value);
            } 
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

		public string DealerRemark
		{
			get { return (string)this.GetValue("DealerRemark"); } 
			set { this.SetValue("DealerRemark", value); } 
		}

		public string Reservation1
		{
            get
            {
                return IsNullField("Reservation1") ? "" : (string)this.GetValue("Reservation1");
            } 
			set { this.SetValue("Reservation1", value); } 
		}

		public string Reservation2
		{
			get { return IsNullField("Reservation2") ? "" : (string)this.GetValue("Reservation2"); } 
			set { this.SetValue("Reservation2", value); } 
		}

		public string Reservation3
		{
            get
            {
                return IsNullField("Reservation3") ? "" : (string)this.GetValue("Reservation3");
                ;
            } 
			set { this.SetValue("Reservation3", value); } 
		}

		public string Reservation4
		{
            get
            {
                return IsNullField("Reservation4") ? "" : (string)this.GetValue("Reservation4");
            } 
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

		public BFIDealerEntity()
		{
			this.TableName = "BFI_Dealer";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DealerID", BFIDealerEntityFields.DealerID);
			this.Fields.Add("DealerCode", BFIDealerEntityFields.DealerCode);
			this.Fields.Add("DealerName", BFIDealerEntityFields.DealerName);
			this.Fields.Add("DealerSpell", BFIDealerEntityFields.DealerSpell);
			this.Fields.Add("DealerArea", BFIDealerEntityFields.DealerArea);
			this.Fields.Add("DealerProvince", BFIDealerEntityFields.DealerProvince);
			this.Fields.Add("DealerCity", BFIDealerEntityFields.DealerCity);
			this.Fields.Add("DealerCounty", BFIDealerEntityFields.DealerCounty);
			this.Fields.Add("DealerAddress", BFIDealerEntityFields.DealerAddress);
			this.Fields.Add("DealerPhone", BFIDealerEntityFields.DealerPhone);
			this.Fields.Add("DealerPostalCode", BFIDealerEntityFields.DealerPostalCode);
			this.Fields.Add("DealerFaxNo", BFIDealerEntityFields.DealerFaxNo);
			this.Fields.Add("DealerMail", BFIDealerEntityFields.DealerMail);
			this.Fields.Add("DealerWebSiteUrl", BFIDealerEntityFields.DealerWebSiteUrl);
			this.Fields.Add("BusinessPerson", BFIDealerEntityFields.BusinessPerson);
			this.Fields.Add("BusinessPersonSpell", BFIDealerEntityFields.BusinessPersonSpell);
			this.Fields.Add("BusinessPhone", BFIDealerEntityFields.BusinessPhone);
			this.Fields.Add("DealerLeader", BFIDealerEntityFields.DealerLeader);
			this.Fields.Add("LeaderSpell", BFIDealerEntityFields.LeaderSpell);
			this.Fields.Add("LeaderPhone", BFIDealerEntityFields.LeaderPhone);
			this.Fields.Add("LegalPerson", BFIDealerEntityFields.LegalPerson);
			this.Fields.Add("LegalSpell", BFIDealerEntityFields.LegalSpell);
			this.Fields.Add("LegalPhone", BFIDealerEntityFields.LegalPhone);
			this.Fields.Add("OrganizationCode", BFIDealerEntityFields.OrganizationCode);
			this.Fields.Add("RegisterAddress", BFIDealerEntityFields.RegisterAddress);
			this.Fields.Add("RegisterData", BFIDealerEntityFields.RegisterData);
			this.Fields.Add("RegisterCapital", BFIDealerEntityFields.RegisterCapital);
			this.Fields.Add("RegisterLicenseNo", BFIDealerEntityFields.RegisterLicenseNo);
			this.Fields.Add("LicenseValidateDate", BFIDealerEntityFields.LicenseValidateDate);
			this.Fields.Add("RegisterTaxNo", BFIDealerEntityFields.RegisterTaxNo);
			this.Fields.Add("TaxValidateDate", BFIDealerEntityFields.TaxValidateDate);
			this.Fields.Add("AccountBankName", BFIDealerEntityFields.AccountBankName);
			this.Fields.Add("AccountNo", BFIDealerEntityFields.AccountNo);
			this.Fields.Add("AccountBankCode", BFIDealerEntityFields.AccountBankCode);
			this.Fields.Add("BusinessRange", BFIDealerEntityFields.BusinessRange);
			this.Fields.Add("IndustryStyle", BFIDealerEntityFields.IndustryStyle);
			this.Fields.Add("DealerLevel", BFIDealerEntityFields.DealerLevel);
			this.Fields.Add("DealerStyle", BFIDealerEntityFields.DealerStyle);
			this.Fields.Add("DealerType", BFIDealerEntityFields.DealerType);
			this.Fields.Add("EmployeeNum", BFIDealerEntityFields.EmployeeNum);
			this.Fields.Add("ParentDealerID", BFIDealerEntityFields.ParentDealerID);
			this.Fields.Add("EnterpriseID", BFIDealerEntityFields.EnterpriseID);
			this.Fields.Add("BusinessStatus", BFIDealerEntityFields.BusinessStatus);
			this.Fields.Add("DealerStatus", BFIDealerEntityFields.DealerStatus);
            this.Fields.Add("PurchasePriceListID", BFIDealerEntityFields.PurchasePriceListID);
            this.Fields.Add("SalePriceListID", BFIDealerEntityFields.SalePriceListID);
			this.Fields.Add("CreateUserID", BFIDealerEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIDealerEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIDealerEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIDealerEntityFields.LastModifyDate);
			this.Fields.Add("DealerRemark", BFIDealerEntityFields.DealerRemark);
			this.Fields.Add("Reservation1", BFIDealerEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIDealerEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIDealerEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIDealerEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIDealerEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIDealerEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIDealerEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIDealerEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIDealerEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIDealerEntityFields.Reservation10);
		}
	}

	#region BFIDealerEntityFields

	public class BFIDealerEntityFields
	{
		public static EntityField DealerID
		{
			get { return new EntityField("BFI_Dealer", 0, "DealerID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BFI_Dealer", 1, "DealerCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BFI_Dealer", 2, "DealerName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField DealerSpell
		{
			get { return new EntityField("BFI_Dealer", 3, "DealerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerArea
		{
            get { return new EntityField("BFI_Dealer", 4, "DealerArea", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerProvince
		{
			get { return new EntityField("BFI_Dealer", 5, "DealerProvince", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerCity
		{
			get { return new EntityField("BFI_Dealer", 6, "DealerCity", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerCounty
		{
			get { return new EntityField("BFI_Dealer", 7, "DealerCounty", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerAddress
		{
			get { return new EntityField("BFI_Dealer", 8, "DealerAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerPhone
		{
			get { return new EntityField("BFI_Dealer", 9, "DealerPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerPostalCode
		{
			get { return new EntityField("BFI_Dealer", 10, "DealerPostalCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerFaxNo
		{
			get { return new EntityField("BFI_Dealer", 11, "DealerFaxNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerMail
		{
			get { return new EntityField("BFI_Dealer", 12, "DealerMail", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerWebSiteUrl
		{
			get { return new EntityField("BFI_Dealer", 13, "DealerWebSiteUrl", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPerson
		{
			get { return new EntityField("BFI_Dealer", 14, "BusinessPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPersonSpell
		{
			get { return new EntityField("BFI_Dealer", 15, "BusinessPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPhone
		{
			get { return new EntityField("BFI_Dealer", 16, "BusinessPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerLeader
		{
			get { return new EntityField("BFI_Dealer", 17, "DealerLeader", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LeaderSpell
		{
			get { return new EntityField("BFI_Dealer", 18, "LeaderSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LeaderPhone
		{
			get { return new EntityField("BFI_Dealer", 19, "LeaderPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LegalPerson
		{
			get { return new EntityField("BFI_Dealer", 20, "LegalPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LegalSpell
		{
			get { return new EntityField("BFI_Dealer", 21, "LegalSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LegalPhone
		{
			get { return new EntityField("BFI_Dealer", 22, "LegalPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField OrganizationCode
		{
			get { return new EntityField("BFI_Dealer", 23, "OrganizationCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterAddress
		{
			get { return new EntityField("BFI_Dealer", 24, "RegisterAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterData
		{
			get { return new EntityField("BFI_Dealer", 25, "RegisterData", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField RegisterCapital
		{
			get { return new EntityField("BFI_Dealer", 26, "RegisterCapital", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterLicenseNo
		{
			get { return new EntityField("BFI_Dealer", 27, "RegisterLicenseNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LicenseValidateDate
		{
			get { return new EntityField("BFI_Dealer", 28, "LicenseValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField RegisterTaxNo
		{
			get { return new EntityField("BFI_Dealer", 29, "RegisterTaxNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TaxValidateDate
		{
			get { return new EntityField("BFI_Dealer", 30, "TaxValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField AccountBankName
		{
			get { return new EntityField("BFI_Dealer", 31, "AccountBankName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AccountNo
		{
			get { return new EntityField("BFI_Dealer", 32, "AccountNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AccountBankCode
		{
			get { return new EntityField("BFI_Dealer", 33, "AccountBankCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessRange
		{
			get { return new EntityField("BFI_Dealer", 34, "BusinessRange", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IndustryStyle
		{
			get { return new EntityField("BFI_Dealer", 35, "IndustryStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerLevel
		{
			get { return new EntityField("BFI_Dealer", 36, "DealerLevel", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerStyle
		{
			get { return new EntityField("BFI_Dealer", 37, "DealerStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerType
		{
			get { return new EntityField("BFI_Dealer", 38, "DealerType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EmployeeNum
		{
			get { return new EntityField("BFI_Dealer", 39, "EmployeeNum", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ParentDealerID
		{
			get { return new EntityField("BFI_Dealer", 40, "ParentDealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField EnterpriseID
		{
			get { return new EntityField("BFI_Dealer", 41, "EnterpriseID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BusinessStatus
		{
			get { return new EntityField("BFI_Dealer", 42, "BusinessStatus", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerStatus
		{
			get { return new EntityField("BFI_Dealer", 43, "DealerStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PurchasePriceListID
		{
            get
            {
                return new EntityField("BFI_Dealer", 44, "PurchasePriceListID", SqlDbType.Int, false, false, false, true);
            }
		}

		public static EntityField SalePriceListID
		{
            get
            {
                return new EntityField("BFI_Dealer", 45, "SalePriceListID", SqlDbType.Int, false, false, false, true);
            }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_Dealer", 46, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_Dealer", 47, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_Dealer", 48, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_Dealer", 49, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DealerRemark
		{
			get { return new EntityField("BFI_Dealer", 50, "DealerRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_Dealer", 51, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_Dealer", 52, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_Dealer", 53, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_Dealer", 54, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_Dealer", 55, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_Dealer", 56, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_Dealer", 57, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_Dealer", 58, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_Dealer", 59, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_Dealer", 60, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIDealerEntityFields2

	public enum BFIDealerEntityFields2
	{
		DealerID,

		DealerCode,

		DealerName,

		DealerSpell,

		DealerArea,

		DealerProvince,

		DealerCity,

		DealerCounty,

		DealerAddress,

		DealerPhone,

		DealerPostalCode,

		DealerFaxNo,

		DealerMail,

		DealerWebSiteUrl,

		BusinessPerson,

		BusinessPersonSpell,

		BusinessPhone,

		DealerLeader,

		LeaderSpell,

		LeaderPhone,

		LegalPerson,

		LegalSpell,

		LegalPhone,

		OrganizationCode,

		RegisterAddress,

		RegisterData,

		RegisterCapital,

		RegisterLicenseNo,

		LicenseValidateDate,

		RegisterTaxNo,

		TaxValidateDate,

		AccountBankName,

		AccountNo,

		AccountBankCode,

		BusinessRange,

		IndustryStyle,

		DealerLevel,

		DealerStyle,

		DealerType,

		EmployeeNum,

		ParentDealerID,

		EnterpriseID,

		BusinessStatus,

		DealerStatus,

		PurchasePriceListID,

		SalePriceListID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		DealerRemark,

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
