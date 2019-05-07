using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Explorer.Entities;
using EAS.Data.ORM;

namespace DrugShop.WinUI
{
    public partial class BaseReport : UserControl
    {
        public BaseReport()
        {
            InitializeComponent();
            this.ReportView = new EAS.Report.Controls.ReportViewer();
            this.panelRport.Controls.Add(this.ReportView);
            this.ReportView.Dock = DockStyle.Fill;

            this.InitInfo();
        }

        public virtual void InitInfo()
        {
            
        }

        #region 报表打印相关

        private EAS.Explorer.Entities.Report report;

        [Browsable(false)]
        public EAS.Explorer.Entities.Report Report
        {
            get
            {
                if (report == null)
                {
                    this.report = new EAS.Explorer.Entities.Report();
                    this.report.Name = string.Empty;
                }
                return report;
            }
        }

        #endregion

        #region 基础属性

        [Browsable(false)]
        private Control headerControl;

        /// <summary>
        /// Top控件
        /// </summary>
        [Browsable(false)]
        public Control HeaderControl
        {
            get
            {
                return this.headerControl;
            }
            set
            {
                this.headerControl = value;
            }
        }

        private EAS.Report.Controls.ReportViewer reportView;

        [Browsable(false)]
        public EAS.Report.Controls.ReportViewer ReportView
        {
            get
            {
                return reportView;
            }
            set
            {
                reportView = value;
            }
        }

        private ConditionControl contentControl;

        /// <summary>
        /// Content控件
        /// </summary>
        [Browsable(false)]
        public ConditionControl ContentControl
        {
            get
            {
                return this.contentControl;
            }
            set
            {
                this.contentControl = value;
                if (value != null)
                    this.SetControlInfo();
            }
        }

        private void SetControlInfo()
        {
            if (this.ContentControl != null)
            {
                this.panelContainer.Height = this.ContentControl.Height;
                this.panelContainer.Controls.Add(this.ContentControl);
                this.ContentControl.Dock = DockStyle.Fill;

                this.ContentControl.SearchHander += new EventHandler(Begin_Seach);

                this.ContentControl.InitControlInfo();
            }
        }

        #endregion

        #region 其他方法

        //设置报表上的报表标题内容

        public string ReportTitle
        {
            set
            {
                this.lbReportTitle.Text = value;
            }
            get
            {
                return this.lbReportTitle.Text.Trim();
            }
        }

        #endregion

        public virtual void Begin_Seach(object sender, EventArgs e)
        {

        }

        #region 设置或绑定报表数据源

        [Browsable(false)]
        public object DataSource
        {
            get
            {
                return this.ReportView.DataObject;
            }
            set
            {
                this.ReportView.DataObject = value;
            }
        }

        [Browsable(true)]
        public EAS.Explorer.Entities.Report ShowReport
        {
            get
            {
                return this.ReportView.Report as EAS.Explorer.Entities.Report;
            }
            set
            {
                this.ReportView.Report = value;
            }
        }

        #endregion
    }
}
