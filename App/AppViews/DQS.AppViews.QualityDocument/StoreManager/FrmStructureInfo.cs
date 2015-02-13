using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ORMSCore;
using DQS.Module.Views;
using DevExpress.XtraTreeList.Columns;
using DQS.Controls;
using DevExpress.XtraTreeList;
using DevExpress.Utils.Drawing;
using DevExpress.XtraTreeList.Nodes;
using DQS.Module.Entities;
using DQS.Common;

namespace DQS.AppViews.QualityDocument.StoreManager
{
    public partial class FrmStructureInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmStructureInfo()
        {
            InitializeComponent();
        }

        private void FrmStructureInfo_Load(object sender, EventArgs e)
        {
            this.cbbParentStructureType.InitSource();
            this.cbbStructureType.InitSource();

            this.InitStructure();

        }

        private void trlStructure_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                this.ftPanelChild.Enabled = false;
                this.btnAdd.Text = "添加(&A)";
                this.btnModify.Text = "编辑(&M)";

                this.btnAdd.Enabled = true;
                this.btnModify.Enabled = true;
                this.btnDelete.Enabled = true;

                this.AcceptButton = null;

                #region 设置存储信息

                object structureType = e.Node.GetValue("StructureType");
                if (structureType != null)
                {
                    this.cbbStructureType.Text = structureType.ToString();
                }

                object isMinStructure = e.Node.GetValue("IsMinStructure");
                if (isMinStructure != null)
                {
                    this.chkIsMinStructure.Checked = Convert.ToBoolean(isMinStructure);
                }

                this.SetStructureInfo(e.Node, this.ftPanelChild);

                #endregion

                #region 设置父级存储信息

                if (e.Node.ParentNode != null)
                {
                    object parentStructureType = e.Node.ParentNode.GetValue("StructureType");
                    if (parentStructureType != null)
                    {
                        this.cbbParentStructureType.Text = parentStructureType.ToString();
                    }

                    object parentIsMinStructure = e.Node.ParentNode.GetValue("IsMinStructure");
                    if (parentIsMinStructure != null)
                    {
                        this.chkParentIsMinStructure.Checked = Convert.ToBoolean(parentIsMinStructure);
                    }

                    this.SetStructureInfo(e.Node.ParentNode, this.ftPanelParent);
                }
                else
                {
                    this.SetStructureClear(this.ftPanelParent);
                    this.chkParentIsMinStructure.Checked = false;
                    this.cbbParentStructureType.Text = "";
                }

                #endregion
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.InitStructure();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnQuery_Click(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TreeListNode node = trlStructure.FocusedNode;
            object structureCode = node.GetValue("StructureCode");
            if (structureCode != null)
            {
                if (node.HasChildren)
                {
                    DialogResult result = XtraMessageBox.Show("确定要删除改存储信息及其子项吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        BFIStorageStructureEntity structure = new BFIStorageStructureEntity { ParentStructureCode = structureCode.ToString() };
                        structure.DeleteByCommonly();

                        structure.StructureCode = structureCode.ToString();
                        structure.Delete();

                        this.InitStructure();
                        
                    }
                }
                else
                {
                    DialogResult result = XtraMessageBox.Show("确定要删除改存储信息吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        BFIStorageStructureEntity structure = new BFIStorageStructureEntity { StructureCode = structureCode.ToString() };
                        structure.Delete();

                        this.InitStructure();
                    }
                }
            }
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            TreeListNode node = trlStructure.FocusedNode;
            if (node != null)
            {
                object structureType = node.GetValue("StructureType");
                if (structureType != null)
                {
                    if (structureType.ToString() == "托盘" || structureType.ToString() == "货位")
                    {
                        XtraMessageBox.Show(String.Format("'{0}'下无法添加子项！", structureType), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            if (btnAdd.Text == "添加(&A)")
            {
                this.ftPanelChild.Enabled = true;
                this.btnAdd.Enabled = true;
                this.btnModify.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnAdd.Text = "保存(&S)";
                this.btnModify.Text = "编辑(&M)";

                this.SetStructureClear(this.ftPanelChild);
                this.cbbStructureType.Text = "";
                this.chkIsMinStructure.Checked = false;

                this.AcceptButton = this.btnAdd;
                //this.txtStructureCode.Enabled = true;
            }
            else
            {
                if (this.SaveStructure())
                {
                    this.InitButton();
                    this.AcceptButton = null;
                }
            }
        }




        private void btnModify_Click(object sender, EventArgs e)
        {
            TreeListNode node = trlStructure.FocusedNode;
            if (node != null)
            {
                object structureType = node.GetValue("StructureType");
                if (structureType != null)
                {
                    if (structureType.ToString() == "仓库")
                    {
                        XtraMessageBox.Show("'仓库'信息在此无法编辑！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            if (btnModify.Text == "编辑(&M)")
            {
                this.ftPanelChild.Enabled = true;
                this.btnAdd.Enabled = false;
                this.btnModify.Enabled = true;
                this.btnDelete.Enabled = false;
                this.btnAdd.Text = "添加(&A)";
                this.btnModify.Text = "保存(&S)";

                this.AcceptButton = this.btnModify;
                //this.txtStructureCode.Enabled = false;
            }
            else
            {
                if (this.SaveStructure())
                {
                    this.InitButton();
                    this.AcceptButton = null;
                }

                //this.txtStructureCode.Enabled = true ;
            }
        }

        private void chkIsMinStructure_CheckedChanged(object sender, EventArgs e)
        {
            this.txtStructureBarCode.Enabled = chkIsMinStructure.Checked;
        }

        private void trlStructure_CustomDrawNodeIndicator(object sender, DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs e)
        {
            TreeList tree = sender as TreeList;

            IndicatorObjectInfoArgs args = e.ObjectArgs as IndicatorObjectInfoArgs;

            args.DisplayText = (tree.GetVisibleIndexByNode(e.Node) + 1).ToString();
        }

        /// <summary>
        /// 初始化树行存储结构信息
        /// </summary>
        private void InitStructure()
        {

            ViewCollection<AllWarehouseStructureView> structures = new ViewCollection<AllWarehouseStructureView>();
            if (this.txtName.Text.Length > 0)
            {
                DataTable data = structures.FetchTable(AllWarehouseStructureViewFields.StructureName % this.txtName.Text.Trim());
                this.trlStructure.DataSource = data;
                this.trlStructure.KeyFieldName = "StructureCode2";
                this.trlStructure.ParentFieldName = "ParentStructureCode2";
                this.trlStructure.ExpandAll();
            }
            else
            {
                DataTable data = structures.FetchTable();
                this.trlStructure.DataSource = data;
                this.trlStructure.KeyFieldName = "StructureCode2";
                this.trlStructure.ParentFieldName = "ParentStructureCode2";
                this.trlStructure.ExpandAll();
            }
        }

        /// <summary>
        /// 初始化按钮
        /// </summary>
        private void InitButton()
        {
            this.ftPanelChild.Enabled = false;
            this.btnAdd.Text = "添加(&A)";
            this.btnModify.Text = "编辑(&M)";

            this.btnAdd.Enabled = true;
            this.btnModify.Enabled = true;
            this.btnDelete.Enabled = true;
        }

        /// <summary>
        /// 保存存储信息
        /// </summary>
        private bool SaveStructure()
        {
            if (!this.ValidateStructure()) return false;

            if (this.cbbStructureType.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("请选择存储类型。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cbbStructureType.Focus();
                return false;
            }

            TreeListNode node = trlStructure.FocusedNode;
            if (node != null)
            {
                BFIStorageStructureEntity structure = this.ftPanelChild.GetEntity() as BFIStorageStructureEntity;
                structure.IsMinStructure = this.chkIsMinStructure.Checked;
                structure.StructureType = this.cbbStructureType.Text.Trim();

                if (this.btnModify.Enabled)
                {
                    //编辑

                    #region 编辑
                    object structureID = node.GetValue("StructureID");
                    if (structureID != null)
                    {
                        //条码不可更新成其它的已经有的条码
                        if (!string.IsNullOrEmpty(this.txtStructureBarCode.Text.Trim()))
                        {
                            object oldBarCode = node.GetValue("StructureBarCode");
                            if (oldBarCode != null)
                            {
                                if (!structure.IsNew(BFIStorageStructureEntityFields.StructureBarCode == this.txtStructureBarCode.Text.Trim() & BFIStorageStructureEntityFields.StructureBarCode != oldBarCode.ToString()))
                                {
                                    XtraMessageBox.Show("条码已存在，请重新输入条码。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.txtStructureBarCode.Focus();
                                    this.txtStructureBarCode.Select(this.txtStructureBarCode.Text.Length, 0);
                                    return false;
                                }
                            }
                        }

                        structure.StructureID = Convert.ToInt32(structureID);

                        structure.LastModifyDate = DateTime.Now;
                        structure.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        structure.Update();

                        //如果编号修改，则更新子级编号
                        object structureCode = node.GetValue("StructureCode");
                        if (structureCode != null)
                        {
                            if (structureCode.ToString() != this.txtStructureCode.Text.Trim())
                            {
                                BFIStorageStructureEntity entity2 = new BFIStorageStructureEntity { ParentStructureCode = structure.StructureCode };
                                entity2.UpdateByCommonly(BFIStorageStructureEntityFields.ParentStructureCode == structureCode);
                            }
                        }

                        this.InitStructure();
                    }
                    else
                    {
                        XtraMessageBox.Show("存储结构ID。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }

                    #endregion
                }
                else
                {
                    //添加

                    #region 添加

                    object parentStructureCode = node.GetValue("StructureCode");
                    if (parentStructureCode != null)
                    {
                        structure.ParentStructureCode = parentStructureCode.ToString();

                        int? warehouseID = this.GetWarehouseID(node);
                        if (warehouseID != null)
                        {
                            structure.WarehouseID = warehouseID.Value;
                        }
                        else
                        {
                            XtraMessageBox.Show("未找到所属仓库ID。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("未找到父级结构编码。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (!string.IsNullOrEmpty(this.txtStructureBarCode.Text.Trim()))
                    {
                        if (!structure.IsNew(BFIStorageStructureEntityFields.StructureBarCode == this.txtStructureBarCode.Text.Trim()))
                        {
                            XtraMessageBox.Show("条码已存在，请重新输入条码。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.txtStructureBarCode.Focus();
                            this.txtStructureBarCode.Select(this.txtStructureBarCode.Text.Length, 0);
                            return false;
                        }
                    }

                    BFIWarehouseEntity warehouse = new BFIWarehouseEntity { WarehouseCode = this.txtStructureCode.Text.Trim() };
                    if (!warehouse.IsNew())
                    {
                        XtraMessageBox.Show("存储编号不能与仓库编号重名，请重新输入。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtStructureCode.Focus();
                        this.txtStructureCode.Select(this.txtStructureCode.Text.Length, 0);
                        return false;
                    }

                    if (structure.IsNew())
                    {
                        structure.CreateDate = DateTime.Now;
                        structure.LastModifyDate = DateTime.Now;
                        structure.CreateUserID = GlobalItem.g_CurrentUser.UserID;
                        structure.LastModifyUserID = GlobalItem.g_CurrentUser.UserID;
                        structure.Save();

                        this.InitStructure();
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show("存储编号已存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    #endregion
                }
            }
            return false;
        }

        /// <summary>
        /// 验证存储结构信息
        /// </summary>
        /// <returns>是否通过</returns>
        private bool ValidateStructure()
        {
            if (this.txtStructureCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("存储编号不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtStructureCode.Focus();
                return false;
            }

            if (this.txtStructureName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("存储名称不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtStructureName.Focus();
                return false;
            }

            if (this.cbbStructureType.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("存储类型不能为空。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cbbStructureType.Focus();
                return false;
            }

            return true;

        }

        /// <summary>
        /// 获取存储信息所在仓库ID
        /// </summary>
        /// <param name="focusedNode">当前选中的Node</param>
        /// <returns>仓库ID</returns>
        private int? GetWarehouseID(TreeListNode focusedNode)
        {
            if (focusedNode.ParentNode != null)
            {
                return this.GetWarehouseID(focusedNode.ParentNode);
            }
            else
            {
                object warehouseID = focusedNode.GetValue("WarehouseID");
                if (warehouseID != null)
                {
                    return Convert.ToInt32(warehouseID);
                }
            }
            return null;
        }

        /// <summary>
        /// 根据TreeNode设置存储信息
        /// </summary>
        /// <param name="node"></param>
        /// <param name="container"></param>
        private void SetStructureInfo(TreeListNode node, Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is BFIStorageStructureEntityTextBox)
                {
                    BFIStorageStructureEntityTextBox structureBox = c as BFIStorageStructureEntityTextBox;
                    string fieldName = structureBox.EntityField.ToString();
                    object nodeValue = node.GetValue(fieldName);
                    if (nodeValue != null)
                    {
                        structureBox.Text = nodeValue.ToString();
                    }
                }

                if (c.HasChildren)
                {
                    this.SetStructureInfo(node, c);
                }
            }
        }

        /// <summary>
        /// 清空存储信息
        /// </summary>
        /// <param name="container"></param>
        private void SetStructureClear(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is BFIStorageStructureEntityTextBox)
                {
                    c.Text = "";
                }

                if (c.HasChildren)
                {
                    this.SetStructureClear(c);
                }
            }
        }








    }
}