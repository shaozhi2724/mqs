/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllQualityAdvisoryView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllQualityAdvisoryView : ViewBase
	{
		public int 咨询ID
		{
			get { return (int)this.GetValue("咨询ID"); } 
			set { this.SetValue("咨询ID", value); } 
		}

		public string 咨询编号
		{
            get { return (string)this.GetValue("咨询编号"); }
            set { this.SetValue("咨询编号", value); } 
		}

		public string 咨询人
		{
			get { return (string)this.GetValue("咨询人"); } 
			set { this.SetValue("咨询人", value); } 
		}

		public string 咨询人Spell
		{
			get { return (string)this.GetValue("咨询人Spell"); } 
			set { this.SetValue("咨询人Spell", value); } 
		}

		public string 咨询人联系方式
		{
			get { return (string)this.GetValue("咨询人联系方式"); } 
			set { this.SetValue("咨询人联系方式", value); } 
		}

		public string 咨询人所属单位
		{
			get { return (string)this.GetValue("咨询人所属单位"); } 
			set { this.SetValue("咨询人所属单位", value); } 
		}

		public string 咨询者类别
		{
			get { return (string)this.GetValue("咨询者类别"); } 
			set { this.SetValue("咨询者类别", value); } 
		}

		public string 咨询方式
		{
			get { return (string)this.GetValue("咨询方式"); } 
			set { this.SetValue("咨询方式", value); } 
		}

		public DateTime 咨询时间
		{
			get { return (DateTime)this.GetValue("咨询时间"); } 
			set { this.SetValue("咨询时间", value); } 
		}

		public string 咨询师
		{
			get { return (string)this.GetValue("咨询师"); } 
			set { this.SetValue("咨询师", value); } 
		}

		public string 咨询师Spell
		{
			get { return (string)this.GetValue("咨询师Spell"); } 
			set { this.SetValue("咨询师Spell", value); } 
		}

		public string 咨询的药品
		{
			get { return (string)this.GetValue("咨询的药品"); } 
			set { this.SetValue("咨询的药品", value); } 
		}

		public string 咨询的内容
		{
			get { return (string)this.GetValue("咨询的内容"); } 
			set { this.SetValue("咨询的内容", value); } 
		}

		public string 咨询回复
		{
			get { return (string)this.GetValue("咨询回复"); } 
			set { this.SetValue("咨询回复", value); } 
		}

		public DateTime 回复时间
		{
			get { return (DateTime)this.GetValue("回复时间"); } 
			set { this.SetValue("回复时间", value); } 
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

		public AllQualityAdvisoryView()
		{
			this.ViewName = "vw_AllQualityAdvisory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("咨询ID", AllQualityAdvisoryViewFields.咨询ID);
            this.Fields.Add("咨询编号", AllQualityAdvisoryViewFields.咨询编号);
			this.Fields.Add("咨询人", AllQualityAdvisoryViewFields.咨询人);
			this.Fields.Add("咨询人Spell", AllQualityAdvisoryViewFields.咨询人Spell);
			this.Fields.Add("咨询人联系方式", AllQualityAdvisoryViewFields.咨询人联系方式);
			this.Fields.Add("咨询人所属单位", AllQualityAdvisoryViewFields.咨询人所属单位);
			this.Fields.Add("咨询者类别", AllQualityAdvisoryViewFields.咨询者类别);
			this.Fields.Add("咨询方式", AllQualityAdvisoryViewFields.咨询方式);
			this.Fields.Add("咨询时间", AllQualityAdvisoryViewFields.咨询时间);
			this.Fields.Add("咨询师", AllQualityAdvisoryViewFields.咨询师);
			this.Fields.Add("咨询师Spell", AllQualityAdvisoryViewFields.咨询师Spell);
			this.Fields.Add("咨询的药品", AllQualityAdvisoryViewFields.咨询的药品);
			this.Fields.Add("咨询的内容", AllQualityAdvisoryViewFields.咨询的内容);
			this.Fields.Add("咨询回复", AllQualityAdvisoryViewFields.咨询回复);
			this.Fields.Add("回复时间", AllQualityAdvisoryViewFields.回复时间);
			this.Fields.Add("创建人", AllQualityAdvisoryViewFields.创建人);
			this.Fields.Add("创建日期", AllQualityAdvisoryViewFields.创建日期);
			this.Fields.Add("最后修改人", AllQualityAdvisoryViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllQualityAdvisoryViewFields.最后修改时间);
			this.Fields.Add("备注", AllQualityAdvisoryViewFields.备注);
		}
	}

	#region AllQualityAdvisoryViewFields

	public class AllQualityAdvisoryViewFields
	{
		public static EntityField 咨询ID
		{
			get { return new EntityField("vw_AllQualityAdvisory", 0, "咨询ID", SqlDbType.Int); }
		}

        public static EntityField 咨询编号
		{
            get { return new EntityField("vw_AllQualityAdvisory", 1, "咨询编号", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询人
		{
			get { return new EntityField("vw_AllQualityAdvisory", 2, "咨询人", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询人Spell
		{
			get { return new EntityField("vw_AllQualityAdvisory", 3, "咨询人Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询人联系方式
		{
			get { return new EntityField("vw_AllQualityAdvisory", 4, "咨询人联系方式", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询人所属单位
		{
			get { return new EntityField("vw_AllQualityAdvisory", 5, "咨询人所属单位", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询者类别
		{
			get { return new EntityField("vw_AllQualityAdvisory", 6, "咨询者类别", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询方式
		{
			get { return new EntityField("vw_AllQualityAdvisory", 7, "咨询方式", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询时间
		{
			get { return new EntityField("vw_AllQualityAdvisory", 8, "咨询时间", SqlDbType.DateTime); }
		}

		public static EntityField 咨询师
		{
			get { return new EntityField("vw_AllQualityAdvisory", 9, "咨询师", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询师Spell
		{
			get { return new EntityField("vw_AllQualityAdvisory", 10, "咨询师Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询的药品
		{
			get { return new EntityField("vw_AllQualityAdvisory", 11, "咨询的药品", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询的内容
		{
			get { return new EntityField("vw_AllQualityAdvisory", 12, "咨询的内容", SqlDbType.NVarChar); }
		}

		public static EntityField 咨询回复
		{
			get { return new EntityField("vw_AllQualityAdvisory", 13, "咨询回复", SqlDbType.NVarChar); }
		}

		public static EntityField 回复时间
		{
			get { return new EntityField("vw_AllQualityAdvisory", 14, "回复时间", SqlDbType.DateTime); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllQualityAdvisory", 15, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllQualityAdvisory", 16, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllQualityAdvisory", 17, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllQualityAdvisory", 18, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllQualityAdvisory", 19, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
