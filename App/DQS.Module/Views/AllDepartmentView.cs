/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllDepartmentView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllDepartmentView : ViewBase
	{
		public int 部门ID
		{
			get { return (int)this.GetValue("部门ID"); } 
			set { this.SetValue("部门ID", value); } 
		}

		public string 部门编号
		{
			get { return (string)this.GetValue("部门编号"); } 
			set { this.SetValue("部门编号", value); } 
		}

		public string 部门名称
		{
			get { return (string)this.GetValue("部门名称"); } 
			set { this.SetValue("部门名称", value); } 
		}

		public string 部门名称Spell
		{
			get { return (string)this.GetValue("部门名称Spell"); } 
			set { this.SetValue("部门名称Spell", value); } 
		}

		public string 部门负责人
		{
			get { return (string)this.GetValue("部门负责人"); } 
			set { this.SetValue("部门负责人", value); } 
		}

		public string 负责人电话
		{
			get { return (string)this.GetValue("负责人电话"); } 
			set { this.SetValue("负责人电话", value); } 
		}

		public string 部门职责
		{
			get { return (string)this.GetValue("部门职责"); } 
			set { this.SetValue("部门职责", value); } 
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

		public AllDepartmentView()
		{
			this.ViewName = "vw_AllDepartment";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("部门ID", AllDepartmentViewFields.部门ID);
			this.Fields.Add("部门编号", AllDepartmentViewFields.部门编号);
			this.Fields.Add("部门名称", AllDepartmentViewFields.部门名称);
			this.Fields.Add("部门名称Spell", AllDepartmentViewFields.部门名称Spell);
			this.Fields.Add("部门负责人", AllDepartmentViewFields.部门负责人);
			this.Fields.Add("负责人电话", AllDepartmentViewFields.负责人电话);
			this.Fields.Add("部门职责", AllDepartmentViewFields.部门职责);
			this.Fields.Add("创建人", AllDepartmentViewFields.创建人);
			this.Fields.Add("创建日期", AllDepartmentViewFields.创建日期);
			this.Fields.Add("最后修改人", AllDepartmentViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllDepartmentViewFields.最后修改时间);
			this.Fields.Add("备注", AllDepartmentViewFields.备注);
		}
	}

	#region AllDepartmentViewFields

	public class AllDepartmentViewFields
	{
		public static EntityField 部门ID
		{
			get { return new EntityField("vw_AllDepartment", 0, "部门ID", SqlDbType.Int); }
		}

		public static EntityField 部门编号
		{
			get { return new EntityField("vw_AllDepartment", 1, "部门编号", SqlDbType.NVarChar); }
		}

		public static EntityField 部门名称
		{
			get { return new EntityField("vw_AllDepartment", 2, "部门名称", SqlDbType.NVarChar); }
		}

		public static EntityField 部门名称Spell
		{
			get { return new EntityField("vw_AllDepartment", 3, "部门名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 部门负责人
		{
			get { return new EntityField("vw_AllDepartment", 4, "部门负责人", SqlDbType.NVarChar); }
		}

		public static EntityField 负责人电话
		{
			get { return new EntityField("vw_AllDepartment", 5, "负责人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 部门职责
		{
			get { return new EntityField("vw_AllDepartment", 6, "部门职责", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllDepartment", 7, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllDepartment", 8, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllDepartment", 9, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllDepartment", 10, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllDepartment", 11, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
