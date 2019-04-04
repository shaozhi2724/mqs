using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SyncService.DataSyncService;
using System.Xml;
using System.Security.Cryptography;
using System.IO;
using SyncService.Code;
using SyncService;
using System.Data.SqlClient;
//using EncryptionLibrary;

namespace SyncService
{
    public partial class FrmService : XtraForm
    {

        public FrmService()
        {
            InitializeComponent();
        }

        private void FrmService_Load(object sender, EventArgs e)
        {

        }

        private void Down()
        {

            DataSyncWS client = new DataSyncWS();
            string message = "";
            client.Url = "http://210.73.89.77:3030/DataSyncService.asmx";
            AuthenticationPT auth = new AuthenticationPT();
            auth.UserCode = "bjkyxh";
            auth.Password = "";// EncryptionLibrary.Encryption.SHA256("1");
            var data = client.GetSyncData("0f5501ec-dfde-46fd-9190-72f6a3fefe12", auth, out message);
            string xmlStr = "";// EncryptionLibrary.Encryption._7UnZipAndFromUTF8(data); //引用EncryptionLibrary.dll转化xml
            //client.UploadSyncData();
            client.Dispose();
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            if (data == null)
            {
                txtDownCon.Text = "无订单！";
            }
            txtDownCon.Text = xmlStr;

            #region
            /*
            string verify = "0f5501ec-dfde-46fd-9190-72f6a3fefe12";
            string message = "";
            DataSyncWS client = new DataSyncWS();
            AuthenticationPT auth = new AuthenticationPT();

            auth.UserCode = "";
            //auth.Password = EncryptionLibrary.Encryption.SHA256("");

            DataSyncWS TheWSClient = new DataSyncWS();

            byte[] bt = TheWSClient.GetSyncData(verify, auth, out message);
            //string xmlStr = EncryptionLibrary.Encryption._7UnZipAndFromUTF8(bt);
            //XmlDocument _Docs = new XmlDocument();
            //_Docs.LoadXml(xmlStr);
            //_Docs.Save(DwonXmlFile);
            */
            #endregion
        }

        public string SHA256(string pwd)
        {
            string shapwd = "";

            //SHA256加密
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                byte[] bytes_sha256_in = UTF8Encoding.Default.GetBytes(pwd);
                byte[] bytes_sha256_out = sha256.ComputeHash(bytes_sha256_in);
                shapwd = BitConverter.ToString(bytes_sha256_out).Replace("-", "");
            }

            return shapwd.ToLower();
        }
        List<YGCG> ygcgs = new List<YGCG>();
        private void btnSerilize_Click(object sender, EventArgs e)
        {

            //string xml = txtOldXML.Text;
            //Table tb = XmlHelper.Deserialize(typeof(Table), xml) as Table;
            //prpXmlObject.SelectedObject = tb;
            //for (int i = 0; i < tb.Column.Count(); i++)
            //{
            //    string a = tb.Column[i].BUYERNAME;
            //    MessageBox.Show(a);
            //}
            string xml = txtOldXML.Text;
            OrderTable tb = XmlHelper.Deserialize(typeof(OrderTable), xml) as OrderTable;
            prpXmlObject.SelectedObject = tb;
            foreach (var item in tb.Column)
            {
                YGCG ygcg = new YGCG();
                ygcg.RECORDID = item.RECORDID;
                ygcg.ORDER_ID = item.ORDER_ID;
                ygcg.ORDERCODE = item.ORDERCODE;
                ygcg.BUYERORGID = item.BUYERORGID;
                ygcg.BUYERNAME = item.BUYERNAME;
                ygcg.BUYEREASY = item.BUYEREASY;
                ygcg.PRODUCTID = item.PRODUCTID;
                ygcg.PRODUCTNAME = item.PRODUCTNAME;
                ygcg.MEDICALMODE = item.MEDICALMODE;
                ygcg.MEDICALNAME = item.MEDICALNAME;
                ygcg.METRICNAME = item.METRICNAME;
                ygcg.MEDICALSPEC = item.MEDICALSPEC;
                ygcg.FATORYID = item.FATORYID;
                ygcg.FACTORYNAME = item.FACTORYNAME;
                ygcg.REQUESTQTY = item.REQUESTQTY;
                ygcg.PRICE = item.PRICE;
                ygcg.CREATEDATE = DateTime.Parse(item.CREATEDATE);
                ygcg.ORDERREMARK = item.ORDERREMARK;
                ygcg.REMARK = item.REMARK;
                ygcg.WAREHOUSENAME = item.WAREHOUSENAME;
                ygcg.DEGREE = item.DEGREE.ToString();
                ygcg.COMPANY_ID = item.COMPANY_ID;
                ygcg.DEPART_NAME = item.DEPART_NAME;
                ygcg.ImportDate = DateTime.Now;
                ygcgs.Add(ygcg);
            }
            using (SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=HGCS;Integrated Security=false;UID=sa;PWD=bokesys.com"))
            {
                string sqlBill = @"EXEC sp_SaveYGCG '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}'";
                try
                {
                    conn.Open();
                    foreach (var item in ygcgs)
                    {
                        SqlCommand comm = new SqlCommand(string.Format(sqlBill, 
                            item.RECORDID,
                            item.ORDER_ID,
                            item.ORDERCODE,
                            item.BUYERORGID,
                            item.BUYERNAME,
                            item.BUYEREASY,
                            item.PRODUCTID,
                            item.PRODUCTNAME,
                            item.MEDICALMODE,
                            item.MEDICALSPEC,
                            item.METRICNAME,
                            item.MEDICALNAME,
                            item.FATORYID,
                            item.FACTORYNAME,
                            item.REQUESTQTY,
                            item.PRICE,
                            item.CREATEDATE,
                            item.ORDERREMARK,
                            item.REMARK,
                            item.WAREHOUSENAME,
                            item.DEGREE,
                            item.COMPANY_ID,
                            item.DEPART_NAME), conn);
                        comm.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            OrderTable tb = prpXmlObject.SelectedObject as OrderTable;
            string newXml = XmlHelper.Serializer(typeof(OrderTable), tb);
            txtNewXML.Text = newXml;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                var billdata = from b in db.BUS_Bill
                               join bd in db.BUS_BillDetail on b.BillID equals bd.BillID
                               select new
                               {
                                   BillCode = b.BillCode,
                                   DealerCode = b.DealerCode,
                                   DealerName = b.DealerName,
                                   DealerSpell = b.DealerSpell,
                                   ProductID = bd.ProductID,
                                   Amount = bd.Amount,
                                   UnitPrice = bd.UnitPrice
                               };
                var viewdata = (billdata.Where(p => p.BillCode == "XS20161020000022")).ToList();
                /*
                var columns = new List<TableColumn> { };
                foreach (var item in viewdata)
	            {
		            TableColumn column = new TableColumn{
                        ORDERCODE=item.BillCode,
                        BUYERORGID=item.DealerCode,
                        BUYERNAME=item.DealerName,
                        BUYEREASY=item.DealerSpell,
                        PRODUCTID=item.ProductID.ToString(),
                        REQUESTQTY=(byte)item.Amount,
                        PRICE=Convert.ToDecimal(item.UnitPrice)
                    };
                    columns.Add(column);
                }

                Table tb = new Table
                {
                    Column = columns.ToArray()
                };
                prpXmlObject.SelectedObject = tb;
                */
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Down();
        }
    }
    public class YGCG
    {
        public string RECORDID { get; set; }
        public string ORDER_ID { get; set; }
        public string ORDERCODE { get; set; }
        public string BUYERORGID { get; set; }
        public string BUYERNAME { get; set; }
        public string BUYEREASY { get; set; }
        public string PRODUCTID { get; set; }
        public string PRODUCTNAME { get; set; }
        public string MEDICALMODE { get; set; }
        public string MEDICALSPEC { get; set; }
        public string METRICNAME { get; set; }
        public string MEDICALNAME { get; set; }
        public string FATORYID { get; set; }
        public string FACTORYNAME { get; set; }
        public decimal REQUESTQTY { get; set; }
        public decimal PRICE { get; set; }
        public DateTime CREATEDATE { get; set; }
        public string ORDERREMARK { get; set; }
        public string REMARK { get; set; }
        public string WAREHOUSENAME { get; set; }
        public string DEGREE { get; set; }
        public string COMPANY_ID { get; set; }
        public string DEPART_NAME { get; set; }
        public DateTime ImportDate { get; set; }
    }
}
