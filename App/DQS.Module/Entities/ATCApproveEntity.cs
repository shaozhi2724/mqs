/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-12-23 17:54:28
 *	Build Type: Entity
 *	Description: ATCApproveEntity
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Entities
{
	public class ATCApproveEntity : EntityBase
	{
		public int ApproveID
		{
			get { return (int)this.GetValue("ApproveID"); } 
			set { this.SetValue("ApproveID", value); } 
		}

		public string ApproveCode
		{
			get { return (string)this.GetValue("ApproveCode"); } 
			set { this.SetValue("ApproveCode", value); } 
		}

		public string InternalNo
		{
			get { return (string)this.GetValue("InternalNo"); } 
			set { this.SetValue("InternalNo", value); } 
		}

		public string ApproveTitle
		{
			get { return (string)this.GetValue("ApproveTitle"); } 
			set { this.SetValue("ApproveTitle", value); } 
		}

		public int ApproveOrder
		{
			get { return (int)this.GetValue("ApproveOrder"); } 
			set { this.SetValue("ApproveOrder", value); } 
		}

		public string DocumentCode
		{
			get { return (string)this.GetValue("DocumentCode"); } 
			set { this.SetValue("DocumentCode", value); } 
		}

		public string BillCode
		{
			get { return (string)this.GetValue("BillCode"); } 
			set { this.SetValue("BillCode", value); } 
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

		public Guid ApprovalUserID
		{
			get { return (Guid)this.GetValue("ApprovalUserID"); } 
			set { this.SetValue("ApprovalUserID", value); } 
		}

		public DateTime ApprovalDate
		{
			get { return (DateTime)this.GetValue("ApprovalDate"); } 
			set { this.SetValue("ApprovalDate", value); } 
		}

		public bool IsApprovaled
		{
			get { return (bool)this.GetValue("IsApprovaled"); } 
			set { this.SetValue("IsApprovaled", value); } 
		}

		public bool IsPass
		{
			get { return (bool)this.GetValue("IsPass"); } 
			set { this.SetValue("IsPass", value); } 
		}

		public bool IsWhole
		{
			get { return (bool)this.GetValue("IsWhole"); } 
			set { this.SetValue("IsWhole", value); } 
		}

		public string ApprovalContent
		{
			get { return (string)this.GetValue("ApprovalContent"); } 
			set { this.SetValue("ApprovalContent", value); } 
		}

		public string ApprovalSuggestion
		{
			get { return (string)this.GetValue("ApprovalSuggestion"); } 
			set { this.SetValue("ApprovalSuggestion", value); } 
		}

		public string ApprovalResult
		{
			get { return (string)this.GetValue("ApprovalResult"); } 
			set { this.SetValue("ApprovalResult", value); } 
		}

		public string ApprovalRemark
		{
			get { return (string)this.GetValue("ApprovalRemark"); } 
			set { this.SetValue("ApprovalRemark", value); } 
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

		public ATCApproveEntity()
		{
			this.TableName = "ATC_Approve";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ApproveID", ATCApproveEntityFields.ApproveID);
			this.Fields.Add("ApproveCode", ATCApproveEntityFields.ApproveCode);
			this.Fields.Add("InternalNo", ATCApproveEntityFields.InternalNo);
			this.Fields.Add("ApproveTitle", ATCApproveEntityFields.ApproveTitle);
			this.Fields.Add("ApproveOrder", ATCApproveEntityFields.ApproveOrder);
			this.Fields.Add("DocumentCode", ATCApproveEntityFields.DocumentCode);
			this.Fields.Add("BillCode", ATCApproveEntityFields.BillCode);
			this.Fields.Add("CreateUserID", ATCApproveEntityFields.CreateUserID);
			this.Fields.Add("CreateDate", ATCApproveEntityFields.CreateDate);
			this.Fields.Add("ApprovalUserID", ATCApproveEntityFields.ApprovalUserID);
			this.Fields.Add("ApprovalDate", ATCApproveEntityFields.ApprovalDate);
			this.Fields.Add("IsApprovaled", ATCApproveEntityFields.IsApprovaled);
			this.Fields.Add("IsPass", ATCApproveEntityFields.IsPass);
			this.Fields.Add("IsWhole", ATCApproveEntityFields.IsWhole);
			this.Fields.Add("ApprovalContent", ATCApproveEntityFields.ApprovalContent);
			this.Fields.Add("ApprovalSuggestion", ATCApproveEntityFields.ApprovalSuggestion);
			this.Fields.Add("ApprovalResult", ATCApproveEntityFields.ApprovalResult);
			this.Fields.Add("ApprovalRemark", ATCApproveEntityFields.ApprovalRemark);
			this.Fields.Add("Reservation1", ATCApproveEntityFields.Reservation1);
			this.Fields.Add("Reservation2", ATCApproveEntityFields.Reservation2);
			this.Fields.Add("Reservation3", ATCApproveEntityFields.Reservation3);
			this.Fields.Add("Reservation4", ATCApproveEntityFields.Reservation4);
			this.Fields.Add("Reservation5", ATCApproveEntityFields.Reservation5);
		}
	}

	#region ATCApproveEntityFields

	public class ATCApproveEntityFields
	{
		public static EntityField ApproveID
		{
			get { return new EntityField("ATC_Approve", 0, "ApproveID", SqlDbType.Int, true, true, true, false); }
		}

		public static EntityField ApproveCode
		{
			get { return new EntityField("ATC_Approve", 1, "ApproveCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField InternalNo
		{
			get { return new EntityField("ATC_Approve", 2, "InternalNo", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ApproveTitle
		{
			get { return new EntityField("ATC_Approve", 3, "ApproveTitle", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField ApproveOrder
		{
			get { return new EntityField("ATC_Approve", 4, "ApproveOrder", SqlDbType.Int, false, false, false, true); }
		}

		public static EntityField DocumentCode
		{
			get { return new EntityField("ATC_Approve", 5, "DocumentCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("ATC_Approve", 6, "BillCode", SqlDbType.NVarChar, false, false, false, false); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("ATC_Approve", 7, "CreateUserID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField CreateDate
		{
			get { return new EntityField("ATC_Approve", 8, "CreateDate", SqlDbType.DateTime, false, false, false, false); }
		}

		public static EntityField ApprovalUserID
		{
			get { return new EntityField("ATC_Approve", 9, "ApprovalUserID", SqlDbType.UniqueIdentifier, false, false, false, false); }
		}

		public static EntityField ApprovalDate
		{
			get { return new EntityField("ATC_Approve", 10, "ApprovalDate", SqlDbType.DateTime, false, false, false, true); }
		}

		public static EntityField IsApprovaled
		{
			get { return new EntityField("ATC_Approve", 11, "IsApprovaled", SqlDbType.Bit, false, false, false, false); }
		}

		public static EntityField IsPass
		{
			get { return new EntityField("ATC_Approve", 12, "IsPass", SqlDbType.Bit, false, false, false, true); }
		}

		public static EntityField IsWhole
		{
			get { return new EntityField("ATC_Approve", 13, "IsWhole", SqlDbType.Bit, false, false, false, false); }
		}

		public static EntityField ApprovalContent
		{
			get { return new EntityField("ATC_Approve", 14, "ApprovalContent", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ApprovalSuggestion
		{
			get { return new EntityField("ATC_Approve", 15, "ApprovalSuggestion", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ApprovalResult
		{
			get { return new EntityField("ATC_Approve", 16, "ApprovalResult", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField ApprovalRemark
		{
			get { return new EntityField("ATC_Approve", 17, "ApprovalRemark", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation1
		{
			get { return new EntityField("ATC_Approve", 18, "Reservation1", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation2
		{
			get { return new EntityField("ATC_Approve", 19, "Reservation2", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation3
		{
			get { return new EntityField("ATC_Approve", 20, "Reservation3", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation4
		{
			get { return new EntityField("ATC_Approve", 21, "Reservation4", SqlDbType.NVarChar, false, false, false, true); }
		}

		public static EntityField Reservation5
		{
			get { return new EntityField("ATC_Approve", 22, "Reservation5", SqlDbType.NVarChar, false, false, false, true); }
		}

	}

	#endregion

	#region ATCApproveEntityFields2

	public enum ATCApproveEntityFields2
	{
		ApproveID,

		ApproveCode,

		InternalNo,

		ApproveTitle,

		ApproveOrder,

		DocumentCode,

		BillCode,

		CreateUserID,

		CreateDate,

		ApprovalUserID,

		ApprovalDate,

		IsApprovaled,

		IsPass,

		IsWhole,

		ApprovalContent,

		ApprovalSuggestion,

		ApprovalResult,

		ApprovalRemark,

		Reservation1,

		Reservation2,

		Reservation3,

		Reservation4,

		Reservation5,

	}

	#endregion

}
