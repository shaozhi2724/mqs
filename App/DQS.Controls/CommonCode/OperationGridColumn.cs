using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.Controls.CommonCode
{
    /// <summary>
    /// 业务表格的列
    /// </summary>
    public class OperationGridColumn
    {
        /// <summary>
        /// 列名称
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// 列对应的实体字段
        /// </summary>
        public string EntityField { get; set; }

        /// <summary>
        /// 列对应的实体字段类型
        /// </summary>
        public string FieldType { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// 是否可为空
        /// </summary>
        public bool Nullable { get; set; }

        /// <summary>
        /// 是否可编辑
        /// </summary>
        public bool AllowEdit { get; set; }

        /// <summary>
        /// 配置文件中的弹出窗体标识
        /// </summary>
        public string PopupFormString { get; set; }

        /// <summary>
        /// 要显示的对应窗体字段
        /// </summary>
        public string PopupField { get; set; }

        /// <summary>
        /// 对应的弹出窗体
        /// </summary>
        public OperationPopupForm PopupForm { get; set; }

        /// <summary>
        /// 允许多选
        /// </summary>
        public bool AllowMultipleSelection { get; set; }

    }
}
