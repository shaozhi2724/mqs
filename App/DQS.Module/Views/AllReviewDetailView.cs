/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllReviewDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllReviewDetailView : ViewBase
	{
		public int 复核单ID
		{
			get { return (int)this.GetValue("复核单ID"); } 
			set { this.SetValue("复核单ID", value); } 
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

		public AllReviewDetailView()
		{
			this.ViewName = "vw_AllReviewDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("复核单ID", AllReviewDetailViewFields.复核单ID);
			this.Fields.Add("药品ID", AllReviewDetailViewFields.药品ID);
			this.Fields.Add("药品编号", AllReviewDetailViewFields.药品编号);
			this.Fields.Add("药品名称", AllReviewDetailViewFields.药品名称);
			this.Fields.Add("生产厂商", AllReviewDetailViewFields.生产厂商);
			this.Fields.Add("规格", AllReviewDetailViewFields.规格);
			this.Fields.Add("剂型", AllReviewDetailViewFields.剂型);
			this.Fields.Add("药品类别", AllReviewDetailViewFields.药品类别);
			this.Fields.Add("单位", AllReviewDetailViewFields.单位);
			this.Fields.Add("批号", AllReviewDetailViewFields.批号);
			this.Fields.Add("生产日期", AllReviewDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllReviewDetailViewFields.有效期至);
			this.Fields.Add("出库数量", AllReviewDetailViewFields.出库数量);
			this.Fields.Add("复核数量", AllReviewDetailViewFields.复核数量);
		}
	}

	#region AllReviewDetailViewFields

	public class AllReviewDetailViewFields
	{
		public static EntityField 复核单ID
		{
			get { return new EntityField("vw_AllReviewDetail", 0, "复核单ID", SqlDbType.Int); }
		}

		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllReviewDetail", 1, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllReviewDetail", 2, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllReviewDetail", 3, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllReviewDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllReviewDetail", 5, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllReviewDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllReviewDetail", 7, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllReviewDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllReviewDetail", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllReviewDetail", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllReviewDetail", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 出库数量
		{
			get { return new EntityField("vw_AllReviewDetail", 12, "出库数量", SqlDbType.Int); }
		}

		public static EntityField 复核数量
		{
			get { return new EntityField("vw_AllReviewDetail", 13, "复核数量", SqlDbType.Int); }
		}

	}

	#endregion

}
