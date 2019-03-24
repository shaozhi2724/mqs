using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DQS.AppViews.Operation.Properties;
using DQS.Common;
using DQS.Module;
using DQS.Module.Entities;
using DQS.Module.Views;
using ORMSCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DQS.AppViews.Operation.PurchaseAndSaleManager
{
    public partial class FrmSingleOutSale : XtraForm
    {

        List<GetDepartment> departments = new List<GetDepartment>();
        GetDepartment department = new GetDepartment();
        string operators = "";

        List<int> productids = new List<int>();

        List<OutSaleViewDetail> outlist = new List<OutSaleViewDetail>();
        string _amountErrors = "";
        int isfrist = 0;


        public FrmSingleOutSale()
        {
            InitializeComponent();
        }
        private void FrmSingleOutSale_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = outlist;
            if (Settings.Default.IsUseDepartment)
            {
                this.layDepartment.Visibility = LayoutVisibility.Always;
                LoadDepartment();
            }

            this.cbxDeliveryType.InitSource();
            this.cbxPaymentType.InitSource();
            BindArea();

            if (this.Tag != null)
            {
                int id = Convert.ToInt32(this.Tag);

                LoadViewOut(id);

                if (!Settings.Default.SettingBusinessPersonISNULL)
                {
                    if (GlobalItem.g_CurrentEmployee != null)
                    {
                        this.txtOperator.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                        txtOperator.SetMemberValue(GlobalItem.g_CurrentEmployee.EmployeeID);
                    }
                }
                this.txtReservation6.Text = GlobalItem.g_CurrentEmployee.EmployeeName;
                this.txtBillCode.Text = GlobalMethod.GenSaleBillCode("XS");
                GetDealerNameInfo();
                GetOutBillDetails(id);
            }
            else
            {
                MessageBox.Show("Tag is null");
            }
        }
        private void GetOutBillDetails(int billid)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"
SELECT ProductID,产品编码,产品名称,包装规格,数量,单价,金额 FROM vw_OutBillDetails WHERE BillID = " + billid;

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    bool isdefualtdepartment = DQS.Controls.Properties.Settings.Default.IsDefaultDepartment;
                    bool islockdepartment = DQS.Controls.Properties.Settings.Default.IsLockDepartment;
                    if (islockdepartment)
                    {
                        isdefualtdepartment = false;
                    }
                    sdad.Fill(ds, "Table");
                    if (ds.Tables["Table"].Rows.Count > 0)
                    {
                        gridControl1.DataSource = ds.Tables["Table"];
                        for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                        {
                            productids.Add(int.Parse(ds.Tables["Table"].Rows[i]["ProductID"].ToString()));
                        }
                        for (int i = 0; i < gridView1.Columns.Count; i++)
                        {
                            string ColumnName = gridView1.Columns[i].ToString();
                            if (ColumnName.Contains("ID"))
                            {
                                gridView1.Columns[i].Visible = false;
                            }
                            if (ColumnName == "单价")
                            {
                                gridView1.Columns[i].OptionsColumn.AllowEdit = true;
                            }
                            else
                            {
                                gridView1.Columns[i].OptionsColumn.AllowEdit = false;
                            }
                        }
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
        private void LoadDepartment()
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT DepartmentID,DepartmentName FROM dbo.BFI_Department WHERE DepartmentName LIKE '%业务%'";

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    bool isdefualtdepartment = DQS.Controls.Properties.Settings.Default.IsDefaultDepartment;
                    bool islockdepartment = DQS.Controls.Properties.Settings.Default.IsLockDepartment;
                    if (islockdepartment)
                    {
                        isdefualtdepartment = false;
                    }
                    sdad.Fill(ds, "Table");
                    for (int i = 0; i < ds.Tables["Table"].Rows.Count; i++)
                    {
                        department = new GetDepartment();
                        department.departmentID = Convert.ToInt32(ds.Tables["Table"].Rows[i]["DepartmentID"]);
                        department.departmentName = ds.Tables["Table"].Rows[i]["DepartmentName"].ToString();
                        departments.Add(department);
                        cboDepartment.Properties.Items.Add(department.departmentName);
                        if (isdefualtdepartment && i == 0)
                        {
                            cboDepartment.Text = department.departmentName;
                        }
                    }
                    if (islockdepartment)
                    {
                        this.cboDepartment.Properties.ReadOnly = true;
                        var departmentid = GlobalItem.g_CurrentEmployee.DepartmentID;
                        if (departmentid == 0)
                        {
                            XtraMessageBox.Show("没有找到相对应的部门，请核实。");
                            return;
                        }
                        foreach (var item in departments)
                        {
                            if (item.departmentID == departmentid)
                            {
                                cboDepartment.Text = item.departmentName;
                            }
                        }
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
        private void BindArea()
        {
            EntityCollection<BFIDealerEntity> dealers = new EntityCollection<BFIDealerEntity>();
            dealers.Fetch();

            List<string> dealerAreas =
                dealers.Cast<BFIDealerEntity>().AsQueryable<BFIDealerEntity>().Select(p => p.DealerArea).Distinct().ToList();

            EntityCollection<ATCUserAreaEntity> userAreas = new EntityCollection<ATCUserAreaEntity>();
            userAreas.Fetch();
            if (userAreas.Count > 0)
            {
                dealerAreas.AddRange(userAreas.Cast<ATCUserAreaEntity>().AsQueryable().Select(p => p.AreaName).Distinct().ToList());
            }
            List<string> areas = dealerAreas.Distinct().OrderBy(p => p).ToList();
            foreach (var dealerArea in areas)
            {
                txtDealerArea.Properties.Items.Add(dealerArea);
            }
        }
        private void BandSaleMan(int dealerID)
        {
            string sql = "SELECT TOP 1 SalesmanID,SalesmanName,MobilePhone FROM dbo.BFI_Salesman WHERE DealerID = " + dealerID;
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                try
                {
                    sda.Fill(ds, "TableBill");
                    if (ds.Tables["TableBill"].Rows.Count > 0)
                    {
                        txtBusinessPerson.Tag = ds.Tables["TableBill"].Rows[0]["SalesmanID"].ToString();
                        txtBusinessPerson.Text = ds.Tables["TableBill"].Rows[0]["SalesmanName"].ToString();
                        txtBusinessPhone.Text = ds.Tables["TableBill"].Rows[0]["MobilePhone"].ToString();
                    }
                    else
                    {
                        txtBusinessPerson.Text = "";
                        txtBusinessPhone.Text = "";
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
        }
        private void GetDealerNameInfo()
        {
            BindDealerAddress();
            int dealerID = Convert.ToInt32(txtDealerCode.Tag);
            BFIDealerEntity dealer = new BFIDealerEntity
            {
                DealerID = dealerID
            };
            dealer.Fetch();
            if (dealer.IndustryStyle == "医疗机构")
            {
                this.layReservation11.Visibility = LayoutVisibility.Always;
                this.layReservation12.Visibility = LayoutVisibility.Always;
                this.layReservation13.Visibility = LayoutVisibility.Always;
                this.layReservation14.Visibility = LayoutVisibility.Always;
                this.layReservation15.Visibility = LayoutVisibility.Always;
            }
            else
            {
                this.layReservation11.Visibility = LayoutVisibility.Never;
                this.layReservation12.Visibility = LayoutVisibility.Never;
                this.layReservation13.Visibility = LayoutVisibility.Never;
                this.layReservation14.Visibility = LayoutVisibility.Never;
                this.layReservation15.Visibility = LayoutVisibility.Never;
            }
            if (!dealer.IsNullField("SalePriceListID"))
            {
                cbxPrice.EditValue = dealer.SalePriceListID;
            }
            if (!dealer.IsNullField("Reservation5") && dealer.Reservation5 != "")
            {
                BandOper(dealer.Reservation5);
            }
            else
            {
                operators = "";
            }
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT DealerID,DealerAddress,DealerArea,Operator FROM vw_OutProvider WHERE DealerID = " + dealerID;

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    bool isdefualtdepartment = DQS.Controls.Properties.Settings.Default.IsDefaultDepartment;
                    bool islockdepartment = DQS.Controls.Properties.Settings.Default.IsLockDepartment;
                    if (islockdepartment)
                    {
                        isdefualtdepartment = false;
                    }
                    sdad.Fill(ds, "Table");
                    if (ds.Tables["Table"].Rows.Count > 0)
                    {
                        this.txtDealerAddress.Text = ds.Tables["Table"].Rows[0]["DealerAddress"].ToString();
                        this.txtDealerArea.Text = ds.Tables["Table"].Rows[0]["DealerArea"].ToString();
                        if (Settings.Default.SettingBusinessPersonWithDealer)
                        {
                            this.txtOperator.Text = ds.Tables["Table"].Rows[0]["Operator"].ToString();
                        }
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
            BandSaleMan(dealerID);


            //是否限制还款周期
            //if (Settings.Default.IsRestriction)
            //{
            //    if (!IsTimeOutCycle(dealerID)) return;
            //}
            if (!this.ValidateDealerQualification()) return;
        }
        private bool ValidateDealerQualification()
        {
            //获取客户的过期证书
            if (txtDealerCode.Tag != null)
            {
                int dealerID = Convert.ToInt32(txtDealerCode.Tag);
                ViewCollection<AllQualificationView> qualifications = new ViewCollection<AllQualificationView>();

                PredicateExpression pe = new PredicateExpression();
                pe.Add(AllQualificationViewFields.所属表ID == "BFI_Dealer");
                pe.Add(AllQualificationViewFields.所属ID == dealerID);
                pe.Add(AllQualificationViewFields.到期状态 == "已过期" | AllQualificationViewFields.到期状态 == "即将过期");
                qualifications.Fetch(pe);

                bool isgo = true;
                string message = "";
                foreach (var item in qualifications)
                {
                    var itemli = (AllQualificationView)item;
                    if (itemli.到期状态 == "已过期")
                    {
                        isgo = false;
                    }
                    string validate = "";
                    try
                    {
                        validate = itemli.到期日期.ToString("d");
                    }
                    catch (Exception)
                    {
                        validate = "空";
                    }
                    string mes = itemli.档案名称 + "--" + itemli.到期状态 + "--" + validate + "\r\n";
                    message += mes;
                }


                if (qualifications.Count > 0)
                {
                    if (isgo)
                    {
                        XtraMessageBox.Show(String.Format("客户的电子档案即将过期！\r\n{0}", message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show(String.Format("客户的电子档案已过期，无法生成订单，请修改！\r\n{0}", message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                XtraMessageBox.Show("订单有误。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        private void BindDealerAddress()
        {
            txtDealerAddress.Properties.Items.Clear();
            int dealerID = Convert.ToInt32(txtDealerCode.Tag);
            EntityCollection<BFIDealerAddressEntity> addresses = new EntityCollection<BFIDealerAddressEntity>();
            addresses.Fetch(BFIDealerAddressEntityFields.DealerID == dealerID & BFIDealerAddressEntityFields.DealerAddressType == "收货地址");
            foreach (var address in addresses)
            {
                txtDealerAddress.Properties.Items.Add(
                    (address as BFIDealerAddressEntity).DealerAddress);
            }
        }
        private void BandOper(string opers)
        {
            operators = "(";
            if (opers.Contains(","))
            {
                string s = opers;
                string[] sArray = s.Split(',');
                foreach (string i in sArray)
                {
                    operators += "'" + i.ToString() + "',";
                }
                operators = operators.Substring(0, operators.Length - 1);
                operators += ")";
            }
            else
            {
                operators += ("'" + opers + "')");
            }
        }
        public void LoadViewOut(int id)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                string sqlBill = @"SELECT  订单号 ,单位ID ,单位编号 ,单位名称 ,总金额 FROM vw_AllOutSale WHERE 订单ID = " + id;

                SqlDataAdapter sdad = new SqlDataAdapter(sqlBill, conn);
                DataSet ds = new DataSet();
                try
                {
                    bool isdefualtdepartment = DQS.Controls.Properties.Settings.Default.IsDefaultDepartment;
                    bool islockdepartment = DQS.Controls.Properties.Settings.Default.IsLockDepartment;
                    if (islockdepartment)
                    {
                        isdefualtdepartment = false;
                    }
                    sdad.Fill(ds, "Table");
                    if (ds.Tables["Table"].Rows.Count > 0)
                    {
                        txtOutBillCode.Text = ds.Tables["Table"].Rows[0]["订单号"].ToString();
                        txtDealerCode.Tag = ds.Tables["Table"].Rows[0]["单位ID"].ToString();
                        txtDealerCode.Text = ds.Tables["Table"].Rows[0]["单位编号"].ToString();
                        txtDealerName.Text = ds.Tables["Table"].Rows[0]["单位名称"].ToString();
                        txtTotalPrice.Text = ds.Tables["Table"].Rows[0]["总金额"].ToString();
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
        //保存前检查库存是不是够开
        private void CheckStoreDetail(int DepartmentID)
        {
            _amountErrors = "";
            int rowCount = this.gridView1.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object productID = this.gridView1.GetRowCellValue(i, "ProductID");
                if (productID != null && productID != DBNull.Value)
                {
                    int ProductID = Convert.ToInt32(productID);
                    int Amount = Convert.ToInt32(gridView1.GetDataRow(i)["数量"]);
                    string productcode = gridView1.GetDataRow(i)["产品编码"].ToString();
                    string productname = gridView1.GetDataRow(i)["产品名称"].ToString();
                    int _isamount=CheckNewStoreDetail(DepartmentID,ProductID, Amount);
                    if (_isamount != -1)
                    {
                        _amountErrors += (String.Format("第{0}行，{1} 产品编号为{2}库存不足，现有库存{3}。", i + 1, productname, productcode, _isamount)) + "\r\n";
                    }
                }
            }
        }
        private int CheckNewStoreDetail(int departmentid,int productid, int Amount)
        {
            int isamount = 0;
            string sql = "EXEC sp_CheckOutStoreDetail {0},{1},{2}";
            sql = string.Format(sql,departmentid, productid, Amount);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    isamount = Convert.ToInt32(cmd.ExecuteScalar());
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
            return isamount;
        }
        private bool CheckNewStoreDetail(int InStoreID, int Amount)
        {
            string sql = "EXEC sp_CheckStoreDetail {0},{1}";
            sql = string.Format(sql, InStoreID, Amount);
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    int returnValue = Convert.ToInt32(cmd.ExecuteScalar());
                    if (returnValue == 1)
                    {
                        return false;
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
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (outlist.Count <= 0)
            {
                MessageBox.Show("有产品未选择批号，请核对。");
                return;
            }
            foreach (var item in outlist)
            {
                if (!productids.Contains(item.ProductID))
                {
                    MessageBox.Show("有产品未选择批号，请核对。");
                    return;
                }
            }

            int departmentid = 0;
            if (Settings.Default.IsUseDepartment)
            {
                if (cboDepartment.Text == "")
                {
                    XtraMessageBox.Show("选择项部门不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    foreach (GetDepartment depart in departments)
                    {
                        if (depart.departmentName == cboDepartment.Text)
                        {
                            departmentid = depart.departmentID;
                        }
                    }
                    cboDepartment.Properties.ReadOnly = true;
                }
            }
            CheckStoreDetail(departmentid);
            if (_amountErrors != "")
            {
                using (FrmError frm = new FrmError(_amountErrors))
                {
                    DialogResult dr = frm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        return;
                    }
                }
            }

            _amountErrors = "";
            foreach (var item in outlist)
            {
                if (!CheckNewStoreDetail(item.InStoreID, item.OutAmount))
                {
                    _amountErrors += (String.Format("{0} 编号为{1}选择项库存不足，请重新选择。", item.ProductName,item.ProductCode));
                }
            }
            if (_amountErrors != "")
            {
                using (FrmError frm = new FrmError(_amountErrors))
                {
                    DialogResult dr = frm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            //保存
            BUSBillEntity entity = this.ftPanel.GetEntity() as BUSBillEntity;

            this.CustomSetEntity(entity);
            if (entity.IsNew())
            {
                entity.IsBillIn = false; //出库订单
                entity.BillTypeID = 1;
                entity.BillTypeName = "销售出货";
                entity.BillTypeSpell = "xsch";
                entity.BillStatus = 1;
                entity.BillStatusName = "已下单";
                entity.DepartmentID = departmentid;
                entity.BillDate = DateTime.Now;
                entity.CreateDate = DateTime.Now;
                entity.LastModifyDate = DateTime.Now;
                entity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                entity.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                entity.Save();

                //查询出其ID
                entity.Fetch();

                InsertBillDetail(outlist, entity.BillID);
                //新库存
                if (!UpdateNewStoreDetail(entity.BillID, entity.BillCode))
                {
                    CheckStoreDetail(departmentid);
                }
                if (_amountErrors != "")
                {
                    using (FrmError frm = new FrmError(_amountErrors))
                    {
                        DialogResult dr = frm.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }

                EntityCollection<ATCUserPageEntity> userPages = new EntityCollection<ATCUserPageEntity>();
                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCUserPageEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                pe.Add(ATCUserPageEntityFields.DocumentCode == "SaleBill");
                DataTable data = userPages.FetchTable(pe);

                if (data.Rows.Count > 0)
                {
                    //按审批顺序排序
                    data.DefaultView.Sort = "ApprovalSort";
                    data = data.DefaultView.ToTable();

                    ATCApproveEntity approveEntity = new ATCApproveEntity();
                    approveEntity.InternalNo = "XSCH" + entity.BillCode.Substring(2);
                    approveEntity.DocumentCode = "SaleBill";
                    approveEntity.BillCode = entity.BillCode;
                    approveEntity.ApproveTitle = string.Format("{0}({1})，编号：{2}", entity.BillTypeName,
                        entity.BillStyle, entity.BillCode);
                    approveEntity.ApprovalContent = String.Format("{0}({1}) {2} 申请审批。", entity.BillTypeName,
                        entity.BillStyle, entity.BillCode);
                    approveEntity.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                    approveEntity.CreateDate = DateTime.Now;
                    approveEntity.IsApprovaled = false;
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
                        notification.FormClass = "SaleBill";
                        notification.IsRead = false;
                        notification.TargetID = entity.BillID;
                        notification.TargetCode = entity.BillCode;
                        notification.ApproveCode = approveCode;
                        notification.Message = string.Format("{0} 于 {1} 申请产品销售（单号 {2}）。请您审批。", userName,
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.BillCode);
                        notification.OwnerUserID = approvalUserId;
                        notification.Save();
                    }
                }
                else
                {
                    entity.BillStatus = 2;
                    entity.BillStatusName = "已审核";
                    entity.Update();
                }
            }
            else
            {
                XtraMessageBox.Show("销售单号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.Yes;
        }
        private bool UpdateNewStoreDetail(int BillID, string BillCode)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                try
                {
                    //string sql = "EXEC sp_InsertNewStoreDetail {0},'{1}'";
                    //sql = String.Format(sql, BillID, BillCode);
                    //SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.ExecuteNonQuery();

                    int returnValue = 0;
                    SqlCommand cmd = new SqlCommand("sp_InsertNewStoreDetailForOut", conn);

                    cmd.Parameters.Add(new SqlParameter("@BillID", BillID));
                    cmd.Parameters.Add(new SqlParameter("@BillCode", BillCode));
                    cmd.Parameters.Add(new SqlParameter("@return", SqlDbType.Int, 0, ParameterDirection.ReturnValue,
                      true, 0, 0, string.Empty, DataRowVersion.Default, DBNull.Value));

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteScalar();
                    returnValue = (int)cmd.Parameters["@return"].Value;
                    if (returnValue == 1)
                    {
                        return false;
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
            return true;
        }
        private void InsertBillDetail(List<OutSaleViewDetail> list, int BillID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalItem.g_DbConnectStrings))
            {
                conn.Open(); //连接数据库
                //必须为SqlCommand指定数据库连接和登记的事务
                try
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        string sql = "EXEC sp_InsertBillDetail {0},{1},{2},'{3}',{4},'{5}','{6}','{7}','{8}',{9},'{10}'";
                        sql = String.Format(sql, list[i].InStoreID,
                            BillID,
                            list[i].ProductID,
                            list[i].BatchNo,
                            list[i].OutAmount,
                            list[i].UnitPrice,
                            list[i].TotalPrice,
                            list[i].TradePrice,
                            list[i].RetailPrice,
                            list[i].Reservation1,
                            list[i].isPrint);
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
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
        }
        protected virtual void CustomSetEntity(BUSBillEntity entity)
        {
            if (Settings.Default.IsUseDepartment)
            {
                if (cboDepartment.Text != "")
                {
                    foreach (GetDepartment depart in departments)
                    {
                        if (depart.departmentName == cboDepartment.Text)
                        {
                            entity.DepartmentID = depart.departmentID;
                        }
                    }
                }
            }

                entity.DealerID = Convert.ToInt32(txtDealerCode.Tag);
                entity.DealerName = this.txtDealerName.Text.Trim();
                entity.DealerCode = txtDealerCode.Text;
                entity.DealerSpell = GlobalMethod.GetAlphabetic(entity.DealerName);

                BFIDealerEntity dealer = new BFIDealerEntity { DealerID = entity.DealerID };
                dealer.Fetch();
                if (!dealer.IsNullField("BusinessPerson"))
                {
                    entity.BusinessPerson = dealer.BusinessPerson;
                }
                if (!dealer.IsNullField("BusinessPhone"))
                {
                    entity.BusinessPhone = dealer.BusinessPhone;
                }

            if (this.txtBusinessPerson.Text.Trim() != "")
            {
                entity.BusinessPerson = this.txtBusinessPerson.Text.Trim();
                entity.BusinessPersonSpell = GlobalMethod.GetAlphabetic(entity.BusinessPerson);
            }

            if (this.txtOperator.Text.Trim() != "")
            {
                entity.Operator = this.txtOperator.Text.Trim();
                entity.OperatorSpell = GlobalMethod.GetAlphabetic(entity.Operator);
            }

            if (this.txtReservation6.Text.Trim() != "")
            {
                entity.Reservation6 = this.txtReservation6.Text.Trim();
            }

            if (this.txtPickUpPerson.Text.Trim() != "")
            {
                entity.PickUpPerson = this.txtPickUpPerson.Text.Trim();
                entity.PickUpPersonSpell = GlobalMethod.GetAlphabetic(entity.PickUpPerson);
            }

            if (this.cbxDeliveryType.SelectedValue != null)
            {
                entity.DeliveryTypeID = Convert.ToInt32(this.cbxDeliveryType.SelectedValue);
                entity.DeliveryTypeName = this.cbxDeliveryType.Text.Trim();
            }

            if (this.cbxPaymentType.SelectedValue != null)
            {
                entity.PaymentTypeID = Convert.ToInt32(this.cbxPaymentType.SelectedValue);
                entity.PaymentTypeName = this.cbxPaymentType.Text.Trim();
            }

            if (!string.IsNullOrWhiteSpace(txtDealerAddress.Text.Trim()))
            {
                entity.DealerAddress = txtDealerAddress.Text.Trim();
            }
            entity.BillStyle = this.rdgBillStyle.Properties.Items[rdgBillStyle.SelectedIndex].Value.ToString();
            entity.InvoiceTypeName = this.rdgPaymentType.Properties.Items[rdgPaymentType.SelectedIndex].Value.ToString();

            entity.SalePriceListID = Convert.ToInt32(cbxPrice.EditValue);

            if (this.txtDealerArea.Text.Trim() != "")
            {
                entity.Reservation4 = this.txtDealerArea.Text.Trim();
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int departmentid = 0;
            if (Settings.Default.IsUseDepartment)
            {
                if (cboDepartment.Text == "")
                {
                    XtraMessageBox.Show("选择项部门不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    foreach (GetDepartment depart in departments)
                    {
                        if (depart.departmentName == cboDepartment.Text)
                        {
                            departmentid = depart.departmentID;
                        }
                    }
                    cboDepartment.Properties.ReadOnly = true;
                }
            }
            if (isfrist == 0)
            {
                CheckStoreDetail(departmentid);
                if (_amountErrors != "")
                {
                    using (FrmError frm = new FrmError(_amountErrors))
                    {
                        DialogResult dr = frm.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    isfrist = 1;
                }
            }
            object id = this.gridView1.GetFocusedRowCellValue("ProductID");
            if (id != null)
            {
                int amount = int.Parse(gridView1.GetFocusedRowCellValue("数量").ToString());
                int productid = int.Parse(id.ToString());
                using (FrmSelectStoreForProduct frm = new FrmSelectStoreForProduct(productid, amount, departmentid))
                {
                    DialogResult result = frm.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        List<int> li = new List<int>();
                        foreach (var item in outlist)
                        {
                            if (item.ProductID == productid)
                            {
                                li.Add(item.InStoreID);
                            }
                        }
                        if (li.Count > 0)
                        {
                            for (int i = 0; i < li.Count; i++)
                            {
                                outlist.Remove(outlist.FirstOrDefault(p => p.InStoreID == li[i]));
                            }
                        }
                        outlist.AddRange(frm.outlist);
                        UpdateList(productid, float.Parse(gridView1.GetFocusedRowCellValue("单价").ToString()));
                        gridControl2.RefreshDataSource();
                    }
                }
            }
            else
            {
                MessageBox.Show("请选中一条信息，进行操作。");
            }
        }
        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "单价")
            {
                if (e.Value.ToString() != "")
                {
                    float thisunitprice = 0;
                    try
                    {
                        thisunitprice = float.Parse(e.Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                    gridView1.SetRowCellValue(e.RowHandle, "金额", thisunitprice * Convert.ToInt32(gridView1.GetDataRow(e.RowHandle)["数量"]));
                    getTotalPrice();
                    UpdateList(Convert.ToInt32(gridView1.GetDataRow(e.RowHandle)["ProductID"]), thisunitprice);
                    gridControl2.RefreshDataSource();
                }
            }
        }
        private void UpdateList(int productid, float unitprice)
        {
            foreach (var item in outlist)
            {
                if (item.ProductID == productid)
                {
                    item.UnitPrice = unitprice;
                    item.TotalPrice = unitprice * item.OutAmount;
                }
            }
        }
        private void getTotalPrice()
        {
            float total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                try
                {
                    total += float.Parse(gridView1.GetDataRow(i)["金额"].ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return;
                }
            }
            txtTotalPrice.Text = total.ToString();
        }
    }

    public class OutSaleViewDetail
    {
        public int InStoreID { get; set; }
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchNo { get; set; }
        public DateTime ProduceDate { get; set; }
        public DateTime ValidateDate { get; set; }
        public string SterilizationBatchNo { get; set; }
        public DateTime SterilizationDate { get; set; }
        public int OutAmount { get; set; }
        public int StoreAmount { get; set; }
        public float UnitPrice { get; set; }
        public float TotalPrice { get; set; }
        public double TradePrice { get; set; }
        public double RetailPrice { get; set; }
        public string Reservation1 { get; set; }
        public string isPrint { get; set; }
    }
}
