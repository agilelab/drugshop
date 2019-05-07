using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Explorer;
using EAS;
using EAS.Messages;

namespace DrugShop.Res
{
    public partial class BottomControl : UserControl
    {
        List<string> m_Messages = new List<string>();

        public BottomControl()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            try
            {
                this.sbPanelMessage.Width = this.sbMessage.Width - this.sbPanelTitle.Width - this.sbPanelLogin.Width - 10;
            }
            catch
            {
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    (EAS.Application.Instance).Started += new EventHandler(Footer_Started);
                    (EAS.Application.Instance).Notify += new EventHandler<NotifyEventArgs>(Footer_Notify);
                }
                catch { }

                IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
                this.sbPanelLogin.Text = LoginInfo.Name + "(" + LoginInfo.LoginID + ")";
            }
        }

        void Footer_Notify(object sender, NotifyEventArgs e)
        {
            this.m_Messages.Add(e.Message.ToString());
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { this.sbMessage.Text = this.m_Messages[this.m_Messages.Count - 1]; }));
            }
            else
            {
                this.sbMessage.Text = this.m_Messages[this.m_Messages.Count - 1];
            }
        }

        void Footer_Started(object sender, EventArgs e)
        {
            IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { this.sbPanelLogin.Text = LoginInfo.Name + "(" + LoginInfo.LoginID + ")"; }));
            }
            else
            {
                this.sbPanelLogin.Text = LoginInfo.Name + "(" + LoginInfo.LoginID + ")";
            }
        }        

    }
}
