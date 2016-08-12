using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
    public class BUSReCheckBillEntity : EntityBase
    {	
        public int ID
		{
			get { return (int)this.GetValue("ID"); } 
			set { this.SetValue("ID", value); } 
		}

        public string ReCheckCode
		{
            get { return (string)this.GetValue("ReCheckCode"); }
            set { this.SetValue("ReCheckCode", value); } 
		}

		public int BillID
		{
			get { return (int)this.GetValue("BillID"); } 
			set { this.SetValue("BillID", value); } 
		}

		public string BillCode
		{
			get { return (string)this.GetValue("BillCode"); } 
			set { this.SetValue("BillCode", value); } 
		}

		public DateTime BillDate
		{
			get { return (DateTime)this.GetValue("BillDate"); } 
			set { this.SetValue("BillDate", value); } 
		}

		public string BillType
		{
			get { return (string)this.GetValue("BillType"); } 
			set { this.SetValue("BillType", value); } 
		}

		public string ReCheckReason
		{
			get { return (string)this.GetValue("ReCheckReason"); } 
			set { this.SetValue("ReCheckReason", value); } 
		}

		public string ReCheckResult
		{
			get { return (string)this.GetValue("ReCheckResult"); } 
			set { this.SetValue("ReCheckResult", value); } 
		}

		public string ReCheckRemark
		{
			get { return (string)this.GetValue("ReCheckRemark"); } 
			set { this.SetValue("ReCheckRemark", value); } 
		}

		public string CreateUserName
		{
			get { return (string)this.GetValue("CreateUserName"); } 
			set { this.SetValue("CreateUserName", value); } 
		}

		public DateTime CreateDate
		{
			get { return (DateTime)this.GetValue("CreateDate"); } 
			set { this.SetValue("CreateDate", value); } 
		}

		public string ReCheckUserName
		{
			get { return (string)this.GetValue("ReCheckUserName"); } 
			set { this.SetValue("ReCheckUserName", value); } 
		}

		public DateTime ReCheckDate
		{
			get { return (DateTime)this.GetValue("ReCheckDate"); } 
			set { this.SetValue("ReCheckDate", value); } 
		}

		public string ReCheck1
		{
			get { return (string)this.GetValue("ReCheck1"); } 
			set { this.SetValue("ReCheck1", value); } 
		}

		public string ReCheck2
		{
			get { return (string)this.GetValue("ReCheck2"); } 
			set { this.SetValue("ReCheck2", value); } 
		}

		public string ReCheck3
		{
			get { return (string)this.GetValue("ReCheck3"); } 
			set { this.SetValue("ReCheck3", value); } 
		}

		public string ReCheck4
		{
			get { return (string)this.GetValue("ReCheck4"); } 
			set { this.SetValue("ReCheck4", value); } 
		}

		public string ReCheck5
		{
			get { return (string)this.GetValue("ReCheck5"); } 
			set { this.SetValue("ReCheck5", value); } 
		}

        public BUSReCheckBillEntity()
		{
            this.TableName = "BUS_ReCheckBill";
			this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("ID", BUSReCheckBillEntityFields.ID);
            this.Fields.Add("ReCheckCode", BUSReCheckBillEntityFields.ReCheckCode);
            this.Fields.Add("BillID", BUSReCheckBillEntityFields.BillID);
            this.Fields.Add("BillCode", BUSReCheckBillEntityFields.BillCode);
            this.Fields.Add("BillDate", BUSReCheckBillEntityFields.BillDate);
            this.Fields.Add("BillType", BUSReCheckBillEntityFields.BillType);
            this.Fields.Add("ReCheckReason", BUSReCheckBillEntityFields.ReCheckReason);
            this.Fields.Add("ReCheckResult", BUSReCheckBillEntityFields.ReCheckResult);
            this.Fields.Add("ReCheckRemark", BUSReCheckBillEntityFields.ReCheckRemark);
            this.Fields.Add("CreateUserName", BUSReCheckBillEntityFields.CreateUserName);
            this.Fields.Add("CreateDate", BUSReCheckBillEntityFields.CreateDate);
            this.Fields.Add("ReCheckUserName", BUSReCheckBillEntityFields.ReCheckUserName);
            this.Fields.Add("ReCheckDate", BUSReCheckBillEntityFields.ReCheckDate);
            this.Fields.Add("ReCheck1", BUSReCheckBillEntityFields.ReCheck1);
            this.Fields.Add("ReCheck2", BUSReCheckBillEntityFields.ReCheck2);
            this.Fields.Add("ReCheck3", BUSReCheckBillEntityFields.ReCheck3);
            this.Fields.Add("ReCheck4", BUSReCheckBillEntityFields.ReCheck4);
            this.Fields.Add("ReCheck5", BUSReCheckBillEntityFields.ReCheck5);
		}
	}

    #region BUSReCheckBillEntityFields

    public class BUSReCheckBillEntityFields
	{
        public static EntityField ID
		{
            get { return new EntityField("BUS_ReCheckBill", 0, "ID", SqlDbType.Int, true, true, true, false); }
		}

        public static EntityField ReCheckCode
		{
            get { return new EntityField("BUS_ReCheckBill", 1, "ReCheckCode", SqlDbType.NVarChar, false, false, true, false); }
		}

        public static EntityField BillID
		{
            get { return new EntityField("BUS_ReCheckBill", 2, "BillID", SqlDbType.Int, false, false, false, false); }
		}

        public static EntityField BillCode
		{
            get { return new EntityField("BUS_ReCheckBill", 3, "BillCode", SqlDbType.NVarChar, false, false, false, false); }
		}

        public static EntityField BillDate
		{
            get { return new EntityField("BUS_ReCheckBill", 4, "BillDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField BillType
		{
            get { return new EntityField("BUS_ReCheckBill", 5, "BillType", SqlDbType.NVarChar, false, false, false, false); }
		}

        public static EntityField ReCheckReason
		{
            get { return new EntityField("BUS_ReCheckBill", 6, "ReCheckReason", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ReCheckResult
		{
            get { return new EntityField("BUS_ReCheckBill", 7, "ReCheckResult", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ReCheckRemark
		{
            get { return new EntityField("BUS_ReCheckBill", 8, "ReCheckRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField CreateUserName
		{
            get { return new EntityField("BUS_ReCheckBill", 9, "CreateUserName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField CreateDate
		{
            get { return new EntityField("BUS_ReCheckBill", 10, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField ReCheckUserName
		{
            get { return new EntityField("BUS_ReCheckBill", 11, "ReCheckUserName", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ReCheckDate
		{
            get { return new EntityField("BUS_ReCheckBill", 12, "ReCheckDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField ReCheck1
		{
            get { return new EntityField("BUS_ReCheckBill", 13, "ReCheck1", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ReCheck2
		{
            get { return new EntityField("BUS_ReCheckBill", 14, "ReCheck2", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ReCheck3
		{
            get { return new EntityField("BUS_ReCheckBill", 15, "ReCheck3", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ReCheck4
		{
            get { return new EntityField("BUS_ReCheckBill", 16, "ReCheck4", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField ReCheck5
		{
            get { return new EntityField("BUS_ReCheckBill", 17, "ReCheck5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

    #region BUSReCheckBillEntityFields2

    public enum BUSReCheckBillEntityFields2
	{
		ID,

        ReCheckCode,

        BillID,
        
        BillCode,
        
        BillDate,
        
        BillType,
        
        ReCheckReason,
        
        ReCheckResult,
        
        ReCheckRemark,
        
        CreateUserName,
        
        CreateDate,
        
        ReCheckUserName,
        
        ReCheckDate,
        
        ReCheck1,
        
        ReCheck2,
        
        ReCheck3,
        
        ReCheck4,
        
        ReCheck5

	}

	#endregion

}
