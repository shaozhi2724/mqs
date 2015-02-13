/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllUserView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllUserView : ViewBase
	{
		public Guid 用户ID
		{
			get { return (Guid)this.GetValue("用户ID"); } 
			set { this.SetValue("用户ID", value); } 
		}

		public string 用户编号
		{
			get { return (string)this.GetValue("用户编号"); } 
			set { this.SetValue("用户编号", value); } 
		}

		public string 用户名称
		{
			get { return (string)this.GetValue("用户名称"); } 
			set { this.SetValue("用户名称", value); } 
		}

		public string 用户名称Spell
		{
			get { return (string)this.GetValue("用户名称Spell"); } 
			set { this.SetValue("用户名称Spell", value); } 
		}

		public string 用户状态
		{
			get { return (string)this.GetValue("用户状态"); } 
			set { this.SetValue("用户状态", value); } 
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

		public DateTime 修改日期
		{
			get { return (DateTime)this.GetValue("修改日期"); } 
			set { this.SetValue("修改日期", value); } 
		}

		public string 用户备注
		{
			get { return (string)this.GetValue("用户备注"); } 
			set { this.SetValue("用户备注", value); } 
		}

		public AllUserView()
		{
			this.ViewName = "vw_AllUser";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("用户ID", AllUserViewFields.用户ID);
			this.Fields.Add("用户编号", AllUserViewFields.用户编号);
			this.Fields.Add("用户名称", AllUserViewFields.用户名称);
			this.Fields.Add("用户名称Spell", AllUserViewFields.用户名称Spell);
			this.Fields.Add("用户状态", AllUserViewFields.用户状态);
			this.Fields.Add("员工姓名", AllUserViewFields.员工姓名);
			this.Fields.Add("员工姓名Spell", AllUserViewFields.员工姓名Spell);
			this.Fields.Add("创建人", AllUserViewFields.创建人);
			this.Fields.Add("创建日期", AllUserViewFields.创建日期);
			this.Fields.Add("最后修改人", AllUserViewFields.最后修改人);
			this.Fields.Add("修改日期", AllUserViewFields.修改日期);
			this.Fields.Add("用户备注", AllUserViewFields.用户备注);
		}
	}

	#region AllUserViewFields

	public class AllUserViewFields
	{
		public static EntityField 用户ID
		{
			get { return new EntityField("vw_AllUser", 0, "用户ID", SqlDbType.UniqueIdentifier); }
		}

		public static EntityField 用户编号
		{
			get { return new EntityField("vw_AllUser", 1, "用户编号", SqlDbType.NVarChar); }
		}

		public static EntityField 用户名称
		{
			get { return new EntityField("vw_AllUser", 2, "用户名称", SqlDbType.NVarChar); }
		}

		public static EntityField 用户名称Spell
		{
			get { return new EntityField("vw_AllUser", 3, "用户名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 用户状态
		{
			get { return new EntityField("vw_AllUser", 4, "用户状态", SqlDbType.NVarChar); }
		}

		public static EntityField 员工姓名
		{
			get { return new EntityField("vw_AllUser", 5, "员工姓名", SqlDbType.NVarChar); }
		}

		public static EntityField 员工姓名Spell
		{
			get { return new EntityField("vw_AllUser", 6, "员工姓名Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllUser", 7, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllUser", 8, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllUser", 9, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 修改日期
		{
			get { return new EntityField("vw_AllUser", 10, "修改日期", SqlDbType.DateTime); }
		}

		public static EntityField 用户备注
		{
			get { return new EntityField("vw_AllUser", 11, "用户备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
