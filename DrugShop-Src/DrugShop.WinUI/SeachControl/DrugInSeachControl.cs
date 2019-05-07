using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrugShop.WinUI
{
    public partial class DrugInSeachControl : ConditionControl
    {
        public DrugInSeachControl()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.OnSearch(sender, e);
        }
    }
}
