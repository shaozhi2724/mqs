/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-27 10:53:20
 *	Build Type: Entity
 *	Description: BUSStoreDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSStoreDetailEntity : EntityBase
	{
		public int StoreDetailID
		{
			get { return (int)this.GetValue("StoreDetailID"); } 
			set { this.SetValue("StoreDetailID", value); } 
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

        public string SterilizationBatchNo
		{
            get { return (string)this.GetValue("SterilizationBatchNo"); }
            set { this.SetValue("SterilizationBatchNo", value); } 
		}

        public DateTime SterilizationDate
		{
            get { return (DateTime)this.GetValue("SterilizationDate"); }
            set { this.SetValue("SterilizationDate", value); } 
		}

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
		}
        public double Price
		{
            get { return (double)this.GetValue("Price"); }
            set { this.SetValue("Price", value); } 
		}
        public double TotalPrice
		{
            get { return (double)this.GetValue("TotalPrice"); }
            set { this.SetValue("TotalPrice", value); } 
		}

		public int CreateStoreID
		{
			get { return (int)this.GetValue("CreateStoreID"); } 
			set { this.SetValue("CreateStoreID", value); } 
		}

		public string CreateStoreCode
		{
			get { return (string)this.GetValue("CreateStoreCode"); } 
			set { this.SetValue("CreateStoreCode", value); } 
		}

		public int LastStoreID
		{
			get { return (int)this.GetValue("LastStoreID"); } 
			set { this.SetValue("LastStoreID", value); } 
		}

		public string LastStoreCode
		{
			get { return (string)this.GetValue("LastStoreCode"); } 
			set { this.SetValue("LastStoreCode", value); } 
		}

		public DateTime LastCuringDate
		{
			get { return (DateTime)this.GetValue("LastCuringDate"); } 
			set { this.SetValue("LastCuringDate", value); } 
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

		public string DetailRemark
		{
			get { return (string)this.GetValue("DetailRemark"); } 
			set { this.SetValue("DetailRemark", value); } 
		}

		public int DepartmentID
		{
			get { return (int)this.GetValue("DepartmentID"); }
            set { this.SetValue("DepartmentID", value); } 
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

		public BUSStoreDetailEntity()
		{
			this.TableName = "BUS_StoreDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("StoreDetailID", BUSStoreDetailEntityFields.StoreDetailID);
			this.Fields.Add("ProductID", BUSStoreDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSStoreDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSStoreDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSStoreDetailEntityFields.ValidateDate);
            this.Fields.Add("SterilizationBatchNo", BUSStoreDetailEntityFields.SterilizationBatchNo);
            this.Fields.Add("SterilizationDate", BUSStoreDetailEntityFields.SterilizationDate);
			this.Fields.Add("Amount", BUSStoreDetailEntityFields.Amount);
            this.Fields.Add("Price", BUSStoreDetailEntityFields.Price);
            this.Fields.Add("TotalPrice", BUSStoreDetailEntityFields.TotalPrice);
			this.Fields.Add("CreateStoreID", BUSStoreDetailEntityFields.CreateStoreID);
			this.Fields.Add("CreateStoreCode", BUSStoreDetailEntityFields.CreateStoreCode);
			this.Fields.Add("LastStoreID", BUSStoreDetailEntityFields.LastStoreID);
			this.Fields.Add("LastStoreCode", BUSStoreDetailEntityFields.LastStoreCode);
			this.Fields.Add("LastCuringDate", BUSStoreDetailEntityFields.LastCuringDate);
			this.Fields.Add("CreateUserID", BUSStoreDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSStoreDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSStoreDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSStoreDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSStoreDetailEntityFields.DetailRemark);
			this.Fields.Add("DepartmentID", BUSStoreDetailEntityFields.DepartmentID);
			this.Fields.Add("Reservation1", BUSStoreDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSStoreDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSStoreDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSStoreDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSStoreDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSStoreDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSStoreDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSStoreDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSStoreDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSStoreDetailEntityFields.Reservation10);
		}
	}

	#region BUSStoreDetailEntityFields

	public class BUSStoreDetailEntityFields
	{

	    public static EntityField StoreDetailID
		{
			get { return new EntityField("BUS_StoreDetail", 0, "StoreDetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_StoreDetail", 1, "ProductID", SqlDbType.Int, false, false, true, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_StoreDetail", 2, "BatchNo", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_StoreDetail", 3, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_StoreDetail", 4, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField SterilizationBatchNo
		{
            get { return new EntityField("BUS_StoreDetail", 5, "SterilizationBatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField SterilizationDate
		{
            get { return new EntityField("BUS_StoreDetail", 6, "SterilizationDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_StoreDetail", 7, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField Price
		{
            get { return new EntityField("BUS_StoreDetail", 8, "Price", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField TotalPrice
		{
            get { return new EntityField("BUS_StoreDetail", 9, "TotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField CreateStoreID
		{
			get { return new EntityField("BUS_StoreDetail", 10, "CreateStoreID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateStoreCode
		{
			get { return new EntityField("BUS_StoreDetail", 11, "CreateStoreCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LastStoreID
		{
			get { return new EntityField("BUS_StoreDetail", 12, "LastStoreID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField LastStoreCode
		{
			get { return new EntityField("BUS_StoreDetail", 13, "LastStoreCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LastCuringDate
		{
			get { return new EntityField("BUS_StoreDetail", 14, "LastCuringDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_StoreDetail", 15, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_StoreDetail", 16, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_StoreDetail", 17, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_StoreDetail", 18, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_StoreDetail", 19, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField DepartmentID
        {
            get { return new EntityField("BUS_StoreDetail", 20, "DepartmentID", SqlDbType.Int, false, false, false, true); }
        }
		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_StoreDetail", 21, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_StoreDetail", 22, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_StoreDetail", 23, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_StoreDetail", 24, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_StoreDetail", 25, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_StoreDetail", 26, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_StoreDetail", 27, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_StoreDetail", 28, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_StoreDetail", 29, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_StoreDetail", 30, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSStoreDetailEntityFields2

	public enum BUSStoreDetailEntityFields2
	{
		StoreDetailID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,
        
        SterilizationBatchNo,
        
        SterilizationDate,

		Amount,

        Price,

        TotalPrice,

		CreateStoreID,

		CreateStoreCode,

		LastStoreID,

		LastStoreCode,

		LastCuringDate,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		DetailRemark,

        DepartmentID,

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
