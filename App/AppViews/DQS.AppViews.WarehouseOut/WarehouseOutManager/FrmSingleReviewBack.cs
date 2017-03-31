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

namespace DQS.AppViews.WarehouseOut.WarehouseOutManager
{
    public partial class FrmSingleReviewBack : XtraForm
    {
        int _id;
        bool _isOver;
        public FrmSingleReviewBack()
        {
            InitializeComponent();
        }
        public FrmSingleReviewBack(int id,bool isOver)
        {
            InitializeComponent();
            _id = id;
            _isOver = isOver;
        }

        private void FrmSingleReviewBack_Load(object sender, EventArgs e)
        {
            BandGrid();
            btnSave.Enabled = _isOver;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView.RowCount; i++)
            {
                var sturckID = gridView.GetDataRow(i)["UpStructureID"].ToString();
                if (sturckID == "")
                {
                    MessageBox.Show(string.Format("第{0}行还未完成，直接取消不会影响已经保存的结果。",i+1), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
UPDATE dbo.BUS_ReviewBack SET AppStatus = '已处理' WHERE BackID = {0}
";
                sql = string.Format(sql, _id);
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
            this.DialogResult = DialogResult.OK;
        }

        private void BandGrid()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = @"
SELECT * FROM vw_AllReviewBackDetail WHERE 返单ID = {0}
";
                sql = string.Format(sql, _id);
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Table");

                    gridControl.DataSource = ds.Tables["Table"];
                    gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gridView.Columns[i].Visible = false;
                        }
                        //gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    }
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

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            var ReviewBackDetailID = gridView.GetDataRow(gridView.FocusedRowHandle)["明细ID"].ToString();
            var UpStructureID = gridView.GetDataRow(gridView.FocusedRowHandle)["UpStructureID"].ToString();
            if (ReviewBackDetailID != null && ReviewBackDetailID != "")
            {
                if (UpStructureID.ToString() != "")
                {
                    return;
                }
                using (FrmModifyReviewBackDetail mrbd = new FrmModifyReviewBackDetail(int.Parse(ReviewBackDetailID)))
                {
                    if (mrbd.ShowDialog() == DialogResult.OK)
                    {
                        BandGrid();
                    }
                }
            }
        }
    }
}
