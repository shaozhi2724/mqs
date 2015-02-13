/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllInventoryView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllInventoryView : ViewBase
	{
		public int 盘点ID
		{
			get { return (int)this.GetValue("盘点ID"); } 
			set { this.SetValue("盘点ID", value); } 
		}

		public string 盘点编号
		{
			get { return (string)this.GetValue("盘点编号"); } 
			set { this.SetValue("盘点编号", value); } 
		}

		public DateTime 盘点时间
		{
			get { return (DateTime)this.GetValue("盘点时间"); } 
			set { this.SetValue("盘点时间", value); } 
		}

		public string 盘点人员
		{
			get { return (string)this.GetValue("盘点人员"); } 
			set { this.SetValue("盘点人员", value); } 
		}

		public string 盘点区域
		{
			get { return (string)this.GetValue("盘点区域"); } 
			set { this.SetValue("盘点区域", value); } 
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

		public AllInventoryView()
		{
			this.ViewName = "vw_AllInventory";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("盘点ID", AllInventoryViewFields.盘点ID);
			this.Fields.Add("盘点编号", AllInventoryViewFields.盘点编号);
			this.Fields.Add("盘点时间", AllInventoryViewFields.盘点时间);
			this.Fields.Add("盘点人员", AllInventoryViewFields.盘点人员);
			this.Fields.Add("盘点区域", AllInventoryViewFields.盘点区域);
			this.Fields.Add("创建人", AllInventoryViewFields.创建人);
			this.Fields.Add("创建日期", AllInventoryViewFields.创建日期);
			this.Fields.Add("最后修改人", AllInventoryViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllInventoryViewFields.最后修改时间);
			this.Fields.Add("备注", AllInventoryViewFields.备注);
		}
	}

	#region AllInventoryViewFields

	public class AllInventoryViewFields
	{
		public static EntityField 盘点ID
		{
			get { return new EntityField("vw_AllInventory", 0, "盘点ID", SqlDbType.Int); }
		}

		public static EntityField 盘点编号
		{
			get { return new EntityField("vw_AllInventory", 1, "盘点编号", SqlDbType.NVarChar); }
		}

		public static EntityField 盘点时间
		{
			get { return new EntityField("vw_AllInventory", 2, "盘点时间", SqlDbType.DateTime); }
		}

		public static EntityField 盘点人员
		{
			get { return new EntityField("vw_AllInventory", 3, "盘点人员", SqlDbType.NVarChar); }
		}

		public static EntityField 盘点区域
		{
			get { return new EntityField("vw_AllInventory", 4, "盘点区域", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllInventory", 5, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllInventory", 6, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllInventory", 7, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllInventory", 8, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllInventory", 9, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
