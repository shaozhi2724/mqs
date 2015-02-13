/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: SYSDbBackupEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class SYSDbBackupEntity : EntityBase
	{
		public int BackupID
		{
			get { return (int)this.GetValue("BackupID"); } 
			set { this.SetValue("BackupID", value); } 
		}

		public string BackupUser
		{
			get { return (string)this.GetValue("BackupUser"); } 
			set { this.SetValue("BackupUser", value); } 
		}

		public DateTime BackupDate
		{
			get { return (DateTime)this.GetValue("BackupDate"); } 
			set { this.SetValue("BackupDate", value); } 
		}

		public string BackupName
		{
			get { return (string)this.GetValue("BackupName"); } 
			set { this.SetValue("BackupName", value); } 
		}

		public string BackupPath
		{
			get { return (string)this.GetValue("BackupPath"); } 
			set { this.SetValue("BackupPath", value); } 
		}

		public string BackupPC
		{
			get { return (string)this.GetValue("BackupPC"); } 
			set { this.SetValue("BackupPC", value); } 
		}

		public string BackupSize
		{
			get { return (string)this.GetValue("BackupSize"); } 
			set { this.SetValue("BackupSize", value); } 
		}

		public string RecoverName
		{
			get { return (string)this.GetValue("RecoverName"); } 
			set { this.SetValue("RecoverName", value); } 
		}

		public string BackupCause
		{
			get { return (string)this.GetValue("BackupCause"); } 
			set { this.SetValue("BackupCause", value); } 
		}

		public string BackupRemark
		{
			get { return (string)this.GetValue("BackupRemark"); } 
			set { this.SetValue("BackupRemark", value); } 
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

		public SYSDbBackupEntity()
		{
			this.TableName = "SYS_DbBackup";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("BackupID", SYSDbBackupEntityFields.BackupID);
			this.Fields.Add("BackupUser", SYSDbBackupEntityFields.BackupUser);
			this.Fields.Add("BackupDate", SYSDbBackupEntityFields.BackupDate);
			this.Fields.Add("BackupName", SYSDbBackupEntityFields.BackupName);
			this.Fields.Add("BackupPath", SYSDbBackupEntityFields.BackupPath);
			this.Fields.Add("BackupPC", SYSDbBackupEntityFields.BackupPC);
			this.Fields.Add("BackupSize", SYSDbBackupEntityFields.BackupSize);
			this.Fields.Add("RecoverName", SYSDbBackupEntityFields.RecoverName);
			this.Fields.Add("BackupCause", SYSDbBackupEntityFields.BackupCause);
			this.Fields.Add("BackupRemark", SYSDbBackupEntityFields.BackupRemark);
			this.Fields.Add("Reservation1", SYSDbBackupEntityFields.Reservation1);
			this.Fields.Add("Reservation2", SYSDbBackupEntityFields.Reservation2);
			this.Fields.Add("Reservation3", SYSDbBackupEntityFields.Reservation3);
			this.Fields.Add("Reservation4", SYSDbBackupEntityFields.Reservation4);
			this.Fields.Add("Reservation5", SYSDbBackupEntityFields.Reservation5);
		}
	}

	#region SYSDbBackupEntityFields

	public class SYSDbBackupEntityFields
	{
		public static EntityField BackupID
		{
			get { return new EntityField("SYS_DbBackup", 0, "BackupID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BackupUser
		{
			get { return new EntityField("SYS_DbBackup", 1, "BackupUser", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BackupDate
		{
			get { return new EntityField("SYS_DbBackup", 2, "BackupDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField BackupName
		{
			get { return new EntityField("SYS_DbBackup", 3, "BackupName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BackupPath
		{
			get { return new EntityField("SYS_DbBackup", 4, "BackupPath", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BackupPC
		{
			get { return new EntityField("SYS_DbBackup", 5, "BackupPC", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BackupSize
		{
			get { return new EntityField("SYS_DbBackup", 6, "BackupSize", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RecoverName
		{
			get { return new EntityField("SYS_DbBackup", 7, "RecoverName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BackupCause
		{
			get { return new EntityField("SYS_DbBackup", 8, "BackupCause", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BackupRemark
		{
			get { return new EntityField("SYS_DbBackup", 9, "BackupRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("SYS_DbBackup", 10, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("SYS_DbBackup", 11, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("SYS_DbBackup", 12, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("SYS_DbBackup", 13, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("SYS_DbBackup", 14, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region SYSDbBackupEntityFields2

	public enum SYSDbBackupEntityFields2
	{
		BackupID,

		BackupUser,

		BackupDate,

		BackupName,

		BackupPath,

		BackupPC,

		BackupSize,

		RecoverName,

		BackupCause,

		BackupRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
