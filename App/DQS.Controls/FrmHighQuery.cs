using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DQS.Controls
{
    public partial class FrmHighQuery : DevExpress.XtraEditors.XtraForm
    {
        private DataTable m_FieldData;
        private List<string> m_QueryFileds;
        private string m_QueryFilters;

        /// <summary>
        /// 所有查询列
        /// </summary>
        public List<string> QueryFileds
        {
            get { return m_QueryFileds; }
        }

        /// <summary>
        /// 查询条件
        /// </summary>
        public string QueryFilters
        {
            get { return m_QueryFilters; }
        }

        public FrmHighQuery(List<string> queryFileds)
        {
            InitializeComponent();

            this.m_QueryFileds = queryFileds;

            this.InitFieldData();
        }

        private void InitFieldData()
        {
            this.m_FieldData = new DataTable();
            this.m_FieldData.Columns.Add("FieldName", Type.GetType("System.String"));
            this.m_FieldData.Columns.Add("Condition", Type.GetType("System.String"));
            this.m_FieldData.Columns.Add("FieldValue", Type.GetType("System.String"));
        }

        private void FrmHighQuery_Load(object sender, EventArgs e)
        {
            foreach (string fieldName in this.m_QueryFileds)
            {
                if (fieldName == "序号" || fieldName.Contains("ID")) continue;
                
                DataRow row = this.m_FieldData.NewRow();
                row["FieldName"] = fieldName;
                this.m_FieldData.Rows.Add(row);
            }

            this.gvControl.DataSource = this.m_FieldData;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();

            for (int i = 0; i < gvData.RowCount; i++)
            {
                DataRow row = gvData.GetDataRow(i);
                string filter = row.ItemArray[2].ToString();

                if (!string.IsNullOrEmpty(filter))
                {
                    string fieldName = row.ItemArray[0].ToString();

                    string condition = row.ItemArray[1].ToString();

                    if (condition == "模糊等于")
                    {
                        filter = String.Format("'%{0}%'", filter);
                    }
                    else
                    {
                        filter = String.Format("'{0}'", filter);
                    }

                    filters.Add(String.Format("{0} {1} {2}", fieldName, FrmHighQuery.GetConditionOperator(condition), filter));
                }
            }

            m_QueryFilters = string.Join(" AND ",filters.ToArray());

            this.DialogResult = DialogResult.OK;
        }

        private void gvData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private static string GetConditionOperator(string condition)
        {
            switch (condition)
            {
                case "等于":
                    return "=";
                case "不等于":
                    return "!=";
                case "大于":
                    return ">";
                case "大于等于":
                    return ">=";
                case "小于":
                    return "<";
                case "小于等于":
                    return "<=";
                case "模糊等于":
                    return "LIKE";
                default:
                    return "=";
            }
        }
    }
}