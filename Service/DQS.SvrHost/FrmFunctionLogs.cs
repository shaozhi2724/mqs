using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DQS.SvrHost
{
    public partial class FrmFunctionLogs : DevExpress.XtraEditors.XtraForm
    {
        public FrmFunctionLogs()
        {
            InitializeComponent();
        }

        private void FrmFunctionLogs_Load(object sender, EventArgs e)
        {
            this.trlLogs.ExpandAll();
            this.gvControl.DataSource = this.GetLogData();
        }

        private void gvData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void gvData_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.RowCount != 0) return;//有记录，返回

            using (StringFormat drawFormat = new StringFormat())
            {
                drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("暂无记录", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
            }
        }

        private DataTable GetLogData()
        {
            DataTable data = new DataTable();
            data.Columns.Add("日志ID", Type.GetType("System.Int32"));
            data.Columns.Add("操作人", Type.GetType("System.String"));
            data.Columns.Add("操作时间", Type.GetType("System.String"));
            data.Columns.Add("操作类型", Type.GetType("System.String"));
            data.Columns.Add("操作的页面", Type.GetType("System.String"));
            data.Columns.Add("操作内容", Type.GetType("System.String"));
            data.Columns.Add("使用的电脑名称", Type.GetType("System.String"));
            data.Columns.Add("日志类型", Type.GetType("System.String"));


            DataRow row = data.NewRow();
            row["日志ID"] = 1;
            row["操作人"] = "张三";
            row["操作时间"] = "2013-7-07 12:23:58";
            row["操作类型"] = "新建";
            row["操作的页面"] = "用户管理";
            row["操作内容"] = "添加了一个'用户'，用户名为'李四'";
            row["使用的电脑名称"] = "John-PC";
            row["日志类型"] = "新建";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 2;
            row["操作人"] = "曹刚川";
            row["操作时间"] = "2013-7-07 13:40:52";
            row["操作类型"] = "编辑";
            row["操作的页面"] = "药品管理";
            row["操作内容"] = "编辑了一个'药品信息'，药品名为'六味地黄丸'改成'浓缩六味地黄丸'";
            row["使用的电脑名称"] = "YANGLQ-PC";
            row["日志类型"] = "编辑";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 3;
            row["操作人"] = "张志峰";
            row["操作时间"] = "2013-7-08 14:44:57";
            row["操作类型"] = "删除";
            row["操作的页面"] = "部门管理";
            row["操作内容"] = "删除了一个'部门'，部门名为'值班部'";
            row["使用的电脑名称"] = "HUDDA-PC";
            row["日志类型"] = "删除";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 4;
            row["操作人"] = "李晓华";
            row["操作时间"] = "2013-7-09 15:43:32";
            row["操作类型"] = "查询";
            row["操作的页面"] = "来往单位管理";
            row["操作内容"] = "查询了一个'来往单位信息'";
            row["使用的电脑名称"] = "ZHANGSAN-PC";
            row["日志类型"] = "查询";
            data.Rows.Add(row);


            row = data.NewRow();
            row["日志ID"] = 5;
            row["操作人"] = "李晓光";
            row["操作时间"] = "2013-7-10 12:23:21";
            row["操作类型"] = "刷新";
            row["操作的页面"] = "药品管理";
            row["操作内容"] = "刷新了一个'药品信息'页面";
            row["使用的电脑名称"] = "LIXIAOGUANG-PC";
            row["日志类型"] = "刷新";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 6;
            row["操作人"] = "高晓松";
            row["操作时间"] = "2013-7-11 12:15:53";
            row["操作类型"] = "导出";
            row["操作的页面"] = "药品管理";
            row["操作内容"] = "导出了一个'药品信息'表";
            row["使用的电脑名称"] = "GAOXIAOSONG-PC";
            row["日志类型"] = "导出";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 7;
            row["操作人"] = "张利民";
            row["操作时间"] = "2013-7-12 15:13:23";
            row["操作类型"] = "打印";
            row["操作的页面"] = "来往单位管理";
            row["操作内容"] = "打印了一个'来往单位信息'表";
            row["使用的电脑名称"] = "ZHAGNLIMIN-PC";
            row["日志类型"] = "打印";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 8;
            row["操作人"] = "赵晓思";
            row["操作时间"] = "2013-7-13 17:36:43";
            row["操作类型"] = "设置";
            row["操作的页面"] = "来往单位管理";
            row["操作内容"] = "设置了一个'来往单位信息'，增加列为'来往单位编号'";
            row["使用的电脑名称"] = "ZHAOXIAOSI-PC";
            row["日志类型"] = "设置";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 8;
            row["操作人"] = "李梅";
            row["操作时间"] = "2013-7-14 12:26:23";
            row["操作类型"] = "高级查询";
            row["操作的页面"] = "药品管理";
            row["操作内容"] = "查询了一个'药品信息'表";
            row["使用的电脑名称"] = "LIMEI-PC";
            row["日志类型"] = "高级查询";
            data.Rows.Add(row);


            row = data.NewRow();
            row["日志ID"] = 10;
            row["操作人"] = "李雪春";
            row["操作时间"] = "2013-7-15 15:24:43";
            row["操作类型"] = "制单";
            row["操作的页面"] = "采购管理";
            row["操作内容"] = "添加了一个'采购单'，单号为'CG201308020001'";
            row["使用的电脑名称"] = "LIXUECHUN-PC";
            row["日志类型"] = "采购";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 11;
            row["操作人"] = "李小妹";
            row["操作时间"] = "2013-7-15 17:47:56";
            row["操作类型"] = "制单";
            row["操作的页面"] = "销售管理";
            row["操作内容"] = "添加了一个'销售单'，单号为'XS201308020001'";
            row["使用的电脑名称"] = "LIXIAOMEI-PC";
            row["日志类型"] = "销售";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 12;
            row["操作人"] = "张岩涛";
            row["操作时间"] = "2013-7-15 17:54:55";
            row["操作类型"] = "制单";
            row["操作的页面"] = "采购退货管理";
            row["操作内容"] = "添加了一个'采购退货单'，单号为'CGTH201308020001'";
            row["使用的电脑名称"] = "ZHANGYANTAO-PC";
            row["日志类型"] = "采购退货";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 13;
            row["操作人"] = "李然";
            row["操作时间"] = "2013-7-16 9:14:15";
            row["操作类型"] = "制单";
            row["操作的页面"] = "销售退货管理";
            row["操作内容"] = "添加了一个'销售退货单'，单号为'XSTH201308020001'";
            row["使用的电脑名称"] = "LIRAN-PC";
            row["日志类型"] = "销售退货";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 14;
            row["操作人"] = "李锋锐";
            row["操作时间"] = "2013-7-16 10:11:25";
            row["操作类型"] = "审批";
            row["操作的页面"] = "采购管理";
            row["操作内容"] = "申请审批了一个'采购单'，单号为'CG201308020001'";
            row["使用的电脑名称"] = "LIFEGNRUI-PC";
            row["日志类型"] = "采购单";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 15;
            row["操作人"] = "李刚";
            row["操作时间"] = "2013-7-16 11:24:35";
            row["操作类型"] = "审批";
            row["操作的页面"] = "销售管理";
            row["操作内容"] = "申请审批了一个'销售单'，单号为'XS201308020001'";
            row["使用的电脑名称"] = "LIGANG-PC";
            row["日志类型"] = "销售单";
            data.Rows.Add(row);


            row = data.NewRow();
            row["日志ID"] = 16;
            row["操作人"] = "王国防";
            row["操作时间"] = "2013-7-16 12:23:45";
            row["操作类型"] = "审批";
            row["操作的页面"] = "采购退货管理";
            row["操作内容"] = "申请审批了一个'采购退货单'，单号为'CGTH201308020001'";
            row["使用的电脑名称"] = "WANGGUOFANG-PC";
            row["日志类型"] = "采购退货单";
            data.Rows.Add(row);


            row = data.NewRow();
            row["日志ID"] = 17;
            row["操作人"] = "卢新";
            row["操作时间"] = "2013-7-16 13:53:25";
            row["操作类型"] = "审批";
            row["操作的页面"] = "销售退货管理";
            row["操作内容"] = "申请审批了一个'销售退货单'，单号为'CGTH201308020001'";
            row["使用的电脑名称"] = "LUXIN-PC";
            row["日志类型"] = "销售退货单";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 18;
            row["操作人"] = "李卫华";
            row["操作时间"] = "2013-7-16 14:33:55";
            row["操作类型"] = "审批";
            row["操作的页面"] = "养护计划管理";
            row["操作内容"] = "申请审批了一个'养护计划单'，单号为'YHJJ201308020001'";
            row["使用的电脑名称"] = "LIWEIHUA-PC";
            row["日志类型"] = "养护计划单";
            data.Rows.Add(row);


            row = data.NewRow();
            row["日志ID"] = 19;
            row["操作人"] = "张银龙";
            row["操作时间"] = "2013-7-16 15:36:57";
            row["操作类型"] = "审批";
            row["操作的页面"] = "异常上报管理";
            row["操作内容"] = "申请审批了一个'异常上报单'，单号为'YCSB201308020001'";
            row["使用的电脑名称"] = "ZHANGYINLONG-PC";
            row["日志类型"] = "异常上报单";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 20;
            row["操作人"] = "张晓明";
            row["操作时间"] = "2013-7-16 15:36:57";
            row["操作类型"] = "审批";
            row["操作的页面"] = "盘点管理";
            row["操作内容"] = "申请审批了一个'盘点单'，单号为'PD201308020001'";
            row["使用的电脑名称"] = "ZHANGXIAOMING-PC";
            row["日志类型"] = "盘点单";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 21;
            row["操作人"] = "王进喜";
            row["操作时间"] = "2013-7-16 16:56:45";
            row["操作类型"] = "审批";
            row["操作的页面"] = "药品锁定管理";
            row["操作内容"] = "申请审批了一个'药品锁定单'，单号为'SDD201308020001'";
            row["使用的电脑名称"] = "WAGNJINXI-PC";
            row["日志类型"] = "药品锁定单";
            data.Rows.Add(row);

            row = data.NewRow();
            row["日志ID"] = 22;
            row["操作人"] = "系统";
            row["操作时间"] = "2013-7-17 16:56:45";
            row["操作类型"] = "备份";
            row["操作的页面"] = "数据库备份";
            row["操作内容"] = "系统在时间为：2013-7-17 16:56:45时，备份数据库为：DQS20130717165645,位置为：D:/备份";
            row["使用的电脑名称"] = "Server-PC";
            row["日志类型"] = "备份";
            data.Rows.Add(row);


            row = data.NewRow();
            row["日志ID"] = 23;
            row["操作人"] = "系统";
            row["操作时间"] = "2013-7-18 13:46:45";
            row["操作类型"] = "注册";
            row["操作的页面"] = "客户端注册记录";
            row["操作内容"] = "系统在时间为：2013-7-18 13:46:45时，客户端注册为：zhangsan";
            row["使用的电脑名称"] = "Server-PC";
            row["日志类型"] = "客户端注册";
            data.Rows.Add(row);
            return data;
        }
    }
}