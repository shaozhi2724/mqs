﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DQS.Controls;

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmSalesmanInfo : StandardForm
    {
        public FrmSalesmanInfo()
        {
            InitializeComponent();
        }

        private void FrmSalesmanInfo_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomQualification()
        {
            this.SaveDataLog("电子档案");
            object id = gvData.GetFocusedRowCellValue("人员ID");
            if (id != null)
            {

                using (FrmQualification frmQualification = new FrmQualification(Convert.ToInt32(id), "BFI_Salesman", "SalesmanID", "DealerPersonCertificate"))
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