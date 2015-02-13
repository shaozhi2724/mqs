/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-18 16:37:33
 *	Build Type: Entity
 *	Description: BUSBillPayableEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSBillPayableEntity : EntityBase
	{
		public int BillPayableID
		{
			get { return (int)this.GetValue("BillPayableID"); } 
			set { this.SetValue("BillPayableID", value); } 
		}

		public string BillPayableCode
		{
			get { return (string)this.GetValue("BillPayableCode"); } 
			set { this.SetValue("BillPayableCode", value); } 
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

		public string DealerCode
		{
			get { return (string)this.GetValue("DealerCode"); } 
			set { this.SetValue("DealerCode", value); } 
		}

		public string DealerName
		{
			get { return (string)this.GetValue("DealerName"); } 
			set { this.SetValue("DealerName", value); } 
		}

		public int ProductAmount
		{
			get { return (int)this.GetValue("ProductAmount"); } 
			set { this.SetValue("ProductAmount", value); } 
		}

		public double TotalPrice
		{
			get { return (double)this.GetValue("TotalPrice"); } 
			set { this.SetValue("TotalPrice", value); } 
		}

		public double AccountsPayable
		{
			get { return (double)this.GetValue("AccountsPayable"); } 
			set { this.SetValue("AccountsPayable", value); } 
		}

		public double AccountsPaid
		{
			get { return (double)this.GetValue("AccountsPaid"); } 
			set { this.SetValue("AccountsPaid", value); } 
		}

		public double AccountsPay
		{
			get { return (double)this.GetValue("AccountsPay"); } 
			set { this.SetValue("AccountsPay", value); } 
		}

		public string BillPayableRemark
		{
			get { return (string)this.GetValue("BillPayableRemark"); } 
			set { this.SetValue("BillPayableRemark", value); } 
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

		public BUSBillPayableEntity()
		{
			this.TableName = "BUS_BillPayable";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("BillPayableID", BUSBillPayableEntityFields.BillPayableID);
			this.Fields.Add("BillPayableCode", BUSBillPayableEntityFields.BillPayableCode);
			this.Fields.Add("BillID", BUSBillPayableEntityFields.BillID);
			this.Fields.Add("BillCode", BUSBillPayableEntityFields.BillCode);
			this.Fields.Add("DealerCode", BUSBillPayableEntityFields.DealerCode);
			this.Fields.Add("DealerName", BUSBillPayableEntityFields.DealerName);
			this.Fields.Add("ProductAmount", BUSBillPayableEntityFields.ProductAmount);
			this.Fields.Add("TotalPrice", BUSBillPayableEntityFields.TotalPrice);
			this.Fields.Add("AccountsPayable", BUSBillPayableEntityFields.AccountsPayable);
			this.Fields.Add("AccountsPaid", BUSBillPayableEntityFields.AccountsPaid);
			this.Fields.Add("AccountsPay", BUSBillPayableEntityFields.AccountsPay);
			this.Fields.Add("BillPayableRemark", BUSBillPayableEntityFields.BillPayableRemark);
			this.Fields.Add("CreateUserName", BUSBillPayableEntityFields.CreateUserName);
			this.Fields.Add("CreateDate", BUSBillPayableEntityFields.CreateDate);
		}
	}

	#region BUSBillPayableEntityFields

	public class BUSBillPayableEntityFields
	{
		public static EntityField BillPayableID
		{
			get { return new EntityField("BUS_BillPayable", 0, "BillPayableID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BillPayableCode
		{
			get { return new EntityField("BUS_BillPayable", 1, "BillPayableCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_BillPayable", 2, "BillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_BillPayable", 3, "BillCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_BillPayable", 4, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_BillPayable", 5, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductAmount
		{
			get { return new EntityField("BUS_BillPayable", 6, "ProductAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField TotalPrice
		{
			get { return new EntityField("BUS_BillPayable", 7, "TotalPrice", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField AccountsPayable
		{
			get { return new EntityField("BUS_BillPayable", 8, "AccountsPayable", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField AccountsPaid
		{
			get { return new EntityField("BUS_BillPayable", 9, "AccountsPaid", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField AccountsPay
		{
			get { return new EntityField("BUS_BillPayable", 10, "AccountsPay", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField BillPayableRemark
		{
			get { return new EntityField("BUS_BillPayable", 11, "BillPayableRemark", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateUserName
		{
			get { return new EntityField("BUS_BillPayable", 12, "CreateUserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_BillPayable", 13, "CreateDate", SqlDbType.DateTime, false, false, false, false); }
		}

	}

	#endregion

	#region BUSBillPayableEntityFields2

	public enum BUSBillPayableEntityFields2
	{
		BillPayableID,

		BillPayableCode,

		BillID,

		BillCode,

		DealerCode,

		DealerName,

		ProductAmount,

		TotalPrice,

		AccountsPayable,

		AccountsPaid,

		AccountsPay,

		BillPayableRemark,

		CreateUserName,

		CreateDate,

	}

	#endregion

}
