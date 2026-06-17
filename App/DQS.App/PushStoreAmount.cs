using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.App
{
    class PushStoreAmount
    {
        // <summary>
        /// 上报者(appkey)
        /// </summary>
        public string oper_ic_code { get; set; }
        // <summary>
        /// 上报企业统一社会信用代
        /// 码，连锁总部代门店上报
        /// 时使用门店统一社会信用代码
        /// </summary>
        public string org_code { get; set; }
        // <summary>
        /// 企业名称,对应统一社会信用代码
        /// </summary>
        public string org_name { get; set; }

        /// <summary>
        /// 监测上报日期 
        /// </summary>
        public string jcsb_rq { get; set; }
        /// <summary>
        /// 获取在库库存 
        /// </summary>
        public string lskc_list_json { get; set; }
    }
}
