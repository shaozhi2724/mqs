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
    
    public partial class StoreDetail
    {
        public int StoreDetailID { get; set; }
        public int ProductID { get; set; }
        public string BatchNo { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> ValidateDate { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> CreateStoreID { get; set; }
        public string CreateStoreCode { get; set; }
        public Nullable<int> LastStoreID { get; set; }
        public string LastStoreCode { get; set; }
        public Nullable<System.DateTime> LastCuringDate { get; set; }
        public Nullable<System.Guid> CreateUserID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> LastModifyUserID { get; set; }
        public Nullable<System.DateTime> LastModifyDate { get; set; }
        public string DetailRemark { get; set; }
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
    }
}
