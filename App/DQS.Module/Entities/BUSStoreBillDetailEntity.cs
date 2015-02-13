/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-08 16:23:34
 *	Build Type: Entity
 *	Description: BUSStoreBillDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSStoreBillDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int StoreID
		{
			get { return (int)this.GetValue("StoreID"); } 
			set { this.SetValue("StoreID", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string BatchNo
		{
			get { return (string)this.GetValue("BatchNo"); } 
			set { this.SetValue("BatchNo", value); } 
		}

		public DateTime ProduceDate
		{
			get { return (DateTime)this.GetValue("ProduceDate"); } 
			set { this.SetValue("ProduceDate", value); } 
		}

		public DateTime ValidateDate
		{
			get { return (DateTime)this.GetValue("ValidateDate"); } 
			set { this.SetValue("ValidateDate", value); } 
		}

		public int BillAmount
		{
			get { return (int)this.GetValue("BillAmount"); } 
			set { this.SetValue("BillAmount", value); } 
		}

		public int QualifiedAmount
		{
			get { return (int)this.GetValue("QualifiedAmount"); } 
			set { this.SetValue("QualifiedAmount", value); } 
		}

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
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

        public int StoreAmount
        {
            get { return (int)this.GetValue("StoreAmount"); }
            set { this.SetValue("StoreAmount", value); }
        }

		public string DetailRemark
		{
			get { return (string)this.GetValue("DetailRemark"); } 
			set { this.SetValue("DetailRemark", value); } 
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

		public BUSStoreBillDetailEntity()
		{
			this.TableName = "BUS_StoreBillDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSStoreBillDetailEntityFields.DetailID);
			this.Fields.Add("StoreID", BUSStoreBillDetailEntityFields.StoreID);
			this.Fields.Add("ProductID", BUSStoreBillDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSStoreBillDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSStoreBillDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSStoreBillDetailEntityFields.ValidateDate);
			this.Fields.Add("BillAmount", BUSStoreBillDetailEntityFields.BillAmount);
			this.Fields.Add("QualifiedAmount", BUSStoreBillDetailEntityFields.QualifiedAmount);
			this.Fields.Add("Amount", BUSStoreBillDetailEntityFields.Amount);
			this.Fields.Add("CreateUserID", BUSStoreBillDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSStoreBillDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSStoreBillDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSStoreBillDetailEntityFields.LastModifyDate);
            this.Fields.Add("StoreAmount", BUSStoreBillDetailEntityFields.StoreAmount);
			this.Fields.Add("DetailRemark", BUSStoreBillDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSStoreBillDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSStoreBillDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSStoreBillDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSStoreBillDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSStoreBillDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSStoreBillDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSStoreBillDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSStoreBillDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSStoreBillDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSStoreBillDetailEntityFields.Reservation10);
		}
	}

	#region BUSStoreBillDetailEntityFields

	public class BUSStoreBillDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_StoreBillDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField StoreID
		{
			get { return new EntityField("BUS_StoreBillDetail", 1, "StoreID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_StoreBillDetail", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_StoreBillDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_StoreBillDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_StoreBillDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField BillAmount
		{
			get { return new EntityField("BUS_StoreBillDetail", 6, "BillAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField QualifiedAmount
		{
			get { return new EntityField("BUS_StoreBillDetail", 7, "QualifiedAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_StoreBillDetail", 8, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_StoreBillDetail", 9, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_StoreBillDetail", 10, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_StoreBillDetail", 11, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_StoreBillDetail", 12, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField StoreAmount
        {
            get { return new EntityField("BUS_StoreBillDetail", 13, "StoreAmount", SqlDbType.Int, false, false, false, true); }
        }

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_StoreBillDetail", 14, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_StoreBillDetail", 15, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_StoreBillDetail", 16, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_StoreBillDetail", 17, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_StoreBillDetail", 18, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_StoreBillDetail", 19, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_StoreBillDetail", 20, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_StoreBillDetail", 21, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_StoreBillDetail", 22, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_StoreBillDetail", 23, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_StoreBillDetail", 24, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSStoreBillDetailEntityFields2

	public enum BUSStoreBillDetailEntityFields2
	{
		DetailID,

		StoreID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		BillAmount,

		QualifiedAmount,

		Amount,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

        StoreAmount,

		DetailRemark,

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
