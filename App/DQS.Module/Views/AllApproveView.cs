/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllApproveView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllApproveView : ViewBase
	{
		public int ApproveID
		{
			get { return (int)this.GetValue("ApproveID"); } 
			set { this.SetValue("ApproveID", value); } 
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

		public bool IsWhole
		{
			get { return (bool)this.GetValue("IsWhole"); } 
			set { this.SetValue("IsWhole", value); } 
		}

		public int ApproveOrder
		{
			get { return (int)this.GetValue("ApproveOrder"); } 
			set { this.SetValue("ApproveOrder", value); } 
		}

		public Guid CreateUserID
		{
			get { return (Guid)this.GetValue("CreateUserID"); } 
			set { this.SetValue("CreateUserID", value); } 
		}

		public Guid ApprovalUserID
		{
			get { return (Guid)this.GetValue("ApprovalUserID"); } 
			set { this.SetValue("ApprovalUserID", value); } 
		}

		public bool IsApprovaled
		{
			get { return (bool)this.GetValue("IsApprovaled"); } 
			set { this.SetValue("IsApprovaled", value); } 
		}

		public string 编号
		{
			get { return (string)this.GetValue("编号"); } 
			set { this.SetValue("编号", value); } 
		}

		public string 标题
		{
			get { return (string)this.GetValue("标题"); } 
			set { this.SetValue("标题", value); } 
		}

		public string 内容
		{
			get { return (string)this.GetValue("内容"); } 
			set { this.SetValue("内容", value); } 
		}

		public string 申请人
		{
			get { return (string)this.GetValue("申请人"); } 
			set { this.SetValue("申请人", value); } 
		}

		public DateTime 申请时间
		{
			get { return (DateTime)this.GetValue("申请时间"); } 
			set { this.SetValue("申请时间", value); } 
		}

		public string 审批类型
		{
			get { return (string)this.GetValue("审批类型"); } 
			set { this.SetValue("审批类型", value); } 
		}

		public string 状态
		{
			get { return (string)this.GetValue("状态"); } 
			set { this.SetValue("状态", value); } 
		}

		public string 审批人
		{
			get { return (string)this.GetValue("审批人"); } 
			set { this.SetValue("审批人", value); } 
		}

		public string 是否审批
		{
			get { return (string)this.GetValue("是否审批"); } 
			set { this.SetValue("是否审批", value); } 
		}

		public string 审批时间
		{
			get { return (string)this.GetValue("审批时间"); } 
			set { this.SetValue("审批时间", value); } 
		}

		public string 审批顺序
		{
			get { return (string)this.GetValue("审批顺序"); } 
			set { this.SetValue("审批顺序", value); } 
		}

		public string 审批意见
		{
			get { return (string)this.GetValue("审批意见"); } 
			set { this.SetValue("审批意见", value); } 
		}

		public string 审批结果
		{
			get { return (string)this.GetValue("审批结果"); } 
			set { this.SetValue("审批结果", value); } 
		}

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public AllApproveView()
		{
			this.ViewName = "vw_AllApprove";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("ApproveID", AllApproveViewFields.ApproveID);
			this.Fields.Add("DocumentCode", AllApproveViewFields.DocumentCode);
			this.Fields.Add("BillCode", AllApproveViewFields.BillCode);
			this.Fields.Add("IsWhole", AllApproveViewFields.IsWhole);
			this.Fields.Add("ApproveOrder", AllApproveViewFields.ApproveOrder);
			this.Fields.Add("CreateUserID", AllApproveViewFields.CreateUserID);
			this.Fields.Add("ApprovalUserID", AllApproveViewFields.ApprovalUserID);
			this.Fields.Add("IsApprovaled", AllApproveViewFields.IsApprovaled);
			this.Fields.Add("编号", AllApproveViewFields.编号);
			this.Fields.Add("标题", AllApproveViewFields.标题);
			this.Fields.Add("内容", AllApproveViewFields.内容);
			this.Fields.Add("申请人", AllApproveViewFields.申请人);
			this.Fields.Add("申请时间", AllApproveViewFields.申请时间);
			this.Fields.Add("审批类型", AllApproveViewFields.审批类型);
			this.Fields.Add("状态", AllApproveViewFields.状态);
			this.Fields.Add("审批人", AllApproveViewFields.审批人);
			this.Fields.Add("是否审批", AllApproveViewFields.是否审批);
			this.Fields.Add("审批时间", AllApproveViewFields.审批时间);
			this.Fields.Add("审批顺序", AllApproveViewFields.审批顺序);
			this.Fields.Add("审批意见", AllApproveViewFields.审批意见);
			this.Fields.Add("审批结果", AllApproveViewFields.审批结果);
			this.Fields.Add("备注", AllApproveViewFields.备注);
		}
	}

	#region AllApproveViewFields

	public class AllApproveViewFields
	{
		public static EntityField ApproveID
		{
			get { return new EntityField("vw_AllApprove", 0, "ApproveID", SqlDbType.Int); }
		}

		public static EntityField DocumentCode
		{
			get { return new EntityField("vw_AllApprove", 1, "DocumentCode", SqlDbType.NVarChar); }
		}

		public static EntityField BillCode
		{
			get { return new EntityField("vw_AllApprove", 2, "BillCode", SqlDbType.NVarChar); }
		}

		public static EntityField IsWhole
		{
			get { return new EntityField("vw_AllApprove", 3, "IsWhole", SqlDbType.Bit); }
		}

		public static EntityField ApproveOrder
		{
			get { return new EntityField("vw_AllApprove", 4, "ApproveOrder", SqlDbType.Int); }
		}

		public static EntityField CreateUserID
		{
			get { return new EntityField("vw_AllApprove", 5, "CreateUserID", SqlDbType.UniqueIdentifier); }
		}

		public static EntityField ApprovalUserID
		{
			get { return new EntityField("vw_AllApprove", 6, "ApprovalUserID", SqlDbType.UniqueIdentifier); }
		}

		public static EntityField IsApprovaled
		{
			get { return new EntityField("vw_AllApprove", 7, "IsApprovaled", SqlDbType.Bit); }
		}

		public static EntityField 编号
		{
			get { return new EntityField("vw_AllApprove", 8, "编号", SqlDbType.NVarChar); }
		}

		public static EntityField 标题
		{
			get { return new EntityField("vw_AllApprove", 9, "标题", SqlDbType.NVarChar); }
		}

		public static EntityField 内容
		{
			get { return new EntityField("vw_AllApprove", 10, "内容", SqlDbType.NVarChar); }
		}

		public static EntityField 申请人
		{
			get { return new EntityField("vw_AllApprove", 11, "申请人", SqlDbType.NVarChar); }
		}

		public static EntityField 申请时间
		{
			get { return new EntityField("vw_AllApprove", 12, "申请时间", SqlDbType.DateTime); }
		}

		public static EntityField 审批类型
		{
			get { return new EntityField("vw_AllApprove", 13, "审批类型", SqlDbType.VarChar); }
		}

		public static EntityField 状态
		{
			get { return new EntityField("vw_AllApprove", 14, "状态", SqlDbType.VarChar); }
		}

		public static EntityField 审批人
		{
			get { return new EntityField("vw_AllApprove", 15, "审批人", SqlDbType.NVarChar); }
		}

		public static EntityField 是否审批
		{
			get { return new EntityField("vw_AllApprove", 16, "是否审批", SqlDbType.VarChar); }
		}

		public static EntityField 审批时间
		{
			get { return new EntityField("vw_AllApprove", 17, "审批时间", SqlDbType.VarChar); }
		}

		public static EntityField 审批顺序
		{
			get { return new EntityField("vw_AllApprove", 18, "审批顺序", SqlDbType.VarChar); }
		}

		public static EntityField 审批意见
		{
			get { return new EntityField("vw_AllApprove", 19, "审批意见", SqlDbType.NVarChar); }
		}

		public static EntityField 审批结果
		{
			get { return new EntityField("vw_AllApprove", 20, "审批结果", SqlDbType.NVarChar); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllApprove", 21, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
