using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using DevComponents.DotNetBar;
using EAS;
using EAS.Explorer;
using EAS.Modularization;
using System.Linq;
using EAS.Explorer.Entities;
using EAS.Messages;

namespace DrugShop.Res
{
    /// <summary>
    /// 自定义主界面。
    /// </summary>
    public partial class TabShell : Form, IMainShell
    {
        NavigationProxy navigationProxy = new NavigationProxy();
        System.Type TStart = null;
        private int m_UniqueBarCount;
        private List<object> m_AddIns = null;

        public TabShell()
        {
            this.InitializeComponent();
            this.m_AddIns = new List<object>();
        }

        #region 文档Bar

        private Bar GetFirstDocumentBar()
        {
            foreach (Bar b in dotNetBarManager1.Bars)
            {
                if (b.DockSide == eDockSide.Document && b.Visible)
                    return b;
            }

            // If no documents bars found, create new one
            m_UniqueBarCount++;
            Bar bar = BarUtilities.CreateDocumentBar();
            bar.DockTabClosing += new DockTabClosingEventHandler(barDocuments_DockTabClosing);
            bar.Name = "barDocuments" + m_UniqueBarCount.ToString();
            dockSite1.GetDocumentUIManager().Dock(bar);

            return bar;
        }

        private void barDocuments_DockTabClosing(object sender, DevComponents.DotNetBar.DockTabClosingEventArgs e)
        {
            if (!XContext.AllowClose)
            {
                if (e.DockContainerItem.Tag.GetType() == typeof(StartWF))
                    e.Cancel = true;
                return;
            }

            e.RemoveDockTab = true;

            if (((Bar)sender).Items.Count == 1) // Remove bar if last item is closed...
                dotNetBarManager1.Bars.Remove((Bar)sender);

            //删除事件订阅。
            if (this.m_AddIns.Contains(e.DockContainerItem.Tag))
            {
                MessageExchange.Singleton.Unsubscribe(e.DockContainerItem.Tag);
                MessageExchange.RemoveNotify(e.DockContainerItem.Tag);
                this.m_AddIns.Remove(e.DockContainerItem.Tag);
            }
        }

        #endregion

        #region IMainShell 接口成员

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
                for (int i = m_AddIns.Count - 1; i >= 0; i--)
                {
                    EAS.Application.Instance.CloseModule(m_AddIns[i]);
                }
            }
            finally
            {
                XContext.AllowClose = false;
            }
            this.barDocuments.Items.Clear();
            
            navigationProxy.GroupList = m_GroupList;
            navigationProxy.ModuleList = m_ModuleList;

            this.barMenu.Items.Clear();
            this.InitMenu(null, null);
            this.barMenu.Refresh();

            this.TStart = typeof(StartWF);
            EAS.Application.Instance.OpenModule(this.TStart);
        }

        public object ActiveAddIn
        {
            get
            {
                var bar = this.GetFirstDocumentBar();
                if (bar == null) return null;
                return bar.SelectedDockContainerItem.Control;
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
            var bar = this.GetFirstDocumentBar();
            if (bar == null) return;

            foreach (DockContainerItem item in bar.Items)
            {
                if (item.Control == module)
                {
                    bar.Items.Remove(item);
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

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化菜单
        /// </summary>
        void InitMenu(DevComponents.DotNetBar.ButtonItem item, INavigateGroup m_Group)
        {
            IList<INavigateGroup> m_GroupList = navigationProxy.GetGroupList(m_Group == null ? string.Empty : m_Group.ID);
            int mask = (int)GroupType.Windows;

            //1.处理下级组。
            foreach (INavigateGroup var in m_GroupList)
            {
                if ((var.Attributes & mask) == mask)
                {
                    DevComponents.DotNetBar.ButtonItem miMan = new DevComponents.DotNetBar.ButtonItem();
                    miMan.Text = var.Name;
                    miMan.Image = imageList1.Images[0];
                    miMan.ImagePosition = eImagePosition.Left;
                    miMan.ButtonStyle = eButtonStyle.ImageAndText;
                    miMan.Tag = var.Attributes;

                    if (item == null)
                    {
                        this.barMenu.Items.Add(miMan);
                    }
                    else
                    {
                        item.SubItems.Add(miMan);
                    }

                    this.InitMenu(miMan, var);
                }
            }

            //2.增加功能插件
            if (m_Group != null)  //功能节点
            {
                IList<INavigateModule> m_moduleList = navigationProxy.GetModuleList(m_Group.ID);
                foreach (INavigateModule module in m_moduleList)
                {
                    DevComponents.DotNetBar.ButtonItem miSub = new DevComponents.DotNetBar.ButtonItem();
                    miSub.Image = imageList1.Images[1];
                    miSub.Text = module.Name;
                    miSub.Tag = module;
                    miSub.Click += new EventHandler(miSub_Click);
                    item.SubItems.Add(miSub);
                }
            }
        }

        void miSub_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem buttonItem = sender as DevComponents.DotNetBar.ButtonItem;

            if (buttonItem.Tag is INavigateModule)
            {
                INavigateModule module = buttonItem.Tag as INavigateModule;
                object addIn = EAS.Objects.ClassProvider.GetObjectInstance(module.Assembly, module.Type);
                this.OpenModule(addIn);
            }
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
            var doc = this.FindAddInContainer(addIn);
            if (doc == null)
            {
                doc = CreateAddInContainer(addIn);
                doc.Tag = addIn;

                //注册模块。
                this.m_AddIns.Add(addIn);
            }
            else
            {
                AddInActivate(addIn);
            }
        }

        void LoadModule(System.Windows.Controls.Control addIn)
        {
            var doc = this.FindAddInContainer(addIn);
            if (doc == null)
            {
                doc = CreateAddInContainer(addIn);
                doc.Tag = addIn;

                //注册模块。
                this.m_AddIns.Add(addIn);
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
            var bar = this.GetFirstDocumentBar();

            foreach (DockContainerItem item in bar.Items)
            {
                if (item.Tag.GetType() == addIn.GetType())
                {
                    Guid m_ID1 = ModuleManager.GetModuleGuid(item.Control);
                    Guid m_ID2 = ModuleManager.GetModuleGuid(addIn);
                    if (m_ID1 == m_ID2)
                    {
                        bar.SelectedDockTab = bar.Items.IndexOf(item);
                        bar.RecalcLayout();
                        return;
                    }
                }
            }
        }

        DockContainerItem CreateAddInContainer(object addIn)
        {
            DockContainerItem document = new DockContainerItem();
            document.Text = GetModuleName(addIn);

            if (addIn is Control)
            {
                (addIn as Control).Dock = DockStyle.Fill;
                document.Control = addIn as Control;
            }
            else if (addIn is System.Windows.Controls.Control)
            {
                System.Windows.Forms.Integration.ElementHost wpfHost = new System.Windows.Forms.Integration.ElementHost();
                wpfHost.Dock = System.Windows.Forms.DockStyle.Fill;
                wpfHost.Location = new System.Drawing.Point(0, 0);
                wpfHost.TabIndex = 0;
                wpfHost.Child = (addIn as System.Windows.Controls.Control);
                this.Controls.Add(wpfHost);
                document.Control = wpfHost;
            }

            Bar bar = GetFirstDocumentBar();
            bar.Items.Add(document);
            bar.SelectedDockTab = bar.Items.IndexOf(document);
            bar.RecalcLayout();

            ModuleManager.StartModule(addIn, this);
            return document;
        }

        string GetModuleName(object addIn)
        {
            string guid = string.Empty;
            if (addIn is IAddIn)
            {
                guid = ((IAddIn)addIn).Guid.ToString();
            }
            else
            {
                guid = MetaHelper.GetModuleGuid(addIn.GetType());
            }

            Module module = XContext.ModuleList.Where(p => p.Guid == guid).FirstOrDefault();
            if (module == null)
            {
                using (DbEntities db = new DbEntities())
                {
                    module = db.Modules.Where(p => p.Guid == guid.ToUpper()).FirstOrDefault();
                }
            }

            if (module != null)
            {
                return module.Name;
            }
            else
            {
                return ModuleManager.GetModuleName(addIn);
            }
        }

        DockContainerItem FindAddInContainer(object addIn)
        {
            Bar bar = GetFirstDocumentBar();

            foreach (DockContainerItem fc in bar.Items)
            {
                if (fc.Tag.GetType() == addIn.GetType())
                {
                    Guid m_ID1 = ModuleManager.GetModuleGuid(fc.Control);
                    Guid m_ID2 = ModuleManager.GetModuleGuid(addIn);
                    if (m_ID1 == m_ID2)
                        return fc;
                }
            }

            return null;
        }

        #endregion

        #region 菜单

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出AgileEAS.NET SOA平台吗？", "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                (EAS.Windows.Application.Instance as EAS.Windows.IApplication).AppEnd();
            }
        }

        /// <summary>
        /// 系统登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            (EAS.Application.Instance as EAS.Windows.IApplication).Login();
        }

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseNowWindow_Click(object sender, EventArgs e)
        {
            this.CloseModule();
        }

        /// <summary>
        /// 关闭所有窗口
        /// </summary>
        private void btnCloseAllWindow_Click(object sender, EventArgs e)
        {
            this.CloseAllWindows();
        }

        /// <summary>
        /// 关闭所有窗口
        /// </summary>
        private void CloseAllWindows()
        {
            foreach (var item in this.m_AddIns)
            {
                this.CloseModule(item);
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.OpenModule(new PasswordBox());
        }

        #endregion
    }
}
