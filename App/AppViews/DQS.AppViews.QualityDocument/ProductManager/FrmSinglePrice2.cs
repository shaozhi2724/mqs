using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DQS.Module.Entities;
using ORMSCore;
using DQS.Common;
using System.Data.SqlClient;

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSinglePrice2 : DevExpress.XtraEditors.XtraForm
    {
        private int? m_ProductID;
        private DataTable m_OldData;

        List<ViewPriceID> oldId = new List<ViewPriceID>();
        List<ViewPriceID> newId = new List<ViewPriceID>();

        public FrmSinglePrice2()
        {
            InitializeComponent();
        }

        public FrmSinglePrice2(int productID)
        {
            InitializeComponent();
            this.m_ProductID = productID;
        }

        public FrmSinglePrice2(int productID,string productName)
        {
            InitializeComponent();
            this.txtPopupProduct.SetMemberValue(productID);
            this.txtPopupProduct.Text = productName;
            this.txtPopupProduct.Enabled = false;

            //判定是新建还是编辑
            EntityCollection<BFIProductPriceEntity> prices = new EntityCollection<BFIProductPriceEntity>();
            DataTable data = prices.FetchTable(BFIProductPriceEntityFields.ProductID == productID);
            if (data.Rows.Count > 0)
            {
                this.m_ProductID = productID;
            }
        }

        private void FrmSinglePrice2_Load(object sender, EventArgs e)
        {
            if (this.m_ProductID != null)
            {
                EntityCollection<BFIProductPriceEntity> prices = new EntityCollection<BFIProductPriceEntity>();
                DataTable data = prices.FetchTable(BFIProductPriceEntityFields.ProductID == this.m_ProductID);
                this.m_OldData = data;
                ViewPriceID vpi;
                if (data.Rows.Count > 0)
                {
                    this.txtPopupProduct.SetMemberValue(this.m_ProductID);
                    this.txtPopupProduct.Enabled = false;

                    //进货价
                    DataRow[] rows = data.Select("PriceID = 1");
                    if (rows.Length > 0)
                    {
                        this.txtJHJ.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 1;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //批发价
                    rows = data.Select("PriceID = 2");
                    if (rows.Length > 0)
                    {
                        this.txtPFJ.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 2;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //零售价
                    rows = data.Select("PriceID = 3");
                    if (rows.Length > 0)
                    {
                        this.txtLSJ.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 3;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //会员价
                    rows = data.Select("PriceID = 4");
                    if (rows.Length > 0)
                    {
                        this.txtHYJ.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 4;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //销价一
                    rows = data.Select("PriceID = 5");
                    if (rows.Length > 0)
                    {
                        this.txtXJ1.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 5;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //销价二
                    rows = data.Select("PriceID = 6");
                    if (rows.Length > 0)
                    {
                        this.txtXJ2.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 6;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //销价三
                    rows = data.Select("PriceID = 7");
                    if (rows.Length > 0)
                    {
                        this.txtXJ3.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 7;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //销价四
                    rows = data.Select("PriceID = 8");
                    if (rows.Length > 0)
                    {
                        this.txtXJ4.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 8;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //销价五
                    rows = data.Select("PriceID = 9");
                    if (rows.Length > 0)
                    {
                        this.txtXJ5.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 9;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //销价六
                    rows = data.Select("PriceID = 10");
                    if (rows.Length > 0)
                    {
                        this.txtXJ6.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 10;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                    //销价七
                    rows = data.Select("PriceID = 11");
                    if (rows.Length > 0)
                    {
                        this.txtXJ7.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                        vpi = new ViewPriceID();
                        vpi.PriceID = 11;
                        vpi.Price = Convert.ToDecimal(rows[0]["Price"].ToString());
                        oldId.Add(vpi);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            if (this.m_ProductID != null)
            {
                if (GlobalItem.g_CurrentUser.UserCode == "admin")
                {
                    //更新，存在调价记录
                    BFIProductPriceEntity entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 1;
                    entity.Price = Convert.ToDouble(this.txtJHJ.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    BFIProductPriceHistoryEntity entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //进货价
                        DataRow[] rows = this.m_OldData.Select("PriceID = 1");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 1;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtJHJ.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 2;
                    entity.Price = Convert.ToDouble(this.txtPFJ.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //批发价
                        DataRow[] rows = this.m_OldData.Select("PriceID = 2");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 2;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtPFJ.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 3;
                    entity.Price = Convert.ToDouble(this.txtLSJ.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //零售价
                        DataRow[] rows = this.m_OldData.Select("PriceID = 3");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 3;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtLSJ.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 4;
                    entity.Price = Convert.ToDouble(this.txtHYJ.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //会员价
                        DataRow[] rows = this.m_OldData.Select("PriceID = 4");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 4;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtHYJ.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 5;
                    entity.Price = Convert.ToDouble(this.txtXJ1.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //销价一
                        DataRow[] rows = this.m_OldData.Select("PriceID = 5");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 5;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtXJ1.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 6;
                    entity.Price = Convert.ToDouble(this.txtXJ2.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //销价二
                        DataRow[] rows = this.m_OldData.Select("PriceID = 6");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 6;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtXJ2.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 7;
                    entity.Price = Convert.ToDouble(this.txtXJ3.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //销价三
                        DataRow[] rows = this.m_OldData.Select("PriceID = 7");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 7;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtXJ3.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 8;
                    entity.Price = Convert.ToDouble(this.txtXJ4.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //销价四
                        DataRow[] rows = this.m_OldData.Select("PriceID = 8");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 8;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtXJ4.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 9;
                    entity.Price = Convert.ToDouble(this.txtXJ5.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //销价五
                        DataRow[] rows = this.m_OldData.Select("PriceID = 9");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 9;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtXJ5.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 10;
                    entity.Price = Convert.ToDouble(this.txtXJ6.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //销价六
                        DataRow[] rows = this.m_OldData.Select("PriceID = 10");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 10;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtXJ6.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                    //-----------------------邪恶的分割线--------------------------//
                    entity = new BFIProductPriceEntity();
                    entity.ProductID = this.m_ProductID.Value;
                    entity.PriceID = 11;
                    entity.Price = Convert.ToDouble(this.txtXJ7.Value);
                    entity.LastModifyDate = DateTime.Now;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.Update();

                    entityHistory = new BFIProductPriceHistoryEntity();
                    if (this.m_OldData.Rows.Count > 0)
                    {
                        //销价七
                        DataRow[] rows = this.m_OldData.Select("PriceID = 11");
                        if (rows.Length > 0)
                        {
                            entityHistory.OldPrice = Convert.ToDouble(rows[0]["Price"]);
                        }
                    }
                    entityHistory.ProductID = this.m_ProductID.Value;
                    entityHistory.PriceID = 11;
                    entityHistory.NewPrice = Convert.ToDouble(this.txtXJ7.Value);
                    entityHistory.CreateDate = DateTime.Now;
                    entityHistory.LastModifyDate = DateTime.Now;
                    entityHistory.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entityHistory.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    //调价则记录
                    if (entityHistory.IsNullField("OldPrice") || entityHistory.OldPrice != entityHistory.NewPrice)
                    {
                        entityHistory.Save();
                    }
                }
                else
                {
                    ViewPriceID vpi;
                    vpi = new ViewPriceID();
                    vpi.PriceID = 1;
                    vpi.Price = Convert.ToDecimal(this.txtJHJ.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 2;
                    vpi.Price = Convert.ToDecimal(this.txtPFJ.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 3;
                    vpi.Price = Convert.ToDecimal(this.txtLSJ.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 4;
                    vpi.Price = Convert.ToDecimal(this.txtHYJ.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 5;
                    vpi.Price = Convert.ToDecimal(this.txtXJ1.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 6;
                    vpi.Price = Convert.ToDecimal(this.txtXJ2.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 7;
                    vpi.Price = Convert.ToDecimal(this.txtXJ3.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 8;
                    vpi.Price = Convert.ToDecimal(this.txtXJ4.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 9;
                    vpi.Price = Convert.ToDecimal(this.txtXJ5.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 10;
                    vpi.Price = Convert.ToDecimal(this.txtXJ6.Value);
                    newId.Add(vpi);
                    vpi = new ViewPriceID();
                    vpi.PriceID = 11;
                    vpi.Price = Convert.ToDecimal(this.txtXJ7.Value);
                    newId.Add(vpi);


                    if (CheckList(oldId, newId))
                    {
                        MessageBox.Show("没有任何修改。");
                    }
                    else
                    {
                        EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                        PredicateExpression pe = new PredicateExpression();
                        pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                        pe.Add(ATCUserPageEntityFields.DocumentCode == "ProductPriceChange");
                        DataTable data = userPages.FetchTable(pe);

                        if (data.Rows.Count <= 0)
                        {
                            XtraMessageBox.Show("系统未设置您的审批流程，无法点击保存功能。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
                        {
                            string sql = @"SELECT COUNT(0) num FROM dbo.BUS_ProductPriceChange WHERE ProductID = " + this.m_ProductID.Value + " AND AppStatus = ''";

                            try
                            {
                                conn.Open();
                                SqlCommand comm = new SqlCommand(sql, conn);
                                int num = int.Parse(comm.ExecuteScalar().ToString());
                                if (num > 0)
                                {
                                    MessageBox.Show("有申请变更未处理，请处理后操作。");
                                    return;
                                }
                                else
                                {
                                    string code = "JG" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                    string insertsql = @"EXEC sp_InsertOldProductPriceChange '{0}',{1},'{2}'";
                                    insertsql = string.Format(insertsql, code,this.m_ProductID.Value, GlobalItem.g_CurrentUser.UserName);
                                    comm = new SqlCommand(insertsql, conn);
                                    comm.ExecuteNonQuery();
                                    foreach (var item in newId)
                                    {
                                        string insertnewsql = @"EXEC sp_InsertNewProductPriceChange '{0}',{1},{2},{3}";
                                        comm = new SqlCommand(string.Format(insertnewsql, code, this.m_ProductID.Value,item.PriceID,item.Price), conn);
                                        comm.ExecuteNonQuery();
                                    }

                                    if (data.Rows.Count > 0)
                                    {
                                        //按审批顺序排序
                                        data.DefaultView.Sort = "ApprovalSort";
                                        data = data.DefaultView.ToTable();

                                        ATCApproveEntity approveEntity = new ATCApproveEntity();
                                        approveEntity.InternalNo = code;
                                        approveEntity.DocumentCode = "ProductPriceChange";
                                        approveEntity.BillCode = code;
                                        approveEntity.ApproveTitle = string.Format("产品价格信息变更，编号：{0}", code);
                                        approveEntity.ApprovalContent = String.Format("角色浏览权限变更，编号：{0}", code);
                                        approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                                        approveEntity.CreateDate = DateTime.Now;
                                        approveEntity.IsApprovaled = false;


                                        //获得新建的ID号
                                        string searchsql = @"SELECT ID FROM BUS_ProductPriceChange WHERE ChangeCode = '" + code + "'";
                                        comm = new SqlCommand(searchsql, conn);
                                        int bgid = int.Parse(comm.ExecuteScalar().ToString());

                                        for (int i = 0; i < data.Rows.Count; i++)
                                        {
                                            var approveCode = approveEntity.InternalNo + (i + 1).ToString("00");
                                            approveEntity.ApproveCode = approveCode;
                                            approveEntity.IsWhole = Convert.ToBoolean(data.Rows[i]["IsWhole"]);
                                            approveEntity.ApproveOrder = Convert.ToInt32(data.Rows[i]["ApprovalSort"]);
                                            var approvalUserId = new Guid(data.Rows[i]["ApprovalUserID"].ToString());
                                            approveEntity.ApprovalUserID = approvalUserId;
                                            approveEntity.Save();

                                            //添加消息提醒
                                            ATCApproveNotificationEntity notification = new ATCApproveNotificationEntity();
                                            notification.CreateUserID = approveEntity.CreateUserID;
                                            var userName = GlobalItem.g_CurrentEmployee == null
                                                ? GlobalItem.g_CurrentUser.UserName
                                                : GlobalItem.g_CurrentEmployee.EmployeeName;
                                            notification.CreateUserName = userName;
                                            notification.FormClass = "ProductPriceChange";
                                            notification.IsRead = false;
                                            notification.TargetID = bgid;
                                            notification.TargetCode = code;
                                            notification.ApproveCode = approveCode;
                                            notification.Message = string.Format("{0} 于 {1} 价格信息变更申请（单号 {2}）。请您审批。", userName,
                                                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), code);
                                            notification.OwnerUserID = approvalUserId;
                                            notification.Save();
                                        }
                                    }

                                    MessageBox.Show("变更申请保存成功。");
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
                    }
                }
            }
            else
            { 
                //添加
                BFIProductPriceEntity entity = new BFIProductPriceEntity();
                entity.ProductID = Convert.ToInt32(txtPopupProduct.SelectedValue);
                if (entity.IsNew(BFIProductPriceEntityFields.ProductID == entity.ProductID))
                {
                    entity.CreateDate = DateTime.Now;
                    entity.LastModifyDate = DateTime.Now;
                    entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;

                    entity.PriceID = 1;
                    entity.Price = Convert.ToDouble(this.txtJHJ.Value);
                    entity.Save();

                    entity.PriceID = 2;
                    entity.Price = Convert.ToDouble(this.txtPFJ.Value);
                    entity.Save();

                    entity.PriceID = 3;
                    entity.Price = Convert.ToDouble(this.txtLSJ.Value);
                    entity.Save();

                    entity.PriceID = 4;
                    entity.Price = Convert.ToDouble(this.txtHYJ.Value);
                    entity.Save();

                    entity.PriceID = 5;
                    entity.Price = Convert.ToDouble(this.txtXJ1.Value);
                    entity.Save();

                    entity.PriceID = 6;
                    entity.Price = Convert.ToDouble(this.txtXJ2.Value);
                    entity.Save();

                    entity.PriceID = 7;
                    entity.Price = Convert.ToDouble(this.txtXJ3.Value);
                    entity.Save();

                    entity.PriceID = 8;
                    entity.Price = Convert.ToDouble(this.txtXJ4.Value);
                    entity.Save();

                    entity.PriceID = 9;
                    entity.Price = Convert.ToDouble(this.txtXJ5.Value);
                    entity.Save();

                    entity.PriceID = 10;
                    entity.Price = Convert.ToDouble(this.txtXJ6.Value);
                    entity.Save();

                    entity.PriceID = 11;
                    entity.Price = Convert.ToDouble(this.txtXJ7.Value);
                    entity.Save();
                }
                else
                {
                    XtraMessageBox.Show("该产品的价格信息已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private bool CheckList(List<ViewPriceID> lista, List<ViewPriceID> listb)
        {
            bool isall = true;
            foreach (var item in lista)
            {
                foreach (var itemb in listb)
                {
                    if (itemb.PriceID == item.PriceID && itemb.Price != item.Price)
                    {
                        isall = false;
                        return isall;
                    }
                }
            }
            foreach (var item in listb)
            {
                foreach (var itema in lista)
                {
                    if (itema.PriceID == item.PriceID && itema.Price != item.Price)
                    {
                        isall = false;
                        return isall;
                    }
                }
            }
            return isall;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class ViewPriceID
    {
        public int PriceID { get; set; }
        public decimal Price { get; set; }
    }
}