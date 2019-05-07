namespace DrugShop.WinUI
{
    partial class DrugSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugSale));
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView_Store = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DCurron = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DBuint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ddatetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DKNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DInprices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DbachNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DFactory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_DrugOut = new System.Windows.Forms.ListView();
            this.HID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HContor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HBunit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HTimeLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HInprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HOutNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_left = new System.Windows.Forms.Panel();
            this.txt_TimeLimit = new System.Windows.Forms.TextBox();
            this.txt_OutNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_StoreNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_contents = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_BUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_SelectPrice = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.panMethod = new System.Windows.Forms.Panel();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.ledClock = new EAS.Windows.UI.Controls.LEDClock();
            this.label38 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.controlAutoFocus1 = new EAS.Windows.UI.Controls.ControlAutoFocus(this.components);
            this.panel_left.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panMethod.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Arrow Right.ico");
            this.ImageList1.Images.SetKeyName(1, "Ok.ico");
            // 
            // listView_Store
            // 
            this.controlAutoFocus1.SetAllowNext(this.listView_Store, false);
            this.controlAutoFocus1.SetAllowPrevious(this.listView_Store, false);
            this.listView_Store.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView_Store.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.DCode,
            this.DName,
            this.DCurron,
            this.DBuint,
            this.Ddatetime,
            this.DKNumber,
            this.DInprices,
            this.DbachNo,
            this.DFactory});
            this.inputControlEnter1.SetFocus(this.listView_Store, false);
            this.listView_Store.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_Store.FullRowSelect = true;
            this.listView_Store.GridLines = true;
            this.listView_Store.Location = new System.Drawing.Point(76, 151);
            this.listView_Store.Name = "listView_Store";
            this.listView_Store.Size = new System.Drawing.Size(894, 233);
            this.listView_Store.SmallImageList = this.ImageList1;
            this.listView_Store.TabIndex = 21;
            this.listView_Store.UseCompatibleStateImageBehavior = false;
            this.listView_Store.View = System.Windows.Forms.View.Details;
            this.listView_Store.Visible = false;
            this.listView_Store.DoubleClick += new System.EventHandler(this.listView_Store_DoubleClick);
            this.listView_Store.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_Store_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "@";
            this.columnHeader1.Width = 5;
            // 
            // DCode
            // 
            this.DCode.Text = "药品编码";
            this.DCode.Width = 75;
            // 
            // DName
            // 
            this.DName.Text = "药品名称";
            this.DName.Width = 200;
            // 
            // DCurron
            // 
            this.DCurron.Text = "药品规格";
            this.DCurron.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DCurron.Width = 120;
            // 
            // DBuint
            // 
            this.DBuint.Text = "单位";
            this.DBuint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DBuint.Width = 90;
            // 
            // Ddatetime
            // 
            this.Ddatetime.Text = "效期";
            this.Ddatetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ddatetime.Width = 90;
            // 
            // DKNumber
            // 
            this.DKNumber.Text = "库存量";
            this.DKNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DKNumber.Width = 55;
            // 
            // DInprices
            // 
            this.DInprices.Text = "价格";
            this.DInprices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DInprices.Width = 55;
            // 
            // DbachNo
            // 
            this.DbachNo.Text = "批号";
            this.DbachNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DbachNo.Width = 70;
            // 
            // DFactory
            // 
            this.DFactory.Text = "生产厂家";
            this.DFactory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DFactory.Width = 120;
            // 
            // listView_DrugOut
            // 
            this.controlAutoFocus1.SetAllowNext(this.listView_DrugOut, false);
            this.controlAutoFocus1.SetAllowPrevious(this.listView_DrugOut, false);
            this.listView_DrugOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HID,
            this.HCode,
            this.HName,
            this.HContor,
            this.HBunit,
            this.HTimeLimit,
            this.HInprice,
            this.HNumber,
            this.HOutNumber});
            this.listView_DrugOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlEnter1.SetFocus(this.listView_DrugOut, false);
            this.listView_DrugOut.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_DrugOut.FullRowSelect = true;
            this.listView_DrugOut.GridLines = true;
            this.listView_DrugOut.Location = new System.Drawing.Point(221, 102);
            this.listView_DrugOut.MultiSelect = false;
            this.listView_DrugOut.Name = "listView_DrugOut";
            this.listView_DrugOut.Size = new System.Drawing.Size(968, 359);
            this.listView_DrugOut.SmallImageList = this.ImageList1;
            this.listView_DrugOut.TabIndex = 20;
            this.listView_DrugOut.UseCompatibleStateImageBehavior = false;
            this.listView_DrugOut.View = System.Windows.Forms.View.Details;
            this.listView_DrugOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_DrugOut_KeyDown);
            // 
            // HID
            // 
            this.HID.Text = "@";
            this.HID.Width = 20;
            // 
            // HCode
            // 
            this.HCode.Text = "编码";
            this.HCode.Width = 50;
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
            this.HContor.Width = 100;
            // 
            // HBunit
            // 
            this.HBunit.Text = "单位";
            this.HBunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HBunit.Width = 80;
            // 
            // HTimeLimit
            // 
            this.HTimeLimit.Text = "效期";
            this.HTimeLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HTimeLimit.Width = 80;
            // 
            // HInprice
            // 
            this.HInprice.Text = "售价";
            this.HInprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HInprice.Width = 75;
            // 
            // HNumber
            // 
            this.HNumber.Text = "库存量";
            this.HNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HNumber.Width = 75;
            // 
            // HOutNumber
            // 
            this.HOutNumber.Text = "出库量";
            this.HOutNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HOutNumber.Width = 75;
            // 
            // panel_left
            // 
            this.panel_left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_left.Controls.Add(this.txt_TimeLimit);
            this.panel_left.Controls.Add(this.txt_OutNumber);
            this.panel_left.Controls.Add(this.label17);
            this.panel_left.Controls.Add(this.txt_StoreNumber);
            this.panel_left.Controls.Add(this.label15);
            this.panel_left.Controls.Add(this.txt_price);
            this.panel_left.Controls.Add(this.label16);
            this.panel_left.Controls.Add(this.label13);
            this.panel_left.Controls.Add(this.txt_contents);
            this.panel_left.Controls.Add(this.label11);
            this.panel_left.Controls.Add(this.txt_name);
            this.panel_left.Controls.Add(this.label10);
            this.panel_left.Controls.Add(this.txt_code);
            this.panel_left.Controls.Add(this.label9);
            this.panel_left.Controls.Add(this.txt_BUnit);
            this.panel_left.Controls.Add(this.label5);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_left.Location = new System.Drawing.Point(0, 102);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(221, 359);
            this.panel_left.TabIndex = 38;
            // 
            // txt_TimeLimit
            // 
            this.controlAutoFocus1.SetAllowNext(this.txt_TimeLimit, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txt_TimeLimit, true);
            this.txt_TimeLimit.BackColor = System.Drawing.Color.White;
            this.txt_TimeLimit.Enabled = false;
            this.inputControlEnter1.SetFocus(this.txt_TimeLimit, true);
            this.txt_TimeLimit.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_TimeLimit.Location = new System.Drawing.Point(74, 140);
            this.txt_TimeLimit.Name = "txt_TimeLimit";
            this.txt_TimeLimit.ReadOnly = true;
            this.txt_TimeLimit.Size = new System.Drawing.Size(130, 26);
            this.txt_TimeLimit.TabIndex = 10;
            this.txt_TimeLimit.TabStop = false;
            // 
            // txt_OutNumber
            // 
            this.controlAutoFocus1.SetAllowNext(this.txt_OutNumber, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txt_OutNumber, true);
            this.txt_OutNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_OutNumber.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.txt_OutNumber, true);
            this.txt_OutNumber.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_OutNumber.Location = new System.Drawing.Point(74, 234);
            this.txt_OutNumber.Name = "txt_OutNumber";
            this.txt_OutNumber.Size = new System.Drawing.Size(130, 26);
            this.txt_OutNumber.TabIndex = 14;
            this.txt_OutNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_OutNumber_KeyDown);
            // 
            // label17
            // 
            this.controlAutoFocus1.SetAllowNext(this.label17, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label17, false);
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label17, false);
            this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(14, 240);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 14);
            this.label17.TabIndex = 38;
            this.label17.Text = "出库量:";
            // 
            // txt_StoreNumber
            // 
            this.controlAutoFocus1.SetAllowNext(this.txt_StoreNumber, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txt_StoreNumber, true);
            this.txt_StoreNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_StoreNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txt_StoreNumber.Enabled = false;
            this.inputControlEnter1.SetFocus(this.txt_StoreNumber, true);
            this.txt_StoreNumber.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_StoreNumber.Location = new System.Drawing.Point(74, 203);
            this.txt_StoreNumber.Name = "txt_StoreNumber";
            this.txt_StoreNumber.ReadOnly = true;
            this.txt_StoreNumber.Size = new System.Drawing.Size(130, 26);
            this.txt_StoreNumber.TabIndex = 13;
            this.txt_StoreNumber.TabStop = false;
            // 
            // label15
            // 
            this.controlAutoFocus1.SetAllowNext(this.label15, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label15, false);
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label15, false);
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(14, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = "库存量:";
            // 
            // txt_price
            // 
            this.controlAutoFocus1.SetAllowNext(this.txt_price, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txt_price, true);
            this.txt_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_price.BackColor = System.Drawing.SystemColors.Window;
            this.txt_price.Enabled = false;
            this.inputControlEnter1.SetFocus(this.txt_price, true);
            this.txt_price.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_price.Location = new System.Drawing.Point(74, 172);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(130, 26);
            this.txt_price.TabIndex = 12;
            this.txt_price.TabStop = false;
            this.txt_price.Tag = "";
            // 
            // label16
            // 
            this.controlAutoFocus1.SetAllowNext(this.label16, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label16, false);
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label16, false);
            this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(14, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 14);
            this.label16.TabIndex = 33;
            this.label16.Text = "零售价:";
            // 
            // label13
            // 
            this.controlAutoFocus1.SetAllowNext(this.label13, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label13, false);
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label13, false);
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(14, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 14);
            this.label13.TabIndex = 27;
            this.label13.Text = "效  期:";
            // 
            // txt_contents
            // 
            this.controlAutoFocus1.SetAllowNext(this.txt_contents, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txt_contents, true);
            this.txt_contents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_contents.BackColor = System.Drawing.SystemColors.Window;
            this.txt_contents.Enabled = false;
            this.inputControlEnter1.SetFocus(this.txt_contents, true);
            this.txt_contents.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_contents.Location = new System.Drawing.Point(74, 77);
            this.txt_contents.Name = "txt_contents";
            this.txt_contents.ReadOnly = true;
            this.txt_contents.Size = new System.Drawing.Size(130, 26);
            this.txt_contents.TabIndex = 6;
            this.txt_contents.TabStop = false;
            // 
            // label11
            // 
            this.controlAutoFocus1.SetAllowNext(this.label11, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label11, false);
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label11, false);
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(14, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "规  格:";
            // 
            // txt_name
            // 
            this.controlAutoFocus1.SetAllowNext(this.txt_name, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txt_name, true);
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.Enabled = false;
            this.inputControlEnter1.SetFocus(this.txt_name, true);
            this.txt_name.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_name.Location = new System.Drawing.Point(74, 46);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(130, 26);
            this.txt_name.TabIndex = 5;
            this.txt_name.TabStop = false;
            // 
            // label10
            // 
            this.controlAutoFocus1.SetAllowNext(this.label10, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label10, false);
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label10, false);
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(14, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "名  称:";
            // 
            // txt_code
            // 
            this.controlAutoFocus1.SetAllowNext(this.txt_code, false);
            this.controlAutoFocus1.SetAllowPrevious(this.txt_code, false);
            this.txt_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_code.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.txt_code, true);
            this.txt_code.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_code.Location = new System.Drawing.Point(74, 15);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(130, 26);
            this.txt_code.TabIndex = 4;
            this.txt_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_code_KeyDown);
            // 
            // label9
            // 
            this.controlAutoFocus1.SetAllowNext(this.label9, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label9, false);
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label9, false);
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 21;
            this.label9.Text = "编  码:";
            // 
            // txt_BUnit
            // 
            this.controlAutoFocus1.SetAllowNext(this.txt_BUnit, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txt_BUnit, true);
            this.txt_BUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_BUnit.BackColor = System.Drawing.SystemColors.Window;
            this.txt_BUnit.Enabled = false;
            this.inputControlEnter1.SetFocus(this.txt_BUnit, true);
            this.txt_BUnit.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_BUnit.Location = new System.Drawing.Point(74, 108);
            this.txt_BUnit.Name = "txt_BUnit";
            this.txt_BUnit.ReadOnly = true;
            this.txt_BUnit.Size = new System.Drawing.Size(130, 26);
            this.txt_BUnit.TabIndex = 7;
            this.txt_BUnit.TabStop = false;
            // 
            // label5
            // 
            this.controlAutoFocus1.SetAllowNext(this.label5, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label5, false);
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label5, false);
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "单  位:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1189, 19);
            this.panel3.TabIndex = 37;
            // 
            // label2
            // 
            this.controlAutoFocus1.SetAllowNext(this.label2, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label2, false);
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputControlEnter1.SetFocus(this.label2, false);
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "明细汇总:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.lbl_price);
            this.panel2.Controls.Add(this.lbl_SelectPrice);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Controls.Add(this.btn_OK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1189, 33);
            this.panel2.TabIndex = 36;
            // 
            // btnNext
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnNext, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btnNext, false);
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btnNext, false);
            this.btnNext.Location = new System.Drawing.Point(1002, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 25);
            this.btnNext.TabIndex = 54;
            this.btnNext.Text = "下一个(&N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrint
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnPrint, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btnPrint, false);
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btnPrint, false);
            this.btnPrint.Location = new System.Drawing.Point(912, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 25);
            this.btnPrint.TabIndex = 53;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbl_price
            // 
            this.controlAutoFocus1.SetAllowNext(this.lbl_price, false);
            this.controlAutoFocus1.SetAllowPrevious(this.lbl_price, false);
            this.lbl_price.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.lbl_price, false);
            this.lbl_price.ForeColor = System.Drawing.Color.Blue;
            this.lbl_price.Location = new System.Drawing.Point(83, 9);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(56, 14);
            this.lbl_price.TabIndex = 32;
            this.lbl_price.Text = "0.00 元";
            this.lbl_price.Visible = false;
            // 
            // lbl_SelectPrice
            // 
            this.controlAutoFocus1.SetAllowNext(this.lbl_SelectPrice, false);
            this.controlAutoFocus1.SetAllowPrevious(this.lbl_SelectPrice, false);
            this.lbl_SelectPrice.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.lbl_SelectPrice, false);
            this.lbl_SelectPrice.ForeColor = System.Drawing.Color.Blue;
            this.lbl_SelectPrice.Location = new System.Drawing.Point(9, 9);
            this.lbl_SelectPrice.Name = "lbl_SelectPrice";
            this.lbl_SelectPrice.Size = new System.Drawing.Size(77, 14);
            this.lbl_SelectPrice.TabIndex = 31;
            this.lbl_SelectPrice.Text = "零售金额：";
            this.lbl_SelectPrice.Visible = false;
            // 
            // btn_Close
            // 
            this.controlAutoFocus1.SetAllowNext(this.btn_Close, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btn_Close, false);
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btn_Close, false);
            this.btn_Close.Location = new System.Drawing.Point(1092, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(85, 25);
            this.btn_Close.TabIndex = 19;
            this.btn_Close.Text = "关闭(&C)";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_OK
            // 
            this.controlAutoFocus1.SetAllowNext(this.btn_OK, false);
            this.controlAutoFocus1.SetAllowPrevious(this.btn_OK, false);
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btn_OK, false);
            this.btn_OK.Location = new System.Drawing.Point(822, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(85, 25);
            this.btn_OK.TabIndex = 17;
            this.btn_OK.Text = "确定(&S)";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.lbl_title2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 21);
            this.panel1.TabIndex = 35;
            // 
            // lbl_title2
            // 
            this.controlAutoFocus1.SetAllowNext(this.lbl_title2, false);
            this.controlAutoFocus1.SetAllowPrevious(this.lbl_title2, false);
            this.lbl_title2.AutoSize = true;
            this.lbl_title2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title2.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputControlEnter1.SetFocus(this.lbl_title2, false);
            this.lbl_title2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title2.ForeColor = System.Drawing.Color.White;
            this.lbl_title2.Location = new System.Drawing.Point(6, 2);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(80, 16);
            this.lbl_title2.TabIndex = 3;
            this.lbl_title2.Text = "明细清单:";
            this.lbl_title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panMethod
            // 
            this.panMethod.Controls.Add(this.txtCustomer);
            this.panMethod.Controls.Add(this.label1);
            this.panMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMethod.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panMethod.Location = new System.Drawing.Point(0, 36);
            this.panMethod.Name = "panMethod";
            this.panMethod.Size = new System.Drawing.Size(1189, 45);
            this.panMethod.TabIndex = 0;
            // 
            // txtCustomer
            // 
            this.controlAutoFocus1.SetAllowNext(this.txtCustomer, true);
            this.controlAutoFocus1.SetAllowPrevious(this.txtCustomer, true);
            this.txtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.txtCustomer, true);
            this.txtCustomer.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCustomer.Location = new System.Drawing.Point(83, 9);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(130, 26);
            this.txtCustomer.TabIndex = 22;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // label1
            // 
            this.controlAutoFocus1.SetAllowNext(this.label1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label1, false);
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label1, false);
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "顾客姓名:";
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
            this.pnTop.Size = new System.Drawing.Size(1189, 36);
            this.pnTop.TabIndex = 33;
            // 
            // ledClock
            // 
            this.controlAutoFocus1.SetAllowNext(this.ledClock, false);
            this.controlAutoFocus1.SetAllowPrevious(this.ledClock, false);
            this.ledClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledClock.ClockColor = System.Drawing.Color.Green;
            this.ledClock.DateTime = new System.DateTime(2013, 10, 10, 10, 11, 2, 0);
            this.inputControlEnter1.SetFocus(this.ledClock, false);
            this.ledClock.IsDrawShadow = true;
            this.ledClock.IsTimerEnable = true;
            this.ledClock.LEDClockStyle = EAS.Windows.UI.Controls.LEDClockStyle.DateAndTime;
            this.ledClock.Location = new System.Drawing.Point(1022, 3);
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
            this.label38.Location = new System.Drawing.Point(952, 8);
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
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "药品销售";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // DrugSale
            // 
            this.controlAutoFocus1.SetAllowNext(this, false);
            this.controlAutoFocus1.SetAllowPrevious(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.listView_Store);
            this.Controls.Add(this.listView_DrugOut);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panMethod);
            this.Controls.Add(this.pnTop);
            this.inputControlEnter1.SetFocus(this, false);
            this.Name = "DrugSale";
            this.Size = new System.Drawing.Size(1189, 513);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panMethod.ResumeLayout(false);
            this.panMethod.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_DrugOut;
        private System.Windows.Forms.ColumnHeader HID;
        private System.Windows.Forms.ColumnHeader HName;
        private System.Windows.Forms.ColumnHeader HContor;
        private System.Windows.Forms.ColumnHeader HInprice;
        private System.Windows.Forms.ColumnHeader HNumber;
        private System.Windows.Forms.ColumnHeader HOutNumber;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.TextBox txt_TimeLimit;
        private System.Windows.Forms.TextBox txt_OutNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_StoreNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_contents;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_BUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title2;
        private System.Windows.Forms.Panel pnTop;
        private EAS.Windows.UI.Controls.LEDClock ledClock;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ColumnHeader HBunit;
        private System.Windows.Forms.ListView listView_Store;
        private System.Windows.Forms.ColumnHeader DCode;
        private System.Windows.Forms.ColumnHeader DName;
        private System.Windows.Forms.ColumnHeader DCurron;
        private System.Windows.Forms.ColumnHeader DBuint;
        private System.Windows.Forms.ColumnHeader Ddatetime;
        private System.Windows.Forms.ColumnHeader DInprices;
        private System.Windows.Forms.ColumnHeader DKNumber;
        private System.Windows.Forms.ColumnHeader DbachNo;
        private System.Windows.Forms.ColumnHeader DFactory;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_SelectPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Panel panMethod;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ColumnHeader HCode;
        private System.Windows.Forms.ColumnHeader HTimeLimit;
        private System.Windows.Forms.Button btnNext;
        private EAS.Windows.UI.Controls.ControlAutoFocus controlAutoFocus1;
        private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;
    }
}
