/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: Entity
 *	Description: BUSInventoryDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSInventoryDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int InventoryID
		{
			get { return (int)this.GetValue("InventoryID"); } 
			set { this.SetValue("InventoryID", value); } 
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

		public DateTime ValidateDate
		{
			get { return (DateTime)this.GetValue("ValidateDate"); } 
			set { this.SetValue("ValidateDate", value); } 
		}

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
		}

		public int InventoryAmount
		{
			get { return (int)this.GetValue("InventoryAmount"); } 
			set { this.SetValue("InventoryAmount", value); } 
		}

		public int DifferenceAmount
		{
			get { return (int)this.GetValue("DifferenceAmount"); } 
			set { this.SetValue("DifferenceAmount", value); } 
		}

		public string InventoryResult
		{
			get { return (string)this.GetValue("InventoryResult"); } 
			set { this.SetValue("InventoryResult", value); } 
		}

		public bool IsLocationRight
		{
			get { return (bool)this.GetValue("IsLocationRight"); } 
			set { this.SetValue("IsLocationRight", value); } 
		}

		public int StructureID
		{
			get { return (int)this.GetValue("StructureID"); } 
			set { this.SetValue("StructureID", value); } 
		}

		public string StructureBarCode
		{
			get { return (string)this.GetValue("StructureBarCode"); } 
			set { this.SetValue("StructureBarCode", value); } 
		}

		public string DealResult
		{
			get { return (string)this.GetValue("DealResult"); } 
			set { this.SetValue("DealResult", value); } 
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

		public int InStoreID
		{
            get { return (int)this.GetValue("InStoreID"); }
            set { this.SetValue("InStoreID", value); } 
		}

		public BUSInventoryDetailEntity()
		{
			this.TableName = "BUS_InventoryDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSInventoryDetailEntityFields.DetailID);
			this.Fields.Add("InventoryID", BUSInventoryDetailEntityFields.InventoryID);
			this.Fields.Add("ProductID", BUSInventoryDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSInventoryDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSInventoryDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSInventoryDetailEntityFields.ValidateDate);
            this.Fields.Add("SterilizationBatchNo", BUSInventoryDetailEntityFields.SterilizationBatchNo);
            this.Fields.Add("SterilizationDate", BUSInventoryDetailEntityFields.SterilizationDate);
			this.Fields.Add("Amount", BUSInventoryDetailEntityFields.Amount);
			this.Fields.Add("InventoryAmount", BUSInventoryDetailEntityFields.InventoryAmount);
			this.Fields.Add("DifferenceAmount", BUSInventoryDetailEntityFields.DifferenceAmount);
			this.Fields.Add("InventoryResult", BUSInventoryDetailEntityFields.InventoryResult);
			this.Fields.Add("IsLocationRight", BUSInventoryDetailEntityFields.IsLocationRight);
			this.Fields.Add("StructureID", BUSInventoryDetailEntityFields.StructureID);
			this.Fields.Add("StructureBarCode", BUSInventoryDetailEntityFields.StructureBarCode);
			this.Fields.Add("DealResult", BUSInventoryDetailEntityFields.DealResult);
			this.Fields.Add("CreateUserID", BUSInventoryDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSInventoryDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSInventoryDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSInventoryDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSInventoryDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSInventoryDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSInventoryDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSInventoryDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSInventoryDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSInventoryDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSInventoryDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSInventoryDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSInventoryDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSInventoryDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSInventoryDetailEntityFields.Reservation10);
            this.Fields.Add("InStoreID", BUSInventoryDetailEntityFields.InStoreID);
		}
	}

	#region BUSInventoryDetailEntityFields

	public class BUSInventoryDetailEntityFields
	{
		public static EntityField DetailID
		{
            get { return new EntityField("BUS_InventoryDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField InventoryID
		{
			get { return new EntityField("BUS_InventoryDetail", 1, "InventoryID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_InventoryDetail", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_InventoryDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_InventoryDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_InventoryDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField SterilizationBatchNo
		{
            get { return new EntityField("BUS_InventoryDetail", 6, "SterilizationBatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField SterilizationDate
		{
            get { return new EntityField("BUS_InventoryDetail", 7, "SterilizationDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_InventoryDetail", 8, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField InventoryAmount
		{
			get { return new EntityField("BUS_InventoryDetail", 9, "InventoryAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DifferenceAmount
		{
			get { return new EntityField("BUS_InventoryDetail", 10, "DifferenceAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField InventoryResult
		{
			get { return new EntityField("BUS_InventoryDetail", 11, "InventoryResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsLocationRight
		{
			get { return new EntityField("BUS_InventoryDetail", 12, "IsLocationRight", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField StructureID
		{
			get { return new EntityField("BUS_InventoryDetail", 13, "StructureID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StructureBarCode
		{
			get { return new EntityField("BUS_InventoryDetail", 14, "StructureBarCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealResult
		{
			get { return new EntityField("BUS_InventoryDetail", 15, "DealResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_InventoryDetail", 16, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_InventoryDetail", 17, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_InventoryDetail", 18, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_InventoryDetail", 19, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_InventoryDetail", 20, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_InventoryDetail", 21, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_InventoryDetail", 22, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_InventoryDetail", 23, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_InventoryDetail", 24, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_InventoryDetail", 25, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_InventoryDetail", 26, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_InventoryDetail", 27, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_InventoryDetail", 28, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_InventoryDetail", 29, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_InventoryDetail", 30, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField InStoreID
		{
            get { return new EntityField("BUS_InventoryDetail", 31, "InStoreID", SqlDbType.Int, false, false, false, true); }
		}

	}

	#endregion

	#region BUSInventoryDetailEntityFields2

	public enum BUSInventoryDetailEntityFields2
	{
		DetailID,

		InventoryID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

        SterilizationBatchNo,

        SterilizationDate,

		Amount,

		InventoryAmount,

		DifferenceAmount,

		InventoryResult,

		IsLocationRight,

		StructureID,

		StructureBarCode,

		DealResult,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

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

        InStoreID

	}

	#endregion

}
