/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-10-08 10:40:38
 *	Build Type: Entity
 *	Description: BUSSamplingEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSSamplingEntity : EntityBase
	{
		public int SamplingID
		{
			get { return (int)this.GetValue("SamplingID"); } 
			set { this.SetValue("SamplingID", value); } 
		}

		public string SamplingCode
		{
			get { return (string)this.GetValue("SamplingCode"); } 
			set { this.SetValue("SamplingCode", value); } 
		}

		public DateTime SamplingDate
		{
			get { return (DateTime)this.GetValue("SamplingDate"); } 
			set { this.SetValue("SamplingDate", value); } 
		}

		public int AcceptID
		{
			get { return (int)this.GetValue("AcceptID"); } 
			set { this.SetValue("AcceptID", value); } 
		}

		public int BillID
		{
			get { return (int)this.GetValue("BillID"); } 
			set { this.SetValue("BillID", value); } 
		}

		public string BillCode
		{
			get { return (string)this.GetValue("BillCode"); } 
			set { this.SetValue("BillCode", value); } 
		}

		public DateTime BillDate
		{
			get { return (DateTime)this.GetValue("BillDate"); } 
			set { this.SetValue("BillDate", value); } 
		}

		public int BillTypeID
		{
			get { return (int)this.GetValue("BillTypeID"); } 
			set { this.SetValue("BillTypeID", value); } 
		}

		public string BillTypeName
		{
			get { return (string)this.GetValue("BillTypeName"); } 
			set { this.SetValue("BillTypeName", value); } 
		}

		public string BillTypeSpell
		{
			get { return (string)this.GetValue("BillTypeSpell"); } 
			set { this.SetValue("BillTypeSpell", value); } 
		}

		public int DealerID
		{
			get { return (int)this.GetValue("DealerID"); } 
			set { this.SetValue("DealerID", value); } 
		}

		public string DealerCode
		{
			get { return (string)this.GetValue("DealerCode"); } 
			set { this.SetValue("DealerCode", value); } 
		}

		public string DealerName
		{
			get { return (string)this.GetValue("DealerName"); } 
			set { this.SetValue("DealerName", value); } 
		}

		public int ConditionID
		{
			get { return (int)this.GetValue("ConditionID"); } 
			set { this.SetValue("ConditionID", value); } 
		}

		public string ConditionCode
		{
			get { return (string)this.GetValue("ConditionCode"); } 
			set { this.SetValue("ConditionCode", value); } 
		}

		public string ConditionName
		{
			get { return (string)this.GetValue("ConditionName"); } 
			set { this.SetValue("ConditionName", value); } 
		}

		public string ConditionContent
		{
			get { return (string)this.GetValue("ConditionContent"); } 
			set { this.SetValue("ConditionContent", value); } 
		}

		public string ConditionMethod
		{
			get { return (string)this.GetValue("ConditionMethod"); } 
			set { this.SetValue("ConditionMethod", value); } 
		}

		public int ProductID
		{
			get { return (int)this.GetValue("ProductID"); } 
			set { this.SetValue("ProductID", value); } 
		}

		public int Amount
		{
			get { return (int)this.GetValue("Amount"); } 
			set { this.SetValue("Amount", value); } 
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

		public int SamplingAmount
		{
			get { return (int)this.GetValue("SamplingAmount"); } 
			set { this.SetValue("SamplingAmount", value); } 
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

		public string Inspector
		{
			get { return (string)this.GetValue("Inspector"); } 
			set { this.SetValue("Inspector", value); } 
		}

		public string InspectorSpell
		{
			get { return (string)this.GetValue("InspectorSpell"); } 
			set { this.SetValue("InspectorSpell", value); } 
		}

		public string ConditionSolution
		{
			get { return (string)this.GetValue("ConditionSolution"); } 
			set { this.SetValue("ConditionSolution", value); } 
		}

		public string ConditionResult
		{
			get { return (string)this.GetValue("ConditionResult"); } 
			set { this.SetValue("ConditionResult", value); } 
		}

		public string DealResult
		{
			get { return (string)this.GetValue("DealResult"); } 
			set { this.SetValue("DealResult", value); } 
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

		public string SamplingRemark
		{
			get { return (string)this.GetValue("SamplingRemark"); } 
			set { this.SetValue("SamplingRemark", value); } 
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

		public BUSSamplingEntity()
		{
			this.TableName = "BUS_Sampling";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("SamplingID", BUSSamplingEntityFields.SamplingID);
			this.Fields.Add("SamplingCode", BUSSamplingEntityFields.SamplingCode);
			this.Fields.Add("SamplingDate", BUSSamplingEntityFields.SamplingDate);
			this.Fields.Add("AcceptID", BUSSamplingEntityFields.AcceptID);
			this.Fields.Add("BillID", BUSSamplingEntityFields.BillID);
			this.Fields.Add("BillCode", BUSSamplingEntityFields.BillCode);
			this.Fields.Add("BillDate", BUSSamplingEntityFields.BillDate);
			this.Fields.Add("BillTypeID", BUSSamplingEntityFields.BillTypeID);
			this.Fields.Add("BillTypeName", BUSSamplingEntityFields.BillTypeName);
			this.Fields.Add("BillTypeSpell", BUSSamplingEntityFields.BillTypeSpell);
			this.Fields.Add("DealerID", BUSSamplingEntityFields.DealerID);
			this.Fields.Add("DealerCode", BUSSamplingEntityFields.DealerCode);
			this.Fields.Add("DealerName", BUSSamplingEntityFields.DealerName);
			this.Fields.Add("ConditionID", BUSSamplingEntityFields.ConditionID);
			this.Fields.Add("ConditionCode", BUSSamplingEntityFields.ConditionCode);
			this.Fields.Add("ConditionName", BUSSamplingEntityFields.ConditionName);
			this.Fields.Add("ConditionContent", BUSSamplingEntityFields.ConditionContent);
			this.Fields.Add("ConditionMethod", BUSSamplingEntityFields.ConditionMethod);
			this.Fields.Add("ProductID", BUSSamplingEntityFields.ProductID);
			this.Fields.Add("Amount", BUSSamplingEntityFields.Amount);
			this.Fields.Add("BatchNo", BUSSamplingEntityFields.BatchNo);
			this.Fields.Add("ProduceDate", BUSSamplingEntityFields.ProduceDate);
			this.Fields.Add("ValidateDate", BUSSamplingEntityFields.ValidateDate);
			this.Fields.Add("SamplingAmount", BUSSamplingEntityFields.SamplingAmount);
			this.Fields.Add("QualifiedAmount", BUSSamplingEntityFields.QualifiedAmount);
			this.Fields.Add("UnqualifiedAmount", BUSSamplingEntityFields.UnqualifiedAmount);
			this.Fields.Add("Inspector", BUSSamplingEntityFields.Inspector);
			this.Fields.Add("InspectorSpell", BUSSamplingEntityFields.InspectorSpell);
			this.Fields.Add("ConditionSolution", BUSSamplingEntityFields.ConditionSolution);
			this.Fields.Add("ConditionResult", BUSSamplingEntityFields.ConditionResult);
			this.Fields.Add("DealResult", BUSSamplingEntityFields.DealResult);
			this.Fields.Add("CreateUserID", BUSSamplingEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSSamplingEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSSamplingEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSSamplingEntityFields.LastModifyDate);
			this.Fields.Add("SamplingRemark", BUSSamplingEntityFields.SamplingRemark);
			this.Fields.Add("Reservation1", BUSSamplingEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSSamplingEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSSamplingEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSSamplingEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSSamplingEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSSamplingEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSSamplingEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSSamplingEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSSamplingEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSSamplingEntityFields.Reservation10);
		}
	}

	#region BUSSamplingEntityFields

	public class BUSSamplingEntityFields
	{
		public static EntityField SamplingID
		{
			get { return new EntityField("BUS_Sampling", 0, "SamplingID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField SamplingCode
		{
			get { return new EntityField("BUS_Sampling", 1, "SamplingCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField SamplingDate
		{
			get { return new EntityField("BUS_Sampling", 2, "SamplingDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField AcceptID
		{
			get { return new EntityField("BUS_Sampling", 3, "AcceptID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillID
		{
			get { return new EntityField("BUS_Sampling", 4, "BillID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("BUS_Sampling", 5, "BillCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillDate
		{
			get { return new EntityField("BUS_Sampling", 6, "BillDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField BillTypeID
		{
			get { return new EntityField("BUS_Sampling", 7, "BillTypeID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BillTypeName
		{
			get { return new EntityField("BUS_Sampling", 8, "BillTypeName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField BillTypeSpell
		{
			get { return new EntityField("BUS_Sampling", 9, "BillTypeSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerID
		{
			get { return new EntityField("BUS_Sampling", 10, "DealerID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DealerCode
		{
			get { return new EntityField("BUS_Sampling", 11, "DealerCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealerName
		{
			get { return new EntityField("BUS_Sampling", 12, "DealerName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionID
		{
			get { return new EntityField("BUS_Sampling", 13, "ConditionID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField ConditionCode
		{
			get { return new EntityField("BUS_Sampling", 14, "ConditionCode", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionName
		{
			get { return new EntityField("BUS_Sampling", 15, "ConditionName", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionContent
		{
			get { return new EntityField("BUS_Sampling", 16, "ConditionContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionMethod
		{
			get { return new EntityField("BUS_Sampling", 17, "ConditionMethod", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProductID
		{
			get { return new EntityField("BUS_Sampling", 18, "ProductID", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField Amount
		{
			get { return new EntityField("BUS_Sampling", 19, "Amount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField BatchNo
		{
			get { return new EntityField("BUS_Sampling", 20, "BatchNo", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProduceDate
		{
			get { return new EntityField("BUS_Sampling", 21, "ProduceDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField ValidateDate
		{
			get { return new EntityField("BUS_Sampling", 22, "ValidateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField SamplingAmount
		{
			get { return new EntityField("BUS_Sampling", 23, "SamplingAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField QualifiedAmount
		{
			get { return new EntityField("BUS_Sampling", 24, "QualifiedAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField UnqualifiedAmount
		{
			get { return new EntityField("BUS_Sampling", 25, "UnqualifiedAmount", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField Inspector
		{
			get { return new EntityField("BUS_Sampling", 26, "Inspector", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField InspectorSpell
		{
			get { return new EntityField("BUS_Sampling", 27, "InspectorSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionSolution
		{
			get { return new EntityField("BUS_Sampling", 28, "ConditionSolution", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ConditionResult
		{
			get { return new EntityField("BUS_Sampling", 29, "ConditionResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField DealResult
		{
			get { return new EntityField("BUS_Sampling", 30, "DealResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_Sampling", 31, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_Sampling", 32, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_Sampling", 33, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_Sampling", 34, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField SamplingRemark
		{
			get { return new EntityField("BUS_Sampling", 35, "SamplingRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_Sampling", 36, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_Sampling", 37, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_Sampling", 38, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_Sampling", 39, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_Sampling", 40, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_Sampling", 41, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_Sampling", 42, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_Sampling", 43, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_Sampling", 44, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_Sampling", 45, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSSamplingEntityFields2

	public enum BUSSamplingEntityFields2
	{
		SamplingID,

		SamplingCode,

		SamplingDate,

		AcceptID,

		BillID,

		BillCode,

		BillDate,

		BillTypeID,

		BillTypeName,

		BillTypeSpell,

		DealerID,

		DealerCode,

		DealerName,

		ConditionID,

		ConditionCode,

		ConditionName,

		ConditionContent,

		ConditionMethod,

		ProductID,

		Amount,

		BatchNo,

		ProduceDate,

		ValidateDate,

		SamplingAmount,

		QualifiedAmount,

		UnqualifiedAmount,

		Inspector,

		InspectorSpell,

		ConditionSolution,

		ConditionResult,

		DealResult,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		SamplingRemark,

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
