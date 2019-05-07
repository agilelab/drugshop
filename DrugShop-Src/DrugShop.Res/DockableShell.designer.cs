namespace DrugShop.Res
{
    partial class DockableShell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockableShell));
            this.mainmenu = new DevComponents.DotNetBar.Bar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnLogin = new DevComponents.DotNetBar.ButtonItem();
            this.btnLogout = new DevComponents.DotNetBar.ButtonItem();
            this.btnCPassword = new DevComponents.DotNetBar.ButtonItem();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.btnView = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.btnCloseAll = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelp = new DevComponents.DotNetBar.ButtonItem();
            this.btnContext = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.btnAbout = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.textBoxItem1 = new DevComponents.DotNetBar.TextBoxItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panBottom = new DevComponents.DotNetBar.PanelEx();
            this.bottomControl1 = new DrugShop.Res.BottomControl();
            this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite9 = new DevComponents.DotNetBar.DockSite();
            this.barDocuments = new DevComponents.DotNetBar.Bar();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.barNavigation = new DevComponents.DotNetBar.Bar();
            this.panNavigation = new DevComponents.DotNetBar.PanelDockContainer();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSystem = new DevComponents.DotNetBar.ButtonItem();
            this.item_100 = new DevComponents.DotNetBar.ButtonItem();
            this.item_111 = new DevComponents.DotNetBar.ButtonItem();
            this.item_122 = new DevComponents.DotNetBar.ButtonItem();
            this.item_133 = new DevComponents.DotNetBar.ButtonItem();
            this.item_144 = new DevComponents.DotNetBar.ButtonItem();
            this.item_155 = new DevComponents.DotNetBar.ButtonItem();
            this.item_166 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenu)).BeginInit();
            this.panBottom.SuspendLayout();
            this.dockSite9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDocuments)).BeginInit();
            this.dockSite1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barNavigation)).BeginInit();
            this.barNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.AccessibleDescription = "DotNetBar Bar (mainmenu)";
            this.mainmenu.AccessibleName = "DotNetBar Bar";
            this.mainmenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.mainmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainmenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.mainmenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.btnView,
            this.btnHelp});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.LockDockPosition = true;
            this.mainmenu.MenuBar = true;
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(986, 25);
            this.mainmenu.Stretch = true;
            this.mainmenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.mainmenu.TabIndex = 1;
            this.mainmenu.TabStop = false;
            this.mainmenu.Text = "Main Menu";
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalName = "item_67";
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLogin,
            this.btnLogout,
            this.btnCPassword,
            this.btnExit});
            this.buttonItem1.Text = "系统(&S)";
            // 
            // btnLogin
            // 
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Text = "登录(&L)";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ImageIndex = 10;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Text = "注销(&O)";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCPassword
            // 
            this.btnCPassword.BeginGroup = true;
            this.btnCPassword.Name = "btnCPassword";
            this.btnCPassword.Text = "修改密码";
            this.btnCPassword.Click += new System.EventHandler(this.btnCPassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.BeginGroup = true;
            this.btnExit.Name = "btnExit";
            this.btnExit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnExit.Text = "退出(&E)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Name = "btnView";
            this.btnView.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClose,
            this.btnCloseAll});
            this.btnView.Text = "视图(&V)";
            // 
            // btnClose
            // 
            this.btnClose.GlobalName = "item_237";
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "关闭当前模块";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.GlobalName = "item_248";
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Text = "关闭所有模块";
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnContext,
            this.buttonItem2,
            this.buttonItem3,
            this.btnAbout});
            this.btnHelp.Text = "帮助(&H)";
            // 
            // btnContext
            // 
            this.btnContext.Name = "btnContext";
            this.btnContext.Text = "内容";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "搜索";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "索引";
            // 
            // btnAbout
            // 
            this.btnAbout.BeginGroup = true;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Text = "关于";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // buttonItem11
            // 
            this.buttonItem11.GlobalName = "item_167";
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem12,
            this.buttonItem13,
            this.buttonItem14,
            this.buttonItem15,
            this.buttonItem16,
            this.buttonItem17,
            this.buttonItem18,
            this.textBoxItem1});
            this.buttonItem11.Text = "&Edit";
            // 
            // buttonItem12
            // 
            this.buttonItem12.GlobalName = "item_237";
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.buttonItem12.Text = "&Undo";
            // 
            // buttonItem13
            // 
            this.buttonItem13.GlobalName = "item_248";
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.buttonItem13.Text = "&Redo";
            // 
            // buttonItem14
            // 
            this.buttonItem14.BeginGroup = true;
            this.buttonItem14.GlobalName = "item_259";
            this.buttonItem14.ImageIndex = 5;
            this.buttonItem14.Name = "buttonItem14";
            this.buttonItem14.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.buttonItem14.Text = "Cut";
            // 
            // buttonItem15
            // 
            this.buttonItem15.GlobalName = "item_270";
            this.buttonItem15.ImageIndex = 4;
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.buttonItem15.Text = "Copy";
            // 
            // buttonItem16
            // 
            this.buttonItem16.GlobalName = "item_281";
            this.buttonItem16.ImageIndex = 11;
            this.buttonItem16.Name = "buttonItem16";
            this.buttonItem16.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.buttonItem16.Text = "Paste";
            // 
            // buttonItem17
            // 
            this.buttonItem17.GlobalName = "item_292";
            this.buttonItem17.Name = "buttonItem17";
            this.buttonItem17.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.buttonItem17.Text = "Delete";
            // 
            // buttonItem18
            // 
            this.buttonItem18.GlobalName = "item_303";
            this.buttonItem18.Name = "buttonItem18";
            this.buttonItem18.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.buttonItem18.Text = "Select All";
            // 
            // textBoxItem1
            // 
            this.textBoxItem1.Name = "textBoxItem1";
            this.textBoxItem1.Text = "textBoxItem1";
            this.textBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            this.imageList2.Images.SetKeyName(6, "");
            this.imageList2.Images.SetKeyName(7, "");
            this.imageList2.Images.SetKeyName(8, "");
            // 
            // panBottom
            // 
            this.panBottom.CanvasColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panBottom.Controls.Add(this.bottomControl1);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 437);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(986, 28);
            this.panBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panBottom.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panBottom.Style.GradientAngle = 90;
            this.panBottom.TabIndex = 7;
            this.panBottom.Text = "panBottom";
            // 
            // bottomControl1
            // 
            this.bottomControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottomControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomControl1.Location = new System.Drawing.Point(0, 0);
            this.bottomControl1.Margin = new System.Windows.Forms.Padding(0);
            this.bottomControl1.Name = "bottomControl1";
            this.bottomControl1.Size = new System.Drawing.Size(986, 28);
            this.bottomControl1.TabIndex = 1;
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
            this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
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
            this.dockSite4.Location = new System.Drawing.Point(0, 465);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(986, 0);
            this.dockSite4.TabIndex = 11;
            this.dockSite4.TabStop = false;
            // 
            // dockSite9
            // 
            this.dockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite9.Controls.Add(this.barDocuments);
            this.dockSite9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockSite9.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.barDocuments, 786, 412)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite9.Location = new System.Drawing.Point(200, 25);
            this.dockSite9.Name = "dockSite9";
            this.dockSite9.Size = new System.Drawing.Size(786, 412);
            this.dockSite9.TabIndex = 16;
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
            this.barDocuments.Size = new System.Drawing.Size(786, 412);
            this.barDocuments.Stretch = true;
            this.barDocuments.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.barDocuments.TabIndex = 0;
            this.barDocuments.TabNavigation = true;
            this.barDocuments.TabStop = false;
            this.barDocuments.DockTabClosing += new DevComponents.DotNetBar.DockTabClosingEventHandler(this.barDocuments_DockTabClosing);
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Controls.Add(this.barNavigation);
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.barNavigation, 197, 412)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.dockSite1.Location = new System.Drawing.Point(0, 25);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(200, 412);
            this.dockSite1.TabIndex = 8;
            this.dockSite1.TabStop = false;
            // 
            // barNavigation
            // 
            this.barNavigation.AccessibleDescription = "DotNetBar Bar (barNavigation)";
            this.barNavigation.AccessibleName = "DotNetBar Bar";
            this.barNavigation.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.barNavigation.AutoSyncBarCaption = true;
            this.barNavigation.CloseSingleTab = true;
            this.barNavigation.Controls.Add(this.panNavigation);
            this.barNavigation.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barNavigation.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.barNavigation.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.dockContainerItem1});
            this.barNavigation.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.barNavigation.Location = new System.Drawing.Point(0, 0);
            this.barNavigation.Name = "barNavigation";
            this.barNavigation.Size = new System.Drawing.Size(197, 412);
            this.barNavigation.Stretch = true;
            this.barNavigation.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.barNavigation.TabIndex = 0;
            this.barNavigation.TabStop = false;
            this.barNavigation.Text = "导航栏";
            // 
            // panNavigation
            // 
            this.panNavigation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panNavigation.Location = new System.Drawing.Point(3, 23);
            this.panNavigation.Name = "panNavigation";
            this.panNavigation.Size = new System.Drawing.Size(191, 386);
            this.panNavigation.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panNavigation.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panNavigation.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panNavigation.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panNavigation.Style.GradientAngle = 90;
            this.panNavigation.TabIndex = 0;
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Control = this.panNavigation;
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "导航栏";
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(986, 25);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 412);
            this.dockSite2.TabIndex = 9;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 465);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(986, 0);
            this.dockSite8.TabIndex = 15;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 0);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 465);
            this.dockSite5.TabIndex = 12;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(986, 0);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 465);
            this.dockSite6.TabIndex = 13;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(986, 0);
            this.dockSite7.TabIndex = 14;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 0);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(986, 0);
            this.dockSite3.TabIndex = 10;
            this.dockSite3.TabStop = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // btnSystem
            // 
            this.btnSystem.GlobalName = "btnSystem";
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.item_100,
            this.item_111,
            this.item_122,
            this.item_133,
            this.item_144,
            this.item_155,
            this.item_166});
            this.btnSystem.Text = "系统(&S)";
            // 
            // item_100
            // 
            this.item_100.GlobalName = "item_100";
            this.item_100.Name = "item_100";
            this.item_100.Text = "&Close";
            // 
            // item_111
            // 
            this.item_111.BeginGroup = true;
            this.item_111.GlobalName = "item_111";
            this.item_111.Name = "item_111";
            this.item_111.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftA);
            this.item_111.Text = "Add Ne&w Item";
            // 
            // item_122
            // 
            this.item_122.GlobalName = "item_122";
            this.item_122.Name = "item_122";
            this.item_122.Text = "Add Existin&g Item";
            // 
            // item_133
            // 
            this.item_133.GlobalName = "item_133";
            this.item_133.Name = "item_133";
            this.item_133.Text = "A&dd Project";
            // 
            // item_144
            // 
            this.item_144.BeginGroup = true;
            this.item_144.GlobalName = "item_144";
            this.item_144.Name = "item_144";
            this.item_144.Text = "Open Solution";
            // 
            // item_155
            // 
            this.item_155.GlobalName = "item_155";
            this.item_155.Name = "item_155";
            this.item_155.Text = "Close Solution";
            // 
            // item_166
            // 
            this.item_166.BeginGroup = true;
            this.item_166.GlobalName = "item_166";
            this.item_166.Name = "item_166";
            this.item_166.Text = "&Exit";
            // 
            // DockableShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 465);
            this.Controls.Add(this.dockSite9);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.mainmenu);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Name = "DockableShell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgileEAS.NET SOA中间件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mainmenu)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.dockSite9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barDocuments)).EndInit();
            this.dockSite1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barNavigation)).EndInit();
            this.barNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar mainmenu;
        private DevComponents.DotNetBar.ButtonItem btnView;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.ButtonItem btnCloseAll;
        private DevComponents.DotNetBar.ButtonItem buttonItem11;
        private DevComponents.DotNetBar.ButtonItem buttonItem12;
        private DevComponents.DotNetBar.ButtonItem buttonItem13;
        private DevComponents.DotNetBar.ButtonItem buttonItem14;
        private DevComponents.DotNetBar.ButtonItem buttonItem15;
        private DevComponents.DotNetBar.ButtonItem buttonItem16;
        private DevComponents.DotNetBar.ButtonItem buttonItem17;
        private DevComponents.DotNetBar.ButtonItem buttonItem18;
        private DevComponents.DotNetBar.TextBoxItem textBoxItem1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevComponents.DotNetBar.PanelEx panBottom;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.DockSite dockSite9;
        private DevComponents.DotNetBar.Bar barDocuments;
        private DevComponents.DotNetBar.Bar barNavigation;
        private DevComponents.DotNetBar.PanelDockContainer panNavigation;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem btnHelp;
        private DevComponents.DotNetBar.ButtonItem btnSystem;
        private DevComponents.DotNetBar.ButtonItem item_100;
        private DevComponents.DotNetBar.ButtonItem item_111;
        private DevComponents.DotNetBar.ButtonItem item_122;
        private DevComponents.DotNetBar.ButtonItem item_133;
        private DevComponents.DotNetBar.ButtonItem item_144;
        private DevComponents.DotNetBar.ButtonItem item_155;
        private DevComponents.DotNetBar.ButtonItem item_166;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnLogin;
        private DevComponents.DotNetBar.ButtonItem btnLogout;
        private DevComponents.DotNetBar.ButtonItem btnCPassword;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.ButtonItem btnContext;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem btnAbout;
        private BottomControl bottomControl1;
    }
}