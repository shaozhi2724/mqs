/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: ReceiveAcceptConditionView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class ReceiveAcceptConditionView : ViewBase
	{
		public int 检查项目ID
		{
			get { return (int)this.GetValue("检查项目ID"); } 
			set { this.SetValue("检查项目ID", value); } 
		}

		public string 检查项目编号
		{
			get { return (string)this.GetValue("检查项目编号"); } 
			set { this.SetValue("检查项目编号", value); } 
		}

		public string 检查项目名称
		{
			get { return (string)this.GetValue("检查项目名称"); } 
			set { this.SetValue("检查项目名称", value); } 
		}

		public string 检查项目内容
		{
			get { return (string)this.GetValue("检查项目内容"); } 
			set { this.SetValue("检查项目内容", value); } 
		}

		public string 检查方式
		{
			get { return (string)this.GetValue("检查方式"); } 
			set { this.SetValue("检查方式", value); } 
		}

		public string 检查类型名称
		{
			get { return (string)this.GetValue("检查类型名称"); } 
			set { this.SetValue("检查类型名称", value); } 
		}

		public string 创建人
		{
			get { return (string)this.GetValue("创建人"); } 
			set { this.SetValue("创建人", value); } 
		}

		public DateTime 创建时间
		{
			get { return (DateTime)this.GetValue("创建时间"); } 
			set { this.SetValue("创建时间", value); } 
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

		public ReceiveAcceptConditionView()
		{
			this.ViewName = "vw_ReceiveAcceptCondition";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("检查项目ID", ReceiveAcceptConditionViewFields.检查项目ID);
			this.Fields.Add("检查项目编号", ReceiveAcceptConditionViewFields.检查项目编号);
			this.Fields.Add("检查项目名称", ReceiveAcceptConditionViewFields.检查项目名称);
			this.Fields.Add("检查项目内容", ReceiveAcceptConditionViewFields.检查项目内容);
			this.Fields.Add("检查方式", ReceiveAcceptConditionViewFields.检查方式);
			this.Fields.Add("检查类型名称", ReceiveAcceptConditionViewFields.检查类型名称);
			this.Fields.Add("创建人", ReceiveAcceptConditionViewFields.创建人);
			this.Fields.Add("创建时间", ReceiveAcceptConditionViewFields.创建时间);
			this.Fields.Add("最后修改人", ReceiveAcceptConditionViewFields.最后修改人);
			this.Fields.Add("最后修改时间", ReceiveAcceptConditionViewFields.最后修改时间);
			this.Fields.Add("备注", ReceiveAcceptConditionViewFields.备注);
		}
	}

	#region ReceiveAcceptConditionViewFields

	public class ReceiveAcceptConditionViewFields
	{
		public static EntityField 检查项目ID
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 0, "检查项目ID", SqlDbType.Int); }
		}

		public static EntityField 检查项目编号
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 1, "检查项目编号", SqlDbType.NVarChar); }
		}

		public static EntityField 检查项目名称
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 2, "检查项目名称", SqlDbType.NVarChar); }
		}

		public static EntityField 检查项目内容
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 3, "检查项目内容", SqlDbType.NVarChar); }
		}

		public static EntityField 检查方式
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 4, "检查方式", SqlDbType.NVarChar); }
		}

		public static EntityField 检查类型名称
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 5, "检查类型名称", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 6, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建时间
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 7, "创建时间", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 8, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 9, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_ReceiveAcceptCondition", 10, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
