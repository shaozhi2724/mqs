/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BFIWarehouseEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIWarehouseEntity : EntityBase
	{
		public int WarehouseID
		{
			get { return (int)this.GetValue("WarehouseID"); } 
			set { this.SetValue("WarehouseID", value); } 
		}

		public string WarehouseCode
		{
			get { return (string)this.GetValue("WarehouseCode"); } 
			set { this.SetValue("WarehouseCode", value); } 
		}

		public string WarehouseName
		{
			get { return (string)this.GetValue("WarehouseName"); } 
			set { this.SetValue("WarehouseName", value); } 
		}

		public string WarehouseSpell
		{
			get { return (string)this.GetValue("WarehouseSpell"); } 
			set { this.SetValue("WarehouseSpell", value); } 
		}

		public string WarehousePurpose
		{
			get { return (string)this.GetValue("WarehousePurpose"); } 
			set { this.SetValue("WarehousePurpose", value); } 
		}

		public string WarehouseType
		{
			get { return (string)this.GetValue("WarehouseType"); } 
			set { this.SetValue("WarehouseType", value); } 
		}

		public string WarehousePhone
		{
			get { return (string)this.GetValue("WarehousePhone"); } 
			set { this.SetValue("WarehousePhone", value); } 
		}

		public string PostalCode
		{
			get { return (string)this.GetValue("PostalCode"); } 
			set { this.SetValue("PostalCode", value); } 
		}

		public string FaxNo
		{
			get { return (string)this.GetValue("FaxNo"); } 
			set { this.SetValue("FaxNo", value); } 
		}

		public string IsAnotherPlace
		{
			get { return (string)this.GetValue("IsAnotherPlace"); } 
			set { this.SetValue("IsAnotherPlace", value); } 
		}

		public string WarehouseAddress
		{
			get { return (string)this.GetValue("WarehouseAddress"); } 
			set { this.SetValue("WarehouseAddress", value); } 
		}

		public string WarehouseLeader
		{
			get { return (string)this.GetValue("WarehouseLeader"); } 
			set { this.SetValue("WarehouseLeader", value); } 
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

		public string FloorSpace
		{
			get { return (string)this.GetValue("FloorSpace"); } 
			set { this.SetValue("FloorSpace", value); } 
		}

		public string Volume
		{
			get { return (string)this.GetValue("Volume"); } 
			set { this.SetValue("Volume", value); } 
		}

		public int EnterpriseID
		{
			get { return (int)this.GetValue("EnterpriseID"); } 
			set { this.SetValue("EnterpriseID", value); } 
		}

		public int ParentWarehouseID
		{
			get { return (int)this.GetValue("ParentWarehouseID"); } 
			set { this.SetValue("ParentWarehouseID", value); } 
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

		public string WarehouseRemark
		{
			get { return (string)this.GetValue("WarehouseRemark"); } 
			set { this.SetValue("WarehouseRemark", value); } 
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

		public BFIWarehouseEntity()
		{
			this.TableName = "BFI_Warehouse";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("WarehouseID", BFIWarehouseEntityFields.WarehouseID);
			this.Fields.Add("WarehouseCode", BFIWarehouseEntityFields.WarehouseCode);
			this.Fields.Add("WarehouseName", BFIWarehouseEntityFields.WarehouseName);
			this.Fields.Add("WarehouseSpell", BFIWarehouseEntityFields.WarehouseSpell);
			this.Fields.Add("WarehousePurpose", BFIWarehouseEntityFields.WarehousePurpose);
			this.Fields.Add("WarehouseType", BFIWarehouseEntityFields.WarehouseType);
			this.Fields.Add("WarehousePhone", BFIWarehouseEntityFields.WarehousePhone);
			this.Fields.Add("PostalCode", BFIWarehouseEntityFields.PostalCode);
			this.Fields.Add("FaxNo", BFIWarehouseEntityFields.FaxNo);
			this.Fields.Add("IsAnotherPlace", BFIWarehouseEntityFields.IsAnotherPlace);
			this.Fields.Add("WarehouseAddress", BFIWarehouseEntityFields.WarehouseAddress);
			this.Fields.Add("WarehouseLeader", BFIWarehouseEntityFields.WarehouseLeader);
			this.Fields.Add("LeaderSpell", BFIWarehouseEntityFields.LeaderSpell);
			this.Fields.Add("LeaderPhone", BFIWarehouseEntityFields.LeaderPhone);
			this.Fields.Add("BusinessPerson", BFIWarehouseEntityFields.BusinessPerson);
			this.Fields.Add("BusinessPersonSpell", BFIWarehouseEntityFields.BusinessPersonSpell);
			this.Fields.Add("BusinessPhone", BFIWarehouseEntityFields.BusinessPhone);
			this.Fields.Add("FloorSpace", BFIWarehouseEntityFields.FloorSpace);
			this.Fields.Add("Volume", BFIWarehouseEntityFields.Volume);
			this.Fields.Add("EnterpriseID", BFIWarehouseEntityFields.EnterpriseID);
			this.Fields.Add("ParentWarehouseID", BFIWarehouseEntityFields.ParentWarehouseID);
			this.Fields.Add("CreateUserID", BFIWarehouseEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIWarehouseEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIWarehouseEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIWarehouseEntityFields.LastModifyDate);
			this.Fields.Add("WarehouseRemark", BFIWarehouseEntityFields.WarehouseRemark);
			this.Fields.Add("Reservation1", BFIWarehouseEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIWarehouseEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIWarehouseEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIWarehouseEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIWarehouseEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIWarehouseEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIWarehouseEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIWarehouseEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIWarehouseEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIWarehouseEntityFields.Reservation10);
		}
	}

	#region BFIWarehouseEntityFields

	public class BFIWarehouseEntityFields
	{
		public static EntityField WarehouseID
		{
			get { return new EntityField("BFI_Warehouse", 0, "WarehouseID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField WarehouseCode
		{
			get { return new EntityField("BFI_Warehouse", 1, "WarehouseCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField WarehouseName
		{
			get { return new EntityField("BFI_Warehouse", 2, "WarehouseName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField WarehouseSpell
		{
			get { return new EntityField("BFI_Warehouse", 3, "WarehouseSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField WarehousePurpose
		{
			get { return new EntityField("BFI_Warehouse", 4, "WarehousePurpose", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField WarehouseType
		{
			get { return new EntityField("BFI_Warehouse", 5, "WarehouseType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField WarehousePhone
		{
			get { return new EntityField("BFI_Warehouse", 6, "WarehousePhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PostalCode
		{
			get { return new EntityField("BFI_Warehouse", 7, "PostalCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FaxNo
		{
			get { return new EntityField("BFI_Warehouse", 8, "FaxNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsAnotherPlace
		{
			get { return new EntityField("BFI_Warehouse", 9, "IsAnotherPlace", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField WarehouseAddress
		{
			get { return new EntityField("BFI_Warehouse", 10, "WarehouseAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField WarehouseLeader
		{
			get { return new EntityField("BFI_Warehouse", 11, "WarehouseLeader", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LeaderSpell
		{
			get { return new EntityField("BFI_Warehouse", 12, "LeaderSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LeaderPhone
		{
			get { return new EntityField("BFI_Warehouse", 13, "LeaderPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPerson
		{
			get { return new EntityField("BFI_Warehouse", 14, "BusinessPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPersonSpell
		{
			get { return new EntityField("BFI_Warehouse", 15, "BusinessPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPhone
		{
			get { return new EntityField("BFI_Warehouse", 16, "BusinessPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FloorSpace
		{
			get { return new EntityField("BFI_Warehouse", 17, "FloorSpace", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Volume
		{
			get { return new EntityField("BFI_Warehouse", 18, "Volume", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnterpriseID
		{
            get { return new EntityField("BFI_Warehouse", 19, "EnterpriseID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ParentWarehouseID
		{
			get { return new EntityField("BFI_Warehouse", 20, "ParentWarehouseID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_Warehouse", 21, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_Warehouse", 22, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_Warehouse", 23, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_Warehouse", 24, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField WarehouseRemark
		{
			get { return new EntityField("BFI_Warehouse", 25, "WarehouseRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_Warehouse", 26, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_Warehouse", 27, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_Warehouse", 28, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_Warehouse", 29, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_Warehouse", 30, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_Warehouse", 31, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_Warehouse", 32, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_Warehouse", 33, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_Warehouse", 34, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_Warehouse", 35, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIWarehouseEntityFields2

	public enum BFIWarehouseEntityFields2
	{
		WarehouseID,

		WarehouseCode,

		WarehouseName,

		WarehouseSpell,

		WarehousePurpose,

		WarehouseType,

		WarehousePhone,

		PostalCode,

		FaxNo,

		IsAnotherPlace,

		WarehouseAddress,

		WarehouseLeader,

		LeaderSpell,

		LeaderPhone,

		BusinessPerson,

		BusinessPersonSpell,

		BusinessPhone,

		FloorSpace,

		Volume,

		EnterpriseID,

		ParentWarehouseID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		WarehouseRemark,

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
