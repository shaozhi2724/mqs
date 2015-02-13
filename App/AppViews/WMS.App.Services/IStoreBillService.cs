using System;
using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IStoreBillService
    {
        List<StoreBill> GetAllStoreOutBills();
        List<StoreBill> GetAllProcessingStoreOutBills();
        StoreBill GetStoreBill(int storeId);
        StoreBill GetStoreBillByCode(string storeCode);
        List<OutDetail> SplitStoreOutBillDetails(int storeID);
        List<StoreInBillDetailViewModel> SplitStoreInBillDetails(int storeId);
        List<StoreInBillDetailViewModel> SplitStoreInBillDetails(int storeId, bool systemSignPosition, bool printCargoBarcode);
        void UpdateStoreBillDetailStatus(string storeCode, Guid wmsDetailID,
            StoreBillStatuses storeBillStatus);
        void UpdateStoreBillStatus(string storeCode, StoreBillStatuses storeBillStatus);
        void UpdateStoreBillStatus(int storeId, StoreBillStatuses storeBillStatus);
        void UpdateStoreInBillStatus(int storeId, StoreBillStatuses storeBillStatus);
        void CheckRegulatoryCode(bool allowNoCodeStoreIn, string storeCode);
        void RelateRegulatoryCode(bool allowNoCodeStoreIn, string storeCode);
        List<StoreBillDetailViewModel> GetStoreBillDetails(int storeId);
        List<StoreInBillDetailViewModel> GetStoreInDetails(int storeId);
        List<StoreInBillDetailViewModel> GetStoreBillInDetails(int storeId);
        List<StoreBill> GetAllStoreInBills();
        List<StoreBill> GetAllCompletedStoreOutBills();
        List<StoreBill> GetAllNotReviewedCompletedStoreOutBills();
        void UpdateCargoSpaceAmount(int billDetailId, int structureId, int productId, string batchNo, int amount);
        List<StoreBillOutDetailViewModel> GetAllStoreOutBillsByProductBarCode(string barcode);
        List<StoreBillOutDetailViewModel> GetAllCompletedStoreOutBillDetails(int storeId);

        List<StoreBill> SearchStoreHistories(string storeCode, int storeTypeId, string dealerName, DateTime startDate,
            DateTime endDate, bool isStoreIn);

        void ManuallyCompleteOutTask(int detailId);
        void CheckAndFixStoreOutBillStatus();
        List<InventoryDetailViewModel> GetAllInventoryDetails();
        bool GenerateInventoryStatisticTask(string taskCode, DateTime startDate, DateTime endDate, Guid userId);
        List<InventoryStatistic> SearchInventoryStatisticTasks(string inventoryStatisCode, DateTime startDate, DateTime endDate);
        List<InventoryStatisticDetail> GetInventoryStatisticDetails(int inventoryStatisticId);
        List<InventoryStatistic> SearchInventoryStatisticHistories(string inventoryStatisCode, DateTime startDate, DateTime endDate);
    }
}