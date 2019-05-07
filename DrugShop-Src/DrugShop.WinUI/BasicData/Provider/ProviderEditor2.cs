using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EAS.Services;
using DrugShop.BLL;
using EAS.Data.ORM;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 供应商、厂家属性编辑器。
    /// </summary>
    public partial class ProviderEditorForm : System.Windows.Forms.Form
    {
        protected int closed = 0;
        protected bool valueChanged = false;

        private int listType = 0x01;

        public ProviderEditorForm()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            e.Cancel = this.closed == -1;

            if(this.closed == -1)
            {
                this.closed = 0;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.valueChanged = false;
        }

        #region 属性

        private DrugShop.Entities.Provider provider;
        /// <summary>
        /// 获取或者设置当前编辑的实体对象。
        /// </summary>
        public DrugShop.Entities.Provider Provider
        {
            get
            {
                return this.provider;
            }
            set
            {
                this.provider = value;
                if (value != null)
                    this.InitEditInfo();
            }
        }

        #endregion

        private void InitEditInfo()
        {
            if(this.Provider != null)
            {
                //基本信息
                this.txtName.Text = this.Provider.Name;
                this.txtAddress.Text = this.Provider.Address;
                this.txtTel.Text = this.Provider.Tel;
                this.txtFax.Text = this.Provider.Fax;
                this.txtPostCode.Text = this.Provider.PostCode;
                this.txtEMail.Text = this.Provider.EMail;
                this.txtInputCode.Text = this.Provider.InputCode;

                //扩展信息
                this.txtContact.Text = this.Provider.Contact;
                this.txtPhone.Text = this.Provider.Phone;
                this.txtMobile.Text = this.Provider.Mobile;

                this.valueChanged = false;
            }
        }

        #region 界面事件

        /// <summary>
        /// 界面值发生变化。
        /// </summary>
        private void ValueChanged(object sender, EventArgs e)
        {
            this.valueChanged = true;
        }

        /// <summary>
        /// 获取拼音码作为输入码。
        /// </summary>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.txtInputCode.Text = EAS.Windows.UI.Controls.ChineseSpell.GetChineseSpell(this.txtName.Text);

            this.ValueChanged(sender, e);
        }

        #endregion

        /// <summary>
        /// 输入有效性校验。
        /// </summary>
        private bool VerifyInput()
        {
            if(this.txtName.Text.Trim() == "")
            {
                MessageBox.Show("名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbpBase.Select();
                this.txtName.Focus();
                return false;
            }

            return true;
        }


        /// <summary>
        /// 【确定】更新。
        /// </summary>
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if(!this.VerifyInput())
            {
                this.closed = -1;
                return;
            }

            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            try
            {
                DrugShop.Entities.Provider provider;

                if(this.Provider == null)
                {
                    provider = new DrugShop.Entities.Provider();
                    provider.ID = ServiceContainer.GetService<IProviderService>().GetMaxID();
                }
                else
                {
                    provider = this.Provider;
                }

                //基本信息
                provider.Name = this.txtName.Text;
                provider.Address = this.txtAddress.Text;
                provider.Tel = this.txtTel.Text;
                provider.Fax = this.txtFax.Text;
                provider.PostCode = this.txtPostCode.Text;
                provider.EMail = this.txtEMail.Text;
                provider.InputCode = this.txtInputCode.Text;

                //扩展信息
                provider.Contact = this.txtContact.Text;
                provider.Phone = this.txtPhone.Text;
                provider.Mobile = this.txtMobile.Text;

                provider.Save();
                this.closed = 1;

                this.Provider = provider;
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(this, "在保存‘厂家属性’数据的过程中发生了一个错误：\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.closed = -1;
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }
    }
}
