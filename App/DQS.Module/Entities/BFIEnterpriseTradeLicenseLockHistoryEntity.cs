/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-09-24 16:32:08
 *	Build Type: Entity
 *	Description: BFIEnterpriseTradeLicenseLockHistoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIEnterpriseTradeLicenseLockHistoryEntity : EntityBase
	{
		public int EnterpriseTradeLicenseLockHistoryID
		{
			get { return (int)this.GetValue("EnterpriseTradeLicenseLockHistoryID"); } 
			set { this.SetValue("EnterpriseTradeLicenseLockHistoryID", value); } 
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

		public BFIEnterpriseTradeLicenseLockHistoryEntity()
		{
			this.TableName = "BFI_EnterpriseTradeLicenseLockHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("EnterpriseTradeLicenseLockHistoryID", BFIEnterpriseTradeLicenseLockHistoryEntityFields.EnterpriseTradeLicenseLockHistoryID);
			this.Fields.Add("OldLicenseValidateDate", BFIEnterpriseTradeLicenseLockHistoryEntityFields.OldLicenseValidateDate);
			this.Fields.Add("NewLicenseValidateDate", BFIEnterpriseTradeLicenseLockHistoryEntityFields.NewLicenseValidateDate);
			this.Fields.Add("LockDate", BFIEnterpriseTradeLicenseLockHistoryEntityFields.LockDate);
			this.Fields.Add("UnLockDate", BFIEnterpriseTradeLicenseLockHistoryEntityFields.UnLockDate);
			this.Fields.Add("ActionName", BFIEnterpriseTradeLicenseLockHistoryEntityFields.ActionName);
			this.Fields.Add("ActionDate", BFIEnterpriseTradeLicenseLockHistoryEntityFields.ActionDate);
			this.Fields.Add("CreateUserName", BFIEnterpriseTradeLicenseLockHistoryEntityFields.CreateUserName);
		}
	}

	#region BFIEnterpriseTradeLicenseLockHistoryEntityFields

	public class BFIEnterpriseTradeLicenseLockHistoryEntityFields
	{
		public static EntityField EnterpriseTradeLicenseLockHistoryID
		{
			get { return new EntityField("BFI_EnterpriseTradeLicenseLockHistory", 0, "EnterpriseTradeLicenseLockHistoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField OldLicenseValidateDate
		{
			get { return new EntityField("BFI_EnterpriseTradeLicenseLockHistory", 1, "OldLicenseValidateDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField NewLicenseValidateDate
		{
			get { return new EntityField("BFI_EnterpriseTradeLicenseLockHistory", 2, "NewLicenseValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LockDate
		{
			get { return new EntityField("BFI_EnterpriseTradeLicenseLockHistory", 3, "LockDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField UnLockDate
		{
			get { return new EntityField("BFI_EnterpriseTradeLicenseLockHistory", 4, "UnLockDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ActionName
		{
			get { return new EntityField("BFI_EnterpriseTradeLicenseLockHistory", 5, "ActionName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ActionDate
		{
			get { return new EntityField("BFI_EnterpriseTradeLicenseLockHistory", 6, "ActionDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField CreateUserName
		{
			get { return new EntityField("BFI_EnterpriseTradeLicenseLockHistory", 7, "CreateUserName", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIEnterpriseTradeLicenseLockHistoryEntityFields2

	public enum BFIEnterpriseTradeLicenseLockHistoryEntityFields2
	{
		EnterpriseTradeLicenseLockHistoryID,

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
