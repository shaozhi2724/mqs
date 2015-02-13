/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProviderSalesmanView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProviderSalesmanView : ViewBase
	{
		public int 人员ID
		{
			get { return (int)this.GetValue("人员ID"); } 
			set { this.SetValue("人员ID", value); } 
		}

		public string 人员编号
		{
			get { return (string)this.GetValue("人员编号"); } 
			set { this.SetValue("人员编号", value); } 
		}

		public string 人员姓名
		{
			get { return (string)this.GetValue("人员姓名"); } 
			set { this.SetValue("人员姓名", value); } 
		}

		public string 人员姓名Spell
		{
			get { return (string)this.GetValue("人员姓名Spell"); } 
			set { this.SetValue("人员姓名Spell", value); } 
		}

		public string 所属单位
		{
			get { return (string)this.GetValue("所属单位"); } 
			set { this.SetValue("所属单位", value); } 
		}

		public string 所属单位Spell
		{
			get { return (string)this.GetValue("所属单位Spell"); } 
			set { this.SetValue("所属单位Spell", value); } 
		}

		public string 性别
		{
			get { return (string)this.GetValue("性别"); } 
			set { this.SetValue("性别", value); } 
		}

		public string 民族
		{
			get { return (string)this.GetValue("民族"); } 
			set { this.SetValue("民族", value); } 
		}

		public DateTime 出生日期
		{
			get { return (DateTime)this.GetValue("出生日期"); } 
			set { this.SetValue("出生日期", value); } 
		}

		public string 身份证号
		{
			get { return (string)this.GetValue("身份证号"); } 
			set { this.SetValue("身份证号", value); } 
		}

		public string 手机
		{
			get { return (string)this.GetValue("手机"); } 
			set { this.SetValue("手机", value); } 
		}

		public string 家庭电话
		{
			get { return (string)this.GetValue("家庭电话"); } 
			set { this.SetValue("家庭电话", value); } 
		}

		public string 电子邮箱
		{
			get { return (string)this.GetValue("电子邮箱"); } 
			set { this.SetValue("电子邮箱", value); } 
		}

		public string 现居住住址
		{
			get { return (string)this.GetValue("现居住住址"); } 
			set { this.SetValue("现居住住址", value); } 
		}

		public string 学历
		{
			get { return (string)this.GetValue("学历"); } 
			set { this.SetValue("学历", value); } 
		}

		public string 学位
		{
			get { return (string)this.GetValue("学位"); } 
			set { this.SetValue("学位", value); } 
		}

		public string 毕业学校
		{
			get { return (string)this.GetValue("毕业学校"); } 
			set { this.SetValue("毕业学校", value); } 
		}

		public string 所学专业
		{
			get { return (string)this.GetValue("所学专业"); } 
			set { this.SetValue("所学专业", value); } 
		}

		public string 学制
		{
			get { return (string)this.GetValue("学制"); } 
			set { this.SetValue("学制", value); } 
		}

		public DateTime 毕业时间
		{
			get { return (DateTime)this.GetValue("毕业时间"); } 
			set { this.SetValue("毕业时间", value); } 
		}

		public string 所获证书
		{
			get { return (string)this.GetValue("所获证书"); } 
			set { this.SetValue("所获证书", value); } 
		}

		public string 所属岗位
		{
			get { return (string)this.GetValue("所属岗位"); } 
			set { this.SetValue("所属岗位", value); } 
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

		public AllProviderSalesmanView()
		{
			this.ViewName = "vw_AllProviderSalesman";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("人员ID", AllProviderSalesmanViewFields.人员ID);
			this.Fields.Add("人员编号", AllProviderSalesmanViewFields.人员编号);
			this.Fields.Add("人员姓名", AllProviderSalesmanViewFields.人员姓名);
			this.Fields.Add("人员姓名Spell", AllProviderSalesmanViewFields.人员姓名Spell);
			this.Fields.Add("所属单位", AllProviderSalesmanViewFields.所属单位);
			this.Fields.Add("所属单位Spell", AllProviderSalesmanViewFields.所属单位Spell);
			this.Fields.Add("性别", AllProviderSalesmanViewFields.性别);
			this.Fields.Add("民族", AllProviderSalesmanViewFields.民族);
			this.Fields.Add("出生日期", AllProviderSalesmanViewFields.出生日期);
			this.Fields.Add("身份证号", AllProviderSalesmanViewFields.身份证号);
			this.Fields.Add("手机", AllProviderSalesmanViewFields.手机);
			this.Fields.Add("家庭电话", AllProviderSalesmanViewFields.家庭电话);
			this.Fields.Add("电子邮箱", AllProviderSalesmanViewFields.电子邮箱);
			this.Fields.Add("现居住住址", AllProviderSalesmanViewFields.现居住住址);
			this.Fields.Add("学历", AllProviderSalesmanViewFields.学历);
			this.Fields.Add("学位", AllProviderSalesmanViewFields.学位);
			this.Fields.Add("毕业学校", AllProviderSalesmanViewFields.毕业学校);
			this.Fields.Add("所学专业", AllProviderSalesmanViewFields.所学专业);
			this.Fields.Add("学制", AllProviderSalesmanViewFields.学制);
			this.Fields.Add("毕业时间", AllProviderSalesmanViewFields.毕业时间);
			this.Fields.Add("所获证书", AllProviderSalesmanViewFields.所获证书);
			this.Fields.Add("所属岗位", AllProviderSalesmanViewFields.所属岗位);
			this.Fields.Add("创建人", AllProviderSalesmanViewFields.创建人);
			this.Fields.Add("创建日期", AllProviderSalesmanViewFields.创建日期);
			this.Fields.Add("最后修改人", AllProviderSalesmanViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllProviderSalesmanViewFields.最后修改时间);
			this.Fields.Add("备注", AllProviderSalesmanViewFields.备注);
		}
	}

	#region AllProviderSalesmanViewFields

	public class AllProviderSalesmanViewFields
	{
		public static EntityField 人员ID
		{
			get { return new EntityField("vw_AllProviderSalesman", 0, "人员ID", SqlDbType.Int); }
		}

		public static EntityField 人员编号
		{
			get { return new EntityField("vw_AllProviderSalesman", 1, "人员编号", SqlDbType.NVarChar); }
		}

		public static EntityField 人员姓名
		{
			get { return new EntityField("vw_AllProviderSalesman", 2, "人员姓名", SqlDbType.NVarChar); }
		}

		public static EntityField 人员姓名Spell
		{
			get { return new EntityField("vw_AllProviderSalesman", 3, "人员姓名Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 所属单位
		{
			get { return new EntityField("vw_AllProviderSalesman", 4, "所属单位", SqlDbType.NVarChar); }
		}

		public static EntityField 所属单位Spell
		{
			get { return new EntityField("vw_AllProviderSalesman", 5, "所属单位Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 性别
		{
			get { return new EntityField("vw_AllProviderSalesman", 6, "性别", SqlDbType.NVarChar); }
		}

		public static EntityField 民族
		{
			get { return new EntityField("vw_AllProviderSalesman", 7, "民族", SqlDbType.NVarChar); }
		}

		public static EntityField 出生日期
		{
			get { return new EntityField("vw_AllProviderSalesman", 8, "出生日期", SqlDbType.DateTime); }
		}

		public static EntityField 身份证号
		{
			get { return new EntityField("vw_AllProviderSalesman", 9, "身份证号", SqlDbType.NChar); }
		}

		public static EntityField 手机
		{
			get { return new EntityField("vw_AllProviderSalesman", 10, "手机", SqlDbType.NVarChar); }
		}

		public static EntityField 家庭电话
		{
			get { return new EntityField("vw_AllProviderSalesman", 11, "家庭电话", SqlDbType.NVarChar); }
		}

		public static EntityField 电子邮箱
		{
			get { return new EntityField("vw_AllProviderSalesman", 12, "电子邮箱", SqlDbType.NVarChar); }
		}

		public static EntityField 现居住住址
		{
			get { return new EntityField("vw_AllProviderSalesman", 13, "现居住住址", SqlDbType.NVarChar); }
		}

		public static EntityField 学历
		{
			get { return new EntityField("vw_AllProviderSalesman", 14, "学历", SqlDbType.NVarChar); }
		}

		public static EntityField 学位
		{
			get { return new EntityField("vw_AllProviderSalesman", 15, "学位", SqlDbType.NVarChar); }
		}

		public static EntityField 毕业学校
		{
			get { return new EntityField("vw_AllProviderSalesman", 16, "毕业学校", SqlDbType.NVarChar); }
		}

		public static EntityField 所学专业
		{
			get { return new EntityField("vw_AllProviderSalesman", 17, "所学专业", SqlDbType.NVarChar); }
		}

		public static EntityField 学制
		{
			get { return new EntityField("vw_AllProviderSalesman", 18, "学制", SqlDbType.NVarChar); }
		}

		public static EntityField 毕业时间
		{
			get { return new EntityField("vw_AllProviderSalesman", 19, "毕业时间", SqlDbType.DateTime); }
		}

		public static EntityField 所获证书
		{
			get { return new EntityField("vw_AllProviderSalesman", 20, "所获证书", SqlDbType.NVarChar); }
		}

		public static EntityField 所属岗位
		{
			get { return new EntityField("vw_AllProviderSalesman", 21, "所属岗位", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllProviderSalesman", 22, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllProviderSalesman", 23, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllProviderSalesman", 24, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllProviderSalesman", 25, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllProviderSalesman", 26, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
