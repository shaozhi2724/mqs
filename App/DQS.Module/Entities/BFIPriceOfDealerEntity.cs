using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
    public class BFIPriceOfDealerEntity : EntityBase
    {
        public int PriceID
        {
            get { return (int)this.GetValue("PriceID"); }
            set { this.SetValue("PriceID", value); }
        }
        public int DealerID
        {
            get { return (int)this.GetValue("DealerID"); }
            set { this.SetValue("DealerID", value); }
        }
        public int ProductID
        {
            get { return (int)this.GetValue("ProductID"); }
            set { this.SetValue("ProductID", value); }
        }
        public double UnitPrice
        {
            get { return (double)this.GetValue("UnitPrice"); }
            set { this.SetValue("UnitPrice", value); }
        }
        public double TradePrice
        {
            get { return (double)this.GetValue("TradePrice"); }
            set { this.SetValue("TradePrice", value); }
        }
        public double RetailPrice
        {
            get { return (double)this.GetValue("RetailPrice"); }
            set { this.SetValue("RetailPrice", value); }
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

        public BFIPriceOfDealerEntity()
        {
            this.TableName = "BFI_PriceOfDealer";
            this.Fields = new Dictionary<string, EntityField>();
            this.Fields.Add("PriceID", BFIPriceOfDealerEntityFields.PriceID);
            this.Fields.Add("DealerID", BFIPriceOfDealerEntityFields.DealerID);
            this.Fields.Add("ProductID", BFIPriceOfDealerEntityFields.ProductID);
            this.Fields.Add("UnitPrice", BFIPriceOfDealerEntityFields.UnitPrice);
            this.Fields.Add("TradePrice", BFIPriceOfDealerEntityFields.TradePrice);
            this.Fields.Add("RetailPrice", BFIPriceOfDealerEntityFields.RetailPrice);
            this.Fields.Add("CreateUserID", BFIPriceOfDealerEntityFields.CreateUserID);
            this.Fields.Add("CreateDate", BFIPriceOfDealerEntityFields.CreateDate);
            this.Fields.Add("LastModifyUserID", BFIPriceOfDealerEntityFields.LastModifyUserID);
            this.Fields.Add("LastModifyDate", BFIPriceOfDealerEntityFields.LastModifyDate);
        }
    }

    #region BFIPriceOfDealerEntityFields
    public class BFIPriceOfDealerEntityFields
    {
        public static EntityField PriceID
        {
            get { return new EntityField("BFI_PriceOfDealer", 0, "PriceID", SqlDbType.Int, true, true, true, false); }
        }

        public static EntityField DealerID
        {
            get { return new EntityField("BFI_PriceOfDealer", 1, "DealerID", SqlDbType.Int, false, false, true, false); }
        }

        public static EntityField ProductID
        {
            get { return new EntityField("BFI_PriceOfDealer", 2, "ProductID", SqlDbType.Int, false, false, false, false); }
        }

        public static EntityField UnitPrice
        {
            get { return new EntityField("BFI_PriceOfDealer", 3, "UnitPrice", SqlDbType.Float, false, false, false, true); }
        }

        public static EntityField TradePrice
        {
            get { return new EntityField("BFI_PriceOfDealer", 4, "TradePrice", SqlDbType.Float, false, false, false, false); }
        }

        public static EntityField RetailPrice
        {
            get { return new EntityField("BFI_PriceOfDealer", 5, "RetailPrice", SqlDbType.Float, false, false, false, true); }
        }
        public static EntityField CreateUserID
        {
            get { return new EntityField("BFI_PriceOfDealer", 6, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
        }

        public static EntityField CreateDate
        {
            get { return new EntityField("BFI_PriceOfDealer", 7, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
        }

        public static EntityField LastModifyUserID
        {
            get { return new EntityField("BFI_PriceOfDealer", 8, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
        }

        public static EntityField LastModifyDate
        {
            get { return new EntityField("BFI_PriceOfDealer", 9, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
        }

    }

    #endregion

    #region BFIPriceOfDealerEntityFields2

    public enum BFIPriceOfDealerEntityFields2
    {
        PriceID,

        DealerID,

        ProductID,

        UnitPrice,

        TradePrice,

        RetailPrice,

        CreateUserID,

        CreateDate,

        LastModifyUserID,

        LastModifyDate,
    }

    #endregion


}
