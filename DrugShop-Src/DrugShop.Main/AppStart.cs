using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DrugShop.Main
{
    static class AppStart
    {
        /// <summary>
        /// AgileEAS.NET平台的启动入口/正常入口。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //1.启动升级。
            //System.Threading.WaitCallback callBack = (s)=>
            //    {
            //        EAS.Windows.Application.Upgrade();
            //    };
            //System.Threading.ThreadPool.QueueUserWorkItem(callBack);
            EAS.Windows.Application.Upgrade();
            //2.启动平台。
            EAS.WinClient.Application.Start();
        }
    }
}
