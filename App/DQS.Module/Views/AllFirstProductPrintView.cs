/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2014-03-04 22:32:22
 *	Build Type: View
 *	Description: AllFirstProductPrintView
*/

using System;
using System.Collections.Generic;
using System.Data;
using ORMSCore;

namespace DQS.Module.Views
{
	public class AllFirstProductPrintView : ViewBase
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

		public string 通用名称
		{
			get { return (string)this.GetValue("通用名称"); } 
			set { this.SetValue("通用名称", value); } 
		}

		public string 商品名称
		{
			get { return (string)this.GetValue("商品名称"); } 
			set { this.SetValue("商品名称", value); } 
		}

		public string 商品条码
		{
			get { return (string)this.GetValue("商品条码"); } 
			set { this.SetValue("商品条码", value); } 
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

		public string 效期
		{
			get { return (string)this.GetValue("效期"); } 
			set { this.SetValue("效期", value); } 
		}

		public string 首次供货商
		{
			get { return (string)this.GetValue("首次供货商"); } 
			set { this.SetValue("首次供货商", value); } 
		}

		public string 生产地址
		{
			get { return (string)this.GetValue("生产地址"); } 
			set { this.SetValue("生产地址", value); } 
		}

		public string 邮政编码
		{
			get { return (string)this.GetValue("邮政编码"); } 
			set { this.SetValue("邮政编码", value); } 
		}

		public string 电话
		{
			get { return (string)this.GetValue("电话"); } 
			set { this.SetValue("电话", value); } 
		}

		public string 传真
		{
			get { return (string)this.GetValue("传真"); } 
			set { this.SetValue("传真", value); } 
		}

		public string 联系人
		{
			get { return (string)this.GetValue("联系人"); } 
			set { this.SetValue("联系人", value); } 
		}

		public string 联系人电话
		{
			get { return (string)this.GetValue("联系人电话"); } 
			set { this.SetValue("联系人电话", value); } 
		}

		public bool 是否是电子监管药品
		{
			get { return (bool)this.GetValue("是否是电子监管药品"); } 
			set { this.SetValue("是否是电子监管药品", value); } 
		}

		public string 监管标识条码
		{
			get { return (string)this.GetValue("监管标识条码"); } 
			set { this.SetValue("监管标识条码", value); } 
		}

		public string 适应症
		{
			get { return (string)this.GetValue("适应症"); } 
			set { this.SetValue("适应症", value); } 
		}

		public string 贮藏条件
		{
			get { return (string)this.GetValue("贮藏条件"); } 
			set { this.SetValue("贮藏条件", value); } 
		}

		public string 性状
		{
			get { return (string)this.GetValue("性状"); } 
			set { this.SetValue("性状", value); } 
		}

		public string 执行标准
		{
			get { return (string)this.GetValue("执行标准"); } 
			set { this.SetValue("执行标准", value); } 
		}

		public string 商标
		{
			get { return (string)this.GetValue("商标"); } 
			set { this.SetValue("商标", value); } 
		}

		public string 性状用途
		{
			get { return (string)this.GetValue("性状用途"); } 
			set { this.SetValue("性状用途", value); } 
		}

		public string 药品GMP证书
		{
			get { return (string)this.GetValue("药品GMP证书"); } 
			set { this.SetValue("药品GMP证书", value); } 
		}

		public string GMP证书编号
		{
			get { return (string)this.GetValue("GMP证书编号"); } 
			set { this.SetValue("GMP证书编号", value); } 
		}

		public string GMP证书发证机关
		{
			get { return (string)this.GetValue("GMP证书发证机关"); } 
			set { this.SetValue("GMP证书发证机关", value); } 
		}

		public string GMP发证日期
		{
			get { return (string)this.GetValue("GMP发证日期"); } 
			set { this.SetValue("GMP发证日期", value); } 
		}

		public string GMP效期至
		{
			get { return (string)this.GetValue("GMP效期至"); } 
			set { this.SetValue("GMP效期至", value); } 
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

		public string 药品注册证
		{
			get { return (string)this.GetValue("药品注册证"); } 
			set { this.SetValue("药品注册证", value); } 
		}

		public string 药品注册证编号
		{
			get { return (string)this.GetValue("药品注册证编号"); } 
			set { this.SetValue("药品注册证编号", value); } 
		}

		public string 药品注册证发证机关
		{
			get { return (string)this.GetValue("药品注册证发证机关"); } 
			set { this.SetValue("药品注册证发证机关", value); } 
		}

		public string 药品注册证发证日期
		{
			get { return (string)this.GetValue("药品注册证发证日期"); } 
			set { this.SetValue("药品注册证发证日期", value); } 
		}

		public string 药品注册证效期至
		{
			get { return (string)this.GetValue("药品注册证效期至"); } 
			set { this.SetValue("药品注册证效期至", value); } 
		}

		public string 委托生产批件
		{
			get { return (string)this.GetValue("委托生产批件"); } 
			set { this.SetValue("委托生产批件", value); } 
		}

		public string 委托生产批件编号
		{
			get { return (string)this.GetValue("委托生产批件编号"); } 
			set { this.SetValue("委托生产批件编号", value); } 
		}

		public string 委托生产批件发证机关
		{
			get { return (string)this.GetValue("委托生产批件发证机关"); } 
			set { this.SetValue("委托生产批件发证机关", value); } 
		}

		public string 委托生产批件发证日期
		{
			get { return (string)this.GetValue("委托生产批件发证日期"); } 
			set { this.SetValue("委托生产批件发证日期", value); } 
		}

		public string 委托生产批件效期至
		{
			get { return (string)this.GetValue("委托生产批件效期至"); } 
			set { this.SetValue("委托生产批件效期至", value); } 
		}

		public string 药品生产许可证
		{
			get { return (string)this.GetValue("药品生产许可证"); } 
			set { this.SetValue("药品生产许可证", value); } 
		}

		public string 药品生产许可证编号
		{
			get { return (string)this.GetValue("药品生产许可证编号"); } 
			set { this.SetValue("药品生产许可证编号", value); } 
		}

		public string 药品生产许可证发证机关
		{
			get { return (string)this.GetValue("药品生产许可证发证机关"); } 
			set { this.SetValue("药品生产许可证发证机关", value); } 
		}

		public string 药品生产许可证发证日期
		{
			get { return (string)this.GetValue("药品生产许可证发证日期"); } 
			set { this.SetValue("药品生产许可证发证日期", value); } 
		}

		public string 药品生产许可证效期至
		{
			get { return (string)this.GetValue("药品生产许可证效期至"); } 
			set { this.SetValue("药品生产许可证效期至", value); } 
		}

		public string 药品标签
		{
			get { return (string)this.GetValue("药品标签"); } 
			set { this.SetValue("药品标签", value); } 
		}

		public string 药品标签编号
		{
			get { return (string)this.GetValue("药品标签编号"); } 
			set { this.SetValue("药品标签编号", value); } 
		}

		public string 药品标签发证机关
		{
			get { return (string)this.GetValue("药品标签发证机关"); } 
			set { this.SetValue("药品标签发证机关", value); } 
		}

		public string 药品标签发证日期
		{
			get { return (string)this.GetValue("药品标签发证日期"); } 
			set { this.SetValue("药品标签发证日期", value); } 
		}

		public string 药品标签效期至
		{
			get { return (string)this.GetValue("药品标签效期至"); } 
			set { this.SetValue("药品标签效期至", value); } 
		}

		public string 说明书
		{
			get { return (string)this.GetValue("说明书"); } 
			set { this.SetValue("说明书", value); } 
		}

		public string 说明书编号
		{
			get { return (string)this.GetValue("说明书编号"); } 
			set { this.SetValue("说明书编号", value); } 
		}

		public string 说明书发证机关
		{
			get { return (string)this.GetValue("说明书发证机关"); } 
			set { this.SetValue("说明书发证机关", value); } 
		}

		public string 说明书发证日期
		{
			get { return (string)this.GetValue("说明书发证日期"); } 
			set { this.SetValue("说明书发证日期", value); } 
		}

		public string 说明书效期至
		{
			get { return (string)this.GetValue("说明书效期至"); } 
			set { this.SetValue("说明书效期至", value); } 
		}

		public string 外包装
		{
			get { return (string)this.GetValue("外包装"); } 
			set { this.SetValue("外包装", value); } 
		}

		public string 外包装编号
		{
			get { return (string)this.GetValue("外包装编号"); } 
			set { this.SetValue("外包装编号", value); } 
		}

		public string 外包装发证机关
		{
			get { return (string)this.GetValue("外包装发证机关"); } 
			set { this.SetValue("外包装发证机关", value); } 
		}

		public string 外包装发证日期
		{
			get { return (string)this.GetValue("外包装发证日期"); } 
			set { this.SetValue("外包装发证日期", value); } 
		}

		public string 外包装效期至
		{
			get { return (string)this.GetValue("外包装效期至"); } 
			set { this.SetValue("外包装效期至", value); } 
		}

		public string 检验报告
		{
			get { return (string)this.GetValue("检验报告"); } 
			set { this.SetValue("检验报告", value); } 
		}

		public string 检验报告编号
		{
			get { return (string)this.GetValue("检验报告编号"); } 
			set { this.SetValue("检验报告编号", value); } 
		}

		public string 检验报告发证机关
		{
			get { return (string)this.GetValue("检验报告发证机关"); } 
			set { this.SetValue("检验报告发证机关", value); } 
		}

		public string 检验报告发证日期
		{
			get { return (string)this.GetValue("检验报告发证日期"); } 
			set { this.SetValue("检验报告发证日期", value); } 
		}

		public string 检验报告效期至
		{
			get { return (string)this.GetValue("检验报告效期至"); } 
			set { this.SetValue("检验报告效期至", value); } 
		}

		public string 检验标准和检验方法
		{
			get { return (string)this.GetValue("检验标准和检验方法"); } 
			set { this.SetValue("检验标准和检验方法", value); } 
		}

		public string 检验标准和检验方法编号
		{
			get { return (string)this.GetValue("检验标准和检验方法编号"); } 
			set { this.SetValue("检验标准和检验方法编号", value); } 
		}

		public string 检验标准和检验方法发证机关
		{
			get { return (string)this.GetValue("检验标准和检验方法发证机关"); } 
			set { this.SetValue("检验标准和检验方法发证机关", value); } 
		}

		public string 检验标准和检验方法发证日期
		{
			get { return (string)this.GetValue("检验标准和检验方法发证日期"); } 
			set { this.SetValue("检验标准和检验方法发证日期", value); } 
		}

		public string 检验标准和检验方法效期至
		{
			get { return (string)this.GetValue("检验标准和检验方法效期至"); } 
			set { this.SetValue("检验标准和检验方法效期至", value); } 
		}

		public string 进口药品注册证
		{
			get { return (string)this.GetValue("进口药品注册证"); } 
			set { this.SetValue("进口药品注册证", value); } 
		}

		public string 进口药品注册证编号
		{
			get { return (string)this.GetValue("进口药品注册证编号"); } 
			set { this.SetValue("进口药品注册证编号", value); } 
		}

		public string 进口药品注册证发证机关
		{
			get { return (string)this.GetValue("进口药品注册证发证机关"); } 
			set { this.SetValue("进口药品注册证发证机关", value); } 
		}

		public string 进口药品注册证发证日期
		{
			get { return (string)this.GetValue("进口药品注册证发证日期"); } 
			set { this.SetValue("进口药品注册证发证日期", value); } 
		}

		public string 进口药品注册证效期至
		{
			get { return (string)this.GetValue("进口药品注册证效期至"); } 
			set { this.SetValue("进口药品注册证效期至", value); } 
		}

		public string 医药产品注册证
		{
			get { return (string)this.GetValue("医药产品注册证"); } 
			set { this.SetValue("医药产品注册证", value); } 
		}

		public string 医药产品注册证编号
		{
			get { return (string)this.GetValue("医药产品注册证编号"); } 
			set { this.SetValue("医药产品注册证编号", value); } 
		}

		public string 医药产品注册证发证机关
		{
			get { return (string)this.GetValue("医药产品注册证发证机关"); } 
			set { this.SetValue("医药产品注册证发证机关", value); } 
		}

		public string 医药产品注册证发证日期
		{
			get { return (string)this.GetValue("医药产品注册证发证日期"); } 
			set { this.SetValue("医药产品注册证发证日期", value); } 
		}

		public string 医药产品注册证效期至
		{
			get { return (string)this.GetValue("医药产品注册证效期至"); } 
			set { this.SetValue("医药产品注册证效期至", value); } 
		}

		public string 进口药品检验报告单
		{
			get { return (string)this.GetValue("进口药品检验报告单"); } 
			set { this.SetValue("进口药品检验报告单", value); } 
		}

		public string 进口药品检验报告单编号
		{
			get { return (string)this.GetValue("进口药品检验报告单编号"); } 
			set { this.SetValue("进口药品检验报告单编号", value); } 
		}

		public string 进口药品检验报告单发证机关
		{
			get { return (string)this.GetValue("进口药品检验报告单发证机关"); } 
			set { this.SetValue("进口药品检验报告单发证机关", value); } 
		}

		public string 进口药品检验报告单发证日期
		{
			get { return (string)this.GetValue("进口药品检验报告单发证日期"); } 
			set { this.SetValue("进口药品检验报告单发证日期", value); } 
		}

		public string 进口药品检验报告单效期至
		{
			get { return (string)this.GetValue("进口药品检验报告单效期至"); } 
			set { this.SetValue("进口药品检验报告单效期至", value); } 
		}

		public string 进口药品通关单
		{
			get { return (string)this.GetValue("进口药品通关单"); } 
			set { this.SetValue("进口药品通关单", value); } 
		}

		public string 进口药品通关单编号
		{
			get { return (string)this.GetValue("进口药品通关单编号"); } 
			set { this.SetValue("进口药品通关单编号", value); } 
		}

		public string 进口药品通关单发证机关
		{
			get { return (string)this.GetValue("进口药品通关单发证机关"); } 
			set { this.SetValue("进口药品通关单发证机关", value); } 
		}

		public string 进口药品通关单发证日期
		{
			get { return (string)this.GetValue("进口药品通关单发证日期"); } 
			set { this.SetValue("进口药品通关单发证日期", value); } 
		}

		public string 进口药品通关单效期至
		{
			get { return (string)this.GetValue("进口药品通关单效期至"); } 
			set { this.SetValue("进口药品通关单效期至", value); } 
		}

		public string 其他
		{
			get { return (string)this.GetValue("其他"); } 
			set { this.SetValue("其他", value); } 
		}

		public string 其他编号
		{
			get { return (string)this.GetValue("其他编号"); } 
			set { this.SetValue("其他编号", value); } 
		}

		public string 其他发证机关
		{
			get { return (string)this.GetValue("其他发证机关"); } 
			set { this.SetValue("其他发证机关", value); } 
		}

		public string 其他发证日期
		{
			get { return (string)this.GetValue("其他发证日期"); } 
			set { this.SetValue("其他发证日期", value); } 
		}

		public string 其他效期至
		{
			get { return (string)this.GetValue("其他效期至"); } 
			set { this.SetValue("其他效期至", value); } 
		}

		public double 进货价
		{
			get { return (double)this.GetValue("进货价"); } 
			set { this.SetValue("进货价", value); } 
		}

		public double 批发价
		{
			get { return (double)this.GetValue("批发价"); } 
			set { this.SetValue("批发价", value); } 
		}

		public double 零售价
		{
			get { return (double)this.GetValue("零售价"); } 
			set { this.SetValue("零售价", value); } 
		}

		public double 会员价
		{
			get { return (double)this.GetValue("会员价"); } 
			set { this.SetValue("会员价", value); } 
		}

		public double 销价一
		{
			get { return (double)this.GetValue("销价一"); } 
			set { this.SetValue("销价一", value); } 
		}

		public double 销价二
		{
			get { return (double)this.GetValue("销价二"); } 
			set { this.SetValue("销价二", value); } 
		}

		public double 销价三
		{
			get { return (double)this.GetValue("销价三"); } 
			set { this.SetValue("销价三", value); } 
		}

		public double 销价四
		{
			get { return (double)this.GetValue("销价四"); } 
			set { this.SetValue("销价四", value); } 
		}

		public double 销价五
		{
			get { return (double)this.GetValue("销价五"); } 
			set { this.SetValue("销价五", value); } 
		}

		public double 销价六
		{
			get { return (double)this.GetValue("销价六"); } 
			set { this.SetValue("销价六", value); } 
		}

		public double 销价七
		{
			get { return (double)this.GetValue("销价七"); } 
			set { this.SetValue("销价七", value); } 
		}

		public AllFirstProductPrintView()
		{
			this.ViewName = "vw_AllFirstProductPrint";
			this.Fields = new Dictionary<string, EntityField>();
			this.Fields.Add("药品ID", AllFirstProductPrintViewFields.药品ID);
			this.Fields.Add("药品编号", AllFirstProductPrintViewFields.药品编号);
			this.Fields.Add("药品名称", AllFirstProductPrintViewFields.药品名称);
			this.Fields.Add("通用名称", AllFirstProductPrintViewFields.通用名称);
			this.Fields.Add("商品名称", AllFirstProductPrintViewFields.商品名称);
			this.Fields.Add("商品条码", AllFirstProductPrintViewFields.商品条码);
			this.Fields.Add("规格", AllFirstProductPrintViewFields.规格);
			this.Fields.Add("单位", AllFirstProductPrintViewFields.单位);
			this.Fields.Add("包装规格", AllFirstProductPrintViewFields.包装规格);
			this.Fields.Add("剂型", AllFirstProductPrintViewFields.剂型);
			this.Fields.Add("药品类别", AllFirstProductPrintViewFields.药品类别);
			this.Fields.Add("批准文号", AllFirstProductPrintViewFields.批准文号);
			this.Fields.Add("生产厂商", AllFirstProductPrintViewFields.生产厂商);
			this.Fields.Add("效期", AllFirstProductPrintViewFields.效期);
			this.Fields.Add("首次供货商", AllFirstProductPrintViewFields.首次供货商);
			this.Fields.Add("生产地址", AllFirstProductPrintViewFields.生产地址);
			this.Fields.Add("邮政编码", AllFirstProductPrintViewFields.邮政编码);
			this.Fields.Add("电话", AllFirstProductPrintViewFields.电话);
			this.Fields.Add("传真", AllFirstProductPrintViewFields.传真);
			this.Fields.Add("联系人", AllFirstProductPrintViewFields.联系人);
			this.Fields.Add("联系人电话", AllFirstProductPrintViewFields.联系人电话);
			this.Fields.Add("是否是电子监管药品", AllFirstProductPrintViewFields.是否是电子监管药品);
			this.Fields.Add("监管标识条码", AllFirstProductPrintViewFields.监管标识条码);
			this.Fields.Add("适应症", AllFirstProductPrintViewFields.适应症);
			this.Fields.Add("贮藏条件", AllFirstProductPrintViewFields.贮藏条件);
			this.Fields.Add("性状", AllFirstProductPrintViewFields.性状);
			this.Fields.Add("执行标准", AllFirstProductPrintViewFields.执行标准);
			this.Fields.Add("商标", AllFirstProductPrintViewFields.商标);
			this.Fields.Add("性状用途", AllFirstProductPrintViewFields.性状用途);
			this.Fields.Add("药品GMP证书", AllFirstProductPrintViewFields.药品GMP证书);
			this.Fields.Add("GMP证书编号", AllFirstProductPrintViewFields.GMP证书编号);
			this.Fields.Add("GMP证书发证机关", AllFirstProductPrintViewFields.GMP证书发证机关);
			this.Fields.Add("GMP发证日期", AllFirstProductPrintViewFields.GMP发证日期);
			this.Fields.Add("GMP效期至", AllFirstProductPrintViewFields.GMP效期至);
			this.Fields.Add("营业执照", AllFirstProductPrintViewFields.营业执照);
			this.Fields.Add("营业执照编号", AllFirstProductPrintViewFields.营业执照编号);
			this.Fields.Add("营业执照发证机关", AllFirstProductPrintViewFields.营业执照发证机关);
			this.Fields.Add("营业执照发证日期", AllFirstProductPrintViewFields.营业执照发证日期);
			this.Fields.Add("营业执照效期至", AllFirstProductPrintViewFields.营业执照效期至);
			this.Fields.Add("药品注册证", AllFirstProductPrintViewFields.药品注册证);
			this.Fields.Add("药品注册证编号", AllFirstProductPrintViewFields.药品注册证编号);
			this.Fields.Add("药品注册证发证机关", AllFirstProductPrintViewFields.药品注册证发证机关);
			this.Fields.Add("药品注册证发证日期", AllFirstProductPrintViewFields.药品注册证发证日期);
			this.Fields.Add("药品注册证效期至", AllFirstProductPrintViewFields.药品注册证效期至);
			this.Fields.Add("委托生产批件", AllFirstProductPrintViewFields.委托生产批件);
			this.Fields.Add("委托生产批件编号", AllFirstProductPrintViewFields.委托生产批件编号);
			this.Fields.Add("委托生产批件发证机关", AllFirstProductPrintViewFields.委托生产批件发证机关);
			this.Fields.Add("委托生产批件发证日期", AllFirstProductPrintViewFields.委托生产批件发证日期);
			this.Fields.Add("委托生产批件效期至", AllFirstProductPrintViewFields.委托生产批件效期至);
			this.Fields.Add("药品生产许可证", AllFirstProductPrintViewFields.药品生产许可证);
			this.Fields.Add("药品生产许可证编号", AllFirstProductPrintViewFields.药品生产许可证编号);
			this.Fields.Add("药品生产许可证发证机关", AllFirstProductPrintViewFields.药品生产许可证发证机关);
			this.Fields.Add("药品生产许可证发证日期", AllFirstProductPrintViewFields.药品生产许可证发证日期);
			this.Fields.Add("药品生产许可证效期至", AllFirstProductPrintViewFields.药品生产许可证效期至);
			this.Fields.Add("药品标签", AllFirstProductPrintViewFields.药品标签);
			this.Fields.Add("药品标签编号", AllFirstProductPrintViewFields.药品标签编号);
			this.Fields.Add("药品标签发证机关", AllFirstProductPrintViewFields.药品标签发证机关);
			this.Fields.Add("药品标签发证日期", AllFirstProductPrintViewFields.药品标签发证日期);
			this.Fields.Add("药品标签效期至", AllFirstProductPrintViewFields.药品标签效期至);
			this.Fields.Add("说明书", AllFirstProductPrintViewFields.说明书);
			this.Fields.Add("说明书编号", AllFirstProductPrintViewFields.说明书编号);
			this.Fields.Add("说明书发证机关", AllFirstProductPrintViewFields.说明书发证机关);
			this.Fields.Add("说明书发证日期", AllFirstProductPrintViewFields.说明书发证日期);
			this.Fields.Add("说明书效期至", AllFirstProductPrintViewFields.说明书效期至);
			this.Fields.Add("外包装", AllFirstProductPrintViewFields.外包装);
			this.Fields.Add("外包装编号", AllFirstProductPrintViewFields.外包装编号);
			this.Fields.Add("外包装发证机关", AllFirstProductPrintViewFields.外包装发证机关);
			this.Fields.Add("外包装发证日期", AllFirstProductPrintViewFields.外包装发证日期);
			this.Fields.Add("外包装效期至", AllFirstProductPrintViewFields.外包装效期至);
			this.Fields.Add("检验报告", AllFirstProductPrintViewFields.检验报告);
			this.Fields.Add("检验报告编号", AllFirstProductPrintViewFields.检验报告编号);
			this.Fields.Add("检验报告发证机关", AllFirstProductPrintViewFields.检验报告发证机关);
			this.Fields.Add("检验报告发证日期", AllFirstProductPrintViewFields.检验报告发证日期);
			this.Fields.Add("检验报告效期至", AllFirstProductPrintViewFields.检验报告效期至);
			this.Fields.Add("检验标准和检验方法", AllFirstProductPrintViewFields.检验标准和检验方法);
			this.Fields.Add("检验标准和检验方法编号", AllFirstProductPrintViewFields.检验标准和检验方法编号);
			this.Fields.Add("检验标准和检验方法发证机关", AllFirstProductPrintViewFields.检验标准和检验方法发证机关);
			this.Fields.Add("检验标准和检验方法发证日期", AllFirstProductPrintViewFields.检验标准和检验方法发证日期);
			this.Fields.Add("检验标准和检验方法效期至", AllFirstProductPrintViewFields.检验标准和检验方法效期至);
			this.Fields.Add("进口药品注册证", AllFirstProductPrintViewFields.进口药品注册证);
			this.Fields.Add("进口药品注册证编号", AllFirstProductPrintViewFields.进口药品注册证编号);
			this.Fields.Add("进口药品注册证发证机关", AllFirstProductPrintViewFields.进口药品注册证发证机关);
			this.Fields.Add("进口药品注册证发证日期", AllFirstProductPrintViewFields.进口药品注册证发证日期);
			this.Fields.Add("进口药品注册证效期至", AllFirstProductPrintViewFields.进口药品注册证效期至);
			this.Fields.Add("医药产品注册证", AllFirstProductPrintViewFields.医药产品注册证);
			this.Fields.Add("医药产品注册证编号", AllFirstProductPrintViewFields.医药产品注册证编号);
			this.Fields.Add("医药产品注册证发证机关", AllFirstProductPrintViewFields.医药产品注册证发证机关);
			this.Fields.Add("医药产品注册证发证日期", AllFirstProductPrintViewFields.医药产品注册证发证日期);
			this.Fields.Add("医药产品注册证效期至", AllFirstProductPrintViewFields.医药产品注册证效期至);
			this.Fields.Add("进口药品检验报告单", AllFirstProductPrintViewFields.进口药品检验报告单);
			this.Fields.Add("进口药品检验报告单编号", AllFirstProductPrintViewFields.进口药品检验报告单编号);
			this.Fields.Add("进口药品检验报告单发证机关", AllFirstProductPrintViewFields.进口药品检验报告单发证机关);
			this.Fields.Add("进口药品检验报告单发证日期", AllFirstProductPrintViewFields.进口药品检验报告单发证日期);
			this.Fields.Add("进口药品检验报告单效期至", AllFirstProductPrintViewFields.进口药品检验报告单效期至);
			this.Fields.Add("进口药品通关单", AllFirstProductPrintViewFields.进口药品通关单);
			this.Fields.Add("进口药品通关单编号", AllFirstProductPrintViewFields.进口药品通关单编号);
			this.Fields.Add("进口药品通关单发证机关", AllFirstProductPrintViewFields.进口药品通关单发证机关);
			this.Fields.Add("进口药品通关单发证日期", AllFirstProductPrintViewFields.进口药品通关单发证日期);
			this.Fields.Add("进口药品通关单效期至", AllFirstProductPrintViewFields.进口药品通关单效期至);
			this.Fields.Add("其他", AllFirstProductPrintViewFields.其他);
			this.Fields.Add("其他编号", AllFirstProductPrintViewFields.其他编号);
			this.Fields.Add("其他发证机关", AllFirstProductPrintViewFields.其他发证机关);
			this.Fields.Add("其他发证日期", AllFirstProductPrintViewFields.其他发证日期);
			this.Fields.Add("其他效期至", AllFirstProductPrintViewFields.其他效期至);
			this.Fields.Add("进货价", AllFirstProductPrintViewFields.进货价);
			this.Fields.Add("批发价", AllFirstProductPrintViewFields.批发价);
			this.Fields.Add("零售价", AllFirstProductPrintViewFields.零售价);
			this.Fields.Add("会员价", AllFirstProductPrintViewFields.会员价);
			this.Fields.Add("销价一", AllFirstProductPrintViewFields.销价一);
			this.Fields.Add("销价二", AllFirstProductPrintViewFields.销价二);
			this.Fields.Add("销价三", AllFirstProductPrintViewFields.销价三);
			this.Fields.Add("销价四", AllFirstProductPrintViewFields.销价四);
			this.Fields.Add("销价五", AllFirstProductPrintViewFields.销价五);
			this.Fields.Add("销价六", AllFirstProductPrintViewFields.销价六);
			this.Fields.Add("销价七", AllFirstProductPrintViewFields.销价七);
		}
	}

	#region AllFirstProductPrintViewFields

	public class AllFirstProductPrintViewFields
	{
		public static EntityField 药品ID
		{
			get { return new EntityField("vw_AllFirstProductPrint", 0, "药品ID", SqlDbType.Int); }
		}

		public static EntityField 药品编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 1, "药品编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品名称
		{
			get { return new EntityField("vw_AllFirstProductPrint", 2, "药品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 通用名称
		{
			get { return new EntityField("vw_AllFirstProductPrint", 3, "通用名称", SqlDbType.NVarChar); }
		}

		public static EntityField 商品名称
		{
			get { return new EntityField("vw_AllFirstProductPrint", 4, "商品名称", SqlDbType.NVarChar); }
		}

		public static EntityField 商品条码
		{
			get { return new EntityField("vw_AllFirstProductPrint", 5, "商品条码", SqlDbType.NVarChar); }
		}

		public static EntityField 规格
		{
			get { return new EntityField("vw_AllFirstProductPrint", 6, "规格", SqlDbType.NVarChar); }
		}

		public static EntityField 单位
		{
			get { return new EntityField("vw_AllFirstProductPrint", 7, "单位", SqlDbType.NVarChar); }
		}

		public static EntityField 包装规格
		{
			get { return new EntityField("vw_AllFirstProductPrint", 8, "包装规格", SqlDbType.NVarChar); }
		}

		public static EntityField 剂型
		{
			get { return new EntityField("vw_AllFirstProductPrint", 9, "剂型", SqlDbType.NVarChar); }
		}

		public static EntityField 药品类别
		{
			get { return new EntityField("vw_AllFirstProductPrint", 10, "药品类别", SqlDbType.NVarChar); }
		}

		public static EntityField 批准文号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 11, "批准文号", SqlDbType.NVarChar); }
		}

		public static EntityField 生产厂商
		{
			get { return new EntityField("vw_AllFirstProductPrint", 12, "生产厂商", SqlDbType.NVarChar); }
		}

		public static EntityField 效期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 13, "效期", SqlDbType.NVarChar); }
		}

		public static EntityField 首次供货商
		{
			get { return new EntityField("vw_AllFirstProductPrint", 14, "首次供货商", SqlDbType.NVarChar); }
		}

		public static EntityField 生产地址
		{
			get { return new EntityField("vw_AllFirstProductPrint", 15, "生产地址", SqlDbType.NVarChar); }
		}

		public static EntityField 邮政编码
		{
			get { return new EntityField("vw_AllFirstProductPrint", 16, "邮政编码", SqlDbType.NVarChar); }
		}

		public static EntityField 电话
		{
			get { return new EntityField("vw_AllFirstProductPrint", 17, "电话", SqlDbType.NVarChar); }
		}

		public static EntityField 传真
		{
			get { return new EntityField("vw_AllFirstProductPrint", 18, "传真", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人
		{
			get { return new EntityField("vw_AllFirstProductPrint", 19, "联系人", SqlDbType.NVarChar); }
		}

		public static EntityField 联系人电话
		{
			get { return new EntityField("vw_AllFirstProductPrint", 20, "联系人电话", SqlDbType.NVarChar); }
		}

		public static EntityField 是否是电子监管药品
		{
			get { return new EntityField("vw_AllFirstProductPrint", 21, "是否是电子监管药品", SqlDbType.Bit); }
		}

		public static EntityField 监管标识条码
		{
			get { return new EntityField("vw_AllFirstProductPrint", 22, "监管标识条码", SqlDbType.NVarChar); }
		}

		public static EntityField 适应症
		{
			get { return new EntityField("vw_AllFirstProductPrint", 23, "适应症", SqlDbType.NVarChar); }
		}

		public static EntityField 贮藏条件
		{
			get { return new EntityField("vw_AllFirstProductPrint", 24, "贮藏条件", SqlDbType.NVarChar); }
		}

		public static EntityField 性状
		{
			get { return new EntityField("vw_AllFirstProductPrint", 25, "性状", SqlDbType.NVarChar); }
		}

		public static EntityField 执行标准
		{
			get { return new EntityField("vw_AllFirstProductPrint", 26, "执行标准", SqlDbType.NVarChar); }
		}

		public static EntityField 商标
		{
			get { return new EntityField("vw_AllFirstProductPrint", 27, "商标", SqlDbType.NVarChar); }
		}

		public static EntityField 性状用途
		{
			get { return new EntityField("vw_AllFirstProductPrint", 28, "性状用途", SqlDbType.NVarChar); }
		}

		public static EntityField 药品GMP证书
		{
			get { return new EntityField("vw_AllFirstProductPrint", 29, "药品GMP证书", SqlDbType.NVarChar); }
		}

		public static EntityField GMP证书编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 30, "GMP证书编号", SqlDbType.NVarChar); }
		}

		public static EntityField GMP证书发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 31, "GMP证书发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField GMP发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 32, "GMP发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField GMP效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 33, "GMP效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照
		{
			get { return new EntityField("vw_AllFirstProductPrint", 34, "营业执照", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 35, "营业执照编号", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 36, "营业执照发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 37, "营业执照发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 营业执照效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 38, "营业执照效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 药品注册证
		{
			get { return new EntityField("vw_AllFirstProductPrint", 39, "药品注册证", SqlDbType.NVarChar); }
		}

		public static EntityField 药品注册证编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 40, "药品注册证编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品注册证发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 41, "药品注册证发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 药品注册证发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 42, "药品注册证发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 药品注册证效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 43, "药品注册证效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 委托生产批件
		{
			get { return new EntityField("vw_AllFirstProductPrint", 44, "委托生产批件", SqlDbType.NVarChar); }
		}

		public static EntityField 委托生产批件编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 45, "委托生产批件编号", SqlDbType.NVarChar); }
		}

		public static EntityField 委托生产批件发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 46, "委托生产批件发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 委托生产批件发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 47, "委托生产批件发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 委托生产批件效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 48, "委托生产批件效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 药品生产许可证
		{
			get { return new EntityField("vw_AllFirstProductPrint", 49, "药品生产许可证", SqlDbType.NVarChar); }
		}

		public static EntityField 药品生产许可证编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 50, "药品生产许可证编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品生产许可证发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 51, "药品生产许可证发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 药品生产许可证发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 52, "药品生产许可证发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 药品生产许可证效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 53, "药品生产许可证效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 药品标签
		{
			get { return new EntityField("vw_AllFirstProductPrint", 54, "药品标签", SqlDbType.NVarChar); }
		}

		public static EntityField 药品标签编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 55, "药品标签编号", SqlDbType.NVarChar); }
		}

		public static EntityField 药品标签发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 56, "药品标签发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 药品标签发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 57, "药品标签发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 药品标签效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 58, "药品标签效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 说明书
		{
			get { return new EntityField("vw_AllFirstProductPrint", 59, "说明书", SqlDbType.NVarChar); }
		}

		public static EntityField 说明书编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 60, "说明书编号", SqlDbType.NVarChar); }
		}

		public static EntityField 说明书发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 61, "说明书发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 说明书发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 62, "说明书发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 说明书效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 63, "说明书效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 外包装
		{
			get { return new EntityField("vw_AllFirstProductPrint", 64, "外包装", SqlDbType.NVarChar); }
		}

		public static EntityField 外包装编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 65, "外包装编号", SqlDbType.NVarChar); }
		}

		public static EntityField 外包装发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 66, "外包装发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 外包装发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 67, "外包装发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 外包装效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 68, "外包装效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 检验报告
		{
			get { return new EntityField("vw_AllFirstProductPrint", 69, "检验报告", SqlDbType.NVarChar); }
		}

		public static EntityField 检验报告编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 70, "检验报告编号", SqlDbType.NVarChar); }
		}

		public static EntityField 检验报告发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 71, "检验报告发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 检验报告发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 72, "检验报告发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 检验报告效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 73, "检验报告效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 检验标准和检验方法
		{
			get { return new EntityField("vw_AllFirstProductPrint", 74, "检验标准和检验方法", SqlDbType.NVarChar); }
		}

		public static EntityField 检验标准和检验方法编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 75, "检验标准和检验方法编号", SqlDbType.NVarChar); }
		}

		public static EntityField 检验标准和检验方法发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 76, "检验标准和检验方法发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 检验标准和检验方法发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 77, "检验标准和检验方法发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 检验标准和检验方法效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 78, "检验标准和检验方法效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品注册证
		{
			get { return new EntityField("vw_AllFirstProductPrint", 79, "进口药品注册证", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品注册证编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 80, "进口药品注册证编号", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品注册证发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 81, "进口药品注册证发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品注册证发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 82, "进口药品注册证发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品注册证效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 83, "进口药品注册证效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 医药产品注册证
		{
			get { return new EntityField("vw_AllFirstProductPrint", 84, "医药产品注册证", SqlDbType.NVarChar); }
		}

		public static EntityField 医药产品注册证编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 85, "医药产品注册证编号", SqlDbType.NVarChar); }
		}

		public static EntityField 医药产品注册证发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 86, "医药产品注册证发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 医药产品注册证发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 87, "医药产品注册证发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 医药产品注册证效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 88, "医药产品注册证效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品检验报告单
		{
			get { return new EntityField("vw_AllFirstProductPrint", 89, "进口药品检验报告单", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品检验报告单编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 90, "进口药品检验报告单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品检验报告单发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 91, "进口药品检验报告单发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品检验报告单发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 92, "进口药品检验报告单发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品检验报告单效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 93, "进口药品检验报告单效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品通关单
		{
			get { return new EntityField("vw_AllFirstProductPrint", 94, "进口药品通关单", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品通关单编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 95, "进口药品通关单编号", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品通关单发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 96, "进口药品通关单发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品通关单发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 97, "进口药品通关单发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 进口药品通关单效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 98, "进口药品通关单效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 其他
		{
			get { return new EntityField("vw_AllFirstProductPrint", 99, "其他", SqlDbType.NVarChar); }
		}

		public static EntityField 其他编号
		{
			get { return new EntityField("vw_AllFirstProductPrint", 100, "其他编号", SqlDbType.NVarChar); }
		}

		public static EntityField 其他发证机关
		{
			get { return new EntityField("vw_AllFirstProductPrint", 101, "其他发证机关", SqlDbType.NVarChar); }
		}

		public static EntityField 其他发证日期
		{
			get { return new EntityField("vw_AllFirstProductPrint", 102, "其他发证日期", SqlDbType.NVarChar); }
		}

		public static EntityField 其他效期至
		{
			get { return new EntityField("vw_AllFirstProductPrint", 103, "其他效期至", SqlDbType.NVarChar); }
		}

		public static EntityField 进货价
		{
			get { return new EntityField("vw_AllFirstProductPrint", 104, "进货价", SqlDbType.Float); }
		}

		public static EntityField 批发价
		{
			get { return new EntityField("vw_AllFirstProductPrint", 105, "批发价", SqlDbType.Float); }
		}

		public static EntityField 零售价
		{
			get { return new EntityField("vw_AllFirstProductPrint", 106, "零售价", SqlDbType.Float); }
		}

		public static EntityField 会员价
		{
			get { return new EntityField("vw_AllFirstProductPrint", 107, "会员价", SqlDbType.Float); }
		}

		public static EntityField 销价一
		{
			get { return new EntityField("vw_AllFirstProductPrint", 108, "销价一", SqlDbType.Float); }
		}

		public static EntityField 销价二
		{
			get { return new EntityField("vw_AllFirstProductPrint", 109, "销价二", SqlDbType.Float); }
		}

		public static EntityField 销价三
		{
			get { return new EntityField("vw_AllFirstProductPrint", 110, "销价三", SqlDbType.Float); }
		}

		public static EntityField 销价四
		{
			get { return new EntityField("vw_AllFirstProductPrint", 111, "销价四", SqlDbType.Float); }
		}

		public static EntityField 销价五
		{
			get { return new EntityField("vw_AllFirstProductPrint", 112, "销价五", SqlDbType.Float); }
		}

		public static EntityField 销价六
		{
			get { return new EntityField("vw_AllFirstProductPrint", 113, "销价六", SqlDbType.Float); }
		}

		public static EntityField 销价七
		{
			get { return new EntityField("vw_AllFirstProductPrint", 114, "销价七", SqlDbType.Float); }
		}

	}

	#endregion

}
