/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllSamplingDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllSamplingDetailView : ViewBase
	{
		public int 验收单ID
		{
			get { return (int)this.GetValue("验收单ID"); } 
			set { this.SetValue("验收单ID", value); } 
		}

		public int 药品ID
		{
			get { return (int)this.GetValue("药品ID"); } 
			set { this.SetValue("药品ID", value); } 
		}

		public string 药品编号
		{
			get { return (string)this.GetValue("药品编号"); } 
			set { this.SetValue("药品编号", value); } 
		}

		public string 药品名称
		{
			get { return (string)this.GetValue("药品名称"); } 
			set { this.SetValue("药品名称", value); } 
		}

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
		}

		public string 规格
		{
			get { return (string)this.GetValue("规格"); } 
			set { this.SetValue("规格", value); } 
		}

		public string 剂型
		{
			get { return (string)this.GetValue("剂型"); } 
			set { this.SetValue("剂型", value); } 
		}

		public string 药品类别
		{
			get { return (string)this.GetValue("药品类别"); } 
			set { this.SetValue("药品类别", value); } 
		}

		public string 单位
		{
			get { return (string)this.GetValue("单位"); } 
			set { this.SetValue("单位", value); } 
		}

		public string 批号
		{
			get { return (string)this.GetValue("批号"); } 
			set { this.SetValue("批号", value); } 
		}

		public DateTime 生产日期
		{
			get { return (DateTime)this.GetValue("生产日期"); } 
			set { this.SetValue("生产日期", value); } 
		}

		public DateTime 有效期至
		{
			get { return (DateTime)this.GetValue("有效期至"); } 
			set { this.SetValue("有效期至", value); } 
		}

		public int 订单数量
		{
			get { return (int)this.GetValue("订单数量"); } 
			set { this.SetValue("订单数量", value); } 
		}

		public int 抽检数量
		{
			get { return (int)this.GetValue("抽检数量"); } 
			set { this.SetValue("抽检数量", value); } 
		}

		public int 抽检合格数量
		{
			get { return (int)this.GetValue("抽检合格数量"); } 
			set { this.SetValue("抽检合格数量", value); } 
		}

		public int 抽检不合格数量
		{
			get { return (int)this.GetValue("抽检不合格数量"); } 
			set { this.SetValue("抽检不合格数量", value); } 
		}

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

		public string 检查方式方法
		{
			get { return (string)this.GetValue("检查方式（方法）"); } 
			set { this.SetValue("检查方式（方法）", value); } 
		}

		public string 检查的情况
		{
			get { return (string)this.GetValue("检查的情况"); } 
			set { this.SetValue("检查的情况", value); } 
		}

		public string 检查的结果
		{
			get { return (string)this.GetValue("检查的结果"); } 
			set { this.SetValue("检查的结果", value); } 
		}

		public string 处理结果
		{
			get { return (string)this.GetValue("处理结果"); } 
			set { this.SetValue("处理结果", value); } 
		}

		public string 备注
		{
			get { return (string)this.GetValue("备注"); } 
			set { this.SetValue("备注", value); } 
		}

		public AllSamplingDetailView()
		{
			this.ViewName = "vw_AllSamplingDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("验收单ID", AllSamplingDetailViewFields.验收单ID);
			this.Fields.Add("药品ID", AllSamplingDetailViewFields.药品ID);
			this.Fields.Add("药品编号", AllSamplingDetailViewFields.药品编号);
			this.Fields.Add("药品名称", AllSamplingDetailViewFields.药品名称);
			this.Fields.Add("生产厂商", AllSamplingDetailViewFields.生产厂商);
			this.Fields.Add("规格", AllSamplingDetailViewFields.规格);
			this.Fields.Add("剂型", AllSamplingDetailViewFields.剂型);
			this.Fields.Add("药品类别", AllSamplingDetailViewFields.药品类别);
			this.Fields.Add("单位", AllSamplingDetailViewFields.单位);
			this.Fields.Add("批号", AllSamplingDetailViewFields.批号);
			this.Fields.Add("生产日期", AllSamplingDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllSamplingDetailViewFields.有效期至);
			this.Fields.Add("订单数量", AllSamplingDetailViewFields.订单数量);
			this.Fields.Add("抽检数量", AllSamplingDetailViewFields.抽检数量);
			this.Fields.Add("抽检合格数量", AllSamplingDetailViewFields.抽检合格数量);
			this.Fields.Add("抽检不合格数量", AllSamplingDetailViewFields.抽检不合格数量);
			this.Fields.Add("检查项目ID", AllSamplingDetailViewFields.检查项目ID);
			this.Fields.Add("检查项目编号", AllSamplingDetailViewFields.检查项目编号);
			this.Fields.Add("检查项目名称", AllSamplingDetailViewFields.检查项目名称);
			this.Fields.Add("检查项目内容", AllSamplingDetailViewFields.检查项目内容);
			this.Fields.Add("检查方式方法", AllSamplingDetailViewFields.检查方式方法);
			this.Fields.Add("检查的情况", AllSamplingDetailViewFields.检查的情况);
			this.Fields.Add("检查的结果", AllSamplingDetailViewFields.检查的结果);
			this.Fields.Add("处理结果", AllSamplingDetailViewFields.处理结果);
			this.Fields.Add("备注", AllSamplingDetailViewFields.备注);
		}
	}

	#region AllSamplingDetailViewFields

	public class AllSamplingDetailViewFields
	{
		public static EntityField 验收单ID
		{
			get { return new EntityField("vw_AllSamplingDetail", 0, "验收单ID", SqlDbType.Int); }
		}

		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllSamplingDetail", 1, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllSamplingDetail", 2, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllSamplingDetail", 3, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllSamplingDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllSamplingDetail", 5, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllSamplingDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllSamplingDetail", 7, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllSamplingDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllSamplingDetail", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllSamplingDetail", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllSamplingDetail", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 订单数量
		{
			get { return new EntityField("vw_AllSamplingDetail", 12, "订单数量", SqlDbType.Int); }
		}

		public static EntityField 抽检数量
		{
			get { return new EntityField("vw_AllSamplingDetail", 13, "抽检数量", SqlDbType.Int); }
		}

		public static EntityField 抽检合格数量
		{
			get { return new EntityField("vw_AllSamplingDetail", 14, "抽检合格数量", SqlDbType.Int); }
		}

		public static EntityField 抽检不合格数量
		{
			get { return new EntityField("vw_AllSamplingDetail", 15, "抽检不合格数量", SqlDbType.Int); }
		}

		public static EntityField 检查项目ID
		{
			get { return new EntityField("vw_AllSamplingDetail", 16, "检查项目ID", SqlDbType.Int); }
		}

		public static EntityField 检查项目编号
		{
			get { return new EntityField("vw_AllSamplingDetail", 17, "检查项目编号", SqlDbType.NVarChar); }
		}

		public static EntityField 检查项目名称
		{
			get { return new EntityField("vw_AllSamplingDetail", 18, "检查项目名称", SqlDbType.NVarChar); }
		}

		public static EntityField 检查项目内容
		{
			get { return new EntityField("vw_AllSamplingDetail", 19, "检查项目内容", SqlDbType.NVarChar); }
		}

		public static EntityField 检查方式方法
		{
			get { return new EntityField("vw_AllSamplingDetail", 20, "检查方式（方法）", SqlDbType.NVarChar); }
		}

		public static EntityField 检查的情况
		{
			get { return new EntityField("vw_AllSamplingDetail", 21, "检查的情况", SqlDbType.NVarChar); }
		}

		public static EntityField 检查的结果
		{
			get { return new EntityField("vw_AllSamplingDetail", 22, "检查的结果", SqlDbType.NVarChar); }
		}

		public static EntityField 处理结果
		{
			get { return new EntityField("vw_AllSamplingDetail", 23, "处理结果", SqlDbType.NVarChar); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllSamplingDetail", 24, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
