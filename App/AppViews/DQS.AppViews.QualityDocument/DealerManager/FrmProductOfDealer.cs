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

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmProductOfDealer : XtraForm
    {
        public FrmProductOfDealer()
        {
            InitializeComponent();
        }

        public string frmType = "";
        public int SearchID = 0;
        public string SelectSql = "";
        public string DelSql = "";
        public string InSql = "";
        public string DealerName = "";



        //记录选择的ID
        public List<int> BillList = new List<int>();

        private void FrmProductOfDealer_Load(object sender, EventArgs e)
        {
            gridLoad();
            getList();
            ReadBillList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (frmType == "Dealer")
            {
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    // 保存的时候判断是否有未审批的变更单号
                    string selsql = "SELECT COUNT(0) havecount FROM dbo.BUS_DealerVSProductChange WHERE AppStatus = '' AND DealerID = " + SearchID;

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(selsql, conn);
                        int havecount = int.Parse(cmd.ExecuteScalar().ToString());
                        if (havecount > 0)
                        {
                            // 如果有,提示,退出
                            XtraMessageBox.Show("该供应商有未完成审批的产品关联,请处理完成后,重新操作.", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            FrmAlter frmalter = new FrmAlter();
                            if (DialogResult.Yes == frmalter.ShowDialog())
                            {
                                // 如果没有,保存到变更表
                                // 先保存旧数据,再保存新数据
                                string code = "GN" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                string insertsql = @"INSERT dbo.BUS_DealerVSProductChange(ChangeCode ,DealerID ,DealerName ,ChangeReason ,CreateDate ,CreateUserName ,AppStatus)
VALUES( N'" + code + "' ," + SearchID + " ,N'" + DealerName + "' ,N'" + frmalter.Reason + "' ,GETDATE() ,N'" + GlobalItem.g_CurrentUser.UserName + "' ,'')";
                                cmd = new SqlCommand(insertsql, conn);
                                int savecount = cmd.ExecuteNonQuery();
                                if (savecount == 0)
                                {
                                    XtraMessageBox.Show("保存失败,请重试。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    string selectchangeid = "SELECT ID FROM dbo.BUS_DealerVSProductChange WHERE ChangeCode = '" + code + "'";
                                    cmd = new SqlCommand(selectchangeid, conn);
                                    int changeid = int.Parse(cmd.ExecuteScalar().ToString());
                                    //保存旧数据
                                    string insertoldsql = @"INSERT dbo.BUS_DealerVSProductChangeDetail( ChangeID, DataType, ProductID )
SELECT " + changeid + ",'OLD',ProductID FROM dbo.BUS_DealerVSProduct WHERE DealerID = " + SearchID;
                                    cmd = new SqlCommand(insertoldsql, conn);
                                    cmd.ExecuteNonQuery();
                                    string insertnewsql = "INSERT dbo.BUS_DealerVSProductChangeDetail( ChangeID, DataType, ProductID )VALUES( {0},'NEW',{1} )";
                                    foreach (int ProductID in BillList)
                                    {
                                        cmd = new SqlCommand(string.Format(insertnewsql, changeid, ProductID), conn);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                            XtraMessageBox.Show("保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                } 
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    string del = @"EXEC " + DelSql + " {0}";
                    string insertBill = @"EXEC " + InSql + " {0},{1},'{2}'";

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(String.Format(del, SearchID), conn);
                        cmd.ExecuteNonQuery();
                        foreach (int ProductID in BillList)
                        {
                            SqlCommand command = new SqlCommand(String.Format(insertBill, SearchID, ProductID, GlobalItem.g_CurrentUser.UserName), conn);
                            command.ExecuteNonQuery();
                        }
                        XtraMessageBox.Show("保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                } 
            }
            this.DialogResult = DialogResult.Yes;
        }

        private void gridLoad()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT ProductID,ProductCode AS [编号],ProductName AS [名称],CommonName AS [通用名称],ProductSpec AS [规格],
PackageSpec AS [包装规格],ProducerName AS [生产厂商],AuthorizedNo AS [批准文号]
FROM dbo.BFI_Product where ProductCode like '%{0}%' or productname like '%{0}%' or productspell like '%{0}%' or producername like '%{0}%'";

                SqlDataAdapter sdad = new SqlDataAdapter(string.Format(sqlBill,txtCode.Text.Trim()), conn);
                DataSet ds = new DataSet();
                try
                {
                    sdad.Fill(ds, "Table");
                    ds.Tables["Table"].Columns.Add("选择", System.Type.GetType("System.Boolean"));
                    gridControl.DataSource = ds.Tables["Table"];
                    //gridView.OptionsView.ColumnAutoWidth = false;
                    //gridView.OptionsView.ColumnAutoWidth = false;
                    gridView.BestFitColumns();
                    gridView.OptionsView.ShowGroupPanel = false;

                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        string ColumnName = gridView.Columns[i].ToString();
                        if (ColumnName.Contains("ID"))
                        {
                            gridView.Columns[i].Visible = false;
                        }
                        gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    }
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        gridView.SetRowCellValue(i, "选择", "False");
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

        /// <summary>
        /// 单据信息点击选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedColumn.ToString() == "选择")
            {
                string value = gridView.GetRowCellValue(gridView.FocusedRowHandle, "选择").ToString();
                if (value == "True")
                {
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "选择", "False");
                    BillList.Remove(Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["ProductID"]));
                }
                else
                {
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "选择", "True");
                    BillList.Add(Convert.ToInt32(gridView.GetDataRow(gridView.FocusedRowHandle)["ProductID"]));
                }
            }
        }

        private void getList()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = SelectSql + SearchID;

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    sdad.Fill(ds, "Table");

                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        BillList.Add(Convert.ToInt32(ds.Tables["Table"].Rows[i]["ProductID"]));
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

        /// <summary>
        /// 读取单据列表是否选择
        /// </summary>
        private void ReadBillList()
        {
            for (int i = 0; i < gridView.RowCount; i++)
            {
                int ProductID = Convert.ToInt32(gridView.GetRowCellValue(i, "ProductID"));
                if (BillList.Contains(ProductID))
                {
                    gridView.SetRowCellValue(i, "选择", "True");
                }
                else
                {
                    gridView.SetRowCellValue(i, "选择", "False");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridLoad();
            ReadBillList();
        }
    }
}
