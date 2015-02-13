using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class CargoSpaceStoreDetailService : ICargoSpaceStoreDetailService
    {
        public List<CargoSpaceStoreDetail> GetAllCargoSpaceStoreDetails()
        {
            using (var db = new WMSContext())
            {
                return db.CargoSpaceStoreDetails.ToList();
            }
        }

        public List<CargoSpaceStoreDetail> SearchCargoSpaceStoreDetails()
        {
            using (var db = new WMSContext())
            {
                return db.CargoSpaceStoreDetails.ToList();
            }
        }

        public CargoSpaceStoreDetail SaveCargoSpaceStoreDetail(CargoSpaceStoreDetail entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(entity.ProductID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.CargoSpaceStoreDetails.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteCargoSpaceStoreDetail(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(entityId);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).State = EntityState.Deleted;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }

        public bool UpdateBatchNo(int detailId, string oldBatchNo, string newBatchNo)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(detailId);
                if (trackedEntity != null)
                {
                    trackedEntity.ProductBatchNumber = newBatchNo;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }

        public bool UpdateBatchNo(int detailId, string oldBatchNo, string newBatchNo, DateTime productionDate, DateTime validDate)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(detailId);
                if (trackedEntity != null)
                {
                    trackedEntity.ProductBatchNumber = newBatchNo;
                    trackedEntity.ProductionDate = productionDate;
                    trackedEntity.ProductValidDate = validDate;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }

        public bool UpdateBatchNoAndAmount(int detailId, string oldBatchNo, string newBatchNo, int oldAmount, int newAmount,
            DateTime productionDate, DateTime validDate)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.CargoSpaceStoreDetails.Find(detailId);
                if (trackedEntity != null)
                {
                    trackedEntity.ProductAmount = newAmount;
                    trackedEntity.ProductBatchNumber = newBatchNo;
                    trackedEntity.ProductionDate = productionDate;
                    trackedEntity.ProductValidDate = validDate;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }

        public void CleanStore()
        {
            using (var db = new WMSContext())
            {
                var storeDetails = db.CargoSpaceStoreDetails.Where(p => p.ProductAmount <= 0);
                foreach (var cargoSpaceStoreDetail in storeDetails)
                {
                    db.CargoSpaceStoreDetails.Remove(cargoSpaceStoreDetail);
                }
                db.SaveChanges();
            }
        }
    }
}