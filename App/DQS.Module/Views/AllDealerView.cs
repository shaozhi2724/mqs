/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllDealerView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllDealerView : ViewBase
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

		public AllDealerView()
		{
			this.ViewName = "vw_AllDealer";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("单位ID", AllDealerViewFields.单位ID);
			this.Fields.Add("单位编号", AllDealerViewFields.单位编号);
			this.Fields.Add("单位名称", AllDealerViewFields.单位名称);
			this.Fields.Add("单位名称Spell", AllDealerViewFields.单位名称Spell);
			this.Fields.Add("单位类型", AllDealerViewFields.单位类型);
			this.Fields.Add("通讯地址", AllDealerViewFields.通讯地址);
			this.Fields.Add("省", AllDealerViewFields.省);
			this.Fields.Add("市", AllDealerViewFields.市);
			this.Fields.Add("区县", AllDealerViewFields.区县);
			this.Fields.Add("固定电话", AllDealerViewFields.固定电话);
			this.Fields.Add("邮编", AllDealerViewFields.邮编);
			this.Fields.Add("传真", AllDealerViewFields.传真);
			this.Fields.Add("电子邮箱", AllDealerViewFields.电子邮箱);
			this.Fields.Add("网址", AllDealerViewFields.网址);
			this.Fields.Add("业务人", AllDealerViewFields.业务人);
			this.Fields.Add("业务人电话", AllDealerViewFields.业务人电话);
			this.Fields.Add("负责人", AllDealerViewFields.负责人);
			this.Fields.Add("负责人电话", AllDealerViewFields.负责人电话);
			this.Fields.Add("法人", AllDealerViewFields.法人);
			this.Fields.Add("法人电话", AllDealerViewFields.法人电话);
			this.Fields.Add("组织机构代码", AllDealerViewFields.组织机构代码);
			this.Fields.Add("注册地址", AllDealerViewFields.注册地址);
			this.Fields.Add("注册日期", AllDealerViewFields.注册日期);
			this.Fields.Add("注册资本", AllDealerViewFields.注册资本);
			this.Fields.Add("营业执照注册号", AllDealerViewFields.营业执照注册号);
			this.Fields.Add("营业执照到期日", AllDealerViewFields.营业执照到期日);
			this.Fields.Add("税务登记证号", AllDealerViewFields.税务登记证号);
			this.Fields.Add("税务登记证到期日", AllDealerViewFields.税务登记证到期日);
			this.Fields.Add("开户行", AllDealerViewFields.开户行);
			this.Fields.Add("银行账号", AllDealerViewFields.银行账号);
			this.Fields.Add("电子行号", AllDealerViewFields.电子行号);
			this.Fields.Add("行业类别", AllDealerViewFields.行业类别);
			this.Fields.Add("单位性质", AllDealerViewFields.单位性质);
			this.Fields.Add("从业人数", AllDealerViewFields.从业人数);
			this.Fields.Add("创建人", AllDealerViewFields.创建人);
			this.Fields.Add("创建日期", AllDealerViewFields.创建日期);
			this.Fields.Add("最后修改人", AllDealerViewFields.最后修改人);
			this.Fields.Add("最后修改时间", AllDealerViewFields.最后修改时间);
			this.Fields.Add("备注", AllDealerViewFields.备注);
		}
	}

	#region AllDealerViewFields

	public class AllDealerViewFields
	{
		public static EntityField 单位ID
		{
			get { return new EntityField("vw_AllDealer", 0, "单位ID", SqlDbType.Int); }
		}

		public static EntityField 单位编号
		{
			get { return new EntityField("vw_AllDealer", 1, "单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 单位名称
		{
			get { return new EntityField("vw_AllDealer", 2, "单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 单位名称Spell
		{
			get { return new EntityField("vw_AllDealer", 3, "单位名称Spell", SqlDbType.NVarChar); }
		}

		public static EntityField 单位类型
		{
			get { return new EntityField("vw_AllDealer", 4, "单位类型", SqlDbType.NVarChar); }
		}

		public static EntityField 通讯地址
		{
			get { return new EntityField("vw_AllDealer", 5, "通讯地址", SqlDbType.NVarChar); }
		}

		public static EntityField 省
		{
			get { return new EntityField("vw_AllDealer", 6, "省", SqlDbType.NVarChar); }
		}

		public static EntityField 市
		{
			get { return new EntityField("vw_AllDealer", 7, "市", SqlDbType.NVarChar); }
		}

		public static EntityField 区县
		{
			get { return new EntityField("vw_AllDealer", 8, "区县", SqlDbType.NVarChar); }
		}

		public static EntityField 固定电话
		{
			get { return new EntityField("vw_AllDealer", 9, "固定电话", SqlDbType.NVarChar); }
		}

		public static EntityField 邮编
		{
			get { return new EntityField("vw_AllDealer", 10, "邮编", SqlDbType.NVarChar); }
		}

		public static EntityField 传真
		{
			get { return new EntityField("vw_AllDealer", 11, "传真", SqlDbType.NVarChar); }
		}

		public static EntityField 电子邮箱
		{
			get { return new EntityField("vw_AllDealer", 12, "电子邮箱", SqlDbType.NVarChar); }
		}

		public static EntityField 网址
		{
			get { return new EntityField("vw_AllDealer", 13, "网址", SqlDbType.NVarChar); }
		}

		public static EntityField 业务人
		{
			get { return new EntityField("vw_AllDealer", 14, "业务人", SqlDbType.NVarChar); }
		}

		public static EntityField 业务人电话
		{
			get { return new EntityField("vw_AllDealer", 15, "业务人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 负责人
		{
			get { return new EntityField("vw_AllDealer", 16, "负责人", SqlDbType.NVarChar); }
		}

		public static EntityField 负责人电话
		{
			get { return new EntityField("vw_AllDealer", 17, "负责人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 法人
		{
			get { return new EntityField("vw_AllDealer", 18, "法人", SqlDbType.NVarChar); }
		}

		public static EntityField 法人电话
		{
			get { return new EntityField("vw_AllDealer", 19, "法人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 组织机构代码
		{
			get { return new EntityField("vw_AllDealer", 20, "组织机构代码", SqlDbType.NVarChar); }
		}

		public static EntityField 注册地址
		{
			get { return new EntityField("vw_AllDealer", 21, "注册地址", SqlDbType.NVarChar); }
		}

		public static EntityField 注册日期
		{
			get { return new EntityField("vw_AllDealer", 22, "注册日期", SqlDbType.DateTime); }
		}

		public static EntityField 注册资本
		{
			get { return new EntityField("vw_AllDealer", 23, "注册资本", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照注册号
		{
			get { return new EntityField("vw_AllDealer", 24, "营业执照注册号", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照到期日
		{
			get { return new EntityField("vw_AllDealer", 25, "营业执照到期日", SqlDbType.DateTime); }
		}

		public static EntityField 税务登记证号
		{
			get { return new EntityField("vw_AllDealer", 26, "税务登记证号", SqlDbType.NVarChar); }
		}

		public static EntityField 税务登记证到期日
		{
			get { return new EntityField("vw_AllDealer", 27, "税务登记证到期日", SqlDbType.DateTime); }
		}

		public static EntityField 开户行
		{
			get { return new EntityField("vw_AllDealer", 28, "开户行", SqlDbType.NVarChar); }
		}

		public static EntityField 银行账号
		{
			get { return new EntityField("vw_AllDealer", 29, "银行账号", SqlDbType.NVarChar); }
		}

		public static EntityField 电子行号
		{
			get { return new EntityField("vw_AllDealer", 30, "电子行号", SqlDbType.NVarChar); }
		}

		public static EntityField 行业类别
		{
			get { return new EntityField("vw_AllDealer", 31, "行业类别", SqlDbType.NVarChar); }
		}

		public static EntityField 单位性质
		{
			get { return new EntityField("vw_AllDealer", 32, "单位性质", SqlDbType.NVarChar); }
		}

		public static EntityField 从业人数
		{
			get { return new EntityField("vw_AllDealer", 33, "从业人数", SqlDbType.NVarChar); }
		}

		public static EntityField 创建人
		{
			get { return new EntityField("vw_AllDealer", 34, "创建人", SqlDbType.NVarChar); }
		}

		public static EntityField 创建日期
		{
			get { return new EntityField("vw_AllDealer", 35, "创建日期", SqlDbType.DateTime); }
		}

		public static EntityField 最后修改人
		{
			get { return new EntityField("vw_AllDealer", 36, "最后修改人", SqlDbType.NVarChar); }
		}

		public static EntityField 最后修改时间
		{
			get { return new EntityField("vw_AllDealer", 37, "最后修改时间", SqlDbType.DateTime); }
		}

		public static EntityField 备注
		{
			get { return new EntityField("vw_AllDealer", 38, "备注", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
