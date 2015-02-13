using System;
using System.Collections.Generic;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class InventoryService : IInventoryService
    {
        public List<InventoryViewModel> SearchInventory(string structureCode, string productName, string batchNumber, string areaType)
        {
            using (var db = new WMSContext())
            {
                var products = from ssd in db.CargoSpaceStoreDetails
                    join s in db.StorageStructures on ssd.StructureID equals s.StructureID
                    join p in db.Products on ssd.ProductID equals p.ProductID
                    select new InventoryViewModel
                    {
                        AreaType = s.AreaType,
                        CargoSpaceStoreDetailID = ssd.CargoSpaceStoreDetailID,
                        ProductID = p.ProductID,
                        StructureCode = s.StructureCode,
                        StructureName = s.StructureName,
                        StructureLocation = s.StructureLocation,
                        ProductCode = p.ProductCode,
                        ProductName = p.ProductName,
                        ProductBarCode = p.ProductBarCode,
                        ProducerName = p.ProducerName,
                        ProductSpell = p.ProductSpell,
                        ProductSpec = p.ProductSpec,
                        PackageSpec = p.PackageSpec,
                        PackagingProportion = p.PackagingProportion,
                        ProductBatchNumber = ssd.ProductBatchNumber,
                        ProductAmount = ssd.ProductAmount,
                        ProductionDate = ssd.ProductionDate,
                        ProductValidDate = ssd.ProductValidDate,
                        StockCondition = p.StockCondition,
                        PhysicType = p.PhysicType,
                        AuthorizedNo = p.AuthorizedNo
                    };
                if (!string.IsNullOrWhiteSpace(areaType))
                {
                    if (areaType == "合格品")
                    {
                        products = products.Where(p => p.AreaType.Contains("整货") || p.AreaType.Contains("零货"));
                    }
                    else
                    {
                        products = products.Where(p => p.AreaType.Contains(areaType));
                    }
                }
                if (!string.IsNullOrWhiteSpace(productName))
                {
                    products = products.Where(p => p.ProductName.Contains(productName) || p.ProductSpell.Contains(productName));
                }
                if (!string.IsNullOrWhiteSpace(structureCode))
                {
                    products = products.Where(p => p.StructureCode.Contains(structureCode) || p.StructureName.Contains(structureCode));
                }
                if (!string.IsNullOrWhiteSpace(batchNumber))
                {
                    products = products.Where(p => p.ProductBatchNumber.Contains(batchNumber));
                }
                return products.ToList();
            }
        }

        public bool GenerateBusinessInventory()
        {
            using (var db = new WMSContext())
            {
                var data = from s in db.CargoSpaceStoreDetails
                           join ss in db.StorageStructures on s.StructureID equals ss.StructureID
                           where !ss.AreaType.Contains("不合格") && !ss.AreaType.Contains("退货")
                           select new
                           {
                               s.CargoSpaceStoreDetailID,
                               s.ProductID,
                               s.ProductBatchNumber,
                               s.ProductionDate,
                               s.ProductValidDate,
                               s.ProductAmount,
                               ss.AreaType
                           };
                var inventories = (from s in data
                                   group s by new { s.ProductID, s.ProductBatchNumber } into g
                                   select new
                                   {
                                       ProductID = g.Key.ProductID.Value,
                                       BatchNo = g.Key.ProductBatchNumber,
                                       ProduceDate = g.FirstOrDefault().ProductionDate,
                                       ValidateDate = g.FirstOrDefault().ProductValidDate,
                                       Amount = g.Sum(p => p.ProductAmount)
                                   }).ToList();
                var storeDetails = db.StoreDetails.ToList();
                foreach (var inventory in inventories)
                {
                    var businessStore = storeDetails.FirstOrDefault(p => p.ProductID == inventory.ProductID && p.BatchNo == inventory.BatchNo);
                    if (null == businessStore)
                    {
                        db.StoreDetails.Add(new StoreDetail{
                            ProductID = inventory.ProductID,
                            BatchNo = inventory.BatchNo,
                            Amount =  inventory.Amount,
                            ProduceDate = inventory.ProduceDate,
                            ValidateDate = inventory.ValidateDate,
                            CreateDate = DateTime.Now
                        });
                    }
                    else
                    {
                        businessStore.Amount = inventory.Amount;
                        businessStore.LastModifyDate = DateTime.Now;
                    }
                }

                foreach (var storeDetail in storeDetails)
                {
                    var inventory = inventories.FirstOrDefault(p => p.ProductID == storeDetail.ProductID && p.BatchNo == storeDetail.BatchNo);
                    if (null == inventory)
                    {
                        //db.StoreDetails.Remove(storeDetail);
                        storeDetail.Amount = 0;
                    }
                }
                try
                {
                    db.SaveChanges();

                    return GenerateUnqualifiedBusinessInventory();
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public void UpdateCargoStoreAmountAndBusinessAmount(int inventoryStatisticId, bool updateBusinessInventory)
        {
            using (var db = new WMSContext())
            {
                List<InventoryStatisticDetail> details =
                    db.InventoryStatisticDetails.Where(p => p.InventoryStatisticID == inventoryStatisticId).ToList();

                var cargoSpaceStoreDetails = (from isd in db.InventoryStatisticDetails
                    join csd in db.CargoSpaceStoreDetails on isd.StructureID equals csd.StructureID
                    where isd.InventoryStatisticID == inventoryStatisticId
                    select csd).ToList();
                foreach (var cargoSpaceStoreDetail in cargoSpaceStoreDetails)
                {
                    var detail =
                        details.FirstOrDefault(
                            p => p.CargoSpaceStoreDetailID == cargoSpaceStoreDetail.CargoSpaceStoreDetailID);
                    if (null != detail)
                    {
                        cargoSpaceStoreDetail.ProductAmount = detail.VerifiedProductAmount;
                    }
                }
                if (updateBusinessInventory)
                {
                    GenerateBusinessInventory();
                }

                var statistics = db.InventoryStatistics.Find(inventoryStatisticId);
                if (null != statistics)
                {
                    statistics.StatusID = 4;
                    statistics.StatusName = "已处理";
                    db.SaveChanges();
                }
            }
        }

        public void CompleteTaskManually(int inventoryStatisticId)
        {
            using (var db = new WMSContext())
            {
                string tempSql = @"UPDATE WMS_InventoryStatisticDetail SET VerifiedProductAmount=ISNULL(ProductAmount,0),StatusID=3,StatusName='完成盘点',VerifiedDate=GETDATE() WHERE InventoryStatisticID={0} AND StatusID < 3
UPDATE dbo.WMS_InventoryStatistic SET StatusID=3,StatusName='完成盘点' WHERE InventoryStatisticID={0}
";
                string sql = string.Format(tempSql,inventoryStatisticId);
                db.Database.ExecuteSqlCommand(sql);
            }
        }

        public bool GenerateUnqualifiedBusinessInventory()
        {
            using (var db = new WMSContext())
            {
                var data = from s in db.CargoSpaceStoreDetails
                           join ss in db.StorageStructures on s.StructureID equals ss.StructureID
                           where ss.AreaType.Contains("不合格")
                           select new
                           {
                               s.CargoSpaceStoreDetailID,
                               s.ProductID,
                               s.ProductBatchNumber,
                               s.ProductionDate,
                               s.ProductValidDate,
                               s.ProductAmount,
                               ss.AreaType
                           };
                var inventories = (from s in data
                                   group s by new { s.ProductID, s.ProductBatchNumber } into g
                                   select new
                                   {
                                       ProductID = g.Key.ProductID.Value,
                                       BatchNo = g.Key.ProductBatchNumber,
                                       ProduceDate = g.FirstOrDefault().ProductionDate,
                                       ValidateDate = g.FirstOrDefault().ProductValidDate,
                                       Amount = g.Sum(p => p.ProductAmount)
                                   }).ToList();
                var storeDetails = db.UnqualifiedStoreDetails.ToList();
                foreach (var inventory in inventories)
                {
                    var businessStore = storeDetails.FirstOrDefault(p => p.ProductID == inventory.ProductID && p.BatchNo == inventory.BatchNo);
                    if (null == businessStore)
                    {
                        db.UnqualifiedStoreDetails.Add(new UnqualifiedStoreDetail{
                            ProductID = inventory.ProductID,
                            BatchNo = inventory.BatchNo,
                            Amount =  inventory.Amount,
                            ProduceDate = inventory.ProduceDate,
                            ValidateDate = inventory.ValidateDate,
                            CreateDate = DateTime.Now
                        });
                    }
                    else
                    {
                        businessStore.Amount = inventory.Amount;
                        businessStore.LastModifyDate = DateTime.Now;
                    }
                }

                foreach (var storeDetail in storeDetails)
                {
                    var inventory = inventories.FirstOrDefault(p => p.ProductID == storeDetail.ProductID && p.BatchNo == storeDetail.BatchNo);
                    if (null == inventory)
                    {
                        //db.StoreDetails.Remove(storeDetail);
                        storeDetail.Amount = 0;
                    }
                }
                int result = db.SaveChanges();
                if (!inventories.Any())
                {
                    return true;
                }
                return result > 0;
            }
        }
    }
}