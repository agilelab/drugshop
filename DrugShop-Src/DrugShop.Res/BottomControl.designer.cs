namespace DrugShop.Res
{
    partial class BottomControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sbMessage = new System.Windows.Forms.StatusBar();
            this.sbPanelTitle = new System.Windows.Forms.StatusBarPanel();
            this.sbPanelMessage = new System.Windows.Forms.StatusBarPanel();
            this.sbPanelLogin = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // sbMessage
            // 
            this.sbMessage.Location = new System.Drawing.Point(0, 0);
            this.sbMessage.Name = "sbMessage";
            this.sbMessage.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sbPanelTitle,
            this.sbPanelMessage,
            this.sbPanelLogin});
            this.sbMessage.ShowPanels = true;
            this.sbMessage.Size = new System.Drawing.Size(762, 25);
            this.sbMessage.TabIndex = 9;
            // 
            // sbPanelTitle
            // 
            this.sbPanelTitle.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sbPanelTitle.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.sbPanelTitle.Name = "sbPanelTitle";
            this.sbPanelTitle.Text = "系统消息";
            this.sbPanelTitle.Width = 64;
            // 
            // sbPanelMessage
            // 
            this.sbPanelMessage.MinWidth = 0;
            this.sbPanelMessage.Name = "sbPanelMessage";
            this.sbPanelMessage.Text = "准备就绪．．．";
            this.sbPanelMessage.Width = 600;
            // 
            // sbPanelLogin
            // 
            this.sbPanelLogin.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sbPanelLogin.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.sbPanelLogin.MinWidth = 180;
            this.sbPanelLogin.Name = "sbPanelLogin";
            this.sbPanelLogin.Text = "系统管理员(Administrator)";
            this.sbPanelLogin.Width = 180;
            // 
            // BottomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sbMessage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BottomControl";
            this.Size = new System.Drawing.Size(762, 25);
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbPanelLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar sbMessage;
        private System.Windows.Forms.StatusBarPanel sbPanelTitle;
        private System.Windows.Forms.StatusBarPanel sbPanelMessage;
        private System.Windows.Forms.StatusBarPanel sbPanelLogin;
    }
}
