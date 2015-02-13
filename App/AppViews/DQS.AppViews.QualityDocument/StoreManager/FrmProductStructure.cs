using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ORMSCore;
using DQS.Module.Views;
using DevExpress.XtraGrid.Views.Grid;
using DQS.Module.Entities;

namespace DQS.AppViews.QualityDocument.StoreManager
{
    public partial class FrmProductStructure : DevExpress.XtraEditors.XtraForm
    {
        public FrmProductStructure()
        {
            InitializeComponent();
        }

        private void FrmProductStructure_Load(object sender, EventArgs e)
        {
            this.InitPageData();
        }

        private void gvData_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void gvData_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.RowCount != 0) return;//有记录，返回

            using (StringFormat drawFormat = new StringFormat())
            {
                drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("暂无记录", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
            }
        }

        private void btnProductQuery_Click(object sender, EventArgs e)
        {
            if (this.txtProductName.Text.Trim().Length > 0)
            {
                this.pageNavigatorProduct.Filter = string.Format(this.txtProductName.FormatQueryString, this.txtProductName.Text.Trim());
                this.pageNavigatorProduct.ShowData();
            }
            else
            {
                this.pageNavigatorProduct.Filter = "";
                this.pageNavigatorProduct.ShowData();
            }
        }

        private void btnStructureQuery_Click(object sender, EventArgs e)
        {
            if (this.txtStructureName.Text.Trim().Length > 0)
            {
                this.pageNavigatorStructure.Filter = string.Format(this.txtStructureName.FormatQueryString, this.txtStructureName.Text.Trim());
                this.pageNavigatorStructure.ShowData();
            }
            else
            {
                this.pageNavigatorStructure.Filter = "";
                this.pageNavigatorStructure.ShowData();
            }
        }

        private void btnUnionQuery_Click(object sender, EventArgs e)
        {
            if (this.txtUnionQuery.Text.Trim().Length > 0)
            {
                this.pageNavigatorUnion.Filter = string.Format(this.txtUnionQuery.FormatQueryString, this.txtUnionQuery.Text.Trim());
                this.pageNavigatorUnion.ShowData();
            }
            else
            {
                this.pageNavigatorUnion.Filter = "";
                this.pageNavigatorUnion.ShowData();
            }
        }

        private void txtQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if ((sender as Control).Name == "txtProductName")
                {
                    this.btnProductQuery_Click(null, null);
                }
                if ((sender as Control).Name == "txtStructureName")
                {
                    this.btnStructureQuery_Click(null, null);
                }
                if ((sender as Control).Name == "txtUnionQuery")
                {
                    this.btnUnionQuery_Click(null, null);
                }
            }
        }

        private void btnRelation_Click(object sender, EventArgs e)
        {
            if (gvProduct.RowCount > 0 && gvStructure.RowCount > 0)
            {
                BFIProductStructureEntity entity = new BFIProductStructureEntity();
                object productID = gvProduct.GetFocusedRowCellValue(this.pageNavigatorProduct.PrimaryField);
                if (productID != null)
                {
                    entity.ProductID = Convert.ToInt32(productID);
                }

                object structureID = gvStructure.GetFocusedRowCellValue(this.pageNavigatorStructure.PrimaryField);
                if (structureID != null)
                {
                    entity.StructureID = Convert.ToInt32(structureID);
                }

                entity.Save();
                this.InitPageData();
            }
        }

        private void btnUnRelation_Click(object sender, EventArgs e)
        {
            if (gvUnion.RowCount > 0)
            {
                DialogResult result = XtraMessageBox.Show("确定要接触该关联关系吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    object id = gvUnion.GetFocusedRowCellValue(this.pageNavigatorUnion.PrimaryField);
                    if (id != null)
                    {
                        BFIProductStructureEntity entity = new BFIProductStructureEntity { ProductID = Convert.ToInt32(id) };
                        entity.Delete();

                        this.InitPageData();
                    }
                }
            }
        }

        private void InitPageData()
        {
            this.txtProductName.Text = "";
            this.txtStructureName.Text = "";
            this.txtUnionQuery.Text = "";

            this.pageNavigatorUnion.Filter = "";
            this.pageNavigatorUnion.ShowData();

            this.pageNavigatorStructure.Filter = "";
            this.pageNavigatorStructure.ShowData();

            this.pageNavigatorProduct.Filter = "";
            this.pageNavigatorProduct.ShowData();
        }

    }
}