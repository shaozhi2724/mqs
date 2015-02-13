using DevExpress.XtraEditors;
using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.OtherOperation.UploadNew
{
    public partial class FrmUploadNew : XtraForm
    {
        public FrmUploadNew()
        {
            InitializeComponent();
        }

        private void FrmUploadNew_Load(object sender, EventArgs e)
        {
            this.deStart.Text = "";
            this.deEnd.Text = "";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.BestFitColumns();
            string sql = @"
SELECT ProductCode AS [企业药品编码],AuthorizedNo AS [批准文号/注册证号],
ProductName AS [药品名称],TradeName AS [商品名],ProducerName AS [生产厂商],
ProductSpec AS [药品规格],PackageSpec AS [包装规格],ProductUnit AS [企业计量单位],
PhysicType AS [剂型] 
FROM dbo.BFI_Product";
            this.gridControl.DataSource = GetDataBySQL(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dateStart = this.deStart.Text + " 00:00:00";
            string dateEnd = this.deEnd.Text + " 23:59:59";
            if (this.deStart.Text == "" || this.deEnd.Text == "")
            {
                XtraMessageBox.Show("请选择日期。","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            string sql = @"
SELECT ProductCode AS [企业药品编码],AuthorizedNo AS [批准文号/注册证号],
ProductName AS [药品名称],TradeName AS [商品名],ProducerName AS [生产厂商],
ProductSpec AS [药品规格],PackageSpec AS [包装规格],ProductUnit AS [企业计量单位],
PhysicType AS [剂型] 
FROM dbo.BFI_Product WHERE (ProductName LIKE '%" + this.txtName.Text + "%' OR ProductSpell LIKE '%" + this.txtName.Text + "%') AND (CreateDate BETWEEN '" + dateStart + "' AND '" + dateEnd + "')";

            this.gridControl.DataSource = GetDataBySQL(sql);
        }

        private void btnDownNew_Click(object sender, EventArgs e)
        {
            var dialogResult = saveFileDialog.ShowDialog(this);
        }

        /// <summary>
        /// 执行sql查询语句，并将结果以DataTable的形式返回
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <returns>sql查询语句结果</returns>
        public static DataTable GetDataBySQL(string sql)
        {
            SqlConnection cn = new SqlConnection(GlobalItem.g_DbConnectStrings);
            if (cn.State != ConnectionState.Open)
                cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter sdap = new SqlDataAdapter();
            sdap.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sdap.Fill(dt);
            cn.Close();
            return dt;
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            FrmUploadNew_Load(null, null);
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            //设置列表头   
            sb.Append("企业药品编码	批准文号/注册证号	药品名称	商品名	生产厂商	药品规格	包装规格	企业计量单位	剂型");
            
            sb.Append(System.Environment.NewLine);


            int rowCount = this.gridView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                DataRow dr = dt.NewRow();
                dr = this.gridView.GetDataRow(i);//遍历每行
                for (int j = 0; j < gridView.Columns.Count; j++)
                {
                    sb.Append(dr[j].ToString() + "\t");
                }
                sb.Append(System.Environment.NewLine);
                //dt.Rows.Add(dr);
            }
            //dt.TableName = "新品资料上传格式";
            //dt.WriteXml("dataset.txt");   


            byte[] s = System.Text.Encoding.Default.GetBytes(sb.ToString());
            FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
            fs.Write(s, 0, s.Length);
            fs.Close();
            XtraMessageBox.Show("保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
