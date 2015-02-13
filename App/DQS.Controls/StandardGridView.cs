using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Drawing;

namespace DQS.Controls
{
    public class StandardGridView : GridView
    {
        public StandardGridView(DevExpress.XtraGrid.GridControl ownerGrid)
            : base(ownerGrid)
        {
            this.InitAppearance();
        }

        public StandardGridView()
        {
            this.InitAppearance();
        }

        private void InitAppearance()
        {
            this.Appearance.EvenRow.BackColor = Color.WhiteSmoke;
            this.Appearance.EvenRow.Options.UseBackColor = true;
            this.Appearance.FocusedCell.BackColor = Color.Aqua;
            this.Appearance.FocusedCell.Options.UseBackColor = true;
            this.Appearance.FocusedRow.BackColor = Color.Beige;
            this.Appearance.FocusedRow.ForeColor = Color.Black;
            this.Appearance.FocusedRow.Options.UseBackColor = true;
            this.Appearance.FocusedRow.Options.UseForeColor = true;
            this.IndicatorWidth = 40;
            this.Name = "gridView";
            this.OptionsView.ColumnAutoWidth = true;
            this.OptionsView.EnableAppearanceEvenRow = true;
            this.OptionsView.ShowGroupPanel = false;
            this.OptionsBehavior.Editable = false;
            this.CustomDrawRowIndicator += this.gridView_CustomDrawRowIndicator;
            this.CustomDrawEmptyForeground += this.gridView_CustomDrawEmptyForeground;
        }

        private void gridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void gridView_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.RowCount != 0) return;//有记录，返回

            using (StringFormat drawFormat = new StringFormat())
            {
                drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("暂无记录", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
            }
        }

    }
}
