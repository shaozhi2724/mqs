/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllAcceptView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllAcceptView : ViewBase
	{
		public int 验收单ID
		{
			get { return (int)this.GetValue("验收单ID"); } 
			set { this.SetValue("验收单ID", value); } 
		}

		public string 验收单号
		{
			get { return (string)this.GetValue("验收单号"); } 
			set { this.SetValue("验收单号", value); } 
		}

		public string 验收人
		{
			get { return (string)this.GetValue("验收人"); } 
			set { this.SetValue("验收人", value); } 
		}

		public DateTime 验收日期
		{
			get { return (DateTime)this.GetValue("验收日期"); } 
			set { this.SetValue("验收日期", value); } 
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

		public AllAcceptView()
		{
			this.ViewName = "vw_AllAccept";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("验收单ID", AllAcceptViewFields.验收单ID);
			this.Fields.Add("验收单号", AllAcceptViewFields.验收单号);
			this.Fields.Add("验收人", AllAcceptViewFields.验收人);
			this.Fields.Add("验收日期", AllAcceptViewFields.验收日期);
			this.Fields.Add("订单编号", AllAcceptViewFields.订单编号);
			this.Fields.Add("订单类型", AllAcceptViewFields.订单类型);
			this.Fields.Add("往来单位编号", AllAcceptViewFields.往来单位编号);
			this.Fields.Add("往来单位名称", AllAcceptViewFields.往来单位名称);
			this.Fields.Add("往来单位Spell", AllAcceptViewFields.往来单位Spell);
			this.Fields.Add("创建人", AllAcceptViewFields.创建人);
			this.Fields.Add("创建日期", AllAcceptViewFields.创建日期);
			this.Fields.Add("最后修改人", AllAcceptViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllAcceptViewFields.最后修改时间);
			this.Fields.Add("备注", AllAcceptViewFields.备注);
		}
	}

	#region AllAcceptViewFields

	public class AllAcceptViewFields
	{
		public static EntityField 验收单ID
		{
			get { return new EntityField("vw_AllAccept", 0, "验收单ID", SqlDbType.Int); }
		}

		public static EntityField 验收单号
		{
			get { return new EntityField("vw_AllAccept", 1, "验收单号", SqlDbType.NVarChar); }
		}

		public static EntityField 验收人
		{
			get { return new EntityField("vw_AllAccept", 2, "验收人", SqlDbType.NVarChar); }
		}

		public static EntityField 验收日期
		{
			get { return new EntityField("vw_AllAccept", 3, "验收日期", SqlDbType.DateTime); }
		}

		public static EntityField 订单编号
		{
			get { return new EntityField("vw_AllAccept", 4, "订单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 订单类型
		{
			get { return new EntityField("vw_AllAccept", 5, "订单类型", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位编号
		{
			get { return new EntityField("vw_AllAccept", 6, "往来单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位名称
		{
			get { return new EntityField("vw_AllAccept", 7, "往来单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 往来单位Spell
		{
			get { return new EntityField("vw_AllAccept", 8, "往来单位Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllAccept", 9, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllAccept", 10, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllAccept", 11, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllAccept", 12, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllAccept", 13, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
