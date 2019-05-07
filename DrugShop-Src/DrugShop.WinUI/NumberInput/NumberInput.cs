using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DrugShop.WinUI
{
    public partial class NumberInput : System.Windows.Forms.Form
    {
        private bool validate;

        public NumberInput()
        {
            InitializeComponent();

            this.validate = false;
        }

        /// <summary>
        /// 数字验正事件。
        /// </summary>
        public event System.EventHandler NumberValidate;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.DialogResult = DialogResult.None;
        }

        private decimal storeNumber = 0;
        public decimal StoreNumber
        {
            get
            {
                return this.storeNumber;
            }
            set
            {
                this.storeNumber = value;
                if (value > 0)
                    this.lbNumber.Text = Convert.ToInt32(storeNumber).ToString()+" 个";
            }
        }

        public int Number
        {
            get
            {
                return int.Parse(this.tbNumber.Text);
            }
            set
            {
                this.tbNumber.Text = value.ToString();
            }
        }

        /// <summary>
        /// 指示验证是否完成。
        /// </summary>
        public bool ValidateFinished
        {
            get
            {
                return this.validate;
            }
            set
            {
                this.validate = value;
            }
        }        

        private void tbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                string s = this.tbNumber.Text.Trim();

                if (s == "")
                {
                    MessageBox.Show("输入不能为空，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.validate =false;
                    return;
                }

                if (!Information.IsNumeric(s))
                {
                    MessageBox.Show("数字格式错误，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNumber.SelectAll();
                    this.validate =false;
                    return;
                }

                if (s.IndexOf(".") > -1)
                {
                    MessageBox.Show("数字格式错误，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNumber.SelectAll();
                    this.validate =false;
                    return;
                }

                if (int.Parse(this.tbNumber.Text) < 1)
                {
                    MessageBox.Show("输入数字不能小于1，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNumber.SelectAll();
                    this.validate =false;
                    return;
                }

                if (int.Parse(this.tbNumber.Text) >this.StoreNumber)
                {
                    MessageBox.Show("输入数字不能大于库存数量，请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNumber.SelectAll();
                    this.validate = false;
                    return;
                }

                if (this.NumberValidate != null)
                {
                    this.NumberValidate(this, new System.EventArgs());

                    if (this.validate)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.tbNumber.SelectAll();
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void NumberInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}