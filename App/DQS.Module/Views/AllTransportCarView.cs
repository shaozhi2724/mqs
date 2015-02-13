/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllTransportCarView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllTransportCarView : ViewBase
	{
		public int 车辆ID
		{
			get { return (int)this.GetValue("车辆ID"); } 
			set { this.SetValue("车辆ID", value); } 
		}

		public string 车辆编号
		{
			get { return (string)this.GetValue("车辆编号"); } 
			set { this.SetValue("车辆编号", value); } 
		}

		public string 车牌号
		{
			get { return (string)this.GetValue("车牌号"); } 
			set { this.SetValue("车牌号", value); } 
		}

		public string 车辆名称
		{
			get { return (string)this.GetValue("车辆名称"); } 
			set { this.SetValue("车辆名称", value); } 
		}

		public string 颜色
		{
			get { return (string)this.GetValue("颜色"); } 
			set { this.SetValue("颜色", value); } 
		}

		public string 车型
		{
			get { return (string)this.GetValue("车型"); } 
			set { this.SetValue("车型", value); } 
		}

		public string 发动机号
		{
			get { return (string)this.GetValue("发动机号"); } 
			set { this.SetValue("发动机号", value); } 
		}

		public string 车架号
		{
			get { return (string)this.GetValue("车架号"); } 
			set { this.SetValue("车架号", value); } 
		}

		public DateTime 购买日期
		{
			get { return (DateTime)this.GetValue("购买日期"); } 
			set { this.SetValue("购买日期", value); } 
		}

		public string 行驶证车主
		{
			get { return (string)this.GetValue("行驶证车主"); } 
			set { this.SetValue("行驶证车主", value); } 
		}

		public string 车主Spell
		{
			get { return (string)this.GetValue("车主Spell"); } 
			set { this.SetValue("车主Spell", value); } 
		}

		public string 车主联系方式
		{
			get { return (string)this.GetValue("车主联系方式"); } 
			set { this.SetValue("车主联系方式", value); } 
		}

		public string 道路运输证
		{
			get { return (string)this.GetValue("道路运输证"); } 
			set { this.SetValue("道路运输证", value); } 
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

		public string 车辆备注
		{
			get { return (string)this.GetValue("车辆备注"); } 
			set { this.SetValue("车辆备注", value); } 
		}

		public AllTransportCarView()
		{
			this.ViewName = "vw_AllTransportCar";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("车辆ID", AllTransportCarViewFields.车辆ID);
			this.Fields.Add("车辆编号", AllTransportCarViewFields.车辆编号);
			this.Fields.Add("车牌号", AllTransportCarViewFields.车牌号);
			this.Fields.Add("车辆名称", AllTransportCarViewFields.车辆名称);
			this.Fields.Add("颜色", AllTransportCarViewFields.颜色);
			this.Fields.Add("车型", AllTransportCarViewFields.车型);
			this.Fields.Add("发动机号", AllTransportCarViewFields.发动机号);
			this.Fields.Add("车架号", AllTransportCarViewFields.车架号);
			this.Fields.Add("购买日期", AllTransportCarViewFields.购买日期);
			this.Fields.Add("行驶证车主", AllTransportCarViewFields.行驶证车主);
			this.Fields.Add("车主Spell", AllTransportCarViewFields.车主Spell);
			this.Fields.Add("车主联系方式", AllTransportCarViewFields.车主联系方式);
			this.Fields.Add("道路运输证", AllTransportCarViewFields.道路运输证);
			this.Fields.Add("创建人", AllTransportCarViewFields.创建人);
			this.Fields.Add("创建日期", AllTransportCarViewFields.创建日期);
			this.Fields.Add("最后修改人", AllTransportCarViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllTransportCarViewFields.最后修改时间);
			this.Fields.Add("车辆备注", AllTransportCarViewFields.车辆备注);
		}
	}

	#region AllTransportCarViewFields

	public class AllTransportCarViewFields
	{
		public static EntityField 车辆ID
		{
			get { return new EntityField("vw_AllTransportCar", 0, "车辆ID", SqlDbType.Int); }
		}

		public static EntityField 车辆编号
		{
			get { return new EntityField("vw_AllTransportCar", 1, "车辆编号", SqlDbType.NVarChar); }
		}

		public static EntityField 车牌号
		{
			get { return new EntityField("vw_AllTransportCar", 2, "车牌号", SqlDbType.NVarChar); }
		}

		public static EntityField 车辆名称
		{
			get { return new EntityField("vw_AllTransportCar", 3, "车辆名称", SqlDbType.NVarChar); }
		}

		public static EntityField 颜色
		{
			get { return new EntityField("vw_AllTransportCar", 4, "颜色", SqlDbType.NVarChar); }
		}

		public static EntityField 车型
		{
			get { return new EntityField("vw_AllTransportCar", 5, "车型", SqlDbType.NVarChar); }
		}

		public static EntityField 发动机号
		{
			get { return new EntityField("vw_AllTransportCar", 6, "发动机号", SqlDbType.NVarChar); }
		}

		public static EntityField 车架号
		{
			get { return new EntityField("vw_AllTransportCar", 7, "车架号", SqlDbType.NVarChar); }
		}

		public static EntityField 购买日期
		{
			get { return new EntityField("vw_AllTransportCar", 8, "购买日期", SqlDbType.DateTime); }
		}

		public static EntityField 行驶证车主
		{
			get { return new EntityField("vw_AllTransportCar", 9, "行驶证车主", SqlDbType.NVarChar); }
		}

		public static EntityField 车主Spell
		{
			get { return new EntityField("vw_AllTransportCar", 10, "车主Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 车主联系方式
		{
			get { return new EntityField("vw_AllTransportCar", 11, "车主联系方式", SqlDbType.NVarChar); }
		}

		public static EntityField 道路运输证
		{
			get { return new EntityField("vw_AllTransportCar", 12, "道路运输证", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllTransportCar", 13, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllTransportCar", 14, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllTransportCar", 15, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllTransportCar", 16, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 车辆备注
		{
			get { return new EntityField("vw_AllTransportCar", 17, "车辆备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
