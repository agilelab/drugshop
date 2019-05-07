using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EAS.Windows.UI.Controls;
using EAS.Threading;
using EAS.Modularization;
using EAS.Explorer.Entities;

namespace DrugShop.Res
{
    public partial class FormContainer : Form, IControlContainer
    {
        object m_AddIn = null;
        System.Windows.Forms.Form m_Shell = null;

        public FormContainer()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!XContext.AllowClose)
            {
                if (this.m_AddIn.GetType() == typeof(StartWF))
                    e.Cancel = true; 
            }

            base.OnClosing(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            if (this.m_AddIn != null)
            {
                ModuleManager.StartModule(this.m_AddIn, this);
            }
        }

        public FormContainer(System.Windows.Forms.Form shell)
            : this()
        {
            m_Shell = shell;

            try
            {
                this.Icon = XContext.ShellResource.GetModuleIcon().ToIcon();
            }
            catch { }
        }

        public void Start(System.Windows.Forms.Control addIn)
        {
            this.SetContainer(addIn);
            addIn.Dock = DockStyle.Fill;
            this.Controls.Add(addIn);
        }

        public void Start(System.Windows.Controls.Control addIn)
        {
            this.SetContainer(addIn);

            System.Windows.Forms.Integration.ElementHost wpfHost = new System.Windows.Forms.Integration.ElementHost();
            wpfHost.Dock = System.Windows.Forms.DockStyle.Fill;
            wpfHost.Location = new System.Drawing.Point(0, 0);
            wpfHost.TabIndex = 0;
            wpfHost.Child = addIn;
            this.Controls.Add(wpfHost);
        }

        #region IControlContainer

        public object ExplorerControl
        {
            get
            {
                return this.m_AddIn;
            }
        }

        public string Message
        {
            get
            {
                return string.Empty;
            }
            set
            {
                if (value != null)
                {
                    Dictionary<string, object> dc = new Dictionary<string, object>();
                    dc.Add("通知", value);
                    EAS.Application.Instance.CallScript("message", dc);
                }
            }
        }

        #endregion

        void SetContainer(object addIn)
        {
            this.m_AddIn = addIn;

            if (this.m_AddIn.GetType() == typeof(StartWF))
            {
                this.ControlBox = false;
            }
            else if (this.m_AddIn.GetType() == typeof(StartWF))
            {
                this.ControlBox = false;
            }

            if (addIn is IExplorerControl)
            {
                (addIn as IExplorerControl).ControlContainer = this;
            }

            this.SetModule(addIn);
        }

        void SetModule(object addIn)
        {
            string guid = string.Empty;
            if (addIn is IAddIn)
            {
                guid = ((IAddIn)addIn).Guid.ToString();
            }
            else
            {
                guid = MetaHelper.GetModuleGuid(addIn.GetType());
            }

            if (addIn is AboutForm)
            {
                this.Icon = (addIn as AboutForm).Icon;
            }
            else if (addIn is LoginForm)
            {
                this.Icon = (addIn as LoginForm).Icon; 
            }
            else if (guid.Length > 0)
            {
                Module module = XContext.ModuleList.Where(p => p.Guid == guid).FirstOrDefault();
                if (module == null)
                {
                    using (DbEntities db = new DbEntities())
                    {
                        module = db.Modules.Where(p => p.Guid == guid.ToUpper()).FirstOrDefault();
                    }
                }

                if (module != null)
                {
                    this.Text = module.Name;
                    try
                    {
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(module.Icon))
                        {
                            this.Icon = System.Drawing.Image.FromStream(ms).ToIcon();
                        }
                    }
                    catch { }
                }
                else
                {
                    this.Text = ModuleManager.GetModuleName(addIn);
                }
            }
        }
    }
}
