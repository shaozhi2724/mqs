/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-09-22 17:27:36
 *	Build Type: Entity
 *	Description: BUSAcceptDetailEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSAcceptDetailEntity : EntityBase
	{
		public int DetailID
		{
			get { return (int)this.GetValue("DetailID"); } 
			set { this.SetValue("DetailID", value); } 
		}

		public int AcceptID
		{
			get { return (int)this.GetValue("AcceptID"); } 
			set { this.SetValue("AcceptID", value); } 
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

		public int ReceiveAmount
		{
			get { return (int)this.GetValue("ReceiveAmount"); } 
			set { this.SetValue("ReceiveAmount", value); } 
		}

		public int QualifiedAmount
		{
			get { return (int)this.GetValue("QualifiedAmount"); } 
			set { this.SetValue("QualifiedAmount", value); } 
		}

		public int UnqualifiedAmount
		{
			get { return (int)this.GetValue("UnqualifiedAmount"); } 
			set { this.SetValue("UnqualifiedAmount", value); } 
		}

		public string AcceptAgingTime
		{
			get { return (string)this.GetValue("AcceptAgingTime"); } 
			set { this.SetValue("AcceptAgingTime", value); } 
		}

		public string AcceptSolution
		{
			get { return (string)this.GetValue("AcceptSolution"); } 
			set { this.SetValue("AcceptSolution", value); } 
		}

		public string AcceptResult
		{
			get { return (string)this.GetValue("AcceptResult"); } 
			set { this.SetValue("AcceptResult", value); } 
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

		public BUSAcceptDetailEntity()
		{
			this.TableName = "BUS_AcceptDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("DetailID", BUSAcceptDetailEntityFields.DetailID);
			this.Fields.Add("AcceptID", BUSAcceptDetailEntityFields.AcceptID);
			this.Fields.Add("ProductID", BUSAcceptDetailEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSAcceptDetailEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSAcceptDetailEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSAcceptDetailEntityFields.ValidateDate);
            this.Fields.Add("SterilizationBatchNo", BUSAcceptDetailEntityFields.SterilizationBatchNo);
            this.Fields.Add("SterilizationDate", BUSAcceptDetailEntityFields.SterilizationDate);
			this.Fields.Add("Amount", BUSAcceptDetailEntityFields.Amount);
			this.Fields.Add("ReceiveAmount", BUSAcceptDetailEntityFields.ReceiveAmount);
			this.Fields.Add("QualifiedAmount", BUSAcceptDetailEntityFields.QualifiedAmount);
			this.Fields.Add("UnqualifiedAmount", BUSAcceptDetailEntityFields.UnqualifiedAmount);
			this.Fields.Add("AcceptAgingTime", BUSAcceptDetailEntityFields.AcceptAgingTime);
			this.Fields.Add("AcceptSolution", BUSAcceptDetailEntityFields.AcceptSolution);
			this.Fields.Add("AcceptResult", BUSAcceptDetailEntityFields.AcceptResult);
			this.Fields.Add("CreateUserID", BUSAcceptDetailEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSAcceptDetailEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSAcceptDetailEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSAcceptDetailEntityFields.LastModifyDate);
			this.Fields.Add("DetailRemark", BUSAcceptDetailEntityFields.DetailRemark);
			this.Fields.Add("Reservation1", BUSAcceptDetailEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSAcceptDetailEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSAcceptDetailEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSAcceptDetailEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSAcceptDetailEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSAcceptDetailEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSAcceptDetailEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSAcceptDetailEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSAcceptDetailEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSAcceptDetailEntityFields.Reservation10);
            this.Fields.Add("SerialNumber", BUSAcceptDetailEntityFields.SerialNumber);
		}
	}

	#region BUSAcceptDetailEntityFields

	public class BUSAcceptDetailEntityFields
	{
		public static EntityField DetailID
		{
			get { return new EntityField("BUS_AcceptDetail", 0, "DetailID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField AcceptID
		{
			get { return new EntityField("BUS_AcceptDetail", 1, "AcceptID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_AcceptDetail", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_AcceptDetail", 3, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_AcceptDetail", 4, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_AcceptDetail", 5, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField SterilizationBatchNo
		{
            get { return new EntityField("BUS_AcceptDetail", 6, "SterilizationBatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField SterilizationDate
		{
            get { return new EntityField("BUS_AcceptDetail", 7, "SterilizationDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_AcceptDetail", 8, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReceiveAmount
		{
			get { return new EntityField("BUS_AcceptDetail", 9, "ReceiveAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField QualifiedAmount
		{
			get { return new EntityField("BUS_AcceptDetail", 10, "QualifiedAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField UnqualifiedAmount
		{
			get { return new EntityField("BUS_AcceptDetail", 11, "UnqualifiedAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField AcceptAgingTime
		{
			get { return new EntityField("BUS_AcceptDetail", 12, "AcceptAgingTime", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AcceptSolution
		{
			get { return new EntityField("BUS_AcceptDetail", 13, "AcceptSolution", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AcceptResult
		{
			get { return new EntityField("BUS_AcceptDetail", 14, "AcceptResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_AcceptDetail", 15, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_AcceptDetail", 16, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_AcceptDetail", 17, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_AcceptDetail", 18, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField DetailRemark
		{
			get { return new EntityField("BUS_AcceptDetail", 19, "DetailRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_AcceptDetail", 20, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_AcceptDetail", 21, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_AcceptDetail", 22, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_AcceptDetail", 23, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_AcceptDetail", 24, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_AcceptDetail", 25, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_AcceptDetail", 26, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_AcceptDetail", 27, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_AcceptDetail", 28, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_AcceptDetail", 29, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField SerialNumber
		{
            get { return new EntityField("BUS_AcceptDetail", 30, "SerialNumber", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSAcceptDetailEntityFields2

	public enum BUSAcceptDetailEntityFields2
	{
		DetailID,

		AcceptID,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

        SterilizationBatchNo,
        
        SterilizationDate,

		Amount,

		ReceiveAmount,

		QualifiedAmount,

		UnqualifiedAmount,

		AcceptAgingTime,

		AcceptSolution,

		AcceptResult,

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
