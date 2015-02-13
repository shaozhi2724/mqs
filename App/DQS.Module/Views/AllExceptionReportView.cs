/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllExceptionReportView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllExceptionReportView : ViewBase
	{
		public int 异常ID
		{
			get { return (int)this.GetValue("异常ID"); } 
			set { this.SetValue("异常ID", value); } 
		}

		public string 异常编号
		{
			get { return (string)this.GetValue("异常编号"); } 
			set { this.SetValue("异常编号", value); } 
		}

		public string 发现人
		{
			get { return (string)this.GetValue("发现人"); } 
			set { this.SetValue("发现人", value); } 
		}

		public DateTime 发现时间
		{
			get { return (DateTime)this.GetValue("发现时间"); } 
			set { this.SetValue("发现时间", value); } 
		}

		public string 异常内容
		{
			get { return (string)this.GetValue("异常内容"); } 
			set { this.SetValue("异常内容", value); } 
		}

		public bool 是否处理
		{
			get { return (bool)this.GetValue("是否处理"); } 
			set { this.SetValue("是否处理", value); } 
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

		public AllExceptionReportView()
		{
			this.ViewName = "vw_AllExceptionReport";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("异常ID", AllExceptionReportViewFields.异常ID);
			this.Fields.Add("异常编号", AllExceptionReportViewFields.异常编号);
			this.Fields.Add("发现人", AllExceptionReportViewFields.发现人);
			this.Fields.Add("发现时间", AllExceptionReportViewFields.发现时间);
			this.Fields.Add("异常内容", AllExceptionReportViewFields.异常内容);
			this.Fields.Add("是否处理", AllExceptionReportViewFields.是否处理);
			this.Fields.Add("处理人", AllExceptionReportViewFields.处理人);
			this.Fields.Add("处理时间", AllExceptionReportViewFields.处理时间);
			this.Fields.Add("处理方案", AllExceptionReportViewFields.处理方案);
			this.Fields.Add("处理结果", AllExceptionReportViewFields.处理结果);
			this.Fields.Add("创建人", AllExceptionReportViewFields.创建人);
			this.Fields.Add("创建日期", AllExceptionReportViewFields.创建日期);
			this.Fields.Add("最后修改人", AllExceptionReportViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllExceptionReportViewFields.最后修改时间);
			this.Fields.Add("备注", AllExceptionReportViewFields.备注);
		}
	}

	#region AllExceptionReportViewFields

	public class AllExceptionReportViewFields
	{
		public static EntityField 异常ID
		{
			get { return new EntityField("vw_AllExceptionReport", 0, "异常ID", SqlDbType.Int); }
		}

		public static EntityField 异常编号
		{
			get { return new EntityField("vw_AllExceptionReport", 1, "异常编号", SqlDbType.NVarChar); }
		}

		public static EntityField 发现人
		{
			get { return new EntityField("vw_AllExceptionReport", 2, "发现人", SqlDbType.NVarChar); }
		}

		public static EntityField 发现时间
		{
			get { return new EntityField("vw_AllExceptionReport", 3, "发现时间", SqlDbType.DateTime); }
		}

		public static EntityField 异常内容
		{
			get { return new EntityField("vw_AllExceptionReport", 4, "异常内容", SqlDbType.NVarChar); }
		}

		public static EntityField 是否处理
		{
			get { return new EntityField("vw_AllExceptionReport", 5, "是否处理", SqlDbType.Bit); }
		}

		public static EntityField 处理人
		{
			get { return new EntityField("vw_AllExceptionReport", 6, "处理人", SqlDbType.NVarChar); }
		}

		public static EntityField 处理时间
		{
			get { return new EntityField("vw_AllExceptionReport", 7, "处理时间", SqlDbType.DateTime); }
		}

		public static EntityField 处理方案
		{
			get { return new EntityField("vw_AllExceptionReport", 8, "处理方案", SqlDbType.NVarChar); }
		}

		public static EntityField 处理结果
		{
			get { return new EntityField("vw_AllExceptionReport", 9, "处理结果", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllExceptionReport", 10, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllExceptionReport", 11, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllExceptionReport", 12, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllExceptionReport", 13, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllExceptionReport", 14, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
