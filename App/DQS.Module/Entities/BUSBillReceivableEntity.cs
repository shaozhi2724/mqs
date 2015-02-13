/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-18 16:37:33
 *	Build Type: Entity
 *	Description: BUSBillReceivableEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSBillReceivableEntity : EntityBase
	{
		public int BillReceivableID
		{
			get { return (int)this.GetValue("BillReceivableID"); } 
			set { this.SetValue("BillReceivableID", value); } 
		}

		public string BillReceivableCode
		{
			get { return (string)this.GetValue("BillReceivableCode"); } 
			set { this.SetValue("BillReceivableCode", value); } 
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

		public double AccountsReceivable
		{
			get { return (double)this.GetValue("AccountsReceivable"); } 
			set { this.SetValue("AccountsReceivable", value); } 
		}

		public double AccountsReceived
		{
			get { return (double)this.GetValue("AccountsReceived"); } 
			set { this.SetValue("AccountsReceived", value); } 
		}

		public double AccountsReceive
		{
			get { return (double)this.GetValue("AccountsReceive"); } 
			set { this.SetValue("AccountsReceive", value); } 
		}

		public string BillReceivableRemark
		{
			get { return (string)this.GetValue("BillReceivableRemark"); } 
			set { this.SetValue("BillReceivableRemark", value); } 
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

		public BUSBillReceivableEntity()
		{
			this.TableName = "BUS_BillReceivable";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("BillReceivableID", BUSBillReceivableEntityFields.BillReceivableID);
			this.Fields.Add("BillReceivableCode", BUSBillReceivableEntityFields.BillReceivableCode);
			this.Fields.Add("BillID", BUSBillReceivableEntityFields.BillID);
			this.Fields.Add("BillCode", BUSBillReceivableEntityFields.BillCode);
			this.Fields.Add("DealerCode", BUSBillReceivableEntityFields.DealerCode);
			this.Fields.Add("DealerName", BUSBillReceivableEntityFields.DealerName);
			this.Fields.Add("ProductAmount", BUSBillReceivableEntityFields.ProductAmount);
			this.Fields.Add("TotalPrice", BUSBillReceivableEntityFields.TotalPrice);
			this.Fields.Add("AccountsReceivable", BUSBillReceivableEntityFields.AccountsReceivable);
			this.Fields.Add("AccountsReceived", BUSBillReceivableEntityFields.AccountsReceived);
			this.Fields.Add("AccountsReceive", BUSBillReceivableEntityFields.AccountsReceive);
			this.Fields.Add("BillReceivableRemark", BUSBillReceivableEntityFields.BillReceivableRemark);
			this.Fields.Add("CreateUserName", BUSBillReceivableEntityFields.CreateUserName);
			this.Fields.Add("CreateDate", BUSBillReceivableEntityFields.CreateDate);
		}
	}

	#region BUSBillReceivableEntityFields

	public class BUSBillReceivableEntityFields
	{
		public static EntityField BillReceivableID
		{
			get { return new EntityField("BUS_BillReceivable", 0, "BillReceivableID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BillReceivableCode
		{
			get { return new EntityField("BUS_BillReceivable", 1, "BillReceivableCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_BillReceivable", 2, "BillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_BillReceivable", 3, "BillCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_BillReceivable", 4, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_BillReceivable", 5, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductAmount
		{
			get { return new EntityField("BUS_BillReceivable", 6, "ProductAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField TotalPrice
		{
			get { return new EntityField("BUS_BillReceivable", 7, "TotalPrice", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField AccountsReceivable
		{
			get { return new EntityField("BUS_BillReceivable", 8, "AccountsReceivable", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField AccountsReceived
		{
			get { return new EntityField("BUS_BillReceivable", 9, "AccountsReceived", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField AccountsReceive
		{
			get { return new EntityField("BUS_BillReceivable", 10, "AccountsReceive", SqlDbType.Float, false, false, false, false); }
		}

		public static EntityField BillReceivableRemark
		{
			get { return new EntityField("BUS_BillReceivable", 11, "BillReceivableRemark", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateUserName
		{
			get { return new EntityField("BUS_BillReceivable", 12, "CreateUserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_BillReceivable", 13, "CreateDate", SqlDbType.DateTime, false, false, false, false); }
		}

	}

	#endregion

	#region BUSBillReceivableEntityFields2

	public enum BUSBillReceivableEntityFields2
	{
		BillReceivableID,

		BillReceivableCode,

		BillID,

		BillCode,

		DealerCode,

		DealerName,

		ProductAmount,

		TotalPrice,

		AccountsReceivable,

		AccountsReceived,

		AccountsReceive,

		BillReceivableRemark,

		CreateUserName,

		CreateDate,

	}

	#endregion

}
