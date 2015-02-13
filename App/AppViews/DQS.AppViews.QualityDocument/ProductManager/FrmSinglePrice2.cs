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

namespace DQS.AppViews.QualityDocument.ProductManager
{
    public partial class FrmSinglePrice2 : DevExpress.XtraEditors.XtraForm
    {
        private int? m_ProductID;
        private DataTable m_OldData;

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

                if (data.Rows.Count > 0)
                {
                    this.txtPopupProduct.SetMemberValue(this.m_ProductID);
                    this.txtPopupProduct.Enabled = false;

                    //进货价
                    DataRow[] rows = data.Select("PriceID = 1");
                    if (rows.Length > 0)
                    {
                        this.txtJHJ.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //批发价
                    rows = data.Select("PriceID = 2");
                    if (rows.Length > 0)
                    {
                        this.txtPFJ.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //零售价
                    rows = data.Select("PriceID = 3");
                    if (rows.Length > 0)
                    {
                        this.txtLSJ.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //会员价
                    rows = data.Select("PriceID = 4");
                    if (rows.Length > 0)
                    {
                        this.txtHYJ.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //销价一
                    rows = data.Select("PriceID = 5");
                    if (rows.Length > 0)
                    {
                        this.txtXJ1.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //销价二
                    rows = data.Select("PriceID = 6");
                    if (rows.Length > 0)
                    {
                        this.txtXJ2.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //销价三
                    rows = data.Select("PriceID = 7");
                    if (rows.Length > 0)
                    {
                        this.txtXJ3.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //销价四
                    rows = data.Select("PriceID = 8");
                    if (rows.Length > 0)
                    {
                        this.txtXJ4.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //销价五
                    rows = data.Select("PriceID = 9");
                    if (rows.Length > 0)
                    {
                        this.txtXJ5.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //销价六
                    rows = data.Select("PriceID = 10");
                    if (rows.Length > 0)
                    {
                        this.txtXJ6.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                    //销价七
                    rows = data.Select("PriceID = 11");
                    if (rows.Length > 0)
                    {
                        this.txtXJ7.Value = Convert.ToDecimal(rows[0]["Price"].ToString());
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ftPanel.ValidateIsNullFields()) return;

            if (this.m_ProductID != null)
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
                //-----------------------邪恶的分割线--------------------------//
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
                    XtraMessageBox.Show("该药品的价格信息已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}