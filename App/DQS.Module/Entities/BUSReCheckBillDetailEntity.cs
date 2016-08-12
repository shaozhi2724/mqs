using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
    public class BUSReCheckBillDetailEntity : EntityBase
    {
        public int ID
		{
			get { return (int)this.GetValue("ID"); } 
			set { this.SetValue("ID", value); } 
		}
        public int ReCheckBillID
		{
            get { return (int)this.GetValue("ReCheckBillID"); }
            set { this.SetValue("ReCheckBillID", value); } 
		}

		public int BillID
		{
			get { return (int)this.GetValue("BillID"); } 
			set { this.SetValue("BillID", value); } 
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

		public int BillAmount
		{
			get { return (int)this.GetValue("BillAmount"); } 
			set { this.SetValue("BillAmount", value); } 
		}

		public int ReceiveAmount
		{
			get { return (int)this.GetValue("ReceiveAmount"); } 
			set { this.SetValue("ReceiveAmount", value); } 
		}

		public int AcceptAmount
		{
			get { return (int)this.GetValue("AcceptAmount"); } 
			set { this.SetValue("AcceptAmount", value); } 
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

        public BUSReCheckBillDetailEntity()
		{
            this.TableName = "BUS_ReCheckBillDetail";
			this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("ID", BUSReCheckBillDetailEntityFields.ID);
            this.Fields.Add("ReCheckBillID", BUSReCheckBillDetailEntityFields.ReCheckBillID);
            this.Fields.Add("BillID", BUSReCheckBillDetailEntityFields.BillID);
            this.Fields.Add("ProductID", BUSReCheckBillDetailEntityFields.ProductID);
            this.Fields.Add("BatchNo", BUSReCheckBillDetailEntityFields.BatchNo);
            this.Fields.Add("ProduceDate", BUSReCheckBillDetailEntityFields.ProduceDate);
            this.Fields.Add("ValidateDate", BUSReCheckBillDetailEntityFields.ValidateDate);
            this.Fields.Add("SterilizationBatchNo", BUSReCheckBillDetailEntityFields.SterilizationBatchNo);
            this.Fields.Add("SterilizationDate", BUSReCheckBillDetailEntityFields.SterilizationDate);
            this.Fields.Add("BillAmount", BUSReCheckBillDetailEntityFields.BillAmount);
            this.Fields.Add("ReceiveAmount", BUSReCheckBillDetailEntityFields.ReceiveAmount);
            this.Fields.Add("AcceptAmount", BUSReCheckBillDetailEntityFields.AcceptAmount);
            this.Fields.Add("QualifiedAmount", BUSReCheckBillDetailEntityFields.QualifiedAmount);
            this.Fields.Add("UnqualifiedAmount", BUSReCheckBillDetailEntityFields.UnqualifiedAmount);
            this.Fields.Add("AcceptSolution", BUSReCheckBillDetailEntityFields.AcceptSolution);
            this.Fields.Add("AcceptResult", BUSReCheckBillDetailEntityFields.AcceptResult);
		}
	}

    #region BUSReCheckBillDetailEntityFields

    public class BUSReCheckBillDetailEntityFields
	{
        public static EntityField ID
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 0, "ID", SqlDbType.Int, true, true, true, false); }
		}
        public static EntityField ReCheckBillID
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 1, "ReCheckBillID", SqlDbType.Int, false, false, false, false); }
		}

        public static EntityField BillID
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 2, "BillID", SqlDbType.Int, false, false, false, false); }
		}

        public static EntityField ProductID
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 3, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

        public static EntityField BatchNo
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 4, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ProduceDate
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 5, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField ValidateDate
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 6, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField SterilizationBatchNo
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 7, "SterilizationBatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField SterilizationDate
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 8, "SterilizationDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField BillAmount
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 9, "BillAmount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField ReceiveAmount
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 10, "ReceiveAmount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField AcceptAmount
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 11, "AcceptAmount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField QualifiedAmount
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 12, "QualifiedAmount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField UnqualifiedAmount
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 13, "UnqualifiedAmount", SqlDbType.Int, false, false, false, true); }
		}

        public static EntityField AcceptSolution
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 14, "AcceptSolution", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField AcceptResult
		{
            get { return new EntityField("BUS_ReCheckBillDetail", 15, "AcceptResult", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

    #region BUSReCheckBillDetailEntityFields2

    public enum BUSReCheckBillDetailEntityFields2
	{
        ID,

        ReCheckBillID,
        
        BillID,
        
        ProductID,
        
        BatchNo,
        
        ProduceDate,
        
        ValidateDate,
        
        SterilizationBatchNo,
        
        SterilizationDate,
        
        BillAmount,
        
        ReceiveAmount,
        
        AcceptAmount,
        
        QualifiedAmount,
        
        UnqualifiedAmount,
        
        AcceptSolution,
        
        AcceptResult

	}

	#endregion

}
