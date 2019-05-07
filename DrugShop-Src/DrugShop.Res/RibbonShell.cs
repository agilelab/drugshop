using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Explorer;
using EAS.Explorer.Entities;
using DevComponents.DotNetBar;
using EAS;
using EAS.Messages;

namespace DrugShop.Res
{
    public partial class RibbonShell : DevComponents.DotNetBar.RibbonForm, IMainShell
    {
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_CLOSE = 0xF060;

        private NavigationProxy navigationProxy = null;
        private List<object> m_AddIns = null;

        public RibbonShell()
        {
            InitializeComponent();
            this.m_AddIns = new List<object>();
        }

        /// <summary>
        /// 处理关闭事件，两次才能关闭的Bug。
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                string name = "AgileEAS.NET SOA 中间件平台";

                try
                {
                    name = XContext.ShellResource.GetApplicationTitle();
                }
                catch { }
                if (MessageBox.Show("你确定要退出\"" + name + "\"吗？", "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    XContext.AllowClose = true;
                }
                else
                {
                    return;
                }
            }

            base.WndProc(ref m);
        }

        protected override void OnLoad(EventArgs e)
        {            
            base.OnLoad(e);
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }

        #region IMainShell

        public object ActiveAddIn
        {
            get
            {
                if (this.ActiveMdiChild == null)
                    return null;
                else
                {
                    FormContainer fc = this.ActiveMdiChild as FormContainer;
                    return fc.ExplorerControl;
                }
            }
        }

        public List<object> AddIns
        {
            get
            {
                return this.m_AddIns;
            }
        }

        public void CloseModule(object module)
        {
            foreach (FormContainer item in this.MdiChildren)
            {
                if (item.ExplorerControl == module)
                {
                    item.Close();
                    return;
                }
            }
        }

        public void CloseModule()
        {
            if (this.ActiveAddIn != null)
            {
                this.CloseModule(this.ActiveAddIn);
            }
        }        

        public void OpenModule(object addIn)
        {
            if (addIn is Form)
            {
                this.LoadModule(addIn as Form);
            }
            else if (addIn is Control)
            {
                this.LoadModule(addIn as Control);
            }
            else if (addIn is System.Windows.Window)
            {
                this.LoadModule(addIn as System.Windows.Window);
            }
            else if (addIn is System.Windows.Controls.Control)
            {
                this.LoadModule(addIn as System.Windows.Controls.Control);
            }
            else
            {
                ModuleManager.StartModule(addIn, this);
            }
        }

        public void SwitchNavigation()
        {
            
        }

        public void InitializeShell(IList<INavigateGroup> m_GroupList, IList<INavigateModule> m_ModuleList)
        {
            #region 初始化设置

            try
            {
                this.Icon = (System.Drawing.Icon)XContext.ShellResource.GetMainIcon();
            }
            catch { }

            #endregion

            #region  问本显示

            string name = "AgileEAS.NET SOA 中间件平台";

            try
            {
                name = XContext.ShellResource.GetApplicationTitle();
            }
            catch { }

            this.Text = name;

            #endregion

            //关闭打开的模块。
            XContext.AllowClose = true;
            try
            {
                for (int i = m_AddIns.Count-1; i >=0;i--)
                {
                    EAS.Application.Instance.CloseModule(m_AddIns[i]);
                }
            }
            finally
            {
                XContext.AllowClose = false;
            }

            //参数。
            this.navigationProxy = new NavigationProxy();
            this.navigationProxy.GroupList = m_GroupList;
            this.navigationProxy.ModuleList = m_ModuleList;

            //导航。
            if (string.Compare(XContext.Account.LoginID, "Guest", true) == 0)
            {
                this.InitializeNavigationGuest();
            }
            else
            {
                this.InitializeNavigationPublic();
            }

            //打开起始页
            EAS.Application.Instance.OpenModule(new Resources().GetStartModule());
        }
        
        #endregion

        #region LoadModule

        void LoadModule(Form addIn)
        {
            ModuleManager.StartModule(addIn, this);
        }

        void LoadModule(System.Windows.Window addIn)
        {
            ModuleManager.StartModule(addIn, this);
        }

        void LoadModule(Control addIn)
        {
            FormContainer doc = this.FindAddInContainer(addIn);
            if (doc == null)
            {
                doc = CreateAddInContainer(addIn);
                doc.Tag = addIn;
                doc.Show();

                //注册模块。
                this.m_AddIns.Add(doc.ExplorerControl);
                //删除事件。
                doc.FormClosed += (s, e) =>
                {
                    if (this.m_AddIns.Contains(doc.ExplorerControl))
                    {
                        MessageExchange.Singleton.Unsubscribe(doc.ExplorerControl);
                        MessageExchange.RemoveNotify(doc.ExplorerControl);
                        this.m_AddIns.Remove(doc.ExplorerControl);
                    }
                };
            }
            else
            {
                AddInActivate(addIn);
            }
        }

        void LoadModule(System.Windows.Controls.Control addIn)
        {
            FormContainer doc = this.FindAddInContainer(addIn);
            if (doc == null)
            {
                doc = CreateAddInContainer(addIn);
                doc.Tag = addIn;

                //注册模块。
                this.m_AddIns.Add(doc.ExplorerControl);
                //删除事件。
                doc.FormClosed += (s, e) =>
                {
                    if (this.m_AddIns.Contains(doc.ExplorerControl))
                    {
                        MessageExchange.Singleton.Unsubscribe(doc.ExplorerControl);
                        MessageExchange.RemoveNotify(doc.ExplorerControl);
                        this.m_AddIns.Remove(doc.ExplorerControl);
                    }
                };
            }
            else
            {
                AddInActivate(addIn);
            }
        }

        #endregion

        #region Mdi Shell Document

        /// <summary>
        /// 激活插件。
        /// </summary>
        /// <param name="addIn"></param>
        void AddInActivate(object addIn)
        {
            foreach (FormContainer item in this.MdiChildren)
            {
                if (item.ExplorerControl.GetType() == addIn.GetType())
                {
                    Guid m_ID1 = ModuleManager.GetModuleGuid(item.ExplorerControl);
                    Guid m_ID2 = ModuleManager.GetModuleGuid(addIn);
                    if (m_ID1 == m_ID2)
                    {
                        this.ActivateMdiChild(item);
                    }
                }
            }
        }

        FormContainer CreateAddInContainer(object addIn)
        {
            FormContainer fc = new FormContainer(this);
            fc.Tag = addIn;

            if (addIn is Control)
            {
                fc.Start(addIn as Control);
            }
            else if (addIn is System.Windows.Controls.Control)
            {
                fc.Start(addIn as System.Windows.Controls.Control);
            }

            fc.MdiParent = this;
            fc.WindowState = FormWindowState.Maximized;
            fc.Show();
            fc.Update();
            return fc;
        }

        FormContainer FindAddInContainer(object addIn)
        {
            foreach (FormContainer fc in this.MdiChildren)
            {
                if (fc.ExplorerControl.GetType() == addIn.GetType())
                {
                    Guid m_ID1 = ModuleManager.GetModuleGuid(fc.ExplorerControl);
                    Guid m_ID2 = ModuleManager.GetModuleGuid(addIn);
                    if (m_ID1 == m_ID2)
                        return fc;
                }
            }

            return null;
        }

        #endregion

        /// <summary>
        /// 读模块图标。
        /// </summary>
        /// <param name="iconBuffer"></param>
        /// <returns></returns>
        System.Drawing.Image GetModuleImage(byte[] iconBuffer)
        {
            System.Drawing.Image image = null;
            try
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(iconBuffer))
                {
                    image = System.Drawing.Image.FromStream(ms);
                    if (image.Height > 32 || image.Width >32)
                    {
                        image = image.ZoomAuto(32, 32);
                    }
                }
            }
            catch { }

            return image;
        }

        #region 公共导航

        /// <summary>
        /// 初始导航。
        /// </summary>
        void InitializeNavigationPublic()
        {
            //清空。
            for (int i = this.ribbonControl.Items.Count - 1; i >= 0; i--)
            {
                var tabItem = this.ribbonControl.Items[i] as RibbonTabItem;
                if (tabItem != null)
                {
                    this.ribbonControl.Items.RemoveAt(i);
                    this.ribbonControl.Controls.Remove(tabItem.Panel);
                }
            }

            //初始化导航
            int mask = (int)GroupType.Windows;
            IList<INavigateGroup> rootGroups = navigationProxy.GetGroupList(Guid.Empty.ToString().ToUpper());
            int index = 0;
            foreach (var vGroup in rootGroups)  //根分组。
            {
                if ((vGroup.Attributes & mask) == mask)
                {
                    #region 一级组/RibbonTabItem

                    DevComponents.DotNetBar.RibbonPanel ribbonPanel = new DevComponents.DotNetBar.RibbonPanel();
                    ribbonPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                    ribbonPanel.Size = new System.Drawing.Size(908, 100);
                    ribbonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                    ribbonPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
                    ribbonPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                    ribbonPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
                    ribbonPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;

                    DevComponents.DotNetBar.RibbonTabItem ribbonTabItem = new DevComponents.DotNetBar.RibbonTabItem();
                    //ribbonTabItem.Checked = true;
                    ribbonTabItem.Text = vGroup.Name;
                    ribbonTabItem.Tag = vGroup;
                    ribbonTabItem.Panel = ribbonPanel;

                    //二级组
                    IList<INavigateGroup> groups = navigationProxy.GetGroupList(vGroup.ID);
                    if (groups.Count == 0)
                    {
                        groups.Add(vGroup);
                    }

                    //工作组。
                    foreach (var xGroup in groups)
                    {
                        #region 工作组/RibbonBar

                        DevComponents.DotNetBar.RibbonBar ribbonBar = new DevComponents.DotNetBar.RibbonBar();
                        ribbonBar.Text = xGroup.Name;
                        ribbonBar.Tag = xGroup;
                        ribbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;

                        var modules = navigationProxy.GetAllModuleList(xGroup.ID);
                        foreach (var module in modules)
                        {
                            DevComponents.DotNetBar.ButtonItem buttonItem = new DevComponents.DotNetBar.ButtonItem();
                            buttonItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
                            buttonItem.Text = module.Name;
                            buttonItem.Tag = module;

                            buttonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;

                            Image image = this.GetModuleImage(module.Icon);
                            if (image == null)
                            {
                                image = DrugShop.Res.Properties.Resources.buttonImage;
                            }
                            buttonItem.Image = image;

                            buttonItem.Click += new EventHandler(buttonItem_Click);
                            ribbonBar.Items.Add(buttonItem);
                        }

                        ribbonPanel.Controls.Add(ribbonBar);

                        #endregion
                    }

                    this.ribbonControl.Controls.Add(ribbonPanel);
                    this.ribbonControl.Items.Add(ribbonTabItem, 1 + index);

                    #endregion
                }
            }

            if (rootGroups.Count > 0)
            {
                this.ribbonControl.SelectedRibbonTabItem = this.ribbonControl.Items[1] as RibbonTabItem;
            }
        }

        #endregion

        #region 访客导航

        private void InitializeNavigationGuest()
        {
            //清空。
            for (int i = this.ribbonControl.Items.Count - 1; i >= 0; i--)
            {
                var tabItem = this.ribbonControl.Items[i] as RibbonTabItem;
                if (tabItem != null)
                {
                    this.ribbonControl.Items.RemoveAt(i);
                    this.ribbonControl.Controls.Remove(tabItem.Panel);
                }
            }

            //根组。
            DevComponents.DotNetBar.RibbonPanel ribbonPanel = new DevComponents.DotNetBar.RibbonPanel();
            ribbonPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ribbonPanel.Size = new System.Drawing.Size(908, 100);
            ribbonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ribbonPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            ribbonPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;

            DevComponents.DotNetBar.RibbonTabItem ribbonTabItem = new DevComponents.DotNetBar.RibbonTabItem();
            //ribbonTabItem.Checked = true;
            ribbonTabItem.Text = "相关连接";
            ribbonTabItem.Tag = null;
            ribbonTabItem.Panel = ribbonPanel;

            //工作组
            DevComponents.DotNetBar.RibbonBar ribbonBar = new DevComponents.DotNetBar.RibbonBar();
            ribbonBar.Text = ribbonTabItem.Text;
            ribbonBar.Tag = null;
            ribbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;

            //模块
            DevComponents.DotNetBar.ButtonItem buttonItem = new DevComponents.DotNetBar.ButtonItem();
            buttonItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            buttonItem.Text = "登录";
            buttonItem.Tag = typeof(LoginForm);

            buttonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItem.Image = DrugShop.Res.Properties.Resources.buttonImage;
            buttonItem.Click += new EventHandler(buttonItem_Click);
            ribbonBar.Items.Add(buttonItem);

            buttonItem = new DevComponents.DotNetBar.ButtonItem();
            buttonItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            buttonItem.Text = "关于";
            buttonItem.Tag = typeof(AboutForm);

            buttonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItem.Image = DrugShop.Res.Properties.Resources.buttonImage;
            buttonItem.Click += new EventHandler(buttonItem_Click);
            ribbonBar.Items.Add(buttonItem);

            ribbonPanel.Controls.Add(ribbonBar);

            this.ribbonControl.Controls.Add(ribbonPanel);
            this.ribbonControl.Items.Add(ribbonTabItem, 1);

            this.ribbonControl.SelectedRibbonTabItem = ribbonTabItem;
        }

        #endregion

        void buttonItem_Click(object sender, EventArgs e)
        {
            ButtonItem buttonItem = sender as ButtonItem;
            if (buttonItem.Tag is INavigateModule)
            {
                INavigateModule nv = buttonItem.Tag as INavigateModule;
                EAS.Application.Instance.OpenModule(new Guid(nv.Guid));
            }
            else if (buttonItem.Tag is System.Type)
            {
                System.Type t = buttonItem.Tag as System.Type;
                if (t == typeof(LoginForm))
                {
                    (EAS.Application.Instance as EAS.Windows.Application).Login();
                }
                else if (t == typeof(AboutForm))
                {
                    new AboutForm().ShowDialog(this);
                }
            }
        }

        private void AppCommandTheme_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
                // Using StyleManager change the style and color tinting
                if (StyleManager.IsMetro(style))
                {
                    // More customization is needed for Metro
                    // Capitalize App Button and tab

                    ////buttonFile.Text = buttonFile.Text.ToUpper();
                    ////foreach (BaseItem item in RibbonControl.Items)
                    ////{
                    ////    // Ribbon Control may contain items other than tabs so that needs to be taken in account
                    ////    RibbonTabItem tab = item as RibbonTabItem;
                    ////    if (tab != null)
                    ////        tab.Text = tab.Text.ToUpper();
                    ////}

                    buttonFile.BackstageTabEnabled = true; // Use Backstage for Metro

                    this.ribbonControl.RibbonStripFont = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    if (style == eStyle.Metro)
                        StyleManager.MetroColorGeneratorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.DarkBlue;

                    // Adjust size of switch button to match Metro styling
                    switchButtonItem1.SwitchWidth = 12;
                    switchButtonItem1.ButtonWidth = 42;
                    switchButtonItem1.ButtonHeight = 19;

                    // Adjust tab strip style
                    tabStrip1.Style = eTabStripStyle.Metro;

                    StyleManager.Style = style; // BOOM
                }
                else
                {
                    // If previous style was Metro we need to update other properties as well
                    if (StyleManager.IsMetro(StyleManager.Style))
                    {
                        this.ribbonControl.RibbonStripFont = null;
                        // Fix capitalization App Button and tab

                        ////buttonFile.Text = ToTitleCase(buttonFile.Text);
                        ////foreach (BaseItem item in RibbonControl.Items)
                        ////{
                        ////    // Ribbon Control may contain items other than tabs so that needs to be taken in account
                        ////    RibbonTabItem tab = item as RibbonTabItem;
                        ////    if (tab != null)
                        ////        tab.Text = ToTitleCase(tab.Text);
                        ////}

                        // Adjust size of switch button to match Office styling
                        switchButtonItem1.SwitchWidth = 28;
                        switchButtonItem1.ButtonWidth = 62;
                        switchButtonItem1.ButtonHeight = 20;
                    }
                    // Adjust tab strip style
                    tabStrip1.Style = eTabStripStyle.Office2007Document;
                    StyleManager.ChangeStyle(style, Color.Empty);
                    if (style == eStyle.Office2007Black || style == eStyle.Office2007Blue || style == eStyle.Office2007Silver || style == eStyle.Office2007VistaGlass)
                        buttonFile.BackstageTabEnabled = false;
                    else
                        buttonFile.BackstageTabEnabled = true;
                }
            }
            else if (source.CommandParameter is Color)
            {
                if (StyleManager.IsMetro(StyleManager.Style))
                    StyleManager.MetroColorGeneratorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, (Color)source.CommandParameter);
                else
                    StyleManager.ColorTint = (Color)source.CommandParameter;
            }
        }

        private void RibbonStateCommand_Executed(object sender, EventArgs e)
        {
            this.ribbonControl.Expanded = RibbonStateCommand.Checked;
            RibbonStateCommand.Checked = !RibbonStateCommand.Checked;
        }

        private void ribbonControl_ExpandedChanged(object sender, EventArgs e)
        {
            this.RibbonStateCommand.Executed -= new EventHandler(this.RibbonStateCommand_Executed);
            //this.switchButtonItem1.Value = this.ribbonControl.Expanded;
            this.switchButtonItem1.Value = !this.switchButtonItem1.Value;
            this.RibbonStateCommand.Executed += new EventHandler(this.RibbonStateCommand_Executed);
        }

        private void RibbonShell_MdiChildActivate(object sender, EventArgs e)
        {
            //EnableFileItems();
            //BindDocumentCommands();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            (EAS.Application.Instance as EAS.Windows.Application).Login();
        }        

        private void tnLogout_Click(object sender, EventArgs e)
        {
            (EAS.Application.Instance as EAS.Windows.Application).Logout();
        }

        private void btnCPassword_Click(object sender, EventArgs e)
        {
            this.OpenModule(new PasswordBox());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string name = "AgileEAS.NET SOA 中间件平台";

            try
            {
                name = XContext.ShellResource.GetApplicationTitle();
            }
            catch { }

            if (MessageBox.Show(string.Format("你确定要退出{0}吗？",name), "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                (EAS.Windows.Application.Instance as EAS.Windows.IApplication).AppEnd();
            }
        }

        private void ribbonControl_BeforeRibbonPanelPopupClose(object sender, RibbonPopupCloseEventArgs e)
        {

        }        
    }
}
