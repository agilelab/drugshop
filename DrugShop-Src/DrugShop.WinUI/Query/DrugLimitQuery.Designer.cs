namespace DrugShop.WinUI
{
    partial class DrugLimitQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugLimitQuery));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbWarn = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSeach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panBottom = new System.Windows.Forms.Panel();
            this.lbTip = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ledClock = new EAS.Windows.UI.Controls.LEDClock();
            this.label38 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChinseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmrstoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.controlAutoFocus1 = new EAS.Windows.UI.Controls.ControlAutoFocus(this.components);
            this.panelTop.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmrstoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.btnPrint);
            this.panelTop.Controls.Add(this.btnSeach);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.tbDay);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.cbxType);
            this.panelTop.Controls.Add(this.cbWarn);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.tbSeach);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 48);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(933, 72);
            this.panelTop.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnPrint, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnPrint, true);
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputControlEnter1.SetFocus(this.btnPrint, true);
            this.btnPrint.Location = new System.Drawing.Point(637, 31);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 27);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSeach
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnSeach, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnSeach, true);
            this.btnSeach.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputControlEnter1.SetFocus(this.btnSeach, true);
            this.btnSeach.Location = new System.Drawing.Point(533, 31);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(95, 27);
            this.btnSeach.TabIndex = 9;
            this.btnSeach.Text = "查询(&S)";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // label4
            // 
            this.controlAutoFocus1.SetAllowNext(this.label4, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label4, false);
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label4, false);
            this.label4.Location = new System.Drawing.Point(121, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "天失效的药品";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDay
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbDay, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbDay, true);
            this.tbDay.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.tbDay, true);
            this.tbDay.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbDay.Location = new System.Drawing.Point(87, 37);
            this.tbDay.MaxLength = 4;
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(30, 23);
            this.tbDay.TabIndex = 6;
            this.tbDay.Text = "0";
            this.tbDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDay_KeyDown);
            // 
            // label3
            // 
            this.controlAutoFocus1.SetAllowNext(this.label3, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label3, false);
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label3, false);
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "距 当 前：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxType
            // 
            this.controlAutoFocus1.SetAllowNext(this.cbxType, true);
            this.controlAutoFocus1.SetAllowPrevious(this.cbxType, true);
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputControlEnter1.SetFocus(this.cbxType, true);
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(87, 7);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(116, 22);
            this.cbxType.TabIndex = 1;
            // 
            // cbWarn
            // 
            this.controlAutoFocus1.SetAllowNext(this.cbWarn, true);
            this.controlAutoFocus1.SetAllowPrevious(this.cbWarn, true);
            this.cbWarn.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.cbWarn, true);
            this.cbWarn.Location = new System.Drawing.Point(424, 9);
            this.cbWarn.Name = "cbWarn";
            this.cbWarn.Size = new System.Drawing.Size(82, 18);
            this.cbWarn.TabIndex = 4;
            this.cbWarn.Text = "失效药品";
            this.cbWarn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.controlAutoFocus1.SetAllowNext(this.label2, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label2, false);
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label2, false);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(227, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "提示：红色已失效药品，蓝色为即将失效药品";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSeach
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbSeach, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbSeach, true);
            this.tbSeach.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.tbSeach, true);
            this.tbSeach.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbSeach.Location = new System.Drawing.Point(278, 7);
            this.tbSeach.MaxLength = 32;
            this.tbSeach.Name = "tbSeach";
            this.tbSeach.Size = new System.Drawing.Size(140, 23);
            this.tbSeach.TabIndex = 3;
            this.tbSeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSeach_KeyDown);
            // 
            // label1
            // 
            this.controlAutoFocus1.SetAllowNext(this.label1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label1, false);
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label1, false);
            this.label1.Location = new System.Drawing.Point(215, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "检索(&S)：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.controlAutoFocus1.SetAllowNext(this.label10, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label10, false);
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label10, false);
            this.label10.Location = new System.Drawing.Point(16, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "药品类型：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.White;
            this.panBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBottom.Controls.Add(this.lbTip);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 427);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(933, 40);
            this.panBottom.TabIndex = 3;
            // 
            // lbTip
            // 
            this.controlAutoFocus1.SetAllowNext(this.lbTip, false);
            this.controlAutoFocus1.SetAllowPrevious(this.lbTip, false);
            this.lbTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTip.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.lbTip, false);
            this.lbTip.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTip.ForeColor = System.Drawing.Color.Blue;
            this.lbTip.Location = new System.Drawing.Point(11, 12);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(227, 14);
            this.lbTip.TabIndex = 0;
            this.lbTip.Text = "共有药品记录0条，总金额0.00元";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "");
            this.imgList.Images.SetKeyName(1, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ledClock);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 48);
            this.panel1.TabIndex = 0;
            // 
            // ledClock
            // 
            this.controlAutoFocus1.SetAllowNext(this.ledClock, false);
            this.controlAutoFocus1.SetAllowPrevious(this.ledClock, false);
            this.ledClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledClock.ClockColor = System.Drawing.Color.Green;
            this.ledClock.DateTime = new System.DateTime(2013, 10, 10, 11, 43, 49, 0);
            this.inputControlEnter1.SetFocus(this.ledClock, false);
            this.ledClock.IsDrawShadow = true;
            this.ledClock.IsTimerEnable = true;
            this.ledClock.LEDClockStyle = EAS.Windows.UI.Controls.LEDClockStyle.DateAndTime;
            this.ledClock.Location = new System.Drawing.Point(734, 9);
            this.ledClock.Name = "ledClock";
            this.ledClock.Size = new System.Drawing.Size(175, 28);
            this.ledClock.TabIndex = 2;
            // 
            // label38
            // 
            this.controlAutoFocus1.SetAllowNext(this.label38, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label38, false);
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label38, false);
            this.label38.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(652, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 14);
            this.label38.TabIndex = 1;
            this.label38.Text = "当前日期：";
            // 
            // label11
            // 
            this.controlAutoFocus1.SetAllowNext(this.label11, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label11, false);
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputControlEnter1.SetFocus(this.label11, false);
            this.label11.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(22, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "药品效期预警";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.controlAutoFocus1.SetAllowNext(this.dataGridView1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.dataGridView1, false);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChinseNameDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.numberDataGridViewTextBoxColumn,
            this.Type,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.DataSource = this.dmrstoreBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlEnter1.SetFocus(this.dataGridView1, false);
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(933, 307);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // ChinseNameDataGridViewTextBoxColumn
            // 
            this.ChinseNameDataGridViewTextBoxColumn.DataPropertyName = "ChinseName";
            this.ChinseNameDataGridViewTextBoxColumn.HeaderText = "药品名称";
            this.ChinseNameDataGridViewTextBoxColumn.Name = "ChinseNameDataGridViewTextBoxColumn";
            this.ChinseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ChinseNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "Spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "规格";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            this.specDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "售价";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "数量";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "药品类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TimeLimit";
            this.dataGridViewTextBoxColumn9.HeaderText = "失效日期";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dmrstoreBindingSource
            // 
            this.dmrstoreBindingSource.DataSource = typeof(DrugShop.Entities.Store);
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
            // DrugLimitQuery
            // 
            this.controlAutoFocus1.SetAllowNext(this, false);
            this.controlAutoFocus1.SetAllowPrevious(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panBottom);
            this.inputControlEnter1.SetFocus(this, false);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DrugLimitQuery";
            this.Size = new System.Drawing.Size(933, 467);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmrstoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbWarn;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Label lbTip;
        private System.Windows.Forms.Panel panel1;
        private EAS.Windows.UI.Controls.LEDClock ledClock;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource dmrstoreBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChinseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private EAS.Windows.UI.Controls.ControlAutoFocus controlAutoFocus1;
        private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;

    }
}
