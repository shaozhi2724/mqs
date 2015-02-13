/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProductStructureView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProductStructureView : ViewBase
	{
		public int 产品ID
		{
			get { return (int)this.GetValue("产品ID"); } 
			set { this.SetValue("产品ID", value); } 
		}

		public int 存储ID
		{
			get { return (int)this.GetValue("存储ID"); } 
			set { this.SetValue("存储ID", value); } 
		}

		public string 药品编号
		{
			get { return (string)this.GetValue("药品编号"); } 
			set { this.SetValue("药品编号", value); } 
		}

		public string 存储编号
		{
			get { return (string)this.GetValue("存储编号"); } 
			set { this.SetValue("存储编号", value); } 
		}

		public string 药品名称
		{
			get { return (string)this.GetValue("药品名称"); } 
			set { this.SetValue("药品名称", value); } 
		}

		public string 存储名称
		{
			get { return (string)this.GetValue("存储名称"); } 
			set { this.SetValue("存储名称", value); } 
		}

		public string 药品名称Spell
		{
			get { return (string)this.GetValue("药品名称Spell"); } 
			set { this.SetValue("药品名称Spell", value); } 
		}

		public string 存储名称Spell
		{
			get { return (string)this.GetValue("存储名称Spell"); } 
			set { this.SetValue("存储名称Spell", value); } 
		}

		public string 存储位置
		{
			get { return (string)this.GetValue("存储位置"); } 
			set { this.SetValue("存储位置", value); } 
		}

		public string 规格
		{
			get { return (string)this.GetValue("规格"); } 
			set { this.SetValue("规格", value); } 
		}

		public string 剂型
		{
			get { return (string)this.GetValue("剂型"); } 
			set { this.SetValue("剂型", value); } 
		}

		public string 药品类别
		{
			get { return (string)this.GetValue("药品类别"); } 
			set { this.SetValue("药品类别", value); } 
		}

		public string 批准文号
		{
			get { return (string)this.GetValue("批准文号"); } 
			set { this.SetValue("批准文号", value); } 
		}

		public string 生产厂商
		{
			get { return (string)this.GetValue("生产厂商"); } 
			set { this.SetValue("生产厂商", value); } 
		}

		public string 所属仓库
		{
			get { return (string)this.GetValue("所属仓库"); } 
			set { this.SetValue("所属仓库", value); } 
		}

		public string 存储类型
		{
			get { return (string)this.GetValue("存储类型"); } 
			set { this.SetValue("存储类型", value); } 
		}

		public AllProductStructureView()
		{
			this.ViewName = "vw_AllProductStructure";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("产品ID", AllProductStructureViewFields.产品ID);
			this.Fields.Add("存储ID", AllProductStructureViewFields.存储ID);
			this.Fields.Add("药品编号", AllProductStructureViewFields.药品编号);
			this.Fields.Add("存储编号", AllProductStructureViewFields.存储编号);
			this.Fields.Add("药品名称", AllProductStructureViewFields.药品名称);
			this.Fields.Add("存储名称", AllProductStructureViewFields.存储名称);
			this.Fields.Add("药品名称Spell", AllProductStructureViewFields.药品名称Spell);
			this.Fields.Add("存储名称Spell", AllProductStructureViewFields.存储名称Spell);
			this.Fields.Add("存储位置", AllProductStructureViewFields.存储位置);
			this.Fields.Add("规格", AllProductStructureViewFields.规格);
			this.Fields.Add("剂型", AllProductStructureViewFields.剂型);
			this.Fields.Add("药品类别", AllProductStructureViewFields.药品类别);
			this.Fields.Add("批准文号", AllProductStructureViewFields.批准文号);
			this.Fields.Add("生产厂商", AllProductStructureViewFields.生产厂商);
			this.Fields.Add("所属仓库", AllProductStructureViewFields.所属仓库);
			this.Fields.Add("存储类型", AllProductStructureViewFields.存储类型);
		}
	}

	#region AllProductStructureViewFields

	public class AllProductStructureViewFields
	{
		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllProductStructure", 0, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 存储ID
		{
			get { return new EntityField("vw_AllProductStructure", 1, "存储ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllProductStructure", 2, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 存储编号
		{
			get { return new EntityField("vw_AllProductStructure", 3, "存储编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllProductStructure", 4, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 存储名称
		{
			get { return new EntityField("vw_AllProductStructure", 5, "存储名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_AllProductStructure", 6, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 存储名称Spell
		{
			get { return new EntityField("vw_AllProductStructure", 7, "存储名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 存储位置
		{
			get { return new EntityField("vw_AllProductStructure", 8, "存储位置", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllProductStructure", 9, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllProductStructure", 10, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllProductStructure", 11, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 批准文号
		{
			get { return new EntityField("vw_AllProductStructure", 12, "批准文号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllProductStructure", 13, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 所属仓库
		{
			get { return new EntityField("vw_AllProductStructure", 14, "所属仓库", SqlDbType.NVarChar); }
		}

		public static EntityField 存储类型
		{
			get { return new EntityField("vw_AllProductStructure", 15, "存储类型", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
