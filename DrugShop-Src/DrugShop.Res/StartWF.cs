using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;

namespace DrugShop.Res
{
    [Module("00000000-0000-0000-0000-000000000000", "启始页", "AgileEAS.NET平台WinForm/Wpf容器起始页模块")]
    public partial class StartWF : UserControl
    {
        [ModuleStart]
        public void Start()
        {
            WorkFlow wf = new WorkFlow();
            wf.Top = 0;
            wf.Left = 0;
            wf.Dock = DockStyle.None;

            int widht = wf.Width;
            int height = wf.Height;

            this.panMain.Controls.Add(wf);
        }

        public StartWF()
        {
            InitializeComponent();
        }
    }
}
