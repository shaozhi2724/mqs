using DevExpress.XtraEditors;
using DQS.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DQS.App
{
    public partial class FrmCreateXml : XtraForm
    {
        public FrmCreateXml()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //获取当前时间
            string dateStr = DateTime.Now.ToString("yyyy-MM-dd");
            //判断是否有未对应的数据
            if (canCreateXml(dateStr))
            {

                //生成入库
                string sql = @"SELECT ap.CenterVarietyCode,isd.BatchNo,ISNULL(CONVERT(NVARCHAR(20),isd.ValidateDate,120),'') AS ValidateDate,p.PackageSpec,p.ProductUnit,isd.InAmount AS Amount,ISNULL(CONVERT(NVARCHAR(20),isd.InStoreDate,120),'') AS StoreDate,isd.InStoreCode AS StoreCode,ISNULL((SELECT TOP 1 REPLACE(ISNULL(q.CertificateNo,''),'统一社会信用代码','') FROM dbo.BFI_Qualification q WHERE q.BelongTable = 'BFI_Dealer' AND q.BelongID = isd.UpDealerID AND q.CertificateStyle = '营业执照'),'') I_MER_CODE,d.DealerName,ISNULL(z.ZoneCoding,'') ZoneCoding,'1' AS BILL_TYPE
FROM dbo.BUS_InStoreDetail isd
INNER JOIN dbo.BFI_Product p ON isd.ProductID = p.ProductID
INNER JOIN dbo.BFI_AllProduct ap ON p.AllProductID = ap.ID
INNER JOIN dbo.BFI_Dealer d ON isd.UpDealerID = d.DealerID
LEFT JOIN dbo.BFI_Zone z ON d.ZoneID = z.ID
WHERE p.Reservation1 = 1 and isd.StoreTypeName = '采购进货'
AND isd.InStoreDate >= '" + dateStr + " 00:00:00' AND isd.InStoreDate <= '" + dateStr + @" 23:59:59'
UNION
SELECT ap.CenterVarietyCode,isd.BatchNo,ISNULL(CONVERT(NVARCHAR(20),isd.ValidateDate,120),'') AS ValidateDate,p.PackageSpec,p.ProductUnit,isd.InAmount AS Amount,ISNULL(CONVERT(NVARCHAR(20),isd.InStoreDate,120),'') AS StoreDate,isd.InStoreCode AS StoreCode,'' I_MER_CODE,'' DealerName,'' ZoneCoding,'4' AS BILL_TYPE
FROM dbo.BUS_InStoreDetail isd
INNER JOIN dbo.BFI_Product p ON isd.ProductID = p.ProductID
INNER JOIN dbo.BFI_AllProduct ap ON p.AllProductID = ap.ID
--INNER JOIN dbo.BFI_Dealer d ON isd.UpDealerID = d.DealerID
--LEFT JOIN dbo.BFI_Zone z ON d.ZoneID = z.ID
WHERE p.Reservation1 = 1 and isd.StoreTypeName = '盘盈'
AND isd.InStoreDate >= '" + dateStr + " 00:00:00' AND isd.InStoreDate <= '" + dateStr + @" 23:59:59'
UNION 
SELECT ap.CenterVarietyCode,osd.BatchNo,ISNULL(CONVERT(NVARCHAR(20),osd.ValidateDate,120),'') AS ValidateDate,p.PackageSpec,p.ProductUnit,-osd.OutAmount AS Amount,ISNULL(CONVERT(NVARCHAR(20),osd.OutStoreDate,120),'') StoreDate,osd.OutStoreCode AS StoreCode,ISNULL((SELECT TOP 1 REPLACE(ISNULL(q.CertificateNo,''),'统一社会信用代码','') FROM dbo.BFI_Qualification q WHERE q.BelongTable = 'BFI_Dealer' AND q.BelongID = osd.DownDealerID AND q.CertificateStyle = '营业执照'),'') I_MER_CODE,d.DealerName,ISNULL(z.ZoneCoding,'') ZoneCoding,'2' AS BILL_TYPE
FROM dbo.BUS_OutStoreDetail osd
INNER JOIN dbo.BFI_Product p ON osd.ProductID = p.ProductID
INNER JOIN dbo.BFI_AllProduct ap ON p.AllProductID = ap.ID
INNER JOIN dbo.BFI_Dealer d ON osd.DownDealerID = d.DealerID
LEFT JOIN dbo.BFI_Zone z ON d.ZoneID = z.ID
WHERE p.Reservation1 = 1 and osd.StoreTypeName = '采购退货'
AND osd.OutStoreDate >= '" + dateStr + " 00:00:00' AND osd.OutStoreDate <= '" + dateStr + " 23:59:59'";
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    try
                    {
                        sda.Fill(ds, "Table");
                        DataTable dt = ds.Tables["Table"];
                        if (dt.Rows.Count > 0)
                        {
                            CreateInXML(dt, txtPath.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                //生成出库
                string outsql = @"
SELECT ap.CenterVarietyCode,isd.BatchNo,ISNULL(CONVERT(NVARCHAR(20),isd.ValidateDate,120),'') AS ValidateDate,p.PackageSpec,p.ProductUnit,-isd.InAmount AS Amount,ISNULL(CONVERT(NVARCHAR(20),isd.InStoreDate,120),'') AS StoreDate,isd.InStoreCode AS StoreCode,ISNULL((SELECT TOP 1 REPLACE(ISNULL(q.CertificateNo,''),'统一社会信用代码','') FROM dbo.BFI_Qualification q WHERE q.BelongTable = 'BFI_Dealer' AND q.BelongID = isd.UpDealerID AND q.CertificateStyle = CASE WHEN d.IndustryStyle = '医疗机构' THEN '医疗机构许可证' ELSE '营业执照' END),'') I_MER_CODE,d.DealerName,ISNULL(z.ZoneCoding,'') ZoneCoding,'2' AS BILL_TYPE
FROM dbo.BUS_InStoreDetail isd
INNER JOIN dbo.BFI_Product p ON isd.ProductID = p.ProductID
INNER JOIN dbo.BFI_AllProduct ap ON p.AllProductID = ap.ID
INNER JOIN dbo.BFI_Dealer d ON isd.UpDealerID = d.DealerID
LEFT JOIN dbo.BFI_Zone z ON d.ZoneID = z.ID
WHERE p.Reservation1 = 1 and isd.StoreTypeName = '销售退货'
AND isd.InStoreDate >= '" + dateStr + " 00:00:00' AND isd.InStoreDate <= '" + dateStr + @" 23:59:59'
UNION
SELECT ap.CenterVarietyCode,osd.BatchNo,ISNULL(CONVERT(NVARCHAR(20),osd.ValidateDate,120),'') AS ValidateDate,p.PackageSpec,p.ProductUnit,osd.OutAmount AS Amount,ISNULL(CONVERT(NVARCHAR(20),osd.OutStoreDate,120),'') AS StoreDate,osd.OutStoreCode AS StoreCode,'' I_MER_CODE,'' DealerName,'' ZoneCoding,'5' AS BILL_TYPE
FROM dbo.BUS_OutStoreDetail osd
INNER JOIN dbo.BFI_Product p ON osd.ProductID = p.ProductID
INNER JOIN dbo.BFI_AllProduct ap ON p.AllProductID = ap.ID
WHERE p.Reservation1 = 1 and osd.StoreTypeName = '盘亏'
AND osd.OutStoreDate >= '" + dateStr + " 00:00:00' AND osd.OutStoreDate <= '" + dateStr + @" 23:59:59'
UNION 
SELECT ap.CenterVarietyCode,osd.BatchNo,ISNULL(CONVERT(NVARCHAR(20),osd.ValidateDate,120),'') AS ValidateDate,p.PackageSpec,p.ProductUnit,osd.OutAmount AS Amount,ISNULL(CONVERT(NVARCHAR(20),osd.OutStoreDate,120),'') StoreDate,osd.OutStoreCode AS StoreCode,ISNULL((SELECT TOP 1 REPLACE(ISNULL(q.CertificateNo,''),'统一社会信用代码','') FROM dbo.BFI_Qualification q WHERE q.BelongTable = 'BFI_Dealer' AND q.BelongID = osd.DownDealerID AND q.CertificateStyle = CASE WHEN d.IndustryStyle = '医疗机构' THEN '医疗机构许可证' ELSE '营业执照' END),'') I_MER_CODE,d.DealerName,ISNULL(z.ZoneCoding,'') ZoneCoding,'1' AS BILL_TYPE
FROM dbo.BUS_OutStoreDetail osd
INNER JOIN dbo.BFI_Product p ON osd.ProductID = p.ProductID
INNER JOIN dbo.BFI_AllProduct ap ON p.AllProductID = ap.ID
INNER JOIN dbo.BFI_Dealer d ON osd.DownDealerID = d.DealerID
LEFT JOIN dbo.BFI_Zone z ON d.ZoneID = z.ID
WHERE p.Reservation1 = 1 and osd.StoreTypeName = '销售出货'
AND osd.OutStoreDate >= '" + dateStr + " 00:00:00' AND osd.OutStoreDate <= '" + dateStr + " 23:59:59'";
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(outsql, conn);
                    DataSet ds = new DataSet();
                    try
                    {
                        sda.Fill(ds, "Table");
                        DataTable dt = ds.Tables["Table"];
                        if (dt.Rows.Count > 0)
                        {
                            CreateOutXML(dt, txtPath.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                //生成库存
                string initsql = @"SELECT ap.CenterVarietyCode,p.ProductBarCode,v.批号,CONVERT(NVARCHAR(60),v.有效期至,120) AS 有效期至,p.PackageSpec,p.ProductUnit,v.库存数量,GETDATE() AS JZ_DATE FROM dbo.vw_NewProductStoreDetail v
INNER JOIN dbo.BFI_Product p ON v.产品ID = p.ProductID
INNER JOIN dbo.BFI_AllProduct ap ON p.AllProductID = ap.ID where  p.Reservation1 = 1";
                using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(initsql, conn);
                    DataSet ds = new DataSet();
                    try
                    {
                        sda.Fill(ds, "Table");
                        DataTable dt = ds.Tables["Table"];
                        if (dt.Rows.Count > 0)
                        {
                            CreateInitXML(dt, txtPath.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }


                XtraMessageBox.Show("生成完毕", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("请完成今日数据匹配", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool canCreateXml(string dateStr)
        {
            bool can = false;

            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string dsql = @"SELECT COUNT(DISTINCT d.DealerID) num FROM dbo.BUS_StoreBill sb 
INNER JOIN dbo.BFI_Dealer d ON sb.DealerID = d.DealerID
WHERE sb.StoreDate >= '" + dateStr + " 00:00:00' AND sb.StoreDate <= '" + dateStr + " 23:59:59' AND d.ZoneID IS NULL";
                string psql = @"SELECT COUNT(DISTINCT p.ProductID) num FROM dbo.BUS_StoreBill sb 
INNER JOIN dbo.BUS_StoreBillDetail sbd ON sb.StoreID = sbd.StoreID
INNER JOIN dbo.BFI_Product p ON sbd.ProductID = p.ProductID
WHERE p.Reservation1 = 1 and sb.StoreDate >= '" + dateStr + " 00:00:00' AND sb.StoreDate <= '" + dateStr + " 23:59:59' AND p.AllProductID IS NULL";
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(dsql, conn);
                    SqlCommand command = new SqlCommand(psql, conn);
                    int dcount = int.Parse(comm.ExecuteScalar().ToString());
                    int pcount = int.Parse(command.ExecuteScalar().ToString());
                    if (dcount == 0 && pcount == 0)
                    {
                        can = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
            return can;
        }

        public void CreateInXML(DataTable dt,string pathName)
        {
            try
            {
                string fileName = "k_in_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_" + txtSenderId.Text + "#" + txtSoftType.Text + ".xml";

                FileStream fileStream = new FileStream(pathName+fileName, FileMode.Create);
                XmlTextWriter writer = new XmlTextWriter(fileStream, Encoding.UTF8);

                writer.WriteStartDocument();
                writer.WriteStartElement("SIGNATURE");
                writer.WriteAttributeString("xmlns", "www.hebfdea.com");
                    writer.WriteStartElement("OBJECT");
                    writer.WriteStartElement("PACKAGE");

                
                    writer.WriteStartElement("ENVELOPINFO");
                        writer.WriteStartElement("VERSION");
                        writer.WriteValue(txtVersion.Text); 
                        writer.WriteEndElement();
                        writer.WriteStartElement("MESSAGE_ID");
                        writer.WriteValue(Guid.NewGuid().ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("FILE_NAME");
                        writer.WriteValue(fileName);
                        writer.WriteEndElement();
                        writer.WriteStartElement("MESSAGE_TYPE"); 
                        writer.WriteValue("in");
                        writer.WriteEndElement();
                        writer.WriteStartElement("SENDER_ID");
                        writer.WriteValue(txtSenderId.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("SEND_TIME");
                        writer.WriteValue(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                        writer.WriteEndElement();
                        writer.WriteStartElement("RECEIVER_ID");
                        writer.WriteValue(txtReceiverId.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("SOFTTYPE");
                        writer.WriteValue(txtSoftType.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("SENDERNAME");
                        writer.WriteValue(txtSendName.Text);
                        writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteStartElement("DATAINFO");

                    foreach (DataRow dr in dt.Rows){
                        writer.WriteStartElement("ROWINFO");
                            writer.WriteStartElement("I_ITEM_CODE");//中心品种编码
                            writer.WriteValue(dr["CenterVarietyCode"].ToString().Trim());
                            writer.WriteEndElement();
                            writer.WriteStartElement("YPPH");
                            writer.WriteValue(dr["BatchNo"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("VDATE");
                            writer.WriteValue(dr["ValidateDate"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("PACKAGE");
                            writer.WriteValue(dr["PackageSpec"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("UNIT");
                            writer.WriteValue(dr["ProductUnit"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("NUM");
                            writer.WriteValue(dr["Amount"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("JZ_DATE");
                            writer.WriteValue(dr["StoreDate"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("FPH");
                            writer.WriteValue(dr["StoreCode"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("I_MER_CODE");
                            writer.WriteValue(dr["I_MER_CODE"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("MER_NAME");
                            writer.WriteValue(dr["DealerName"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("MERA_CODE");
                            writer.WriteValue(dr["ZoneCoding"].ToString());
                            writer.WriteEndElement();
                            writer.WriteStartElement("BILL_TYPE");
                            writer.WriteValue(dr["BILL_TYPE"].ToString());
                            writer.WriteEndElement();

                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                fileStream.Close();
            }
            catch (Exception)
            {}
        }

        public void CreateOutXML(DataTable dt, string pathName)
        {
            try
            {
                string fileName = "k_out_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_" + txtSenderId.Text + "#" + txtSoftType.Text + ".xml";

                FileStream fileStream = new FileStream(pathName + fileName, FileMode.Create);
                XmlTextWriter writer = new XmlTextWriter(fileStream, Encoding.UTF8);

                writer.WriteStartDocument();
                writer.WriteStartElement("SIGNATURE");
                writer.WriteAttributeString("xmlns", "www.hebfdea.com");
                writer.WriteStartElement("OBJECT");
                writer.WriteStartElement("PACKAGE");


                writer.WriteStartElement("ENVELOPINFO");
                writer.WriteStartElement("VERSION");
                writer.WriteValue(txtVersion.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("MESSAGE_ID");
                writer.WriteValue(Guid.NewGuid().ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("FILE_NAME");
                writer.WriteValue(fileName);
                writer.WriteEndElement();
                writer.WriteStartElement("MESSAGE_TYPE");
                writer.WriteValue("out");
                writer.WriteEndElement();
                writer.WriteStartElement("SENDER_ID");
                writer.WriteValue(txtSenderId.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("SEND_TIME");
                writer.WriteValue(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                writer.WriteEndElement();
                writer.WriteStartElement("RECEIVER_ID");
                writer.WriteValue(txtReceiverId.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("SOFTTYPE");
                writer.WriteValue(txtSoftType.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("SENDERNAME");
                writer.WriteValue(txtSendName.Text);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteStartElement("DATAINFO");

                foreach (DataRow dr in dt.Rows)
                {
                    writer.WriteStartElement("ROWINFO");
                    writer.WriteStartElement("I_ITEM_CODE");//中心品种编码
                    writer.WriteValue(dr["CenterVarietyCode"].ToString().Trim());
                    writer.WriteEndElement();
                    writer.WriteStartElement("YPPH");
                    writer.WriteValue(dr["BatchNo"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("VDATE");
                    writer.WriteValue(dr["ValidateDate"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("PACKAGE");
                    writer.WriteValue(dr["PackageSpec"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("UNIT");
                    writer.WriteValue(dr["ProductUnit"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("NUM");
                    writer.WriteValue(dr["Amount"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("JZ_DATE");
                    writer.WriteValue(dr["StoreDate"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("FPH");
                    writer.WriteValue(dr["StoreCode"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("I_MER_CODE");
                    writer.WriteValue(dr["I_MER_CODE"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("MER_NAME");
                    writer.WriteValue(dr["DealerName"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("MERA_CODE");
                    writer.WriteValue(dr["ZoneCoding"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("BILL_TYPE");
                    writer.WriteValue(dr["BILL_TYPE"].ToString());
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                fileStream.Close();
            }
            catch (Exception)
            { }
        }

        public void CreateInitXML(DataTable dt, string pathName)
        {
            try
            {
                string fileName = "k_init_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_" + txtSenderId.Text + "#" + txtSoftType.Text + ".xml";

                FileStream fileStream = new FileStream(pathName + fileName, FileMode.Create);
                XmlTextWriter writer = new XmlTextWriter(fileStream, Encoding.UTF8);

                writer.WriteStartDocument();
                writer.WriteStartElement("SIGNATURE");
                writer.WriteAttributeString("xmlns", "www.hebfdea.com");
                writer.WriteStartElement("OBJECT");
                writer.WriteStartElement("PACKAGE");


                writer.WriteStartElement("ENVELOPINFO");
                writer.WriteStartElement("VERSION");
                writer.WriteValue(txtVersion.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("MESSAGE_ID");
                writer.WriteValue(Guid.NewGuid().ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("FILE_NAME");
                writer.WriteValue(fileName);
                writer.WriteEndElement();
                writer.WriteStartElement("MESSAGE_TYPE");
                writer.WriteValue("init");
                writer.WriteEndElement();
                writer.WriteStartElement("SENDER_ID");
                writer.WriteValue(txtSenderId.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("SEND_TIME");
                writer.WriteValue(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                writer.WriteEndElement();
                writer.WriteStartElement("RECEIVER_ID");
                writer.WriteValue(txtReceiverId.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("SOFTTYPE");
                writer.WriteValue(txtSoftType.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("SENDERNAME");
                writer.WriteValue(txtSendName.Text);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteStartElement("DATAINFO");

                foreach (DataRow dr in dt.Rows)
                {
                    writer.WriteStartElement("ROWINFO");
                    writer.WriteStartElement("I_ITEM_CODE");//中心品种编码
                    writer.WriteValue(dr["CenterVarietyCode"].ToString().Trim());
                    writer.WriteEndElement();
                    writer.WriteStartElement("BARCODE");
                    writer.WriteValue(dr["ProductBarCode"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("YPPH");
                    writer.WriteValue(dr["批号"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("VDATE");
                    writer.WriteValue(dr["有效期至"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("PACKAGE");
                    writer.WriteValue(dr["PackageSpec"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("UNIT");
                    writer.WriteValue(dr["ProductUnit"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("NUM");
                    writer.WriteValue(dr["库存数量"].ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("JZ_DATE");
                    writer.WriteValue(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                fileStream.Close();
            }
            catch (Exception)
            { }
        }

        private void btnCheckProduct_Click(object sender, EventArgs e)
        {
            using (FrmProductCheck frm = new FrmProductCheck())
            {
                frm.ShowDialog();
            }
        }

        private void btnZoneCheck_Click(object sender, EventArgs e)
        {
            using (FrmCheckZone frm = new FrmCheckZone())
            {
                frm.ShowDialog();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            if (hour == txthour.Text && minute == txtmin.Text)
            {
                btnCreate_Click(null, null);
            }
        }
    }
}
