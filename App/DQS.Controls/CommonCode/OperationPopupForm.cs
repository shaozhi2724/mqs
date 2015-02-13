using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.Controls.CommonCode
{
    public class OperationPopupForm
    {
        /// <summary>
        /// 窗体名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 弹出方式
        /// </summary>
        public string PopStyle { get; set; }

        /// <summary>
        /// 弹出窗体查询的转换字符串
        /// </summary>
        public string FormatQueryString { get; set; }

        /// <summary>
        /// 弹出窗体要显示的视图名称
        /// </summary>
        public string ViewName { get; set; }

        /// <summary>
        /// 视图中的主键，ROW_NUMBER分页使用
        /// </summary>
        public string PrimaryField { get; set; }

        /// <summary>
        /// 要显示的视图中的字段，","逗号分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 查询视图的初始条件
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// 弹出窗体分页页数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 允许多选
        /// </summary>
        public bool AllowMultipleSelection { get; set; }
        /// <summary>
        /// 分组字段
        /// </summary>
        public string GroupFieldName { get; set; }
    }
}
