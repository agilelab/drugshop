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
    public partial class ConditionControl : UserControl
    {
        public ConditionControl()
        {
            InitializeComponent();
        }

        public event EventHandler SearchHander;

        public void OnSearch(object sender, EventArgs e)
        {
            if (SearchHander != null)
                SearchHander(sender, e);
        }

        public virtual void InitControlInfo()
        {
        }
    }
}
