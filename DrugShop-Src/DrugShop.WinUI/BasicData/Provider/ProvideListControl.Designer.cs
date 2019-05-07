namespace DrugShop.WinUI
{
    partial class ProvideList
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvideList));
            this.cmItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiItemProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmiItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmiItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.cmiItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnItemDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.btnItemAdd = new System.Windows.Forms.ToolStripButton();
            this.btnItemProperty = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inputcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmItem.SuspendLayout();
            this.tsToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmItem
            // 
            this.cmItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiItemAdd,
            this.cmiItemProperty,
            this.toolStripSeparator3,
            this.cmiItemDelete,
            this.toolStripSeparator4,
            this.cmiItemRefresh,
            this.toolStripSeparator7,
            this.cmiItemSearch});
            this.cmItem.Name = "cmItem";
            this.cmItem.Size = new System.Drawing.Size(118, 132);
            // 
            // cmiItemAdd
            // 
            this.cmiItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmiItemAdd.Image")));
            this.cmiItemAdd.Name = "cmiItemAdd";
            this.cmiItemAdd.Size = new System.Drawing.Size(117, 22);
            this.cmiItemAdd.Text = "添加(&A)";
            this.cmiItemAdd.Click += new System.EventHandler(this.cmiItemAdd_Click);
            // 
            // cmiItemProperty
            // 
            this.cmiItemProperty.Image = ((System.Drawing.Image)(resources.GetObject("cmiItemProperty.Image")));
            this.cmiItemProperty.Name = "cmiItemProperty";
            this.cmiItemProperty.Size = new System.Drawing.Size(117, 22);
            this.cmiItemProperty.Text = "属性(&P)";
            this.cmiItemProperty.Click += new System.EventHandler(this.cmiItemProperty_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(114, 6);
            // 
            // cmiItemDelete
            // 
            this.cmiItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmiItemDelete.Image")));
            this.cmiItemDelete.Name = "cmiItemDelete";
            this.cmiItemDelete.Size = new System.Drawing.Size(117, 22);
            this.cmiItemDelete.Text = "删除(&D)";
            this.cmiItemDelete.Click += new System.EventHandler(this.cmiItemDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(114, 6);
            // 
            // cmiItemRefresh
            // 
            this.cmiItemRefresh.Image = ((System.Drawing.Image)(resources.GetObject("cmiItemRefresh.Image")));
            this.cmiItemRefresh.Name = "cmiItemRefresh";
            this.cmiItemRefresh.Size = new System.Drawing.Size(117, 22);
            this.cmiItemRefresh.Text = "刷新(&R)";
            this.cmiItemRefresh.Click += new System.EventHandler(this.cmiItemRefresh_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(114, 6);
            // 
            // cmiItemSearch
            // 
            this.cmiItemSearch.Image = ((System.Drawing.Image)(resources.GetObject("cmiItemSearch.Image")));
            this.cmiItemSearch.Name = "cmiItemSearch";
            this.cmiItemSearch.Size = new System.Drawing.Size(117, 22);
            this.cmiItemSearch.Text = "检索(&S)";
            this.cmiItemSearch.Click += new System.EventHandler(this.cmiItemSearch_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "登记时间";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "联系人";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 20;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "电话";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "联系人电话";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "属性";
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnItemDelete.Image")));
            this.btnItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(57, 24);
            this.btnItemDelete.Text = "删除";
            this.btnItemDelete.ToolTipText = "禁用指定的供应商记录。";
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsToolbar
            // 
            this.tsToolbar.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnItemAdd,
            this.btnItemProperty,
            this.btnItemDelete,
            this.toolStripSeparator1,
            this.btnSearch,
            this.toolStripSeparator6,
            this.btnPrint});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsToolbar.Size = new System.Drawing.Size(800, 27);
            this.tsToolbar.TabIndex = 5;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.Image")));
            this.btnItemAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(57, 24);
            this.btnItemAdd.Text = "添加";
            this.btnItemAdd.ToolTipText = "添加一个新的供应商记录。";
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnItemProperty
            // 
            this.btnItemProperty.Image = ((System.Drawing.Image)(resources.GetObject("btnItemProperty.Image")));
            this.btnItemProperty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemProperty.Name = "btnItemProperty";
            this.btnItemProperty.Size = new System.Drawing.Size(57, 24);
            this.btnItemProperty.Text = "属性";
            this.btnItemProperty.ToolTipText = "查看或者修改选定的供应商记录属性。";
            this.btnItemProperty.Click += new System.EventHandler(this.btnItemProperty_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 24);
            this.btnSearch.Text = "检索";
            this.btnSearch.ToolTipText = "指定条件并检索相应的供应商记录。";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(57, 24);
            this.btnPrint.Text = "打印";
            this.btnPrint.ToolTipText = "打印当前列表中的供应商记录。";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Arrow Right.ico");
            this.imgList.Images.SetKeyName(1, "Ok.ico");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.Inputcode});
            this.dataGridView1.DataSource = this.providerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(800, 373);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "供应商名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "电话";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "传值";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "联系人";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "联系人电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "移动电话";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Inputcode
            // 
            this.Inputcode.DataPropertyName = "Inputcode";
            this.Inputcode.HeaderText = "输入码";
            this.Inputcode.Name = "Inputcode";
            this.Inputcode.ReadOnly = true;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataSource = typeof(DrugShop.Entities.Provider);
            // 
            // ProvideListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tsToolbar);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ProvideListControl";
            this.Size = new System.Drawing.Size(800, 400);
            this.cmItem.ResumeLayout(false);
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmItem;
        private System.Windows.Forms.ToolStripMenuItem cmiItemAdd;
        private System.Windows.Forms.ToolStripMenuItem cmiItemProperty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmiItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmiItemRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem cmiItemSearch;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripButton btnItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.ToolStripButton btnItemAdd;
        private System.Windows.Forms.ToolStripButton btnItemProperty;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inputcode;

    }
}
