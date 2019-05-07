using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using EAS.Modularization;
using EAS.Windows.UI.Controls;
using EAS.Data.ORM;
using EAS.Explorer.Entities;
using System.Collections.Generic;
using EAS.Objects;
using EAS.Explorer;

namespace DrugShop.Res
{
    partial class NavigationControl : UserControl, INavigation
    {
        /// <summary>
        /// 加载模块。
        /// </summary>
        /// <param name="name"></param>
        /// <param name="assemmby"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        static object LoadModule(string name, string assemmby, string type)
        {
            object module = ClassProvider.GetObjectInstance(assemmby, type);

            if (module == null)
            {
                throw new System.Exception("无法加载“" + name + "”，请通知您的系统管理人员。");
            }

            return module;
        }

        NavigationProxy navigationProxy = null;

        /// <summary>
        /// 初始化 Navigation 类实例。
        /// </summary>
        public NavigationControl()
        {
            InitializeComponent();
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                if (e.Node.Tag is Type)
                {
                    Type T = (Type)e.Node.Tag;

                    if (T == typeof(LoginForm))
                        new LoginForm().ShowDialog();
                    else
                        new AboutForm().ShowDialog();
                }
                else if (e.Node.Tag is INavigateModule)
                {
                    INavigateModule modue = e.Node.Tag as INavigateModule;
                    object addIn = LoadModule(modue.Name, modue.Assembly, modue.Type);
                    EAS.Application.Instance.OpenModule(addIn);
                }
            }
        }        

        /// <summary>
        /// 初始化导航控件导航栏目。
        /// </summary>
        private void InitializeNavigation()
        {
            this.Tree.Nodes.Clear();

            TreeNode root = new TreeNode("DrugShop.NET", 0, 1);

            if (string.Compare(XContext.Account.LoginID, "Guest", true) == 0)
            {
                this.InitializeNavigationGuest(root);
            }
            else
            {
                this.InitializeNavigationPublic(root, null);
            }

            this.Tree.Nodes.Add(root);

            root.Expand();
            this.Tree.SelectedNode = root;
        }

        /// <summary>
        /// Guest用户初始化导航。
        /// </summary>
        private void InitializeNavigationGuest(TreeNode root)
        {
            TreeNode node = new TreeNode("相关连接", 0, 1);

            Type TModule = typeof(LoginForm);
            TreeNode itemNode = new TreeNode("登录", 2, 2);
            itemNode.Tag = TModule;
            node.Nodes.Add(itemNode);

            TModule = typeof(AboutForm);
            itemNode = new TreeNode("关于", 2, 2);
            itemNode.Tag = TModule;
            node.Nodes.Add(itemNode);

            root.Nodes.Add(node);
        }

        /// <summary>
        /// 普通用户导航初始化。
        /// </summary>
        private void InitializeNavigationPublic(TreeNode node, INavigateGroup Group)
        {
            int mask = (int)GroupType.Windows;
            int mask2 = (int)GroupType.Expend;

            IList<INavigateGroup> groupList = navigationProxy.GetGroupList(Group == null ? Guid.Empty.ToString() : Group.ID);

            foreach (INavigateGroup var in groupList) //下级组
            {
                if ((var.Attributes & mask) == mask) 
                {
                    TreeNode subNode = new TreeNode(var.Name, 0, 1);
                    this.InitializeNavigationPublic(subNode, var);
                    node.Nodes.Add(subNode);

                    if ((var.Attributes & mask2) == mask2)
                    {
                        node.Expand();
                    }
                }
            }

            if (Group != null)  //功能节点
            {
                TreeNode itemNode = null;

                IList<INavigateModule> moduleList = navigationProxy.GetModuleList(Group.ID);

                foreach (INavigateModule mv in moduleList)
                {
                    itemNode = new TreeNode(mv.Name, 2, 2);
                    itemNode.Tag = mv;
                    node.Nodes.Add(itemNode);
                }
            }
        }

        #region INavigation 成员

        public void Initialize(IList<INavigateGroup> m_GroupList, IList<INavigateModule> m_ModuleList)
        {
            this.navigationProxy = new NavigationProxy();
            this.navigationProxy.GroupList = m_GroupList;
            this.navigationProxy.ModuleList = m_ModuleList;

            this.InitializeNavigation();
        }

        #endregion
    }
}
