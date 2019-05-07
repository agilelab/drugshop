using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EAS.Modularization;
using EAS.Services;
using EAS.Explorer.BLL;

namespace DrugShop.Res
{
    [Module("5FCF96C2-F5BB-47C9-8524-0AE2511AB1E3", "密码修改", "AgileEAS.NET平台WinForm/Wpf容器密码修改模块")]
	partial class PasswordBox:Form 
	{
        [ModuleStart]
        public void Start()
        {
            System.Windows.Forms.Form shell = (EAS.Windows.Application.Instance as EAS.Windows.Application).Shell;

            this.LoginID = this.LoginID == null || this.LoginID == string.Empty ? XContext.Account.LoginID : this.LoginID;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MdiParent = null;

            if (shell != null)
                this.ShowDialog(shell);
            else
                this.ShowDialog();
        }

	    private string loginid;
		private bool canclose;

		public PasswordBox()
		{
			InitializeComponent();
			this.loginid = string.Empty;
			this.canclose = true;
			this.tbPassword.Focus();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = !this.canclose;
			this.canclose = true;
			base.OnClosing (e);
		}

		/// <summary>
		/// 获取或者设置要设置密码的帐户的登录ID。
		/// </summary>
		internal string LoginID
		{
			get
			{
				return this.loginid;
			}
			set
			{
				this.loginid = value;
			}
		} 	 

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			this.canclose = true;
			if(this.tbPassword.Text != this.tbCPassword.Text)
			{
				MessageBox.Show(this, "您两次输入的密码不一致，请重新确定密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.tbPassword.Focus();
				this.canclose = false;
				return;
			}

			if(this.tbPassword.Text == string.Empty)
			{
				if(MessageBox.Show(this, "您要将密码设置为空密码，这样会使您的工作和数据很容易被窃取。\n系统强烈建议您不要将密码设置为空密码，是否要设定密码为空密码？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
				{
					this.tbPassword.Focus();
					this.canclose = false;
					return;
				}
			}

			Cursor c = this.Cursor;
			try
			{
				this.Cursor = Cursors.WaitCursor;

                IAccountService service = ServiceContainer.GetService<IAccountService>();
                service.UpdatePassword(this.loginid, this.tbPassword.Text);
				MessageBox.Show(this, "您已经成功的修改了“" + this.loginid + "”的登录密码，请牢记您刚刚设置的密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show(this, "密码设置过程中出现了一个错误，可能是数据库出现了异常，请通知系统管理员，让他（她）帮助您解决这个问题！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.canclose = false;
				return;
			}
			finally
			{
				this.Cursor = c;
			}
		}
	}
}
