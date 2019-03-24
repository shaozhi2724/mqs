using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting;
using ORMSCore;
using DQS.Module.Entities;
using System.Data;
using DQS.Common;
using DevExpress.XtraBars;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using DQS.Module;
using DQS.Module.Views;
using DevExpress.XtraReports.UI;
using DQS.Controls.CommonCode;

namespace DQS.Controls
{
    public class StandardForm : XtraForm
    {
        protected GroupControl gpcQuery;
        protected PageNavigator pageNavigator;
        protected GridControl gvControl;
        protected GridView gvData;
        protected ToolBarPanel toolBarPanel;

        private SYSPageEntity sysPage;

        protected bool isPopupView;
        protected bool isRowReadOnly;
        public StandardForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
            {
                CustomAdd();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        private void InitializeComponent()
        {
            this.toolBarPanel = new DQS.Controls.ToolBarPanel();
            this.gpcQuery = new DevExpress.XtraEditors.GroupControl();
            this.pageNavigator = new DQS.Controls.PageNavigator();
            this.gvControl = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(814, 28);
            this.toolBarPanel.TabIndex = 0;
            this.toolBarPanel.ToolButtonClicked += new DQS.Controls.ToolBarPanel.OnToolButtonClicked(this.toolBarPanel_ToolButtonClicked);
            // 
            // gpcQuery
            // 
            this.gpcQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpcQuery.Location = new System.Drawing.Point(0, 28);
            this.gpcQuery.Name = "gpcQuery";
            this.gpcQuery.Size = new System.Drawing.Size(814, 80);
            this.gpcQuery.TabIndex = 1;
            this.gpcQuery.Text = "查询";
            // 
            // pageNavigator
            // 
            this.pageNavigator.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNavigator.Appearance.Options.UseFont = true;
            this.pageNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageNavigator.EmptySource = null;
            this.pageNavigator.Fields = "*";
            this.pageNavigator.Filter = "";
            this.pageNavigator.GridControl = this.gvControl;
            this.pageNavigator.Location = new System.Drawing.Point(0, 108);
            this.pageNavigator.MinimumSize = new System.Drawing.Size(800, 40);
            this.pageNavigator.Name = "pageNavigator";
            this.pageNavigator.PageCount = 0;
            this.pageNavigator.PageIndex = 0;
            this.pageNavigator.PageSize = 50;
            this.pageNavigator.PrimaryField = null;
            this.pageNavigator.RecordCount = 0;
            this.pageNavigator.Size = new System.Drawing.Size(814, 40);
            this.pageNavigator.SortField = "";
            this.pageNavigator.SortType = "";
            this.pageNavigator.TabIndex = 2;
            this.pageNavigator.ViewName = "";
            // 
            // gvControl
            // 
            this.gvControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvControl.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvControl.Location = new System.Drawing.Point(0, 148);
            this.gvControl.MainView = this.gvData;
            this.gvControl.Name = "gvControl";
            this.gvControl.Size = new System.Drawing.Size(814, 334);
            this.gvControl.TabIndex = 3;
            this.gvControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gvData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedCell.BackColor = System.Drawing.Color.Aqua;
            this.gvData.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Beige;
            this.gvData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvData.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gvData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvData.GridControl = this.gvControl;
            this.gvData.IndicatorWidth = 43;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvData_RowCellClick);
            this.gvData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvData_CustomDrawRowIndicator);
            this.gvData.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvData_CustomDrawEmptyForeground);
            // 
            // StandardForm
            // 
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.gvControl);
            this.Controls.Add(this.pageNavigator);
            this.Controls.Add(this.gpcQuery);
            this.Controls.Add(this.toolBarPanel);
            this.Name = "StandardForm";
            this.Text = "模版窗体";
            ((System.ComponentModel.ISupportInitialize)(this.toolBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        private void gvData_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void gvData_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.RowCount != 0) return;//有记录，返回

            using (StringFormat drawFormat = new StringFormat())
            {
                drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("暂无记录", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
            }
        }

        private void gvData_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                this.CustomModify(true);
            }
        }

        private void toolBarPanel_ToolButtonClicked(object sender, ItemClickEventArgs e)
        {
            switch (e.Item.Caption.Trim())
            {
                case "新建":
                    this.CustomAdd();
                    break;
                case "修改":
                    this.CustomModify();
                    break;
                case "删除":
                    this.CustomDelete();
                    break;
                case "显示设置":
                    this.CustomView();
                    break;
                case "高级查询":
                    this.CustomHighQuery();
                    break;
                case "查询":
                    this.CustomQuery();
                    break;
                case "重置":
                    this.CustomReset();
                    break;
                case "刷新":
                    this.CustomRefresh();
                    break;
                case "导出":
                    this.CustomExport();
                    break;
                case "打印":
                    this.CustomPrint();
                    break;
                case "审批":
                    this.CustomApprove();
                    break;
                case "电子档案":
                    this.CustomQualification();
                    break;
                case "审批状态":
                    this.CustomApproveStatusQuery();
                    break;
                case "产品价格":
                    this.CustomProductPrice();
                    break;
                case "信息变更":
                    this.CustomModifyRequest();
                    break;
                case "反审批":
                    this.CustomRejectApprove();
                    break;
                case "关联产品":
                    this.CustomProductForDealer();
                    break;
                case "变更":
                    this.CustomChangeStatus();
                    break;
                case "复查":
                    this.CustomReCheck();
                    break;
                case "流通监管码":
                    this.CustomRegulatoryCode();
                    break;
                case "添加复核记录":
                    this.CustomOldStoreOut();
                    break;
                case "添加入库记录":
                    this.CustomOldStoreIn();
                    break;
                case "维修":
                    this.CustomFacilitiesService();
                    break;
                case "检定":
                    this.CustomFacilitiesVerification();
                    break;
                case "调价":
                    this.CustomChangePrice();
                    break;
                case "健康档案":
                    this.CustomCheckBody();
                    break;
                case "培训档案":
                    this.CustomPlanDocument();
                    break;
                default:
                    break;
            }
        }

        protected void InitPage()
        {
            if (GlobalItem.g_CurrentUser.UserCode == "root")//root全部功能权限
            {
                if (GlobalItem.g_Functions != null)
                {
                    if (GlobalItem.g_Functions.Rows.Count > 0)
                    {
                        EntityCollection<SYSPageFunctionEntity> pageFunctions = new EntityCollection<SYSPageFunctionEntity>();
                        pageFunctions.Fetch(SYSPageFunctionEntityFields.PageCode == this.Name);

                        if (pageFunctions.Count > 0)
                        {
                            foreach (DataRow functionRow in GlobalItem.g_Functions.Rows)
                            {
                                foreach (SYSPageFunctionEntity pageFunction in pageFunctions)
                                {
                                    string functionCode = functionRow["FunctionCode"].ToString();
                                    if (functionCode == pageFunction.FunctionCode)
                                    {
                                        string functionName = functionRow["FunctionName"].ToString();
                                        string imageName = functionRow["ImageName"].ToString();
                                        this.toolBarPanel.AddTool(functionName, imageName);
                                    }
                                }
                            }

                        }
                    }
                }
            }
            else
            {
                EntityCollection<SYSFunctionEntity> functions = new EntityCollection<SYSFunctionEntity>();

                PrefetchRelation pr = new PrefetchRelation();
                pr.Add(RelationType.ATC_RolePage_Parent_SYS_Function);
                pr.Add(RelationType.ATC_UserRole_Parent_ATC_RolePage);
                pr.Add(RelationType.ATC_User_Parent_ATC_UserRole);

                PredicateExpression pe = new PredicateExpression();
                pe.Add(ATCUserEntityFields.UserID == GlobalItem.g_CurrentUser.UserID);
                pe.Add(ATCRolePageEntityFields.PageCode == this.Name);


                DataTable data = functions.FetchTable(pe, pr);
                string[] columnNames = new string[] { "FunctionName", "FunctionSort", "ImageName" };
                if (data.Rows.Count > 0)
                {
                    data.DefaultView.Sort = "FunctionSort";
                    data = data.DefaultView.ToTable(true, columnNames);

                    foreach (DataRow row in data.Rows)
                    {
                        string functionName = row["FunctionName"].ToString();
                        string imageName = row["ImageName"].ToString();
                        this.toolBarPanel.AddTool(functionName, imageName);
                    }
                }
                else
                {
                    this.toolBarPanel.Visible = false;
                }
            }


            //设置数据
            sysPage = GlobalMethod.GetFormPage(this.Name);
            if (sysPage != null)
            {

                this.pageNavigator.PrimaryField = sysPage.ViewPrimaryField;

                this.pageNavigator.ViewName = sysPage.DbViewName;

                var filedNames = GetFiledNames();
                PageSetting pageSetting = new PageSetting(this.Name,
                    this.pageNavigator.ViewName,
                    this.pageNavigator.PrimaryField,
                    string.IsNullOrWhiteSpace(pageNavigator.SortField)
                        ? (filedNames.Contains("创建日期") ? "创建日期" : pageNavigator.PrimaryField)
                        : pageNavigator.SortField,
                    string.IsNullOrWhiteSpace(pageNavigator.SortType) ? "DESC" : pageNavigator.SortType,
                    this.pageNavigator.PageSize,
                    filedNames);
                if (pageSetting.EnabledFileds.Any())
                {
                    if (!pageSetting.EnabledFileds.Contains(this.pageNavigator.PrimaryField))
                    {
                        pageSetting.EnabledFileds.Add(this.pageNavigator.PrimaryField);
                    }
                    if (!pageSetting.EnabledFileds.Contains(this.pageNavigator.SortField))
                    {
                        pageSetting.EnabledFileds.Add(this.pageNavigator.SortField);
                    }
                    string enabledFields = string.Join(",", pageSetting.EnabledFileds.ToArray());
                    enabledFields = enabledFields.TrimEnd(',');
                    this.pageNavigator.Fields = enabledFields;
                    this.pageNavigator.SortField = pageSetting.SortField;
                    this.pageNavigator.SortType = pageSetting.SortType;
                    this.pageNavigator.PageSize = pageSetting.PageSize;
                }
                this.pageNavigator.ShowData();
                pageNavigator.GridControl.Views[0].RefreshData();

                CustomGroup();
            }

            //设置查询事件
            this.SetEnterQueryKeyPress(this.gpcQuery);

            gvData.OptionsView.ColumnAutoWidth = false;

            //gvData.BestFitColumns();
        }

        private List<string> GetFiledNames()
        {
            List<string> filedNames = new List<string>();
            string sql =
                string.Format(
                    "SELECT c.name FROM sys.all_views v JOIN sys.all_columns c ON c.object_id = v.object_id WHERE v.name = '{0}'",
                    pageNavigator.ViewName);
            SqlCommand command = new SqlConnection(GlobalItem.g_DbConnectStrings).CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            using (command.Connection)
            {
                try
                {
                    command.Connection.Open();
                    var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        filedNames.Add(reader.GetString(0));
                    }
                    command.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (command.Connection.State != ConnectionState.Closed)
                    {
                        command.Connection.Close();
                    }
                }
            }
            return filedNames;
        }

        private void SaveDataLog(string Operate)
        {
            SYSDateDataLogEntity sysDataLog = new SYSDateDataLogEntity();
            sysDataLog.UserName = GlobalItem.g_CurrentUser.UserName;
            sysDataLog.ModuleEntities = sysPage.PageName;
            sysDataLog.Operate = Operate;
            sysDataLog.OperateDate = DateTime.Now;
            sysDataLog.Save();
        }

        /// <summary>
        /// 自定义新建
        /// </summary>
        protected virtual void CustomAdd()
        {
            if (sysPage != null)
            {
                try
                {
                    if (string.IsNullOrEmpty(sysPage.SingleFullClass))
                    {
                        XtraMessageBox.Show("未设置 SingleFullClass 的值。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    SaveDataLog("新建");
                    //MessageBox.Show(sysPage.PageName.ToString());
                    XtraForm singleForm = Activator.CreateInstance(Type.GetType(sysPage.SingleFullClass)) as XtraForm;
                    DialogResult result = singleForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.pageNavigator.ShowData();
                        CustomGroup();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("未设定系统页面。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// 自定义修改
        /// </summary>
        protected virtual void CustomModify()
        {
            if (sysPage != null)
            {
                try
                {
                    if (string.IsNullOrEmpty(sysPage.SingleFullClass))
                    {
                        //XtraMessageBox.Show("未设置 SingleFullClass 的值。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    SaveDataLog("修改");

                    XtraForm singleForm = Activator.CreateInstance(Type.GetType(sysPage.SingleFullClass)) as XtraForm;
                    singleForm.Tag = gvData.GetFocusedRowCellValue(sysPage.ViewPrimaryField);
                    if (singleForm.Tag != null)
                    {
                        DialogResult result = singleForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.pageNavigator.ShowData();
                            CustomGroup();
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("未设定系统页面。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        protected virtual void CustomModify(bool isView)
        {
            if (sysPage != null)
            {
                try
                {
                    if (string.IsNullOrEmpty(sysPage.SingleFullClass))
                    {
                        //XtraMessageBox.Show("未设置 SingleFullClass 的值。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    XtraForm singleForm = Activator.CreateInstance(Type.GetType(sysPage.SingleFullClass)) as XtraForm;
                    singleForm.Tag = gvData.GetFocusedRowCellValue(sysPage.ViewPrimaryField);
                    if (singleForm.Tag != null)
                    {
                        if (isView)
                        {
                            foreach (Control control in singleForm.Controls.Find("btnSave", true))
                            {
                                control.Enabled = false;
                            }
                            foreach (Control control in singleForm.Controls.Find("btnUpdateStoreAmount", true))
                            {
                                control.Enabled = false;
                            }
                        }
                        DialogResult result = singleForm.ShowDialog();
                        
                        if (result == DialogResult.OK)
                        {
                            this.pageNavigator.ShowData();
                            CustomGroup();
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("未设定系统页面。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected virtual void CustomModifyRequest()
        {
            SaveDataLog("信息变更");
        }
        /// <summary>
        /// 自定义删除
        /// </summary>
        protected virtual void CustomDelete()
        {
            if (sysPage != null)
            {
                try
                {
                    object id = gvData.GetFocusedRowCellValue(sysPage.ViewPrimaryField);
                    if (id != null)
                    {
                        DialogResult result = XtraMessageBox.Show("确定要删除该信息吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            //获取实体
                            string fullEntityClass = String.Format("DQS.Module.Entities.{0}, DQS.Module", sysPage.EntityName);
                            EntityBase entity = Activator.CreateInstance(Type.GetType(fullEntityClass)) as EntityBase;

                            //给实体的主键赋值
                            PropertyInfo property = entity.GetType().GetProperty(sysPage.TablePrimaryField);
                            property.SetValue(entity, Convert.ChangeType(id, property.PropertyType), null);

                            //删除
                            entity.Delete();

                            this.pageNavigator.ShowData();
                            CustomGroup();
                        }
                    }

                    SaveDataLog("删除");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("未设定系统页面。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// 自定义显示设置
        /// </summary>
        protected virtual void CustomView()
        {
            SaveDataLog("显示设置");
            List<string> filedNames = new List<string>();
            foreach (DataColumn col in this.pageNavigator.EmptySource.Columns)
            {
                filedNames.Add(col.ColumnName);
            }

            using (FrmPageSetting frmPageSetting = new FrmPageSetting(this.Name, this.pageNavigator.ViewName, this.pageNavigator.PrimaryField, this.pageNavigator.SortField, this.pageNavigator.SortType, this.pageNavigator.PageSize, filedNames))
            {
                DialogResult result = frmPageSetting.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.pageNavigator.Fields = string.Join(",", frmPageSetting.EnabledFileds.ToArray());
                    this.pageNavigator.PageSize = frmPageSetting.PageSize == 0 ? 50 : frmPageSetting.PageSize;
                    this.pageNavigator.SortField = frmPageSetting.SortField ?? pageNavigator.PrimaryField;
                    this.pageNavigator.SortType = frmPageSetting.SortType ?? "DESC";
                    this.pageNavigator.ShowData();
                    CustomGroup();
                }
            }
        }

        /// <summary>
        /// 自定义高级查询
        /// </summary>
        protected virtual void CustomHighQuery()
        {
            SaveDataLog("高级查询");
            List<string> filedNames = new List<string>();
            foreach (DataColumn col in this.pageNavigator.EmptySource.Columns)
            {
                filedNames.Add(col.ColumnName);
            }

            using (FrmHighQuery frmHighQuery = new FrmHighQuery(filedNames))
            {
                DialogResult result = frmHighQuery.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //高级查询
                    this.pageNavigator.Filter = frmHighQuery.QueryFilters;
                    this.pageNavigator.ShowData();
                    CustomGroup();
                }
            }
        }


        /// <summary>
        /// 自定义重置
        /// </summary>
        protected virtual void CustomReset()
        {
            SaveDataLog("重置");
            this.ClearTextEdit(this.gpcQuery);
            if (pageNavigator.Filter.StartsWith("所属部门ID") || pageNavigator.Filter.Contains("[产品ID] IN ("))
            {
                pageNavigator.Filter = pageNavigator.Filter.Split(' ')[0];
            }
            else
            {
                this.pageNavigator.Filter = "";
            }
            this.pageNavigator.ShowData();
            CustomGroup();
        }

        /// <summary>
        /// 自定义刷新
        /// </summary>
        protected virtual void CustomRefresh()
        {
            SaveDataLog("刷新");
            CustomQuery();
        }

        /// <summary>
        /// 自定义导出
        /// </summary>
        protected virtual void CustomExport()
        {
            SaveDataLog("导出");
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                if (sysPage != null)
                {
                    fileDialog.FileName = sysPage.PageName;
                }

                fileDialog.Filter = "Excel文件(*.xls)|*.xls";
                fileDialog.Title = "选择要导出的文件位置";
                fileDialog.InitialDirectory = "桌面";

                if (fileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.gvControl.ExportToXls(fileDialog.FileName);
                }
            }
        }

        /// <summary>
        /// 自定义打印
        /// </summary>
        protected virtual void CustomPrint()
        {
            SaveDataLog("打印");
            //this.gvControl.Print();
            SinglePrint(sysPage.PageName, 0);
        }

        /// <summary>
        /// 自定义产品价格（首营产品用）
        /// </summary>
        protected virtual void CustomProductPrice()
        {
            SaveDataLog("产品价格");
        }

        /// <summary>
        /// 自定义关联产品（首营供应商用）
        /// </summary>
        protected virtual void CustomProductForDealer()
        {
            SaveDataLog("关联产品");
        }

        /// <summary>
        /// 单据状态返回已下单
        /// </summary>
        protected virtual void CustomChangeStatus()
        {
            SaveDataLog("变更");
        }

        /// <summary>
        /// 收货、验收，发现有疑问后
        /// </summary>
        protected virtual void CustomReCheck()
        {
            SaveDataLog("复查");
        }

        /// <summary>
        /// 单据查看流通监管码
        /// </summary>
        protected virtual void CustomRegulatoryCode()
        {
            SaveDataLog("流通监管码");
        }

        /// <summary>
        /// 添加旧系统复核数据
        /// </summary>
        protected virtual void CustomOldStoreOut()
        {
            SaveDataLog("添加复核记录");
        }

        /// <summary>
        /// 添加旧系统入库数据
        /// </summary>
        protected virtual void CustomOldStoreIn()
        {
            SaveDataLog("添加入库记录");
        }

        /// <summary>
        /// 添加设备检定记录
        /// </summary>
        protected virtual void CustomFacilitiesVerification()
        {
            SaveDataLog("检定");
        }

        /// <summary>
        /// 库存调价
        /// </summary>
        protected virtual void CustomChangePrice()
        {
            SaveDataLog("库存调价");
        }

        /// <summary>
        /// 健康档案
        /// </summary>
        protected virtual void CustomCheckBody()
        {
            SaveDataLog("健康档案");
        }

        /// <summary>
        /// 培训档案
        /// </summary>
        protected virtual void CustomPlanDocument()
        {
            SaveDataLog("培训档案");
        }

        /// <summary>
        /// 添加设备维修记录
        /// </summary>
        protected virtual void CustomFacilitiesService()
        {
            SaveDataLog("维修");
        }

        /// <summary>
        /// 自定义查询
        /// </summary>
        protected virtual void CustomQuery()
        {
            SaveDataLog("查询");
            List<string> filters = new List<string>();
            this.GetQueryFilters(this.gpcQuery, filters);
            if (filters.Count > 0)
            {
                if (pageNavigator.Filter.StartsWith("所属部门ID"))
                {
                    this.pageNavigator.Filter = pageNavigator.Filter.Split(' ')[0] + " AND " +
                                                string.Join(" AND ", filters.ToArray());
                }
                else
                {
                    this.pageNavigator.Filter = string.Join(" AND ", filters.ToArray());
                }
                this.pageNavigator.ShowData();
            }
            else
            {
                if (pageNavigator.Filter.StartsWith("所属部门ID") || pageNavigator.Filter.Contains("[产品ID] IN ("))
                {
                    this.pageNavigator.Filter = pageNavigator.Filter.Split(' ')[0];
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(pageNavigator.DefaultFilter))
                    {
                        this.pageNavigator.Filter = pageNavigator.DefaultFilter;
                    }
                    else
                    {
                        this.pageNavigator.Filter = "";
                    }
                }
                this.pageNavigator.ShowData();
            }
            CustomGroup();
        }
        public virtual void CustomFastQuery(List<string> filters)
        {
            if (filters.Count > 0)
            {
                if (pageNavigator.Filter.StartsWith("所属部门ID") || pageNavigator.Filter.Contains("[产品ID] IN ("))
                {
                    this.pageNavigator.Filter = pageNavigator.Filter.Split(' ')[0] + " AND " +
                                                string.Join(" AND ", filters.ToArray());
                }
                else
                {
                    this.pageNavigator.Filter = string.Join(" AND ", filters.ToArray());
                }
                this.pageNavigator.ShowData();
            }
            CustomGroup();
        }

        protected virtual void CustomGroup()
        {
            
        }
        protected DialogResult BaseApprove()
        {
            if (gvData.FocusedRowHandle < 0)
            {
                return DialogResult.None;//无数据
            }

            if (sysPage != null)
            {
                try
                {
                    SYSDocumentEntity documentEntity = new SYSDocumentEntity { DocumentCode = sysPage.DocumentCode };
                    if (!documentEntity.Fetch())
                    {
                        XtraMessageBox.Show("审批单据类型编号不存在或未配置。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return DialogResult.None;
                    }

                    object billCode = gvData.GetFocusedRowCellValue(documentEntity.CodeFieldName);
                    if (billCode == null || billCode == DBNull.Value)
                    {
                        XtraMessageBox.Show("审批单据类型对应字段名称不存在或未配置。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return DialogResult.None;
                    }

                    ViewCollection<AllApproveView> approves = new ViewCollection<AllApproveView>();
                    PredicateExpression pe = new PredicateExpression();
                    pe.Add(AllApproveViewFields.DocumentCode == sysPage.DocumentCode);
                    pe.Add(AllApproveViewFields.BillCode == billCode.ToString());
                    DataTable data = approves.FetchTable(pe);

                    if (data.Rows.Count <= 0)
                    {
                        XtraMessageBox.Show("未找到相应审批状态信息，数据可能出现错误。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return DialogResult.None;
                    }

                    //按审批顺序排序
                    data.DefaultView.Sort = "ApproveOrder";
                    data = data.DefaultView.ToTable();

                    //最大审批次数
                    int maxApproveCount = Convert.ToInt32(data.Rows[data.Rows.Count - 1]["ApproveOrder"]);

                    //是否可以审批
                    DataRow[] rows = data.Select(String.Format("ApprovalUserID = '{0}'", GlobalItem.g_CurrentUser.UserID));
                    if (rows.Length <= 0)
                    {
                        XtraMessageBox.Show("您没有审批权限。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return DialogResult.None;
                    }

                    //已审批的无法再次审批
                    if (Convert.ToInt32(rows[0]["IsApprovaled"]) != 0)
                    {
                        XtraMessageBox.Show("您已经审批过，无法再次审批。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return DialogResult.None;
                    }

                    //审批类型
                    if (Convert.ToInt32(data.Rows[0]["IsWhole"]) != 0)
                    {
                        //多人全部审批通过，按顺序
                        if (Convert.ToInt32(rows[0]["ApproveOrder"]) > 1)
                        {
                            DataRow[] preRows = data.Select("IsApprovaled = 1 AND ApproveOrder = " + (Convert.ToInt32(rows[0]["ApproveOrder"]) - 1));
                            if (preRows.Length <= 0)
                            {
                                XtraMessageBox.Show("审批流程还未走到您这里，请耐心等待。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return DialogResult.None;
                            }
                        }
                    }

                    AllApproveView approve = new AllApproveView();
                    approve.ApprovalUserID = new Guid(rows[0]["ApprovalUserID"].ToString());
                    approve.ApproveID = Convert.ToInt32(rows[0]["ApproveID"]);
                    approve.ApproveOrder = Convert.ToInt32(rows[0]["ApproveOrder"]);
                    approve.BillCode = rows[0]["BillCode"].ToString();
                    approve.CreateUserID = new Guid(rows[0]["CreateUserID"].ToString());
                    approve.DocumentCode = rows[0]["DocumentCode"].ToString();
                    approve.IsApprovaled = Convert.ToBoolean(rows[0]["IsApprovaled"]);
                    approve.IsWhole = Convert.ToBoolean(rows[0]["IsWhole"]);
                    approve.编号 = rows[0]["编号"].ToString();
                    approve.标题 = rows[0]["标题"].ToString();
                    approve.内容 = rows[0]["内容"].ToString();
                    approve.申请人 = rows[0]["申请人"].ToString();
                    approve.申请时间 = Convert.ToDateTime(rows[0]["申请时间"]);
                    approve.审批类型 = rows[0]["审批类型"].ToString();
                    approve.状态 = rows[0]["状态"].ToString();

                    using (FrmApprove frmApprove = new FrmApprove(approve, maxApproveCount))
                    {
                        return frmApprove.ShowDialog(this);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("未设定系统页面。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return DialogResult.None;
        }

        /// <summary>
        /// 自定义审批
        /// </summary>
        protected virtual void CustomApprove()
        {
            SaveDataLog("审批");
            #region 无法先调用此方法的返回值，故无用，可使用BaseApprove方法
            //if (sysPage != null)
            //{
            //    try
            //    {
            //        SYSDocumentEntity documentEntity = new SYSDocumentEntity { DocumentCode = sysPage.DocumentCode };
            //        if (!documentEntity.Fetch())
            //        {
            //            XtraMessageBox.Show("审批单据类型编号不存在或未配置。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            return;
            //        }

            //        object billCode = gvData.GetFocusedRowCellValue(documentEntity.CodeFieldName);
            //        if (billCode == null || billCode == DBNull.Value)
            //        {
            //            XtraMessageBox.Show("审批单据类型对应字段名称不存在或未配置。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            return;
            //        }

            //        ViewCollection<AllApproveView> approves = new ViewCollection<AllApproveView>();
            //        PredicateExpression pe = new PredicateExpression();
            //        pe.Add(AllApproveViewFields.DocumentCode == sysPage.DocumentCode);
            //        pe.Add(AllApproveViewFields.BillCode == billCode.ToString());
            //        DataTable data = approves.FetchTable(pe);

            //        if (data.Rows.Count <= 0)
            //        {
            //            XtraMessageBox.Show("未找到相应审批状态信息，数据可能出现错误。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            return;
            //        }

            //        //按审批顺序排序
            //        data.DefaultView.Sort = "ApproveOrder";
            //        data = data.DefaultView.ToTable();

            //        //最大审批次数
            //        int maxApproveCount = Convert.ToInt32(data.Rows[data.Rows.Count - 1]["ApproveOrder"]);

            //        //是否可以审批
            //        DataRow[] rows = data.Select(String.Format("ApprovalUserID = '{0}'", GlobalItem.g_CurrentUser.UserID));
            //        if (rows.Length <= 0)
            //        {
            //            XtraMessageBox.Show("您没有审批权限。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            return;
            //        }

            //        //已审批的无法再次审批
            //        if (rows[0]["IsApprovaled"].ToString().Trim() != "0")
            //        {
            //            XtraMessageBox.Show("您已经审批过，无法再次审批。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            return;
            //        }



            //        //审批类型
            //        if (data.Rows[0]["IsWhole"].ToString().Trim() != "0")
            //        {
            //            //多人全部审批通过，按顺序
            //            DataRow[] preRows = data.Select("IsApprovaled = 1 AND ApproveOrder = " + (Convert.ToInt32(rows[0]["ApproveOrder"]) - 1));
            //            if (preRows.Length <= 0)
            //            {
            //                XtraMessageBox.Show("审批流程还未走到您这里，请耐心等待。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                return;
            //            }
            //        }

            //        AllApproveView approve = new AllApproveView();
            //        approve.ApprovalUserID = new Guid(rows[0]["ApprovalUserID"].ToString());
            //        approve.ApproveID = Convert.ToInt32(rows[0]["ApproveID"]);
            //        approve.ApproveOrder = Convert.ToInt32(rows[0]["ApproveOrder"]);
            //        approve.BillCode = rows[0]["BillCode"].ToString();
            //        approve.CreateUserID = new Guid(rows[0]["CreateUserID"].ToString());
            //        approve.DocumentCode = rows[0]["DocumentCode"].ToString();
            //        approve.IsApprovaled = Convert.ToBoolean(rows[0]["DocumentCode"]);
            //        approve.IsWhole = Convert.ToBoolean(rows[0]["IsWhole"]);
            //        approve.编号 = rows[0]["编号"].ToString();
            //        approve.标题 = rows[0]["标题"].ToString();
            //        approve.内容 = rows[0]["内容"].ToString();
            //        approve.申请人 = rows[0]["申请人"].ToString();
            //        approve.申请时间 = Convert.ToDateTime(rows[0]["申请时间"]);
            //        approve.审批类型 = rows[0]["审批类型"].ToString();
            //        approve.状态 = rows[0]["状态"].ToString();

            //        using (FrmApprove frmApprove = new FrmApprove(approve, maxApproveCount))
            //        {
            //            frmApprove.ShowDialog(this);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    XtraMessageBox.Show("未设定系统页面。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            #endregion
        }

        /// <summary>
        /// 自定义审批状态查询
        /// </summary>
        protected virtual void CustomApproveStatusQuery()
        {
            SaveDataLog("审批状态");
            if (gvData.FocusedRowHandle < 0)
            {
                return;//无数据
            }

            if (sysPage != null)
            {
                try
                {
                    SYSDocumentEntity documentEntity = new SYSDocumentEntity { DocumentCode = sysPage.DocumentCode };
                    if (!documentEntity.Fetch())
                    {
                        XtraMessageBox.Show("审批单据类型编号不存在或未配置。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    object billCode = gvData.GetFocusedRowCellValue(documentEntity.CodeFieldName);
                    if (billCode == null || billCode == DBNull.Value)
                    {
                        XtraMessageBox.Show("审批单据类型对应字段名称不存在或未配置。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    using (FrmApproveStatus frmApproveStatus = new FrmApproveStatus(sysPage.DocumentCode, billCode.ToString()))
                    {
                        frmApproveStatus.ShowDialog(this);
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("未设定系统页面。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// 自定义电子档案
        /// </summary>
        protected virtual void CustomQualification()
        {
            SaveDataLog("电子档案");
        }
        /// <summary>
        /// 自定义电子档案
        /// </summary>
        protected virtual void CustomRejectApprove()
        {
            SaveDataLog("反审批");
            CustomQuery();
        }

        protected void ClearTextEdit(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c.HasChildren)
                {
                    this.ClearTextEdit(c);
                }

                if (c is TextEdit)
                {
                    c.Text = "";
                }
            }
        }

        protected void GetQueryFilters(Control container, List<string> filters)
        {
            foreach (Control c in container.Controls)
            {
                if (c.HasChildren)
                {
                    this.GetQueryFilters(c, filters);
                }

                if (c is TextBoxQueryEx)
                {
                    TextBoxQueryEx queryBox = c as TextBoxQueryEx;
                    if (queryBox.Text.Trim().Length > 0)
                    {
                        string filter = string.Format(queryBox.FormatQueryString, c.Text);
                        filters.Add(filter);
                    }
                }

                if (c is DateQueryEx)
                {
                    DateQueryEx queryBox = c as DateQueryEx;
                    if (queryBox.Text.Trim().Length > 0)
                    {
                        string filter = string.Format(queryBox.FormatQueryString, c.Text);
                        filters.Add(filter);
                    }
                }

                if(c is ComboBoxCategoryEx)
                {
                    ComboBoxCategoryEx queryBox = c as ComboBoxCategoryEx;
                    if(null != queryBox.SelectedValue && !string.IsNullOrWhiteSpace(queryBox.SelectedItem.ToString()) && queryBox.SelectedItem.ToString() != "全部")
                    {
                        string filter = string.Format(queryBox.FormatQueryString, queryBox.SelectedItem.ToString());
                        filters.Add(filter);
                    }
                }
            }
        }

        protected void SetEnterQueryKeyPress(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c.HasChildren)
                {
                    this.SetEnterQueryKeyPress(c);
                }

                if (c is TextBoxQueryEx)
                {
                    TextBoxQueryEx queryBox = c as TextBoxQueryEx;
                    if (!string.IsNullOrEmpty(queryBox.FormatQueryString))
                    {
                        queryBox.KeyPress += Query_KeyPress;
                    }

                }

                if (c is DateQueryEx)
                {
                    DateQueryEx queryBox = c as DateQueryEx;
                    if (!string.IsNullOrEmpty(queryBox.FormatQueryString))
                    {
                        queryBox.KeyPress += Query_KeyPress;
                    }
                }
            }
        }

        protected virtual void Query_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.CustomQuery();
            }
        }

        protected void SinglePrint(string reportName, string opName, string fileter)
        {
            string viewName = OperationReportSetting.GetReportViewName(opName);
            if (!string.IsNullOrEmpty(viewName))
            {
                /*string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, reportName + ".repx");

                XtraReport report = new XtraReport();
                report.LoadLayout(fileName);

                DataTable data = GlobalMethod.GetViewData(viewName, fileter);

                report.DataSource = data;

                report.ShowPreview();*/

                string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, reportName + ".mrt");
                if (File.Exists(fileName))
                {
                    object pkValue = this.gvData.GetFocusedRowCellValue(pageNavigator.PrimaryField);
                    int id = 0;
                    if (null != pkValue)
                    {
                        id = int.Parse(pkValue.ToString());
                    }
                    PrintPreviewForm printPreview = new PrintPreviewForm(fileName, id);
                    printPreview.ShowDialog(this);
                }
                else
                {
                    fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, reportName + ".repx");
                    XtraReport report = new XtraReport();
                    report.LoadLayout(fileName);

                    DataTable data = GlobalMethod.GetViewData(viewName, fileter);

                    report.DataSource = data;

                    report.ShowPreview();

                }

            }
        }

        protected void SinglePrint(string reportName, int id)
        {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, reportName + ".mrt");
            if (File.Exists(fileName))
            {
                object pkValue = this.gvData.GetFocusedRowCellValue(pageNavigator.PrimaryField);

                if (null != pkValue)
                {
                    id = int.Parse(pkValue.ToString());
                }
                PrintPreviewForm printPreview = new PrintPreviewForm(fileName, id);
                printPreview.ShowDialog(this);
            }
            else
            {
                XtraMessageBox.Show(string.Format("打印模板“{0}”不存在。", reportName + ".mrt"), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
