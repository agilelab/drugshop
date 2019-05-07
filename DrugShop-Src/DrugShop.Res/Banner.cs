using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DrugShop.Res
{
	partial class Banner :UserControl
	{
        Image left = null;
        Image back=null;
        Image right = null;
		public Banner()
		{
			InitializeComponent();
		}

        protected override void OnLoad(EventArgs e)
        {
            left = Properties.Resources.left;
            back = Properties.Resources.bj;
            right = Properties.Resources.right;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GuiResize();
        }

        void GuiResize()
        {
            this.lbPassword.Left = this.Width - 128;
            this.llLogout.Left = this.Width - 50;
            this.lbPassword.Top = this.llLogout.Top = this.Height - 15;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;

            if (this.back != null)
            {
                g.DrawImage(this.back, 0, 0, this.Width, this.Height);
            }

            if (this.left != null)
            {
                g.DrawImage(this.left, 0, 0, this.left.Width, this.Height);
            }

            if (this.right != null)
            {
                g.DrawImage(this.right, this.left.Width, 0, this.Width-this.left.Width, this.Height);
            }            
        }

        private void lbPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (EAS.Application.Instance as EAS.Windows.IApplication).ChangePassword();
        }

        private void llLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (EAS.Application.Instance as EAS.Windows.IApplication).Logout();
        }
	}
}
