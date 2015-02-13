/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-05-03 19:03:28
 *	Build Type: Entity
 *	Description: BUSStoreBillEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSStoreBillEntity : EntityBase
	{
		public int StoreID
		{
			get { return (int)this.GetValue("StoreID"); } 
			set { this.SetValue("StoreID", value); } 
		}

		public string StoreCode
		{
			get { return (string)this.GetValue("StoreCode"); } 
			set { this.SetValue("StoreCode", value); } 
		}

		public DateTime StoreDate
		{
			get { return (DateTime)this.GetValue("StoreDate"); } 
			set { this.SetValue("StoreDate", value); } 
		}

		public bool IsBillIn
		{
			get { return (bool)this.GetValue("IsBillIn"); } 
			set { this.SetValue("IsBillIn", value); } 
		}

		public string BillStyle
		{
			get { return (string)this.GetValue("BillStyle"); } 
			set { this.SetValue("BillStyle", value); } 
		}

		public int StoreTypeID
		{
			get { return (int)this.GetValue("StoreTypeID"); } 
			set { this.SetValue("StoreTypeID", value); } 
		}

		public string StoreTypeName
		{
			get { return (string)this.GetValue("StoreTypeName"); } 
			set { this.SetValue("StoreTypeName", value); } 
		}

		public string StoreTypeSpell
		{
			get { return (string)this.GetValue("StoreTypeSpell"); } 
			set { this.SetValue("StoreTypeSpell", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
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

		public string StoreKeeper
		{
			get { return (string)this.GetValue("StoreKeeper"); } 
			set { this.SetValue("StoreKeeper", value); } 
		}

		public string StoreKeeperSpell
		{
			get { return (string)this.GetValue("StoreKeeperSpell"); } 
			set { this.SetValue("StoreKeeperSpell", value); } 
		}

		public int PurchaseBillID
		{
			get { return (int)this.GetValue("PurchaseBillID"); } 
			set { this.SetValue("PurchaseBillID", value); } 
		}

		public string PurchaseBillCode
		{
			get { return (string)this.GetValue("PurchaseBillCode"); } 
			set { this.SetValue("PurchaseBillCode", value); } 
		}

		public int ReceiveID
		{
			get { return (int)this.GetValue("ReceiveID"); } 
			set { this.SetValue("ReceiveID", value); } 
		}

		public string ReceiveCode
		{
			get { return (string)this.GetValue("ReceiveCode"); } 
			set { this.SetValue("ReceiveCode", value); } 
		}

		public int AcceptID
		{
			get { return (int)this.GetValue("AcceptID"); } 
			set { this.SetValue("AcceptID", value); } 
		}

		public string AcceptCode
		{
			get { return (string)this.GetValue("AcceptCode"); } 
			set { this.SetValue("AcceptCode", value); } 
		}

		public int SaleBillID
		{
			get { return (int)this.GetValue("SaleBillID"); } 
			set { this.SetValue("SaleBillID", value); } 
		}

		public string SaleBillCode
		{
			get { return (string)this.GetValue("SaleBillCode"); } 
			set { this.SetValue("SaleBillCode", value); } 
		}

		public int ReviewID
		{
			get { return (int)this.GetValue("ReviewID"); } 
			set { this.SetValue("ReviewID", value); } 
		}

		public string ReviewCode
		{
			get { return (string)this.GetValue("ReviewCode"); } 
			set { this.SetValue("ReviewCode", value); } 
		}

		public string Operator
		{
			get { return (string)this.GetValue("Operator"); } 
			set { this.SetValue("Operator", value); } 
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

		public string StoreRemark
		{
			get { return (string)this.GetValue("StoreRemark"); } 
			set { this.SetValue("StoreRemark", value); } 
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

		public BUSStoreBillEntity()
		{
			this.TableName = "BUS_StoreBill";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("StoreID", BUSStoreBillEntityFields.StoreID);
			this.Fields.Add("StoreCode", BUSStoreBillEntityFields.StoreCode);
			this.Fields.Add("StoreDate", BUSStoreBillEntityFields.StoreDate);
			this.Fields.Add("IsBillIn", BUSStoreBillEntityFields.IsBillIn);
			this.Fields.Add("BillStyle", BUSStoreBillEntityFields.BillStyle);
			this.Fields.Add("StoreTypeID", BUSStoreBillEntityFields.StoreTypeID);
			this.Fields.Add("StoreTypeName", BUSStoreBillEntityFields.StoreTypeName);
			this.Fields.Add("StoreTypeSpell", BUSStoreBillEntityFields.StoreTypeSpell);
			this.Fields.Add("DealerID", BUSStoreBillEntityFields.DealerID);
			this.Fields.Add("DealerName", BUSStoreBillEntityFields.DealerName);
			this.Fields.Add("DealerSpell", BUSStoreBillEntityFields.DealerSpell);
			this.Fields.Add("StoreKeeper", BUSStoreBillEntityFields.StoreKeeper);
			this.Fields.Add("StoreKeeperSpell", BUSStoreBillEntityFields.StoreKeeperSpell);
			this.Fields.Add("PurchaseBillID", BUSStoreBillEntityFields.PurchaseBillID);
			this.Fields.Add("PurchaseBillCode", BUSStoreBillEntityFields.PurchaseBillCode);
			this.Fields.Add("ReceiveID", BUSStoreBillEntityFields.ReceiveID);
			this.Fields.Add("ReceiveCode", BUSStoreBillEntityFields.ReceiveCode);
			this.Fields.Add("AcceptID", BUSStoreBillEntityFields.AcceptID);
			this.Fields.Add("AcceptCode", BUSStoreBillEntityFields.AcceptCode);
			this.Fields.Add("SaleBillID", BUSStoreBillEntityFields.SaleBillID);
			this.Fields.Add("SaleBillCode", BUSStoreBillEntityFields.SaleBillCode);
			this.Fields.Add("ReviewID", BUSStoreBillEntityFields.ReviewID);
			this.Fields.Add("ReviewCode", BUSStoreBillEntityFields.ReviewCode);
			this.Fields.Add("Operator", BUSStoreBillEntityFields.Operator);
			this.Fields.Add("CreateUserID", BUSStoreBillEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSStoreBillEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSStoreBillEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSStoreBillEntityFields.LastModifyDate);
			this.Fields.Add("StoreRemark", BUSStoreBillEntityFields.StoreRemark);
			this.Fields.Add("Reservation1", BUSStoreBillEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSStoreBillEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSStoreBillEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSStoreBillEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSStoreBillEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSStoreBillEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSStoreBillEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSStoreBillEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSStoreBillEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSStoreBillEntityFields.Reservation10);
		}
	}

	#region BUSStoreBillEntityFields

	public class BUSStoreBillEntityFields
	{
		public static EntityField StoreID
		{
			get { return new EntityField("BUS_StoreBill", 0, "StoreID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField StoreCode
		{
			get { return new EntityField("BUS_StoreBill", 1, "StoreCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField StoreDate
		{
			get { return new EntityField("BUS_StoreBill", 2, "StoreDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField IsBillIn
		{
			get { return new EntityField("BUS_StoreBill", 3, "IsBillIn", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField BillStyle
		{
			get { return new EntityField("BUS_StoreBill", 4, "BillStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreTypeID
		{
			get { return new EntityField("BUS_StoreBill", 5, "StoreTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StoreTypeName
		{
			get { return new EntityField("BUS_StoreBill", 6, "StoreTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreTypeSpell
		{
			get { return new EntityField("BUS_StoreBill", 7, "StoreTypeSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_StoreBill", 8, "DealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_StoreBill", 9, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerSpell
		{
			get { return new EntityField("BUS_StoreBill", 10, "DealerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreKeeper
		{
			get { return new EntityField("BUS_StoreBill", 11, "StoreKeeper", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreKeeperSpell
		{
			get { return new EntityField("BUS_StoreBill", 12, "StoreKeeperSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PurchaseBillID
		{
			get { return new EntityField("BUS_StoreBill", 13, "PurchaseBillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PurchaseBillCode
		{
			get { return new EntityField("BUS_StoreBill", 14, "PurchaseBillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReceiveID
		{
			get { return new EntityField("BUS_StoreBill", 15, "ReceiveID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReceiveCode
		{
			get { return new EntityField("BUS_StoreBill", 16, "ReceiveCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AcceptID
		{
			get { return new EntityField("BUS_StoreBill", 17, "AcceptID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField AcceptCode
		{
			get { return new EntityField("BUS_StoreBill", 18, "AcceptCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SaleBillID
		{
			get { return new EntityField("BUS_StoreBill", 19, "SaleBillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField SaleBillCode
		{
			get { return new EntityField("BUS_StoreBill", 20, "SaleBillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReviewID
		{
			get { return new EntityField("BUS_StoreBill", 21, "ReviewID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReviewCode
		{
			get { return new EntityField("BUS_StoreBill", 22, "ReviewCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Operator
		{
			get { return new EntityField("BUS_StoreBill", 23, "Operator", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_StoreBill", 24, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_StoreBill", 25, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_StoreBill", 26, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_StoreBill", 27, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField StoreRemark
		{
			get { return new EntityField("BUS_StoreBill", 28, "StoreRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_StoreBill", 29, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_StoreBill", 30, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_StoreBill", 31, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_StoreBill", 32, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_StoreBill", 33, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_StoreBill", 34, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_StoreBill", 35, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_StoreBill", 36, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_StoreBill", 37, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_StoreBill", 38, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSStoreBillEntityFields2

	public enum BUSStoreBillEntityFields2
	{
		StoreID,

		StoreCode,

		StoreDate,

		IsBillIn,

		BillStyle,

		StoreTypeID,

		StoreTypeName,

		StoreTypeSpell,

		DealerID,

		DealerName,

		DealerSpell,

		StoreKeeper,

		StoreKeeperSpell,

		PurchaseBillID,

		PurchaseBillCode,

		ReceiveID,

		ReceiveCode,

		AcceptID,

		AcceptCode,

		SaleBillID,

		SaleBillCode,

		ReviewID,

		ReviewCode,

		Operator,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		StoreRemark,

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
