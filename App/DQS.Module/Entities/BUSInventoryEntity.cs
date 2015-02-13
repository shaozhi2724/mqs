/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSInventoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSInventoryEntity : EntityBase
	{
		public int InventoryID
		{
			get { return (int)this.GetValue("InventoryID"); } 
			set { this.SetValue("InventoryID", value); } 
		}

		public string InventoryCode
		{
			get { return (string)this.GetValue("InventoryCode"); } 
			set { this.SetValue("InventoryCode", value); } 
		}

		public DateTime InventoryDate
		{
			get { return (DateTime)this.GetValue("InventoryDate"); } 
			set { this.SetValue("InventoryDate", value); } 
		}

		public string InventoryPerson
		{
			get { return (string)this.GetValue("InventoryPerson"); } 
			set { this.SetValue("InventoryPerson", value); } 
		}

		public string InventoryPersonSpell
		{
			get { return (string)this.GetValue("InventoryPersonSpell"); } 
			set { this.SetValue("InventoryPersonSpell", value); } 
		}

		public int StatusID
		{
			get { return (int)this.GetValue("StatusID"); } 
			set { this.SetValue("StatusID", value); } 
		}

		public string StatusName
		{
			get { return (string)this.GetValue("StatusName"); } 
			set { this.SetValue("StatusName", value); } 
		}

		public string StatusSpell
		{
			get { return (string)this.GetValue("StatusSpell"); } 
			set { this.SetValue("StatusSpell", value); } 
		}

		public int InventoryTypeID
		{
			get { return (int)this.GetValue("InventoryTypeID"); } 
			set { this.SetValue("InventoryTypeID", value); } 
		}

		public string InventoryTypeName
		{
			get { return (string)this.GetValue("InventoryTypeName"); } 
			set { this.SetValue("InventoryTypeName", value); } 
		}

		public string InventoryTypeSpell
		{
			get { return (string)this.GetValue("InventoryTypeSpell"); } 
			set { this.SetValue("InventoryTypeSpell", value); } 
		}

		public string InventoryArea
		{
			get { return (string)this.GetValue("InventoryArea"); } 
			set { this.SetValue("InventoryArea", value); } 
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

		public string InventoryRemark
		{
			get { return (string)this.GetValue("InventoryRemark"); } 
			set { this.SetValue("InventoryRemark", value); } 
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

		public BUSInventoryEntity()
		{
			this.TableName = "BUS_Inventory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("InventoryID", BUSInventoryEntityFields.InventoryID);
			this.Fields.Add("InventoryCode", BUSInventoryEntityFields.InventoryCode);
			this.Fields.Add("InventoryDate", BUSInventoryEntityFields.InventoryDate);
			this.Fields.Add("InventoryPerson", BUSInventoryEntityFields.InventoryPerson);
			this.Fields.Add("InventoryPersonSpell", BUSInventoryEntityFields.InventoryPersonSpell);
			this.Fields.Add("StatusID", BUSInventoryEntityFields.StatusID);
			this.Fields.Add("StatusName", BUSInventoryEntityFields.StatusName);
			this.Fields.Add("StatusSpell", BUSInventoryEntityFields.StatusSpell);
			this.Fields.Add("InventoryTypeID", BUSInventoryEntityFields.InventoryTypeID);
			this.Fields.Add("InventoryTypeName", BUSInventoryEntityFields.InventoryTypeName);
			this.Fields.Add("InventoryTypeSpell", BUSInventoryEntityFields.InventoryTypeSpell);
			this.Fields.Add("InventoryArea", BUSInventoryEntityFields.InventoryArea);
			this.Fields.Add("CreateUserID", BUSInventoryEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSInventoryEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSInventoryEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSInventoryEntityFields.LastModifyDate);
			this.Fields.Add("InventoryRemark", BUSInventoryEntityFields.InventoryRemark);
			this.Fields.Add("Reservation1", BUSInventoryEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSInventoryEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSInventoryEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSInventoryEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSInventoryEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSInventoryEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSInventoryEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSInventoryEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSInventoryEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSInventoryEntityFields.Reservation10);
		}
	}

	#region BUSInventoryEntityFields

	public class BUSInventoryEntityFields
	{
		public static EntityField InventoryID
		{
			get { return new EntityField("BUS_Inventory", 0, "InventoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField InventoryCode
		{
			get { return new EntityField("BUS_Inventory", 1, "InventoryCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField InventoryDate
		{
			get { return new EntityField("BUS_Inventory", 2, "InventoryDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField InventoryPerson
		{
			get { return new EntityField("BUS_Inventory", 3, "InventoryPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InventoryPersonSpell
		{
			get { return new EntityField("BUS_Inventory", 4, "InventoryPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StatusID
		{
			get { return new EntityField("BUS_Inventory", 5, "StatusID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StatusName
		{
			get { return new EntityField("BUS_Inventory", 6, "StatusName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StatusSpell
		{
			get { return new EntityField("BUS_Inventory", 7, "StatusSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InventoryTypeID
		{
			get { return new EntityField("BUS_Inventory", 8, "InventoryTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField InventoryTypeName
		{
			get { return new EntityField("BUS_Inventory", 9, "InventoryTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InventoryTypeSpell
		{
			get { return new EntityField("BUS_Inventory", 10, "InventoryTypeSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InventoryArea
		{
			get { return new EntityField("BUS_Inventory", 11, "InventoryArea", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_Inventory", 12, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_Inventory", 13, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_Inventory", 14, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_Inventory", 15, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField InventoryRemark
		{
			get { return new EntityField("BUS_Inventory", 16, "InventoryRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_Inventory", 17, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_Inventory", 18, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_Inventory", 19, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_Inventory", 20, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_Inventory", 21, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_Inventory", 22, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_Inventory", 23, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_Inventory", 24, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_Inventory", 25, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_Inventory", 26, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSInventoryEntityFields2

	public enum BUSInventoryEntityFields2
	{
		InventoryID,

		InventoryCode,

		InventoryDate,

		InventoryPerson,

		InventoryPersonSpell,

		StatusID,

		StatusName,

		StatusSpell,

		InventoryTypeID,

		InventoryTypeName,

		InventoryTypeSpell,

		InventoryArea,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		InventoryRemark,

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
