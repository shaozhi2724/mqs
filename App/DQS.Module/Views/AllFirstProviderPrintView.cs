/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllFirstProviderPrintView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllFirstProviderPrintView : ViewBase
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

		public string 注册地址
		{
			get { return (string)this.GetValue("注册地址"); } 
			set { this.SetValue("注册地址", value); } 
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

		public string 注册资本
		{
			get { return (string)this.GetValue("注册资本"); } 
			set { this.SetValue("注册资本", value); } 
		}

		public string 单位性质
		{
			get { return (string)this.GetValue("单位性质"); } 
			set { this.SetValue("单位性质", value); } 
		}

		public string 营业执照
		{
			get { return (string)this.GetValue("营业执照"); } 
			set { this.SetValue("营业执照", value); } 
		}

		public string 营业执照编号
		{
			get { return (string)this.GetValue("营业执照编号"); } 
			set { this.SetValue("营业执照编号", value); } 
		}

		public string 营业执照发证机关
		{
			get { return (string)this.GetValue("营业执照发证机关"); } 
			set { this.SetValue("营业执照发证机关", value); } 
		}

		public string 营业执照发证日期
		{
			get { return (string)this.GetValue("营业执照发证日期"); } 
			set { this.SetValue("营业执照发证日期", value); } 
		}

		public string 营业执照效期至
		{
			get { return (string)this.GetValue("营业执照效期至"); } 
			set { this.SetValue("营业执照效期至", value); } 
		}

		public string 营业执照备注
		{
			get { return (string)this.GetValue("营业执照备注"); } 
			set { this.SetValue("营业执照备注", value); } 
		}

		public string 药品经营许可证
		{
			get { return (string)this.GetValue("药品经营许可证"); } 
			set { this.SetValue("药品经营许可证", value); } 
		}

		public string 药品经营许可证编号
		{
			get { return (string)this.GetValue("药品经营许可证编号"); } 
			set { this.SetValue("药品经营许可证编号", value); } 
		}

		public string 药品经营许可证发证机关
		{
			get { return (string)this.GetValue("药品经营许可证发证机关"); } 
			set { this.SetValue("药品经营许可证发证机关", value); } 
		}

		public string 药品经营许可证发证日期
		{
			get { return (string)this.GetValue("药品经营许可证发证日期"); } 
			set { this.SetValue("药品经营许可证发证日期", value); } 
		}

		public string 药品经营许可证效期至
		{
			get { return (string)this.GetValue("药品经营许可证效期至"); } 
			set { this.SetValue("药品经营许可证效期至", value); } 
		}

		public string 药品经营许可证备注
		{
			get { return (string)this.GetValue("药品经营许可证备注"); } 
			set { this.SetValue("药品经营许可证备注", value); } 
		}

		public string 药品GSPGMP证书
		{
			get { return (string)this.GetValue("药品GSPGMP证书"); } 
			set { this.SetValue("药品GSPGMP证书", value); } 
		}

		public string 药品GSPGMP证书编号
		{
			get { return (string)this.GetValue("药品GSPGMP证书编号"); } 
			set { this.SetValue("药品GSPGMP证书编号", value); } 
		}

		public string 药品GSPGMP证书效期至
		{
			get { return (string)this.GetValue("药品GSPGMP证书效期至"); } 
			set { this.SetValue("药品GSPGMP证书效期至", value); } 
		}

		public string 法人委托书
		{
			get { return (string)this.GetValue("法人委托书"); } 
			set { this.SetValue("法人委托书", value); } 
		}

		public string 法人委托书编号vs姓名
		{
			get { return (string)this.GetValue("法人委托书编号vs姓名"); } 
			set { this.SetValue("法人委托书编号vs姓名", value); } 
		}

		public string 法人委托书发证机关vs身份证号
		{
			get { return (string)this.GetValue("法人委托书发证机关vs身份证号"); } 
			set { this.SetValue("法人委托书发证机关vs身份证号", value); } 
		}

		public string 法人委托书效期至vs授权委托书期限
		{
			get { return (string)this.GetValue("法人委托书效期至vs授权委托书期限"); } 
			set { this.SetValue("法人委托书效期至vs授权委托书期限", value); } 
		}

		public string 法人委托书备注vs手机号
		{
			get { return (string)this.GetValue("法人委托书备注vs手机号"); } 
			set { this.SetValue("法人委托书备注vs手机号", value); } 
		}

		public string 质量保证协议书
		{
			get { return (string)this.GetValue("质量保证协议书"); } 
			set { this.SetValue("质量保证协议书", value); } 
		}

		public string 质量保证协议书编号
		{
			get { return (string)this.GetValue("质量保证协议书编号"); } 
			set { this.SetValue("质量保证协议书编号", value); } 
		}

		public string 质量保证协议书发证机关
		{
			get { return (string)this.GetValue("质量保证协议书发证机关"); } 
			set { this.SetValue("质量保证协议书发证机关", value); } 
		}

		public string 质量保证协议书发证日期
		{
			get { return (string)this.GetValue("质量保证协议书发证日期"); } 
			set { this.SetValue("质量保证协议书发证日期", value); } 
		}

		public string 质量保证协议书效期至
		{
			get { return (string)this.GetValue("质量保证协议书效期至"); } 
			set { this.SetValue("质量保证协议书效期至", value); } 
		}

		public AllFirstProviderPrintView()
		{
			this.ViewName = "vw_AllFirstProviderPrint";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("单位ID", AllFirstProviderPrintViewFields.单位ID);
			this.Fields.Add("单位编号", AllFirstProviderPrintViewFields.单位编号);
			this.Fields.Add("单位名称", AllFirstProviderPrintViewFields.单位名称);
			this.Fields.Add("注册地址", AllFirstProviderPrintViewFields.注册地址);
			this.Fields.Add("法人", AllFirstProviderPrintViewFields.法人);
			this.Fields.Add("法人电话", AllFirstProviderPrintViewFields.法人电话);
			this.Fields.Add("注册资本", AllFirstProviderPrintViewFields.注册资本);
			this.Fields.Add("单位性质", AllFirstProviderPrintViewFields.单位性质);
			this.Fields.Add("营业执照", AllFirstProviderPrintViewFields.营业执照);
			this.Fields.Add("营业执照编号", AllFirstProviderPrintViewFields.营业执照编号);
			this.Fields.Add("营业执照发证机关", AllFirstProviderPrintViewFields.营业执照发证机关);
			this.Fields.Add("营业执照发证日期", AllFirstProviderPrintViewFields.营业执照发证日期);
			this.Fields.Add("营业执照效期至", AllFirstProviderPrintViewFields.营业执照效期至);
			this.Fields.Add("营业执照备注", AllFirstProviderPrintViewFields.营业执照备注);
			this.Fields.Add("药品经营许可证", AllFirstProviderPrintViewFields.药品经营许可证);
			this.Fields.Add("药品经营许可证编号", AllFirstProviderPrintViewFields.药品经营许可证编号);
			this.Fields.Add("药品经营许可证发证机关", AllFirstProviderPrintViewFields.药品经营许可证发证机关);
			this.Fields.Add("药品经营许可证发证日期", AllFirstProviderPrintViewFields.药品经营许可证发证日期);
			this.Fields.Add("药品经营许可证效期至", AllFirstProviderPrintViewFields.药品经营许可证效期至);
			this.Fields.Add("药品经营许可证备注", AllFirstProviderPrintViewFields.药品经营许可证备注);
			this.Fields.Add("药品GSPGMP证书", AllFirstProviderPrintViewFields.药品GSPGMP证书);
			this.Fields.Add("药品GSPGMP证书编号", AllFirstProviderPrintViewFields.药品GSPGMP证书编号);
			this.Fields.Add("药品GSPGMP证书效期至", AllFirstProviderPrintViewFields.药品GSPGMP证书效期至);
			this.Fields.Add("法人委托书", AllFirstProviderPrintViewFields.法人委托书);
			this.Fields.Add("法人委托书编号vs姓名", AllFirstProviderPrintViewFields.法人委托书编号vs姓名);
			this.Fields.Add("法人委托书发证机关vs身份证号", AllFirstProviderPrintViewFields.法人委托书发证机关vs身份证号);
			this.Fields.Add("法人委托书效期至vs授权委托书期限", AllFirstProviderPrintViewFields.法人委托书效期至vs授权委托书期限);
			this.Fields.Add("法人委托书备注vs手机号", AllFirstProviderPrintViewFields.法人委托书备注vs手机号);
			this.Fields.Add("质量保证协议书", AllFirstProviderPrintViewFields.质量保证协议书);
			this.Fields.Add("质量保证协议书编号", AllFirstProviderPrintViewFields.质量保证协议书编号);
			this.Fields.Add("质量保证协议书发证机关", AllFirstProviderPrintViewFields.质量保证协议书发证机关);
			this.Fields.Add("质量保证协议书发证日期", AllFirstProviderPrintViewFields.质量保证协议书发证日期);
			this.Fields.Add("质量保证协议书效期至", AllFirstProviderPrintViewFields.质量保证协议书效期至);
		}
	}

	#region AllFirstProviderPrintViewFields

	public class AllFirstProviderPrintViewFields
	{
		public static EntityField 单位ID
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 0, "单位ID", SqlDbType.Int); }
		}

		public static EntityField 单位编号
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 1, "单位编号", SqlDbType.NVarChar); }
		}

		public static EntityField 单位名称
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 2, "单位名称", SqlDbType.NVarChar); }
		}

		public static EntityField 注册地址
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 3, "注册地址", SqlDbType.NVarChar); }
		}

		public static EntityField 法人
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 4, "法人", SqlDbType.NVarChar); }
		}

		public static EntityField 法人电话
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 5, "法人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 注册资本
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 6, "注册资本", SqlDbType.NVarChar); }
		}

		public static EntityField 单位性质
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 7, "单位性质", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 8, "营业执照", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照编号
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 9, "营业执照编号", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照发证机关
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 10, "营业执照发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照发证日期
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 11, "营业执照发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照效期至
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 12, "营业执照效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照备注
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 13, "营业执照备注", SqlDbType.NVarChar); }
		}

		public static EntityField 药品经营许可证
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 14, "药品经营许可证", SqlDbType.NVarChar); }
		}

		public static EntityField 药品经营许可证编号
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 15, "药品经营许可证编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品经营许可证发证机关
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 16, "药品经营许可证发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 药品经营许可证发证日期
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 17, "药品经营许可证发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 药品经营许可证效期至
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 18, "药品经营许可证效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 药品经营许可证备注
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 19, "药品经营许可证备注", SqlDbType.NVarChar); }
		}

		public static EntityField 药品GSPGMP证书
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 20, "药品GSPGMP证书", SqlDbType.NVarChar); }
		}

		public static EntityField 药品GSPGMP证书编号
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 21, "药品GSPGMP证书编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品GSPGMP证书效期至
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 22, "药品GSPGMP证书效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 法人委托书
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 23, "法人委托书", SqlDbType.NVarChar); }
		}

		public static EntityField 法人委托书编号vs姓名
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 24, "法人委托书编号vs姓名", SqlDbType.NVarChar); }
		}

		public static EntityField 法人委托书发证机关vs身份证号
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 25, "法人委托书发证机关vs身份证号", SqlDbType.NVarChar); }
		}

		public static EntityField 法人委托书效期至vs授权委托书期限
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 26, "法人委托书效期至vs授权委托书期限", SqlDbType.NVarChar); }
		}

		public static EntityField 法人委托书备注vs手机号
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 27, "法人委托书备注vs手机号", SqlDbType.NVarChar); }
		}

		public static EntityField 质量保证协议书
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 28, "质量保证协议书", SqlDbType.NVarChar); }
		}

		public static EntityField 质量保证协议书编号
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 29, "质量保证协议书编号", SqlDbType.NVarChar); }
		}

		public static EntityField 质量保证协议书发证机关
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 30, "质量保证协议书发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 质量保证协议书发证日期
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 31, "质量保证协议书发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 质量保证协议书效期至
		{
			get { return new EntityField("vw_AllFirstProviderPrint", 32, "质量保证协议书效期至", SqlDbType.NVarChar); }
		}

	}

	#endregion

}
