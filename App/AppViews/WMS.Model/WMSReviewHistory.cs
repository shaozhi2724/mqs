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
    
    public partial class WMSReviewHistory
    {
        public int ReviewHistoryID { get; set; }
        public int ReviewID { get; set; }
        public int DetailID { get; set; }
        public int ProductID { get; set; }
        public string BatchNo { get; set; }
        public Nullable<System.DateTime> ProduceDate { get; set; }
        public Nullable<System.DateTime> ValidateDate { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> ReviewAmount { get; set; }
        public string ReviewResult { get; set; }
        public Nullable<System.Guid> CreateUserID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> LastModifyUserID { get; set; }
        public Nullable<System.DateTime> LastModifyDate { get; set; }
    }
}
