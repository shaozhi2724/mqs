/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllAdverseReactionView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllAdverseReactionView : ViewBase
	{
		public int 记录ID
		{
			get { return (int)this.GetValue("记录ID"); } 
			set { this.SetValue("记录ID", value); } 
		}

		public string 记录编号
		{
			get { return (string)this.GetValue("记录编号"); } 
			set { this.SetValue("记录编号", value); } 
		}

		public string 使用人
		{
			get { return (string)this.GetValue("使用人"); } 
			set { this.SetValue("使用人", value); } 
		}

		public string 使用人Spell
		{
			get { return (string)this.GetValue("使用人Spell"); } 
			set { this.SetValue("使用人Spell", value); } 
		}

		public DateTime 使用时间
		{
			get { return (DateTime)this.GetValue("使用时间"); } 
			set { this.SetValue("使用时间", value); } 
		}

		public DateTime 发生反应时间
		{
			get { return (DateTime)this.GetValue("发生反应时间"); } 
			set { this.SetValue("发生反应时间", value); } 
		}

		public string 使用人联系方式
		{
			get { return (string)this.GetValue("使用人联系方式"); } 
			set { this.SetValue("使用人联系方式", value); } 
		}

		public string 使用人所在医院
		{
			get { return (string)this.GetValue("使用人所在医院"); } 
			set { this.SetValue("使用人所在医院", value); } 
		}

		public string 接线员
		{
			get { return (string)this.GetValue("接线员"); } 
			set { this.SetValue("接线员", value); } 
		}

		public string 接线员Spell
		{
			get { return (string)this.GetValue("接线员Spell"); } 
			set { this.SetValue("接线员Spell", value); } 
		}

		public string 产品编号
		{
			get { return (string)this.GetValue("产品编号"); } 
			set { this.SetValue("产品编号", value); } 
		}

		public string 产品名称
		{
			get { return (string)this.GetValue("产品名称"); } 
			set { this.SetValue("产品名称", value); } 
		}

		public string 规格型号
		{
			get { return (string)this.GetValue("规格型号"); } 
			set { this.SetValue("规格型号", value); } 
		}

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
		}

		public string 注册证号
		{
			get { return (string)this.GetValue("注册证号"); } 
			set { this.SetValue("注册证号", value); } 
		}

		public string 批号
		{
			get { return (string)this.GetValue("批号"); } 
			set { this.SetValue("批号", value); } 
		}

		public string 不良反应症状
		{
			get { return (string)this.GetValue("不良反应症状"); } 
			set { this.SetValue("不良反应症状", value); } 
		}

		public string 调查情况
		{
			get { return (string)this.GetValue("调查情况"); } 
			set { this.SetValue("调查情况", value); } 
		}

		public string 处理人
		{
			get { return (string)this.GetValue("处理人"); } 
			set { this.SetValue("处理人", value); } 
		}

		public DateTime 处理时间
		{
			get { return (DateTime)this.GetValue("处理时间"); } 
			set { this.SetValue("处理时间", value); } 
		}

		public string 处理方案
		{
			get { return (string)this.GetValue("处理方案"); } 
			set { this.SetValue("处理方案", value); } 
		}

		public string 处理结果
		{
			get { return (string)this.GetValue("处理结果"); } 
			set { this.SetValue("处理结果", value); } 
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

		public AllAdverseReactionView()
		{
			this.ViewName = "vw_AllAdverseReaction";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("记录ID", AllAdverseReactionViewFields.记录ID);
			this.Fields.Add("记录编号", AllAdverseReactionViewFields.记录编号);
			this.Fields.Add("使用人", AllAdverseReactionViewFields.使用人);
			this.Fields.Add("使用人Spell", AllAdverseReactionViewFields.使用人Spell);
			this.Fields.Add("使用时间", AllAdverseReactionViewFields.使用时间);
			this.Fields.Add("发生反应时间", AllAdverseReactionViewFields.发生反应时间);
			this.Fields.Add("使用人联系方式", AllAdverseReactionViewFields.使用人联系方式);
			this.Fields.Add("使用人所在医院", AllAdverseReactionViewFields.使用人所在医院);
			this.Fields.Add("接线员", AllAdverseReactionViewFields.接线员);
			this.Fields.Add("接线员Spell", AllAdverseReactionViewFields.接线员Spell);
			this.Fields.Add("产品编号", AllAdverseReactionViewFields.产品编号);
			this.Fields.Add("产品名称", AllAdverseReactionViewFields.产品名称);
			this.Fields.Add("规格型号", AllAdverseReactionViewFields.规格型号);
			this.Fields.Add("生产厂商", AllAdverseReactionViewFields.生产厂商);
			this.Fields.Add("注册证号", AllAdverseReactionViewFields.注册证号);
			this.Fields.Add("批号", AllAdverseReactionViewFields.批号);
			this.Fields.Add("不良反应症状", AllAdverseReactionViewFields.不良反应症状);
			this.Fields.Add("调查情况", AllAdverseReactionViewFields.调查情况);
			this.Fields.Add("处理人", AllAdverseReactionViewFields.处理人);
			this.Fields.Add("处理时间", AllAdverseReactionViewFields.处理时间);
			this.Fields.Add("处理方案", AllAdverseReactionViewFields.处理方案);
			this.Fields.Add("处理结果", AllAdverseReactionViewFields.处理结果);
			this.Fields.Add("创建人", AllAdverseReactionViewFields.创建人);
			this.Fields.Add("创建日期", AllAdverseReactionViewFields.创建日期);
			this.Fields.Add("最后修改人", AllAdverseReactionViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllAdverseReactionViewFields.最后修改时间);
			this.Fields.Add("备注", AllAdverseReactionViewFields.备注);
		}
	}

	#region AllAdverseReactionViewFields

	public class AllAdverseReactionViewFields
	{
		public static EntityField 记录ID
		{
			get { return new EntityField("vw_AllAdverseReaction", 0, "记录ID", SqlDbType.Int); }
		}

		public static EntityField 记录编号
		{
			get { return new EntityField("vw_AllAdverseReaction", 1, "记录编号", SqlDbType.NVarChar); }
		}

		public static EntityField 使用人
		{
			get { return new EntityField("vw_AllAdverseReaction", 2, "使用人", SqlDbType.NVarChar); }
		}

		public static EntityField 使用人Spell
		{
			get { return new EntityField("vw_AllAdverseReaction", 3, "使用人Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 使用时间
		{
			get { return new EntityField("vw_AllAdverseReaction", 4, "使用时间", SqlDbType.DateTime); }
		}

		public static EntityField 发生反应时间
		{
			get { return new EntityField("vw_AllAdverseReaction", 5, "发生反应时间", SqlDbType.DateTime); }
		}

		public static EntityField 使用人联系方式
		{
			get { return new EntityField("vw_AllAdverseReaction", 6, "使用人联系方式", SqlDbType.NVarChar); }
		}

		public static EntityField 使用人所在医院
		{
			get { return new EntityField("vw_AllAdverseReaction", 7, "使用人所在医院", SqlDbType.NVarChar); }
		}

		public static EntityField 接线员
		{
			get { return new EntityField("vw_AllAdverseReaction", 8, "接线员", SqlDbType.NVarChar); }
		}

		public static EntityField 接线员Spell
		{
			get { return new EntityField("vw_AllAdverseReaction", 9, "接线员Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllAdverseReaction", 10, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllAdverseReaction", 11, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllAdverseReaction", 12, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllAdverseReaction", 13, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 注册证号
		{
			get { return new EntityField("vw_AllAdverseReaction", 14, "注册证号", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllAdverseReaction", 15, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 不良反应症状
		{
			get { return new EntityField("vw_AllAdverseReaction", 16, "不良反应症状", SqlDbType.NVarChar); }
		}

		public static EntityField 调查情况
		{
			get { return new EntityField("vw_AllAdverseReaction", 17, "调查情况", SqlDbType.NVarChar); }
		}

		public static EntityField 处理人
		{
			get { return new EntityField("vw_AllAdverseReaction", 18, "处理人", SqlDbType.NVarChar); }
		}

		public static EntityField 处理时间
		{
			get { return new EntityField("vw_AllAdverseReaction", 19, "处理时间", SqlDbType.DateTime); }
		}

		public static EntityField 处理方案
		{
			get { return new EntityField("vw_AllAdverseReaction", 20, "处理方案", SqlDbType.NVarChar); }
		}

		public static EntityField 处理结果
		{
			get { return new EntityField("vw_AllAdverseReaction", 21, "处理结果", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllAdverseReaction", 22, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllAdverseReaction", 23, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllAdverseReaction", 24, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllAdverseReaction", 25, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllAdverseReaction", 26, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
