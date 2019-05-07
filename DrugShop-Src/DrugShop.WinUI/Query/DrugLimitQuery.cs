using System;
using System.Collections.Generic;
using System.Windows.Forms;


using Microsoft.VisualBasic;
using EAS.Modularization;
using DrugShop.Entities;
using DrugShop.BLL;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 药店药品效期预警
    /// </summary>
    [Module("39BB586B-E397-4563-93E8-C27A5BE2BE95", "效期预警", "提供药店效期预警功能")]
    public partial class DrugLimitQuery : UserControl
    {
        private IList<Store> storeList;

        [ModuleStart()]
        public void StartEx()
        {
            this.Initialize();
        }

        public DrugLimitQuery()
        {
            InitializeComponent();
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Enter };
        }

        internal void Initialize()
        {
            this.ledClock.DateTime = XContext.CurrentTime;

            DataBindHelper.BindDrugTypeCmbBox2(this.cbxType);
        }

        internal void SeachDrugShop()
        {
            if (this.tbDay.Text == string.Empty)
            {
                this.tbDay.Text = "0";
            }

            if (!Information.IsNumeric(this.tbDay.Text) & this.cbWarn.Checked)
            {
                MessageBox.Show("天数格式输入错误，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbDay.Focus();
                return;
            }

            if (this.storeList == null)
            {
                storeList = new List<Store>();
            }
            int type = 0;
            int days = int.Parse(this.tbDay.Text);

            if (Information.IsNumeric(this.cbxType.SelectedValue))
            {
                type = (int)this.cbxType.SelectedValue;
            }

            this.dmrstoreBindingSource.DataSource = null;

            storeList = EAS.Services.ServiceContainer.GetService<IDrugStoreService>().GetDrugList(type, this.tbSeach.Text.Trim(), this.cbWarn.Checked, days);

            this.dmrstoreBindingSource.DataSource = this.storeList;

            decimal jobCash = decimal.Zero;
            decimal saleCash = decimal.Zero;

            DateTime time2 = XContext.CurrentTime.AddDays(days);

            foreach (DrugShop.Entities.Store drug in storeList)
            {
                if (drug.Number != 0)
                {
                    jobCash += drug.JobPrice * drug.Number;
                    saleCash += drug.SalePrice * drug.Number;
                }
            }
            this.lbTip.Text = "共有药品记录" + storeList.Count.ToString() + "个，总金额" + saleCash.ToString("F2") + "元";

            if (storeList.Count > 0)
                this.dataGridView1.Tag = storeList;
        }

        private void tbDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string s = this.tbDay.Text.Trim();

                if (s == "")
                {
                    MessageBox.Show("天数不能为空，请输入天数！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!Information.IsNumeric(s))
                {
                    MessageBox.Show("天数格式错误，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbDay.SelectAll();
                    return;
                }

                if (s.IndexOf(".") > -1)
                {
                    MessageBox.Show("天数格式错误，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbDay.SelectAll();
                    return;
                }

                this.btnSeach.Focus();
            }
        }

        private void tbSeach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SeachDrugShop();
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            this.SeachDrugShop();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.SetReportName("药品效期预警表(药店)");
            this.PrintPreview(this.storeList);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int days = int.Parse(this.tbDay.Text);
            DateTime time2 = XContext.CurrentTime.AddDays(days);

            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
            {
                if (dr != null)
                {
                    if (Convert.ToInt32(dr.Cells["numberDataGridViewTextBoxColumn"].Value) != 0)
                    {
                        if (Convert.ToDateTime(dr.Cells["dataGridViewTextBoxColumn9"].Value) <= XContext.CurrentTime)
                        {
                            dr.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        }
                        else if (Convert.ToDateTime(dr.Cells["dataGridViewTextBoxColumn9"].Value) <= time2)
                        {
                            dr.DefaultCellStyle.BackColor = System.Drawing.Color.Blue;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //药品类型
            DataGridViewHelper.GetDrugTypeName(this.dataGridView1, e, "Type");
        }
    }
}
