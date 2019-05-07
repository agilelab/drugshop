using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EAS.Services;

namespace DrugShop.WinUI
{
    public partial class DrugInOutSearchControl : ConditionControl
    {
        public DrugInOutSearchControl()
        {
            InitializeComponent();
        }

        #region  Ù–‘

        public DateTime StartTime
        {
            get
            {
                return this.dtpStart.Value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return this.dtpEnd.Value;
            }
        }

        #endregion

        public override void InitControlInfo()
        {
            //this.dtpStart.Value = DateTimeClient.CurrentTime;
            InitSCountControl();
        }

        private void InitSCountControl()
        {
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            this.OnSearch(sender,e);
        }
    }
}
