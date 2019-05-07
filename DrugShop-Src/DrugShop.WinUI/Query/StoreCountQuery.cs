using System;
using System.Collections.Generic;
using System.Windows.Forms;

using EAS.Explorer.Entities;
using EAS.Modularization;
using DrugShop.Entities;
using DrugShop.BLL;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 药品盘点结果查询
    /// </summary>
    [Module("62D5E57E-4437-4902-B4A8-FB6F0A983CBB", "药品盘点结果查询", "提供药品盘点结果查询功能")]
    public partial class StoreCountQuery : UserControl
    {
        private IList<Inventory>  countList;

        [ModuleStart()]
        public void StartEx()
        {
            this.Initialize();
        }

        public StoreCountQuery()
        {
            InitializeComponent();
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Enter };
        }

        internal void Initialize()
        {
            this.ledClock.DateTime = XContext.CurrentTime;

            this.dtpStart.Value = XContext.CurrentTime;
            this.dtpEnd.Value = XContext.CurrentTime;
        }

        protected IList<Inventory> CountList
        {
            get
            {
                if (this.countList == null)
                {
                    this.countList = new List<Inventory>();
                }

                return this.countList;
            }
            set
            {
                this.countList = value;
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        private void SeachStoreCount()
        {
            int state = this.rbYes.Checked ? 0x01 : 0x00;

            this.dmrcountBindingSource.DataSource = null;

            this.CountList = EAS.Services.ServiceContainer.GetService<IDrugStoreCountService>().GetDrugStoreCountList(this.dtpStart.Value, this.dtpEnd.Value, this.tbSeach.Text, state);

            this.dmrcountBindingSource.DataSource = this.CountList;

            decimal jobCash = decimal.Zero;
            decimal saleCash = decimal.Zero;

            foreach (DrugShop.Entities.Inventory store in this.CountList)
            {
                jobCash += store.JobPrice * (store.RealNumber - store.Number);
                saleCash += store.SalePrice * (store.RealNumber - store.Number);
            }

            this.lbTip.Text = "盈亏金额，总金额" + saleCash.ToString("F2") + "元";

            this.dataGridView1.Tag = this.CountList.GetType();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.SetReportName("药品盘点统计表(药店)");
            this.PrintPreview(this.countList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SeachStoreCount();
        }

        private void tbSeach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnSearch_Click(sender, e);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
            int number = Convert.ToInt32(dr.Cells["numberDataGridViewTextBoxColumn"].Value);
            int RealNumber = Convert.ToInt32(dr.Cells["RealNumberDataGridViewTextBoxColumn"].Value);
            decimal JobPrice = Convert.ToDecimal(dr.Cells["JobPriceDataGridViewTextBoxColumn"].Value);
            decimal SalePrice = Convert.ToDecimal(dr.Cells["SalePriceDataGridViewTextBoxColumn"].Value);
            int x = number - RealNumber;
            int subNumber = Math.Abs(x);
            // 
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "colflag")
            {
                string flag = x == 0 ? "持平" : x < 0 ? "盘盈" : "盘亏";
                e.Value = flag;
            }
            // 
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "colsubNumber")
            {
                e.Value = subNumber.ToString("F2");
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "colcash1")
            {
                decimal cash1 = subNumber * JobPrice;
                e.Value = cash1.ToString("F2");
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "colcash2")
            {
                decimal cash2 = subNumber * SalePrice;
                e.Value = cash2.ToString("F2");
            }

            //药品类型
            DataGridViewHelper.GetDrugTypeName(this.dataGridView1, e, "typeDataGridViewTextBoxColumn");
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
            {
                if (dr != null)
                {
                    int number = Convert.ToInt32(dr.Cells["numberDataGridViewTextBoxColumn"].Value);
                    int RealNumber = Convert.ToInt32(dr.Cells["RealNumberDataGridViewTextBoxColumn"].Value);
                    int x = number - RealNumber;
                    if (x != 0)
                    {
                        dr.DefaultCellStyle.BackColor = x > 0 ? System.Drawing.Color.Red : System.Drawing.Color.Blue;
                    }
                }
            }
        }
    }
}
