using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Columns;

namespace DQS.Controls.CommonCode
{
    public class BeforePopupFormShowArgs
    {
        private GridColumn m_GridColumn;
        private OperationGridColumn m_OperationColumn;

        public BeforePopupFormShowArgs(GridColumn gridColumn, OperationGridColumn operationColumn)
        {
            this.m_GridColumn = gridColumn;
            this.m_OperationColumn = operationColumn;
        }

        public GridColumn ActiveColumn
        {
            get
            {
                return m_GridColumn;
            }
        }

        public OperationGridColumn ActiveOperationColumn
        {
            get
            {
                return m_OperationColumn;
            }
        }

        public bool Cancel { get; set; }
    }
}
