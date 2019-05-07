using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Explorer.BLL;
using EAS.Services;
using EAS.Data.ORM;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 报表扩展。
    /// </summary>
    static class ReportExtensions
    {
        /// <summary>
        /// 窗体与报表名称扩展。
        /// </summary>
        static readonly Dictionary<System.Windows.Forms.Control, string> m_PrintNames = new Dictionary<System.Windows.Forms.Control, string>();

        /// <summary>
        /// 报表定义。
        /// </summary>
        static readonly Dictionary<string, EAS.Explorer.Entities.Report> m_Reports = new Dictionary<string, EAS.Explorer.Entities.Report>();

        /// <summary>
        /// 设置报表名称。
        /// </summary>
        /// <param name="Control">控件/窗体。</param>
        /// <param name="Name">报表名称。</param>
        public static void SetReportName(this System.Windows.Forms.Control Control,string Name)
        {
            if(m_PrintNames.ContainsKey(Control))
            {
                m_PrintNames[Control] =Name;;
            }
            else
            {
                m_PrintNames.Add(Control,Name);
            }
        }

        /// <summary>
        /// 显示打印预览窗口。
        /// </summary>
        /// <param name="Control"></param>
        /// <param name="dataSource"></param>
        public static void PrintPreview(this System.Windows.Forms.Control Control, object dataSource)
        {
            EAS.Explorer.Entities.Report R = GetReport(Control);
            if (!R.Exists) return;

            EAS.Report.Controls.PrintViewDialog ViewDialog = new EAS.Report.Controls.PrintViewDialog();
            ViewDialog.Report = R;
            ViewDialog.DataObject = dataSource;
            ViewDialog.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ViewDialog.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ViewDialog.ShowDialog();
        }

        /// <summary>
        /// 直接打印报表。
        /// </summary>
        /// <param name="Control"></param>
        /// <param name="dataSource"></param>
        public static void Print(this System.Windows.Forms.Control Control, object dataSource, bool showDialog = false)
        {
            EAS.Explorer.Entities.Report R = GetReport(Control);
            if (!R.Exists) return;

            EAS.Report.Controls.PrintViewDialog ViewDialog = new EAS.Report.Controls.PrintViewDialog();
            ViewDialog.Report = R;
            ViewDialog.DataObject = dataSource;
            ViewDialog.Print(showDialog);
        }

        static EAS.Explorer.Entities.Report GetReport(System.Windows.Forms.Control Control)
        {
            EAS.Explorer.Entities.Report R = new EAS.Explorer.Entities.Report();
            string Name = string.Empty;
            m_PrintNames.TryGetValue(Control, out Name);
            if (string.IsNullOrEmpty(Name)) return R;

            if (!m_Reports.TryGetValue(Name, out R))
            {
                R = new EAS.Explorer.Entities.Report();
                R.Name = Name;
                R.Read();
                m_Reports.Add(Name, R);
            }
            return R;
        }
    }
}
