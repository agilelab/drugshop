using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrugShop.UI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        #region 进入\退出 控件焦点

        public void Control_Enter(object sender)
        {
            System.Windows.Forms.Control ctrl = sender as System.Windows.Forms.Control;

            ctrl.BackColor = System.Drawing.Color.FromArgb(0xC0, 0xFF, 0xC0);
            ctrl.ForeColor = System.Drawing.Color.Red;

            if (ctrl is System.Windows.Forms.ComboBox)
            {
                ((System.Windows.Forms.ComboBox)ctrl).DroppedDown = true;
            }
            else if (ctrl is System.Windows.Forms.TextBox)
            {
                ((System.Windows.Forms.TextBox)ctrl).SelectAll();
            }
        }

        public void Control_Leave(object sender)
        {
            System.Windows.Forms.Control ctrl = sender as System.Windows.Forms.Control;

            ctrl.BackColor = System.Drawing.Color.White;
            ctrl.ForeColor = System.Drawing.Color.Black;
        }

        #endregion
    }
}
