using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Controls;
using DQS.Module.Entities;
using ORMSCore;

namespace DQS.AppViews.ExceptionControl.ExceptionManager
{
    public partial class FrmProdcutDestroy : StandardForm
    {
        public FrmProdcutDestroy()
        {
            InitializeComponent();
        }

        private void FrmProdcutDestroy_Load(object sender, EventArgs e)
        {
            base.InitPage();
        }

        protected override void CustomApprove()
        {
            object id = this.gvData.GetFocusedRowCellValue("销毁ID");
            if (id != null && id != DBNull.Value)
            {
                DialogResult dr = base.BaseApprove();
                if (dr == DialogResult.Yes)
                {
                    BUSProdcutDestroyEntity entity = new BUSProdcutDestroyEntity{DestroyID = (int) id};
                    entity.Fetch();
                    if (entity.DestroyStatusID == 1)
                    {
                        entity.DestroyStatusID = 2;
                        entity.DestroyStatus = "已审核";
                        entity.Update();
                    }
                    //更新不合格品业务库存
                    EntityCollection<BUSProdcutDestroyDetailEntity> details =
                        new EntityCollection<BUSProdcutDestroyDetailEntity>();
                    details.Fetch(BUSProdcutDestroyDetailEntityFields.DestroyID == (int) id);
                    foreach (BUSProdcutDestroyDetailEntity detail in details)
                    {

                        EntityCollection<BUSUnqualifiedStoreDetailEntity> stores =
                            new EntityCollection<BUSUnqualifiedStoreDetailEntity>();
                        stores.Fetch(BUSUnqualifiedStoreDetailEntityFields.ProductID == detail.ProductID &
                                     BUSUnqualifiedStoreDetailEntityFields.BatchNo == detail.BatchNo);
                        foreach (BUSUnqualifiedStoreDetailEntity unqualifiedStoreDetailEntity in stores)
                        {
                            if (null != unqualifiedStoreDetailEntity)
                            {
                                unqualifiedStoreDetailEntity.Amount -= detail.Amount;
                                if (unqualifiedStoreDetailEntity.Amount == 0)
                                {
                                    unqualifiedStoreDetailEntity.Delete();
                                }
                                else
                                {
                                    unqualifiedStoreDetailEntity.Save();
                                }
                            }
                        }
                    }
                    this.pageNavigator.ShowData();
                }
            }
        }

        protected override void CustomDelete()
        {
            object approveStatus = this.gvData.GetFocusedRowCellValue("审批状态");
            object destroyCode = this.gvData.GetFocusedRowCellValue("销毁编号");
            if (destroyCode != null && destroyCode != DBNull.Value && approveStatus != null && approveStatus != DBNull.Value)
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
                    pe.Add(ATCApproveEntityFields.DocumentCode == "ProductDestroy");
                    pe.Add(ATCApproveEntityFields.BillCode == destroyCode.ToString());
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
    }
}