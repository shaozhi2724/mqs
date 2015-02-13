/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-07-15 10:11:56
 *	Build Type: Entity
 *	Description: BUSBillEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSBillEntity : EntityBase
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

		public int DepartmentID
		{
			get { return (int)this.GetValue("DepartmentID"); } 
			set { this.SetValue("DepartmentID", value); }
        }

        public int PurchasePriceListID
        {
            get
            {
                return IsNullField("PurchasePriceListID") ? 1 : (int)this.GetValue("PurchasePriceListID");
            }
            set
            {
                this.SetValue("PurchasePriceListID", value);
            }
        }

        public int SalePriceListID
        {
            get
            {
                return IsNullField("SalePriceListID") ? 2 : (int)this.GetValue("SalePriceListID");
            }
            set
            {
                this.SetValue("SalePriceListID", value);
            }
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

		public BUSBillEntity()
		{
			this.TableName = "BUS_Bill";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("BillID", BUSBillEntityFields.BillID);
			this.Fields.Add("BillCode", BUSBillEntityFields.BillCode);
			this.Fields.Add("BillDate", BUSBillEntityFields.BillDate);
			this.Fields.Add("IsBillIn", BUSBillEntityFields.IsBillIn);
			this.Fields.Add("BillTypeID", BUSBillEntityFields.BillTypeID);
			this.Fields.Add("BillTypeName", BUSBillEntityFields.BillTypeName);
			this.Fields.Add("BillTypeSpell", BUSBillEntityFields.BillTypeSpell);
			this.Fields.Add("BillStyle", BUSBillEntityFields.BillStyle);
			this.Fields.Add("BillStatus", BUSBillEntityFields.BillStatus);
			this.Fields.Add("BillStatusName", BUSBillEntityFields.BillStatusName);
			this.Fields.Add("DealerID", BUSBillEntityFields.DealerID);
			this.Fields.Add("DealerCode", BUSBillEntityFields.DealerCode);
			this.Fields.Add("DealerName", BUSBillEntityFields.DealerName);
			this.Fields.Add("DealerSpell", BUSBillEntityFields.DealerSpell);
			this.Fields.Add("DealerAddress", BUSBillEntityFields.DealerAddress);
			this.Fields.Add("BusinessPerson", BUSBillEntityFields.BusinessPerson);
			this.Fields.Add("BusinessPersonSpell", BUSBillEntityFields.BusinessPersonSpell);
			this.Fields.Add("BusinessPhone", BUSBillEntityFields.BusinessPhone);
			this.Fields.Add("DeliveryTypeID", BUSBillEntityFields.DeliveryTypeID);
			this.Fields.Add("DeliveryTypeName", BUSBillEntityFields.DeliveryTypeName);
			this.Fields.Add("TransportID", BUSBillEntityFields.TransportID);
			this.Fields.Add("TransportCode", BUSBillEntityFields.TransportCode);
			this.Fields.Add("PaymentTypeID", BUSBillEntityFields.PaymentTypeID);
			this.Fields.Add("PaymentTypeName", BUSBillEntityFields.PaymentTypeName);
			this.Fields.Add("TotalPrice", BUSBillEntityFields.TotalPrice);
			this.Fields.Add("PaymentDate", BUSBillEntityFields.PaymentDate);
			this.Fields.Add("InvoiceTypeID", BUSBillEntityFields.InvoiceTypeID);
			this.Fields.Add("InvoiceTypeName", BUSBillEntityFields.InvoiceTypeName);
			this.Fields.Add("InvoiceTitle", BUSBillEntityFields.InvoiceTitle);
			this.Fields.Add("InvoiceContent", BUSBillEntityFields.InvoiceContent);
			this.Fields.Add("Operator", BUSBillEntityFields.Operator);
			this.Fields.Add("OperatorSpell", BUSBillEntityFields.OperatorSpell);
			this.Fields.Add("ContractNo", BUSBillEntityFields.ContractNo);
			this.Fields.Add("ContractContent", BUSBillEntityFields.ContractContent);
			this.Fields.Add("SaleBillID", BUSBillEntityFields.SaleBillID);
			this.Fields.Add("SaleBillCode", BUSBillEntityFields.SaleBillCode);
			this.Fields.Add("ReviewID", BUSBillEntityFields.ReviewID);
			this.Fields.Add("ReviewCode", BUSBillEntityFields.ReviewCode);
			this.Fields.Add("StoreOutID", BUSBillEntityFields.StoreOutID);
			this.Fields.Add("StoreOutCode", BUSBillEntityFields.StoreOutCode);
			this.Fields.Add("PurchaseBillID", BUSBillEntityFields.PurchaseBillID);
			this.Fields.Add("PurchaseBillCode", BUSBillEntityFields.PurchaseBillCode);
			this.Fields.Add("ReceiveID", BUSBillEntityFields.ReceiveID);
			this.Fields.Add("ReceiveCode", BUSBillEntityFields.ReceiveCode);
			this.Fields.Add("AcceptID", BUSBillEntityFields.AcceptID);
			this.Fields.Add("AcceptCode", BUSBillEntityFields.AcceptCode);
			this.Fields.Add("StoreInID", BUSBillEntityFields.StoreInID);
			this.Fields.Add("StoreInCode", BUSBillEntityFields.StoreInCode);
			this.Fields.Add("PickUpPerson", BUSBillEntityFields.PickUpPerson);
			this.Fields.Add("PickUpPersonSpell", BUSBillEntityFields.PickUpPersonSpell);
			this.Fields.Add("ProductAmount", BUSBillEntityFields.ProductAmount);
			this.Fields.Add("DepartmentID", BUSBillEntityFields.DepartmentID);
			this.Fields.Add("PurchaseListID", BUSBillEntityFields.PurchasePriceListID);
            this.Fields.Add("SalePriceListID", BUSBillEntityFields.SalePriceListID);
			this.Fields.Add("CreateUserID", BUSBillEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSBillEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSBillEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSBillEntityFields.LastModifyDate);
			this.Fields.Add("BillRemark", BUSBillEntityFields.BillRemark);
			this.Fields.Add("Reservation1", BUSBillEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSBillEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSBillEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSBillEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSBillEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSBillEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSBillEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSBillEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSBillEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSBillEntityFields.Reservation10);
		}
	}

	#region BUSBillEntityFields

	public class BUSBillEntityFields
	{
		public static EntityField BillID
		{
			get { return new EntityField("BUS_Bill", 0, "BillID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_Bill", 1, "BillCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField BillDate
		{
			get { return new EntityField("BUS_Bill", 2, "BillDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField IsBillIn
		{
			get { return new EntityField("BUS_Bill", 3, "IsBillIn", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField BillTypeID
		{
			get { return new EntityField("BUS_Bill", 4, "BillTypeID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BillTypeName
		{
			get { return new EntityField("BUS_Bill", 5, "BillTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillTypeSpell
		{
			get { return new EntityField("BUS_Bill", 6, "BillTypeSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillStyle
		{
			get { return new EntityField("BUS_Bill", 7, "BillStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillStatus
		{
			get { return new EntityField("BUS_Bill", 8, "BillStatus", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillStatusName
		{
			get { return new EntityField("BUS_Bill", 9, "BillStatusName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_Bill", 10, "DealerID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_Bill", 11, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_Bill", 12, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerSpell
		{
			get { return new EntityField("BUS_Bill", 13, "DealerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerAddress
		{
			get { return new EntityField("BUS_Bill", 14, "DealerAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPerson
		{
			get { return new EntityField("BUS_Bill", 15, "BusinessPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPersonSpell
		{
			get { return new EntityField("BUS_Bill", 16, "BusinessPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessPhone
		{
			get { return new EntityField("BUS_Bill", 17, "BusinessPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DeliveryTypeID
		{
			get { return new EntityField("BUS_Bill", 18, "DeliveryTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DeliveryTypeName
		{
			get { return new EntityField("BUS_Bill", 19, "DeliveryTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TransportID
		{
			get { return new EntityField("BUS_Bill", 20, "TransportID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField TransportCode
		{
			get { return new EntityField("BUS_Bill", 21, "TransportCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PaymentTypeID
		{
			get { return new EntityField("BUS_Bill", 22, "PaymentTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PaymentTypeName
		{
			get { return new EntityField("BUS_Bill", 23, "PaymentTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TotalPrice
		{
			get { return new EntityField("BUS_Bill", 24, "TotalPrice", SqlDbType.Float, false, false, false, true); }
		}

		public static EntityField PaymentDate
		{
			get { return new EntityField("BUS_Bill", 25, "PaymentDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField InvoiceTypeID
		{
			get { return new EntityField("BUS_Bill", 26, "InvoiceTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField InvoiceTypeName
		{
			get { return new EntityField("BUS_Bill", 27, "InvoiceTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InvoiceTitle
		{
			get { return new EntityField("BUS_Bill", 28, "InvoiceTitle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InvoiceContent
		{
			get { return new EntityField("BUS_Bill", 29, "InvoiceContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Operator
		{
			get { return new EntityField("BUS_Bill", 30, "Operator", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField OperatorSpell
		{
			get { return new EntityField("BUS_Bill", 31, "OperatorSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContractNo
		{
			get { return new EntityField("BUS_Bill", 32, "ContractNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContractContent
		{
			get { return new EntityField("BUS_Bill", 33, "ContractContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField SaleBillID
		{
			get { return new EntityField("BUS_Bill", 34, "SaleBillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField SaleBillCode
		{
			get { return new EntityField("BUS_Bill", 35, "SaleBillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReviewID
		{
			get { return new EntityField("BUS_Bill", 36, "ReviewID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReviewCode
		{
			get { return new EntityField("BUS_Bill", 37, "ReviewCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreOutID
		{
			get { return new EntityField("BUS_Bill", 38, "StoreOutID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StoreOutCode
		{
			get { return new EntityField("BUS_Bill", 39, "StoreOutCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PurchaseBillID
		{
			get { return new EntityField("BUS_Bill", 40, "PurchaseBillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PurchaseBillCode
		{
			get { return new EntityField("BUS_Bill", 41, "PurchaseBillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ReceiveID
		{
			get { return new EntityField("BUS_Bill", 42, "ReceiveID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ReceiveCode
		{
			get { return new EntityField("BUS_Bill", 43, "ReceiveCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AcceptID
		{
			get { return new EntityField("BUS_Bill", 44, "AcceptID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField AcceptCode
		{
			get { return new EntityField("BUS_Bill", 45, "AcceptCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StoreInID
		{
			get { return new EntityField("BUS_Bill", 46, "StoreInID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField StoreInCode
		{
			get { return new EntityField("BUS_Bill", 47, "StoreInCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PickUpPerson
		{
			get { return new EntityField("BUS_Bill", 48, "PickUpPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PickUpPersonSpell
		{
			get { return new EntityField("BUS_Bill", 49, "PickUpPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductAmount
		{
			get { return new EntityField("BUS_Bill", 50, "ProductAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DepartmentID
		{
			get { return new EntityField("BUS_Bill", 51, "DepartmentID", SqlDbType.Int, false, false, false, true); }
        }

        public static EntityField PurchasePriceListID
        {
            get
            {
                return new EntityField("BUS_Bill", 52, "PurchasePriceListID", SqlDbType.Int, false, false, false, true);
            }
        }

        public static EntityField SalePriceListID
        {
            get
            {
                return new EntityField("BUS_Bill", 53, "SalePriceListID", SqlDbType.Int, false, false, false, true);
            }
        }

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_Bill", 54, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_Bill", 55, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_Bill", 56, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_Bill", 57, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField BillRemark
		{
			get { return new EntityField("BUS_Bill", 58, "BillRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_Bill", 59, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_Bill", 60, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_Bill", 61, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_Bill", 62, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_Bill", 63, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_Bill", 64, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_Bill", 65, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_Bill", 66, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_Bill", 67, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_Bill", 68, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSBillEntityFields2

	public enum BUSBillEntityFields2
	{
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

        DepartmentID,

        PurchasePriceListID,

        SalePriceListID,

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

	}

	#endregion

}
