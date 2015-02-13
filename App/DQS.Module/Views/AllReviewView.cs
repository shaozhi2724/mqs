/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllReviewView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllReviewView : ViewBase
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

		public string 状态名称
		{
			get { return (string)this.GetValue("状态名称"); } 
			set { this.SetValue("状态名称", value); } 
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

		public AllReviewView()
		{
			this.ViewName = "vw_AllReview";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("复核ID", AllReviewViewFields.复核ID);
			this.Fields.Add("复核单号", AllReviewViewFields.复核单号);
			this.Fields.Add("复核日期", AllReviewViewFields.复核日期);
			this.Fields.Add("复核人员", AllReviewViewFields.复核人员);
			this.Fields.Add("状态名称", AllReviewViewFields.状态名称);
			this.Fields.Add("销售单号", AllReviewViewFields.销售单号);
			this.Fields.Add("往来单位Spell", AllReviewViewFields.往来单位Spell);
			this.Fields.Add("往来单位名称", AllReviewViewFields.往来单位名称);
			this.Fields.Add("创建人", AllReviewViewFields.创建人);
			this.Fields.Add("创建日期", AllReviewViewFields.创建日期);
			this.Fields.Add("最后修改人", AllReviewViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllReviewViewFields.最后修改时间);
			this.Fields.Add("备注", AllReviewViewFields.备注);
		}
	}

	#region AllReviewViewFields

	public class AllReviewViewFields
	{
		public static EntityField 复核ID
		{
			get { return new EntityField("vw_AllReview", 0, "复核ID", SqlDbType.Int); }
		}

		public static EntityField 复核单号
		{
			get { return new EntityField("vw_AllReview", 1, "复核单号", SqlDbType.NVarChar); }
		}

		public static EntityField 复核日期
		{
			get { return new EntityField("vw_AllReview", 2, "复核日期", SqlDbType.DateTime); }
		}

		public static EntityField 复核人员
		{
			get { return new EntityField("vw_AllReview", 3, "复核人员", SqlDbType.NVarChar); }
		}

		public static EntityField 状态名称
		{
			get { return new EntityField("vw_AllReview", 4, "状态名称", SqlDbType.NVarChar); }
		}

		public static EntityField 销售单号
		{
			get { return new EntityField("vw_AllReview", 5, "销售单号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位Spell
		{
			get { return new EntityField("vw_AllReview", 6, "往来单位Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllReview", 7, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllReview", 8, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllReview", 9, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllReview", 10, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllReview", 11, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllReview", 12, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
