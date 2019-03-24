using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using DQS.Common;
using System.Data.SqlClient;

namespace DQS.AppViews.OtherOperation.OtherManager
{
    public partial class FrmSingleEmployeeTrainPlan : DevExpress.XtraEditors.XtraForm
    {
        private int? m_id;

        public FrmSingleEmployeeTrainPlan()
        {
            InitializeComponent();
            LoadType("BUS_EmployeeTrainPlan", "TrainContent", txtTrainContent);
            LoadType("BUS_EmployeeTrainPlan", "Reservation2", txtAim);
        }

        private void LoadType(string tableName, string tableColumn, ComboBoxEdit cbo)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "SELECT " + tableColumn + " FROM " + tableName + " GROUP BY " + tableColumn;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        cbo.Properties.Items.Add(ds.Tables["Table"].Rows[i][tableColumn].ToString());
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

        private void FrmSingleEmployeeTrainPlan_Load(object sender, EventArgs e)
        {
            this.cbxTrainType.InitSource();

            if (this.Tag != null)
            {
                this.m_id = Convert.ToInt32(this.Tag);

                BUSEmployeeTrainPlanEntity entity = new BUSEmployeeTrainPlanEntity { TrainID = m_id.Value };
                entity.Fetch();

                this.ftPanel.SetEntity(entity);

                this.txtTrainCode.Enabled = false;

                this.CustomGetEntity(entity);
            }
            else
            {
                this.txtTrainCode.Text = "YGPX" + DateTime.Now.ToString("yyyyMMddHHmmss");
                this.txtTrainCode.Select(this.txtTrainCode.Text.Length, 0);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            BUSEmployeeTrainPlanEntity entity = this.ftPanel.GetEntity() as BUSEmployeeTrainPlanEntity;
            this.CustomSetEntity(entity);

            if (this.m_id != null)
            {
                entity.LastModifyDate = DateTime.Now;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Update();
                if (entity.IsTrained)
                {
                    using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                    {
                        string sql = "EXEC sp_InsertEmployeeTrainPlanDocument {0}";
                        sql = string.Format(sql, Convert.ToInt32(this.Tag));
                        SqlCommand com = new SqlCommand(sql, conn);
                        try
                        {
                            conn.Open();
                            int i = com.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("保存成功。");
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
            }
            else
            {
                if (entity.IsNew())
                {
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("培训编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 非文本框取值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomGetEntity(BUSEmployeeTrainPlanEntity entity)
        {
            if (!entity.IsNullField("TrainType"))
            {
                this.cbxTrainType.Text = entity.TrainType;
            }

            if (!entity.IsNullField("TrainContent"))
            {
                this.txtTrainContent.Text = entity.TrainContent;
            }

            if (!entity.IsNullField("Reservation2"))
            {
                this.txtAim.Text = entity.Reservation2;
            }

            if (!entity.IsNullField("Reservation3"))
            {
                this.dteCheckDate.DateTime = Convert.ToDateTime(entity.Reservation3);
            }

            if (!entity.IsNullField("StartTime"))
            {
                this.dteStartTime.DateTime = entity.StartTime;
            }

            if (!entity.IsNullField("EndTime"))
            {
                this.dteEndTime.DateTime = entity.EndTime;
            }

            if (!entity.IsNullField("PropoDate"))
            {
                this.dtePropoDate.DateTime = entity.PropoDate;
            }

            if (!entity.IsNullField("IsTrained"))
            {
                this.rgpIsTrained.SelectedIndex = entity.IsTrained ? 1 : 0;
            }
        }

        /// <summary>
        /// 非文本框赋值
        /// </summary>
        /// <param name="entity">实体</param>
        protected virtual void CustomSetEntity(BUSEmployeeTrainPlanEntity entity)
        {
            if (this.cbxTrainType.Text.Trim().Length >0)
            {
                entity.TrainType = this.cbxTrainType.Text.Trim();
            }

            if (this.cbxTrainType.Text.Trim().Length >0)
            {
                entity.TrainContent = this.txtTrainContent.Text.Trim();
            }

            if (this.txtAim.Text.Trim().Length > 0)
            {
                entity.Reservation2 = this.txtAim.Text.Trim();
            }

            if (this.dteCheckDate.Text.Trim().Length > 0)
            {
                entity.Reservation3 = this.dteCheckDate.DateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }

            if (this.dteStartTime.Text.Trim().Length > 0)
            {
                entity.StartTime = this.dteStartTime.DateTime;
            }

            if (this.dteEndTime.Text.Trim().Length > 0)
            {
                entity.EndTime = this.dteEndTime.DateTime;
            }

            if (this.dtePropoDate.Text.Trim().Length > 0)
            {
                entity.PropoDate = this.dtePropoDate.DateTime;
            }

            if (this.rgpIsTrained.SelectedIndex >= 0)
            {
                entity.IsTrained = Convert.ToBoolean(this.rgpIsTrained.EditValue);
            }
        }

    }
}