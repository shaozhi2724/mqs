/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-09 11:37:07
 *	Build Type: Entity
 *	Description: BFIEnterpriseLicenseLockHistoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIEnterpriseLicenseLockHistoryEntity : EntityBase
	{
		public int EnterpriseLicenseLockHistoryID
		{
			get { return (int)this.GetValue("EnterpriseLicenseLockHistoryID"); } 
			set { this.SetValue("EnterpriseLicenseLockHistoryID", value); } 
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

		public BFIEnterpriseLicenseLockHistoryEntity()
		{
			this.TableName = "BFI_EnterpriseLicenseLockHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("EnterpriseLicenseLockHistoryID", BFIEnterpriseLicenseLockHistoryEntityFields.EnterpriseLicenseLockHistoryID);
			this.Fields.Add("OldLicenseValidateDate", BFIEnterpriseLicenseLockHistoryEntityFields.OldLicenseValidateDate);
			this.Fields.Add("NewLicenseValidateDate", BFIEnterpriseLicenseLockHistoryEntityFields.NewLicenseValidateDate);
			this.Fields.Add("LockDate", BFIEnterpriseLicenseLockHistoryEntityFields.LockDate);
			this.Fields.Add("UnLockDate", BFIEnterpriseLicenseLockHistoryEntityFields.UnLockDate);
			this.Fields.Add("ActionName", BFIEnterpriseLicenseLockHistoryEntityFields.ActionName);
			this.Fields.Add("ActionDate", BFIEnterpriseLicenseLockHistoryEntityFields.ActionDate);
			this.Fields.Add("CreateUserName", BFIEnterpriseLicenseLockHistoryEntityFields.CreateUserName);
		}
	}

	#region BFIEnterpriseLicenseLockHistoryEntityFields

	public class BFIEnterpriseLicenseLockHistoryEntityFields
	{
		public static EntityField EnterpriseLicenseLockHistoryID
		{
			get { return new EntityField("BFI_EnterpriseLicenseLockHistory", 0, "EnterpriseLicenseLockHistoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField OldLicenseValidateDate
		{
			get { return new EntityField("BFI_EnterpriseLicenseLockHistory", 1, "OldLicenseValidateDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField NewLicenseValidateDate
		{
			get { return new EntityField("BFI_EnterpriseLicenseLockHistory", 2, "NewLicenseValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LockDate
		{
			get { return new EntityField("BFI_EnterpriseLicenseLockHistory", 3, "LockDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField UnLockDate
		{
			get { return new EntityField("BFI_EnterpriseLicenseLockHistory", 4, "UnLockDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ActionName
		{
			get { return new EntityField("BFI_EnterpriseLicenseLockHistory", 5, "ActionName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ActionDate
		{
			get { return new EntityField("BFI_EnterpriseLicenseLockHistory", 6, "ActionDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField CreateUserName
		{
			get { return new EntityField("BFI_EnterpriseLicenseLockHistory", 7, "CreateUserName", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIEnterpriseLicenseLockHistoryEntityFields2

	public enum BFIEnterpriseLicenseLockHistoryEntityFields2
	{
		EnterpriseLicenseLockHistoryID,

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
