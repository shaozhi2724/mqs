/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllEmployeeTrainPlanView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllEmployeeTrainPlanView : ViewBase
	{
		public int 培训ID
		{
			get { return (int)this.GetValue("培训ID"); } 
			set { this.SetValue("培训ID", value); } 
		}

		public string 培训编号
		{
			get { return (string)this.GetValue("培训编号"); } 
			set { this.SetValue("培训编号", value); } 
		}

		public string 培训名称
		{
			get { return (string)this.GetValue("培训名称"); } 
			set { this.SetValue("培训名称", value); } 
		}

		public string 申请人
		{
			get { return (string)this.GetValue("申请人"); } 
			set { this.SetValue("申请人", value); } 
		}

		public string 申请人Spell
		{
			get { return (string)this.GetValue("申请人Spell"); } 
			set { this.SetValue("申请人Spell", value); } 
		}

		public string 培训对象
		{
			get { return (string)this.GetValue("培训对象"); } 
			set { this.SetValue("培训对象", value); } 
		}

		public string 培训内容
		{
			get { return (string)this.GetValue("培训内容"); } 
			set { this.SetValue("培训内容", value); } 
		}

		public string 承办部门人
		{
			get { return (string)this.GetValue("承办部门人"); } 
			set { this.SetValue("承办部门人", value); } 
		}

		public string 协助部门人
		{
			get { return (string)this.GetValue("协助部门人"); } 
			set { this.SetValue("协助部门人", value); } 
		}

		public string 培训类别
		{
			get { return (string)this.GetValue("培训类别"); } 
			set { this.SetValue("培训类别", value); } 
		}

		public string 培训方式
		{
			get { return (string)this.GetValue("培训方式"); } 
			set { this.SetValue("培训方式", value); } 
		}

		public string 培训讲师机构
		{
			get { return (string)this.GetValue("培训讲师机构"); } 
			set { this.SetValue("培训讲师机构", value); } 
		}

		public string 教材
		{
			get { return (string)this.GetValue("教材"); } 
			set { this.SetValue("教材", value); } 
		}

		public string 培训地点
		{
			get { return (string)this.GetValue("培训地点"); } 
			set { this.SetValue("培训地点", value); } 
		}

		public string 现有水平
		{
			get { return (string)this.GetValue("现有水平"); } 
			set { this.SetValue("现有水平", value); } 
		}

		public string 预期水平
		{
			get { return (string)this.GetValue("预期水平"); } 
			set { this.SetValue("预期水平", value); } 
		}

		public DateTime 培训开始时间
		{
			get { return (DateTime)this.GetValue("培训开始时间"); } 
			set { this.SetValue("培训开始时间", value); } 
		}

		public DateTime 培训结束时间
		{
			get { return (DateTime)this.GetValue("培训结束时间"); } 
			set { this.SetValue("培训结束时间", value); } 
		}

		public string 培训时长
		{
			get { return (string)this.GetValue("培训时长"); } 
			set { this.SetValue("培训时长", value); } 
		}

		public string 考核人
		{
			get { return (string)this.GetValue("考核人"); } 
			set { this.SetValue("考核人", value); } 
		}

		public string 考核方式
		{
			get { return (string)this.GetValue("考核方式"); } 
			set { this.SetValue("考核方式", value); } 
		}

		public string 费用预算
		{
			get { return (string)this.GetValue("费用预算"); } 
			set { this.SetValue("费用预算", value); } 
		}

		public DateTime 申请时间
		{
			get { return (DateTime)this.GetValue("申请时间"); } 
			set { this.SetValue("申请时间", value); } 
		}

		public bool 是否已培训
		{
			get { return (bool)this.GetValue("是否已培训"); } 
			set { this.SetValue("是否已培训", value); } 
		}

		public string 创建人
		{
			get { return (string)this.GetValue("创建人"); } 
			set { this.SetValue("创建人", value); } 
		}

		public DateTime 创建日期
		{
			get { return (DateTime)this.GetValue("创建日期"); } 
			set { this.SetValue("创建日期", value); } 
		}

		public string 最后修改人
		{
			get { return (string)this.GetValue("最后修改人"); } 
			set { this.SetValue("最后修改人", value); } 
		}

		public DateTime 最后修改时间
		{
			get { return (DateTime)this.GetValue("最后修改时间"); } 
			set { this.SetValue("最后修改时间", value); } 
		}

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public AllEmployeeTrainPlanView()
		{
			this.ViewName = "vw_AllEmployeeTrainPlan";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("培训ID", AllEmployeeTrainPlanViewFields.培训ID);
			this.Fields.Add("培训编号", AllEmployeeTrainPlanViewFields.培训编号);
			this.Fields.Add("培训名称", AllEmployeeTrainPlanViewFields.培训名称);
			this.Fields.Add("申请人", AllEmployeeTrainPlanViewFields.申请人);
			this.Fields.Add("申请人Spell", AllEmployeeTrainPlanViewFields.申请人Spell);
			this.Fields.Add("培训对象", AllEmployeeTrainPlanViewFields.培训对象);
			this.Fields.Add("培训内容", AllEmployeeTrainPlanViewFields.培训内容);
			this.Fields.Add("承办部门人", AllEmployeeTrainPlanViewFields.承办部门人);
			this.Fields.Add("协助部门人", AllEmployeeTrainPlanViewFields.协助部门人);
			this.Fields.Add("培训类别", AllEmployeeTrainPlanViewFields.培训类别);
			this.Fields.Add("培训方式", AllEmployeeTrainPlanViewFields.培训方式);
			this.Fields.Add("培训讲师机构", AllEmployeeTrainPlanViewFields.培训讲师机构);
			this.Fields.Add("教材", AllEmployeeTrainPlanViewFields.教材);
			this.Fields.Add("培训地点", AllEmployeeTrainPlanViewFields.培训地点);
			this.Fields.Add("现有水平", AllEmployeeTrainPlanViewFields.现有水平);
			this.Fields.Add("预期水平", AllEmployeeTrainPlanViewFields.预期水平);
			this.Fields.Add("培训开始时间", AllEmployeeTrainPlanViewFields.培训开始时间);
			this.Fields.Add("培训结束时间", AllEmployeeTrainPlanViewFields.培训结束时间);
			this.Fields.Add("培训时长", AllEmployeeTrainPlanViewFields.培训时长);
			this.Fields.Add("考核人", AllEmployeeTrainPlanViewFields.考核人);
			this.Fields.Add("考核方式", AllEmployeeTrainPlanViewFields.考核方式);
			this.Fields.Add("费用预算", AllEmployeeTrainPlanViewFields.费用预算);
			this.Fields.Add("申请时间", AllEmployeeTrainPlanViewFields.申请时间);
			this.Fields.Add("是否已培训", AllEmployeeTrainPlanViewFields.是否已培训);
			this.Fields.Add("创建人", AllEmployeeTrainPlanViewFields.创建人);
			this.Fields.Add("创建日期", AllEmployeeTrainPlanViewFields.创建日期);
			this.Fields.Add("最后修改人", AllEmployeeTrainPlanViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllEmployeeTrainPlanViewFields.最后修改时间);
			this.Fields.Add("备注", AllEmployeeTrainPlanViewFields.备注);
		}
	}

	#region AllEmployeeTrainPlanViewFields

	public class AllEmployeeTrainPlanViewFields
	{
		public static EntityField 培训ID
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 0, "培训ID", SqlDbType.Int); }
		}

		public static EntityField 培训编号
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 1, "培训编号", SqlDbType.NVarChar); }
		}

		public static EntityField 培训名称
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 2, "培训名称", SqlDbType.NVarChar); }
		}

		public static EntityField 申请人
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 3, "申请人", SqlDbType.NVarChar); }
		}

		public static EntityField 申请人Spell
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 4, "申请人Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 培训对象
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 5, "培训对象", SqlDbType.NVarChar); }
		}

		public static EntityField 培训内容
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 6, "培训内容", SqlDbType.NVarChar); }
		}

		public static EntityField 承办部门人
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 7, "承办部门人", SqlDbType.NVarChar); }
		}

		public static EntityField 协助部门人
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 8, "协助部门人", SqlDbType.NVarChar); }
		}

		public static EntityField 培训类别
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 9, "培训类别", SqlDbType.NVarChar); }
		}

		public static EntityField 培训方式
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 10, "培训方式", SqlDbType.NVarChar); }
		}

		public static EntityField 培训讲师机构
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 11, "培训讲师机构", SqlDbType.NVarChar); }
		}

		public static EntityField 教材
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 12, "教材", SqlDbType.NVarChar); }
		}

		public static EntityField 培训地点
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 13, "培训地点", SqlDbType.NVarChar); }
		}

		public static EntityField 现有水平
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 14, "现有水平", SqlDbType.NVarChar); }
		}

		public static EntityField 预期水平
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 15, "预期水平", SqlDbType.NVarChar); }
		}

		public static EntityField 培训开始时间
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 16, "培训开始时间", SqlDbType.DateTime); }
		}

		public static EntityField 培训结束时间
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 17, "培训结束时间", SqlDbType.DateTime); }
		}

		public static EntityField 培训时长
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 18, "培训时长", SqlDbType.NVarChar); }
		}

		public static EntityField 考核人
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 19, "考核人", SqlDbType.NVarChar); }
		}

		public static EntityField 考核方式
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 20, "考核方式", SqlDbType.NVarChar); }
		}

		public static EntityField 费用预算
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 21, "费用预算", SqlDbType.NVarChar); }
		}

		public static EntityField 申请时间
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 22, "申请时间", SqlDbType.DateTime); }
		}

		public static EntityField 是否已培训
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 23, "是否已培训", SqlDbType.Bit); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 24, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 25, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 26, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 27, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllEmployeeTrainPlan", 28, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
