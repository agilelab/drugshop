using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;

namespace DrugShop.BLL
{
    [ServiceObject("服务器时间服务")]
    [ServiceBind(typeof(IDateTimeService))]
    public class DateTimeService : ServiceObject, DrugShop.BLL.IDateTimeService
    {
        private static readonly DateTime minTime = DateTime.Parse("1900-01-01 00:00:00");

        /// <summary>
        /// 取系统当前时间。
        /// </summary>
        /// <returns>当前系统时间。</returns>
        public DateTime GetCurrentTime()
        {
            return DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        /// <summary>
        /// 取系统最小时间。
        /// </summary>
        /// <returns>系统最小时间。</returns>
        public DateTime GetMinTime()
        {
            return minTime;
        }
    }
}
