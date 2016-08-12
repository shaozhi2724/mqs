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

namespace DQS.AppViews.StoreAndCuring.StockManager
{
    public partial class FrmSingleStoreDetail : XtraForm
    {
        public FrmSingleStoreDetail()
        {
            InitializeComponent();
        }

        private void FrmSingleStoreDetail_Load(object sender, EventArgs e)
        {

        }

        private void txtProductCode_PopupClosing(object sender, EventArgs e)
        {
            if (this.txtProductCode.EditData != null)
            {
                this.ftPanel.Tag = (this.txtProductCode.EditData as DataRow)["InStoreID"];
                this.txtProductName.Text = (this.txtProductCode.EditData as DataRow)["产品名称"].ToString();
                this.txtProductSpec.Text = (this.txtProductCode.EditData as DataRow)["规格型号"].ToString();
                this.txtProductUnit.Text = (this.txtProductCode.EditData as DataRow)["单位"].ToString();
                this.txtPackageSpec.Text = (this.txtProductCode.EditData as DataRow)["包装规格型号"].ToString();
                this.txtPhysicType.Text = (this.txtProductCode.EditData as DataRow)["剂型"].ToString();
                this.txtAuthorizedNo.Text = (this.txtProductCode.EditData as DataRow)["注册证号"].ToString();
                this.txtProductStyle.Text = (this.txtProductCode.EditData as DataRow)["产品类别"].ToString();
                this.txtProducerName.Text = (this.txtProductCode.EditData as DataRow)["生产厂商"].ToString();
                this.txtBatchNo.Text = (this.txtProductCode.EditData as DataRow)["批号"].ToString();
                this.dteProduceDate.Text = (this.txtProductCode.EditData as DataRow)["生产日期"].ToString();
                this.dteValidateDate.Text = (this.txtProductCode.EditData as DataRow)["有效期至"].ToString();
                this.speAmount.Text = (this.txtProductCode.EditData as DataRow)["库存数量"].ToString();
                this.cbxDepartment.Text = (this.txtProductCode.EditData as DataRow)["部门"].ToString();

                this.txtBatchNo.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string Updatesql = @"
UPDATE dbo.BUS_Bill SET BillStatus=9,BillStatusName='已删除',LastModifyDate=GETDATE(),LastModifyUserID='{1}',Reservation5='已删除。操作员：'+(SELECT UserName FROM dbo.ATC_User WHERE UserID = '{1}')+'于'+CONVERT(varchar(100), GETDATE(), 20)+'删除，删除原因为：'+'{2}' WHERE BillID='{0}'";
            string DelNewsql = "EXEC sp_NewStoreDetailDeleteBill ";
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open();
                try
                {
                    SqlCommand Bcommand = new SqlCommand(Updatesql, conn);
                    Bcommand.ExecuteNonQuery();
                    SqlCommand comm = new SqlCommand(DelNewsql, conn);
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            this.DialogResult = DialogResult.Yes;
        }
    }
}
