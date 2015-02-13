﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WMSContext : DbContext
    {
        public WMSContext()
            : base("name=WMSContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ElectronicLabel> ElectronicLabels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductStructure> ProductStructures { get; set; }
        public DbSet<StorageStructure> StorageStructures { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<CargoSpaceStoreDetail> CargoSpaceStoreDetails { get; set; }
        public DbSet<InventoryDemolition> InventoryDemolitions { get; set; }
        public DbSet<StoreInHistory> StoreInHistories { get; set; }
        public DbSet<StoreOutHistory> StoreOutHistories { get; set; }
        public DbSet<LabelStructure> LabelStructures { get; set; }
        public DbSet<LabelTask> LabelTasks { get; set; }
        public DbSet<StoreBill> StoreBills { get; set; }
        public DbSet<StoreBillBarCode> StoreBillBarCodes { get; set; }
        public DbSet<StoreBillDetail> StoreBillDetails { get; set; }
        public DbSet<WMSStoreBillDetail> WMSStoreBillDetails { get; set; }
        public DbSet<PDATask> PDATasks { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewDetail> ReviewDetails { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<RegulatoryCode> RegulatoryCodes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<StoreDetail> StoreDetails { get; set; }
        public DbSet<WMSUser> WMSUsers { get; set; }
        public DbSet<WMSStoreInDetail> WMSStoreInDetails { get; set; }
        public DbSet<UnqualifiedStoreDetail> UnqualifiedStoreDetails { get; set; }
        public DbSet<InventoryStatistic> InventoryStatistics { get; set; }
        public DbSet<InventoryStatisticDetail> InventoryStatisticDetails { get; set; }
        public DbSet<WMSReviewHistory> WMSReviewHistories { get; set; }
    }
}
