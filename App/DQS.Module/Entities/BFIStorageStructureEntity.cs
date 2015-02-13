/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-01-22 13:37:52
 *	Build Type: Entity
 *	Description: BFIStorageStructureEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIStorageStructureEntity : EntityBase
	{
		public int StructureID
		{
			get { return (int)this.GetValue("StructureID"); } 
			set { this.SetValue("StructureID", value); } 
		}

		public int WarehouseID
		{
			get { return (int)this.GetValue("WarehouseID"); } 
			set { this.SetValue("WarehouseID", value); } 
		}

		public string StructureCode
		{
			get { return (string)this.GetValue("StructureCode"); } 
			set { this.SetValue("StructureCode", value); } 
		}

		public string StructureName
		{
			get { return (string)this.GetValue("StructureName"); } 
			set { this.SetValue("StructureName", value); } 
		}

		public string StructureSpell
		{
			get { return (string)this.GetValue("StructureSpell"); } 
			set { this.SetValue("StructureSpell", value); } 
		}

		public string StructureType
		{
			get { return (string)this.GetValue("StructureType"); } 
			set { this.SetValue("StructureType", value); } 
		}

		public string StructureLocation
		{
			get { return (string)this.GetValue("StructureLocation"); } 
			set { this.SetValue("StructureLocation", value); } 
		}

		public string StructureLeader
		{
			get { return (string)this.GetValue("StructureLeader"); } 
			set { this.SetValue("StructureLeader", value); } 
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

		public string StructureSpace
		{
			get { return (string)this.GetValue("StructureSpace"); } 
			set { this.SetValue("StructureSpace", value); } 
		}

		public string StructureVolume
		{
			get { return (string)this.GetValue("StructureVolume"); } 
			set { this.SetValue("StructureVolume", value); } 
		}

		public bool IsMinStructure
		{
			get { return (bool)this.GetValue("IsMinStructure"); } 
			set { this.SetValue("IsMinStructure", value); } 
		}

		public string StructureBarCode
		{
			get { return (string)this.GetValue("StructureBarCode"); } 
			set { this.SetValue("StructureBarCode", value); } 
		}

		public string ParentStructureCode
		{
			get { return (string)this.GetValue("ParentStructureCode"); } 
			set { this.SetValue("ParentStructureCode", value); } 
		}

		public int StructureStyle
		{
			get { return (int)this.GetValue("StructureStyle"); } 
			set { this.SetValue("StructureStyle", value); } 
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

		public string StructureRemark
		{
			get { return (string)this.GetValue("StructureRemark"); } 
			set { this.SetValue("StructureRemark", value); } 
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

		public BFIStorageStructureEntity()
		{
			this.TableName = "BFI_StorageStructure";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("StructureID", BFIStorageStructureEntityFields.StructureID);
			this.Fields.Add("WarehouseID", BFIStorageStructureEntityFields.WarehouseID);
			this.Fields.Add("StructureCode", BFIStorageStructureEntityFields.StructureCode);
			this.Fields.Add("StructureName", BFIStorageStructureEntityFields.StructureName);
			this.Fields.Add("StructureSpell", BFIStorageStructureEntityFields.StructureSpell);
			this.Fields.Add("StructureType", BFIStorageStructureEntityFields.StructureType);
			this.Fields.Add("StructureLocation", BFIStorageStructureEntityFields.StructureLocation);
			this.Fields.Add("StructureLeader", BFIStorageStructureEntityFields.StructureLeader);
			this.Fields.Add("LeaderSpell", BFIStorageStructureEntityFields.LeaderSpell);
			this.Fields.Add("LeaderPhone", BFIStorageStructureEntityFields.LeaderPhone);
			this.Fields.Add("StructureSpace", BFIStorageStructureEntityFields.StructureSpace);
			this.Fields.Add("StructureVolume", BFIStorageStructureEntityFields.StructureVolume);
			this.Fields.Add("IsMinStructure", BFIStorageStructureEntityFields.IsMinStructure);
			this.Fields.Add("StructureBarCode", BFIStorageStructureEntityFields.StructureBarCode);
			this.Fields.Add("ParentStructureCode", BFIStorageStructureEntityFields.ParentStructureCode);
			this.Fields.Add("StructureStyle", BFIStorageStructureEntityFields.StructureStyle);
			this.Fields.Add("CreateUserID", BFIStorageStructureEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIStorageStructureEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIStorageStructureEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIStorageStructureEntityFields.LastModifyDate);
			this.Fields.Add("StructureRemark", BFIStorageStructureEntityFields.StructureRemark);
			this.Fields.Add("Reservation1", BFIStorageStructureEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIStorageStructureEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIStorageStructureEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIStorageStructureEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIStorageStructureEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIStorageStructureEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIStorageStructureEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIStorageStructureEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIStorageStructureEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIStorageStructureEntityFields.Reservation10);
		}
	}

	#region BFIStorageStructureEntityFields

	public class BFIStorageStructureEntityFields
	{
		public static EntityField StructureID
		{
			get { return new EntityField("BFI_StorageStructure", 0, "StructureID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField WarehouseID
		{
			get { return new EntityField("BFI_StorageStructure", 1, "WarehouseID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField StructureCode
		{
			get { return new EntityField("BFI_StorageStructure", 2, "StructureCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField StructureName
		{
			get { return new EntityField("BFI_StorageStructure", 3, "StructureName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField StructureSpell
		{
			get { return new EntityField("BFI_StorageStructure", 4, "StructureSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StructureType
		{
			get { return new EntityField("BFI_StorageStructure", 5, "StructureType", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField StructureLocation
		{
			get { return new EntityField("BFI_StorageStructure", 6, "StructureLocation", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StructureLeader
		{
			get { return new EntityField("BFI_StorageStructure", 7, "StructureLeader", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LeaderSpell
		{
			get { return new EntityField("BFI_StorageStructure", 8, "LeaderSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LeaderPhone
		{
			get { return new EntityField("BFI_StorageStructure", 9, "LeaderPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StructureSpace
		{
			get { return new EntityField("BFI_StorageStructure", 10, "StructureSpace", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StructureVolume
		{
			get { return new EntityField("BFI_StorageStructure", 11, "StructureVolume", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsMinStructure
		{
			get { return new EntityField("BFI_StorageStructure", 12, "IsMinStructure", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField StructureBarCode
		{
			get { return new EntityField("BFI_StorageStructure", 13, "StructureBarCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ParentStructureCode
		{
			get { return new EntityField("BFI_StorageStructure", 14, "ParentStructureCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StructureStyle
		{
			get { return new EntityField("BFI_StorageStructure", 15, "StructureStyle", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_StorageStructure", 16, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_StorageStructure", 17, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_StorageStructure", 18, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_StorageStructure", 19, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField StructureRemark
		{
			get { return new EntityField("BFI_StorageStructure", 20, "StructureRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_StorageStructure", 21, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_StorageStructure", 22, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_StorageStructure", 23, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_StorageStructure", 24, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_StorageStructure", 25, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_StorageStructure", 26, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_StorageStructure", 27, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_StorageStructure", 28, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_StorageStructure", 29, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_StorageStructure", 30, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIStorageStructureEntityFields2

	public enum BFIStorageStructureEntityFields2
	{
		StructureID,

		WarehouseID,

		StructureCode,

		StructureName,

		StructureSpell,

		StructureType,

		StructureLocation,

		StructureLeader,

		LeaderSpell,

		LeaderPhone,

		StructureSpace,

		StructureVolume,

		IsMinStructure,

		StructureBarCode,

		ParentStructureCode,

		StructureStyle,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		StructureRemark,

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
