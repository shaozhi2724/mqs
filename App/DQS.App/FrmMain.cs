using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DQS.App.Properties;
using ORMSCore;
using DQS.Module.Entities;
using DevExpress.XtraNavBar;
using DevExpress.XtraTab;
using DevExpress.Utils;
using System.Resources;
using System.Reflection;
using System.Threading;
using DQS.App.Licenser;
using DQS.App.MQSKeyServices;
using DQS.Module;
using DQS.Common;
using DQS.Controls;
using Microsoft.Win32;
using Timer = System.Timers.Timer;

namespace DQS.App
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        private DataTable m_MemuData;
        private XtraTabPage m_CurrentPage;

        private ResourceManager m_ResourceManager;

        private WaitDialogForm m_WaitForm;

        string[] columnNames = { "MenuCode", "ParentCode", "MenuName", "LevelNo", "SubTitle", "SmallImageName", "MenuFullClass", "SortNumber" };

        //数据库依赖通知

        Notification notification = null;

        public FrmMain()
        {
            #region 启动等待窗体
            new Thread((ThreadStart)delegate
            {
                m_WaitForm = new WaitDialogForm("正在加载应用系统...", "请稍候");
                Application.Run(m_WaitForm);
            }).Start();

            #endregion

            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            m_ResourceManager = new ResourceManager("DQS.App.Properties.Resources", assembly);
            GlobalItem.g_DbConnectStrings = ConfigurationManager.ConnectionStrings["DbConnectStrings"].ConnectionString;

            ThreadPool.QueueUserWorkItem((w) => SubmitEnterpriseInfo());
#if RockeyLicense
            Timer timerToCheckRockeyLicense = new Timer(60000);
            timerToCheckRockeyLicense.Elapsed += timerToCheckRockeyLicense_Elapsed;
            timerToCheckRockeyLicense.Enabled = true;
            timerToCheckRockeyLicense.Start();
#endif
            ShowApproveNotificationLink();
        }

        private void SubmitEnterpriseInfo()
        {
            try
            {
                var decodedContent = "";
                var keyHid = "";
                var keyVersion = "";
                #if RockeyLicense
                    try
                    {
                        byte[] content = Program.RockeyLicenseManager.ReadBytes();
                        decodedContent = Program.RockeyLicenseManager.RSADecrypt(content);
                        keyHid = Program.RockeyLicenseManager.Hid;
                        keyVersion = Program.RockeyLicenseManager.Version;
                    }
                    catch (Exception)
                    {
                        decodedContent = "加密锁RSA内容解密错误！";
                    }
                #else
                        decodedContent = "非加密锁";
                #endif
                EntityCollection<BFIEnterpriseEntity> entities = new EntityCollection<BFIEnterpriseEntity>();
                entities.Fetch();
                BFIEnterpriseEntity enterprise = new BFIEnterpriseEntity();
                if (entities.Count > 0)
                {
                    enterprise = entities.Cast<BFIEnterpriseEntity>().FirstOrDefault();
                }

                MQSKeyServiceSoapClient service = new MQSKeyServiceSoapClient();

                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                List<string> macAddresses = new List<string>();
                foreach (NetworkInterface adapter in networkInterfaces)
                {
                    string fRegistryKey = "SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\" + adapter.Id + "\\Connection";
                    RegistryKey rk = Registry.LocalMachine.OpenSubKey(fRegistryKey, false);
                    if (rk != null)
                    {
                        // 区分 PnpInstanceID
                        // 如果前面有 PCI 就是本机的真实网卡
                        string pnpInstanceId = rk.GetValue("PnpInstanceID", "").ToString();
                        if (pnpInstanceId.Length > 3 && pnpInstanceId.Substring(0, 3) == "PCI") //物理网卡
                        {
                            macAddresses.Add(adapter.GetPhysicalAddress().ToString());
                        }
                    }
                }
                var macAddress = macAddresses.FirstOrDefault();

                service.SubmitClientInfo(new ClientKeyInfo
                                             {
                                                 EnterpriseName = enterprise.EnterpriseName,
                                                 ContactPerson = enterprise.ContactPerson,
                                                 ContactPhone = enterprise.ContactPhone,
                                                 EmployeeCount =!enterprise.IsNullField("EmployeeNum") && !string.IsNullOrWhiteSpace(enterprise.EmployeeNum) ? int.Parse(enterprise.EmployeeNum) : 0,
                                                 EnterpriseAddress = enterprise.EnterpriseAddress,
                                                 EnterpriseFax = enterprise.EnterpriseFaxNo,
                                                 EnterpriseLevel = enterprise.EnterpriseLevel,
                                                 EnterpriseMail = enterprise.EnterpriseMail,
                                                 EnterprisePhone = enterprise.EnterprisePhone,
                                                 EnterprisePostCode = enterprise.EnterprisePostalCode,
                                                 EnterpriseType = enterprise.EnterpriseType,
                                                 EnterpriseWebsite = enterprise.EnterpriseWebSiteUrl,
                                                 Industry = enterprise.IndustryStyle,
                                                 OrganizationCode = enterprise.OrganizationCode,
                                                 RegisterLicenseNo = enterprise.RegisterLicenseNo,
                                                 LicenseValidateDate = enterprise.LicenseValidateDate,
                                                 RegisterTaxNo = enterprise.RegisterTaxNo,
                                                 RegisterAddress = enterprise.RegisterAddress,
                                                 RegisterDate = enterprise.RegisterData,
                                                 TradeLicenseValidateDate = enterprise.TradeLicenseValidateDate,
                                                 KeyHid = keyHid,
                                                 ClientMacAddress = macAddress,
                                                 KeyVersion = keyVersion,
                                                 KeyDecryptedContent = decodedContent,
                                                 InstallDate = !enterprise.IsNullField("CreateDate") ? enterprise.CreateDate : DateTime.MinValue,
                                                 InfoSendDate = DateTime.Now,
                                             });
                service.Close();
            }
            catch (Exception)
            {

            }
        }

#if RockeyLicense
        void timerToCheckRockeyLicense_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string pid = Settings.Default.PID_Rockey;
            string pin = Settings.Default.PIN_Rockey;
            Program.RockeyLicenseManager = new RockeyLicenseManager(pid, pin);
            if (Program.RockeyLicenseManager.Find())
            {
                Program.RockeyLicenseManager.Open();
                if (!Program.RockeyLicenseManager.IsOpened)
                {
                        ShowError("未检测到密钥锁连接，请检查后重试！");

                        Application.Exit();
                }
            }
            else
            {
                ShowError("未检测到密钥锁，请插入密钥锁后重试！");

                Application.Exit();
            }
            
        }

        private void ShowError(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => { XtraMessageBox.Show(this, message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);}));
            }
            else
            {
                XtraMessageBox.Show(message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
#endif

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F1))
            {
                if (GlobalItem.g_CurrentUser.UserCode == "root" && GlobalItem.g_CurrentUser.UserName == "特级管理员")
                {
                    new FrmCategorySetting().ShowDialog(this);
                    return true;
                }
            }
            if (keyData == (Keys.Alt | Keys.F2))
            {
                GlobalMethod.AllowNoReviewSaleBack = true;
            }
            return base.ProcessDialogKey(keyData);
        }
        
        void NotificationHandler(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new OnChangeEventHandler(NotificationHandler), new object[] { sender, e });
                return;
            }
            var sqlDep = sender as SqlDependency;
            sqlDep.OnChange -= new OnChangeEventHandler(NotificationHandler);
            DataTable notifications = notification.GetData(NotificationHandler);
            DataRowCollection rows = notifications.Rows;
            hleApproveNote.Text = string.Format("您有 {0} 个待批复的单据", rows.Count);

            EntityCollection<ATCUserPageEntity> approvePages = new EntityCollection<ATCUserPageEntity>();
            approvePages.Fetch(ATCUserPageEntityFields.ApprovalUserID == GlobalItem.g_CurrentUser.UserID);
            hleApproveNote.Visible = approvePages.Count > 0;
            picApproveNote.Visible = approvePages.Count > 0;

            if (e.Info == SqlNotificationInfo.Insert)
            {
                AlertControl notifier = new AlertControl();
                notifier.LookAndFeel.SkinName = "Blue";
                notifier.LookAndFeel.UseDefaultLookAndFeel = false;
                notifier.FormLoad += alertControl_FormLoad;
                notifier.BeforeFormShow += alertControl_BeforeFormShow;

                string notifierType = "单据";
                var formClass = notifications.Rows[0]["FormClass"].ToString();
                switch (formClass)
                {
                    case "FirstDealer":
                        notifierType = "首营供应商";
                        break;
                    case "FirstProvider":
                        notifierType = "首营客户";
                        break;
                    case "PurchaseBill":
                        notifierType = "采购订单";
                        break;
                    case "PurchaseBackBill":
                        notifierType = "采购退回单";
                        break;
                    case "SaleBill":
                        notifierType = "销售订单";
                        break;
                    case "SaleBackBill":
                        notifierType = "销售退回单";
                        break;
                    case "ProductUnqualified":
                        notifierType = "不合格产品处理单";
                        break;
                    case "ProductDestroy":
                        notifierType = "产品销毁处理单";
                        break;
                }

                notifier.Show(null,
                    string.Format("有新的{0}需要您审核", notifierType),
                    notifications.Rows[0]["Message"].ToString(),
                    this.imageList.Images[0]);
            }
        }

        void alertControl_BeforeFormShow(object sender, AlertFormEventArgs e)
        {
            e.AlertForm.Size = new Size(400, 150);
        }

        private void alertControl_AlertClick(object sender, AlertClickEventArgs e)
        {
            ShowWarningForm();
        }

        private void ShowApproveNotificationLink()
        {
            if (notification == null)
            {
                notification = new Notification();
            }

            notification.Initialization();

            try
            {

                DataTable notifications = notification.GetData(NotificationHandler);
                DataRowCollection rows = notifications.Rows;

                var message = string.Format("您有 {0} 个待批复的单据", rows.Count);
                hleApproveNote.Text = message;
                hleApproveNote.EditValue = message;

                EntityCollection<ATCUserPageEntity> approvePages = new EntityCollection<ATCUserPageEntity>();
                approvePages.Fetch(ATCUserPageEntityFields.ApprovalUserID == GlobalItem.g_CurrentUser.UserID);
                hleApproveNote.Visible = approvePages.Count > 0;
                picApproveNote.Visible = approvePages.Count > 0;
                if (approvePages.Count == 0 && notifications.Rows.Count == 0)
                {
                    dockPanel.HideImmediately();
                    hideContainerRight.Hide();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void hleApproveNote_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            FrmApproveNotifications notifications = new FrmApproveNotifications();
            notifications.Visible = true;

            dockPanel.ControlContainer.Controls.Clear();
            dockPanel.ControlContainer.Controls.Add(notifications);

            notifications.Dock = DockStyle.Fill;

            hideContainerRight.Show();
            dockPanel.Show();
            Application.DoEvents();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.splitterButtom.Visible = false;
            this.gpcFastQuery.Visible = false;

            this.lblUserName.Text = GlobalItem.g_CurrentUser.UserName;

            this.lblDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");

            this.lblDate.Text += " " + Week();

            this.Text += " - V " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            BFIEnterpriseEntity enterprise = new BFIEnterpriseEntity { EnterpriseID = 1 };
            enterprise.Fetch();
            this.Text += " - " + enterprise.EnterpriseName;

            this.AutoLoadTopMenu();

            //点击第一个大菜单
            if (btnNavMainMenu.Buttons.Count > 0)
            {
                this.btnNavMainMenu_ButtonClicked(btnNavMainMenu.Buttons[0], new EventArgs());
            }

            //首页不许关闭
            this.tbMain.ShowCloseButton = DefaultBoolean.False;

            #region 关闭等待窗体

            m_WaitForm.Invoke((EventHandler) delegate
            {
                m_WaitForm.Close();

            });

            #endregion

            if (this.btnNavMainMenu.Buttons.Count <= 0)
            {
                XtraMessageBox.Show("您所属的角色未分配任何浏览权限或已被禁用，请联系管理员！", "系统提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                //this.Close();
            }

            //预警显示
            DataSet dataSet = GlobalMethod.GetWarningData();
            foreach (DataTable data in dataSet.Tables)
            {
                if (data.Rows.Count > 0)
                {
                    this.hleWarning.Tag = dataSet; //将数据关联到此控件
                    this.hleWarning.Visible = true;
                    this.picWarning.Visible = true;
                    alertControl.Show(null, new AlertInfo("系统预警信息", "点击查看系统预警信息", this.imageList.Images[0]));
                    break;
                }
            }

            bool checkEnterpriseLicense = CheckEnterpriseGSPLicense();
            bool checkEnterpriseTradeLicense = CheckEnterpriseTradeLicense();

            string message = "";
            if (!checkEnterpriseLicense)
            {
                message += "- 企业营业执照已到期\n";
            }
            if (!checkEnterpriseTradeLicense)
            {
                message += "- 企业经营许可证已到期\n";
            }
            if (!string.IsNullOrWhiteSpace(message))
            {
                XtraMessageBox.Show("不能进行业务管理操作:\n" + message, "系统提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //一级菜单点击
        private void btnNavMainMenu_ButtonClicked(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            DataRow mainRow = button.Tag as DataRow;

            this.AutoLoadLeftMenu(mainRow);     //加载左侧菜单（二，三级）
            //this.AutoLoadButtomMenu(mainRow);   //加载底部快速查询（四级）

            string fullClass = mainRow["MenuFullClass"].ToString();
            HomePageForm frmHome = Activator.CreateInstance(Type.GetType(fullClass)) as HomePageForm;

            if (GlobalItem.g_CurrentUser.UserCode != "root")//非root用户根据权限设置是否禁用菜单按钮
            {
                frmHome.SetMenuAuthority(m_MemuData);
            }
            
            frmHome.Show();

            frmHome.TopLevel = false;
            frmHome.FormBorderStyle = FormBorderStyle.None;
            frmHome.Dock = DockStyle.Fill;
            tbMain.Controls.Clear();
            tbMain.Controls.Add(frmHome);

        }

        //三级菜单点击
        private void item_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            try
            {
                NavBarItem navBarItem = sender as NavBarItem;
                DataRow itemRow = navBarItem.Tag as DataRow;
                this.AutoLoadLeftMenuPage(itemRow);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("加载页面失败。\r\n{0}", ex.Message), "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 加载一级菜单
        /// </summary>
        private void AutoLoadTopMenu()
        {
            //设置一级菜单权限
            EntityCollection<SYSMenuEntity> menus = new EntityCollection<SYSMenuEntity>();

            if (GlobalItem.g_CurrentUser.UserCode == "root")
            {
                m_MemuData = menus.FetchTable();//root最高权限
            }
            else
            {
                PrefetchRelation pr = new PrefetchRelation();
                pr.Add(RelationType.ATC_RoleMenu_Parent_SYS_Menu);
                pr.Add(RelationType.ATC_Role_Parent_ATC_RoleMenu);
                pr.Add(RelationType.ATC_Role_Parent_ATC_UserRole);
                pr.Add(RelationType.ATC_User_Parent_ATC_UserRole);

                PredicateExpression pe = new PredicateExpression();
                pe.Add(SYSMenuEntityFields.IsEnabled == 1);
                pe.Add(ATCRoleEntityFields.RoleStatus == 1);
                pe.Add(ATCUserEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                var menuData = menus.FetchTable(pe, pr);
                
                m_MemuData = menuData.DefaultView.ToTable(true, columnNames);
            }

            this.SetTopMenu();
        }

        //设置一级菜单
        private void SetTopMenu()
        {
            if (m_MemuData.Rows.Count > 0)
            {
                m_MemuData.DefaultView.Sort = "SortNumber";
                m_MemuData = m_MemuData.DefaultView.ToTable(true, columnNames);
                DataRow[] mainRows = m_MemuData.Select("LevelNo = 1");
                if (mainRows.Length > 0)
                {
                    foreach (DataRow mainRow in mainRows)
                    {
                        SimpleButton button = new SimpleButton();
                        this.btnNavMainMenu.AddButton(button);
                        button.Text = mainRow["MenuName"].ToString();
                        button.ToolTip = mainRow["SubTitle"].ToString();

                        object img = m_ResourceManager.GetObject(mainRow["SmallImageName"].ToString());
                        if (img != null)
                        {
                            button.Image = img as Image;//设置图片
                        }

                        button.Tag = mainRow;
                    }
                }
            }
        }

        /// <summary>
        /// 加载左侧菜单页面
        /// </summary>
        /// <param name="mainRow">一级菜单</param>
        private void AutoLoadLeftMenu(DataRow mainRow)
        {
            DataRow[] groupRows = m_MemuData.Select(String.Format("LevelNo = 2 and ParentCode = '{0}'", mainRow["MenuCode"]));

            //每次清空
            navBarMenu.Groups.Clear();
            navBarMenu.Items.Clear();

            if (groupRows.Length > 0)
            {
                foreach (DataRow groupRow in groupRows)
                {
                    NavBarGroup group = new NavBarGroup
                    {
                        Name = groupRow["MenuCode"].ToString(),
                        Caption = groupRow["MenuName"].ToString()
                    };
                    group.Appearance.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    group.Appearance.Options.UseFont = true;
                    navBarMenu.Groups.Add(group);
                    group.Expanded = true;


                    DataRow[] itemRows = m_MemuData.Select(String.Format("LevelNo = 3 and ParentCode = '{0}'", groupRow["MenuCode"]));
                    if (itemRows.Length > 0)
                    {
                        foreach (DataRow itemRow in itemRows)
                        {
                            NavBarItem item = new NavBarItem
                            {
                                Name = itemRow["MenuCode"].ToString(),
                                Caption = itemRow["MenuName"].ToString()
                            };

                            item.Appearance.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                            item.Appearance.Options.UseFont = true;

                            object img = m_ResourceManager.GetObject(itemRow["SmallImageName"].ToString());
                            if (img != null)
                            {
                                item.SmallImage = img as Image;//设置图片
                            }

                            navBarMenu.Items.Add(item);
                            group.ItemLinks.Add(item);
                            item.Tag = itemRow;
                            item.LinkClicked += item_LinkClicked;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 显示左侧菜单页面(三级菜单)
        /// </summary>
        /// <param name="menu">三级菜单</param>
        private void AutoLoadLeftMenuPage(DataRow menuRow)
        {
#if SenseLockLicense
            if (!Program.SENSE4CONTEXT.HasValue)
            {
                XtraMessageBox.Show("此客户端已被取消授权，请联系管理员！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
#endif
            string caption = menuRow["MenuName"].ToString();
            string code = menuRow["MenuCode"].ToString();


            if (menuRow.ItemArray[0].ToString() != "ProductQuery")
            {
                //快速查询暂时只对“在库查询”开放
                this.splitterButtom.Visible = false;
                this.gpcFastQuery.Visible = false;
            }
            if (!IsTabShowing(code))
            {
                try
                {

                    string fullClass = menuRow["MenuFullClass"].ToString();

                    bool checkEnterpriseLicense = CheckEnterpriseGSPLicense();
                    bool checkEnterpriseTradeLicense = CheckEnterpriseTradeLicense();
                    if (fullClass.Contains("DQS.AppViews.Operation"))
                    {
                        string message = "";
                        if (!checkEnterpriseLicense)
                        {
                            message += "- 企业营业执照已到期\n";
                        }
                        if (!checkEnterpriseTradeLicense)
                        {
                            message += "- 企业经营许可证已到期\n";
                        }
                        if (!string.IsNullOrWhiteSpace(message))
                        {
                            XtraMessageBox.Show("不能进行业务管理操作:\n" + message, "系统提示", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }

                    #region 启动等待窗体

                    new Thread((ThreadStart) delegate
                    {
                        m_WaitForm = new WaitDialogForm("正在努力加载页面...", "请稍候");
                        Application.Run(m_WaitForm);
                    }).Start();

                    #endregion
                    
                    XtraForm frmContent = Activator.CreateInstance(Type.GetType(fullClass)) as XtraForm;
                    frmContent.Tag = "Frm" + code;
                    //frmContent.WindowState = FormWindowState.Minimized;//先最小化再Dock，解决窗体一闪后再显示，此时会造成ToolBar没有鼠标移动效果
                    frmContent.Show(); //必须先显示后在添加到Page页，否则ToolBar没有鼠标移动效果

                    frmContent.TopLevel = false;
                    frmContent.FormBorderStyle = FormBorderStyle.None;
                    frmContent.Dock = DockStyle.Fill;

                    XtraTabPage page = new XtraTabPage {Name = code, Text = caption};
                    page.Controls.Add(frmContent);
                    tbControlMain.TabPages.Add(page);
                    tbControlMain.SelectedTabPage = page;

                    if (menuRow.ItemArray[0].ToString() == "ProductQuery")
                    {
                        this.AutoLoadButtomMenu(menuRow, frmContent as StandardForm);
                    }
                    else
                    {

                        this.splitterButtom.Visible = false;
                        this.gpcFastQuery.Visible = false;
                        //快速查询暂时只对“在库查询”开放
                    }

                    #region 关闭等待窗体

                    m_WaitForm.Invoke((EventHandler)delegate
                    {
                        m_WaitForm.Close();
                    });

                    #endregion

                    //特例: GSP报表预览界面会弹出查询窗体，这与预加载等待窗体有冲突
                    if (fullClass == "DQS.AppViews.StatReport.StatManager.FrmReportViewer, DQS.AppViews.StatReport")
                    {
                        (frmContent as DQS.AppViews.StatReport.StatManager.FrmReportViewer).CustomQuery();
                    }
                }
                catch (Exception ex)
                {

                    #region 关闭等待窗体

                    if (null != m_WaitForm && m_WaitForm.IsHandleCreated)
                    {
                        m_WaitForm.Invoke((EventHandler) delegate
                                                         {
                                                             m_WaitForm.SendToBack();
                                                             m_WaitForm.Close();
                                                             Application.DoEvents();
                                                             XtraMessageBox.Show(ex.Message);
                                                         });
                    }
                    else
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                    #endregion
                }
                finally
                {
                    #region 关闭等待窗体

                    if(null != m_WaitForm && m_WaitForm.IsHandleCreated)
                    {
                        m_WaitForm.Invoke((EventHandler)delegate
                        {
                            m_WaitForm.Close();
                        });
                    }

                    #endregion
                }
            }
        }

        private bool CheckEnterpriseGSPLicense()
        {
            EntityCollection<BFIEnterpriseEntity> entities = new EntityCollection<BFIEnterpriseEntity>();
            entities.Fetch();

            if (entities.Count > 0)
            {
                BFIEnterpriseEntity entity = entities[0] as BFIEnterpriseEntity;
                if (!entity.IsNullField("LicenseValidateDate"))
                {
                    if (DateTime.Today > entity.LicenseValidateDate)
                    {
                        EntityCollection<BFIEnterpriseLicenseLockHistoryEntity> lockHistories = new EntityCollection<BFIEnterpriseLicenseLockHistoryEntity>();
                        lockHistories.Fetch(BFIEnterpriseLicenseLockHistoryEntityFields.OldLicenseValidateDate == entity.LicenseValidateDate | BFIEnterpriseLicenseLockHistoryEntityFields.LockDate == entity.LicenseValidateDate);
                        if (lockHistories.Count == 0)
                        {
                            BFIEnterpriseLicenseLockHistoryEntity lockHistory = new BFIEnterpriseLicenseLockHistoryEntity();
                            lockHistory.ActionName = "锁定";
                            lockHistory.ActionDate = entity.LicenseValidateDate.Date;
                            lockHistory.OldLicenseValidateDate = entity.LicenseValidateDate;
                            lockHistory.LockDate = entity.LicenseValidateDate;
                            lockHistory.CreateUserName = "系统";
                            lockHistory.Save();
                        }
                        return false;
                    }
                }
            }
            return true;
            //this.Close();
        }
        private bool CheckEnterpriseTradeLicense()
        {
            EntityCollection<BFIEnterpriseEntity> entities = new EntityCollection<BFIEnterpriseEntity>();
            entities.Fetch();

            if (entities.Count > 0)
            {
                BFIEnterpriseEntity entity = entities[0] as BFIEnterpriseEntity;
                if (!entity.IsNullField("TradeLicenseValidateDate"))
                {
                    if (DateTime.Today > entity.TradeLicenseValidateDate)
                    {
                        EntityCollection<BFIEnterpriseTradeLicenseLockHistoryEntity> lockHistories = new EntityCollection<BFIEnterpriseTradeLicenseLockHistoryEntity>();
                        lockHistories.Fetch(BFIEnterpriseTradeLicenseLockHistoryEntityFields.OldLicenseValidateDate == entity.TradeLicenseValidateDate | BFIEnterpriseTradeLicenseLockHistoryEntityFields.LockDate == entity.TradeLicenseValidateDate);
                        if (lockHistories.Count == 0)
                        {
                            BFIEnterpriseTradeLicenseLockHistoryEntity lockHistory = new BFIEnterpriseTradeLicenseLockHistoryEntity();
                            lockHistory.ActionName = "锁定";
                            lockHistory.ActionDate = entity.TradeLicenseValidateDate.Date;
                            lockHistory.OldLicenseValidateDate = entity.TradeLicenseValidateDate;
                            lockHistory.LockDate = entity.TradeLicenseValidateDate;
                            lockHistory.CreateUserName = "系统";
                            lockHistory.Save();
                        }
                        return false;
                    }
                }
            }
            return true;
            //this.Close();
        }

        /// <summary>
        /// 加载底部快速查询页面（四级菜单）
        /// </summary>
        /// <param name="menuRow"></param>
        private void AutoLoadButtomMenu(DataRow menuRow)
        {
            this.btnNavFastQuery.Buttons.Clear();
            this.btnNavFastQuery.Controls.Clear();

            string code = menuRow["MenuCode"].ToString();
            if (code != "ProductQuery")
            {
                //快速查询暂时只对“在库查询”开放
                return;
            }

            this.splitterButtom.Visible = true;
            this.gpcFastQuery.Visible = true;
            EntityCollection<SYSMenuEntity> menus = new EntityCollection<SYSMenuEntity>();
            PredicateExpression pe = new PredicateExpression();
            pe.Add(SYSMenuEntityFields.IsEnabled == 1);
            pe.Add(SYSMenuEntityFields.LevelNo == 4);
            pe.Add(SYSMenuEntityFields.ParentCode == code);
            DataTable dt = menus.FetchTable(pe);
            DataView dv = dt.DefaultView;
            dv.Sort = "SortNumber ASC";
            DataTable allBottomMenus = dv.ToTable();
            foreach (DataRow fastQueryRow in allBottomMenus.Rows)
            {
                SimpleButton button = new SimpleButton();
                this.btnNavFastQuery.AddButton(button);
                button.Text = fastQueryRow["MenuName"].ToString();
                button.ToolTip = fastQueryRow["SubTitle"].ToString();
                button.Tag = fastQueryRow;
            }
        }
        private void AutoLoadButtomMenu(DataRow menuRow, StandardForm form)
        {
            this.btnNavFastQuery.Buttons.Clear();
            this.btnNavFastQuery.Controls.Clear();

            string code = menuRow["MenuCode"].ToString();
            if (code != "ProductQuery")
            {

                this.splitterButtom.Visible = false;
                this.gpcFastQuery.Visible = false;
                //快速查询暂时只对“在库查询”开放
                return;
            }

            this.splitterButtom.Visible = true;
            this.gpcFastQuery.Visible = true;
            EntityCollection<SYSMenuEntity> menus = new EntityCollection<SYSMenuEntity>();
            PredicateExpression pe = new PredicateExpression();
            pe.Add(SYSMenuEntityFields.IsEnabled == 1);
            pe.Add(SYSMenuEntityFields.LevelNo == 4);
            pe.Add(SYSMenuEntityFields.ParentCode == code);
            DataTable dt = menus.FetchTable(pe);

            DataView dv = dt.DefaultView;
            dv.Sort = "SortNumber ASC";
            DataTable allBottomMenus = dv.ToTable();
            foreach (DataRow fastQueryRow in allBottomMenus.Rows)
            {
                SimpleButton button = new SimpleButton();
                this.btnNavFastQuery.AddButton(button);
                button.Text = fastQueryRow["MenuName"].ToString();
                button.ToolTip = fastQueryRow["SubTitle"].ToString();
                button.Tag = fastQueryRow;
                List<string> filter = new List<string>();
                var fastQueryMenuCode = fastQueryRow["MenuCode"].ToString();
                switch (fastQueryMenuCode)
                {
                    case "UnqualifiedProductQuery":
                        filter.Add("[货区类型] LIKE '%不合格%'");
                        break;
                    case "QualifiedProductQuery":
                        filter.Add("([货区类型]='整货' OR [货区类型]='零货')");
                        break;
                    case "EntireProductQuery":
                        filter.Add("[货区类型]='整货'");
                        break;
                    case "ScatteredProductQuery":
                        filter.Add("[货区类型]='零货'");
                        break;
                    case "ReturnedProductQuery":
                        filter.Add("[货区类型] LIKE '%退货%'");
                        break;
                }
                button.Click += (o, args) =>
                {
                    form.CustomFastQuery(filter);
                };
            }
        }

        #region 二级菜单在Tab页中的显示，关闭操作

        /// <summary>
        /// 菜单是否在Tab页中已经显示
        /// </summary>
        /// <param name="name">Tab页的名称编号</param>
        /// <returns>是否显示，true已显示</returns>
        private bool IsTabShowing(string code)
        {
            for (int i = 0; i < tbControlMain.TabPages.Count; i++)
            {
                if (tbControlMain.TabPages[i].Name == code)
                {
                    tbControlMain.SelectedTabPageIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void tbControlMain_DoubleClick(object sender, EventArgs e)
        {
            if (m_CurrentPage != null)
            {
                int index = this.ShowPreTabPage(m_CurrentPage);
                m_CurrentPage.Dispose();
                this.tbControlMain.SelectedTabPageIndex = index;
            }
        }

        private void tbControlMain_HotTrackedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            try
            {
                m_CurrentPage = e.Page;
            }
            catch
            {
                m_CurrentPage = null;
            }
        }

        private void tbControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            int index = this.ShowPreTabPage(this.tbControlMain.SelectedTabPage);
            tbControlMain.TabPages.Remove(this.tbControlMain.SelectedTabPage);
            this.tbControlMain.SelectedTabPageIndex = index;
        }

        private void tbControlMain_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (tbControlMain.SelectedTabPageIndex == 0)
            {
                tbMain.ShowCloseButton = DefaultBoolean.False;
            }
            if (null != tbControlMain.SelectedTabPage)
            {
                if (tbControlMain.SelectedTabPage.Text == "在库产品查询")
                {

                    //快速查询暂时只对“在库查询”开放
                    this.splitterButtom.Visible = true;
                    this.gpcFastQuery.Visible = true;
                }
                else
                {
                    this.splitterButtom.Visible = false;
                    this.gpcFastQuery.Visible = false;
                }
            }
        }

        private int ShowPreTabPage(XtraTabPage tabPage)
        {
            for (int i = 0; i < tbControlMain.TabPages.Count; i++)
            {
                if (tbControlMain.TabPages[i] == tabPage)
                {
                    if (i - 1 >= 0)
                    {
                        return i;
                    }
                    break;
                }
            }
            return 0;
        }

        #endregion

        /// <summary>
        /// 获取当前的星期
        /// </summary>
        /// <returns></returns>
        private static string Week()
        {
            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = weekdays[Convert.ToInt32(DateTime.Now.DayOfWeek)];
            return week;
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            using (FrmChangePassword frmChangePassword = new FrmChangePassword())
            {
                frmChangePassword.ShowDialog(this);
            }
        }

        private void hleWarning_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ShowWarningForm();
        }

        private void ShowWarningForm()
        {
            DataSet dataSet = hleWarning.Tag as DataSet;
            FrmWarningShow frmWarning = new FrmWarningShow(dataSet);
            frmWarning.ShowDialog(this);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notification != null)
            {
                notification.Termination();
            }


            SYSDateLogEntity sysDateLog = new SYSDateLogEntity();
            sysDateLog.UserName = GlobalItem.g_CurrentUser.UserName;
            sysDateLog.Operate = "退出系统";
            sysDateLog.OperateDate = DateTime.Now;
            sysDateLog.Save();
        }

        private void alertControl_FormLoad(object sender, AlertFormLoadEventArgs e)
        {
            e.Buttons.PinButton.SetDown(false);
        }
    }
}