using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrugShop.Develop
{
    static class AppStart
    {
        /// <summary>
        /// AgileEAS.NET平台的启动入口。
        /// </summary>
        /// <remarks>如果操作系统是 Windows XP 或者 Windows 2003，则系统将使用 系统 视觉样式。</remarks>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EAS.WinClient.Application.Start("DrugShop.WinUI",false);
        }
    }
}