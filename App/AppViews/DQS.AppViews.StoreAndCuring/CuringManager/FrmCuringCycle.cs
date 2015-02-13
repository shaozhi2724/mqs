using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.StoreAndCuring.CuringManager
{
    public partial class FrmCuringCycle : StandardForm
    {
        public FrmCuringCycle()
        {
            InitializeComponent();
        }

        private void FrmCuringCycle_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomModify()
        {
            object cycleCode = this.gvData.GetFocusedRowCellValue("周期编码");
            object productID = this.gvData.GetFocusedRowCellValue("药品ID");
            object productCode = this.gvData.GetFocusedRowCellValue("药品编号");
            object productName = this.gvData.GetFocusedRowCellValue("药品名称");
            object productSpec = this.gvData.GetFocusedRowCellValue("规格");
            object productUnit = this.gvData.GetFocusedRowCellValue("单位");
            object packageSpec = this.gvData.GetFocusedRowCellValue("包装规格");
            object physicType = this.gvData.GetFocusedRowCellValue("剂型");
            object productStyle = this.gvData.GetFocusedRowCellValue("药品类别");
            object authorizedNo = this.gvData.GetFocusedRowCellValue("批准文号");
            object producerName = this.gvData.GetFocusedRowCellValue("生产厂商");

            using (FrmSingleCuringCycle frmSingleCuringCycle = new FrmSingleCuringCycle(cycleCode, productID))
            {
                if (productCode != null && productCode != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductCode.Text = productCode.ToString();
                }

                if (productName != null && productName != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductName.Text = productName.ToString();
                }

                if (productSpec != null && productSpec != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductSpec.Text = productSpec.ToString();
                }

                if (productUnit != null && productUnit != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductUnit.Text = productUnit.ToString();
                }

                if (packageSpec != null && packageSpec != DBNull.Value)
                {
                    frmSingleCuringCycle.txtPackageSpec.Text = packageSpec.ToString();
                }

                if (physicType != null && physicType != DBNull.Value)
                {
                    frmSingleCuringCycle.txtPhysicType.Text = physicType.ToString();
                }

                if (productStyle != null && productStyle != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductStyle.Text = productStyle.ToString();
                }

                if (authorizedNo != null && authorizedNo != DBNull.Value)
                {
                    frmSingleCuringCycle.txtAuthorizedNo.Text = authorizedNo.ToString();
                }

                if (producerName != null && producerName != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProducerName.Text = producerName.ToString();
                }

                DialogResult result = frmSingleCuringCycle.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.pageNavigator.ShowData();
                }
            }
            
        }
        protected override void CustomModify(bool isView)
        {
            object cycleCode = this.gvData.GetFocusedRowCellValue("周期编码");
            object productID = this.gvData.GetFocusedRowCellValue("药品ID");
            object productCode = this.gvData.GetFocusedRowCellValue("药品编号");
            object productName = this.gvData.GetFocusedRowCellValue("药品名称");
            object productSpec = this.gvData.GetFocusedRowCellValue("规格");
            object productUnit = this.gvData.GetFocusedRowCellValue("单位");
            object packageSpec = this.gvData.GetFocusedRowCellValue("包装规格");
            object physicType = this.gvData.GetFocusedRowCellValue("剂型");
            object productStyle = this.gvData.GetFocusedRowCellValue("药品类别");
            object authorizedNo = this.gvData.GetFocusedRowCellValue("批准文号");
            object producerName = this.gvData.GetFocusedRowCellValue("生产厂商");

            using (FrmSingleCuringCycle frmSingleCuringCycle = new FrmSingleCuringCycle(cycleCode, productID))
            {
                if (productCode != null && productCode != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductCode.Text = productCode.ToString();
                }

                if (productName != null && productName != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductName.Text = productName.ToString();
                }

                if (productSpec != null && productSpec != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductSpec.Text = productSpec.ToString();
                }

                if (productUnit != null && productUnit != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductUnit.Text = productUnit.ToString();
                }

                if (packageSpec != null && packageSpec != DBNull.Value)
                {
                    frmSingleCuringCycle.txtPackageSpec.Text = packageSpec.ToString();
                }

                if (physicType != null && physicType != DBNull.Value)
                {
                    frmSingleCuringCycle.txtPhysicType.Text = physicType.ToString();
                }

                if (productStyle != null && productStyle != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProductStyle.Text = productStyle.ToString();
                }

                if (authorizedNo != null && authorizedNo != DBNull.Value)
                {
                    frmSingleCuringCycle.txtAuthorizedNo.Text = authorizedNo.ToString();
                }

                if (producerName != null && producerName != DBNull.Value)
                {
                    frmSingleCuringCycle.txtProducerName.Text = producerName.ToString();
                }
                if (isView)
                {
                    foreach (Control control in frmSingleCuringCycle.Controls.Find("btnSave", true))
                    {
                        control.Enabled = false;
                    }
                }
                DialogResult result = frmSingleCuringCycle.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.pageNavigator.ShowData();
                }
            }
        }
    }
}