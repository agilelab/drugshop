namespace DrugShop.WinUI
{
    partial class DrugDictEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugDictEditor));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbChinseName = new System.Windows.Forms.TextBox();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudDown = new System.Windows.Forms.NumericUpDown();
            this.nudUp = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.tbInputCode1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbEffect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUnit = new DrugShop.WinUI.DrugUnit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbOTCNo = new System.Windows.Forms.RadioButton();
            this.rbOTCYes = new System.Windows.Forms.RadioButton();
            this.label29 = new System.Windows.Forms.Label();
            this.tbFileNo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.controlAutoFocus1 = new EAS.Windows.UI.Controls.ControlAutoFocus(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.controlAutoFocus1.SetAllowNext(this.label7, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label7, false);
            this.label7.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label7, false);
            this.label7.Location = new System.Drawing.Point(15, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "药品单位(&B)：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.controlAutoFocus1.SetAllowNext(this.label6, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label6, false);
            this.label6.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label6, false);
            this.label6.Location = new System.Drawing.Point(15, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "药品学名(&F)：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCode
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbCode, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbCode, true);
            this.inputControlEnter1.SetFocus(this.tbCode, true);
            this.tbCode.Location = new System.Drawing.Point(108, 15);
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(312, 23);
            this.tbCode.TabIndex = 1;
            // 
            // label4
            // 
            this.controlAutoFocus1.SetAllowNext(this.label4, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label4, false);
            this.label4.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label4, false);
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "药品规格(&S)：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnCancel, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btnCancel, false);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.inputControlEnter1.SetFocus(this.btnCancel, false);
            this.btnCancel.Location = new System.Drawing.Point(370, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnOK, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btnOK, false);
            this.inputControlEnter1.SetFocus(this.btnOK, false);
            this.btnOK.Location = new System.Drawing.Point(275, 490);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 27);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbChinseName
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbChinseName, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbChinseName, true);
            this.inputControlEnter1.SetFocus(this.tbChinseName, true);
            this.tbChinseName.Location = new System.Drawing.Point(108, 78);
            this.tbChinseName.MaxLength = 64;
            this.tbChinseName.Name = "tbChinseName";
            this.tbChinseName.Size = new System.Drawing.Size(312, 23);
            this.tbChinseName.TabIndex = 13;
            // 
            // tbSpec
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbSpec, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbSpec, true);
            this.inputControlEnter1.SetFocus(this.tbSpec, true);
            this.tbSpec.Location = new System.Drawing.Point(108, 111);
            this.tbSpec.MaxLength = 16;
            this.tbSpec.Name = "tbSpec";
            this.tbSpec.Size = new System.Drawing.Size(312, 23);
            this.tbSpec.TabIndex = 15;
            // 
            // nudPrice
            // 
            this.controlAutoFocus1.SetAllowNext(this.nudPrice, true);
            this.controlAutoFocus1.SetAllowPrevious(this.nudPrice, true);
            this.nudPrice.DecimalPlaces = 4;
            this.inputControlEnter1.SetFocus(this.nudPrice, true);
            this.nudPrice.Location = new System.Drawing.Point(108, 223);
            this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(313, 23);
            this.nudPrice.TabIndex = 25;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.controlAutoFocus1.SetAllowNext(this.label9, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label9, false);
            this.label9.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label9, false);
            this.label9.Location = new System.Drawing.Point(15, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 14);
            this.label9.TabIndex = 24;
            this.label9.Text = "药品价格(P)：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.controlAutoFocus1.SetAllowNext(this.label11, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label11, false);
            this.label11.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label11, false);
            this.label11.Location = new System.Drawing.Point(15, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "库存限制(L)：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudDown
            // 
            this.controlAutoFocus1.SetAllowNext(this.nudDown, true);
            this.controlAutoFocus1.SetAllowPrevious(this.nudDown, true);
            this.inputControlEnter1.SetFocus(this.nudDown, true);
            this.nudDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDown.Location = new System.Drawing.Point(108, 254);
            this.nudDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDown.Name = "nudDown";
            this.nudDown.Size = new System.Drawing.Size(133, 23);
            this.nudDown.TabIndex = 29;
            this.nudDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudUp
            // 
            this.controlAutoFocus1.SetAllowNext(this.nudUp, true);
            this.controlAutoFocus1.SetAllowPrevious(this.nudUp, true);
            this.inputControlEnter1.SetFocus(this.nudUp, true);
            this.nudUp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudUp.Location = new System.Drawing.Point(290, 254);
            this.nudUp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudUp.Name = "nudUp";
            this.nudUp.Size = new System.Drawing.Size(131, 23);
            this.nudUp.TabIndex = 31;
            this.nudUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.controlAutoFocus1.SetAllowNext(this.label13, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label13, false);
            this.label13.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label13, false);
            this.label13.Location = new System.Drawing.Point(15, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "药品编码(&C)：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInputCode1
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbInputCode1, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbInputCode1, true);
            this.inputControlEnter1.SetFocus(this.tbInputCode1, true);
            this.tbInputCode1.Location = new System.Drawing.Point(108, 294);
            this.tbInputCode1.MaxLength = 16;
            this.tbInputCode1.Name = "tbInputCode1";
            this.tbInputCode1.Size = new System.Drawing.Size(312, 23);
            this.tbInputCode1.TabIndex = 33;
            // 
            // label1
            // 
            this.controlAutoFocus1.SetAllowNext(this.label1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label1, false);
            this.label1.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label1, false);
            this.label1.Location = new System.Drawing.Point(15, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "助记码1：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(15, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbEffect);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbUnit);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.tbFileNo);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.nudUp);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.cbxType);
            this.tabPage1.Controls.Add(this.tbCode);
            this.tabPage1.Controls.Add(this.tbInputCode1);
            this.tabPage1.Controls.Add(this.nudDown);
            this.tabPage1.Controls.Add(this.nudPrice);
            this.tabPage1.Controls.Add(this.tbChinseName);
            this.tabPage1.Controls.Add(this.tbSpec);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "字典信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbEffect
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbEffect, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbEffect, true);
            this.inputControlEnter1.SetFocus(this.tbEffect, true);
            this.tbEffect.Location = new System.Drawing.Point(110, 372);
            this.tbEffect.MaxLength = 32;
            this.tbEffect.Multiline = true;
            this.tbEffect.Name = "tbEffect";
            this.tbEffect.Size = new System.Drawing.Size(312, 60);
            this.tbEffect.TabIndex = 57;
            // 
            // label2
            // 
            this.controlAutoFocus1.SetAllowNext(this.label2, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label2, false);
            this.label2.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label2, false);
            this.label2.Location = new System.Drawing.Point(15, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 56;
            this.label2.Text = "药品功效(&E)：";
            // 
            // tbUnit
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbUnit, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbUnit, true);
            this.tbUnit.BackColor = System.Drawing.Color.White;
            this.tbUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUnit.Content = "*/";
            this.inputControlEnter1.SetFocus(this.tbUnit, true);
            this.tbUnit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbUnit.Location = new System.Drawing.Point(110, 190);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(159, 23);
            this.tbUnit.TabIndex = 55;
            this.tbUnit.TextBackColor = System.Drawing.SystemColors.Window;
            this.tbUnit.TextForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbOTCNo);
            this.panel2.Controls.Add(this.rbOTCYes);
            this.panel2.Location = new System.Drawing.Point(108, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 29);
            this.panel2.TabIndex = 54;
            // 
            // rbOTCNo
            // 
            this.controlAutoFocus1.SetAllowNext(this.rbOTCNo, true);
            this.controlAutoFocus1.SetAllowPrevious(this.rbOTCNo, true);
            this.rbOTCNo.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.rbOTCNo, true);
            this.rbOTCNo.Location = new System.Drawing.Point(64, 5);
            this.rbOTCNo.Name = "rbOTCNo";
            this.rbOTCNo.Size = new System.Drawing.Size(39, 18);
            this.rbOTCNo.TabIndex = 51;
            this.rbOTCNo.Text = "否";
            this.rbOTCNo.UseVisualStyleBackColor = true;
            // 
            // rbOTCYes
            // 
            this.controlAutoFocus1.SetAllowNext(this.rbOTCYes, true);
            this.controlAutoFocus1.SetAllowPrevious(this.rbOTCYes, true);
            this.rbOTCYes.AutoSize = true;
            this.rbOTCYes.Checked = true;
            this.inputControlEnter1.SetFocus(this.rbOTCYes, true);
            this.rbOTCYes.Location = new System.Drawing.Point(3, 5);
            this.rbOTCYes.Name = "rbOTCYes";
            this.rbOTCYes.Size = new System.Drawing.Size(39, 18);
            this.rbOTCYes.TabIndex = 50;
            this.rbOTCYes.TabStop = true;
            this.rbOTCYes.Text = "是";
            this.rbOTCYes.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.controlAutoFocus1.SetAllowNext(this.label29, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label29, false);
            this.label29.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label29, false);
            this.label29.Location = new System.Drawing.Point(17, 337);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 14);
            this.label29.TabIndex = 53;
            this.label29.Text = "非处方药(&T)：";
            // 
            // tbFileNo
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbFileNo, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbFileNo, true);
            this.inputControlEnter1.SetFocus(this.tbFileNo, true);
            this.tbFileNo.Location = new System.Drawing.Point(110, 145);
            this.tbFileNo.MaxLength = 32;
            this.tbFileNo.Name = "tbFileNo";
            this.tbFileNo.Size = new System.Drawing.Size(312, 23);
            this.tbFileNo.TabIndex = 47;
            // 
            // label23
            // 
            this.controlAutoFocus1.SetAllowNext(this.label23, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label23, false);
            this.label23.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label23, false);
            this.label23.Location = new System.Drawing.Point(15, 149);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 14);
            this.label23.TabIndex = 46;
            this.label23.Text = "批准文号(&F)：";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(20, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(402, 1);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(19, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 1);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // cbxType
            // 
            this.controlAutoFocus1.SetAllowNext(this.cbxType, true);
            this.controlAutoFocus1.SetAllowPrevious(this.cbxType, true);
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputControlEnter1.SetFocus(this.cbxType, true);
            this.cbxType.Location = new System.Drawing.Point(108, 47);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(312, 22);
            this.cbxType.TabIndex = 3;
            // 
            // label19
            // 
            this.controlAutoFocus1.SetAllowNext(this.label19, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label19, false);
            this.inputControlEnter1.SetFocus(this.label19, false);
            this.label19.Location = new System.Drawing.Point(229, 259);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 14);
            this.label19.TabIndex = 30;
            this.label19.Text = "--->";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.controlAutoFocus1.SetAllowNext(this.label16, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label16, false);
            this.label16.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label16, false);
            this.label16.Location = new System.Drawing.Point(15, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 14);
            this.label16.TabIndex = 2;
            this.label16.Text = "药品类型(&T)：";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Item16.ico");
            this.imgList.Images.SetKeyName(1, "Yes16.ico");
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
            // DrugDictEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 530);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrugDictEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "药品字典属性";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbChinseName;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudDown;
        private System.Windows.Forms.NumericUpDown nudUp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbInputCode1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private DrugUnit tbBigUnit;
        private DrugUnit tbSmallUnit;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbOTCNo;
        private System.Windows.Forms.RadioButton rbOTCYes;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbFileNo;
        private System.Windows.Forms.Label label23;
        private DrugUnit tbUnit;
        private System.Windows.Forms.TextBox tbEffect;
        private System.Windows.Forms.Label label2;
        private EAS.Windows.UI.Controls.ControlAutoFocus controlAutoFocus1;
        private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;
    }
}