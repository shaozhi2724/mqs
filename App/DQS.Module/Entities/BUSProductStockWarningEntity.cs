/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSProductStockWarningEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSProductStockWarningEntity : EntityBase
	{
		public int WarningID
		{
			get { return (int)this.GetValue("WarningID"); } 
			set { this.SetValue("WarningID", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public int CurrentAmount
		{
			get { return (int)this.GetValue("CurrentAmount"); } 
			set { this.SetValue("CurrentAmount", value); } 
		}

		public int StockMinAmount
		{
			get { return (int)this.GetValue("StockMinAmount"); } 
			set { this.SetValue("StockMinAmount", value); } 
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

		public string WarningRemrk
		{
			get { return (string)this.GetValue("WarningRemrk"); } 
			set { this.SetValue("WarningRemrk", value); } 
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

		public BUSProductStockWarningEntity()
		{
			this.TableName = "BUS_ProductStockWarning";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("WarningID", BUSProductStockWarningEntityFields.WarningID);
			this.Fields.Add("ProductID", BUSProductStockWarningEntityFields.ProductID);
			this.Fields.Add("CurrentAmount", BUSProductStockWarningEntityFields.CurrentAmount);
			this.Fields.Add("StockMinAmount", BUSProductStockWarningEntityFields.StockMinAmount);
			this.Fields.Add("CreateUserID", BUSProductStockWarningEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSProductStockWarningEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSProductStockWarningEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSProductStockWarningEntityFields.LastModifyDate);
			this.Fields.Add("WarningRemrk", BUSProductStockWarningEntityFields.WarningRemrk);
			this.Fields.Add("Reservation1", BUSProductStockWarningEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSProductStockWarningEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSProductStockWarningEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSProductStockWarningEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSProductStockWarningEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSProductStockWarningEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSProductStockWarningEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSProductStockWarningEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSProductStockWarningEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSProductStockWarningEntityFields.Reservation10);
		}
	}

	#region BUSProductStockWarningEntityFields

	public class BUSProductStockWarningEntityFields
	{
		public static EntityField WarningID
		{
			get { return new EntityField("BUS_ProductStockWarning", 0, "WarningID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ProductStockWarning", 1, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField CurrentAmount
		{
			get { return new EntityField("BUS_ProductStockWarning", 2, "CurrentAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StockMinAmount
		{
			get { return new EntityField("BUS_ProductStockWarning", 3, "StockMinAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ProductStockWarning", 4, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ProductStockWarning", 5, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ProductStockWarning", 6, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ProductStockWarning", 7, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField WarningRemrk
		{
			get { return new EntityField("BUS_ProductStockWarning", 8, "WarningRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ProductStockWarning", 9, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ProductStockWarning", 10, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ProductStockWarning", 11, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ProductStockWarning", 12, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ProductStockWarning", 13, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ProductStockWarning", 14, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ProductStockWarning", 15, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ProductStockWarning", 16, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ProductStockWarning", 17, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ProductStockWarning", 18, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSProductStockWarningEntityFields2

	public enum BUSProductStockWarningEntityFields2
	{
		WarningID,

		ProductID,

		CurrentAmount,

		StockMinAmount,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		WarningRemrk,

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
