/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-02-01 12:24:10
 *	Build Type: Entity
 *	Description: BUSCuringRecordEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSCuringRecordEntity : EntityBase
	{
		public int CuringID
		{
			get { return (int)this.GetValue("CuringID"); } 
			set { this.SetValue("CuringID", value); } 
		}

		public string CuringCode
		{
			get { return (string)this.GetValue("CuringCode"); } 
			set { this.SetValue("CuringCode", value); } 
		}

		public string PlanCode
		{
			get { return (string)this.GetValue("PlanCode"); } 
			set { this.SetValue("PlanCode", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string BatchNo
		{
			get { return (string)this.GetValue("BatchNo"); } 
			set { this.SetValue("BatchNo", value); } 
		}

		public DateTime ProduceDate
		{
			get { return (DateTime)this.GetValue("ProduceDate"); } 
			set { this.SetValue("ProduceDate", value); } 
		}

		public DateTime ValidateDate
		{
			get { return (DateTime)this.GetValue("ValidateDate"); } 
			set { this.SetValue("ValidateDate", value); }
        }

        public string SterilizationBatchNo
        {
            get { return (string)this.GetValue("SterilizationBatchNo"); }
            set { this.SetValue("SterilizationBatchNo", value); }
        }

        public DateTime SterilizationDate
        {
            get { return (DateTime)this.GetValue("SterilizationDate"); }
            set { this.SetValue("SterilizationDate", value); }
        }

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
		}

		public int QualifiedAmount
		{
			get { return (int)this.GetValue("QualifiedAmount"); } 
			set { this.SetValue("QualifiedAmount", value); } 
		}

		public int UnqualifiedAmount
		{
			get { return (int)this.GetValue("UnqualifiedAmount"); } 
			set { this.SetValue("UnqualifiedAmount", value); } 
		}

		public string CuringMan
		{
			get { return (string)this.GetValue("CuringMan"); } 
			set { this.SetValue("CuringMan", value); } 
		}

		public string CuringManSpell
		{
			get { return (string)this.GetValue("CuringManSpell"); } 
			set { this.SetValue("CuringManSpell", value); } 
		}

		public int CuringDays
		{
            get { return (int)this.GetValue("CuringDays"); }
            set { this.SetValue("CuringDays", value); } 
		}

		public DateTime CheckDate
		{
			get { return (DateTime)this.GetValue("CheckDate"); } 
			set { this.SetValue("CheckDate", value); } 
		}

		public string CheckItem
		{
            get
            {
                return IsNullField("CheckItem") ? "" : (string)this.GetValue("CheckItem");
            } 
			set { this.SetValue("CheckItem", value); } 
		}

		public string QualityCondition
		{
            get
            {
                return IsNullField("QualityCondition") ? "" : (string)this.GetValue("QualityCondition");
            } 
			set { this.SetValue("QualityCondition", value); } 
		}

		public string CuringMeasure
		{
            get
            {
                return IsNullField("CuringMeasure") ? "" : (string)this.GetValue("CuringMeasure");
            } 
			set { this.SetValue("CuringMeasure", value); } 
		}

		public string CuringResult
		{
            get
            {
                return IsNullField("CuringResult") ? "" : (string)this.GetValue("CuringResult");
            } 
			set { this.SetValue("CuringResult", value); } 
		}

        public int InStoreID
		{
            get { return (int)this.GetValue("InStoreID"); }
            set { this.SetValue("InStoreID", value); } 
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

		public string CuringRemrk
		{
			get { return (string)this.GetValue("CuringRemrk"); } 
			set { this.SetValue("CuringRemrk", value); } 
		}

		public string Reservation1
		{
			get { return (string)this.GetValue("Reservation1"); } 
			set { this.SetValue("Reservation1", value); } 
		}

		public string Reservation2
		{
			get { return (string)this.GetValue("Reservation2"); } 
			set { this.SetValue("Reservation2", value); } 
		}

		public string Reservation3
		{
			get { return (string)this.GetValue("Reservation3"); } 
			set { this.SetValue("Reservation3", value); } 
		}

		public string Reservation4
		{
			get { return (string)this.GetValue("Reservation4"); } 
			set { this.SetValue("Reservation4", value); } 
		}

		public string Reservation5
		{
			get { return (string)this.GetValue("Reservation5"); } 
			set { this.SetValue("Reservation5", value); } 
		}

		public string Reservation6
		{
			get { return (string)this.GetValue("Reservation6"); } 
			set { this.SetValue("Reservation6", value); } 
		}

		public string Reservation7
		{
			get { return (string)this.GetValue("Reservation7"); } 
			set { this.SetValue("Reservation7", value); } 
		}

		public string Reservation8
		{
			get { return (string)this.GetValue("Reservation8"); } 
			set { this.SetValue("Reservation8", value); } 
		}

		public string Reservation9
		{
			get { return (string)this.GetValue("Reservation9"); } 
			set { this.SetValue("Reservation9", value); } 
		}

		public string Reservation10
		{
			get { return (string)this.GetValue("Reservation10"); } 
			set { this.SetValue("Reservation10", value); } 
		}

		public BUSCuringRecordEntity()
		{
			this.TableName = "BUS_CuringRecord";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("CuringID", BUSCuringRecordEntityFields.CuringID);
			this.Fields.Add("CuringCode", BUSCuringRecordEntityFields.CuringCode);
			this.Fields.Add("PlanCode", BUSCuringRecordEntityFields.PlanCode);
			this.Fields.Add("ProductID", BUSCuringRecordEntityFields.ProductID);
			this.Fields.Add("BatchNo", BUSCuringRecordEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSCuringRecordEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSCuringRecordEntityFields.ValidateDate);
            this.Fields.Add("SterilizationBatchNo", BUSCuringRecordEntityFields.SterilizationBatchNo);
            this.Fields.Add("SterilizationDate", BUSCuringRecordEntityFields.SterilizationDate);
			this.Fields.Add("Amount", BUSCuringRecordEntityFields.Amount);
			this.Fields.Add("QualifiedAmount", BUSCuringRecordEntityFields.QualifiedAmount);
			this.Fields.Add("UnqualifiedAmount", BUSCuringRecordEntityFields.UnqualifiedAmount);
			this.Fields.Add("CuringMan", BUSCuringRecordEntityFields.CuringMan);
			this.Fields.Add("CuringManSpell", BUSCuringRecordEntityFields.CuringManSpell);
            this.Fields.Add("CuringDays", BUSCuringRecordEntityFields.CuringDays);
			this.Fields.Add("CheckDate", BUSCuringRecordEntityFields.CheckDate);
			this.Fields.Add("CheckItem", BUSCuringRecordEntityFields.CheckItem);
			this.Fields.Add("QualityCondition", BUSCuringRecordEntityFields.QualityCondition);
			this.Fields.Add("CuringMeasure", BUSCuringRecordEntityFields.CuringMeasure);
			this.Fields.Add("CuringResult", BUSCuringRecordEntityFields.CuringResult);
            this.Fields.Add("InStoreID", BUSCuringRecordEntityFields.InStoreID);
			this.Fields.Add("CreateUserID", BUSCuringRecordEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSCuringRecordEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSCuringRecordEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSCuringRecordEntityFields.LastModifyDate);
			this.Fields.Add("CuringRemrk", BUSCuringRecordEntityFields.CuringRemrk);
			this.Fields.Add("Reservation1", BUSCuringRecordEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSCuringRecordEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSCuringRecordEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSCuringRecordEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSCuringRecordEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSCuringRecordEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSCuringRecordEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSCuringRecordEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSCuringRecordEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSCuringRecordEntityFields.Reservation10);
		}
	}

	#region BUSCuringRecordEntityFields

	public class BUSCuringRecordEntityFields
	{
		public static EntityField CuringID
		{
			get { return new EntityField("BUS_CuringRecord", 0, "CuringID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField CuringCode
		{
			get { return new EntityField("BUS_CuringRecord", 1, "CuringCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField PlanCode
		{
            get { return new EntityField("BUS_CuringRecord", 2, "PlanCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_CuringRecord", 3, "ProductID", SqlDbType.Int, false, false, false, false); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_CuringRecord", 4, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_CuringRecord", 5, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_CuringRecord", 6, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

        public static EntityField SterilizationBatchNo
		{
            get { return new EntityField("BUS_CuringRecord", 7, "SterilizationBatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField SterilizationDate
		{
            get { return new EntityField("BUS_CuringRecord", 8, "SterilizationDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_CuringRecord", 9, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField QualifiedAmount
		{
			get { return new EntityField("BUS_CuringRecord", 10, "QualifiedAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField UnqualifiedAmount
		{
			get { return new EntityField("BUS_CuringRecord", 11, "UnqualifiedAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CuringMan
		{
			get { return new EntityField("BUS_CuringRecord", 12, "CuringMan", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CuringManSpell
		{
			get { return new EntityField("BUS_CuringRecord", 13, "CuringManSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField CuringDays
		{
            get { return new EntityField("BUS_CuringRecord", 14, "CuringDays", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField CheckDate
		{
			get { return new EntityField("BUS_CuringRecord", 15, "CheckDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CheckItem
		{
			get { return new EntityField("BUS_CuringRecord", 16, "CheckItem", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField QualityCondition
		{
			get { return new EntityField("BUS_CuringRecord", 17, "QualityCondition", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CuringMeasure
		{
			get { return new EntityField("BUS_CuringRecord", 18, "CuringMeasure", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CuringResult
		{
			get { return new EntityField("BUS_CuringRecord", 19, "CuringResult", SqlDbType.NVarChar, false, false, false, true); }
		}

        public static EntityField InStoreID
        {
            get { return new EntityField("BUS_CuringRecord", 20, "InStoreID", SqlDbType.Int, false, false, false, true); }
        }

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_CuringRecord", 21, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_CuringRecord", 22, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_CuringRecord", 23, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_CuringRecord", 24, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField CuringRemrk
		{
			get { return new EntityField("BUS_CuringRecord", 25, "CuringRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_CuringRecord", 26, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_CuringRecord", 27, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_CuringRecord", 28, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_CuringRecord", 29, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_CuringRecord", 30, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_CuringRecord", 31, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_CuringRecord", 32, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_CuringRecord", 33, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_CuringRecord", 34, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_CuringRecord", 35, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSCuringRecordEntityFields2

	public enum BUSCuringRecordEntityFields2
	{
		CuringID,

		CuringCode,

		PlanCode,

		ProductID,

		BatchNo,

		ProduceDate,

		ValidateDate,

        SterilizationBatchNo,

        SterilizationDate,

		Amount,

		QualifiedAmount,

		UnqualifiedAmount,

		CuringMan,

		CuringManSpell,

        CuringDays,

		CheckDate,

		CheckItem,

		QualityCondition,

		CuringMeasure,

		CuringResult,

        InStoreID,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		CuringRemrk,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

		Reservation6,

		Reservation7,

		Reservation8,

		Reservation9,

		Reservation10,

	}

	#endregion

}
