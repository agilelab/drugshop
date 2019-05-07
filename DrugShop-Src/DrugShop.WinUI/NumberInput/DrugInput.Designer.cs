namespace DrugShop.WinUI
{
    partial class DrugInput
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugInput));
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.controlFocus2 = new EAS.Windows.UI.Controls.ControlFocus(this.components);
            this.cbxProvider = new System.Windows.Forms.ComboBox();
            this.dtpTimeLimit = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBitchID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.controlFocus1 = new EAS.Windows.UI.Controls.ControlFocus(this.components);
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.controlAutoFocus1 = new EAS.Windows.UI.Controls.ControlAutoFocus(this.components);
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbNumber, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbNumber, true);
            this.tbNumber.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.tbNumber, true);
            this.tbNumber.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbNumber.Location = new System.Drawing.Point(91, 12);
            this.tbNumber.MaxLength = 6;
            this.tbNumber.Name = "tbNumber";
            this.controlFocus1.SetNextControl(this.tbNumber, this.cbxProvider);
            this.controlFocus2.SetNextControl(this.tbNumber, null);
            this.controlFocus2.SetPreviousControl(this.tbNumber, null);
            this.controlFocus1.SetPreviousControl(this.tbNumber, null);
            this.tbNumber.Size = new System.Drawing.Size(181, 23);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumber_KeyDown);
            // 
            // label5
            // 
            this.controlAutoFocus1.SetAllowNext(this.label5, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label5, false);
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label5, false);
            this.label5.Location = new System.Drawing.Point(14, 15);
            this.label5.Name = "label5";
            this.controlFocus1.SetNextControl(this.label5, null);
            this.controlFocus2.SetNextControl(this.label5, null);
            this.controlFocus2.SetPreviousControl(this.label5, null);
            this.controlFocus1.SetPreviousControl(this.label5, null);
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "数 量(&N)：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.controlAutoFocus1.SetAllowNext(this.label1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label1, false);
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label1, false);
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.controlFocus1.SetNextControl(this.label1, null);
            this.controlFocus2.SetNextControl(this.label1, null);
            this.controlFocus2.SetPreviousControl(this.label1, null);
            this.controlFocus1.SetPreviousControl(this.label1, null);
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "供 应 商：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnOK, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnOK, true);
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btnOK, true);
            this.btnOK.Location = new System.Drawing.Point(44, 141);
            this.btnOK.Name = "btnOK";
            this.controlFocus1.SetNextControl(this.btnOK, null);
            this.controlFocus2.SetNextControl(this.btnOK, null);
            this.controlFocus1.SetPreviousControl(this.btnOK, null);
            this.controlFocus2.SetPreviousControl(this.btnOK, null);
            this.btnOK.Size = new System.Drawing.Size(87, 27);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnClose, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnClose, true);
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.inputControlEnter1.SetFocus(this.btnClose, true);
            this.btnClose.Location = new System.Drawing.Point(148, 142);
            this.btnClose.Name = "btnClose";
            this.controlFocus1.SetNextControl(this.btnClose, null);
            this.controlFocus2.SetNextControl(this.btnClose, null);
            this.controlFocus1.SetPreviousControl(this.btnClose, null);
            this.controlFocus2.SetPreviousControl(this.btnClose, null);
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "取消(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // controlFocus2
            // 
            this.controlFocus2.NextKeys = null;
            this.controlFocus2.PreviousKeys = null;
            // 
            // cbxProvider
            // 
            this.controlAutoFocus1.SetAllowNext(this.cbxProvider, true);
            this.controlAutoFocus1.SetAllowPrevious(this.cbxProvider, true);
            this.inputControlEnter1.SetFocus(this.cbxProvider, true);
            this.cbxProvider.FormattingEnabled = true;
            this.cbxProvider.Location = new System.Drawing.Point(91, 43);
            this.cbxProvider.Name = "cbxProvider";
            this.controlFocus2.SetNextControl(this.cbxProvider, null);
            this.controlFocus1.SetNextControl(this.cbxProvider, null);
            this.controlFocus2.SetPreviousControl(this.cbxProvider, null);
            this.controlFocus1.SetPreviousControl(this.cbxProvider, null);
            this.cbxProvider.Size = new System.Drawing.Size(181, 22);
            this.cbxProvider.TabIndex = 3;
            // 
            // dtpTimeLimit
            // 
            this.controlAutoFocus1.SetAllowNext(this.dtpTimeLimit, true);
            this.controlAutoFocus1.SetAllowPrevious(this.dtpTimeLimit, true);
            this.dtpTimeLimit.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.inputControlEnter1.SetFocus(this.dtpTimeLimit, true);
            this.dtpTimeLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeLimit.Location = new System.Drawing.Point(91, 75);
            this.dtpTimeLimit.Name = "dtpTimeLimit";
            this.controlFocus2.SetNextControl(this.dtpTimeLimit, null);
            this.controlFocus1.SetNextControl(this.dtpTimeLimit, null);
            this.controlFocus2.SetPreviousControl(this.dtpTimeLimit, null);
            this.controlFocus1.SetPreviousControl(this.dtpTimeLimit, null);
            this.dtpTimeLimit.Size = new System.Drawing.Size(181, 23);
            this.dtpTimeLimit.TabIndex = 5;
            // 
            // label2
            // 
            this.controlAutoFocus1.SetAllowNext(this.label2, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label2, false);
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label2, false);
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.controlFocus1.SetNextControl(this.label2, null);
            this.controlFocus2.SetNextControl(this.label2, null);
            this.controlFocus2.SetPreviousControl(this.label2, null);
            this.controlFocus1.SetPreviousControl(this.label2, null);
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "药品效期：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBitchID
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbBitchID, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbBitchID, true);
            this.tbBitchID.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.tbBitchID, true);
            this.tbBitchID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbBitchID.Location = new System.Drawing.Point(91, 108);
            this.tbBitchID.MaxLength = 32;
            this.tbBitchID.Name = "tbBitchID";
            this.controlFocus1.SetNextControl(this.tbBitchID, null);
            this.controlFocus2.SetNextControl(this.tbBitchID, null);
            this.controlFocus2.SetPreviousControl(this.tbBitchID, null);
            this.controlFocus1.SetPreviousControl(this.tbBitchID, null);
            this.tbBitchID.Size = new System.Drawing.Size(181, 23);
            this.tbBitchID.TabIndex = 7;
            // 
            // label4
            // 
            this.controlAutoFocus1.SetAllowNext(this.label4, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label4, false);
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label4, false);
            this.label4.Location = new System.Drawing.Point(14, 112);
            this.label4.Name = "label4";
            this.controlFocus1.SetNextControl(this.label4, null);
            this.controlFocus2.SetNextControl(this.label4, null);
            this.controlFocus2.SetPreviousControl(this.label4, null);
            this.controlFocus1.SetPreviousControl(this.label4, null);
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "批    号：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // controlFocus1
            // 
            this.controlFocus1.NextKeys = new System.Windows.Forms.Keys[] {
        System.Windows.Forms.Keys.Down};
            this.controlFocus1.PreviousKeys = new System.Windows.Forms.Keys[] {
        System.Windows.Forms.Keys.Up};
            // 
            // inputControlEnter1
            // 
            this.inputControlEnter1.DroppedDown = true;
            this.inputControlEnter1.EnterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inputControlEnter1.EnterForeColor = System.Drawing.Color.Red;
            // 
            // controlAutoFocus1
            // 
            this.controlAutoFocus1.NextKeys = null;
            this.controlAutoFocus1.PreviousKeys = null;
            // 
            // DrugInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(290, 178);
            this.Controls.Add(this.tbBitchID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTimeLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxProvider);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrugInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "药品入库数量输入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private EAS.Windows.UI.Controls.ControlFocus controlFocus2;
        private EAS.Windows.UI.Controls.ControlFocus controlFocus1;
        private System.Windows.Forms.ComboBox cbxProvider;
        private System.Windows.Forms.DateTimePicker dtpTimeLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBitchID;
        private System.Windows.Forms.Label label4;
        private EAS.Windows.UI.Controls.ControlAutoFocus controlAutoFocus1;
        private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;
    }
}