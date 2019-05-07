namespace DrugShop.Res
{
    partial class TabShell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabShell));
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.mifExit = new DevComponents.DotNetBar.ButtonItem();
            this.btnLogin = new DevComponents.DotNetBar.ButtonItem();
            this.btnWindows = new DevComponents.DotNetBar.ButtonItem();
            this.btnCloseCurrentWindow = new DevComponents.DotNetBar.ButtonItem();
            this.btnCloseAllWindow = new DevComponents.DotNetBar.ButtonItem();
            this.btnChangePass = new DevComponents.DotNetBar.ButtonItem();
            this.panBottom = new System.Windows.Forms.Panel();
            this.navMainTool = new System.Windows.Forms.Panel();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite9 = new DevComponents.DotNetBar.DockSite();
            this.barDocuments = new DevComponents.DotNetBar.Bar();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.barMenu = new DevComponents.DotNetBar.Bar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.bottomControl1 = new DrugShop.Res.BottomControl();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            this.panBottom.SuspendLayout();
            this.dockSite9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDocuments)).BeginInit();
            this.dockSite7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
            this.bar2.AccessibleName = "DotNetBar Bar";
            this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mifExit,
            this.btnLogin,
            this.btnWindows,
            this.btnChangePass});
            this.bar2.Location = new System.Drawing.Point(0, 26);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(933, 41);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bar2.TabIndex = 62;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // mifExit
            // 
            this.mifExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.mifExit.Image = ((System.Drawing.Image)(resources.GetObject("mifExit.Image")));
            this.mifExit.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.mifExit.Name = "mifExit";
            this.mifExit.Text = "退出";
            this.mifExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Text = "重新登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnWindows
            // 
            this.btnWindows.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnWindows.Image = ((System.Drawing.Image)(resources.GetObject("btnWindows.Image")));
            this.btnWindows.Name = "btnWindows";
            this.btnWindows.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCloseCurrentWindow,
            this.btnCloseAllWindow});
            this.btnWindows.Text = "窗口";
            // 
            // btnCloseCurrentWindow
            // 
            this.btnCloseCurrentWindow.Name = "btnCloseCurrentWindow";
            this.btnCloseCurrentWindow.Text = "关闭当前窗口";
            this.btnCloseCurrentWindow.Click += new System.EventHandler(this.btnCloseNowWindow_Click);
            // 
            // btnCloseAllWindow
            // 
            this.btnCloseAllWindow.Name = "btnCloseAllWindow";
            this.btnCloseAllWindow.Text = "关闭所有窗口";
            this.btnCloseAllWindow.Click += new System.EventHandler(this.btnCloseAllWindow_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Image")));
            this.btnChangePass.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Text = "修改密码";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.bottomControl1);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 586);
            this.panBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(933, 25);
            this.panBottom.TabIndex = 85;
            // 
            // navMainTool
            // 
            this.navMainTool.Location = new System.Drawing.Point(0, 0);
            this.navMainTool.Name = "navMainTool";
            this.navMainTool.Size = new System.Drawing.Size(200, 100);
            this.navMainTool.TabIndex = 0;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // dotNetBarManager1
            // 
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarManager1.BottomDockSite = this.dockSite4;
            this.dotNetBarManager1.EnableFullSizeDock = false;
            this.dotNetBarManager1.FillDockSite = this.dockSite9;
            this.dotNetBarManager1.LeftDockSite = this.dockSite1;
            this.dotNetBarManager1.ParentForm = this;
            this.dotNetBarManager1.RightDockSite = this.dockSite2;
            this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite8;
            this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite5;
            this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite6;
            this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite7;
            this.dotNetBarManager1.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.Location = new System.Drawing.Point(0, 611);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(933, 0);
            this.dockSite4.TabIndex = 100;
            this.dockSite4.TabStop = false;
            // 
            // dockSite9
            // 
            this.dockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite9.Controls.Add(this.barDocuments);
            this.dockSite9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockSite9.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.barDocuments, 933, 519)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite9.Location = new System.Drawing.Point(0, 67);
            this.dockSite9.Name = "dockSite9";
            this.dockSite9.Size = new System.Drawing.Size(933, 519);
            this.dockSite9.TabIndex = 105;
            this.dockSite9.TabStop = false;
            // 
            // barDocuments
            // 
            this.barDocuments.AccessibleDescription = "DotNetBar Bar (barDocuments)";
            this.barDocuments.AccessibleName = "DotNetBar Bar";
            this.barDocuments.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.barDocuments.AlwaysDisplayDockTab = true;
            this.barDocuments.CanCustomize = false;
            this.barDocuments.CanDockBottom = false;
            this.barDocuments.CanDockDocument = true;
            this.barDocuments.CanDockLeft = false;
            this.barDocuments.CanDockRight = false;
            this.barDocuments.CanDockTop = false;
            this.barDocuments.CanHide = true;
            this.barDocuments.CanUndock = false;
            this.barDocuments.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.barDocuments.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barDocuments.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.barDocuments.Location = new System.Drawing.Point(0, 0);
            this.barDocuments.Name = "barDocuments";
            this.barDocuments.Size = new System.Drawing.Size(933, 519);
            this.barDocuments.Stretch = true;
            this.barDocuments.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.barDocuments.TabIndex = 0;
            this.barDocuments.TabNavigation = true;
            this.barDocuments.TabStop = false;
            this.barDocuments.DockTabClosing += new DevComponents.DotNetBar.DockTabClosingEventHandler(this.barDocuments_DockTabClosing);
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite1.Location = new System.Drawing.Point(0, 67);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(0, 519);
            this.dockSite1.TabIndex = 97;
            this.dockSite1.TabStop = false;
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(933, 67);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 519);
            this.dockSite2.TabIndex = 98;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 611);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(933, 0);
            this.dockSite8.TabIndex = 104;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 26);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 585);
            this.dockSite5.TabIndex = 101;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(933, 26);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 585);
            this.dockSite6.TabIndex = 102;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Controls.Add(this.barMenu);
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(933, 26);
            this.dockSite7.TabIndex = 103;
            this.dockSite7.TabStop = false;
            // 
            // barMenu
            // 
            this.barMenu.AccessibleDescription = "DotNetBar Bar (barMenu)";
            this.barMenu.AccessibleName = "DotNetBar Bar";
            this.barMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.barMenu.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.barMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.barMenu.Images = this.imageList1;
            this.barMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.MenuBar = true;
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(933, 25);
            this.barMenu.Stretch = true;
            this.barMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.barMenu.TabIndex = 0;
            this.barMenu.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_closed_ii.ico");
            this.imageList1.Images.SetKeyName(1, "closed_floder.ico");
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem3});
            this.buttonItem2.Text = "buttonItem2";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "buttonItem3";
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 26);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(933, 0);
            this.dockSite3.TabIndex = 99;
            this.dockSite3.TabStop = false;
            // 
            // bottomControl1
            // 
            this.bottomControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottomControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomControl1.Location = new System.Drawing.Point(0, 0);
            this.bottomControl1.Margin = new System.Windows.Forms.Padding(0);
            this.bottomControl1.Name = "bottomControl1";
            this.bottomControl1.Size = new System.Drawing.Size(933, 25);
            this.bottomControl1.TabIndex = 0;
            // 
            // TabShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 611);
            this.Controls.Add(this.dockSite9);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "TabShell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgileEAS.NET SOA中间件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.dockSite9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barDocuments)).EndInit();
            this.dockSite7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem mifExit;
        private DevComponents.DotNetBar.ButtonItem btnLogin;
        private DevComponents.DotNetBar.ButtonItem btnWindows;
        private DevComponents.DotNetBar.ButtonItem btnCloseCurrentWindow;
        private DevComponents.DotNetBar.ButtonItem btnCloseAllWindow;
        private DevComponents.DotNetBar.ButtonItem btnChangePass;
        private System.Windows.Forms.Panel navMainTool;
        private System.Windows.Forms.Panel panBottom;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite9;
        private DevComponents.DotNetBar.Bar barDocuments;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.Bar barMenu;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private BottomControl bottomControl1;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
    }
}