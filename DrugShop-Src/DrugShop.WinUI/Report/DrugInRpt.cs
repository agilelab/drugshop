using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using EAS.Services;
using DrugShop.Entities;
using EAS.Data.ORM;
using DrugShop.BLL;
using DrugShop.WinUI.RDL;

namespace DrugShop.WinUI
{
     [Module("A69C11A5-CE7A-43A0-ABFA-71FC0CF9D4DE", "药品入库报表", "药品入库报表")]
    public partial class DrugInRpt : BaseReport
    {
        public DrugInRpt()
        {
            InitializeComponent();
        }

        [ModuleStart()]
        public void StartEx()
        {
            this.InitInfo();
        }

        public override void InitInfo()
        {
            this.ReportTitle = "药品入库报表";

            this.ContentControl = new DrugInSeachControl();
        }

        public override void Begin_Seach(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DrugInSeachControl searchControl = this.ContentControl as DrugInSeachControl;

                this.Report.Name = "药店入库报表";
                this.Report.Read();
                //this.Report.Define = RDLHelper.GetRDLDefine("药品入库报表");

                //统计数据
                IList<PIn> DataList = new List<PIn>();
                DataList = ServiceContainer.GetService<IDrugInService>().GetDrugInList("", "", DateTime.Now.AddDays(-100), DateTime.Now.AddDays(100));

                this.ShowReport = this.Report;
                this.DataSource = DataList;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
