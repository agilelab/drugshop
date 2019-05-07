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
    /// 药品出库查询
    /// </summary>
    [Module("B8EA8BDA-5565-4EC1-A83F-E64BDF237B01", "药品销售查询", "药品销售信息查询")]
    public partial class DrugSaleQuery : UserControl
    {
        private IList<SOut> drugOutList;

        [ModuleStart()]
        public void StartEx()
        {
            this.Initialize();
        }

        public DrugSaleQuery()
        {
            InitializeComponent();
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Enter };
        }

        internal void Initialize()
        {
            this.ledClock.DateTime = XContext.CurrentTime;
            this.dtpStart.Value = XContext.CurrentTime;
            this.dtpEnd.Value = XContext.CurrentTime;
            this.Viewer.ReportID = new Guid("04F25701-57A7-412C-BD41-31DF116634C0");
        }

        internal void SeachDrugOut()
        {
            if (this.drugOutList == null)
            {
                this.drugOutList = new List<SOut>();
            }

            this.drugOutList= ServiceContainer.GetService<IDrugOutService>().GetDrugOutList(this.tbCustomName.Text.Trim(), this.tbSeach.Text, this.dtpStart.Value, this.dtpEnd.Value);
            this.Viewer.DataObject = this.drugOutList;
        }

        private void tbSeach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SeachDrugOut();
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            this.SeachDrugOut();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Viewer.PrintView();
        }
    }
}
