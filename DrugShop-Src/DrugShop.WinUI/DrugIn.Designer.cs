namespace  DrugShop.WinUI

{
    partial class DrugIn
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugIn));
            this.pnTop = new System.Windows.Forms.Panel();
            this.ledClock = new EAS.Windows.UI.Controls.LEDClock();
            this.label38 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panMethod = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpTimeLimit = new System.Windows.Forms.DateTimePicker();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContens = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvwDrugInList = new System.Windows.Forms.ListView();
            this.HID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HContor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HBUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HBatch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAutoComplete1 = new EAS.Windows.UI.Controls.TextBoxAutoComplete(this.components);
            this.chineseLanguageInput1 = new EAS.Windows.UI.Controls.ChineseLanguageInput(this.components);
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.controlAutoFocus1 = new EAS.Windows.UI.Controls.ControlAutoFocus(this.components);
            this.pnTop.SuspendLayout();
            this.panMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTop.Controls.Add(this.ledClock);
            this.pnTop.Controls.Add(this.label38);
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1079, 30);
            this.pnTop.TabIndex = 0;
            this.pnTop.TabStop = true;
            // 
            // ledClock
            // 
            this.controlAutoFocus1.SetAllowNext(this.ledClock, false);
            this.controlAutoFocus1.SetAllowPrevious(this.ledClock, false);
            this.ledClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledClock.ClockColor = System.Drawing.Color.Green;
            this.ledClock.DateTime = new System.DateTime(2013, 12, 18, 13, 23, 29, 0);
            this.inputControlEnter1.SetFocus(this.ledClock, false);
            this.ledClock.IsDrawShadow = true;
            this.ledClock.IsTimerEnable = true;
            this.ledClock.LEDClockStyle = EAS.Windows.UI.Controls.LEDClockStyle.DateAndTime;
            this.ledClock.Location = new System.Drawing.Point(912, 3);
            this.ledClock.Name = "ledClock";
            this.ledClock.Size = new System.Drawing.Size(144, 23);
            this.ledClock.TabIndex = 10;
            // 
            // label38
            // 
            this.controlAutoFocus1.SetAllowNext(this.label38, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label38, false);
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label38, false);
            this.label38.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(842, 8);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 14);
            this.label38.TabIndex = 9;
            this.label38.Text = "当前时间：";
            // 
            // lbTitle
            // 
            this.controlAutoFocus1.SetAllowNext(this.lbTitle, false);
            this.controlAutoFocus1.SetAllowPrevious(this.lbTitle, false);
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputControlEnter1.SetFocus(this.lbTitle, false);
            this.lbTitle.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Teal;
            this.lbTitle.Location = new System.Drawing.Point(10, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(102, 21);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "药品入库";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panMethod
            // 
            this.panMethod.Controls.Add(this.btnPrint);
            this.panMethod.Controls.Add(this.dtpTimeLimit);
            this.panMethod.Controls.Add(this.txtBatch);
            this.panMethod.Controls.Add(this.label11);
            this.panMethod.Controls.Add(this.txtNumber);
            this.panMethod.Controls.Add(this.label6);
            this.panMethod.Controls.Add(this.txtInPrice);
            this.panMethod.Controls.Add(this.label7);
            this.panMethod.Controls.Add(this.btnClose);
            this.panMethod.Controls.Add(this.btnOK);
            this.panMethod.Controls.Add(this.label8);
            this.panMethod.Controls.Add(this.txtContens);
            this.panMethod.Controls.Add(this.label5);
            this.panMethod.Controls.Add(this.txtName);
            this.panMethod.Controls.Add(this.label3);
            this.panMethod.Controls.Add(this.txtSearch);
            this.panMethod.Controls.Add(this.label1);
            this.panMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMethod.Location = new System.Drawing.Point(0, 30);
            this.panMethod.Name = "panMethod";
            this.panMethod.Size = new System.Drawing.Size(1079, 68);
            this.panMethod.TabIndex = 1;
            this.panMethod.TabStop = true;
            // 
            // btnPrint
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnPrint, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnPrint, true);
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btnPrint, true);
            this.btnPrint.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnPrint.Location = new System.Drawing.Point(922, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpTimeLimit
            // 
            this.controlAutoFocus1.SetAllowNext(this.dtpTimeLimit, true);
            this.controlAutoFocus1.SetAllowPrevious(this.dtpTimeLimit, true);
            this.dtpTimeLimit.CustomFormat = "yyyy-MM-dd";
            this.inputControlEnter1.SetFocus(this.dtpTimeLimit, true);
            this.dtpTimeLimit.Font = new System.Drawing.Font("宋体", 10.5F);
            this.dtpTimeLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeLimit.Location = new System.Drawing.Point(397, 36);
            this.dtpTimeLimit.Name = "dtpTimeLimit";
            this.dtpTimeLimit.ShowUpDown = true;
            this.dtpTimeLimit.Size = new System.Drawing.Size(99, 23);
            this.dtpTimeLimit.TabIndex = 11;
            this.dtpTimeLimit.Value = new System.DateTime(2013, 2, 26, 23, 5, 0, 0);
            this.dtpTimeLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpTimeLimit_KeyDown);
            // 
            // txtBatch
            // 
            this.controlAutoFocus1.SetAllowNext(this.txtBatch, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txtBatch, true);
            this.inputControlEnter1.SetFocus(this.txtBatch, true);
            this.txtBatch.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtBatch.Location = new System.Drawing.Point(239, 37);
            this.textBoxAutoComplete1.SetMetadataID(this.txtBatch, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.txtBatch.Name = "txtBatch";
            this.textBoxAutoComplete1.SetNextControl(this.txtBatch, null);
            this.txtBatch.Size = new System.Drawing.Size(83, 23);
            this.txtBatch.TabIndex = 9;
            this.txtBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatch_KeyDown);
            // 
            // label11
            // 
            this.controlAutoFocus1.SetAllowNext(this.label11, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label11, false);
            this.label11.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label11, false);
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label11.Location = new System.Drawing.Point(166, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 8;
            this.label11.Text = "批    号：";
            // 
            // txtNumber
            // 
            this.controlAutoFocus1.SetAllowNext(this.txtNumber, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txtNumber, true);
            this.inputControlEnter1.SetFocus(this.txtNumber, true);
            this.txtNumber.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtNumber.Location = new System.Drawing.Point(584, 36);
            this.textBoxAutoComplete1.SetMetadataID(this.txtNumber, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.txtNumber.Name = "txtNumber";
            this.textBoxAutoComplete1.SetNextControl(this.txtNumber, null);
            this.txtNumber.Size = new System.Drawing.Size(108, 23);
            this.txtNumber.TabIndex = 13;
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // label6
            // 
            this.controlAutoFocus1.SetAllowNext(this.label6, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label6, false);
            this.label6.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label6, false);
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label6.Location = new System.Drawing.Point(512, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "数    量：";
            // 
            // txtInPrice
            // 
            this.controlAutoFocus1.SetAllowNext(this.txtInPrice, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txtInPrice, true);
            this.txtInPrice.BackColor = System.Drawing.Color.White;
            this.txtInPrice.Enabled = false;
            this.inputControlEnter1.SetFocus(this.txtInPrice, true);
            this.txtInPrice.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtInPrice.Location = new System.Drawing.Point(77, 36);
            this.textBoxAutoComplete1.SetMetadataID(this.txtInPrice, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.txtInPrice.Name = "txtInPrice";
            this.textBoxAutoComplete1.SetNextControl(this.txtInPrice, null);
            this.txtInPrice.ReadOnly = true;
            this.txtInPrice.Size = new System.Drawing.Size(83, 23);
            this.txtInPrice.TabIndex = 7;
            // 
            // label7
            // 
            this.controlAutoFocus1.SetAllowNext(this.label7, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label7, false);
            this.label7.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label7, false);
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "进    价：";
            // 
            // btnClose
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnClose, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnClose, true);
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btnClose, false);
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnClose.Location = new System.Drawing.Point(1001, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btnOK
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnOK, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnOK, true);
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btnOK, true);
            this.btnOK.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnOK.Location = new System.Drawing.Point(841, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "入库(&D)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label8
            // 
            this.controlAutoFocus1.SetAllowNext(this.label8, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label8, false);
            this.label8.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label8, false);
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label8.Location = new System.Drawing.Point(326, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "效    期：";
            // 
            // txtContens
            // 
            this.controlAutoFocus1.SetAllowNext(this.txtContens, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txtContens, true);
            this.txtContens.BackColor = System.Drawing.Color.White;
            this.txtContens.Enabled = false;
            this.inputControlEnter1.SetFocus(this.txtContens, true);
            this.txtContens.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtContens.Location = new System.Drawing.Point(584, 10);
            this.textBoxAutoComplete1.SetMetadataID(this.txtContens, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.txtContens.Name = "txtContens";
            this.textBoxAutoComplete1.SetNextControl(this.txtContens, null);
            this.txtContens.ReadOnly = true;
            this.txtContens.Size = new System.Drawing.Size(108, 23);
            this.txtContens.TabIndex = 5;
            // 
            // label5
            // 
            this.controlAutoFocus1.SetAllowNext(this.label5, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label5, false);
            this.label5.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label5, false);
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label5.Location = new System.Drawing.Point(511, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "规    格：";
            // 
            // txtName
            // 
            this.controlAutoFocus1.SetAllowNext(this.txtName, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txtName, true);
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Enabled = false;
            this.inputControlEnter1.SetFocus(this.txtName, true);
            this.txtName.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtName.Location = new System.Drawing.Point(239, 9);
            this.textBoxAutoComplete1.SetMetadataID(this.txtName, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.txtName.Name = "txtName";
            this.textBoxAutoComplete1.SetNextControl(this.txtName, null);
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(257, 23);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.controlAutoFocus1.SetAllowNext(this.label3, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label3, false);
            this.label3.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label3, false);
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(166, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "名    称：";
            // 
            // txtSearch
            // 
            this.controlAutoFocus1.SetAllowNext(this.txtSearch, false);
            this.controlAutoFocus1.SetAllowPrevious(this.txtSearch, false);
            this.inputControlEnter1.SetFocus(this.txtSearch, true);
            this.txtSearch.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txtSearch.Location = new System.Drawing.Point(77, 9);
            this.textBoxAutoComplete1.SetMetadataID(this.txtSearch, new System.Guid("935e4632-049f-479d-94ba-52d49a256e56"));
            this.txtSearch.Name = "txtSearch";
            this.textBoxAutoComplete1.SetNextControl(this.txtSearch, this.txtName);
            this.txtSearch.Size = new System.Drawing.Size(83, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.controlAutoFocus1.SetAllowNext(this.label1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label1, false);
            this.label1.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label1, false);
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "检    索：";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Arrow Right.ico");
            this.ImageList1.Images.SetKeyName(1, "Ok.ico");
            // 
            // lvwDrugInList
            // 
            this.controlAutoFocus1.SetAllowNext(this.lvwDrugInList, false);
            this.controlAutoFocus1.SetAllowPrevious(this.lvwDrugInList, false);
            this.lvwDrugInList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HID,
            this.HCode,
            this.HName,
            this.HContor,
            this.HBUnit,
            this.HDateTime,
            this.HBatch,
            this.HPrice,
            this.HNumber,
            this.columnHeader3});
            this.lvwDrugInList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlEnter1.SetFocus(this.lvwDrugInList, false);
            this.lvwDrugInList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwDrugInList.FullRowSelect = true;
            this.lvwDrugInList.GridLines = true;
            this.lvwDrugInList.Location = new System.Drawing.Point(0, 98);
            this.lvwDrugInList.MultiSelect = false;
            this.lvwDrugInList.Name = "lvwDrugInList";
            this.lvwDrugInList.Size = new System.Drawing.Size(1079, 302);
            this.lvwDrugInList.SmallImageList = this.ImageList1;
            this.lvwDrugInList.TabIndex = 2;
            this.lvwDrugInList.UseCompatibleStateImageBehavior = false;
            this.lvwDrugInList.View = System.Windows.Forms.View.Details;
            this.lvwDrugInList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwDrugInList_KeyDown);
            // 
            // HID
            // 
            this.HID.Text = "@";
            this.HID.Width = 20;
            // 
            // HCode
            // 
            this.HCode.Text = "药品编码";
            this.HCode.Width = 90;
            // 
            // HName
            // 
            this.HName.Text = "药品名称";
            this.HName.Width = 200;
            // 
            // HContor
            // 
            this.HContor.Text = "药品规格";
            this.HContor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HContor.Width = 120;
            // 
            // HBUnit
            // 
            this.HBUnit.Text = "单位";
            this.HBUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HBUnit.Width = 80;
            // 
            // HDateTime
            // 
            this.HDateTime.Text = "效期";
            this.HDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HDateTime.Width = 100;
            // 
            // HBatch
            // 
            this.HBatch.Text = "批号";
            this.HBatch.Width = 80;
            // 
            // HPrice
            // 
            this.HPrice.Text = "售价";
            this.HPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HPrice.Width = 70;
            // 
            // HNumber
            // 
            this.HNumber.Text = "数量";
            this.HNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HNumber.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "类型";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // textBoxAutoComplete1
            // 
            this.textBoxAutoComplete1.Enabled = true;
            this.textBoxAutoComplete1.InputComplete += new System.EventHandler<EAS.Windows.UI.Controls.TextBoxInputEventAgrs>(this.textBoxAutoComplete1_InputComplete);
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
            // DrugIn
            // 
            this.controlAutoFocus1.SetAllowNext(this, false);
            this.controlAutoFocus1.SetAllowPrevious(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.lvwDrugInList);
            this.Controls.Add(this.panMethod);
            this.Controls.Add(this.pnTop);
            this.inputControlEnter1.SetFocus(this, false);
            this.Name = "DrugIn";
            this.Size = new System.Drawing.Size(1079, 400);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panMethod.ResumeLayout(false);
            this.panMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private EAS.Windows.UI.Controls.LEDClock ledClock;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panMethod;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader HID;
        private System.Windows.Forms.ColumnHeader HCode;
        private System.Windows.Forms.ColumnHeader HName;
        private System.Windows.Forms.ColumnHeader HContor;
        private System.Windows.Forms.ColumnHeader HBUnit;
        private System.Windows.Forms.ColumnHeader HDateTime;
        private System.Windows.Forms.ColumnHeader HPrice;
        private System.Windows.Forms.ColumnHeader HNumber;
        private System.Windows.Forms.ListView lvwDrugInList;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.TextBox txtInPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader HBatch;
        private System.Windows.Forms.DateTimePicker dtpTimeLimit;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnPrint;
        private EAS.Windows.UI.Controls.TextBoxAutoComplete textBoxAutoComplete1;
        private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;
        private EAS.Windows.UI.Controls.ChineseLanguageInput chineseLanguageInput1;
        private EAS.Windows.UI.Controls.ControlAutoFocus controlAutoFocus1;
    }
}
