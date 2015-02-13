using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DQS.Controls.CommonCode
{
    public class PopupFormClosedArgs
    {
        private DataRow m_Row;
        private DataRow[] m_Rows;

        public PopupFormClosedArgs(DataRow row)
        {
            this.m_Row = row;
        }
        public PopupFormClosedArgs(DataRow[] rows)
        {
            this.m_Rows = rows;
        }

        public DataRow PopupRow 
        {
            get 
            {
                return this.m_Row;
            }
        }

        public DataRow[] PopupRows
        {
            get 
            {
                return this.m_Rows;
            }
        }

        public bool Cancel { get; set; }
    }
}
