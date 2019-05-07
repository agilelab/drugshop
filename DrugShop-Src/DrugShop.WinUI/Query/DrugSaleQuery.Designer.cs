namespace DrugShop.WinUI
{
    partial class DrugSaleQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugSaleQuery));
            this.panelTop = new System.Windows.Forms.Panel();
            this.tbCustomName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSeach = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ledClock = new EAS.Windows.UI.Controls.LEDClock();
            this.label38 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dmroutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Viewer = new EAS.GReport.Controls.GDisplayViewer();
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.controlAutoFocus1 = new EAS.Windows.UI.Controls.ControlAutoFocus(this.components);
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmroutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.tbCustomName);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.tbSeach);
            this.panelTop.Controls.Add(this.btnPrint);
            this.panelTop.Controls.Add(this.btnSeach);
            this.panelTop.Controls.Add(this.dtpEnd);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.dtpStart);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 48);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(933, 72);
            this.panelTop.TabIndex = 1;
            // 
            // tbCustomName
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbCustomName, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbCustomName, true);
            this.tbCustomName.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.tbCustomName, true);
            this.tbCustomName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbCustomName.Location = new System.Drawing.Point(78, 7);
            this.tbCustomName.MaxLength = 32;
            this.tbCustomName.Name = "tbCustomName";
            this.tbCustomName.Size = new System.Drawing.Size(158, 23);
            this.tbCustomName.TabIndex = 1;
            // 
            // label4
            // 
            this.controlAutoFocus1.SetAllowNext(this.label4, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label4, false);
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label4, false);
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "客户姓名：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSeach
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbSeach, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbSeach, true);
            this.tbSeach.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.tbSeach, true);
            this.tbSeach.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbSeach.Location = new System.Drawing.Point(280, 7);
            this.tbSeach.MaxLength = 32;
            this.tbSeach.Name = "tbSeach";
            this.tbSeach.Size = new System.Drawing.Size(175, 23);
            this.tbSeach.TabIndex = 3;
            this.tbSeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSeach_KeyDown);
            // 
            // btnPrint
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnPrint, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnPrint, true);
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputControlEnter1.SetFocus(this.btnPrint, true);
            this.btnPrint.Location = new System.Drawing.Point(567, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 27);
            this.btnPrint.TabIndex = 9;
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
            this.btnSeach.Location = new System.Drawing.Point(465, 32);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(96, 27);
            this.btnSeach.TabIndex = 8;
            this.btnSeach.Text = "查询(&S)";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // dtpEnd
            // 
            this.controlAutoFocus1.SetAllowNext(this.dtpEnd, true);
            this.controlAutoFocus1.SetAllowPrevious(this.dtpEnd, true);
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.inputControlEnter1.SetFocus(this.dtpEnd, true);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(280, 36);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(175, 23);
            this.dtpEnd.TabIndex = 7;
            // 
            // label3
            // 
            this.controlAutoFocus1.SetAllowNext(this.label3, true);
            this.controlAutoFocus1.SetAllowPrevious(this.label3, true);
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label3, true);
            this.label3.Location = new System.Drawing.Point(251, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "-->";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStart
            // 
            this.controlAutoFocus1.SetAllowNext(this.dtpStart, true);
            this.controlAutoFocus1.SetAllowPrevious(this.dtpStart, true);
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.inputControlEnter1.SetFocus(this.dtpStart, true);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(78, 36);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(175, 23);
            this.dtpStart.TabIndex = 5;
            // 
            // label2
            // 
            this.controlAutoFocus1.SetAllowNext(this.label2, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label2, false);
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label2, false);
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "出库时间：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.controlAutoFocus1.SetAllowNext(this.label1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label1, false);
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label1, false);
            this.label1.Location = new System.Drawing.Point(242, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "检索：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ledClock.DateTime = new System.DateTime(2013, 10, 10, 11, 43, 38, 0);
            this.inputControlEnter1.SetFocus(this.ledClock, false);
            this.ledClock.IsDrawShadow = true;
            this.ledClock.IsTimerEnable = true;
            this.ledClock.LEDClockStyle = EAS.Windows.UI.Controls.LEDClockStyle.DateAndTime;
            this.ledClock.Location = new System.Drawing.Point(734, 9);
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
            this.label38.Location = new System.Drawing.Point(652, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 14);
            this.label38.TabIndex = 37;
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
            this.label11.Location = new System.Drawing.Point(10, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "药品销售查询";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dmroutBindingSource
            // 
            this.dmroutBindingSource.DataSource = typeof(DrugShop.Entities.SOut);
            // 
            // Viewer
            // 
            this.controlAutoFocus1.SetAllowNext(this.Viewer, false);
            this.controlAutoFocus1.SetAllowPrevious(this.Viewer, false);
            this.Viewer.BackColor = System.Drawing.SystemColors.Control;
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlEnter1.SetFocus(this.Viewer, false);
            this.Viewer.Location = new System.Drawing.Point(0, 120);
            this.Viewer.Name = "Viewer";
            this.Viewer.ShowClose = true;
            this.Viewer.ShowFooter = true;
            this.Viewer.ShowHeader = true;
            this.Viewer.ShowLoad = false;
            this.Viewer.Size = new System.Drawing.Size(933, 323);
            this.Viewer.TabIndex = 2;
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
            // DrugSaleQuery
            // 
            this.controlAutoFocus1.SetAllowNext(this, false);
            this.controlAutoFocus1.SetAllowPrevious(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.inputControlEnter1.SetFocus(this, false);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DrugSaleQuery";
            this.Size = new System.Drawing.Size(933, 443);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmroutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Panel panel1;
        private EAS.Windows.UI.Controls.LEDClock ledClock;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource dmroutBindingSource;
        private System.Windows.Forms.TextBox tbCustomName;
        private System.Windows.Forms.Label label4;
        private EAS.GReport.Controls.GDisplayViewer Viewer;
        private EAS.Windows.UI.Controls.ControlAutoFocus controlAutoFocus1;
        private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;

    }
}
