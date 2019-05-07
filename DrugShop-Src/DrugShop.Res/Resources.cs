using System;
using EAS.Explorer;

namespace DrugShop.Res
{
	public class Resources:EAS.Explorer.IResource  
	{
        /// <summary>
        /// 主界面图标。
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Icon GetMainIcon()
        {
            return Properties.Resources.Drugbasket;
        }

        /// <summary>
        /// Tab页图标
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Image GetModuleIcon()
        {
            return Properties.Resources.Module.ToBitmap();
        }

        /// <summary>
        /// 桌面背景。
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Image GetDesktopImage()
        {
            return null;
        }

        /// <summary>
        /// 应用程序名称。
        /// </summary>
        /// <returns></returns>
        public string GetApplicationName()
        {
            return "AgileEAS.NET";
        }

        /// <summary>
        /// 应用程序标题。
        /// </summary>
        /// <returns></returns>
        public string GetApplicationTitle()
        {
            return "药店管理信息系统";
        }

        public object GetMainShell()
        {
            return new RibbonShell(); //Ribbon风格自定义界面。
            //return new DockableShell(); //Dockable风格自定义界面。
            //return new TabShell(); //TabMdi风格自定义界面。
            //return null; //使用AgileEAS.NET SOA平台自带界面。
        }

        /// <summary>
        /// 关于窗口。
        /// </summary>
        /// <returns></returns>
        public object GetAboutForm()
        {
            return new AboutForm();
        }

        /// <summary>
        /// Bottom通知。
        /// </summary>
        /// <returns></returns>
        public object GetBottomControl()
        {
            return new BottomControl();
        }

        /// <summary>
        /// Top条幅。
        /// </summary>
        /// <returns></returns>
        public object GetBannerControl()
        {
            return new Banner();
        }

        /// <summary>
        /// 导航工具条。
        /// </summary>
        /// <returns></returns>
        public object GetNavigationControl()
        {
            return new NavigationControl();
        }

        /// <summary>
        /// 登录窗口。
        /// </summary>
        /// <returns></returns>
        public ILoginForm GetLoginForm()
        {
            return new LoginForm();
        }

        /// <summary>
        /// 起始页。
        /// </summary>
        /// <returns></returns>
        public object GetStartModule()
        {
            return new StartWF();
        }

        /// <summary>
        /// 显示菜单。
        /// </summary>
        public bool DisplayMainMenu
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// 显示导航。
        /// </summary>
        public bool DisplayNavigation
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// 显示导航工具条。
        /// </summary>
        public bool DisplayNavigationTool
        {
            get
            {
                return true;
            }
        }


        public IAccountOriginal GetAccountOriginal()
        {
            return null;
        }
    }
}