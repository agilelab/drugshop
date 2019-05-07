using System;
using System.Collections.Generic;
using System.Text;
using EAS.Explorer;

namespace DrugShop.Res
{
    class XContext 
    {
        /// <summary>
        /// 当前登录账号。
        /// </summary>
        public static IAccount Account
        {
            get
            {
                return EAS.Application.Instance.Session.Client as IAccount;
            }
        }

        /// <summary>
        /// 所有模块。
        /// </summary>
        public static IList<EAS.Explorer.Entities.Module> ModuleList
        {
            get
            {
                return EAS.Data.Caching.Cache.Get<EAS.Explorer.Entities.Module>();
            }
        }

        /// <summary>
        /// 资源。
        /// </summary>
        internal static IResource ShellResource
        {
            get
            {
                return EAS.Explorer.ResourceManager.Resource;
            }
        }

        /// <summary>
        /// 充许关闭起始页。
        /// </summary>
        public static bool AllowClose
        {
            get;
            set;
        }
    }
}
