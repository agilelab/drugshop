namespace DrugShop.WinUI
{
    partial class ProviderEditorForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderEditorForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbpBase = new System.Windows.Forms.TabPage();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtInputCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcBG = new System.Windows.Forms.TabControl();
            this.tbpBase.SuspendLayout();
            this.tbcBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(202, 460);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 27);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(296, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbpBase
            // 
            this.tbpBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpBase.Controls.Add(this.txtAddress);
            this.tbpBase.Controls.Add(this.txtInputCode);
            this.tbpBase.Controls.Add(this.label2);
            this.tbpBase.Controls.Add(this.txtMobile);
            this.tbpBase.Controls.Add(this.txtPhone);
            this.tbpBase.Controls.Add(this.label13);
            this.tbpBase.Controls.Add(this.txtContact);
            this.tbpBase.Controls.Add(this.txtEMail);
            this.tbpBase.Controls.Add(this.txtPostCode);
            this.tbpBase.Controls.Add(this.txtFax);
            this.tbpBase.Controls.Add(this.txtTel);
            this.tbpBase.Controls.Add(this.txtName);
            this.tbpBase.Controls.Add(this.label12);
            this.tbpBase.Controls.Add(this.label11);
            this.tbpBase.Controls.Add(this.label9);
            this.tbpBase.Controls.Add(this.label8);
            this.tbpBase.Controls.Add(this.label7);
            this.tbpBase.Controls.Add(this.label6);
            this.tbpBase.Controls.Add(this.label3);
            this.tbpBase.Controls.Add(this.label1);
            this.tbpBase.Location = new System.Drawing.Point(4, 24);
            this.tbpBase.Name = "tbpBase";
            this.tbpBase.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBase.Size = new System.Drawing.Size(365, 406);
            this.tbpBase.TabIndex = 0;
            this.tbpBase.Text = "基础信息";
            this.tbpBase.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(104, 318);
            this.txtAddress.MaxLength = 128;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 23);
            this.txtAddress.TabIndex = 5;
            // 
            // txtInputCode
            // 
            this.txtInputCode.Location = new System.Drawing.Point(104, 356);
            this.txtInputCode.MaxLength = 16;
            this.txtInputCode.Name = "txtInputCode";
            this.txtInputCode.Size = new System.Drawing.Size(250, 23);
            this.txtInputCode.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "地    址(&A):";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(104, 280);
            this.txtMobile.MaxLength = 16;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(250, 23);
            this.txtMobile.TabIndex = 19;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(104, 243);
            this.txtPhone.MaxLength = 16;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 23);
            this.txtPhone.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 14);
            this.label13.TabIndex = 20;
            this.label13.Text = "输 入 码(&I):";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(104, 205);
            this.txtContact.MaxLength = 16;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(250, 23);
            this.txtContact.TabIndex = 15;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(104, 168);
            this.txtEMail.MaxLength = 32;
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(250, 23);
            this.txtEMail.TabIndex = 11;
            this.txtEMail.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(104, 129);
            this.txtPostCode.MaxLength = 6;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(250, 23);
            this.txtPostCode.TabIndex = 9;
            this.txtPostCode.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(104, 91);
            this.txtFax.MaxLength = 16;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(250, 23);
            this.txtFax.TabIndex = 7;
            this.txtFax.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(104, 52);
            this.txtTel.MaxLength = 16;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(250, 23);
            this.txtTel.TabIndex = 5;
            this.txtTel.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 15);
            this.txtName.MaxLength = 64;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 14);
            this.label12.TabIndex = 18;
            this.label12.Text = "手    机(&M):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "电    话(&P):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "联 系 人(&N):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "电子邮件(&E):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "邮    编(&P):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "传    真(&F):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "电    话(&T):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "名    称(&N):";
            // 
            // tbcBG
            // 
            this.tbcBG.Controls.Add(this.tbpBase);
            this.tbcBG.Location = new System.Drawing.Point(14, 14);
            this.tbcBG.Name = "tbcBG";
            this.tbcBG.SelectedIndex = 0;
            this.tbcBG.Size = new System.Drawing.Size(373, 434);
            this.tbcBG.TabIndex = 0;
            // 
            // ProviderEditorForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(401, 497);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbcBG);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProviderEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "供应商属性";
            this.tbpBase.ResumeLayout(false);
            this.tbpBase.PerformLayout();
            this.tbcBG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tbpBase;
        private System.Windows.Forms.TextBox txtInputCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcBG;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
    }
}