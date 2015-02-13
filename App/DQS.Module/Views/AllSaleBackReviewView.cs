/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllSaleBackReviewView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllSaleBackReviewView : ViewBase
	{
		public int 复核ID
		{
			get { return (int)this.GetValue("复核ID"); } 
			set { this.SetValue("复核ID", value); } 
		}

		public string 复核单号
		{
			get { return (string)this.GetValue("复核单号"); } 
			set { this.SetValue("复核单号", value); } 
		}

		public DateTime 复核日期
		{
			get { return (DateTime)this.GetValue("复核日期"); } 
			set { this.SetValue("复核日期", value); } 
		}

		public string 复核人员
		{
			get { return (string)this.GetValue("复核人员"); } 
			set { this.SetValue("复核人员", value); } 
		}

		public string 销售单号
		{
			get { return (string)this.GetValue("销售单号"); } 
			set { this.SetValue("销售单号", value); } 
		}

		public string 往来单位Spell
		{
			get { return (string)this.GetValue("往来单位Spell"); } 
			set { this.SetValue("往来单位Spell", value); } 
		}

		public string 往来单位名称
		{
			get { return (string)this.GetValue("往来单位名称"); } 
			set { this.SetValue("往来单位名称", value); } 
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

		public int 出库数量
		{
			get { return (int)this.GetValue("出库数量"); } 
			set { this.SetValue("出库数量", value); } 
		}

		public int 复核数量
		{
			get { return (int)this.GetValue("复核数量"); } 
			set { this.SetValue("复核数量", value); } 
		}

		public AllSaleBackReviewView()
		{
			this.ViewName = "vw_AllSaleBackReview";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("复核ID", AllSaleBackReviewViewFields.复核ID);
			this.Fields.Add("复核单号", AllSaleBackReviewViewFields.复核单号);
			this.Fields.Add("复核日期", AllSaleBackReviewViewFields.复核日期);
			this.Fields.Add("复核人员", AllSaleBackReviewViewFields.复核人员);
			this.Fields.Add("销售单号", AllSaleBackReviewViewFields.销售单号);
			this.Fields.Add("往来单位Spell", AllSaleBackReviewViewFields.往来单位Spell);
			this.Fields.Add("往来单位名称", AllSaleBackReviewViewFields.往来单位名称);
			this.Fields.Add("创建人", AllSaleBackReviewViewFields.创建人);
			this.Fields.Add("创建日期", AllSaleBackReviewViewFields.创建日期);
			this.Fields.Add("最后修改人", AllSaleBackReviewViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllSaleBackReviewViewFields.最后修改时间);
			this.Fields.Add("备注", AllSaleBackReviewViewFields.备注);
			this.Fields.Add("药品ID", AllSaleBackReviewViewFields.药品ID);
			this.Fields.Add("药品编号", AllSaleBackReviewViewFields.药品编号);
			this.Fields.Add("药品名称", AllSaleBackReviewViewFields.药品名称);
			this.Fields.Add("生产厂商", AllSaleBackReviewViewFields.生产厂商);
			this.Fields.Add("规格", AllSaleBackReviewViewFields.规格);
			this.Fields.Add("剂型", AllSaleBackReviewViewFields.剂型);
			this.Fields.Add("药品类别", AllSaleBackReviewViewFields.药品类别);
			this.Fields.Add("单位", AllSaleBackReviewViewFields.单位);
			this.Fields.Add("批号", AllSaleBackReviewViewFields.批号);
			this.Fields.Add("生产日期", AllSaleBackReviewViewFields.生产日期);
			this.Fields.Add("有效期至", AllSaleBackReviewViewFields.有效期至);
			this.Fields.Add("出库数量", AllSaleBackReviewViewFields.出库数量);
			this.Fields.Add("复核数量", AllSaleBackReviewViewFields.复核数量);
		}
	}

	#region AllSaleBackReviewViewFields

	public class AllSaleBackReviewViewFields
	{
		public static EntityField 复核ID
		{
			get { return new EntityField("vw_AllSaleBackReview", 0, "复核ID", SqlDbType.Int); }
		}

		public static EntityField 复核单号
		{
			get { return new EntityField("vw_AllSaleBackReview", 1, "复核单号", SqlDbType.NVarChar); }
		}

		public static EntityField 复核日期
		{
			get { return new EntityField("vw_AllSaleBackReview", 2, "复核日期", SqlDbType.DateTime); }
		}

		public static EntityField 复核人员
		{
			get { return new EntityField("vw_AllSaleBackReview", 3, "复核人员", SqlDbType.NVarChar); }
		}

		public static EntityField 销售单号
		{
			get { return new EntityField("vw_AllSaleBackReview", 4, "销售单号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位Spell
		{
			get { return new EntityField("vw_AllSaleBackReview", 5, "往来单位Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllSaleBackReview", 6, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllSaleBackReview", 7, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllSaleBackReview", 8, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllSaleBackReview", 9, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllSaleBackReview", 10, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllSaleBackReview", 11, "备注", SqlDbType.NVarChar); }
		}

		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllSaleBackReview", 12, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllSaleBackReview", 13, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllSaleBackReview", 14, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllSaleBackReview", 15, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllSaleBackReview", 16, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllSaleBackReview", 17, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllSaleBackReview", 18, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllSaleBackReview", 19, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllSaleBackReview", 20, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllSaleBackReview", 21, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllSaleBackReview", 22, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 出库数量
		{
			get { return new EntityField("vw_AllSaleBackReview", 23, "出库数量", SqlDbType.Int); }
		}

		public static EntityField 复核数量
		{
			get { return new EntityField("vw_AllSaleBackReview", 24, "复核数量", SqlDbType.Int); }
		}

	}

	#endregion

}
