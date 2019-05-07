using System;
using System.Collections.Generic;
using System.Windows.Forms;


using EAS.Modularization;
using EAS.Services;
using DrugShop.Entities;
using DrugShop.BLL;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 药品入库查询
    /// </summary>
    [Module("E913188A-F041-4FCB-98FE-3A9BCD7B13BC", "药品入库查询", "入库查询")]
    public partial class DrugInQuery : UserControl
    {
        private IList<PIn> drugInList;

        [ModuleStart()]
        public void StartEx()
        {
            this.Initialize();
        }

        public DrugInQuery()
        {
            InitializeComponent();
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Enter };
        }

        internal void Initialize()
        {
            this.ledClock.DateTime = XContext.CurrentTime;

            this.dtpStart.Value = XContext.CurrentTime;
            this.dtpEnd.Value = XContext.CurrentTime;

            this.tbProvider.Tag = 0;
        }

        internal void SeachDrugIn()
        {
            if (this.drugInList == null)
            {
                this.drugInList = new List<PIn>();
            }

            this.drugInList = ServiceContainer.GetService<IDrugInService>().GetDrugInList(this.tbProvider.Text, this.tbSeach.Text, this.dtpStart.Value, this.dtpEnd.Value);

            this.dmrinBindingSource.DataSource = null;

            this.dmrinBindingSource.DataSource = this.drugInList;


            List<string> bills = new List<string>(this.drugInList.Count);
            decimal jobCash = decimal.Zero;
            decimal saleCash = decimal.Zero;
            foreach (DrugShop.Entities.PIn drugIn in this.drugInList)
            {
                jobCash += drugIn.JobPrice * drugIn.Number;
                saleCash += drugIn.SalePrice * drugIn.Number;
            }

            this.lbTip.Text = "共有药品记录" + drugInList.Count.ToString() + "个，总金额" + saleCash.ToString("F2") + "元";
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            ProviderSelect input = new ProviderSelect();

            if (input.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                this.tbProvider.Tag = input.Provider.ID;
                this.tbProvider.Text = input.Provider.Name;
            }
        }

        private void tbSeach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SeachDrugIn();
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            this.SeachDrugIn();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //内嵌打开。
            EAS.GReport.Controls.GDisplayViewer printViewer = new EAS.GReport.Controls.GDisplayViewer();
            printViewer.ReportID = new Guid("598FAEFA-F8B8-44FB-9DCD-3EA1C3EDEA00");
            printViewer.DataObject = this.drugInList;
            EAS.Application.Instance.OpenModule(printViewer);

            //独立打开
            EAS.GReport.Controls.PrintViewDialog viewDialog = new EAS.GReport.Controls.PrintViewDialog();
            viewDialog.WindowState = FormWindowState.Maximized;
            viewDialog.ReportID = new Guid("598FAEFA-F8B8-44FB-9DCD-3EA1C3EDEA00");
            viewDialog.DataObject = this.drugInList;
            viewDialog.ShowDialog(this.ParentForm);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //药品类型
            DataGridViewHelper.GetDrugTypeName(this.dataGridView1, e, "Type");
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
