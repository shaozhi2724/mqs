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

        private void btnDown_Click(object sender, EventArgs e)
        {

            /*
            DataSyncWS client = new DataSyncWS();
            string message = "";
            client.Url = "http://124.193.157.37:8067/DataSyncService.asmx";
            var data = client.GetSyncData("0f5501ec-dfde-46fd-9190-72f6a3fefe12", new AuthenticationPT { UserCode="",Password=""}, out message);
            //client.UploadSyncData();
            client.Dispose();
            */


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

            return shapwd;
        }
    }
}
