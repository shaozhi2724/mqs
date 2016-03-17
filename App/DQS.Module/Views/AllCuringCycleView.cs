/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllCuringCycleView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllCuringCycleView : ViewBase
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

		public string 周期编码
		{
			get { return (string)this.GetValue("周期编码"); } 
			set { this.SetValue("周期编码", value); } 
		}

		public string 产品名称
		{
			get { return (string)this.GetValue("产品名称"); } 
			set { this.SetValue("产品名称", value); } 
		}

		public int 养护周期
		{
			get { return (int)this.GetValue("养护周期"); } 
			set { this.SetValue("养护周期", value); } 
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

		public string 单位
		{
			get { return (string)this.GetValue("单位"); } 
			set { this.SetValue("单位", value); } 
		}

		public string 包装规格
		{
			get { return (string)this.GetValue("包装规格型号"); } 
			set { this.SetValue("包装规格型号", value); } 
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

		public string 厂商Spell
		{
			get { return (string)this.GetValue("厂商Spell"); } 
			set { this.SetValue("厂商Spell", value); } 
		}

		public string 创建人
		{
			get { return (string)this.GetValue("创建人"); } 
			set { this.SetValue("创建人", value); } 
		}

		public DateTime 创建时间
		{
			get { return (DateTime)this.GetValue("创建时间"); } 
			set { this.SetValue("创建时间", value); } 
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

		public int 周期ID
		{
			get { return (int)this.GetValue("周期ID"); } 
			set { this.SetValue("周期ID", value); } 
		}

		public AllCuringCycleView()
		{
			this.ViewName = "vw_AllCuringCycle";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("产品ID", AllCuringCycleViewFields.产品ID);
			this.Fields.Add("产品编号", AllCuringCycleViewFields.产品编号);
			this.Fields.Add("周期编码", AllCuringCycleViewFields.周期编码);
			this.Fields.Add("产品名称", AllCuringCycleViewFields.产品名称);
			this.Fields.Add("养护周期", AllCuringCycleViewFields.养护周期);
			this.Fields.Add("产品名称Spell", AllCuringCycleViewFields.产品名称Spell);
			this.Fields.Add("规格型号", AllCuringCycleViewFields.规格型号);
			this.Fields.Add("单位", AllCuringCycleViewFields.单位);
			this.Fields.Add("包装规格型号", AllCuringCycleViewFields.包装规格);
			this.Fields.Add("剂型", AllCuringCycleViewFields.剂型);
			this.Fields.Add("产品类别", AllCuringCycleViewFields.产品类别);
			this.Fields.Add("注册证号", AllCuringCycleViewFields.注册证号);
			this.Fields.Add("生产厂商", AllCuringCycleViewFields.生产厂商);
			this.Fields.Add("厂商Spell", AllCuringCycleViewFields.厂商Spell);
			this.Fields.Add("创建人", AllCuringCycleViewFields.创建人);
			this.Fields.Add("创建时间", AllCuringCycleViewFields.创建时间);
			this.Fields.Add("最后修改人", AllCuringCycleViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllCuringCycleViewFields.最后修改时间);
			this.Fields.Add("备注", AllCuringCycleViewFields.备注);
			this.Fields.Add("周期ID", AllCuringCycleViewFields.周期ID);
		}
	}

	#region AllCuringCycleViewFields

	public class AllCuringCycleViewFields
	{
		public static EntityField 产品ID
		{
			get { return new EntityField("vw_AllCuringCycle", 0, "产品ID", SqlDbType.Int); }
		}

		public static EntityField 产品编号
		{
			get { return new EntityField("vw_AllCuringCycle", 1, "产品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 周期编码
		{
			get { return new EntityField("vw_AllCuringCycle", 2, "周期编码", SqlDbType.NVarChar); }
		}

		public static EntityField 产品名称
		{
			get { return new EntityField("vw_AllCuringCycle", 3, "产品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 养护周期
		{
			get { return new EntityField("vw_AllCuringCycle", 4, "养护周期", SqlDbType.Int); }
		}

		public static EntityField 产品名称Spell
		{
			get { return new EntityField("vw_AllCuringCycle", 5, "产品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 规格型号
		{
			get { return new EntityField("vw_AllCuringCycle", 6, "规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllCuringCycle", 7, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 包装规格
		{
			get { return new EntityField("vw_AllCuringCycle", 8, "包装规格型号", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllCuringCycle", 9, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 产品类别
		{
			get { return new EntityField("vw_AllCuringCycle", 10, "产品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 注册证号
		{
			get { return new EntityField("vw_AllCuringCycle", 11, "注册证号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllCuringCycle", 12, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 厂商Spell
		{
			get { return new EntityField("vw_AllCuringCycle", 13, "厂商Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllCuringCycle", 14, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建时间
		{
			get { return new EntityField("vw_AllCuringCycle", 15, "创建时间", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllCuringCycle", 16, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllCuringCycle", 17, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllCuringCycle", 18, "备注", SqlDbType.NVarChar); }
		}

		public static EntityField 周期ID
		{
			get { return new EntityField("vw_AllCuringCycle", 19, "周期ID", SqlDbType.Int); }
		}

	}

	#endregion

}
