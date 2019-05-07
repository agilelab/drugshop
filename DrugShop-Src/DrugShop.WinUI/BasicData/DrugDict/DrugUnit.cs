using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DrugShop.WinUI
{
    public partial class DrugUnit : UserControl
    {

        public DrugUnit()
        {
            InitializeComponent();

            this.tbNumber.Text = "";
            this.tbLUnit.Text = "";
            this.tbBUnit.Text = "";
        }

        protected override void OnResize(EventArgs e)
        {
            this.Width = 159;
            this.Height = 23;

            base.OnResize(e);
        }

        public System.Drawing.Color TextBackColor
        {
            get
            {
                return this.tbNumber.BackColor;
            }
            set
            {
                this.tbNumber.BackColor = value;
                this.tbBUnit.BackColor = value;
                this.tbLUnit.BackColor = value;
            }
        }

        public System.Drawing.Color TextForeColor
        {
            get
            {
                return this.tbNumber.ForeColor;
            }
            set
            {
                this.tbNumber.ForeColor = value;
                this.tbBUnit.ForeColor = value;
                this.tbLUnit.ForeColor = value;
            }
        }

        public string Content
        {
            get
            {
                return this.tbNumber.Text + "*" + this.tbLUnit.Text + "/" + this.tbBUnit.Text;
            }
            set
            {
                if (value == null)
                    return;

                if (value == "")
                    return;

                string [] sv  = value.Split('*');

                this.tbNumber.Text = sv[0];

                if (sv.Length > 1)
                {
                    sv = sv[1].Split('/');

                    this.tbLUnit.Text = sv[0];
                    if(sv.Length > 1)
                    {
                        this.tbBUnit.Text = sv[1];
                    }
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down) | (e.KeyCode == Keys.PageDown) | (e.KeyCode == Keys.Right) | (e.KeyCode == Keys.Enter))
            {
                this.tbLUnit.Focus();
                this.tbLUnit.SelectAll();
            }
        }

        private void tbLUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down) | (e.KeyCode == Keys.PageDown) | (e.KeyCode == Keys.Right) | (e.KeyCode == Keys.Enter))
            {
                this.tbBUnit.Focus();
                this.tbBUnit.SelectAll(); 
            }
            else if ((e.KeyCode == Keys.Up) | (e.KeyCode == Keys.PageUp) | (e.KeyCode == Keys.Left))
            {
                this.tbNumber.Focus();
                this.tbNumber.SelectAll();
            }
        }

        private void tbBUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Up) | (e.KeyCode == Keys.PageUp) | (e.KeyCode == Keys.Left))
            {
                this.tbLUnit.Focus();
                this.tbLUnit.SelectAll();
            }
        }
    }
}
