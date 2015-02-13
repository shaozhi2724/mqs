/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllCuringPlanView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllCuringPlanView : ViewBase
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

		public DateTime 上次保养日期
		{
			get { return (DateTime)this.GetValue("上次保养日期"); } 
			set { this.SetValue("上次保养日期", value); } 
		}

		public int 养护周期
		{
			get { return (int)this.GetValue("养护周期"); } 
			set { this.SetValue("养护周期", value); } 
		}

		public DateTime 下次保养日期
		{
			get { return (DateTime)this.GetValue("下次保养日期"); } 
			set { this.SetValue("下次保养日期", value); } 
		}

		public string 批号
		{
			get { return (string)this.GetValue("批号"); } 
			set { this.SetValue("批号", value); } 
		}

		public int 库存数量
		{
			get { return (int)this.GetValue("库存数量"); } 
			set { this.SetValue("库存数量", value); } 
		}

		public DateTime 生产日期
		{
			get { return (DateTime)this.GetValue("生产日期"); } 
			set { this.SetValue("生产日期", value); } 
		}

		public DateTime 有效期至
		{
			get { return (DateTime)this.GetValue("有效期至"); } 
			set { this.SetValue("有效期至", value); } 
		}

		public string 规格
		{
			get { return (string)this.GetValue("规格"); } 
			set { this.SetValue("规格", value); } 
		}

		public string 单位
		{
			get { return (string)this.GetValue("单位"); } 
			set { this.SetValue("单位", value); } 
		}

		public string 包装规格
		{
			get { return (string)this.GetValue("包装规格"); } 
			set { this.SetValue("包装规格", value); } 
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

		public string 生产厂商Spell
		{
			get { return (string)this.GetValue("生产厂商Spell"); } 
			set { this.SetValue("生产厂商Spell", value); } 
		}

		public AllCuringPlanView()
		{
			this.ViewName = "vw_AllCuringPlan";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("药品ID", AllCuringPlanViewFields.药品ID);
			this.Fields.Add("药品编号", AllCuringPlanViewFields.药品编号);
			this.Fields.Add("药品名称", AllCuringPlanViewFields.药品名称);
			this.Fields.Add("药品名称Spell", AllCuringPlanViewFields.药品名称Spell);
			this.Fields.Add("上次保养日期", AllCuringPlanViewFields.上次保养日期);
			this.Fields.Add("养护周期", AllCuringPlanViewFields.养护周期);
			this.Fields.Add("下次保养日期", AllCuringPlanViewFields.下次保养日期);
			this.Fields.Add("批号", AllCuringPlanViewFields.批号);
			this.Fields.Add("库存数量", AllCuringPlanViewFields.库存数量);
			this.Fields.Add("生产日期", AllCuringPlanViewFields.生产日期);
			this.Fields.Add("有效期至", AllCuringPlanViewFields.有效期至);
			this.Fields.Add("规格", AllCuringPlanViewFields.规格);
			this.Fields.Add("单位", AllCuringPlanViewFields.单位);
			this.Fields.Add("包装规格", AllCuringPlanViewFields.包装规格);
			this.Fields.Add("剂型", AllCuringPlanViewFields.剂型);
			this.Fields.Add("药品类别", AllCuringPlanViewFields.药品类别);
			this.Fields.Add("批准文号", AllCuringPlanViewFields.批准文号);
			this.Fields.Add("生产厂商", AllCuringPlanViewFields.生产厂商);
			this.Fields.Add("生产厂商Spell", AllCuringPlanViewFields.生产厂商Spell);
		}
	}

	#region AllCuringPlanViewFields

	public class AllCuringPlanViewFields
	{
		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllCuringPlan", 0, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllCuringPlan", 1, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllCuringPlan", 2, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称Spell
		{
			get { return new EntityField("vw_AllCuringPlan", 3, "药品名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 上次保养日期
		{
			get { return new EntityField("vw_AllCuringPlan", 4, "上次保养日期", SqlDbType.DateTime); }
		}

		public static EntityField 养护周期
		{
			get { return new EntityField("vw_AllCuringPlan", 5, "养护周期", SqlDbType.Int); }
		}

		public static EntityField 下次保养日期
		{
			get { return new EntityField("vw_AllCuringPlan", 6, "下次保养日期", SqlDbType.DateTime); }
		}

		public static EntityField 批号
		{
			get { return new EntityField("vw_AllCuringPlan", 7, "批号", SqlDbType.NVarChar); }
		}

		public static EntityField 库存数量
		{
			get { return new EntityField("vw_AllCuringPlan", 8, "库存数量", SqlDbType.Int); }
		}

		public static EntityField 生产日期
		{
			get { return new EntityField("vw_AllCuringPlan", 9, "生产日期", SqlDbType.DateTime); }
		}

		public static EntityField 有效期至
		{
			get { return new EntityField("vw_AllCuringPlan", 10, "有效期至", SqlDbType.DateTime); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllCuringPlan", 11, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllCuringPlan", 12, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 包装规格
		{
			get { return new EntityField("vw_AllCuringPlan", 13, "包装规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllCuringPlan", 14, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllCuringPlan", 15, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 批准文号
		{
			get { return new EntityField("vw_AllCuringPlan", 16, "批准文号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllCuringPlan", 17, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商Spell
		{
			get { return new EntityField("vw_AllCuringPlan", 18, "生产厂商Spell", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
