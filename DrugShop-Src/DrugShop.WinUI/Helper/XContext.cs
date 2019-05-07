using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Explorer;

namespace DrugShop.WinUI
{
    public class XContext
    {
        /// <summary>
        /// 当前账号。
        /// </summary>
        public static IAccount Accout
        {
            get
            {
                return EAS.Application.Instance.Session.Client as IAccount;
            }
        }

        /// <summary>
        /// 系统时间。
        /// </summary>
        public static DateTime CurrentTime
        {
            get
            {
                return EAS.Application.Instance.Time;
            }
        }

        /// <summary>
        /// 系统最小时间。
        /// </summary>
        public static DateTime MinTime
        {
            get
            {
                return DateTime.Parse("1900-01-01");
            }
        }
    }
}
