/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllEmployeeView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllEmployeeView : ViewBase
	{
		public int 员工ID
		{
			get { return (int)this.GetValue("员工ID"); } 
			set { this.SetValue("员工ID", value); } 
		}

		public string 员工编号
		{
			get { return (string)this.GetValue("员工编号"); } 
			set { this.SetValue("员工编号", value); } 
		}

		public string 员工姓名
		{
			get { return (string)this.GetValue("员工姓名"); } 
			set { this.SetValue("员工姓名", value); } 
		}

		public string 员工姓名Spell
		{
			get { return (string)this.GetValue("员工姓名Spell"); } 
			set { this.SetValue("员工姓名Spell", value); } 
		}

		public string 曾用名
		{
			get { return (string)this.GetValue("曾用名"); } 
			set { this.SetValue("曾用名", value); } 
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

		public string 所属部门
		{
			get { return (string)this.GetValue("所属部门"); } 
			set { this.SetValue("所属部门", value); } 
		}

		public string 所属部门Spell
		{
			get { return (string)this.GetValue("所属部门Spell"); } 
			set { this.SetValue("所属部门Spell", value); } 
		}

		public string 岗位名称
		{
			get { return (string)this.GetValue("岗位名称"); } 
			set { this.SetValue("岗位名称", value); } 
		}

		public DateTime 入职时间
		{
			get { return (DateTime)this.GetValue("入职时间"); } 
			set { this.SetValue("入职时间", value); } 
		}

		public string 政治面貌
		{
			get { return (string)this.GetValue("政治面貌"); } 
			set { this.SetValue("政治面貌", value); } 
		}

		public string 婚姻状况
		{
			get { return (string)this.GetValue("婚姻状况"); } 
			set { this.SetValue("婚姻状况", value); } 
		}

		public string 籍贯
		{
			get { return (string)this.GetValue("籍贯"); } 
			set { this.SetValue("籍贯", value); } 
		}

		public string 户口所在地
		{
			get { return (string)this.GetValue("户口所在地"); } 
			set { this.SetValue("户口所在地", value); } 
		}

		public string 现居住住址
		{
			get { return (string)this.GetValue("现居住住址"); } 
			set { this.SetValue("现居住住址", value); } 
		}

		public string 紧急联系人
		{
			get { return (string)this.GetValue("紧急联系人"); } 
			set { this.SetValue("紧急联系人", value); } 
		}

		public string 紧急电话
		{
			get { return (string)this.GetValue("紧急电话"); } 
			set { this.SetValue("紧急电话", value); } 
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

		public string 所获证书列表
		{
			get { return (string)this.GetValue("所获证书列表"); } 
			set { this.SetValue("所获证书列表", value); } 
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

		public AllEmployeeView()
		{
			this.ViewName = "vw_AllEmployee";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("员工ID", AllEmployeeViewFields.员工ID);
			this.Fields.Add("员工编号", AllEmployeeViewFields.员工编号);
			this.Fields.Add("员工姓名", AllEmployeeViewFields.员工姓名);
			this.Fields.Add("员工姓名Spell", AllEmployeeViewFields.员工姓名Spell);
			this.Fields.Add("曾用名", AllEmployeeViewFields.曾用名);
			this.Fields.Add("性别", AllEmployeeViewFields.性别);
			this.Fields.Add("民族", AllEmployeeViewFields.民族);
			this.Fields.Add("出生日期", AllEmployeeViewFields.出生日期);
			this.Fields.Add("身份证号", AllEmployeeViewFields.身份证号);
			this.Fields.Add("手机", AllEmployeeViewFields.手机);
			this.Fields.Add("家庭电话", AllEmployeeViewFields.家庭电话);
			this.Fields.Add("电子邮箱", AllEmployeeViewFields.电子邮箱);
			this.Fields.Add("所属部门", AllEmployeeViewFields.所属部门);
			this.Fields.Add("所属部门Spell", AllEmployeeViewFields.所属部门Spell);
			this.Fields.Add("岗位名称", AllEmployeeViewFields.岗位名称);
			this.Fields.Add("入职时间", AllEmployeeViewFields.入职时间);
			this.Fields.Add("政治面貌", AllEmployeeViewFields.政治面貌);
			this.Fields.Add("婚姻状况", AllEmployeeViewFields.婚姻状况);
			this.Fields.Add("籍贯", AllEmployeeViewFields.籍贯);
			this.Fields.Add("户口所在地", AllEmployeeViewFields.户口所在地);
			this.Fields.Add("现居住住址", AllEmployeeViewFields.现居住住址);
			this.Fields.Add("紧急联系人", AllEmployeeViewFields.紧急联系人);
			this.Fields.Add("紧急电话", AllEmployeeViewFields.紧急电话);
			this.Fields.Add("学历", AllEmployeeViewFields.学历);
			this.Fields.Add("学位", AllEmployeeViewFields.学位);
			this.Fields.Add("毕业学校", AllEmployeeViewFields.毕业学校);
			this.Fields.Add("所学专业", AllEmployeeViewFields.所学专业);
			this.Fields.Add("学制", AllEmployeeViewFields.学制);
			this.Fields.Add("毕业时间", AllEmployeeViewFields.毕业时间);
			this.Fields.Add("所获证书列表", AllEmployeeViewFields.所获证书列表);
			this.Fields.Add("创建人", AllEmployeeViewFields.创建人);
			this.Fields.Add("创建日期", AllEmployeeViewFields.创建日期);
			this.Fields.Add("最后修改人", AllEmployeeViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllEmployeeViewFields.最后修改时间);
			this.Fields.Add("备注", AllEmployeeViewFields.备注);
		}
	}

	#region AllEmployeeViewFields

	public class AllEmployeeViewFields
	{
		public static EntityField 员工ID
		{
			get { return new EntityField("vw_AllEmployee", 0, "员工ID", SqlDbType.Int); }
		}

		public static EntityField 员工编号
		{
			get { return new EntityField("vw_AllEmployee", 1, "员工编号", SqlDbType.NVarChar); }
		}

		public static EntityField 员工姓名
		{
			get { return new EntityField("vw_AllEmployee", 2, "员工姓名", SqlDbType.NVarChar); }
		}

		public static EntityField 员工姓名Spell
		{
			get { return new EntityField("vw_AllEmployee", 3, "员工姓名Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 曾用名
		{
			get { return new EntityField("vw_AllEmployee", 4, "曾用名", SqlDbType.NVarChar); }
		}

		public static EntityField 性别
		{
			get { return new EntityField("vw_AllEmployee", 5, "性别", SqlDbType.NVarChar); }
		}

		public static EntityField 民族
		{
			get { return new EntityField("vw_AllEmployee", 6, "民族", SqlDbType.NVarChar); }
		}

		public static EntityField 出生日期
		{
			get { return new EntityField("vw_AllEmployee", 7, "出生日期", SqlDbType.DateTime); }
		}

		public static EntityField 身份证号
		{
			get { return new EntityField("vw_AllEmployee", 8, "身份证号", SqlDbType.NChar); }
		}

		public static EntityField 手机
		{
			get { return new EntityField("vw_AllEmployee", 9, "手机", SqlDbType.NVarChar); }
		}

		public static EntityField 家庭电话
		{
			get { return new EntityField("vw_AllEmployee", 10, "家庭电话", SqlDbType.NVarChar); }
		}

		public static EntityField 电子邮箱
		{
			get { return new EntityField("vw_AllEmployee", 11, "电子邮箱", SqlDbType.NVarChar); }
		}

		public static EntityField 所属部门
		{
			get { return new EntityField("vw_AllEmployee", 12, "所属部门", SqlDbType.NVarChar); }
		}

		public static EntityField 所属部门Spell
		{
			get { return new EntityField("vw_AllEmployee", 13, "所属部门Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 岗位名称
		{
			get { return new EntityField("vw_AllEmployee", 14, "岗位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 入职时间
		{
			get { return new EntityField("vw_AllEmployee", 15, "入职时间", SqlDbType.DateTime); }
		}

		public static EntityField 政治面貌
		{
			get { return new EntityField("vw_AllEmployee", 16, "政治面貌", SqlDbType.NVarChar); }
		}

		public static EntityField 婚姻状况
		{
			get { return new EntityField("vw_AllEmployee", 17, "婚姻状况", SqlDbType.NVarChar); }
		}

		public static EntityField 籍贯
		{
			get { return new EntityField("vw_AllEmployee", 18, "籍贯", SqlDbType.NVarChar); }
		}

		public static EntityField 户口所在地
		{
			get { return new EntityField("vw_AllEmployee", 19, "户口所在地", SqlDbType.NVarChar); }
		}

		public static EntityField 现居住住址
		{
			get { return new EntityField("vw_AllEmployee", 20, "现居住住址", SqlDbType.NVarChar); }
		}

		public static EntityField 紧急联系人
		{
			get { return new EntityField("vw_AllEmployee", 21, "紧急联系人", SqlDbType.NVarChar); }
		}

		public static EntityField 紧急电话
		{
			get { return new EntityField("vw_AllEmployee", 22, "紧急电话", SqlDbType.NVarChar); }
		}

		public static EntityField 学历
		{
			get { return new EntityField("vw_AllEmployee", 23, "学历", SqlDbType.NVarChar); }
		}

		public static EntityField 学位
		{
			get { return new EntityField("vw_AllEmployee", 24, "学位", SqlDbType.NVarChar); }
		}

		public static EntityField 毕业学校
		{
			get { return new EntityField("vw_AllEmployee", 25, "毕业学校", SqlDbType.NVarChar); }
		}

		public static EntityField 所学专业
		{
			get { return new EntityField("vw_AllEmployee", 26, "所学专业", SqlDbType.NVarChar); }
		}

		public static EntityField 学制
		{
			get { return new EntityField("vw_AllEmployee", 27, "学制", SqlDbType.NVarChar); }
		}

		public static EntityField 毕业时间
		{
			get { return new EntityField("vw_AllEmployee", 28, "毕业时间", SqlDbType.DateTime); }
		}

		public static EntityField 所获证书列表
		{
			get { return new EntityField("vw_AllEmployee", 29, "所获证书列表", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllEmployee", 30, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllEmployee", 31, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllEmployee", 32, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllEmployee", 33, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllEmployee", 34, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
