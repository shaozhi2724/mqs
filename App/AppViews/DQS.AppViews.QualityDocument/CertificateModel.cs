using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQS.AppViews.QualityDocument
{
    public class CertificateModel
    {
        public string 档案ID { get; set; }
        public string 档案编号 { get; set; }
        public string 档案名称 { get; set; }
        public string 证书类型 { get; set; }
        public string 证书编号 { get; set; }
        public string 发证机关 { get; set; }
        public string 发证日期 { get; set; }
        public string 到期日期 { get; set; }
        public string 到期状态 { get; set; }
        public string 创建人 { get; set; }
        public string 创建日期 { get; set; }
        public string 最后修改人 { get; set; }
        public string 修改时间 { get; set; }
        public string 备注 { get; set; }
        public string 所属ID { get; set; }
        public string 所属表ID { get; set; }
        public string 所属列名ID { get; set; }
    }
}
