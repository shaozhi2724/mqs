/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-18 15:05:57
 *	Build Type: Entity
 *	Description: BUSReviewDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSReviewDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int ReviewID
		{
			get { return (int)this.GetValue("ReviewID"); } 
			set { this.SetValue("ReviewID", value); } 
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

		public int ReviewAmount
		{
			get { return (int)this.GetValue("ReviewAmount"); } 
			set { this.SetValue("ReviewAmount", value); } 
		}

		public string ReviewResult
		{
			get { return (string)this.GetValue("ReviewResult"); } 
			set { this.SetValue("ReviewResult", value); } 
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

        public string SerialNumber
		{
            get { return (string)this.GetValue("SerialNumber"); }
            set { this.SetValue("SerialNumber", value); } 
		}

		public BUSReviewDetailEntity()
		{
			this.TableName = "BUS_ReviewDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSReviewDetailEntityFields.DetailID);
			this.Fields.Add("ReviewID", BUSReviewDetailEntityFields.ReviewID);
			this.Fields.Add("ProductID", BUSReviewDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSReviewDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSReviewDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSReviewDetailEntityFields.ValidateDate);
            this.Fields.Add("SterilizationBatchNo", BUSReviewDetailEntityFields.SterilizationBatchNo);
            this.Fields.Add("SterilizationDate", BUSReviewDetailEntityFields.SterilizationDate);
			this.Fields.Add("Amount", BUSReviewDetailEntityFields.Amount);
			this.Fields.Add("ReviewAmount", BUSReviewDetailEntityFields.ReviewAmount);
			this.Fields.Add("ReviewResult", BUSReviewDetailEntityFields.ReviewResult);
			this.Fields.Add("CreateUserID", BUSReviewDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSReviewDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSReviewDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSReviewDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSReviewDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSReviewDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSReviewDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSReviewDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSReviewDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSReviewDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSReviewDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSReviewDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSReviewDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSReviewDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSReviewDetailEntityFields.Reservation10);
            this.Fields.Add("SerialNumber", BUSReviewDetailEntityFields.SerialNumber);
		}
	}

	#region BUSReviewDetailEntityFields

	public class BUSReviewDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_ReviewDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ReviewID
		{
			get { return new EntityField("BUS_ReviewDetail", 1, "ReviewID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_ReviewDetail", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_ReviewDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_ReviewDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_ReviewDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField SterilizationBatchNo
		{
            get { return new EntityField("BUS_ReviewDetail", 6, "SterilizationBatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField SterilizationDate
		{
            get { return new EntityField("BUS_ReviewDetail", 7, "SterilizationDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_ReviewDetail", 8, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReviewAmount
		{
			get { return new EntityField("BUS_ReviewDetail", 9, "ReviewAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReviewResult
		{
			get { return new EntityField("BUS_ReviewDetail", 10, "ReviewResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_ReviewDetail", 11, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_ReviewDetail", 12, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_ReviewDetail", 13, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_ReviewDetail", 14, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_ReviewDetail", 15, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_ReviewDetail", 16, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_ReviewDetail", 17, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_ReviewDetail", 18, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_ReviewDetail", 19, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_ReviewDetail", 20, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_ReviewDetail", 21, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_ReviewDetail", 22, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_ReviewDetail", 23, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_ReviewDetail", 24, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_ReviewDetail", 25, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField SerialNumber
		{
            get { return new EntityField("BUS_ReviewDetail", 26, "SerialNumber", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSReviewDetailEntityFields2

	public enum BUSReviewDetailEntityFields2
	{
		DetailID,

		ReviewID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,
        
        SterilizationBatchNo,
        
        SterilizationDate,

		Amount,

		ReviewAmount,

		ReviewResult,

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

        SerialNumber,

	}

	#endregion

}
