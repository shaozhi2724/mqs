/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-28 14:15:34
 *	Build Type: Entity
 *	Description: BUSExceptionReportDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSExceptionReportDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int ExceptionID
		{
			get { return (int)this.GetValue("ExceptionID"); } 
			set { this.SetValue("ExceptionID", value); } 
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

        public int LockAmount
		{
            get { return (int)this.GetValue("LockAmount"); }
            set { this.SetValue("LockAmount", value); } 
		}

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
		}

        public int ResultAmount
		{
            get { return (int)this.GetValue("ResultAmount"); }
            set { this.SetValue("ResultAmount", value); } 
		}

		public string DetailContent
		{
			get { return (string)this.GetValue("DetailContent"); } 
			set { this.SetValue("DetailContent", value); } 
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

		public BUSExceptionReportDetailEntity()
		{
			this.TableName = "BUS_ExceptionReportDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSExceptionReportDetailEntityFields.DetailID);
			this.Fields.Add("ExceptionID", BUSExceptionReportDetailEntityFields.ExceptionID);
			this.Fields.Add("ProductID", BUSExceptionReportDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSExceptionReportDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSExceptionReportDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSExceptionReportDetailEntityFields.ValidateDate);
            this.Fields.Add("LockAmount", BUSExceptionReportDetailEntityFields.LockAmount);
			this.Fields.Add("Amount", BUSExceptionReportDetailEntityFields.Amount);
            this.Fields.Add("ResultAmount", BUSExceptionReportDetailEntityFields.ResultAmount);
			this.Fields.Add("DetailContent", BUSExceptionReportDetailEntityFields.DetailContent);
			this.Fields.Add("CreateUserID", BUSExceptionReportDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSExceptionReportDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSExceptionReportDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSExceptionReportDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSExceptionReportDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSExceptionReportDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSExceptionReportDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSExceptionReportDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSExceptionReportDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSExceptionReportDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSExceptionReportDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSExceptionReportDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSExceptionReportDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSExceptionReportDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSExceptionReportDetailEntityFields.Reservation10);
		}
	}

	#region BUSExceptionReportDetailEntityFields

	public class BUSExceptionReportDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ExceptionID
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 1, "ExceptionID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 2, "ProductID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField LockAmount
		{
            get { return new EntityField("BUS_ExceptionReportDetail", 6, "LockAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 6, "Amount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField ResultAmount
		{
            get { return new EntityField("BUS_ExceptionReportDetail", 6, "ResultAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DetailContent
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 7, "DetailContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 8, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 9, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 10, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 11, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 12, "DetailRemark", SqlDbType.VarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 13, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 14, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 15, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 16, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 17, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 18, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 19, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 20, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 21, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ExceptionReportDetail", 22, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSExceptionReportDetailEntityFields2

	public enum BUSExceptionReportDetailEntityFields2
	{
		DetailID,

		ExceptionID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

        LockAmount,

		Amount,

        ResultAmount,

		DetailContent,

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

	}

	#endregion

}
