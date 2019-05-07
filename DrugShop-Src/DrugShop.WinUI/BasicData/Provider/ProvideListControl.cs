using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using DrugShop.Entities;using EAS.Data.ORM;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 供应商维护列表。
    /// </summary>
    [Module("4921F5B3-5A2A-402B-95AA-D97A327C7FB0", "供应商", "提供供应商信息维护功能")]
    public partial class ProvideList : UserControl
    {
        public event EventHandler Close;

        private IList<Provider> providerList;
        /// <summary>
        /// 触发 Exited 事件。
        /// </summary>
        /// <param name="e">事件参数。</param>
        protected void OnExited(EventArgs e)
        {
            if (this.Close != null)
            {
                this.Close(this, e);
            }
        }

        [ModuleStart()]
        public void StartEx()
        {
            this.Initialize();
        }

        public ProvideList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化。
        /// </summary>
        public void Initialize()
        {
            this.InitList();
            this.EnabledItemMenu(false);
        }

        #region 菜单、工具栏

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            this.ItemAdd();
        }

        private void btnItemProperty_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            this.ItemProperty(row);
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            this.ItemDelete();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.ListSearch();
        }

        private void cmiItemAdd_Click(object sender, EventArgs e)
        {
            this.ItemAdd();
        }

        private void cmiItemProperty_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            this.ItemProperty(row);
        }

        private void cmiItemDelete_Click(object sender, EventArgs e)
        {
            this.ItemDelete();
        }

        private void cmiItemRefresh_Click(object sender, EventArgs e)
        {
            this.ListRefresh();
        }

        private void cmiItemSearch_Click(object sender, EventArgs e)
        {
            this.ListSearch();
        }

        private void tsmiNoShowAll_Click(object sender, EventArgs e)
        {
            this.InitList();
        }

        private void tsmiShowAll_Click(object sender, EventArgs e)
        {
            this.InitList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.SetReportName("药品类型");
            this.PrintPreview(this.providerList);
        }

        #endregion

        #region 记录维护

        /// <summary>
        /// 记录添加。
        /// </summary>
        protected void ItemAdd()
        {
            ProviderEditorForm o = new ProviderEditorForm();

            if(o.ShowDialog() == DialogResult.OK)
            {
                DrugShop.Entities.Provider var = o.Provider;

                this.providerList.Insert(0,var);

                this.providerBindingSource.DataSource = null;
                this.providerBindingSource.DataSource = this.providerList;
            }
        }

        private void InitRowInfo(DataGridViewRow row, DrugShop.Entities.Provider var)
        {
            row.Cells[0].Value = var.Name;
            row.Cells[1].Value = var.Tel;
            row.Cells[2].Value = var.Fax;
            row.Cells[3].Value = var.EMail;
            row.Cells[4].Value = var.Contact;
            row.Cells[5].Value = var.Phone;
            row.Cells[6].Value = var.Mobile;
            row.Cells[7].Value = var.Address;
            row.Cells[8].Value = var.InputCode;
        }

        /// <summary>
        /// 记录属性。
        /// </summary>
        protected void ItemProperty(DataGridViewRow row)
        {
            DrugShop.Entities.Provider provider = row.DataBoundItem as DrugShop.Entities.Provider;

            if(provider == null)
            {
                return;
            }

            ProviderEditorForm o = new ProviderEditorForm();
            o.Provider = provider;

            if(o.ShowDialog() == DialogResult.OK)
            {
                DrugShop.Entities.Provider var = o.Provider;

                this.InitRowInfo(row, var);
            }
        }

        /// <summary>
        /// 记录删除。
        /// </summary>
        protected void ItemDelete()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            DrugShop.Entities.Provider provider = row.DataBoundItem as DrugShop.Entities.Provider;

            if(provider == null)
            {
                return;
            }

            string tip = "厂家" ;
            if(MessageBox.Show("您确认要删除所选择的" + tip + "记录么？\n请确认您的操作。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                provider.Delete();

                this.dataGridView1.Rows.Remove(row);
            }
        }

        /// <summary>
        /// 刷新当前列表数据。
        /// </summary>
        protected void ListRefresh()
        {
            this.InitList();
        }

        /// <summary>
        /// 记录检索。
        /// </summary>
        protected void ListSearch()
        {
            MessageBox.Show("search");
        }

        #endregion

        #region 初始化列表相关

        /// <summary>
        /// 载入指定属性的所有记录到列表。
        /// </summary>
        protected void InitList()
        {
            DrugShop.Entities.Provider provider = new Entities.Provider();

            if (providerList == null)
                providerList = new List<Provider>();

            providerList= provider.GetAll();

            this.InitList(providerList);
        }

        /// <summary>
        /// 将指定的数据源中的记录绑定到列表。
        /// </summary>
        protected void InitList(IList<Provider> list)
        {
            //绑定相关的提供商数据源信息
            this.providerBindingSource.DataSource = list;
        }

        #endregion

        /// <summary>
        /// 记录菜单项的可用与否控制。
        /// </summary>
        private void EnabledItemMenu(bool enabled)
        {
            this.cmiItemProperty.Enabled = enabled;
            this.cmiItemDelete.Enabled = enabled;

            this.btnItemProperty.Enabled = enabled;
            this.btnItemDelete.Enabled = enabled;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.OnExited(e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool enabled = e.RowIndex !=-1;
            this.EnabledItemMenu(enabled);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            this.ItemProperty(row);
        }
    }
}
