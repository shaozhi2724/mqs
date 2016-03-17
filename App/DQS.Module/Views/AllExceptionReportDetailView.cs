/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllExceptionReportDetailView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllExceptionReportDetailView : ViewBase
	{
		public int 异常ID
		{
			get { return (int)this.GetValue("异常ID"); } 
			set { this.SetValue("异常ID", value); } 
		}

		public int 产品ID
		{
			get { return (int)this.GetValue("产品ID"); } 
			set { this.SetValue("产品ID", value); } 
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

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
		}

		public string 规格型号
		{
			get { return (string)this.GetValue("规格型号"); } 
			set { this.SetValue("规格型号", value); } 
		}

		public string 剂型
		{
			get { return (string)this.GetValue("剂型"); } 
			set { this.SetValue("剂型", value); } 
		}

		public string 产品类别
		{
			get { return (string)this.GetValue("产品类别"); } 
			set { this.SetValue("产品类别", value); } 
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

		public int 数量
		{
			get { return (int)this.GetValue("数量"); } 
			set { this.SetValue("数量", value); } 
		}

		public string 异常内容
		{
			get { return (string)this.GetValue("异常内容"); } 
			set { this.SetValue("异常内容", value); } 
		}

		public string 明细备注
		{
			get { return (string)this.GetValue("明细备注"); } 
			set { this.SetValue("明细备注", value); } 
		}

		public int 明细ID
		{
			get { return (int)this.GetValue("明细ID"); } 
			set { this.SetValue("明细ID", value); } 
		}

		public AllExceptionReportDetailView()
		{
			this.ViewName = "vw_AllExceptionReportDetail";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("异常ID", AllExceptionReportDetailViewFields.异常ID);
			this.Fields.Add("产品ID", AllExceptionReportDetailViewFields.产品ID);
			this.Fields.Add("产品编号", AllExceptionReportDetailViewFields.产品编号);
			this.Fields.Add("产品名称", AllExceptionReportDetailViewFields.产品名称);
			this.Fields.Add("生产厂商", AllExceptionReportDetailViewFields.生产厂商);
			this.Fields.Add("规格型号", AllExceptionReportDetailViewFields.规格型号);
			this.Fields.Add("剂型", AllExceptionReportDetailViewFields.剂型);
			this.Fields.Add("产品类别", AllExceptionReportDetailViewFields.产品类别);
			this.Fields.Add("单位", AllExceptionReportDetailViewFields.单位);
			this.Fields.Add("批号", AllExceptionReportDetailViewFields.批号);
			this.Fields.Add("生产日期", AllExceptionReportDetailViewFields.生产日期);
			this.Fields.Add("有效期至", AllExceptionReportDetailViewFields.有效期至);
			this.Fields.Add("数量", AllExceptionReportDetailViewFields.数量);
			this.Fields.Add("异常内容", AllExceptionReportDetailViewFields.异常内容);
			this.Fields.Add("明细备注", AllExceptionReportDetailViewFields.明细备注);
			this.Fields.Add("明细ID", AllExceptionReportDetailViewFields.明细ID);
		}
	}

	#region AllExceptionReportDetailViewFields

	public class AllExceptionReportDetailViewFields
	{
		public static EntityField 异常ID
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 0, "异常ID", SqlDbType.Int); }
		}

		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 1, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 2, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 3, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 4, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 5, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 6, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 7, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 8, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 9, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 10, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 11, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 数量
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 12, "数量", SqlDbType.Int); }
		}

		public static EntityField 异常内容
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 13, "异常内容", SqlDbType.NVarChar); }
		}

		public static EntityField 明细备注
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 14, "明细备注", SqlDbType.VarChar); }
		}

		public static EntityField 明细ID
		{
			get { return new EntityField("vw_AllExceptionReportDetail", 15, "明细ID", SqlDbType.Int); }
		}

	}

	#endregion

}
