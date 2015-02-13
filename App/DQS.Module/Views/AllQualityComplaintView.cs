/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllQualityComplaintView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllQualityComplaintView : ViewBase
	{
		public int 投诉ID
		{
			get { return (int)this.GetValue("投诉ID"); } 
			set { this.SetValue("投诉ID", value); } 
		}

        public string 投诉编号
		{
            get { return (string)this.GetValue("投诉编号"); }
            set { this.SetValue("投诉编号", value); } 
		}

		public string 投诉人
		{
			get { return (string)this.GetValue("投诉人"); } 
			set { this.SetValue("投诉人", value); } 
		}

		public string 投诉人联系方式
		{
			get { return (string)this.GetValue("投诉人联系方式"); } 
			set { this.SetValue("投诉人联系方式", value); } 
		}

		public string 投诉人所属单位
		{
			get { return (string)this.GetValue("投诉人所属单位"); } 
			set { this.SetValue("投诉人所属单位", value); } 
		}

		public string 投诉者类别
		{
			get { return (string)this.GetValue("投诉者类别"); } 
			set { this.SetValue("投诉者类别", value); } 
		}

		public string 投诉方式
		{
			get { return (string)this.GetValue("投诉方式"); } 
			set { this.SetValue("投诉方式", value); } 
		}

		public DateTime 投诉时间
		{
			get { return (DateTime)this.GetValue("投诉时间"); } 
			set { this.SetValue("投诉时间", value); } 
		}

		public string 操作员
		{
			get { return (string)this.GetValue("操作员"); } 
			set { this.SetValue("操作员", value); } 
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

		public string 药品名称Spell
		{
			get { return (string)this.GetValue("药品名称Spell"); } 
			set { this.SetValue("药品名称Spell", value); } 
		}

		public string 规格
		{
			get { return (string)this.GetValue("规格"); } 
			set { this.SetValue("规格", value); } 
		}

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
		}

		public string 批准文号
		{
			get { return (string)this.GetValue("批准文号"); } 
			set { this.SetValue("批准文号", value); } 
		}

		public string 批号
		{
			get { return (string)this.GetValue("批号"); } 
			set { this.SetValue("批号", value); } 
		}

		public int 数量
		{
			get { return (int)this.GetValue("数量"); } 
			set { this.SetValue("数量", value); } 
		}

		public string 投诉内容
		{
			get { return (string)this.GetValue("投诉内容"); } 
			set { this.SetValue("投诉内容", value); } 
		}

		public string 投诉方的建议或意见
		{
			get { return (string)this.GetValue("投诉方的建议或意见"); } 
			set { this.SetValue("投诉方的建议或意见", value); } 
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

		public string 处理意见
		{
			get { return (string)this.GetValue("处理意见"); } 
			set { this.SetValue("处理意见", value); } 
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

		public AllQualityComplaintView()
		{
			this.ViewName = "vw_AllQualityComplaint";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("投诉ID", AllQualityComplaintViewFields.投诉ID);
            this.Fields.Add("投诉编号", AllQualityComplaintViewFields.投诉编号);
			this.Fields.Add("投诉人", AllQualityComplaintViewFields.投诉人);
			this.Fields.Add("投诉人联系方式", AllQualityComplaintViewFields.投诉人联系方式);
			this.Fields.Add("投诉人所属单位", AllQualityComplaintViewFields.投诉人所属单位);
			this.Fields.Add("投诉者类别", AllQualityComplaintViewFields.投诉者类别);
			this.Fields.Add("投诉方式", AllQualityComplaintViewFields.投诉方式);
			this.Fields.Add("投诉时间", AllQualityComplaintViewFields.投诉时间);
			this.Fields.Add("操作员", AllQualityComplaintViewFields.操作员);
			this.Fields.Add("药品编号", AllQualityComplaintViewFields.药品编号);
			this.Fields.Add("药品名称", AllQualityComplaintViewFields.药品名称);
			this.Fields.Add("药品名称Spell", AllQualityComplaintViewFields.药品名称Spell);
			this.Fields.Add("规格", AllQualityComplaintViewFields.规格);
			this.Fields.Add("生产厂商", AllQualityComplaintViewFields.生产厂商);
			this.Fields.Add("批准文号", AllQualityComplaintViewFields.批准文号);
			this.Fields.Add("批号", AllQualityComplaintViewFields.批号);
			this.Fields.Add("数量", AllQualityComplaintViewFields.数量);
			this.Fields.Add("投诉内容", AllQualityComplaintViewFields.投诉内容);
			this.Fields.Add("投诉方的建议或意见", AllQualityComplaintViewFields.投诉方的建议或意见);
			this.Fields.Add("处理人", AllQualityComplaintViewFields.处理人);
			this.Fields.Add("处理时间", AllQualityComplaintViewFields.处理时间);
			this.Fields.Add("处理意见", AllQualityComplaintViewFields.处理意见);
			this.Fields.Add("处理结果", AllQualityComplaintViewFields.处理结果);
			this.Fields.Add("创建人", AllQualityComplaintViewFields.创建人);
			this.Fields.Add("创建日期", AllQualityComplaintViewFields.创建日期);
			this.Fields.Add("最后修改人", AllQualityComplaintViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllQualityComplaintViewFields.最后修改时间);
			this.Fields.Add("备注", AllQualityComplaintViewFields.备注);
		}
	}

	#region AllQualityComplaintViewFields

	public class AllQualityComplaintViewFields
	{
		public static EntityField 投诉ID
		{
			get { return new EntityField("vw_AllQualityComplaint", 0, "投诉ID", SqlDbType.Int); }
		}

        public static EntityField 投诉编号
		{
            get { return new EntityField("vw_AllQualityComplaint", 1, "投诉编号", SqlDbType.NVarChar); }
		}

		public static EntityField 投诉人
		{
			get { return new EntityField("vw_AllQualityComplaint", 2, "投诉人", SqlDbType.NVarChar); }
		}

		public static EntityField 投诉人联系方式
		{
			get { return new EntityField("vw_AllQualityComplaint", 3, "投诉人联系方式", SqlDbType.NVarChar); }
		}

		public static EntityField 投诉人所属单位
		{
			get { return new EntityField("vw_AllQualityComplaint", 4, "投诉人所属单位", SqlDbType.NVarChar); }
		}

		public static EntityField 投诉者类别
		{
			get { return new EntityField("vw_AllQualityComplaint", 5, "投诉者类别", SqlDbType.NVarChar); }
		}

		public static EntityField 投诉方式
		{
			get { return new EntityField("vw_AllQualityComplaint", 6, "投诉方式", SqlDbType.NVarChar); }
		}

		public static EntityField 投诉时间
		{
			get { return new EntityField("vw_AllQualityComplaint", 7, "投诉时间", SqlDbType.DateTime); }
		}

		public static EntityField 操作员
		{
			get { return new EntityField("vw_AllQualityComplaint", 8, "操作员", SqlDbType.NVarChar); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllQualityComplaint", 9, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllQualityComplaint", 10, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_AllQualityComplaint", 11, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllQualityComplaint", 12, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllQualityComplaint", 13, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 批准文号
		{
			get { return new EntityField("vw_AllQualityComplaint", 14, "批准文号", SqlDbType.NVarChar); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllQualityComplaint", 15, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 数量
		{
			get { return new EntityField("vw_AllQualityComplaint", 16, "数量", SqlDbType.Int); }
		}

		public static EntityField 投诉内容
		{
			get { return new EntityField("vw_AllQualityComplaint", 17, "投诉内容", SqlDbType.NVarChar); }
		}

		public static EntityField 投诉方的建议或意见
		{
			get { return new EntityField("vw_AllQualityComplaint", 18, "投诉方的建议或意见", SqlDbType.NVarChar); }
		}

		public static EntityField 处理人
		{
			get { return new EntityField("vw_AllQualityComplaint", 19, "处理人", SqlDbType.NVarChar); }
		}

		public static EntityField 处理时间
		{
			get { return new EntityField("vw_AllQualityComplaint", 20, "处理时间", SqlDbType.DateTime); }
		}

		public static EntityField 处理意见
		{
			get { return new EntityField("vw_AllQualityComplaint", 21, "处理意见", SqlDbType.NVarChar); }
		}

		public static EntityField 处理结果
		{
			get { return new EntityField("vw_AllQualityComplaint", 22, "处理结果", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllQualityComplaint", 23, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllQualityComplaint", 24, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllQualityComplaint", 25, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllQualityComplaint", 26, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllQualityComplaint", 27, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
