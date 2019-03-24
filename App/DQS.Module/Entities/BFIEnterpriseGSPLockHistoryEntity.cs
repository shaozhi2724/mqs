using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
    public class BFIEnterpriseGSPLockHistoryEntity : EntityBase
    {
		public int EnterpriseGSPLockHistoryID
		{
            get { return (int)this.GetValue("EnterpriseGSPLockHistoryID"); }
            set { this.SetValue("EnterpriseGSPLockHistoryID", value); } 
		}

		public DateTime OldLicenseValidateDate
		{
			get { return (DateTime)this.GetValue("OldLicenseValidateDate"); } 
			set { this.SetValue("OldLicenseValidateDate", value); } 
		}

		public DateTime NewLicenseValidateDate
		{
			get { return (DateTime)this.GetValue("NewLicenseValidateDate"); } 
			set { this.SetValue("NewLicenseValidateDate", value); } 
		}

		public DateTime LockDate
		{
			get { return (DateTime)this.GetValue("LockDate"); } 
			set { this.SetValue("LockDate", value); } 
		}

		public DateTime UnLockDate
		{
			get { return (DateTime)this.GetValue("UnLockDate"); } 
			set { this.SetValue("UnLockDate", value); } 
		}

		public string ActionName
		{
			get { return (string)this.GetValue("ActionName"); } 
			set { this.SetValue("ActionName", value); } 
		}

		public DateTime ActionDate
		{
			get { return (DateTime)this.GetValue("ActionDate"); } 
			set { this.SetValue("ActionDate", value); } 
		}

		public string CreateUserName
		{
			get { return (string)this.GetValue("CreateUserName"); } 
			set { this.SetValue("CreateUserName", value); } 
		}

		public BFIEnterpriseGSPLockHistoryEntity()
		{
            this.TableName = "BFI_EnterpriseGSPLockHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("EnterpriseGSPLockHistoryID", BFIEnterpriseGSPLockHistoryEntityFields.EnterpriseGSPLockHistoryID);
            this.Fields.Add("OldLicenseValidateDate", BFIEnterpriseGSPLockHistoryEntityFields.OldLicenseValidateDate);
            this.Fields.Add("NewLicenseValidateDate", BFIEnterpriseGSPLockHistoryEntityFields.NewLicenseValidateDate);
            this.Fields.Add("LockDate", BFIEnterpriseGSPLockHistoryEntityFields.LockDate);
            this.Fields.Add("UnLockDate", BFIEnterpriseGSPLockHistoryEntityFields.UnLockDate);
            this.Fields.Add("ActionName", BFIEnterpriseGSPLockHistoryEntityFields.ActionName);
            this.Fields.Add("ActionDate", BFIEnterpriseGSPLockHistoryEntityFields.ActionDate);
            this.Fields.Add("CreateUserName", BFIEnterpriseGSPLockHistoryEntityFields.CreateUserName);
		}
	}

	#region BFIEnterpriseGSPLockHistoryEntityFields

	public class BFIEnterpriseGSPLockHistoryEntityFields
	{
		public static EntityField EnterpriseGSPLockHistoryID
		{
			get { return new EntityField("BFI_EnterpriseGSPLockHistory", 0, "EnterpriseGSPLockHistoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField OldLicenseValidateDate
		{
			get { return new EntityField("BFI_EnterpriseGSPLockHistory", 1, "OldLicenseValidateDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField NewLicenseValidateDate
		{
			get { return new EntityField("BFI_EnterpriseGSPLockHistory", 2, "NewLicenseValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LockDate
		{
			get { return new EntityField("BFI_EnterpriseGSPLockHistory", 3, "LockDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField UnLockDate
		{
			get { return new EntityField("BFI_EnterpriseGSPLockHistory", 4, "UnLockDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ActionName
		{
			get { return new EntityField("BFI_EnterpriseGSPLockHistory", 5, "ActionName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ActionDate
		{
			get { return new EntityField("BFI_EnterpriseGSPLockHistory", 6, "ActionDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField CreateUserName
		{
			get { return new EntityField("BFI_EnterpriseGSPLockHistory", 7, "CreateUserName", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIEnterpriseGSPLockHistoryEntityFields2

	public enum BFIEnterpriseGSPLockHistoryEntityFields2
	{
		EnterpriseGSPLockHistoryID,

		OldLicenseValidateDate,

		NewLicenseValidateDate,

		LockDate,

		UnLockDate,

		ActionName,

		ActionDate,

		CreateUserName,

	}

	#endregion

}
