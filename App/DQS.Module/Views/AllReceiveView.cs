/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllReceiveView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllReceiveView : ViewBase
	{
		public int 收货单ID
		{
			get { return (int)this.GetValue("收货单ID"); } 
			set { this.SetValue("收货单ID", value); } 
		}

		public string 收货单号
		{
			get { return (string)this.GetValue("收货单号"); } 
			set { this.SetValue("收货单号", value); } 
		}

		public string 收货人
		{
			get { return (string)this.GetValue("收货人"); } 
			set { this.SetValue("收货人", value); } 
		}

		public DateTime 收货日期
		{
			get { return (DateTime)this.GetValue("收货日期"); } 
			set { this.SetValue("收货日期", value); } 
		}

		public int 状态ID
		{
			get { return (int)this.GetValue("状态ID"); } 
			set { this.SetValue("状态ID", value); } 
		}

		public string 状态
		{
			get { return (string)this.GetValue("状态"); } 
			set { this.SetValue("状态", value); } 
		}

		public int 订单ID
		{
			get { return (int)this.GetValue("订单ID"); } 
			set { this.SetValue("订单ID", value); } 
		}

		public string 订单编号
		{
			get { return (string)this.GetValue("订单编号"); } 
			set { this.SetValue("订单编号", value); } 
		}

		public DateTime 下单日期
		{
			get { return (DateTime)this.GetValue("下单日期"); } 
			set { this.SetValue("下单日期", value); } 
		}

		public int 订单类型ID
		{
			get { return (int)this.GetValue("订单类型ID"); } 
			set { this.SetValue("订单类型ID", value); } 
		}

		public string 订单类型
		{
			get { return (string)this.GetValue("订单类型"); } 
			set { this.SetValue("订单类型", value); } 
		}

		public string 订单类型Spell
		{
			get { return (string)this.GetValue("订单类型Spell"); } 
			set { this.SetValue("订单类型Spell", value); } 
		}

		public int 往来单位ID
		{
			get { return (int)this.GetValue("往来单位ID"); } 
			set { this.SetValue("往来单位ID", value); } 
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

		public string 同行单号
		{
			get { return (string)this.GetValue("同行单号"); } 
			set { this.SetValue("同行单号", value); } 
		}

		public string 送货单位
		{
			get { return (string)this.GetValue("送货单位"); } 
			set { this.SetValue("送货单位", value); } 
		}

		public string 送货人
		{
			get { return (string)this.GetValue("送货人"); } 
			set { this.SetValue("送货人", value); } 
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

		public AllReceiveView()
		{
			this.ViewName = "vw_AllReceive";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("收货单ID", AllReceiveViewFields.收货单ID);
			this.Fields.Add("收货单号", AllReceiveViewFields.收货单号);
			this.Fields.Add("收货人", AllReceiveViewFields.收货人);
			this.Fields.Add("收货日期", AllReceiveViewFields.收货日期);
			this.Fields.Add("状态ID", AllReceiveViewFields.状态ID);
			this.Fields.Add("状态", AllReceiveViewFields.状态);
			this.Fields.Add("订单ID", AllReceiveViewFields.订单ID);
			this.Fields.Add("订单编号", AllReceiveViewFields.订单编号);
			this.Fields.Add("下单日期", AllReceiveViewFields.下单日期);
			this.Fields.Add("订单类型ID", AllReceiveViewFields.订单类型ID);
			this.Fields.Add("订单类型", AllReceiveViewFields.订单类型);
			this.Fields.Add("订单类型Spell", AllReceiveViewFields.订单类型Spell);
			this.Fields.Add("往来单位ID", AllReceiveViewFields.往来单位ID);
			this.Fields.Add("往来单位编号", AllReceiveViewFields.往来单位编号);
			this.Fields.Add("往来单位名称", AllReceiveViewFields.往来单位名称);
			this.Fields.Add("往来单位Spell", AllReceiveViewFields.往来单位Spell);
			this.Fields.Add("同行单号", AllReceiveViewFields.同行单号);
			this.Fields.Add("送货单位", AllReceiveViewFields.送货单位);
			this.Fields.Add("送货人", AllReceiveViewFields.送货人);
			this.Fields.Add("创建人", AllReceiveViewFields.创建人);
			this.Fields.Add("创建日期", AllReceiveViewFields.创建日期);
			this.Fields.Add("最后修改人", AllReceiveViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllReceiveViewFields.最后修改时间);
			this.Fields.Add("备注", AllReceiveViewFields.备注);
		}
	}

	#region AllReceiveViewFields

	public class AllReceiveViewFields
	{
		public static EntityField 收货单ID
		{
			get { return new EntityField("vw_AllReceive", 0, "收货单ID", SqlDbType.Int); }
		}

		public static EntityField 收货单号
		{
			get { return new EntityField("vw_AllReceive", 1, "收货单号", SqlDbType.NVarChar); }
		}

		public static EntityField 收货人
		{
			get { return new EntityField("vw_AllReceive", 2, "收货人", SqlDbType.NVarChar); }
		}

		public static EntityField 收货日期
		{
			get { return new EntityField("vw_AllReceive", 3, "收货日期", SqlDbType.DateTime); }
		}

		public static EntityField 状态ID
		{
			get { return new EntityField("vw_AllReceive", 4, "状态ID", SqlDbType.Int); }
		}

		public static EntityField 状态
		{
			get { return new EntityField("vw_AllReceive", 5, "状态", SqlDbType.NVarChar); }
		}

		public static EntityField 订单ID
		{
			get { return new EntityField("vw_AllReceive", 6, "订单ID", SqlDbType.Int); }
		}

		public static EntityField 订单编号
		{
			get { return new EntityField("vw_AllReceive", 7, "订单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 下单日期
		{
			get { return new EntityField("vw_AllReceive", 8, "下单日期", SqlDbType.DateTime); }
		}

		public static EntityField 订单类型ID
		{
			get { return new EntityField("vw_AllReceive", 9, "订单类型ID", SqlDbType.Int); }
		}

		public static EntityField 订单类型
		{
			get { return new EntityField("vw_AllReceive", 10, "订单类型", SqlDbType.NVarChar); }
		}

		public static EntityField 订单类型Spell
		{
			get { return new EntityField("vw_AllReceive", 11, "订单类型Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位ID
		{
			get { return new EntityField("vw_AllReceive", 12, "往来单位ID", SqlDbType.Int); }
		}

		public static EntityField 往来单位编号
		{
			get { return new EntityField("vw_AllReceive", 13, "往来单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllReceive", 14, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位Spell
		{
			get { return new EntityField("vw_AllReceive", 15, "往来单位Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 同行单号
		{
			get { return new EntityField("vw_AllReceive", 16, "同行单号", SqlDbType.NVarChar); }
		}

		public static EntityField 送货单位
		{
			get { return new EntityField("vw_AllReceive", 17, "送货单位", SqlDbType.NVarChar); }
		}

		public static EntityField 送货人
		{
			get { return new EntityField("vw_AllReceive", 18, "送货人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllReceive", 19, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllReceive", 20, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllReceive", 21, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllReceive", 22, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllReceive", 23, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
