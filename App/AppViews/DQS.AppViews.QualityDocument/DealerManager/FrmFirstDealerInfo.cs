using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DQS.Common;
using DQS.Controls;
using DQS.Module.Entities;
using DevExpress.XtraGrid;
using ORMSCore;

namespace DQS.AppViews.QualityDocument.DealerManager
{
    public partial class FrmFirstDealerInfo : StandardForm
    {
        public FrmFirstDealerInfo()
        {
            InitializeComponent();
        }

        private void FrmFirstDealerInfo_Load(object sender, EventArgs e)
        {
            this.pageNavigator.SortField = "创建日期";
            this.pageNavigator.SortType = "DESC";

            base.InitPage();

            #region 未审批结束高亮显示

            StyleFormatCondition sfcApprove = new StyleFormatCondition();
            sfcApprove.Appearance.BackColor = Color.Red;
            sfcApprove.Appearance.Options.UseBackColor = true;
            sfcApprove.ApplyToRow = true;
            sfcApprove.Column = this.gvData.Columns["审批状态"];
            sfcApprove.Condition = FormatConditionEnum.Equal;
            sfcApprove.Value1 = "未审批结束";

            this.gvData.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] { sfcApprove });

            #endregion
        }

        protected override void CustomQualification()
        {
            object id = gvData.GetFocusedRowCellValue("单位ID");
            if (id != null)
            {

                using (FrmQualification frmQualification = new FrmQualification(Convert.ToInt32(id), "BFI_Dealer", "DealerID", "DealerCertificate"))
                {
                    frmQualification.VisbleBarItem();

                    object approveStatus = this.gvData.GetFocusedRowCellValue("审批状态");
                    object dealerCode = this.gvData.GetFocusedRowCellValue("单位编号");
                    if (dealerCode != null && dealerCode != DBNull.Value && approveStatus != null && approveStatus != DBNull.Value)
                    {
                        if (approveStatus.ToString() == "审批结束")
                        {
                            frmQualification.ShowDialog();
                        }
                        else
                        {
                            EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                            PredicateExpression pe = new PredicateExpression();
                            pe.Add(ATCApproveEntityFields.DocumentCode == "FirstDealer");
                            pe.Add(ATCApproveEntityFields.BillCode == dealerCode.ToString());
                            pe.Add(ATCApproveEntityFields.IsApprovaled == 1);
                            approveEntities.Fetch(pe);
                            if (approveEntities.Count > 0)
                            {
                                frmQualification.ShowDialog();
                            }
                            else
                            {
                                SetToolbarItemStates(frmQualification);

                                frmQualification.ShowDialog();
                            }

                        }
                    }
                }
            }

            base.CustomQualification();
        }

        protected override void CustomProductForDealer()
        {
            using (FrmProductOfDealer pod = new FrmProductOfDealer())
            {
                object id = gvData.GetFocusedRowCellValue("单位ID");
                if (id != null)
                {
                    pod.SearchID = Convert.ToInt32(id);
                    pod.SelectSql = "SELECT ProductID FROM BUS_DealerVSProduct WHERE DealerID = ";
                    pod.DelSql = "sp_DelDealerVSProduct";
                    pod.InSql = "sp_SaveDealerVSProduct";
                }
                pod.ShowDialog();
            }
        }

        protected override void CustomModifyRequest()
        {
            try
            {
                object id = gvData.GetFocusedRowCellValue("单位ID");
                if (id != null)
                {
                    object approveStatus = this.gvData.GetFocusedRowCellValue("审批状态");
                    object dealerCode = this.gvData.GetFocusedRowCellValue("单位编号");
                    if (dealerCode != null && dealerCode != DBNull.Value && approveStatus != null &&
                        approveStatus != DBNull.Value)
                    {
                        if (approveStatus.ToString() != "审批结束")
                        {
                            EntityCollection<ATCApproveEntity> approveEntities =
                                new EntityCollection<ATCApproveEntity>();
                            PredicateExpression pe = new PredicateExpression();
                            pe.Add(ATCApproveEntityFields.DocumentCode == "FirstDealer");
                            pe.Add(ATCApproveEntityFields.BillCode == dealerCode.ToString());
                            pe.Add(ATCApproveEntityFields.IsApprovaled == 1);
                            approveEntities.Fetch(pe);
                            if (approveEntities.Count > 0)
                            {
                                XtraMessageBox.Show("此记录正在审核中，请在审核结束后再进行信息变更！", "系统提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                XtraMessageBox.Show("此记录还未进入审核流程，请直接修改信息！", "系统提示", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    EntityCollection<ATCAntiApproveEntity> antiApproveEntities =
                        new EntityCollection<ATCAntiApproveEntity>();
                    antiApproveEntities.Fetch(ATCAntiApproveEntityFields.DocumentCode == "FirstDealer"
                                              & ATCAntiApproveEntityFields.AntiApproveItemID == (int) id
                                              & ATCAntiApproveEntityFields.StatusID == 1
                                              //& ATCAntiApproveEntityFields.CreateUserID == GlobalItem.g_CurrentUser.UserID
                                              );
                    if (antiApproveEntities.Count > 0)
                    {
                        XtraMessageBox.Show("此记录已有提交的变更申请还未批准，请不要重复提交变更申请！", "系统提示", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    FrmSingleFirstDealerAntiApprove singleForm = new FrmSingleFirstDealerAntiApprove();
                    singleForm.Tag = (int) id;
                    if (singleForm.Tag != null)
                    {
                        DialogResult result = singleForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.pageNavigator.ShowData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetToolbarItemStates(FrmQualification frmQualification)
        {
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
        }

        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("单位ID");
            if (id != null && id != DBNull.Value)
            {
                //检查证书完成情况
                EntityCollection<BFIQualificationEntity> quatities = new EntityCollection<BFIQualificationEntity>();
                quatities.Fetch(BFIQualificationEntityFields.BelongTable == "BFI_Dealer"
                    & BFIQualificationEntityFields.QualificationBelong == "BFI_Dealer"
                    & BFIQualificationEntityFields.BelongFieldName == "DealerID"
                    & BFIQualificationEntityFields.BelongID == id.ToString());
                List<string> defaultQuatificateNames = new List<string>();
                List<string> unFinishedDefaultQuatificateNames = new List<string>();
                List<string> unValidQuatificateNames = new List<string>();
                foreach (var quatity in quatities.Cast<BFIQualificationEntity>())
                {
                    if (!quatity.IsNullField("ValidateDate"))
                    {
                        if (DateTime.Now > quatity.ValidateDate)
                        {
                            unValidQuatificateNames.Add(quatity.CertificateStyle);
                        }
                    }
                    if (quatity.QualificationCode.Length == 20 && quatity.QualificationCode.EndsWith("D"))
                    {
                        defaultQuatificateNames.Add(quatity.CertificateStyle);
                        if(quatity.IsNullField("ValidateDate"))
                        {
                            unFinishedDefaultQuatificateNames.Add(quatity.CertificateStyle);
                        }
                    }
                }
                if (defaultQuatificateNames.Count == 0 || unFinishedDefaultQuatificateNames.Count > 0)
                {
                    XtraMessageBox.Show("电子档案信息不全，请返回并录入电子档案！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (unValidQuatificateNames.Count > 0)
                {
                    var message = string.Empty;
                    for (int i = 0; i < unValidQuatificateNames.Count; i++)
                    {
                        var unValidQuatificateName = unValidQuatificateNames[i];
                        message += (i+1).ToString() + ". " + unValidQuatificateName + "\n";
                    }
                    XtraMessageBox.Show("以下电子档案已过期，请返回并修改电子档案：\n" + message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {
                    //更新首营客户状态

                    BFIDealerEntity dealer = new BFIDealerEntity();
                    dealer.BusinessStatus = 1;
                    dealer.DealerID = Convert.ToInt32(id);
                    dealer.Update();

                    this.pageNavigator.ShowData();
                }
            }
        }
        protected override void CustomDelete()
        {
            object approveStatus = this.gvData.GetFocusedRowCellValue("审批状态");
            object dealerCode = this.gvData.GetFocusedRowCellValue("单位编号");
            if (dealerCode != null && dealerCode != DBNull.Value && approveStatus != null && approveStatus != DBNull.Value)
            {
                if (approveStatus.ToString() == "审批结束")
                {
                    XtraMessageBox.Show("此记录已审核通过，不允许删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    EntityCollection<ATCApproveEntity> approveEntities = new EntityCollection<ATCApproveEntity>();
                    PredicateExpression pe = new PredicateExpression();
                    pe.Add(ATCApproveEntityFields.DocumentCode == "FirstDealer");
                    pe.Add(ATCApproveEntityFields.BillCode == dealerCode.ToString());
                    pe.Add(ATCApproveEntityFields.IsApprovaled == 1);
                    approveEntities.Fetch(pe);
                    if (approveEntities.Count > 0)
                    {
                        XtraMessageBox.Show("此记录正在审核中，不允许删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    base.CustomDelete();
                }
            }
        }
        protected override void CustomPrint()
        {
            object id = gvData.GetFocusedRowCellValue("单位ID");
            if (id != null)
            {
                base.SinglePrint("首营经销商", "FirstDealer", "单位ID = " + id);
            }

            //base.CustomPrint();
        }
    }
}