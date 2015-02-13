/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllRoleView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllRoleView : ViewBase
	{
		public Guid 角色ID
		{
			get { return (Guid)this.GetValue("角色ID"); } 
			set { this.SetValue("角色ID", value); } 
		}

		public string 角色编号
		{
			get { return (string)this.GetValue("角色编号"); } 
			set { this.SetValue("角色编号", value); } 
		}

		public string 角色名称
		{
			get { return (string)this.GetValue("角色名称"); } 
			set { this.SetValue("角色名称", value); } 
		}

		public string 角色名称Spell
		{
			get { return (string)this.GetValue("角色名称Spell"); } 
			set { this.SetValue("角色名称Spell", value); } 
		}

		public string 角色状态
		{
			get { return (string)this.GetValue("角色状态"); } 
			set { this.SetValue("角色状态", value); } 
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

		public DateTime 最后修改日期
		{
			get { return (DateTime)this.GetValue("最后修改日期"); } 
			set { this.SetValue("最后修改日期", value); } 
		}

		public string 角色备注
		{
			get { return (string)this.GetValue("角色备注"); } 
			set { this.SetValue("角色备注", value); } 
		}

		public AllRoleView()
		{
			this.ViewName = "vw_AllRole";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("角色ID", AllRoleViewFields.角色ID);
			this.Fields.Add("角色编号", AllRoleViewFields.角色编号);
			this.Fields.Add("角色名称", AllRoleViewFields.角色名称);
			this.Fields.Add("角色名称Spell", AllRoleViewFields.角色名称Spell);
			this.Fields.Add("角色状态", AllRoleViewFields.角色状态);
			this.Fields.Add("创建人", AllRoleViewFields.创建人);
			this.Fields.Add("创建日期", AllRoleViewFields.创建日期);
			this.Fields.Add("最后修改人", AllRoleViewFields.最后修改人);
			this.Fields.Add("最后修改日期", AllRoleViewFields.最后修改日期);
			this.Fields.Add("角色备注", AllRoleViewFields.角色备注);
		}
	}

	#region AllRoleViewFields

	public class AllRoleViewFields
	{
		public static EntityField 角色ID
		{
			get { return new EntityField("vw_AllRole", 0, "角色ID", SqlDbType.UniqueIdentifier); }
		}

		public static EntityField 角色编号
		{
			get { return new EntityField("vw_AllRole", 1, "角色编号", SqlDbType.NVarChar); }
		}

		public static EntityField 角色名称
		{
			get { return new EntityField("vw_AllRole", 2, "角色名称", SqlDbType.NVarChar); }
		}

		public static EntityField 角色名称Spell
		{
			get { return new EntityField("vw_AllRole", 3, "角色名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 角色状态
		{
			get { return new EntityField("vw_AllRole", 4, "角色状态", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllRole", 5, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllRole", 6, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllRole", 7, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改日期
		{
			get { return new EntityField("vw_AllRole", 8, "最后修改日期", SqlDbType.DateTime); }
		}

		public static EntityField 角色备注
		{
			get { return new EntityField("vw_AllRole", 9, "角色备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
