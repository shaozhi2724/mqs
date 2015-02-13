﻿/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllFirstDealerView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllFirstDealerView : ViewBase
	{
		public int 单位ID
		{
			get { return (int)this.GetValue("单位ID"); } 
			set { this.SetValue("单位ID", value); } 
		}

		public string 单位编号
		{
			get { return (string)this.GetValue("单位编号"); } 
			set { this.SetValue("单位编号", value); } 
		}

		public string 单位名称
		{
			get { return (string)this.GetValue("单位名称"); } 
			set { this.SetValue("单位名称", value); } 
		}

		public string 单位名称Spell
		{
			get { return (string)this.GetValue("单位名称Spell"); } 
			set { this.SetValue("单位名称Spell", value); } 
		}

		public string 单位类型
		{
			get { return (string)this.GetValue("单位类型"); } 
			set { this.SetValue("单位类型", value); } 
		}

		public string 通讯地址
		{
			get { return (string)this.GetValue("通讯地址"); } 
			set { this.SetValue("通讯地址", value); } 
		}

		public string 省
		{
			get { return (string)this.GetValue("省"); } 
			set { this.SetValue("省", value); } 
		}

		public string 市
		{
			get { return (string)this.GetValue("市"); } 
			set { this.SetValue("市", value); } 
		}

		public string 区县
		{
			get { return (string)this.GetValue("区县"); } 
			set { this.SetValue("区县", value); } 
		}

		public string 固定电话
		{
			get { return (string)this.GetValue("固定电话"); } 
			set { this.SetValue("固定电话", value); } 
		}

		public string 邮编
		{
			get { return (string)this.GetValue("邮编"); } 
			set { this.SetValue("邮编", value); } 
		}

		public string 传真
		{
			get { return (string)this.GetValue("传真"); } 
			set { this.SetValue("传真", value); } 
		}

		public string 电子邮箱
		{
			get { return (string)this.GetValue("电子邮箱"); } 
			set { this.SetValue("电子邮箱", value); } 
		}

		public string 网址
		{
			get { return (string)this.GetValue("网址"); } 
			set { this.SetValue("网址", value); } 
		}

		public string 业务人
		{
			get { return (string)this.GetValue("业务人"); } 
			set { this.SetValue("业务人", value); } 
		}

		public string 业务人电话
		{
			get { return (string)this.GetValue("业务人电话"); } 
			set { this.SetValue("业务人电话", value); } 
		}

		public string 负责人
		{
			get { return (string)this.GetValue("负责人"); } 
			set { this.SetValue("负责人", value); } 
		}

		public string 负责人电话
		{
			get { return (string)this.GetValue("负责人电话"); } 
			set { this.SetValue("负责人电话", value); } 
		}

		public string 法人
		{
			get { return (string)this.GetValue("法人"); } 
			set { this.SetValue("法人", value); } 
		}

		public string 法人电话
		{
			get { return (string)this.GetValue("法人电话"); } 
			set { this.SetValue("法人电话", value); } 
		}

		public string 组织机构代码
		{
			get { return (string)this.GetValue("组织机构代码"); } 
			set { this.SetValue("组织机构代码", value); } 
		}

		public string 注册地址
		{
			get { return (string)this.GetValue("注册地址"); } 
			set { this.SetValue("注册地址", value); } 
		}

		public DateTime 注册日期
		{
			get { return (DateTime)this.GetValue("注册日期"); } 
			set { this.SetValue("注册日期", value); } 
		}

		public string 注册资本
		{
			get { return (string)this.GetValue("注册资本"); } 
			set { this.SetValue("注册资本", value); } 
		}

		public string 营业执照注册号
		{
			get { return (string)this.GetValue("营业执照注册号"); } 
			set { this.SetValue("营业执照注册号", value); } 
		}

		public DateTime 营业执照到期日
		{
			get { return (DateTime)this.GetValue("营业执照到期日"); } 
			set { this.SetValue("营业执照到期日", value); } 
		}

		public string 税务登记证号
		{
			get { return (string)this.GetValue("税务登记证号"); } 
			set { this.SetValue("税务登记证号", value); } 
		}

		public DateTime 税务登记证到期日
		{
			get { return (DateTime)this.GetValue("税务登记证到期日"); } 
			set { this.SetValue("税务登记证到期日", value); } 
		}

		public string 开户行
		{
			get { return (string)this.GetValue("开户行"); } 
			set { this.SetValue("开户行", value); } 
		}

		public string 银行账号
		{
			get { return (string)this.GetValue("银行账号"); } 
			set { this.SetValue("银行账号", value); } 
		}

		public string 电子行号
		{
			get { return (string)this.GetValue("电子行号"); } 
			set { this.SetValue("电子行号", value); } 
		}

		public string 行业类别
		{
			get { return (string)this.GetValue("行业类别"); } 
			set { this.SetValue("行业类别", value); } 
		}

		public string 单位性质
		{
			get { return (string)this.GetValue("单位性质"); } 
			set { this.SetValue("单位性质", value); } 
		}

		public string 从业人数
		{
			get { return (string)this.GetValue("从业人数"); } 
			set { this.SetValue("从业人数", value); } 
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

		public AllFirstDealerView()
		{
			this.ViewName = "vw_AllFirstDealer";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("单位ID", AllFirstDealerViewFields.单位ID);
			this.Fields.Add("单位编号", AllFirstDealerViewFields.单位编号);
			this.Fields.Add("单位名称", AllFirstDealerViewFields.单位名称);
			this.Fields.Add("单位名称Spell", AllFirstDealerViewFields.单位名称Spell);
			this.Fields.Add("单位类型", AllFirstDealerViewFields.单位类型);
			this.Fields.Add("通讯地址", AllFirstDealerViewFields.通讯地址);
			this.Fields.Add("省", AllFirstDealerViewFields.省);
			this.Fields.Add("市", AllFirstDealerViewFields.市);
			this.Fields.Add("区县", AllFirstDealerViewFields.区县);
			this.Fields.Add("固定电话", AllFirstDealerViewFields.固定电话);
			this.Fields.Add("邮编", AllFirstDealerViewFields.邮编);
			this.Fields.Add("传真", AllFirstDealerViewFields.传真);
			this.Fields.Add("电子邮箱", AllFirstDealerViewFields.电子邮箱);
			this.Fields.Add("网址", AllFirstDealerViewFields.网址);
			this.Fields.Add("业务人", AllFirstDealerViewFields.业务人);
			this.Fields.Add("业务人电话", AllFirstDealerViewFields.业务人电话);
			this.Fields.Add("负责人", AllFirstDealerViewFields.负责人);
			this.Fields.Add("负责人电话", AllFirstDealerViewFields.负责人电话);
			this.Fields.Add("法人", AllFirstDealerViewFields.法人);
			this.Fields.Add("法人电话", AllFirstDealerViewFields.法人电话);
			this.Fields.Add("组织机构代码", AllFirstDealerViewFields.组织机构代码);
			this.Fields.Add("注册地址", AllFirstDealerViewFields.注册地址);
			this.Fields.Add("注册日期", AllFirstDealerViewFields.注册日期);
			this.Fields.Add("注册资本", AllFirstDealerViewFields.注册资本);
			this.Fields.Add("营业执照注册号", AllFirstDealerViewFields.营业执照注册号);
			this.Fields.Add("营业执照到期日", AllFirstDealerViewFields.营业执照到期日);
			this.Fields.Add("税务登记证号", AllFirstDealerViewFields.税务登记证号);
			this.Fields.Add("税务登记证到期日", AllFirstDealerViewFields.税务登记证到期日);
			this.Fields.Add("开户行", AllFirstDealerViewFields.开户行);
			this.Fields.Add("银行账号", AllFirstDealerViewFields.银行账号);
			this.Fields.Add("电子行号", AllFirstDealerViewFields.电子行号);
			this.Fields.Add("行业类别", AllFirstDealerViewFields.行业类别);
			this.Fields.Add("单位性质", AllFirstDealerViewFields.单位性质);
			this.Fields.Add("从业人数", AllFirstDealerViewFields.从业人数);
			this.Fields.Add("创建人", AllFirstDealerViewFields.创建人);
			this.Fields.Add("创建日期", AllFirstDealerViewFields.创建日期);
			this.Fields.Add("最后修改人", AllFirstDealerViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllFirstDealerViewFields.最后修改时间);
			this.Fields.Add("备注", AllFirstDealerViewFields.备注);
		}
	}

	#region AllFirstDealerViewFields

	public class AllFirstDealerViewFields
	{
		public static EntityField 单位ID
		{
			get { return new EntityField("vw_AllFirstDealer", 0, "单位ID", SqlDbType.Int); }
		}

		public static EntityField 单位编号
		{
			get { return new EntityField("vw_AllFirstDealer", 1, "单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 单位名称
		{
			get { return new EntityField("vw_AllFirstDealer", 2, "单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 单位名称Spell
		{
			get { return new EntityField("vw_AllFirstDealer", 3, "单位名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 单位类型
		{
			get { return new EntityField("vw_AllFirstDealer", 4, "单位类型", SqlDbType.NVarChar); }
		}

		public static EntityField 通讯地址
		{
			get { return new EntityField("vw_AllFirstDealer", 5, "通讯地址", SqlDbType.NVarChar); }
		}

		public static EntityField 省
		{
			get { return new EntityField("vw_AllFirstDealer", 6, "省", SqlDbType.NVarChar); }
		}

		public static EntityField 市
		{
			get { return new EntityField("vw_AllFirstDealer", 7, "市", SqlDbType.NVarChar); }
		}

		public static EntityField 区县
		{
			get { return new EntityField("vw_AllFirstDealer", 8, "区县", SqlDbType.NVarChar); }
		}

		public static EntityField 固定电话
		{
			get { return new EntityField("vw_AllFirstDealer", 9, "固定电话", SqlDbType.NVarChar); }
		}

		public static EntityField 邮编
		{
			get { return new EntityField("vw_AllFirstDealer", 10, "邮编", SqlDbType.NVarChar); }
		}

		public static EntityField 传真
		{
			get { return new EntityField("vw_AllFirstDealer", 11, "传真", SqlDbType.NVarChar); }
		}

		public static EntityField 电子邮箱
		{
			get { return new EntityField("vw_AllFirstDealer", 12, "电子邮箱", SqlDbType.NVarChar); }
		}

		public static EntityField 网址
		{
			get { return new EntityField("vw_AllFirstDealer", 13, "网址", SqlDbType.NVarChar); }
		}

		public static EntityField 业务人
		{
			get { return new EntityField("vw_AllFirstDealer", 14, "业务人", SqlDbType.NVarChar); }
		}

		public static EntityField 业务人电话
		{
			get { return new EntityField("vw_AllFirstDealer", 15, "业务人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 负责人
		{
			get { return new EntityField("vw_AllFirstDealer", 16, "负责人", SqlDbType.NVarChar); }
		}

		public static EntityField 负责人电话
		{
			get { return new EntityField("vw_AllFirstDealer", 17, "负责人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 法人
		{
			get { return new EntityField("vw_AllFirstDealer", 18, "法人", SqlDbType.NVarChar); }
		}

		public static EntityField 法人电话
		{
			get { return new EntityField("vw_AllFirstDealer", 19, "法人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 组织机构代码
		{
			get { return new EntityField("vw_AllFirstDealer", 20, "组织机构代码", SqlDbType.NVarChar); }
		}

		public static EntityField 注册地址
		{
			get { return new EntityField("vw_AllFirstDealer", 21, "注册地址", SqlDbType.NVarChar); }
		}

		public static EntityField 注册日期
		{
			get { return new EntityField("vw_AllFirstDealer", 22, "注册日期", SqlDbType.DateTime); }
		}

		public static EntityField 注册资本
		{
			get { return new EntityField("vw_AllFirstDealer", 23, "注册资本", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照注册号
		{
			get { return new EntityField("vw_AllFirstDealer", 24, "营业执照注册号", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照到期日
		{
			get { return new EntityField("vw_AllFirstDealer", 25, "营业执照到期日", SqlDbType.DateTime); }
		}

		public static EntityField 税务登记证号
		{
			get { return new EntityField("vw_AllFirstDealer", 26, "税务登记证号", SqlDbType.NVarChar); }
		}

		public static EntityField 税务登记证到期日
		{
			get { return new EntityField("vw_AllFirstDealer", 27, "税务登记证到期日", SqlDbType.DateTime); }
		}

		public static EntityField 开户行
		{
			get { return new EntityField("vw_AllFirstDealer", 28, "开户行", SqlDbType.NVarChar); }
		}

		public static EntityField 银行账号
		{
			get { return new EntityField("vw_AllFirstDealer", 29, "银行账号", SqlDbType.NVarChar); }
		}

		public static EntityField 电子行号
		{
			get { return new EntityField("vw_AllFirstDealer", 30, "电子行号", SqlDbType.NVarChar); }
		}

		public static EntityField 行业类别
		{
			get { return new EntityField("vw_AllFirstDealer", 31, "行业类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位性质
		{
			get { return new EntityField("vw_AllFirstDealer", 32, "单位性质", SqlDbType.NVarChar); }
		}

		public static EntityField 从业人数
		{
			get { return new EntityField("vw_AllFirstDealer", 33, "从业人数", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllFirstDealer", 34, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllFirstDealer", 35, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllFirstDealer", 36, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllFirstDealer", 37, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllFirstDealer", 38, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
