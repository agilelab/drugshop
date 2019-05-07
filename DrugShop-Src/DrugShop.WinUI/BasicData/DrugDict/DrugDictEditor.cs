using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using EAS.Data.ORM;
using EAS.Services;
using DrugShop.BLL;
using DrugShop.Entities;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 药品字典属性编辑框。
    /// </summary>
    public partial class DrugDictEditor : System.Windows.Forms.Form
    {
        protected bool canClosed = true;

        public DrugDictEditor()
        {
            InitializeComponent();
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Enter };
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.PageUp };
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            e.Cancel = !this.canClosed;

            if(!this.canClosed)
            {
                this.canClosed = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if(this.DrugDict ==null)
            {
                int Code =ServiceContainer.GetService<IDrugDictService>().GetMaxCodeIDN();
                this.tbCode.Text = Code.ToString("D7");
            }
        }

        public void Initialize()
        {
            this.BindDrugType();
        }

        private DrugShop.Entities.Dict dict;
        public DrugShop.Entities.Dict DrugDict
        {
            get
            {
                return this.dict;
            }
            set
            {
                if(value == null)
                    return;

                this.dict = value;
                this.InitDictInfo(this.dict);
            }
        }

        private void InitDictInfo(Dict Dict)
        {
            this.cbxType.SelectedValue = Dict.Type;
            this.tbUnit.Content = Dict.Unit;
            this.tbChinseName.Text = Dict.ChinseName;
            this.tbCode.Text = Dict.Code;
            this.tbFileNo.Text = Dict.FileNo;
            this.tbInputCode1.Text = Dict.InputCode1;
            this.tbSpec.Text = Dict.Spec;
            this.rbOTCYes.Checked = Dict.Isotc == 1 ? true : false;
            this.rbOTCNo.Checked = !this.rbOTCYes.Checked;
            this.nudPrice.Value = Dict.Price;
            this.nudDown.Value = Dict.DownLimit;
            this.nudUp.Value = Dict.UpLimit;
            this.tbEffect.Text = Dict.Effect;
        }

        private void BindDrugType()
        {
            DataBindHelper.BindDrugTypeCmbBox3(this.cbxType);
        }

        private bool ValidInput()
        {
            if(this.tbCode.Text.Trim() == "")
            {
                MessageBox.Show(this, "药品编码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tabControl1.SelectedIndex = 0;
                this.tbCode.Focus();
                return false;
            }

            if(this.tbChinseName.Text.Trim() == "")
            {
                MessageBox.Show(this, "药品中文名称不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tabControl1.SelectedIndex = 0;
                this.tbChinseName.Focus();
                return false;
            }

            if(this.tbUnit.Content.Trim() == "*/")
            {
                MessageBox.Show(this, "药品单位不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tabControl1.SelectedIndex = 0;
                this.tbBigUnit.Focus();
                return false;
            }

            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!this.ValidInput())
            {
                this.canClosed = false;
                return;
            }

            try
            {
                DrugShop.Entities.Dict drugDict = null;

                if(this.DrugDict == null)
                {
                    drugDict = new DrugShop.Entities.Dict();
                    drugDict.ID = ServiceContainer.GetService<IDrugDictService>().GetMaxCodeIDN();
                    drugDict.Remarks = string.Empty;
                }
                else
                {
                    drugDict = this.DrugDict;
                }

                drugDict.Code = this.tbCode.Text;
                drugDict.ChinseName = this.tbChinseName.Text;

                drugDict.Type = this.cbxType.SelectedValue == null ? 0 : (int)this.cbxType.SelectedValue;

                drugDict.Spec = this.tbSpec.Text;
                drugDict.Unit = this.tbUnit.Content;
                drugDict.Price = this.nudPrice.Value;
                drugDict.DownLimit = (int)this.nudDown.Value;
                drugDict.UpLimit = (int)this.nudUp.Value;
                drugDict.FileNo = this.tbFileNo.Text.Trim();
                drugDict.InputCode1 = this.tbInputCode1.Text;
                drugDict.Effect = this.tbEffect.Text.Trim();

                drugDict.Isotc = this.rbOTCYes.Checked ? 1 : 0;

                drugDict.Isenable = 1;

                if (this.DrugDict == null)
                {
                    drugDict.Insert();
                }
                else
                {
                    drugDict.Update();
                }

                this.canClosed = true;
                this.DrugDict = drugDict;
                this.DialogResult = DialogResult.OK;

            }
            catch(System.Exception exc)
            {
                MessageBox.Show(this, "在保存药品字典时出错，错误：" + exc.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.canClosed = false;
            }
        }

        private void tbChinseName_TextChanged(object sender, EventArgs e)
        {
            this.tbInputCode1.Text = EAS.Windows.UI.Controls.ChineseSpell.GetChineseSpell(this.tbChinseName.Text);
        }
    }
}