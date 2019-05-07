using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrugShop.Res
{
    partial class PasswordBox
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PasswordBox));
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tbCPassword = new System.Windows.Forms.TextBox();
            this.labelCPassword = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbxIcon.Image")));
            this.pbxIcon.Location = new System.Drawing.Point(16, 16);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(48, 48);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(133, 80);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(240, 21);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "";
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(30, 80);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "新密码(&P)：";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCPassword
            // 
            this.tbCPassword.Location = new System.Drawing.Point(133, 120);
            this.tbCPassword.Name = "tbCPassword";
            this.tbCPassword.PasswordChar = '*';
            this.tbCPassword.Size = new System.Drawing.Size(240, 21);
            this.tbCPassword.TabIndex = 4;
            this.tbCPassword.Text = "";
            // 
            // labelCPassword
            // 
            this.labelCPassword.Location = new System.Drawing.Point(30, 120);
            this.labelCPassword.Name = "labelCPassword";
            this.labelCPassword.TabIndex = 3;
            this.labelCPassword.Text = "确认新密码(&C)：";
            this.labelCPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOK.Location = new System.Drawing.Point(208, 160);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "确定";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCancel.Location = new System.Drawing.Point(298, 160);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "取消";
            // 
            // labelTip
            // 
            this.labelTip.Location = new System.Drawing.Point(80, 16);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(304, 48);
            this.labelTip.TabIndex = 0;
            this.labelTip.Text = "    注意：请牢牢记住您设置的密码。密码应该具有一定的长度（大于等于6），并且应该使用字母、数字、以及其他字符的组合，以使密码具有一定的复杂度。";
            // 
            // PasswordBox
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(402, 191);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbCPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelCPassword);
            this.Controls.Add(this.pbxIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置密码";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelCPassword;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.TextBox tbCPassword;
    }
}
