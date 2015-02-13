/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllSamplingView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllSamplingView : ViewBase
	{
		public int 抽检单ID
		{
			get { return (int)this.GetValue("抽检单ID"); } 
			set { this.SetValue("抽检单ID", value); } 
		}

		public string 抽检单号
		{
			get { return (string)this.GetValue("抽检单号"); } 
			set { this.SetValue("抽检单号", value); } 
		}

		public string 抽检人
		{
			get { return (string)this.GetValue("抽检人"); } 
			set { this.SetValue("抽检人", value); } 
		}

		public DateTime 抽检日期
		{
			get { return (DateTime)this.GetValue("抽检日期"); } 
			set { this.SetValue("抽检日期", value); } 
		}

		public string 订单编号
		{
			get { return (string)this.GetValue("订单编号"); } 
			set { this.SetValue("订单编号", value); } 
		}

		public string 订单类型
		{
			get { return (string)this.GetValue("订单类型"); } 
			set { this.SetValue("订单类型", value); } 
		}

		public string 往来单位编号
		{
			get { return (string)this.GetValue("往来单位编号"); } 
			set { this.SetValue("往来单位编号", value); } 
		}

		public string 往来单位名称
		{
			get { return (string)this.GetValue("往来单位名称"); } 
			set { this.SetValue("往来单位名称", value); } 
		}

		public string 往来单位Spell
		{
			get { return (string)this.GetValue("往来单位Spell"); } 
			set { this.SetValue("往来单位Spell", value); } 
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

		public AllSamplingView()
		{
			this.ViewName = "vw_AllSampling";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("抽检单ID", AllSamplingViewFields.抽检单ID);
			this.Fields.Add("抽检单号", AllSamplingViewFields.抽检单号);
			this.Fields.Add("抽检人", AllSamplingViewFields.抽检人);
			this.Fields.Add("抽检日期", AllSamplingViewFields.抽检日期);
			this.Fields.Add("订单编号", AllSamplingViewFields.订单编号);
			this.Fields.Add("订单类型", AllSamplingViewFields.订单类型);
			this.Fields.Add("往来单位编号", AllSamplingViewFields.往来单位编号);
			this.Fields.Add("往来单位名称", AllSamplingViewFields.往来单位名称);
			this.Fields.Add("往来单位Spell", AllSamplingViewFields.往来单位Spell);
			this.Fields.Add("创建人", AllSamplingViewFields.创建人);
			this.Fields.Add("创建日期", AllSamplingViewFields.创建日期);
			this.Fields.Add("最后修改人", AllSamplingViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllSamplingViewFields.最后修改时间);
			this.Fields.Add("备注", AllSamplingViewFields.备注);
		}
	}

	#region AllSamplingViewFields

	public class AllSamplingViewFields
	{
		public static EntityField 抽检单ID
		{
			get { return new EntityField("vw_AllSampling", 0, "抽检单ID", SqlDbType.Int); }
		}

		public static EntityField 抽检单号
		{
			get { return new EntityField("vw_AllSampling", 1, "抽检单号", SqlDbType.NVarChar); }
		}

		public static EntityField 抽检人
		{
			get { return new EntityField("vw_AllSampling", 2, "抽检人", SqlDbType.NVarChar); }
		}

		public static EntityField 抽检日期
		{
			get { return new EntityField("vw_AllSampling", 3, "抽检日期", SqlDbType.DateTime); }
		}

		public static EntityField 订单编号
		{
			get { return new EntityField("vw_AllSampling", 4, "订单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 订单类型
		{
			get { return new EntityField("vw_AllSampling", 5, "订单类型", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位编号
		{
			get { return new EntityField("vw_AllSampling", 6, "往来单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllSampling", 7, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位Spell
		{
			get { return new EntityField("vw_AllSampling", 8, "往来单位Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllSampling", 9, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllSampling", 10, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllSampling", 11, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllSampling", 12, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllSampling", 13, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
