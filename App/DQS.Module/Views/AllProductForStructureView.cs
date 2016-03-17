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
		public int 产品ID
		{
			get { return (int)this.GetValue("产品ID"); } 
			set { this.SetValue("产品ID", value); } 
		}

		public string 产品编号
		{
			get { return (string)this.GetValue("产品编号"); } 
			set { this.SetValue("产品编号", value); } 
		}

		public string 产品名称
		{
			get { return (string)this.GetValue("产品名称"); } 
			set { this.SetValue("产品名称", value); } 
		}

		public string 产品名称Spell
		{
			get { return (string)this.GetValue("产品名称Spell"); } 
			set { this.SetValue("产品名称Spell", value); } 
		}

		public string 规格型号
		{
			get { return (string)this.GetValue("规格型号"); } 
			set { this.SetValue("规格型号", value); } 
		}

		public string 剂型
		{
			get { return (string)this.GetValue("剂型"); } 
			set { this.SetValue("剂型", value); } 
		}

		public string 产品类别
		{
			get { return (string)this.GetValue("产品类别"); } 
			set { this.SetValue("产品类别", value); } 
		}

		public string 注册证号
		{
			get { return (string)this.GetValue("注册证号"); } 
			set { this.SetValue("注册证号", value); } 
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
			this.Fields.Add("产品ID", AllProductForStructureViewFields.产品ID);
			this.Fields.Add("产品编号", AllProductForStructureViewFields.产品编号);
			this.Fields.Add("产品名称", AllProductForStructureViewFields.产品名称);
			this.Fields.Add("产品名称Spell", AllProductForStructureViewFields.产品名称Spell);
			this.Fields.Add("规格型号", AllProductForStructureViewFields.规格型号);
			this.Fields.Add("剂型", AllProductForStructureViewFields.剂型);
			this.Fields.Add("产品类别", AllProductForStructureViewFields.产品类别);
			this.Fields.Add("注册证号", AllProductForStructureViewFields.注册证号);
			this.Fields.Add("生产厂商", AllProductForStructureViewFields.生产厂商);
			this.Fields.Add("商品条码", AllProductForStructureViewFields.商品条码);
		}
	}

	#region AllProductForStructureViewFields

	public class AllProductForStructureViewFields
	{
		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllProductForStructure", 0, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllProductForStructure", 1, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllProductForStructure", 2, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称Spell
		{
			get { return new EntityField("vw_AllProductForStructure", 3, "产品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllProductForStructure", 4, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllProductForStructure", 5, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllProductForStructure", 6, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 注册证号
		{
			get { return new EntityField("vw_AllProductForStructure", 7, "注册证号", SqlDbType.NVarChar); }
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
