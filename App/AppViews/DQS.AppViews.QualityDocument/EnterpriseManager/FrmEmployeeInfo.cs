using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.QualityDocument.EnterpriseManager
{
    public partial class FrmEmployeeInfo : StandardForm
    {
        public FrmEmployeeInfo()
        {
            InitializeComponent();
        }

        private void FrmEmployeeInfo_Load(object sender, EventArgs e)
        {
            base.InitPage();
            
        }

        protected override void CustomQualification()
        {
            object id = gvData.GetFocusedRowCellValue("员工ID");
            if (id != null)
            {

                using (FrmQualification frmQualification = new FrmQualification(Convert.ToInt32(id), "BFI_Employee", "EmployeeID", "EmployeeCertificate"))
                {
                    frmQualification.VisbleBarItem();
                    var barItems = toolBarPanel.barManager.Items;
                    foreach (BarItem barItem in barItems)
                    {
                        switch (barItem.Caption.Trim())
                        {
                            case "新建":
                                frmQualification.barBtnNew.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnUpAttachment.Visibility = BarItemVisibility.Always;
                                frmQualification.barDeleteAttachment.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnNewAttribute.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnDeleteAttribute.Visibility = BarItemVisibility.Always;
                                break;
                            case "修改":
                                frmQualification.barBtnModify.Visibility = BarItemVisibility.Always;

                                frmQualification.barBtnUpAttachment.Visibility = BarItemVisibility.Always;
                                frmQualification.barDeleteAttachment.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnNewAttribute.Visibility = BarItemVisibility.Always;
                                frmQualification.barBtnDeleteAttribute.Visibility = BarItemVisibility.Always;
                                break;
                            case "删除":
                                frmQualification.barBtnDelete.Visibility = BarItemVisibility.Always;
                                break;
                        }
                    }
                    frmQualification.ShowDialog();
                }
            }

            base.CustomQualification();
        }
    }
}