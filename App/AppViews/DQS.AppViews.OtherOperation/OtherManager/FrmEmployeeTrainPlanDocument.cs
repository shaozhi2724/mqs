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

namespace DQS.AppViews.OtherOperation.OtherManager
{
    public partial class FrmEmployeeTrainPlanDocument : XtraForm
    {
        private int m_Id;

        private string[] m_ImageType = new string[] { "BMP", "JPG", "GIF", "PNG", "PCX", "DCX", "EMF", "JIF", "JPE", "JFIF", "JPEG", "RLE", "DIB", "PCD", "DXF", "ICO", "WMF", "TIFF", "TGA" };

        public FrmEmployeeTrainPlanDocument()
        {
            InitializeComponent();
        }
        public FrmEmployeeTrainPlanDocument(int _m_id)
        {
            InitializeComponent();
            m_Id = _m_id;
        }

        private void FrmEmployeeTrainPlanDocument_Load(object sender, EventArgs e)
        {
            BandGrid();
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmSingleEmployeeTrainPlanDocument frm = new FrmSingleEmployeeTrainPlanDocument(m_Id, 0))
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
                using (FrmSingleEmployeeTrainPlanDocument frm = new FrmSingleEmployeeTrainPlanDocument(m_Id, int.Parse(id.ToString())))
                {
                    DialogResult dr = frm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        BandGrid();
                    }
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
                BandGrid();
            }
        }

        private void DeleCheckBody(int id)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"DELETE BUS_EmployeeTrainPlanDocument WHERE ID = {0}";
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

        private void BandGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"SELECT etpd.ID,e.EmployeeName 员工名称,d.DepartmentName 部门,CheckResult 考核结果,CheckSolution 采取措施,Remark 备注 FROM BUS_EmployeeTrainPlanDocument etpd
INNER JOIN dbo.BFI_Employee e ON etpd.EmployeeID = e.EmployeeID
INNER JOIN dbo.BFI_Department d ON e.DepartmentID = d.DepartmentID WHERE etpd.TrainID = " + m_Id;
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
    }
}
