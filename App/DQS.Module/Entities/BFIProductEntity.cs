/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-04-13 15:45:47
 *	Build Type: Entity
 *	Description: BFIProductEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BFIProductEntity : EntityBase
	{
		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public string ProductCode
		{
			get { return (string)this.GetValue("ProductCode"); } 
			set { this.SetValue("ProductCode", value); } 
		}

		public string ProductName
		{
			get { return (string)this.GetValue("ProductName"); } 
			set { this.SetValue("ProductName", value); } 
		}

		public string ProductSpell
		{
			get { return (string)this.GetValue("ProductSpell"); } 
			set { this.SetValue("ProductSpell", value); } 
		}

		public string CommonName
		{
			get { return (string)this.GetValue("CommonName"); } 
			set { this.SetValue("CommonName", value); } 
		}

		public string TradeName
		{
			get { return (string)this.GetValue("TradeName"); } 
			set { this.SetValue("TradeName", value); } 
		}

		public string EnglishName
		{
			get { return (string)this.GetValue("EnglishName"); } 
			set { this.SetValue("EnglishName", value); } 
		}

		public string ChinesePinyin
		{
			get { return (string)this.GetValue("ChinesePinyin"); } 
			set { this.SetValue("ChinesePinyin", value); } 
		}

		public string ProductBarCode
		{
			get { return (string)this.GetValue("ProductBarCode"); } 
			set { this.SetValue("ProductBarCode", value); } 
		}

		public string ProductSpec
		{
			get { return (string)this.GetValue("ProductSpec"); } 
			set { this.SetValue("ProductSpec", value); } 
		}

		public string ProductUnit
		{
			get { return (string)this.GetValue("ProductUnit"); } 
			set { this.SetValue("ProductUnit", value); } 
		}

		public string PackageSpec
		{
			get { return (string)this.GetValue("PackageSpec"); } 
			set { this.SetValue("PackageSpec", value); } 
		}

		public int PhysicTypeID
		{
			get { return (int)this.GetValue("PhysicTypeID"); } 
			set { this.SetValue("PhysicTypeID", value); } 
		}

		public string PhysicType
		{
			get { return (string)this.GetValue("PhysicType"); } 
			set { this.SetValue("PhysicType", value); } 
		}

		public int ProductStyleID
		{
			get { return (int)this.GetValue("ProductStyleID"); } 
			set { this.SetValue("ProductStyleID", value); } 
		}

		public string ProductStyle
		{
			get { return (string)this.GetValue("ProductStyle"); } 
			set { this.SetValue("ProductStyle", value); } 
		}

		public int BusinessStatus
		{
			get { return (int)this.GetValue("BusinessStatus"); } 
			set { this.SetValue("BusinessStatus", value); } 
		}

		public string AuthorizedNo
		{
			get { return (string)this.GetValue("AuthorizedNo"); } 
			set { this.SetValue("AuthorizedNo", value); } 
		}

		public string ProducerName
		{
			get { return (string)this.GetValue("ProducerName"); } 
			set { this.SetValue("ProducerName", value); } 
		}

		public string ProducerSpell
		{
			get { return (string)this.GetValue("ProducerSpell"); } 
			set { this.SetValue("ProducerSpell", value); } 
		}

		public string ProductionAddress
		{
			get { return (string)this.GetValue("ProductionAddress"); } 
			set { this.SetValue("ProductionAddress", value); } 
		}

		public string ProductionOriginAddress
		{
		    get { return IsNullField("ProductionOriginAddress") ? "" : (string) this.GetValue("ProductionOriginAddress"); }
		    set { this.SetValue("ProductionOriginAddress", value); } 
		}

		public string ProductionPostalCode
		{
			get { return (string)this.GetValue("ProductionPostalCode"); } 
			set { this.SetValue("ProductionPostalCode", value); } 
		}

		public string ProductionPhone
		{
			get { return (string)this.GetValue("ProductionPhone"); } 
			set { this.SetValue("ProductionPhone", value); } 
		}

		public string ProductionFaxNo
		{
			get { return (string)this.GetValue("ProductionFaxNo"); } 
			set { this.SetValue("ProductionFaxNo", value); } 
		}

		public string ContactPerson
		{
			get { return (string)this.GetValue("ContactPerson"); } 
			set { this.SetValue("ContactPerson", value); } 
		}

		public string ContactPersonSpell
		{
			get { return (string)this.GetValue("ContactPersonSpell"); } 
			set { this.SetValue("ContactPersonSpell", value); } 
		}

		public string ContactPhone
		{
			get { return (string)this.GetValue("ContactPhone"); } 
			set { this.SetValue("ContactPhone", value); } 
		}

		public bool IsSupervise
		{
			get { return (bool)this.GetValue("IsSupervise"); } 
			set { this.SetValue("IsSupervise", value); } 
		}

		public string SuperviseSignBar
		{
			get { return (string)this.GetValue("SuperviseSignBar"); } 
			set { this.SetValue("SuperviseSignBar", value); } 
		}

		public int StockMinAmount
		{
			get { return (int)this.GetValue("StockMinAmount"); } 
			set { this.SetValue("StockMinAmount", value); } 
		}

		public int BatchPreWarningDays
		{
			get { return (int)this.GetValue("BatchPreWarningDays"); } 
			set { this.SetValue("BatchPreWarningDays", value); } 
		}

		public string AcceptAgingTime
		{
			get { return (string)this.GetValue("AcceptAgingTime"); } 
			set { this.SetValue("AcceptAgingTime", value); } 
		}

		public string TreatmentFor
		{
			get { return (string)this.GetValue("TreatmentFor"); } 
			set { this.SetValue("TreatmentFor", value); } 
		}

		public string UsageDosage
		{
			get { return (string)this.GetValue("UsageDosage"); } 
			set { this.SetValue("UsageDosage", value); } 
		}

		public string AdverseReaction
		{
			get { return (string)this.GetValue("AdverseReaction"); } 
			set { this.SetValue("AdverseReaction", value); } 
		}

		public string Contraindication
		{
			get { return (string)this.GetValue("Contraindication"); } 
			set { this.SetValue("Contraindication", value); } 
		}

		public string MatterAttention
		{
			get { return (string)this.GetValue("MatterAttention"); } 
			set { this.SetValue("MatterAttention", value); } 
		}

		public string StockCondition
		{
			get { return (string)this.GetValue("StockCondition"); } 
			set { this.SetValue("StockCondition", value); } 
		}

		public bool IsUseToPregnant
		{
			get { return (bool)this.GetValue("IsUseToPregnant"); } 
			set { this.SetValue("IsUseToPregnant", value); } 
		}

		public bool IsUseToChildren
		{
			get { return (bool)this.GetValue("IsUseToChildren"); } 
			set { this.SetValue("IsUseToChildren", value); } 
		}

		public bool IsUseToOldPeople
		{
			get { return (bool)this.GetValue("IsUseToOldPeople"); } 
			set { this.SetValue("IsUseToOldPeople", value); } 
		}

		public string Ingredient
		{
			get { return (string)this.GetValue("Ingredient"); } 
			set { this.SetValue("Ingredient", value); } 
		}

		public string Character
		{
			get { return (string)this.GetValue("Character"); } 
			set { this.SetValue("Character", value); } 
		}

		public string DrugInteraction
		{
			get { return (string)this.GetValue("DrugInteraction"); } 
			set { this.SetValue("DrugInteraction", value); } 
		}

		public string Overdose
		{
			get { return (string)this.GetValue("Overdose"); } 
			set { this.SetValue("Overdose", value); } 
		}

		public string ClinicalTrial
		{
			get { return (string)this.GetValue("ClinicalTrial"); } 
			set { this.SetValue("ClinicalTrial", value); } 
		}

		public string Pharmacology
		{
			get { return (string)this.GetValue("Pharmacology"); } 
			set { this.SetValue("Pharmacology", value); } 
		}

		public string Pharmacokinetics
		{
			get { return (string)this.GetValue("Pharmacokinetics"); } 
			set { this.SetValue("Pharmacokinetics", value); } 
		}

		public string PerformanceStandard
		{
			get { return (string)this.GetValue("PerformanceStandard"); } 
			set { this.SetValue("PerformanceStandard", value); } 
		}

		public string RegisterNo
		{
            get { return IsNullField("RegisterNo") ? "" : (string)this.GetValue("RegisterNo"); } 
			set { this.SetValue("RegisterNo", value); } 
		}

		public string InstructionContent
		{
			get { return (string)this.GetValue("InstructionContent"); } 
			set { this.SetValue("InstructionContent", value); } 
		}

		public DateTime InstructionDate
		{
			get { return (DateTime)this.GetValue("InstructionDate"); } 
			set { this.SetValue("InstructionDate", value); } 
		}

		public string PackagingProportion
		{
            get { return IsNullField("PackagingProportion") ? "" : (string)this.GetValue("PackagingProportion"); } 
			set { this.SetValue("PackagingProportion", value); } 
		}

		public int EntireCargoSpaceMaximum
		{
			get { return (int)this.GetValue("EntireCargoSpaceMaximum"); } 
			set { this.SetValue("EntireCargoSpaceMaximum", value); } 
		}

		public int ScatteredCargoSpaceMaximum
		{
			get { return (int)this.GetValue("ScatteredCargoSpaceMaximum"); } 
			set { this.SetValue("ScatteredCargoSpaceMaximum", value); } 
		}

		public int ScatteredCargoSpaceMinimum
		{
			get { return (int)this.GetValue("ScatteredCargoSpaceMinimum"); } 
			set { this.SetValue("ScatteredCargoSpaceMinimum", value); } 
		}

		public string ValidateYears
		{
            get { return IsNullField("ValidateYears") ? "" : (string)this.GetValue("ValidateYears"); } 
			set { this.SetValue("ValidateYears", value); } 
		}

		public string FirstDealerName
		{
            get { return IsNullField("FirstDealerName") ? "" : (string)this.GetValue("FirstDealerName"); } 
			set { this.SetValue("FirstDealerName", value); } 
		}

		public string ProductStatus
		{
			get { return (string)this.GetValue("ProductStatus"); } 
			set { this.SetValue("ProductStatus", value); } 
		}

		public string CycleType
		{
			get { return IsNullField("CycleType") ? "" : (string)this.GetValue("CycleType"); } 
			set { this.SetValue("CycleType", value); } 
		}

		public string StockFilter
		{
            get { return IsNullField("StockFilter") ? "" : (string)this.GetValue("StockFilter"); } 
			set { this.SetValue("StockFilter", value); } 
		}

		public bool IsForeignDrug
		{
			get { return (bool)this.GetValue("IsForeignDrug"); } 
			set { this.SetValue("IsForeignDrug", value); } 
		}


        public int DSpecialNum
        {
            get { return (int)this.GetValue("DSpecialNum"); }
            set { this.SetValue("DSpecialNum", value); } 
        }
        public int MSpecialNum
        {
            get { return (int)this.GetValue("MSpecialNum"); }
            set { this.SetValue("MSpecialNum", value); } 
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

		public string ProductRemrk
		{
			get { return (string)this.GetValue("ProductRemrk"); } 
			set { this.SetValue("ProductRemrk", value); } 
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

		public BFIProductEntity()
		{
			this.TableName = "BFI_Product";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ProductID", BFIProductEntityFields.ProductID);
			this.Fields.Add("ProductCode", BFIProductEntityFields.ProductCode);
			this.Fields.Add("ProductName", BFIProductEntityFields.ProductName);
			this.Fields.Add("ProductSpell", BFIProductEntityFields.ProductSpell);
			this.Fields.Add("CommonName", BFIProductEntityFields.CommonName);
			this.Fields.Add("TradeName", BFIProductEntityFields.TradeName);
			this.Fields.Add("EnglishName", BFIProductEntityFields.EnglishName);
			this.Fields.Add("ChinesePinyin", BFIProductEntityFields.ChinesePinyin);
			this.Fields.Add("ProductBarCode", BFIProductEntityFields.ProductBarCode);
			this.Fields.Add("ProductSpec", BFIProductEntityFields.ProductSpec);
			this.Fields.Add("ProductUnit", BFIProductEntityFields.ProductUnit);
			this.Fields.Add("PackageSpec", BFIProductEntityFields.PackageSpec);
			this.Fields.Add("PhysicTypeID", BFIProductEntityFields.PhysicTypeID);
			this.Fields.Add("PhysicType", BFIProductEntityFields.PhysicType);
			this.Fields.Add("ProductStyleID", BFIProductEntityFields.ProductStyleID);
			this.Fields.Add("ProductStyle", BFIProductEntityFields.ProductStyle);
			this.Fields.Add("BusinessStatus", BFIProductEntityFields.BusinessStatus);
			this.Fields.Add("AuthorizedNo", BFIProductEntityFields.AuthorizedNo);
			this.Fields.Add("ProducerName", BFIProductEntityFields.ProducerName);
			this.Fields.Add("ProducerSpell", BFIProductEntityFields.ProducerSpell);
			this.Fields.Add("ProductionAddress", BFIProductEntityFields.ProductionAddress);
			this.Fields.Add("ProductionOriginAddress", BFIProductEntityFields.ProductionOriginAddress);
			this.Fields.Add("ProductionPostalCode", BFIProductEntityFields.ProductionPostalCode);
			this.Fields.Add("ProductionPhone", BFIProductEntityFields.ProductionPhone);
			this.Fields.Add("ProductionFaxNo", BFIProductEntityFields.ProductionFaxNo);
			this.Fields.Add("ContactPerson", BFIProductEntityFields.ContactPerson);
			this.Fields.Add("ContactPersonSpell", BFIProductEntityFields.ContactPersonSpell);
			this.Fields.Add("ContactPhone", BFIProductEntityFields.ContactPhone);
			this.Fields.Add("IsSupervise", BFIProductEntityFields.IsSupervise);
			this.Fields.Add("SuperviseSignBar", BFIProductEntityFields.SuperviseSignBar);
			this.Fields.Add("StockMinAmount", BFIProductEntityFields.StockMinAmount);
			this.Fields.Add("BatchPreWarningDays", BFIProductEntityFields.BatchPreWarningDays);
			this.Fields.Add("AcceptAgingTime", BFIProductEntityFields.AcceptAgingTime);
			this.Fields.Add("TreatmentFor", BFIProductEntityFields.TreatmentFor);
			this.Fields.Add("UsageDosage", BFIProductEntityFields.UsageDosage);
			this.Fields.Add("AdverseReaction", BFIProductEntityFields.AdverseReaction);
			this.Fields.Add("Contraindication", BFIProductEntityFields.Contraindication);
			this.Fields.Add("MatterAttention", BFIProductEntityFields.MatterAttention);
			this.Fields.Add("StockCondition", BFIProductEntityFields.StockCondition);
			this.Fields.Add("IsUseToPregnant", BFIProductEntityFields.IsUseToPregnant);
			this.Fields.Add("IsUseToChildren", BFIProductEntityFields.IsUseToChildren);
			this.Fields.Add("IsUseToOldPeople", BFIProductEntityFields.IsUseToOldPeople);
			this.Fields.Add("Ingredient", BFIProductEntityFields.Ingredient);
			this.Fields.Add("Character", BFIProductEntityFields.Character);
			this.Fields.Add("DrugInteraction", BFIProductEntityFields.DrugInteraction);
			this.Fields.Add("Overdose", BFIProductEntityFields.Overdose);
			this.Fields.Add("ClinicalTrial", BFIProductEntityFields.ClinicalTrial);
			this.Fields.Add("Pharmacology", BFIProductEntityFields.Pharmacology);
			this.Fields.Add("Pharmacokinetics", BFIProductEntityFields.Pharmacokinetics);
			this.Fields.Add("PerformanceStandard", BFIProductEntityFields.PerformanceStandard);
			this.Fields.Add("RegisterNo", BFIProductEntityFields.RegisterNo);
			this.Fields.Add("InstructionContent", BFIProductEntityFields.InstructionContent);
			this.Fields.Add("InstructionDate", BFIProductEntityFields.InstructionDate);
			this.Fields.Add("PackagingProportion", BFIProductEntityFields.PackagingProportion);
			this.Fields.Add("EntireCargoSpaceMaximum", BFIProductEntityFields.EntireCargoSpaceMaximum);
			this.Fields.Add("ScatteredCargoSpaceMaximum", BFIProductEntityFields.ScatteredCargoSpaceMaximum);
			this.Fields.Add("ScatteredCargoSpaceMinimum", BFIProductEntityFields.ScatteredCargoSpaceMinimum);
			this.Fields.Add("ValidateYears", BFIProductEntityFields.ValidateYears);
			this.Fields.Add("FirstDealerName", BFIProductEntityFields.FirstDealerName);
			this.Fields.Add("ProductStatus", BFIProductEntityFields.ProductStatus);
			this.Fields.Add("CycleType", BFIProductEntityFields.CycleType);
			this.Fields.Add("StockFilter", BFIProductEntityFields.StockFilter);
			this.Fields.Add("IsForeignDrug", BFIProductEntityFields.IsForeignDrug);
            this.Fields.Add("DSpecialNum", BFIProductEntityFields.DSpecialNum);
            this.Fields.Add("MSpecialNum", BFIProductEntityFields.MSpecialNum);
			this.Fields.Add("CreateUserID", BFIProductEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BFIProductEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BFIProductEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BFIProductEntityFields.LastModifyDate);
			this.Fields.Add("ProductRemrk", BFIProductEntityFields.ProductRemrk);
			this.Fields.Add("Reservation1", BFIProductEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BFIProductEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BFIProductEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BFIProductEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BFIProductEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BFIProductEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BFIProductEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BFIProductEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BFIProductEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BFIProductEntityFields.Reservation10);
		}
	}

	#region BFIProductEntityFields

	public class BFIProductEntityFields
	{
		public static EntityField ProductID
		{
			get { return new EntityField("BFI_Product", 0, "ProductID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ProductCode
		{
			get { return new EntityField("BFI_Product", 1, "ProductCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField ProductName
		{
			get { return new EntityField("BFI_Product", 2, "ProductName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ProductSpell
		{
			get { return new EntityField("BFI_Product", 3, "ProductSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CommonName
		{
			get { return new EntityField("BFI_Product", 4, "CommonName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TradeName
		{
			get { return new EntityField("BFI_Product", 5, "TradeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EnglishName
		{
			get { return new EntityField("BFI_Product", 6, "EnglishName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ChinesePinyin
		{
			get { return new EntityField("BFI_Product", 7, "ChinesePinyin", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductBarCode
		{
			get { return new EntityField("BFI_Product", 8, "ProductBarCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductSpec
		{
			get { return new EntityField("BFI_Product", 9, "ProductSpec", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductUnit
		{
			get { return new EntityField("BFI_Product", 10, "ProductUnit", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PackageSpec
		{
			get { return new EntityField("BFI_Product", 11, "PackageSpec", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PhysicTypeID
		{
			get { return new EntityField("BFI_Product", 12, "PhysicTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField PhysicType
		{
			get { return new EntityField("BFI_Product", 13, "PhysicType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductStyleID
		{
			get { return new EntityField("BFI_Product", 14, "ProductStyleID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ProductStyle
		{
			get { return new EntityField("BFI_Product", 15, "ProductStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BusinessStatus
		{
			get { return new EntityField("BFI_Product", 16, "BusinessStatus", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField AuthorizedNo
		{
			get { return new EntityField("BFI_Product", 17, "AuthorizedNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProducerName
		{
			get { return new EntityField("BFI_Product", 18, "ProducerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProducerSpell
		{
			get { return new EntityField("BFI_Product", 19, "ProducerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductionAddress
		{
			get { return new EntityField("BFI_Product", 20, "ProductionAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductionOriginAddress
		{
			get { return new EntityField("BFI_Product", 21, "ProductionOriginAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductionPostalCode
		{
			get { return new EntityField("BFI_Product", 22, "ProductionPostalCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductionPhone
		{
			get { return new EntityField("BFI_Product", 23, "ProductionPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductionFaxNo
		{
			get { return new EntityField("BFI_Product", 24, "ProductionFaxNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContactPerson
		{
			get { return new EntityField("BFI_Product", 25, "ContactPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContactPersonSpell
		{
			get { return new EntityField("BFI_Product", 26, "ContactPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ContactPhone
		{
			get { return new EntityField("BFI_Product", 27, "ContactPhone", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsSupervise
		{
			get { return new EntityField("BFI_Product", 28, "IsSupervise", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField SuperviseSignBar
		{
			get { return new EntityField("BFI_Product", 29, "SuperviseSignBar", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StockMinAmount
		{
			get { return new EntityField("BFI_Product", 30, "StockMinAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BatchPreWarningDays
		{
			get { return new EntityField("BFI_Product", 31, "BatchPreWarningDays", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField AcceptAgingTime
		{
			get { return new EntityField("BFI_Product", 32, "AcceptAgingTime", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TreatmentFor
		{
			get { return new EntityField("BFI_Product", 33, "TreatmentFor", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField UsageDosage
		{
			get { return new EntityField("BFI_Product", 34, "UsageDosage", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AdverseReaction
		{
			get { return new EntityField("BFI_Product", 35, "AdverseReaction", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Contraindication
		{
			get { return new EntityField("BFI_Product", 36, "Contraindication", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField MatterAttention
		{
			get { return new EntityField("BFI_Product", 37, "MatterAttention", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StockCondition
		{
			get { return new EntityField("BFI_Product", 38, "StockCondition", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsUseToPregnant
		{
			get { return new EntityField("BFI_Product", 39, "IsUseToPregnant", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField IsUseToChildren
		{
			get { return new EntityField("BFI_Product", 40, "IsUseToChildren", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField IsUseToOldPeople
		{
			get { return new EntityField("BFI_Product", 41, "IsUseToOldPeople", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField Ingredient
		{
			get { return new EntityField("BFI_Product", 42, "Ingredient", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Character
		{
			get { return new EntityField("BFI_Product", 43, "Character", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DrugInteraction
		{
			get { return new EntityField("BFI_Product", 44, "DrugInteraction", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Overdose
		{
			get { return new EntityField("BFI_Product", 45, "Overdose", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ClinicalTrial
		{
			get { return new EntityField("BFI_Product", 46, "ClinicalTrial", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Pharmacology
		{
			get { return new EntityField("BFI_Product", 47, "Pharmacology", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Pharmacokinetics
		{
			get { return new EntityField("BFI_Product", 48, "Pharmacokinetics", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PerformanceStandard
		{
			get { return new EntityField("BFI_Product", 49, "PerformanceStandard", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField RegisterNo
		{
			get { return new EntityField("BFI_Product", 50, "RegisterNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InstructionContent
		{
			get { return new EntityField("BFI_Product", 51, "InstructionContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InstructionDate
		{
			get { return new EntityField("BFI_Product", 52, "InstructionDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField PackagingProportion
		{
			get { return new EntityField("BFI_Product", 53, "PackagingProportion", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField EntireCargoSpaceMaximum
		{
			get { return new EntityField("BFI_Product", 54, "EntireCargoSpaceMaximum", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ScatteredCargoSpaceMaximum
		{
			get { return new EntityField("BFI_Product", 55, "ScatteredCargoSpaceMaximum", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ScatteredCargoSpaceMinimum
		{
			get { return new EntityField("BFI_Product", 56, "ScatteredCargoSpaceMinimum", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ValidateYears
		{
			get { return new EntityField("BFI_Product", 57, "ValidateYears", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField FirstDealerName
		{
			get { return new EntityField("BFI_Product", 58, "FirstDealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductStatus
		{
			get { return new EntityField("BFI_Product", 59, "ProductStatus", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CycleType
		{
			get { return new EntityField("BFI_Product", 60, "CycleType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StockFilter
		{
			get { return new EntityField("BFI_Product", 61, "StockFilter", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField IsForeignDrug
		{
			get { return new EntityField("BFI_Product", 62, "IsForeignDrug", SqlDbType.Bit, false, false, false, true); }
		}

        public static EntityField DSpecialNum
		{
            get { return new EntityField("BFI_Product", 63, "DSpecialNum", SqlDbType.Int, false, false, false, true); }
		}
        public static EntityField MSpecialNum
		{
            get { return new EntityField("BFI_Product", 64, "MSpecialNum", SqlDbType.Int, false, false, false, true); }
		}
		public static EntityField CreateUserID
		{
			get { return new EntityField("BFI_Product", 65, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}
		public static EntityField CreateDate
		{
			get { return new EntityField("BFI_Product", 66, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BFI_Product", 67, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BFI_Product", 68, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ProductRemrk
		{
			get { return new EntityField("BFI_Product", 69, "ProductRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BFI_Product", 70, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BFI_Product", 71, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BFI_Product", 72, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BFI_Product", 73, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BFI_Product", 74, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BFI_Product", 75, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BFI_Product", 76, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BFI_Product", 77, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BFI_Product", 78, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BFI_Product", 79, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BFIProductEntityFields2

	public enum BFIProductEntityFields2
	{
		ProductID,

		ProductCode,

		ProductName,

		ProductSpell,

		CommonName,

		TradeName,

		EnglishName,

		ChinesePinyin,

		ProductBarCode,

		ProductSpec,

		ProductUnit,

		PackageSpec,

		PhysicTypeID,

		PhysicType,

		ProductStyleID,

		ProductStyle,

		BusinessStatus,

		AuthorizedNo,

		ProducerName,

		ProducerSpell,

		ProductionAddress,

		ProductionOriginAddress,

		ProductionPostalCode,

		ProductionPhone,

		ProductionFaxNo,

		ContactPerson,

		ContactPersonSpell,

		ContactPhone,

		IsSupervise,

		SuperviseSignBar,

		StockMinAmount,

		BatchPreWarningDays,

		AcceptAgingTime,

		TreatmentFor,

		UsageDosage,

		AdverseReaction,

		Contraindication,

		MatterAttention,

		StockCondition,

		IsUseToPregnant,

		IsUseToChildren,

		IsUseToOldPeople,

		Ingredient,

		Character,

		DrugInteraction,

		Overdose,

		ClinicalTrial,

		Pharmacology,

		Pharmacokinetics,

		PerformanceStandard,

		RegisterNo,

		InstructionContent,

		InstructionDate,

		PackagingProportion,

		EntireCargoSpaceMaximum,

		ScatteredCargoSpaceMaximum,

		ScatteredCargoSpaceMinimum,

		ValidateYears,

		FirstDealerName,

		ProductStatus,

		CycleType,

		StockFilter,

		IsForeignDrug,

        DSpecialNum,

        MSpecialNum,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		ProductRemrk,

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
