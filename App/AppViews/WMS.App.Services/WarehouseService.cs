using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class WarehouseService : IWarehouseService
    {
        public List<Warehouse> GetAllWarehouses()
        {
            using (var db = new WMSContext())
            {
                return db.Warehouses.AsNoTracking().ToList();
            }
        }

        public List<Warehouse> SearchWarehouses()
        {
            using (var db = new WMSContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public Warehouse GetWarehouse(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.Warehouses.Find(entityId);
                if (trackedEntity != null)
                {
                    return trackedEntity;
                }
            }
            return null;
        }

        public Warehouse SaveWarehouse(Warehouse entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.Warehouses.Find(entity.WarehouseID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.Warehouses.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteWarehouse(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.Warehouses.Find(entityId);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).State = EntityState.Deleted;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }
    }
}
