namespace DrugShop.WinUI
{
    partial class DrugStoreCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugStoreCount));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.tbSeach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.cbDown = new System.Windows.Forms.CheckBox();
            this.cbUp = new System.Windows.Forms.CheckBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ledClock = new EAS.Windows.UI.Controls.LEDClock();
            this.label38 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChinseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmrcountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ChinseNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmrcountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlAutoFocus1 = new EAS.Windows.UI.Controls.ControlAutoFocus(this.components);
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmrcountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmrcountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Item16.ico");
            this.imgList.Images.SetKeyName(1, "Yes16.ico");
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.AliceBlue;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.btnCount);
            this.panelTop.Controls.Add(this.btnCreate);
            this.panelTop.Controls.Add(this.chkOther);
            this.panelTop.Controls.Add(this.tbSeach);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.cbxDate);
            this.panelTop.Controls.Add(this.cbDown);
            this.panelTop.Controls.Add(this.cbUp);
            this.panelTop.Controls.Add(this.dtpTime);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.btnPrint);
            this.panelTop.Controls.Add(this.btnSave);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 48);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1246, 52);
            this.panelTop.TabIndex = 0;
            // 
            // btnCount
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnCount, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btnCount, false);
            this.btnCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCount.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputControlEnter1.SetFocus(this.btnCount, true);
            this.btnCount.Location = new System.Drawing.Point(876, 11);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(65, 27);
            this.btnCount.TabIndex = 32;
            this.btnCount.Text = "盘存(&C)";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnCreate
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnCreate, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btnCreate, false);
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputControlEnter1.SetFocus(this.btnCreate, true);
            this.btnCreate.Location = new System.Drawing.Point(948, 11);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(65, 27);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "检索(&J)";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // chkOther
            // 
            this.controlAutoFocus1.SetAllowNext(this.chkOther, false);
            this.controlAutoFocus1.SetAllowPrevious(this.chkOther, false);
            this.chkOther.AutoSize = true;
            this.chkOther.Checked = true;
            this.chkOther.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputControlEnter1.SetFocus(this.chkOther, true);
            this.chkOther.Location = new System.Drawing.Point(653, 17);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(110, 18);
            this.chkOther.TabIndex = 17;
            this.chkOther.Text = "持平数据过滤";
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.Visible = false;
            // 
            // tbSeach
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbSeach, false);
            this.controlAutoFocus1.SetAllowPrevious(this.tbSeach, false);
            this.inputControlEnter1.SetFocus(this.tbSeach, true);
            this.tbSeach.Location = new System.Drawing.Point(523, 14);
            this.tbSeach.Name = "tbSeach";
            this.tbSeach.Size = new System.Drawing.Size(95, 23);
            this.tbSeach.TabIndex = 5;
            this.tbSeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSeach_KeyDown);
            // 
            // label2
            // 
            this.controlAutoFocus1.SetAllowNext(this.label2, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label2, false);
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label2, false);
            this.label2.Location = new System.Drawing.Point(478, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "检索：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxDate
            // 
            this.controlAutoFocus1.SetAllowNext(this.cbxDate, false);
            this.controlAutoFocus1.SetAllowPrevious(this.cbxDate, false);
            this.cbxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputControlEnter1.SetFocus(this.cbxDate, true);
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Location = new System.Drawing.Point(303, 14);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(167, 22);
            this.cbxDate.TabIndex = 3;
            // 
            // cbDown
            // 
            this.controlAutoFocus1.SetAllowNext(this.cbDown, false);
            this.controlAutoFocus1.SetAllowPrevious(this.cbDown, false);
            this.cbDown.AutoSize = true;
            this.cbDown.Checked = true;
            this.cbDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputControlEnter1.SetFocus(this.cbDown, true);
            this.cbDown.Location = new System.Drawing.Point(826, 16);
            this.cbDown.Name = "cbDown";
            this.cbDown.Size = new System.Drawing.Size(54, 18);
            this.cbDown.TabIndex = 11;
            this.cbDown.Text = "盘亏";
            this.cbDown.UseVisualStyleBackColor = true;
            this.cbDown.Visible = false;
            // 
            // cbUp
            // 
            this.controlAutoFocus1.SetAllowNext(this.cbUp, false);
            this.controlAutoFocus1.SetAllowPrevious(this.cbUp, false);
            this.cbUp.AutoSize = true;
            this.cbUp.Checked = true;
            this.cbUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputControlEnter1.SetFocus(this.cbUp, true);
            this.cbUp.Location = new System.Drawing.Point(770, 16);
            this.cbUp.Name = "cbUp";
            this.cbUp.Size = new System.Drawing.Size(54, 18);
            this.cbUp.TabIndex = 10;
            this.cbUp.Text = "盘盈";
            this.cbUp.UseVisualStyleBackColor = true;
            this.cbUp.Visible = false;
            // 
            // dtpTime
            // 
            this.controlAutoFocus1.SetAllowNext(this.dtpTime, false);
            this.controlAutoFocus1.SetAllowPrevious(this.dtpTime, false);
            this.dtpTime.CustomFormat = "yyyy-MM-dd";
            this.dtpTime.Enabled = false;
            this.inputControlEnter1.SetFocus(this.dtpTime, true);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(97, 14);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(123, 23);
            this.dtpTime.TabIndex = 1;
            // 
            // label4
            // 
            this.controlAutoFocus1.SetAllowNext(this.label4, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label4, false);
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label4, false);
            this.label4.Location = new System.Drawing.Point(233, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "盘存日期：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrint
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnPrint, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btnPrint, false);
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputControlEnter1.SetFocus(this.btnPrint, true);
            this.btnPrint.Location = new System.Drawing.Point(1088, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 27);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "打印预览(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnSave, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btnSave, false);
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputControlEnter1.SetFocus(this.btnSave, true);
            this.btnSave.Location = new System.Drawing.Point(1021, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 27);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.controlAutoFocus1.SetAllowNext(this.label10, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label10, false);
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label10, false);
            this.label10.Location = new System.Drawing.Point(26, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "系统时间：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ledClock);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 48);
            this.panel2.TabIndex = 37;
            // 
            // ledClock
            // 
            this.controlAutoFocus1.SetAllowNext(this.ledClock, false);
            this.controlAutoFocus1.SetAllowPrevious(this.ledClock, false);
            this.ledClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledClock.ClockColor = System.Drawing.Color.Green;
            this.ledClock.DateTime = new System.DateTime(2013, 10, 10, 10, 12, 47, 0);
            this.inputControlEnter1.SetFocus(this.ledClock, false);
            this.ledClock.IsDrawShadow = true;
            this.ledClock.IsTimerEnable = true;
            this.ledClock.LEDClockStyle = EAS.Windows.UI.Controls.LEDClockStyle.DateAndTime;
            this.ledClock.Location = new System.Drawing.Point(1046, 9);
            this.ledClock.Name = "ledClock";
            this.ledClock.Size = new System.Drawing.Size(175, 28);
            this.ledClock.TabIndex = 38;
            // 
            // label38
            // 
            this.controlAutoFocus1.SetAllowNext(this.label38, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label38, false);
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label38, false);
            this.label38.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(965, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 14);
            this.label38.TabIndex = 37;
            this.label38.Text = "当前日期：";
            // 
            // label5
            // 
            this.controlAutoFocus1.SetAllowNext(this.label5, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label5, false);
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputControlEnter1.SetFocus(this.label5, false);
            this.label5.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(22, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "药品盘存";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(1246, 516);
            this.splitContainer1.SplitterDistance = 515;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.controlAutoFocus1.SetAllowNext(this.dataGridView1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.dataGridView1, false);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChinseNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.unitDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.RealNumberDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dmrcountBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlEnter1.SetFocus(this.dataGridView1, false);
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(515, 516);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // ChinseNameDataGridViewTextBoxColumn
            // 
            this.ChinseNameDataGridViewTextBoxColumn.DataPropertyName = "ChinseName";
            this.ChinseNameDataGridViewTextBoxColumn.HeaderText = "药品名称";
            this.ChinseNameDataGridViewTextBoxColumn.Name = "ChinseNameDataGridViewTextBoxColumn";
            this.ChinseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Spec";
            this.dataGridViewTextBoxColumn1.HeaderText = "规格";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "售价";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "库存数量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // RealNumberDataGridViewTextBoxColumn1
            // 
            this.RealNumberDataGridViewTextBoxColumn1.DataPropertyName = "RealNumber";
            this.RealNumberDataGridViewTextBoxColumn1.HeaderText = "实际数量";
            this.RealNumberDataGridViewTextBoxColumn1.Name = "RealNumberDataGridViewTextBoxColumn1";
            this.RealNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "药品类型";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dmrcountBindingSource1
            // 
            this.dmrcountBindingSource1.DataSource = typeof(DrugShop.Entities.Inventory);
            // 
            // dataGridView2
            // 
            this.controlAutoFocus1.SetAllowNext(this.dataGridView2, false);
            this.controlAutoFocus1.SetAllowPrevious(this.dataGridView2, false);
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChinseNameDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.unitDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.RealNumberDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn1,
            this.TimeLimitDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dmrcountBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlEnter1.SetFocus(this.dataGridView2, false);
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(726, 516);
            this.dataGridView2.TabIndex = 0;
            // 
            // ChinseNameDataGridViewTextBoxColumn1
            // 
            this.ChinseNameDataGridViewTextBoxColumn1.DataPropertyName = "ChinseName";
            this.ChinseNameDataGridViewTextBoxColumn1.HeaderText = "药品名称";
            this.ChinseNameDataGridViewTextBoxColumn1.Name = "ChinseNameDataGridViewTextBoxColumn1";
            this.ChinseNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Spec";
            this.dataGridViewTextBoxColumn2.HeaderText = "规格";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn1
            // 
            this.unitDataGridViewTextBoxColumn1.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn1.HeaderText = "单位";
            this.unitDataGridViewTextBoxColumn1.Name = "unitDataGridViewTextBoxColumn1";
            this.unitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "售价";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn7.HeaderText = "库存数量";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // RealNumberDataGridViewTextBoxColumn
            // 
            this.RealNumberDataGridViewTextBoxColumn.DataPropertyName = "RealNumber";
            this.RealNumberDataGridViewTextBoxColumn.HeaderText = "实际数量";
            this.RealNumberDataGridViewTextBoxColumn.Name = "RealNumberDataGridViewTextBoxColumn";
            this.RealNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "药品类型";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TimeLimitDataGridViewTextBoxColumn
            // 
            this.TimeLimitDataGridViewTextBoxColumn.DataPropertyName = "TimeLimit";
            this.TimeLimitDataGridViewTextBoxColumn.HeaderText = "效期";
            this.TimeLimitDataGridViewTextBoxColumn.Name = "TimeLimitDataGridViewTextBoxColumn";
            this.TimeLimitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "供应商";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            this.providerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dmrcountBindingSource
            // 
            this.dmrcountBindingSource.DataSource = typeof(DrugShop.Entities.Inventory);
            // 
            // controlAutoFocus1
            // 
            this.controlAutoFocus1.NextKeys = null;
            this.controlAutoFocus1.PreviousKeys = null;
            // 
            // inputControlEnter1
            // 
            this.inputControlEnter1.DroppedDown = true;
            this.inputControlEnter1.EnterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inputControlEnter1.EnterForeColor = System.Drawing.Color.Red;
            // 
            // DrugStoreCount
            // 
            this.controlAutoFocus1.SetAllowNext(this, false);
            this.controlAutoFocus1.SetAllowPrevious(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel2);
            this.inputControlEnter1.SetFocus(this, false);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DrugStoreCount";
            this.Size = new System.Drawing.Size(1246, 616);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmrcountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmrcountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.CheckBox cbDown;
        private System.Windows.Forms.CheckBox cbUp;
        private System.Windows.Forms.ComboBox cbxDate;
        private System.Windows.Forms.TextBox tbSeach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private EAS.Windows.UI.Controls.LEDClock ledClock;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bigUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smallUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packRuleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChinseNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dmrcountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChinseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dmrcountBindingSource1;
        private System.Windows.Forms.Button btnCount;
        private EAS.Windows.UI.Controls.ControlAutoFocus controlAutoFocus1;
        private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;

    }
}
