/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-05 23:42:26
 *	Build Type: Entity
 *	Description: BUSBillChangeHistoryEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSBillChangeHistoryEntity : EntityBase
	{
		public Guid BillHistoryID
		{
			get { return (Guid)this.GetValue("BillHistoryID"); } 
			set { this.SetValue("BillHistoryID", value); } 
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

		public bool IsBillIn
		{
			get { return (bool)this.GetValue("IsBillIn"); } 
			set { this.SetValue("IsBillIn", value); } 
		}

		public int BillTypeID
		{
			get { return (int)this.GetValue("BillTypeID"); } 
			set { this.SetValue("BillTypeID", value); } 
		}

		public string BillTypeName
		{
			get { return (string)this.GetValue("BillTypeName"); } 
			set { this.SetValue("BillTypeName", value); } 
		}

		public string BillTypeSpell
		{
			get { return (string)this.GetValue("BillTypeSpell"); } 
			set { this.SetValue("BillTypeSpell", value); } 
		}

		public string BillStyle
		{
			get { return (string)this.GetValue("BillStyle"); } 
			set { this.SetValue("BillStyle", value); } 
		}

		public int BillStatus
		{
			get { return (int)this.GetValue("BillStatus"); } 
			set { this.SetValue("BillStatus", value); } 
		}

		public string BillStatusName
		{
			get { return (string)this.GetValue("BillStatusName"); } 
			set { this.SetValue("BillStatusName", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
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

		public string DealerSpell
		{
			get { return (string)this.GetValue("DealerSpell"); } 
			set { this.SetValue("DealerSpell", value); } 
		}

		public string DealerAddress
		{
			get { return (string)this.GetValue("DealerAddress"); } 
			set { this.SetValue("DealerAddress", value); } 
		}

		public string BusinessPerson
		{
			get { return (string)this.GetValue("BusinessPerson"); } 
			set { this.SetValue("BusinessPerson", value); } 
		}

		public string BusinessPersonSpell
		{
			get { return (string)this.GetValue("BusinessPersonSpell"); } 
			set { this.SetValue("BusinessPersonSpell", value); } 
		}

		public string BusinessPhone
		{
			get { return (string)this.GetValue("BusinessPhone"); } 
			set { this.SetValue("BusinessPhone", value); } 
		}

		public int DeliveryTypeID
		{
			get { return (int)this.GetValue("DeliveryTypeID"); } 
			set { this.SetValue("DeliveryTypeID", value); } 
		}

		public string DeliveryTypeName
		{
			get { return (string)this.GetValue("DeliveryTypeName"); } 
			set { this.SetValue("DeliveryTypeName", value); } 
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

		public double TotalPrice
		{
			get { return (double)this.GetValue("TotalPrice"); } 
			set { this.SetValue("TotalPrice", value); } 
		}

		public DateTime PaymentDate
		{
			get { return (DateTime)this.GetValue("PaymentDate"); } 
			set { this.SetValue("PaymentDate", value); } 
		}

		public int InvoiceTypeID
		{
			get { return (int)this.GetValue("InvoiceTypeID"); } 
			set { this.SetValue("InvoiceTypeID", value); } 
		}

		public string InvoiceTypeName
		{
			get { return (string)this.GetValue("InvoiceTypeName"); } 
			set { this.SetValue("InvoiceTypeName", value); } 
		}

		public string InvoiceTitle
		{
			get { return (string)this.GetValue("InvoiceTitle"); } 
			set { this.SetValue("InvoiceTitle", value); } 
		}

		public string InvoiceContent
		{
			get { return (string)this.GetValue("InvoiceContent"); } 
			set { this.SetValue("InvoiceContent", value); } 
		}

		public string Operator
		{
			get { return (string)this.GetValue("Operator"); } 
			set { this.SetValue("Operator", value); } 
		}

		public string OperatorSpell
		{
			get { return (string)this.GetValue("OperatorSpell"); } 
			set { this.SetValue("OperatorSpell", value); } 
		}

		public string ContractNo
		{
			get { return (string)this.GetValue("ContractNo"); } 
			set { this.SetValue("ContractNo", value); } 
		}

		public string ContractContent
		{
			get { return (string)this.GetValue("ContractContent"); } 
			set { this.SetValue("ContractContent", value); } 
		}

		public int SaleBillID
		{
			get { return (int)this.GetValue("SaleBillID"); } 
			set { this.SetValue("SaleBillID", value); } 
		}

		public string SaleBillCode
		{
			get { return (string)this.GetValue("SaleBillCode"); } 
			set { this.SetValue("SaleBillCode", value); } 
		}

		public int ReviewID
		{
			get { return (int)this.GetValue("ReviewID"); } 
			set { this.SetValue("ReviewID", value); } 
		}

		public string ReviewCode
		{
			get { return (string)this.GetValue("ReviewCode"); } 
			set { this.SetValue("ReviewCode", value); } 
		}

		public int StoreOutID
		{
			get { return (int)this.GetValue("StoreOutID"); } 
			set { this.SetValue("StoreOutID", value); } 
		}

		public string StoreOutCode
		{
			get { return (string)this.GetValue("StoreOutCode"); } 
			set { this.SetValue("StoreOutCode", value); } 
		}

		public int PurchaseBillID
		{
			get { return (int)this.GetValue("PurchaseBillID"); } 
			set { this.SetValue("PurchaseBillID", value); } 
		}

		public string PurchaseBillCode
		{
			get { return (string)this.GetValue("PurchaseBillCode"); } 
			set { this.SetValue("PurchaseBillCode", value); } 
		}

		public int ReceiveID
		{
			get { return (int)this.GetValue("ReceiveID"); } 
			set { this.SetValue("ReceiveID", value); } 
		}

		public string ReceiveCode
		{
			get { return (string)this.GetValue("ReceiveCode"); } 
			set { this.SetValue("ReceiveCode", value); } 
		}

		public int AcceptID
		{
			get { return (int)this.GetValue("AcceptID"); } 
			set { this.SetValue("AcceptID", value); } 
		}

		public string AcceptCode
		{
			get { return (string)this.GetValue("AcceptCode"); } 
			set { this.SetValue("AcceptCode", value); } 
		}

		public int StoreInID
		{
			get { return (int)this.GetValue("StoreInID"); } 
			set { this.SetValue("StoreInID", value); } 
		}

		public string StoreInCode
		{
			get { return (string)this.GetValue("StoreInCode"); } 
			set { this.SetValue("StoreInCode", value); } 
		}

		public string PickUpPerson
		{
			get { return (string)this.GetValue("PickUpPerson"); } 
			set { this.SetValue("PickUpPerson", value); } 
		}

		public string PickUpPersonSpell
		{
			get { return (string)this.GetValue("PickUpPersonSpell"); } 
			set { this.SetValue("PickUpPersonSpell", value); } 
		}

		public int ProductAmount
		{
			get { return (int)this.GetValue("ProductAmount"); } 
			set { this.SetValue("ProductAmount", value); } 
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

		public BUSBillChangeHistoryEntity()
		{
			this.TableName = "BUS_BillChangeHistory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("BillHistoryID", BUSBillChangeHistoryEntityFields.BillHistoryID);
			this.Fields.Add("BillID", BUSBillChangeHistoryEntityFields.BillID);
			this.Fields.Add("BillCode", BUSBillChangeHistoryEntityFields.BillCode);
			this.Fields.Add("BillDate", BUSBillChangeHistoryEntityFields.BillDate);
			this.Fields.Add("IsBillIn", BUSBillChangeHistoryEntityFields.IsBillIn);
			this.Fields.Add("BillTypeID", BUSBillChangeHistoryEntityFields.BillTypeID);
			this.Fields.Add("BillTypeName", BUSBillChangeHistoryEntityFields.BillTypeName);
			this.Fields.Add("BillTypeSpell", BUSBillChangeHistoryEntityFields.BillTypeSpell);
			this.Fields.Add("BillStyle", BUSBillChangeHistoryEntityFields.BillStyle);
			this.Fields.Add("BillStatus", BUSBillChangeHistoryEntityFields.BillStatus);
			this.Fields.Add("BillStatusName", BUSBillChangeHistoryEntityFields.BillStatusName);
			this.Fields.Add("DealerID", BUSBillChangeHistoryEntityFields.DealerID);
			this.Fields.Add("DealerCode", BUSBillChangeHistoryEntityFields.DealerCode);
			this.Fields.Add("DealerName", BUSBillChangeHistoryEntityFields.DealerName);
			this.Fields.Add("DealerSpell", BUSBillChangeHistoryEntityFields.DealerSpell);
			this.Fields.Add("DealerAddress", BUSBillChangeHistoryEntityFields.DealerAddress);
			this.Fields.Add("BusinessPerson", BUSBillChangeHistoryEntityFields.BusinessPerson);
			this.Fields.Add("BusinessPersonSpell", BUSBillChangeHistoryEntityFields.BusinessPersonSpell);
			this.Fields.Add("BusinessPhone", BUSBillChangeHistoryEntityFields.BusinessPhone);
			this.Fields.Add("DeliveryTypeID", BUSBillChangeHistoryEntityFields.DeliveryTypeID);
			this.Fields.Add("DeliveryTypeName", BUSBillChangeHistoryEntityFields.DeliveryTypeName);
			this.Fields.Add("TransportID", BUSBillChangeHistoryEntityFields.TransportID);
			this.Fields.Add("TransportCode", BUSBillChangeHistoryEntityFields.TransportCode);
			this.Fields.Add("PaymentTypeID", BUSBillChangeHistoryEntityFields.PaymentTypeID);
			this.Fields.Add("PaymentTypeName", BUSBillChangeHistoryEntityFields.PaymentTypeName);
			this.Fields.Add("TotalPrice", BUSBillChangeHistoryEntityFields.TotalPrice);
			this.Fields.Add("PaymentDate", BUSBillChangeHistoryEntityFields.PaymentDate);
			this.Fields.Add("InvoiceTypeID", BUSBillChangeHistoryEntityFields.InvoiceTypeID);
			this.Fields.Add("InvoiceTypeName", BUSBillChangeHistoryEntityFields.InvoiceTypeName);
			this.Fields.Add("InvoiceTitle", BUSBillChangeHistoryEntityFields.InvoiceTitle);
			this.Fields.Add("InvoiceContent", BUSBillChangeHistoryEntityFields.InvoiceContent);
			this.Fields.Add("Operator", BUSBillChangeHistoryEntityFields.Operator);
			this.Fields.Add("OperatorSpell", BUSBillChangeHistoryEntityFields.OperatorSpell);
			this.Fields.Add("ContractNo", BUSBillChangeHistoryEntityFields.ContractNo);
			this.Fields.Add("ContractContent", BUSBillChangeHistoryEntityFields.ContractContent);
			this.Fields.Add("SaleBillID", BUSBillChangeHistoryEntityFields.SaleBillID);
			this.Fields.Add("SaleBillCode", BUSBillChangeHistoryEntityFields.SaleBillCode);
			this.Fields.Add("ReviewID", BUSBillChangeHistoryEntityFields.ReviewID);
			this.Fields.Add("ReviewCode", BUSBillChangeHistoryEntityFields.ReviewCode);
			this.Fields.Add("StoreOutID", BUSBillChangeHistoryEntityFields.StoreOutID);
			this.Fields.Add("StoreOutCode", BUSBillChangeHistoryEntityFields.StoreOutCode);
			this.Fields.Add("PurchaseBillID", BUSBillChangeHistoryEntityFields.PurchaseBillID);
			this.Fields.Add("PurchaseBillCode", BUSBillChangeHistoryEntityFields.PurchaseBillCode);
			this.Fields.Add("ReceiveID", BUSBillChangeHistoryEntityFields.ReceiveID);
			this.Fields.Add("ReceiveCode", BUSBillChangeHistoryEntityFields.ReceiveCode);
			this.Fields.Add("AcceptID", BUSBillChangeHistoryEntityFields.AcceptID);
			this.Fields.Add("AcceptCode", BUSBillChangeHistoryEntityFields.AcceptCode);
			this.Fields.Add("StoreInID", BUSBillChangeHistoryEntityFields.StoreInID);
			this.Fields.Add("StoreInCode", BUSBillChangeHistoryEntityFields.StoreInCode);
			this.Fields.Add("PickUpPerson", BUSBillChangeHistoryEntityFields.PickUpPerson);
			this.Fields.Add("PickUpPersonSpell", BUSBillChangeHistoryEntityFields.PickUpPersonSpell);
			this.Fields.Add("ProductAmount", BUSBillChangeHistoryEntityFields.ProductAmount);
			this.Fields.Add("CreateUserID", BUSBillChangeHistoryEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSBillChangeHistoryEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSBillChangeHistoryEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSBillChangeHistoryEntityFields.LastModifyDate);
			this.Fields.Add("BillRemark", BUSBillChangeHistoryEntityFields.BillRemark);
			this.Fields.Add("Reservation1", BUSBillChangeHistoryEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSBillChangeHistoryEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSBillChangeHistoryEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSBillChangeHistoryEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSBillChangeHistoryEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSBillChangeHistoryEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSBillChangeHistoryEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSBillChangeHistoryEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSBillChangeHistoryEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSBillChangeHistoryEntityFields.Reservation10);
			this.Fields.Add("VersionNumber", BUSBillChangeHistoryEntityFields.VersionNumber);
			this.Fields.Add("ActionName", BUSBillChangeHistoryEntityFields.ActionName);
			this.Fields.Add("ChangeUserName", BUSBillChangeHistoryEntityFields.ChangeUserName);
			this.Fields.Add("ChangeDate", BUSBillChangeHistoryEntityFields.ChangeDate);
		}
	}

	#region BUSBillChangeHistoryEntityFields

	public class BUSBillChangeHistoryEntityFields
	{
		public static EntityField BillHistoryID
		{
			get { return new EntityField("BUS_BillChangeHistory", 0, "BillHistoryID", SqlDbType.UniqueIdentifier, true, false, true, false); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_BillChangeHistory", 1, "BillID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 2, "BillCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BillDate
		{
			get { return new EntityField("BUS_BillChangeHistory", 3, "BillDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField IsBillIn
		{
			get { return new EntityField("BUS_BillChangeHistory", 4, "IsBillIn", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField BillTypeID
		{
			get { return new EntityField("BUS_BillChangeHistory", 5, "BillTypeID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BillTypeName
		{
			get { return new EntityField("BUS_BillChangeHistory", 6, "BillTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillTypeSpell
		{
			get { return new EntityField("BUS_BillChangeHistory", 7, "BillTypeSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillStyle
		{
			get { return new EntityField("BUS_BillChangeHistory", 8, "BillStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillStatus
		{
			get { return new EntityField("BUS_BillChangeHistory", 9, "BillStatus", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillStatusName
		{
			get { return new EntityField("BUS_BillChangeHistory", 10, "BillStatusName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_BillChangeHistory", 11, "DealerID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 12, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_BillChangeHistory", 13, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerSpell
		{
			get { return new EntityField("BUS_BillChangeHistory", 14, "DealerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerAddress
		{
			get { return new EntityField("BUS_BillChangeHistory", 15, "DealerAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPerson
		{
			get { return new EntityField("BUS_BillChangeHistory", 16, "BusinessPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPersonSpell
		{
			get { return new EntityField("BUS_BillChangeHistory", 17, "BusinessPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPhone
		{
			get { return new EntityField("BUS_BillChangeHistory", 18, "BusinessPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DeliveryTypeID
		{
			get { return new EntityField("BUS_BillChangeHistory", 19, "DeliveryTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DeliveryTypeName
		{
			get { return new EntityField("BUS_BillChangeHistory", 20, "DeliveryTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportID
		{
			get { return new EntityField("BUS_BillChangeHistory", 21, "TransportID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField TransportCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 22, "TransportCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PaymentTypeID
		{
			get { return new EntityField("BUS_BillChangeHistory", 23, "PaymentTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PaymentTypeName
		{
			get { return new EntityField("BUS_BillChangeHistory", 24, "PaymentTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TotalPrice
		{
			get { return new EntityField("BUS_BillChangeHistory", 25, "TotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField PaymentDate
		{
			get { return new EntityField("BUS_BillChangeHistory", 26, "PaymentDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField InvoiceTypeID
		{
			get { return new EntityField("BUS_BillChangeHistory", 27, "InvoiceTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField InvoiceTypeName
		{
			get { return new EntityField("BUS_BillChangeHistory", 28, "InvoiceTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InvoiceTitle
		{
			get { return new EntityField("BUS_BillChangeHistory", 29, "InvoiceTitle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InvoiceContent
		{
			get { return new EntityField("BUS_BillChangeHistory", 30, "InvoiceContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Operator
		{
			get { return new EntityField("BUS_BillChangeHistory", 31, "Operator", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField OperatorSpell
		{
			get { return new EntityField("BUS_BillChangeHistory", 32, "OperatorSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContractNo
		{
			get { return new EntityField("BUS_BillChangeHistory", 33, "ContractNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContractContent
		{
			get { return new EntityField("BUS_BillChangeHistory", 34, "ContractContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SaleBillID
		{
			get { return new EntityField("BUS_BillChangeHistory", 35, "SaleBillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField SaleBillCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 36, "SaleBillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReviewID
		{
			get { return new EntityField("BUS_BillChangeHistory", 37, "ReviewID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReviewCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 38, "ReviewCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreOutID
		{
			get { return new EntityField("BUS_BillChangeHistory", 39, "StoreOutID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StoreOutCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 40, "StoreOutCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PurchaseBillID
		{
			get { return new EntityField("BUS_BillChangeHistory", 41, "PurchaseBillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PurchaseBillCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 42, "PurchaseBillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReceiveID
		{
			get { return new EntityField("BUS_BillChangeHistory", 43, "ReceiveID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReceiveCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 44, "ReceiveCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AcceptID
		{
			get { return new EntityField("BUS_BillChangeHistory", 45, "AcceptID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField AcceptCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 46, "AcceptCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreInID
		{
			get { return new EntityField("BUS_BillChangeHistory", 47, "StoreInID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StoreInCode
		{
			get { return new EntityField("BUS_BillChangeHistory", 48, "StoreInCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PickUpPerson
		{
			get { return new EntityField("BUS_BillChangeHistory", 49, "PickUpPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PickUpPersonSpell
		{
			get { return new EntityField("BUS_BillChangeHistory", 50, "PickUpPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductAmount
		{
			get { return new EntityField("BUS_BillChangeHistory", 51, "ProductAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_BillChangeHistory", 52, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_BillChangeHistory", 53, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_BillChangeHistory", 54, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_BillChangeHistory", 55, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField BillRemark
		{
			get { return new EntityField("BUS_BillChangeHistory", 56, "BillRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_BillChangeHistory", 57, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_BillChangeHistory", 58, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_BillChangeHistory", 59, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_BillChangeHistory", 60, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_BillChangeHistory", 61, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_BillChangeHistory", 62, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_BillChangeHistory", 63, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_BillChangeHistory", 64, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_BillChangeHistory", 65, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_BillChangeHistory", 66, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField VersionNumber
		{
			get { return new EntityField("BUS_BillChangeHistory", 67, "VersionNumber", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField ActionName
		{
			get { return new EntityField("BUS_BillChangeHistory", 68, "ActionName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ChangeUserName
		{
			get { return new EntityField("BUS_BillChangeHistory", 69, "ChangeUserName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ChangeDate
		{
			get { return new EntityField("BUS_BillChangeHistory", 70, "ChangeDate", SqlDbType.DateTime, false, false, false, false); }
		}

	}

	#endregion

	#region BUSBillChangeHistoryEntityFields2

	public enum BUSBillChangeHistoryEntityFields2
	{
		BillHistoryID,

		BillID,

		BillCode,

		BillDate,

		IsBillIn,

		BillTypeID,

		BillTypeName,

		BillTypeSpell,

		BillStyle,

		BillStatus,

		BillStatusName,

		DealerID,

		DealerCode,

		DealerName,

		DealerSpell,

		DealerAddress,

		BusinessPerson,

		BusinessPersonSpell,

		BusinessPhone,

		DeliveryTypeID,

		DeliveryTypeName,

		TransportID,

		TransportCode,

		PaymentTypeID,

		PaymentTypeName,

		TotalPrice,

		PaymentDate,

		InvoiceTypeID,

		InvoiceTypeName,

		InvoiceTitle,

		InvoiceContent,

		Operator,

		OperatorSpell,

		ContractNo,

		ContractContent,

		SaleBillID,

		SaleBillCode,

		ReviewID,

		ReviewCode,

		StoreOutID,

		StoreOutCode,

		PurchaseBillID,

		PurchaseBillCode,

		ReceiveID,

		ReceiveCode,

		AcceptID,

		AcceptCode,

		StoreInID,

		StoreInCode,

		PickUpPerson,

		PickUpPersonSpell,

		ProductAmount,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		BillRemark,

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

		VersionNumber,

		ActionName,

		ChangeUserName,

		ChangeDate,

	}

	#endregion

}
