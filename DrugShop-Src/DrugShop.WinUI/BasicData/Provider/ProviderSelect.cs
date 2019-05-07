using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Services;
using DrugShop.Entities;using EAS.Data.ORM;
using DrugShop.BLL;

namespace DrugShop.WinUI
{
    public partial class ProviderSelect : Form
    {
        protected bool isProvider = true;

        private IList<Provider> providerList;
        public ProviderSelect()
        {
            InitializeComponent();
        }

        private DrugShop.Entities.Provider provider;
        public DrugShop.Entities.Provider Provider
        {
            get
            {
                return this.provider;
            }
            set
            {
                this.provider = value;
            }
        }

        private void tbKeys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            this.SearchProviderInfo();
        }

        private void SearchProviderInfo()
        {
            this.providerBindingSource.DataSource = null;

            if (isProvider)
            {
                this.providerList = ServiceContainer.GetService<IProviderService>().GetProviderList(this.tbKeys.Text.Trim());

                this.providerBindingSource.DataSource = this.providerList;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            this.btnOK.Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index < 0)
                return;

            this.InitSelectProvider(index);
        }

        private void InitSelectProvider(int index)
        {
            DataGridViewRow row = dataGridView1.Rows[index];

            DrugShop.Entities.Provider item = row.DataBoundItem as DrugShop.Entities.Provider;

            if (item == null)
            {
                return;
            }

            this.Provider = item;

            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.CurrentCell.RowIndex;

            if (index < 0)
                return;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InitSelectProvider(index);
        }
    }
}
