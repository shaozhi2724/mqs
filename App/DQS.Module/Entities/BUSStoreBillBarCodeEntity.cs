/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSStoreBillBarCodeEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSStoreBillBarCodeEntity : EntityBase
	{
		public int BarID
		{
			get { return (int)this.GetValue("BarID"); } 
			set { this.SetValue("BarID", value); } 
		}

		public int StoreID
		{
			get { return (int)this.GetValue("StoreID"); } 
			set { this.SetValue("StoreID", value); } 
		}

		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public string BarCode
		{
			get { return (string)this.GetValue("BarCode"); } 
			set { this.SetValue("BarCode", value); } 
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

		public BUSStoreBillBarCodeEntity()
		{
			this.TableName = "BUS_StoreBillBarCode";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("BarID", BUSStoreBillBarCodeEntityFields.BarID);
			this.Fields.Add("StoreID", BUSStoreBillBarCodeEntityFields.StoreID);
			this.Fields.Add("DetailID", BUSStoreBillBarCodeEntityFields.DetailID);
			this.Fields.Add("BarCode", BUSStoreBillBarCodeEntityFields.BarCode);
			this.Fields.Add("CreateUserID", BUSStoreBillBarCodeEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSStoreBillBarCodeEntityFields.CreateDate);
			this.Fields.Add("Reservation1", BUSStoreBillBarCodeEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSStoreBillBarCodeEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSStoreBillBarCodeEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSStoreBillBarCodeEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSStoreBillBarCodeEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSStoreBillBarCodeEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSStoreBillBarCodeEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSStoreBillBarCodeEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSStoreBillBarCodeEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSStoreBillBarCodeEntityFields.Reservation10);
		}
	}

	#region BUSStoreBillBarCodeEntityFields

	public class BUSStoreBillBarCodeEntityFields
	{
		public static EntityField BarID
		{
			get { return new EntityField("BUS_StoreBillBarCode", 0, "BarID", SqlDbType.Int, true, false, true, false); }
		}

		public static EntityField StoreID
		{
			get { return new EntityField("BUS_StoreBillBarCode", 1, "StoreID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField DetailID
		{
			get { return new EntityField("BUS_StoreBillBarCode", 2, "DetailID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BarCode
		{
			get { return new EntityField("BUS_StoreBillBarCode", 3, "BarCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_StoreBillBarCode", 4, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_StoreBillBarCode", 5, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_StoreBillBarCode", 6, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_StoreBillBarCode", 7, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_StoreBillBarCode", 8, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_StoreBillBarCode", 9, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_StoreBillBarCode", 10, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_StoreBillBarCode", 11, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_StoreBillBarCode", 12, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_StoreBillBarCode", 13, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_StoreBillBarCode", 14, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_StoreBillBarCode", 15, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSStoreBillBarCodeEntityFields2

	public enum BUSStoreBillBarCodeEntityFields2
	{
		BarID,

		StoreID,

		DetailID,

		BarCode,

		CreateUserID,

		CreateDate,

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
