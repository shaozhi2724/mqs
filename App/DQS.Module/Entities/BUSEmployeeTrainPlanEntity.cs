/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-08-28 12:02:22
 *	Build Type: Entity
 *	Description: BUSEmployeeTrainPlanEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class BUSEmployeeTrainPlanEntity : EntityBase
	{
		public int TrainID
		{
			get { return (int)this.GetValue("TrainID"); } 
			set { this.SetValue("TrainID", value); } 
		}

		public string TrainCode
		{
			get { return (string)this.GetValue("TrainCode"); } 
			set { this.SetValue("TrainCode", value); } 
		}

		public string TrainName
		{
			get { return (string)this.GetValue("TrainName"); } 
			set { this.SetValue("TrainName", value); } 
		}

		public string TrainTarget
		{
			get { return (string)this.GetValue("TrainTarget"); } 
			set { this.SetValue("TrainTarget", value); } 
		}

		public string TrainContent
		{
			get { return (string)this.GetValue("TrainContent"); } 
			set { this.SetValue("TrainContent", value); } 
		}

		public string UndertakeDept
		{
			get { return (string)this.GetValue("UndertakeDept"); } 
			set { this.SetValue("UndertakeDept", value); } 
		}

		public string AssistDept
		{
			get { return (string)this.GetValue("AssistDept"); } 
			set { this.SetValue("AssistDept", value); } 
		}

		public string TrainType
		{
			get { return (string)this.GetValue("TrainType"); } 
			set { this.SetValue("TrainType", value); } 
		}

		public string TrainStyle
		{
			get { return (string)this.GetValue("TrainStyle"); } 
			set { this.SetValue("TrainStyle", value); } 
		}

		public string Lecturer
		{
			get { return (string)this.GetValue("Lecturer"); } 
			set { this.SetValue("Lecturer", value); } 
		}

		public string TeachingMaterial
		{
			get { return (string)this.GetValue("TeachingMaterial"); } 
			set { this.SetValue("TeachingMaterial", value); } 
		}

		public string TrainAddress
		{
			get { return (string)this.GetValue("TrainAddress"); } 
			set { this.SetValue("TrainAddress", value); } 
		}

		public string PresentLevel
		{
			get { return (string)this.GetValue("PresentLevel"); } 
			set { this.SetValue("PresentLevel", value); } 
		}

		public string AnticipativeLevel
		{
			get { return (string)this.GetValue("AnticipativeLevel"); } 
			set { this.SetValue("AnticipativeLevel", value); } 
		}

		public DateTime StartTime
		{
			get { return (DateTime)this.GetValue("StartTime"); } 
			set { this.SetValue("StartTime", value); } 
		}

		public DateTime EndTime
		{
			get { return (DateTime)this.GetValue("EndTime"); } 
			set { this.SetValue("EndTime", value); } 
		}

		public string Duration
		{
			get { return (string)this.GetValue("Duration"); } 
			set { this.SetValue("Duration", value); } 
		}

		public string CheckPerson
		{
			get { return (string)this.GetValue("CheckPerson"); } 
			set { this.SetValue("CheckPerson", value); } 
		}

		public string CheckPersonSpell
		{
			get { return (string)this.GetValue("CheckPersonSpell"); } 
			set { this.SetValue("CheckPersonSpell", value); } 
		}

		public string CheckStyle
		{
			get { return (string)this.GetValue("CheckStyle"); } 
			set { this.SetValue("CheckStyle", value); } 
		}

		public string Budget
		{
			get { return (string)this.GetValue("Budget"); } 
			set { this.SetValue("Budget", value); } 
		}

		public string Proposer
		{
			get { return (string)this.GetValue("Proposer"); } 
			set { this.SetValue("Proposer", value); } 
		}

		public string ProposerSpell
		{
			get { return (string)this.GetValue("ProposerSpell"); } 
			set { this.SetValue("ProposerSpell", value); } 
		}

		public DateTime PropoDate
		{
			get { return (DateTime)this.GetValue("PropoDate"); } 
			set { this.SetValue("PropoDate", value); } 
		}

		public bool IsTrained
		{
			get { return (bool)this.GetValue("IsTrained"); } 
			set { this.SetValue("IsTrained", value); } 
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

		public string TrianRemrk
		{
			get { return (string)this.GetValue("TrianRemrk"); } 
			set { this.SetValue("TrianRemrk", value); } 
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

		public BUSEmployeeTrainPlanEntity()
		{
			this.TableName = "BUS_EmployeeTrainPlan";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("TrainID", BUSEmployeeTrainPlanEntityFields.TrainID);
			this.Fields.Add("TrainCode", BUSEmployeeTrainPlanEntityFields.TrainCode);
			this.Fields.Add("TrainName", BUSEmployeeTrainPlanEntityFields.TrainName);
			this.Fields.Add("TrainTarget", BUSEmployeeTrainPlanEntityFields.TrainTarget);
			this.Fields.Add("TrainContent", BUSEmployeeTrainPlanEntityFields.TrainContent);
			this.Fields.Add("UndertakeDept", BUSEmployeeTrainPlanEntityFields.UndertakeDept);
			this.Fields.Add("AssistDept", BUSEmployeeTrainPlanEntityFields.AssistDept);
			this.Fields.Add("TrainType", BUSEmployeeTrainPlanEntityFields.TrainType);
			this.Fields.Add("TrainStyle", BUSEmployeeTrainPlanEntityFields.TrainStyle);
			this.Fields.Add("Lecturer", BUSEmployeeTrainPlanEntityFields.Lecturer);
			this.Fields.Add("TeachingMaterial", BUSEmployeeTrainPlanEntityFields.TeachingMaterial);
			this.Fields.Add("TrainAddress", BUSEmployeeTrainPlanEntityFields.TrainAddress);
			this.Fields.Add("PresentLevel", BUSEmployeeTrainPlanEntityFields.PresentLevel);
			this.Fields.Add("AnticipativeLevel", BUSEmployeeTrainPlanEntityFields.AnticipativeLevel);
			this.Fields.Add("StartTime", BUSEmployeeTrainPlanEntityFields.StartTime);
			this.Fields.Add("EndTime", BUSEmployeeTrainPlanEntityFields.EndTime);
			this.Fields.Add("Duration", BUSEmployeeTrainPlanEntityFields.Duration);
			this.Fields.Add("CheckPerson", BUSEmployeeTrainPlanEntityFields.CheckPerson);
			this.Fields.Add("CheckPersonSpell", BUSEmployeeTrainPlanEntityFields.CheckPersonSpell);
			this.Fields.Add("CheckStyle", BUSEmployeeTrainPlanEntityFields.CheckStyle);
			this.Fields.Add("Budget", BUSEmployeeTrainPlanEntityFields.Budget);
			this.Fields.Add("Proposer", BUSEmployeeTrainPlanEntityFields.Proposer);
			this.Fields.Add("ProposerSpell", BUSEmployeeTrainPlanEntityFields.ProposerSpell);
			this.Fields.Add("PropoDate", BUSEmployeeTrainPlanEntityFields.PropoDate);
			this.Fields.Add("IsTrained", BUSEmployeeTrainPlanEntityFields.IsTrained);
			this.Fields.Add("CreateUserID", BUSEmployeeTrainPlanEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", BUSEmployeeTrainPlanEntityFields.CreateDate);
			this.Fields.Add("LastModifyUserID", BUSEmployeeTrainPlanEntityFields.LastModifyUserID);
			this.Fields.Add("LastModifyDate", BUSEmployeeTrainPlanEntityFields.LastModifyDate);
			this.Fields.Add("TrianRemrk", BUSEmployeeTrainPlanEntityFields.TrianRemrk);
			this.Fields.Add("Reservation1", BUSEmployeeTrainPlanEntityFields.Reservation1);
			this.Fields.Add("Reservation2", BUSEmployeeTrainPlanEntityFields.Reservation2);
			this.Fields.Add("Reservation3", BUSEmployeeTrainPlanEntityFields.Reservation3);
			this.Fields.Add("Reservation4", BUSEmployeeTrainPlanEntityFields.Reservation4);
			this.Fields.Add("Reservation5", BUSEmployeeTrainPlanEntityFields.Reservation5);
			this.Fields.Add("Reservation6", BUSEmployeeTrainPlanEntityFields.Reservation6);
			this.Fields.Add("Reservation7", BUSEmployeeTrainPlanEntityFields.Reservation7);
			this.Fields.Add("Reservation8", BUSEmployeeTrainPlanEntityFields.Reservation8);
			this.Fields.Add("Reservation9", BUSEmployeeTrainPlanEntityFields.Reservation9);
			this.Fields.Add("Reservation10", BUSEmployeeTrainPlanEntityFields.Reservation10);
		}
	}

	#region BUSEmployeeTrainPlanEntityFields

	public class BUSEmployeeTrainPlanEntityFields
	{
		public static EntityField TrainID
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 0, "TrainID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField TrainCode
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 1, "TrainCode", SqlDbType.NVarChar, false, false, true, false); }
		}

		public static EntityField TrainName
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 2, "TrainName", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField TrainTarget
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 3, "TrainTarget", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField TrainContent
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 4, "TrainContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField UndertakeDept
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 5, "UndertakeDept", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AssistDept
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 6, "AssistDept", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TrainType
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 7, "TrainType", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TrainStyle
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 8, "TrainStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Lecturer
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 9, "Lecturer", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TeachingMaterial
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 10, "TeachingMaterial", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField TrainAddress
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 11, "TrainAddress", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PresentLevel
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 12, "PresentLevel", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField AnticipativeLevel
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 13, "AnticipativeLevel", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField StartTime
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 14, "StartTime", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField EndTime
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 15, "EndTime", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField Duration
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 16, "Duration", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CheckPerson
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 17, "CheckPerson", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CheckPersonSpell
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 18, "CheckPersonSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField CheckStyle
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 19, "CheckStyle", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Budget
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 20, "Budget", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Proposer
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 21, "Proposer", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ProposerSpell
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 22, "ProposerSpell", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField PropoDate
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 23, "PropoDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField IsTrained
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 24, "IsTrained", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 25, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 26, "CreateDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField LastModifyUserID
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 27, "LastModifyUserID", SqlDbType.UniqueIdentifier, false, false, false, true); }
		}

		public static EntityField LastModifyDate
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 28, "LastModifyDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField TrianRemrk
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 29, "TrianRemrk", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 30, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 31, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 32, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 33, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 34, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation6
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 35, "Reservation6", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation7
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 36, "Reservation7", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation8
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 37, "Reservation8", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation9
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 38, "Reservation9", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation10
		{
			get { return new EntityField("BUS_EmployeeTrainPlan", 39, "Reservation10", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region BUSEmployeeTrainPlanEntityFields2

	public enum BUSEmployeeTrainPlanEntityFields2
	{
		TrainID,

		TrainCode,

		TrainName,

		TrainTarget,

		TrainContent,

		UndertakeDept,

		AssistDept,

		TrainType,

		TrainStyle,

		Lecturer,

		TeachingMaterial,

		TrainAddress,

		PresentLevel,

		AnticipativeLevel,

		StartTime,

		EndTime,

		Duration,

		CheckPerson,

		CheckPersonSpell,

		CheckStyle,

		Budget,

		Proposer,

		ProposerSpell,

		PropoDate,

		IsTrained,

		CreateUserID,

		CreateDate,

		LastModifyUserID,

		LastModifyDate,

		TrianRemrk,

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
