using System.Collections.Generic;

namespace WMS.App.Services
{
    public interface IInventoryService
    {
        List<InventoryViewModel> SearchInventory(string structureCode, string productName, string batchNumber, string areaType);
        bool GenerateBusinessInventory();
        void UpdateCargoStoreAmountAndBusinessAmount(int inventoryStatisticId, bool updateBusinessInventory);
        void CompleteTaskManually(int inventoryStatisticId);
    }
}