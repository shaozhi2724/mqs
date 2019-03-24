using DevExpress.XtraEditors;
using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmEmployeeCheckBody : XtraForm
    {
        private int m_Id;

        private string[] m_ImageType = new string[] { "BMP", "JPG", "GIF", "PNG", "PCX", "DCX", "EMF", "JIF", "JPE", "JFIF", "JPEG", "RLE", "DIB", "PCD", "DXF", "ICO", "WMF", "TIFF", "TGA" };

        public FrmEmployeeCheckBody()
        {
            InitializeComponent();
        }
        public FrmEmployeeCheckBody(int _m_id)
        {
            InitializeComponent();
            m_Id = _m_id;
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmSingleEmployeeCheckBody frm = new FrmSingleEmployeeCheckBody(m_Id,0))
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    BandGrid();
                }
            }
        }

        private void barBtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object id = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("ID");
            if (m_Id > 0 && id != null && id != DBNull.Value)
            {
                using (FrmSingleEmployeeCheckBody frm = new FrmSingleEmployeeCheckBody(m_Id, int.Parse(id.ToString())))
                {
                    DialogResult dr = frm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        BandGrid();
                    }
                }
            }
        }

        private void BandGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT  ID ,
        EmployeeID ,
        YearKey 年度,
        Code 编号,
        CheckProject 检查项目,
        CheckDate 检查日期,
        CheckGov 检查机构,
        Measure 采取措施,
        CheckResult 检查结果,
        Remark 备注 FROM dbo.BFI_EmployeeCheckBody WHERE EmployeeID = "+m_Id;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    gridAcceptDetailControl.DataSource = ds.Tables["Table"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void barBtnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            object id = this.gridAcceptDetailControl.GridViewData.GetFocusedRowCellValue("ID");
            if (id != null && id != DBNull.Value)
            {
                DialogResult dr = XtraMessageBox.Show("是否删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DeleCheckBody((int)id);
                }
            }
        }

        private void DeleCheckBody(int id)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"DELETE BUS_CuringTools WHERE ID = {0}";
                sql = string.Format(sql, id);
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void barBtnUpAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnDownAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barDeleteAttachment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void FrmEmployeeCheckBody_Load(object sender, EventArgs e)
        {
            BandGrid();
        }
    }
}
