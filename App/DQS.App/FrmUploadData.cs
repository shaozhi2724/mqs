using DevExpress.XtraEditors;
using DQS.App.Properties;
using DQS.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DQS.App
{
    public partial class FrmUploadData : XtraForm
    {
        public FrmUploadData()
        {
            InitializeComponent();
        }

        private void FrmUploadData_Load(object sender, EventArgs e)
        {
            //加载定时器
            this.timer.Enabled = true;
            txtData.EditValue = "定时器启动......" + Environment.NewLine;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //判断当前时间小时数
            txtData.EditValue += "当前时间ToString为:" + DateTime.UtcNow.AddHours(8).ToString("yyyy-MM-dd HH:mm:ss") + ",当前小时为:" + DateTime.UtcNow.AddHours(8).Hour + Environment.NewLine;
            int CurrentHour = DateTime.UtcNow.AddHours(8).Hour;
            txtData.EditValue += CurrentHour % 2 + Environment.NewLine;

            //string tokenValue = getToken();
            txtData.EditValue +=  Environment.NewLine;
            //JObject jo = (JObject)JsonConvert.DeserializeObject(tokenValue);
            //string token = jo["token"].ToString();
            //txtData.EditValue += token + Environment.NewLine;


            if (CurrentHour % 2 == 0)
            {
                //调用每两个小时的出入库
                GetPushOrderValue("");
            }
            if (CurrentHour == 21)
            {
                //调用上传当天库存
                string PushStoreValue = GetPushValue("serviceCode6", "");
                txtData.EditValue += "推送库存结果:" + PushStoreValue + Environment.NewLine;
                //调用上传当天统计
                string InOutAmountValue = GetPushValue("serviceCode5", "");
                txtData.EditValue += "推送出入库汇总结果:" + InOutAmountValue + Environment.NewLine;
            }
        }

        private void FrmUploadData_FormClosed(object sender, FormClosedEventArgs e)
        {
            //关闭定时器
            this.timer.Enabled = false;
        }

        /// <summary>
        /// 获取token
        /// </summary>
        /// <returns></returns>
        private string getToken()
        {
            string PushUrl = Settings.Default.PushUrl;
            string GetToken = Settings.Default.GetToken;
            string appKey = Settings.Default.appKey;
            string appSecret = Settings.Default.appSecret;
            return HttpUtil.Get(PushUrl + GetToken + "?appKey=" + appKey + "&appSecret=" + appSecret);
        }

        /// <summary>
        /// 推送数据
        /// </summary>
        /// <returns></returns>
        private string pushData(string GateWay,string aesStr)
        {
            string PushUrl = Settings.Default.PushUrl;
            string GateWayData = Settings.Default.GateWayData;
            //List<StoreAmount> storeAmountList = ;
            PushClass pushClass = new PushClass();
            pushClass.s_k = GateWay;
            string tokenValue = getToken();
            JObject jo = (JObject)JsonConvert.DeserializeObject(tokenValue);
            pushClass.a_t = jo["token"].ToString();
            pushClass.s_p = aesStr;
            string pushStr = JsonConvert.SerializeObject(pushClass, Formatting.Indented);
            pushStr = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(pushStr), Formatting.None);
            string value = HttpUtil.Post(PushUrl + GateWayData, pushStr);
            return value;
        }

        private string GetPushOrderValue(string currentTime)
        {
            if (currentTime == "" || currentTime == null)
            {
                currentTime = DateTime.UtcNow.AddHours(8).ToString("yyyy-MM-dd");
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "EXEC dbo.sp_GetTimeData @CurrentDate = N'"+ currentTime + "'";

                SqlDataAdapter sdad = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sdad.Fill(ds, "table");

                if (ds.Tables[0].Rows.Count <= 0)
                {
                    return "无上传数据";
                }
                List<BillData> billList = new List<BillData>();
                for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                {
                    BillData bill = new BillData();
                    bill.id = int.Parse(ds.Tables["Table"].Rows[i]["id"].ToString());
                    bill.table_name = ds.Tables["Table"].Rows[i]["table_name"].ToString();
                    bill.update_id = ds.Tables["Table"].Rows[i]["update_id"].ToString();

                    if (billList.Count > 0 && billList.Any(x => x.id.Equals(bill.id) && x.table_name.Equals(bill.table_name)))
                    {
                        continue;
                    }

                    bill.bill_code = ds.Tables["Table"].Rows[i]["bill_code"].ToString();
                    bill.bill_time = ds.Tables["Table"].Rows[i]["bill_time"].ToString();
                    bill.bill_type = ds.Tables["Table"].Rows[i]["bill_type"].ToString();
                    bill.org_code = ds.Tables["Table"].Rows[i]["org_code"].ToString();
                    bill.from_org_code = ds.Tables["Table"].Rows[i]["from_org_code"].ToString();
                    bill.from_org_name = ds.Tables["Table"].Rows[i]["from_org_name"].ToString();
                    bill.to_org_code = ds.Tables["Table"].Rows[i]["to_org_code"].ToString();
                    bill.to_org_name = ds.Tables["Table"].Rows[i]["to_org_name"].ToString();
                    bill.enterprise_type = ds.Tables["Table"].Rows[i]["enterprise_type"].ToString();
                    bill.enterprise_area = ds.Tables["Table"].Rows[i]["enterprise_area"].ToString();
                    bill.oper_ic_code = ds.Tables["Table"].Rows[i]["oper_ic_code"].ToString();
                    bill.data_type = ds.Tables["Table"].Rows[i]["data_type"].ToString();
                    billList.Add(bill);

                }
                foreach (BillData item in billList)
                {
                    txtData.EditValue += "开始推送单据:" + item.bill_code + Environment.NewLine;
                    List<BillDetailData> billDetailDataList = new List<BillDetailData>();
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        int id = int.Parse(ds.Tables["Table"].Rows[i]["id"].ToString());
                        string table_name = ds.Tables["Table"].Rows[i]["table_name"].ToString();
                        if (id.Equals(item.id) && table_name.Equals(item.table_name))
                        {
                            BillDetailData billDetail = new BillDetailData();
                            billDetail.code_type = ds.Tables["Table"].Rows[i]["data_type"].ToString();
                            billDetail.code = ds.Tables["Table"].Rows[i]["data_type"].ToString();
                            billDetail.physic_info = ds.Tables["Table"].Rows[i]["physic_info"].ToString();
                            billDetail.pkg_spec = ds.Tables["Table"].Rows[i]["pkg_spec"].ToString();
                            billDetail.packing_unit = ds.Tables["Table"].Rows[i]["packing_unit"].ToString();
                            billDetail.approval_licence_no = ds.Tables["Table"].Rows[i]["approval_licence_no"].ToString();
                            billDetail.produce_batch_no = ds.Tables["Table"].Rows[i]["produce_batch_no"].ToString();
                            billDetail.produce_date = ds.Tables["Table"].Rows[i]["produce_date"].ToString();
                            billDetail.exprie_date = ds.Tables["Table"].Rows[i]["exprie_date"].ToString();
                            billDetail.code_count = ds.Tables["Table"].Rows[i]["code_count"].ToString();
                            billDetailDataList.Add(billDetail);
                        }
                    }
                    string list = JsonConvert.SerializeObject(billDetailDataList, Formatting.None);
                    byte[] listDataBytes = Encoding.UTF8.GetBytes(list);
                    string base64List = Convert.ToBase64String(listDataBytes);
                    item.drug_list_json = base64List;

                    Type type = item.GetType();
                    PropertyInfo[] properties = type.GetProperties();
                    string jointStr = "";
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.Name.Equals("id") || property.Name.Equals("table_name") || property.Name.Equals("update_id"))
                        {
                            continue;
                        }
                        jointStr+=property.Name + "=" + property.GetValue(item, null)+"&";
                    }
                    jointStr = jointStr.Substring(0, jointStr.Length - 1);
                    txtData.EditValue += "加密前:" + jointStr + Environment.NewLine;
                    txtData.EditValue += Environment.NewLine;

                    string appSecret = Settings.Default.appSecret;
                    // Key should be 16 bytes
                    byte[] key = Encoding.UTF8.GetBytes(appSecret.Substring(0, 16));

                    byte[] newStrByte = Encoding.UTF8.GetBytes(jointStr);

                    // Encrypt the data
                    byte[] encryptedData = EncryptAesEcb(newStrByte, key);


                    string finalStr = BitConverter.ToString(encryptedData).Replace("-", ""); //转完String去掉"-"
                    txtData.EditValue += "加密后:" + finalStr + Environment.NewLine;
                    string pushBillValue = pushData("serviceCode2", finalStr);
                    txtData.EditValue += "推送结果:" + pushBillValue + Environment.NewLine;
                    JObject jo = (JObject)JsonConvert.DeserializeObject(pushBillValue);
                    if (jo["code"].ToString().Equals("200"))
                    {
                        string updateStr = "update " + item.table_name + " set IsPush = 1 where " + item.update_id + " = " + item.id;
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(updateStr, conn);
                        int count = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            return "推送单据完成";
        }

        /// <summary>
        /// 库存和汇总 获取数据后推送
        /// </summary>
        /// <param name="GateWayType"></param>
        /// <param name="listName"></param>
        /// <returns></returns>
        private string GetPushValue(string GateWayType,string currentTime)
        {
            if (currentTime == "" || currentTime == null)
            {
                currentTime = DateTime.UtcNow.AddHours(8).ToString("yyyy-MM-dd");
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sql = "";
                string listName = "";
                switch (GateWayType)
                {
                    case "serviceCode6":
                        sql = "EXEC dbo.sp_GetStoreAmount";
                        listName = "lskc_list_json";
                        break;
                    case "serviceCode5":
                        sql = "EXEC dbo.sp_GetInOutAmount @CurrentDate = N'"+ currentTime + "'";
                        listName = "pfkc_list_json";
                        break;
                    default:
                        break;
                }

                SqlDataAdapter sdad = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sdad.Fill(ds, "table");

                if (ds.Tables[0].Rows.Count <= 0)
                {
                    return "无上传数据";
                }

                string list = JsonConvert.SerializeObject(ds.Tables[0], Formatting.Indented);
                list = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(list), Formatting.None);
                byte[] listDataBytes = Encoding.UTF8.GetBytes(list);
                string base64List = Convert.ToBase64String(listDataBytes);

                //拼接字符串
                string newStr = "";
                newStr += "oper_ic_code=" + Settings.Default.appKey + "&org_code="+ Settings.Default.orgCode + "&org_name=" + Settings.Default.orgName + "&jcsb_rq=" + currentTime + " 00:00&" + listName + "=" + base64List;
                txtData.EditValue += "加密前:" + newStr + Environment.NewLine;
                txtData.EditValue += Environment.NewLine;

                string appSecret = Settings.Default.appSecret;
                // Key should be 16 bytes
                byte[] key = Encoding.UTF8.GetBytes(appSecret.Substring(0, 16));

                byte[] newStrByte = Encoding.UTF8.GetBytes(newStr);

                // Encrypt the data
                byte[] encryptedData = EncryptAesEcb(newStrByte, key);


                string finalStr = BitConverter.ToString(encryptedData).Replace("-", ""); //转完String去掉"-"
                txtData.EditValue += "加密后:" + finalStr + Environment.NewLine;
                return pushData(GateWayType, finalStr);
            } 
        }

        public static byte[] EncryptAesEcb(byte[] data, byte[] key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    return encryptor.TransformFinalBlock(data, 0, data.Length);
                }
            }
        }

    }

    public class BillData
    {
        public int id { get; set; }
        public string table_name { get; set; }
        public string update_id { get; set; }
        public string bill_code { get; set; }
        public string bill_time { get; set; }
        public string bill_type { get; set; }
        public string org_code { get; set; }
        public string from_org_code { get; set; }
        public string from_org_name { get; set; }
        public string to_org_code { get; set; }
        public string to_org_name { get; set; }
        public string enterprise_type { get; set; }
        public string enterprise_area { get; set; }
        public string oper_ic_code { get; set; }
        public string data_type { get; set; }
        public string drug_list_json { get; set; }
    }
    public class BillDetailData
    {
        public string code_type { get; set; }
        public string code { get; set; }
        public string physic_info { get; set; }
        public string pkg_spec { get; set; }
        public string packing_unit { get; set; }
        public string approval_licence_no { get; set; }
        public string produce_batch_no { get; set; }
        public string produce_date { get; set; }
        public string exprie_date { get; set; }
        public string code_count { get; set; }
    }
}
