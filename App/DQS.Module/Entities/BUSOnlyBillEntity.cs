
using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
    public class BUSOnlyBillEntity : EntityBase
    {
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

		public string BillTypeName
		{
			get { return (string)this.GetValue("BillTypeName"); } 
			set { this.SetValue("BillTypeName", value); } 
		}

		public string BillStyle
		{
			get { return (string)this.GetValue("BillStyle"); } 
			set { this.SetValue("BillStyle", value); } 
		}


		public string BillStatusName
		{
			get { return (string)this.GetValue("BillStatusName"); } 
			set { this.SetValue("BillStatusName", value); } 
		}

		public int PDealerID
		{
			get { return (int)this.GetValue("PDealerID"); } 
			set { this.SetValue("PDealerID", value); } 
		}

		public string PDealerName
		{
			get { return (string)this.GetValue("PDealerName"); } 
			set { this.SetValue("PDealerName", value); } 
		}
        
		public string PDealerAddress
		{
			get { return (string)this.GetValue("PDealerAddress"); } 
			set { this.SetValue("PDealerAddress", value); } 
		}

		public int SDealerID
		{
			get { return (int)this.GetValue("SDealerID"); } 
			set { this.SetValue("SDealerID", value); } 
		}

		public string SDealerName
		{
			get { return (string)this.GetValue("SDealerName"); } 
			set { this.SetValue("SDealerName", value); } 
		}
        
		public string SDealerAddress
		{
			get { return (string)this.GetValue("SDealerAddress"); } 
			set { this.SetValue("SDealerAddress", value); } 
		}

		public int TransportID
		{
			get { return (int)this.GetValue("TransportID"); } 
			set { this.SetValue("TransportID", value); } 
		}

		public string TransportCode
		{
			get { return (string)this.GetValue("TransportCode"); } 
			set { this.SetValue("TransportCode", value); } 
		}

		public int PaymentTypeID
		{
			get { return (int)this.GetValue("PaymentTypeID"); } 
			set { this.SetValue("PaymentTypeID", value); } 
		}

		public string PaymentTypeName
		{
			get { return (string)this.GetValue("PaymentTypeName"); } 
			set { this.SetValue("PaymentTypeName", value); } 
		}

		public double PTotalPrice
		{
			get { return (double)this.GetValue("PTotalPrice"); } 
			set { this.SetValue("PTotalPrice", value); } 
		}

		public double STotalPrice
		{
			get { return (double)this.GetValue("STotalPrice"); } 
			set { this.SetValue("STotalPrice", value); } 
		}

		public string POperator
		{
			get { return (string)this.GetValue("POperator"); } 
			set { this.SetValue("POperator", value); } 
		}

		public string SOperator
		{
			get { return (string)this.GetValue("SOperator"); } 
			set { this.SetValue("SOperator", value); } 
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

		public string BillRemark
		{
			get { return (string)this.GetValue("BillRemark"); } 
			set { this.SetValue("BillRemark", value); } 
		}


        public BUSOnlyBillEntity()
		{
			this.TableName = "BUS_OnlyBill";
			this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("BillID", BUSOnlyBillEntityFields.BillID);
            this.Fields.Add("BillCode", BUSOnlyBillEntityFields.BillCode);
            this.Fields.Add("BillDate", BUSOnlyBillEntityFields.BillDate);
            this.Fields.Add("BillTypeName", BUSOnlyBillEntityFields.BillTypeName);
            this.Fields.Add("BillStyle", BUSOnlyBillEntityFields.BillStyle);
            this.Fields.Add("BillStatusName", BUSOnlyBillEntityFields.BillStatusName);
            this.Fields.Add("PDealerID", BUSOnlyBillEntityFields.PDealerID);
            this.Fields.Add("PDealerName", BUSOnlyBillEntityFields.PDealerName);
            this.Fields.Add("PDealerAddress", BUSOnlyBillEntityFields.PDealerAddress);
            this.Fields.Add("SDealerID", BUSOnlyBillEntityFields.SDealerID);
            this.Fields.Add("SDealerName", BUSOnlyBillEntityFields.SDealerName);
            this.Fields.Add("SDealerAddress", BUSOnlyBillEntityFields.SDealerAddress);
            this.Fields.Add("TransportID", BUSOnlyBillEntityFields.TransportID);
            this.Fields.Add("TransportCode", BUSOnlyBillEntityFields.TransportCode);
            this.Fields.Add("PaymentTypeID", BUSOnlyBillEntityFields.PaymentTypeID);
            this.Fields.Add("PaymentTypeName", BUSOnlyBillEntityFields.PaymentTypeName);
            this.Fields.Add("PTotalPrice", BUSOnlyBillEntityFields.PTotalPrice);
            this.Fields.Add("STotalPrice", BUSOnlyBillEntityFields.STotalPrice);
            this.Fields.Add("POperator", BUSOnlyBillEntityFields.POperator);
            this.Fields.Add("SOperator", BUSOnlyBillEntityFields.SOperator);
            this.Fields.Add("CreateUserID", BUSOnlyBillEntityFields.CreateUserID);
            this.Fields.Add("CreateDate", BUSOnlyBillEntityFields.CreateDate);
            this.Fields.Add("LastModifyUserID", BUSOnlyBillEntityFields.LastModifyUserID);
            this.Fields.Add("LastModifyDate", BUSOnlyBillEntityFields.LastModifyDate);
            this.Fields.Add("BillRemark", BUSOnlyBillEntityFields.BillRemark);
		}
	}

	#region BUSOnlyBillEntityFields

	public class BUSOnlyBillEntityFields
	{
		public static EntityField BillID
		{
			get { return new EntityField("BUS_OnlyBill", 0, "BillID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BillCode
		{
            get { return new EntityField("BUS_OnlyBill", 1, "BillCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField BillDate
		{
            get { return new EntityField("BUS_OnlyBill", 2, "BillDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField BillTypeName
		{
            get { return new EntityField("BUS_OnlyBill", 3, "BillTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillStyle
		{
            get { return new EntityField("BUS_OnlyBill", 4, "BillStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillStatusName
		{
            get { return new EntityField("BUS_OnlyBill", 5, "BillStatusName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PDealerID
		{
            get { return new EntityField("BUS_OnlyBill", 6, "PDealerID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField PDealerName
		{
            get { return new EntityField("BUS_OnlyBill", 7, "PDealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PDealerAddress
		{
            get { return new EntityField("BUS_OnlyBill", 8, "PDealerAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SDealerID
		{
            get { return new EntityField("BUS_OnlyBill", 9, "SDealerID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField SDealerName
		{
            get { return new EntityField("BUS_OnlyBill", 10, "SDealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SDealerAddress
		{
            get { return new EntityField("BUS_OnlyBill", 11, "SDealerAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportID
		{
            get { return new EntityField("BUS_OnlyBill", 12, "TransportID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField TransportCode
		{
            get { return new EntityField("BUS_OnlyBill", 13, "TransportCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PaymentTypeID
		{
            get { return new EntityField("BUS_OnlyBill", 14, "PaymentTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PaymentTypeName
		{
            get { return new EntityField("BUS_OnlyBill", 15, "PaymentTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PTotalPrice
		{
            get { return new EntityField("BUS_OnlyBill", 16, "PTotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField STotalPrice
		{
            get { return new EntityField("BUS_OnlyBill", 17, "STotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField POperator
		{
            get { return new EntityField("BUS_OnlyBill", 18, "POperator", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SOperator
		{
            get { return new EntityField("BUS_OnlyBill", 19, "SOperator", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
            get { return new EntityField("BUS_OnlyBill", 20, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
            get { return new EntityField("BUS_OnlyBill", 21, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
            get { return new EntityField("BUS_OnlyBill", 22, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
            get { return new EntityField("BUS_OnlyBill", 23, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField BillRemark
		{
            get { return new EntityField("BUS_OnlyBill", 24, "BillRemark", SqlDbType.NVarChar, false, false, false, true); }
		}


	}

	#endregion

	#region BUSOnlyBillEntityFields2

	public enum BUSOnlyBillEntityFields2
	{
		
        BillID,
        BillCode,
        BillDate,
        BillTypeName,
        BillStyle,
        BillStatusName,
        PDealerID,
        PDealerName,
        PDealerAddress,
        SDealerID,
        SDealerName,
        SDealerAddress,
        TransportID,
        TransportCode,
        PaymentTypeID,
        PaymentTypeName,
        PTotalPrice,
        STotalPrice,
        POperator,
        SOperator,
        CreateUserID,
        CreateDate,
        LastModifyUserID,
        LastModifyDate,
        BillRemark,

	}

	#endregion

}
