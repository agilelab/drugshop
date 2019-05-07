using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DrugShop.Res
{
    partial class Banner : UserControl
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

        #region 组件设计器生成的代码
        /// <summary> 
        /// 设计器支持所需的方法 - 不要使用代码编辑器 
        /// 修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.llLogout = new System.Windows.Forms.LinkLabel();
            this.lbPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llLogout
            // 
            this.llLogout.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.llLogout.AutoSize = true;
            this.llLogout.BackColor = System.Drawing.Color.Transparent;
            this.llLogout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llLogout.ForeColor = System.Drawing.Color.Blue;
            this.llLogout.Location = new System.Drawing.Point(984, 41);
            this.llLogout.Name = "llLogout";
            this.llLogout.Size = new System.Drawing.Size(29, 12);
            this.llLogout.TabIndex = 7;
            this.llLogout.TabStop = true;
            this.llLogout.Text = "注销";
            this.llLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llLogout.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogout_LinkClicked);
            // 
            // lbPassword
            // 
            this.lbPassword.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPassword.ForeColor = System.Drawing.Color.Blue;
            this.lbPassword.Location = new System.Drawing.Point(917, 41);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 12);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.TabStop = true;
            this.lbPassword.Text = "修改密码";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPassword.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbPassword_LinkClicked);
            // 
            // Banner
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.llLogout);
            this.Name = "Banner";
            this.Size = new System.Drawing.Size(1024, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.LinkLabel llLogout;
        private System.Windows.Forms.LinkLabel lbPassword;
    }
}