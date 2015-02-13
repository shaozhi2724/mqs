//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int BillID { get; set; }
        public string BillCode { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<bool> IsBillIn { get; set; }
        public int BillTypeID { get; set; }
        public string BillTypeName { get; set; }
        public string BillTypeSpell { get; set; }
        public Nullable<int> BillStatus { get; set; }
        public string BillStatusName { get; set; }
        public int DealerID { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public string DealerSpell { get; set; }
        public string DealerAddress { get; set; }
        public string BusinessPerson { get; set; }
        public string BusinessPersonSpell { get; set; }
        public string BusinessPhone { get; set; }
        public Nullable<int> DeliveryTypeID { get; set; }
        public string DeliveryTypeName { get; set; }
        public Nullable<int> TransportID { get; set; }
        public string TransportCode { get; set; }
        public Nullable<int> PaymentTypeID { get; set; }
        public string PaymentTypeName { get; set; }
        public Nullable<double> TotalPrice { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<int> InvoiceTypeID { get; set; }
        public string InvoiceTypeName { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceContent { get; set; }
        public string Operator { get; set; }
        public string OperatorSpell { get; set; }
        public string ContractNo { get; set; }
        public string ContractContent { get; set; }
        public Nullable<int> SaleBillID { get; set; }
        public string SaleBillCode { get; set; }
        public Nullable<int> ReviewID { get; set; }
        public string ReviewCode { get; set; }
        public Nullable<int> StoreOutID { get; set; }
        public string StoreOutCode { get; set; }
        public Nullable<int> PurchaseBillID { get; set; }
        public string PurchaseBillCode { get; set; }
        public Nullable<int> ReceiveID { get; set; }
        public string ReceiveCode { get; set; }
        public Nullable<int> AcceptID { get; set; }
        public string AcceptCode { get; set; }
        public Nullable<int> StoreInID { get; set; }
        public string StoreInCode { get; set; }
        public Nullable<System.Guid> CreateUserID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> LastModifyUserID { get; set; }
        public Nullable<System.DateTime> LastModifyDate { get; set; }
        public string BillRemark { get; set; }
        public string Reservation1 { get; set; }
        public string Reservation2 { get; set; }
        public string Reservation3 { get; set; }
        public string Reservation4 { get; set; }
        public string Reservation5 { get; set; }
        public string Reservation6 { get; set; }
        public string Reservation7 { get; set; }
        public string Reservation8 { get; set; }
        public string Reservation9 { get; set; }
        public string Reservation10 { get; set; }
        public string BillStyle { get; set; }
    }
}
