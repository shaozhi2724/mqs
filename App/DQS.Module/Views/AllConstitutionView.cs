/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllConstitutionView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllConstitutionView : ViewBase
	{
		public int 规程ID
		{
			get { return (int)this.GetValue("规程ID"); } 
			set { this.SetValue("规程ID", value); } 
		}

		public string 规程编号
		{
			get { return (string)this.GetValue("规程编号"); } 
			set { this.SetValue("规程编号", value); } 
		}

		public string 规程名称
		{
			get { return (string)this.GetValue("规程名称"); } 
			set { this.SetValue("规程名称", value); } 
		}

		public string 所属菜单
		{
			get { return (string)this.GetValue("所属菜单"); } 
			set { this.SetValue("所属菜单", value); } 
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

		public AllConstitutionView()
		{
			this.ViewName = "vw_AllConstitution";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("规程ID", AllConstitutionViewFields.规程ID);
			this.Fields.Add("规程编号", AllConstitutionViewFields.规程编号);
			this.Fields.Add("规程名称", AllConstitutionViewFields.规程名称);
			this.Fields.Add("所属菜单", AllConstitutionViewFields.所属菜单);
			this.Fields.Add("创建人", AllConstitutionViewFields.创建人);
			this.Fields.Add("创建日期", AllConstitutionViewFields.创建日期);
			this.Fields.Add("最后修改人", AllConstitutionViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllConstitutionViewFields.最后修改时间);
			this.Fields.Add("备注", AllConstitutionViewFields.备注);
		}
	}

	#region AllConstitutionViewFields

	public class AllConstitutionViewFields
	{
		public static EntityField 规程ID
		{
			get { return new EntityField("vw_AllConstitution", 0, "规程ID", SqlDbType.Int); }
		}

		public static EntityField 规程编号
		{
			get { return new EntityField("vw_AllConstitution", 1, "规程编号", SqlDbType.NVarChar); }
		}

		public static EntityField 规程名称
		{
			get { return new EntityField("vw_AllConstitution", 2, "规程名称", SqlDbType.NVarChar); }
		}

		public static EntityField 所属菜单
		{
			get { return new EntityField("vw_AllConstitution", 3, "所属菜单", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllConstitution", 4, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllConstitution", 5, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllConstitution", 6, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllConstitution", 7, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllConstitution", 8, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
