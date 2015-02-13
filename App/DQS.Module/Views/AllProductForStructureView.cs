/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllProductForStructureView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllProductForStructureView : ViewBase
	{
		public int 药品ID
		{
			get { return (int)this.GetValue("药品ID"); } 
			set { this.SetValue("药品ID", value); } 
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

		public string 商品条码
		{
			get { return (string)this.GetValue("商品条码"); } 
			set { this.SetValue("商品条码", value); } 
		}

		public AllProductForStructureView()
		{
			this.ViewName = "vw_AllProductForStructure";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("药品ID", AllProductForStructureViewFields.药品ID);
			this.Fields.Add("药品编号", AllProductForStructureViewFields.药品编号);
			this.Fields.Add("药品名称", AllProductForStructureViewFields.药品名称);
			this.Fields.Add("药品名称Spell", AllProductForStructureViewFields.药品名称Spell);
			this.Fields.Add("规格", AllProductForStructureViewFields.规格);
			this.Fields.Add("剂型", AllProductForStructureViewFields.剂型);
			this.Fields.Add("药品类别", AllProductForStructureViewFields.药品类别);
			this.Fields.Add("批准文号", AllProductForStructureViewFields.批准文号);
			this.Fields.Add("生产厂商", AllProductForStructureViewFields.生产厂商);
			this.Fields.Add("商品条码", AllProductForStructureViewFields.商品条码);
		}
	}

	#region AllProductForStructureViewFields

	public class AllProductForStructureViewFields
	{
		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllProductForStructure", 0, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllProductForStructure", 1, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllProductForStructure", 2, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_AllProductForStructure", 3, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllProductForStructure", 4, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllProductForStructure", 5, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllProductForStructure", 6, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 批准文号
		{
			get { return new EntityField("vw_AllProductForStructure", 7, "批准文号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllProductForStructure", 8, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 商品条码
		{
			get { return new EntityField("vw_AllProductForStructure", 9, "商品条码", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
