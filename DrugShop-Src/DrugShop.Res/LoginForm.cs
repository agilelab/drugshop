using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using EAS.Configuration;
using System.IO;
using EAS.Services;
using EAS.Modularization;
using EAS.Explorer;

namespace DrugShop.Res
{
    partial class LoginForm : Form, ILoginForm
    {
        int passed;
        object[] loginInfo;

        public LoginForm()
        {
            InitializeComponent();

            this.passed = 0;
            this.loginInfo = null;

            this.txtPassword.Text = string.Empty;

            this.Width = 475;
            this.Height = 310;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.TopMost = true;

            this.cmbLoginID.Items.Clear();
            string users = ConfigReader.Instance.Read("WorkstationUser");

            if (users == null || users.Trim().Length == 0)
            {
                this.cmbLoginID.Items.Add("Administrator");
                this.cmbLoginID.SelectedIndex = 0;
                base.OnLoad(e);
                return;
            }
            string[] vusers = users.Split(';');
            foreach (string user in vusers)
            {
                this.cmbLoginID.Items.Add(user);
            }

            string lastuser = ConfigReader.Instance.Read("LastUser");
            if (this.cmbLoginID.Items.Count > 0)
            {
                if (lastuser != null && this.cmbLoginID.Items.Contains(lastuser))
                    this.cmbLoginID.SelectedItem = lastuser;
                else
                    this.cmbLoginID.SelectedIndex = 0;
            }
            else
            {
                this.cmbLoginID.Items.Add("Administrator");
                this.cmbLoginID.SelectedIndex = 0;
            }

            this.lblLoginID.Enabled = true;
            this.lblPassword.Enabled = true;
            this.cmbLoginID.Enabled = true;
            this.txtPassword.Enabled = true;
            this.chkSmartLogin.Enabled = true;
            this.btnOK.Enabled = true;
            this.btnCancel.Enabled = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            e.Cancel = this.passed == -1;
            if (this.passed == -1)
                this.passed = 0;
        }

        protected override void OnClosed(EventArgs e)
        {
            this.TopMost = false;
            base.OnClosed(e);
        }

        /// <summary>
        /// 获取或者设置一个值，该值只是用户是否通过验证。
        /// </summary>
        public bool Passed
        {
            get
            {
                return this.passed == 1;
            }
        }

        /// <summary>
        /// 获取正在登录的用户的登录ID。
        /// </summary>
        string LoginID
        {
            get
            {
                return this.cmbLoginID.Text;
            }
        }

        /// <summary>
        /// 获取正在登录的用户的登录密码。
        /// </summary>
        string Password
        {
            get
            {
                return this.txtPassword.Text;
            }
        }

        internal object[] LoginInfo
        {
            get
            {
                return this.loginInfo;
            }
        }

        void btnOK_Click(object sender, System.EventArgs e)
        {
            if (string.Compare("Guest", this.cmbLoginID.Text.Trim(), true) == 0)
            {
                this.passed = -1;
                MessageBox.Show(this, "Guest用户不充许登录", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.cmbLoginID.Focus();
            }

            this.lblLoginID.Enabled = false;
            this.lblPassword.Enabled = false;
            this.cmbLoginID.Enabled = false;
            this.txtPassword.Enabled = false;
            this.chkSmartLogin.Enabled = false;
            this.btnOK.Enabled = false;
            this.btnCancel.Enabled = false;
            this.Refresh();

            try
            {
                (EAS.Application.Instance as EAS.Windows.Application).Login(this.cmbLoginID.Text, this.txtPassword.Text);
                this.passed = 1;
            }
            catch (System.Exception exc)
            {
                this.passed = -1;
                if (exc.InnerException != null)
                    MessageBox.Show(this, exc.InnerException.Message, "未能通过验证", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(this, "用户验证过程中出现未知错误，请记录下面的异常信息，并通知您的系统管理员。\n\n" + exc.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.lblLoginID.Enabled = true;
                this.lblPassword.Enabled = true;
                this.cmbLoginID.Enabled = true;
                this.txtPassword.Enabled = true;
                this.chkSmartLogin.Enabled = true;
                this.btnOK.Enabled = true;
                this.btnCancel.Enabled = true;
                this.btnCancel.Focus();
                return;
            }

            this.txtPassword.Text = string.Empty;

            try
            {
                if (this.chkSmartLogin.Checked)
                {
                    string users = ConfigReader.Instance.Read("WorkstationUser");

                    if (users != null)
                    {
                        if (users.Length == 0)
                        {
                            ConfigReader.Instance.Write("WorkstationUser", this.cmbLoginID.Text);
                            ConfigReader.Instance.Write("LastUser", this.cmbLoginID.Text);
                        }
                        else
                        {
                            string[] vusers = users.Split(';');
                            if (!((System.Collections.IList)vusers).Contains(this.cmbLoginID.Text))
                            {
                                ConfigReader.Instance.Write("WorkstationUser", users + ";" + this.cmbLoginID.Text);
                                ConfigReader.Instance.Write("LastUser", this.cmbLoginID.Text);
                            }
                            else
                            {
                                ConfigReader.Instance.Write("LastUser", this.cmbLoginID.Text);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show(this, "无法为您启用智能登录功能，启用该功能可以使您的登录名称反映在用户名称列表中，该计算机会记住您曾经在这台计算机上登录过，下次登录不需要再次输入您的登录名称。\n\n但是这不会影响您现在的登录。", "启用智能登录错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtPassword_TextChanged(object sender, System.EventArgs e)
        {
            this.btnOK.Enabled = this.cmbLoginID.Text.Trim().Length > 0;
        }

        private void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

    }
}
