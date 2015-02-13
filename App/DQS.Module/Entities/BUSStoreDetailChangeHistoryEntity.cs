/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-08-07 11:04:01
 *	Build Type: Entity
 *	Description: BUSStoreDetailChangeHistoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSStoreDetailChangeHistoryEntity : EntityBase
	{
		public int StoreDetailChangeHistoryID
		{
			get { return (int)this.GetValue("StoreDetailChangeHistoryID"); } 
			set { this.SetValue("StoreDetailChangeHistoryID", value); } 
		}

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

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
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

		public int NewProductID
		{
			get { return (int)this.GetValue("NewProductID"); } 
			set { this.SetValue("NewProductID", value); } 
		}

		public string NewBatchNo
		{
			get { return (string)this.GetValue("NewBatchNo"); } 
			set { this.SetValue("NewBatchNo", value); } 
		}

		public DateTime NewProduceDate
		{
			get { return (DateTime)this.GetValue("NewProduceDate"); } 
			set { this.SetValue("NewProduceDate", value); } 
		}

		public DateTime NewValidateDate
		{
			get { return (DateTime)this.GetValue("NewValidateDate"); } 
			set { this.SetValue("NewValidateDate", value); } 
		}

		public int NewAmount
		{
			get { return (int)this.GetValue("NewAmount"); } 
			set { this.SetValue("NewAmount", value); } 
		}

		public DateTime NewLastCuringDate
		{
			get { return (DateTime)this.GetValue("NewLastCuringDate"); } 
			set { this.SetValue("NewLastCuringDate", value); } 
		}

		public string NewDetailRemark
		{
			get { return (string)this.GetValue("NewDetailRemark"); } 
			set { this.SetValue("NewDetailRemark", value); } 
		}

		public int NewDepartmentID
		{
			get { return (int)this.GetValue("NewDepartmentID"); } 
			set { this.SetValue("NewDepartmentID", value); } 
		}

		public int VersionNumber
		{
			get { return (int)this.GetValue("VersionNumber"); } 
			set { this.SetValue("VersionNumber", value); } 
		}

		public string ActionName
		{
			get { return (string)this.GetValue("ActionName"); } 
			set { this.SetValue("ActionName", value); } 
		}

		public string ChangeUserName
		{
			get { return (string)this.GetValue("ChangeUserName"); } 
			set { this.SetValue("ChangeUserName", value); } 
		}

		public DateTime ChangeDate
		{
			get { return (DateTime)this.GetValue("ChangeDate"); } 
			set { this.SetValue("ChangeDate", value); } 
		}

		public BUSStoreDetailChangeHistoryEntity()
		{
			this.TableName = "BUS_StoreDetailChangeHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("StoreDetailChangeHistoryID", BUSStoreDetailChangeHistoryEntityFields.StoreDetailChangeHistoryID);
			this.Fields.Add("StoreDetailID", BUSStoreDetailChangeHistoryEntityFields.StoreDetailID);
			this.Fields.Add("ProductID", BUSStoreDetailChangeHistoryEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSStoreDetailChangeHistoryEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSStoreDetailChangeHistoryEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSStoreDetailChangeHistoryEntityFields.ValidateDate);
			this.Fields.Add("Amount", BUSStoreDetailChangeHistoryEntityFields.Amount);
			this.Fields.Add("CreateStoreID", BUSStoreDetailChangeHistoryEntityFields.CreateStoreID);
			this.Fields.Add("CreateStoreCode", BUSStoreDetailChangeHistoryEntityFields.CreateStoreCode);
			this.Fields.Add("LastStoreID", BUSStoreDetailChangeHistoryEntityFields.LastStoreID);
			this.Fields.Add("LastStoreCode", BUSStoreDetailChangeHistoryEntityFields.LastStoreCode);
			this.Fields.Add("LastCuringDate", BUSStoreDetailChangeHistoryEntityFields.LastCuringDate);
			this.Fields.Add("CreateUserID", BUSStoreDetailChangeHistoryEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSStoreDetailChangeHistoryEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSStoreDetailChangeHistoryEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSStoreDetailChangeHistoryEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSStoreDetailChangeHistoryEntityFields.DetailRemark);
			this.Fields.Add("DepartmentID", BUSStoreDetailChangeHistoryEntityFields.DepartmentID);
			this.Fields.Add("NewProductID", BUSStoreDetailChangeHistoryEntityFields.NewProductID);
			this.Fields.Add("NewBatchNo", BUSStoreDetailChangeHistoryEntityFields.NewBatchNo);
			this.Fields.Add("NewProduceDate", BUSStoreDetailChangeHistoryEntityFields.NewProduceDate);
			this.Fields.Add("NewValidateDate", BUSStoreDetailChangeHistoryEntityFields.NewValidateDate);
			this.Fields.Add("NewAmount", BUSStoreDetailChangeHistoryEntityFields.NewAmount);
			this.Fields.Add("NewLastCuringDate", BUSStoreDetailChangeHistoryEntityFields.NewLastCuringDate);
			this.Fields.Add("NewDetailRemark", BUSStoreDetailChangeHistoryEntityFields.NewDetailRemark);
			this.Fields.Add("NewDepartmentID", BUSStoreDetailChangeHistoryEntityFields.NewDepartmentID);
			this.Fields.Add("VersionNumber", BUSStoreDetailChangeHistoryEntityFields.VersionNumber);
			this.Fields.Add("ActionName", BUSStoreDetailChangeHistoryEntityFields.ActionName);
			this.Fields.Add("ChangeUserName", BUSStoreDetailChangeHistoryEntityFields.ChangeUserName);
			this.Fields.Add("ChangeDate", BUSStoreDetailChangeHistoryEntityFields.ChangeDate);
		}
	}

	#region BUSStoreDetailChangeHistoryEntityFields

	public class BUSStoreDetailChangeHistoryEntityFields
	{
		public static EntityField StoreDetailChangeHistoryID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 0, "StoreDetailChangeHistoryID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField StoreDetailID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 1, "StoreDetailID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 6, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateStoreID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 7, "CreateStoreID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateStoreCode
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 8, "CreateStoreCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LastStoreID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 9, "LastStoreID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField LastStoreCode
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 10, "LastStoreCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField LastCuringDate
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 11, "LastCuringDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 12, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 13, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 14, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 15, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 16, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DepartmentID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 17, "DepartmentID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField NewProductID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 18, "NewProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField NewBatchNo
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 19, "NewBatchNo", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField NewProduceDate
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 20, "NewProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField NewValidateDate
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 21, "NewValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField NewAmount
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 22, "NewAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField NewLastCuringDate
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 23, "NewLastCuringDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField NewDetailRemark
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 24, "NewDetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField NewDepartmentID
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 25, "NewDepartmentID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField VersionNumber
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 26, "VersionNumber", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ActionName
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 27, "ActionName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ChangeUserName
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 28, "ChangeUserName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ChangeDate
		{
			get { return new EntityField("BUS_StoreDetailChangeHistory", 29, "ChangeDate", SqlDbType.DateTime, false, false, false, false); }
		}

	}

	#endregion

	#region BUSStoreDetailChangeHistoryEntityFields2

	public enum BUSStoreDetailChangeHistoryEntityFields2
	{
		StoreDetailChangeHistoryID,

		StoreDetailID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

		Amount,

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

		NewProductID,

		NewBatchNo,

		NewProduceDate,

		NewValidateDate,

		NewAmount,

		NewLastCuringDate,

		NewDetailRemark,

		NewDepartmentID,

		VersionNumber,

		ActionName,

		ChangeUserName,

		ChangeDate,

	}

	#endregion

}
