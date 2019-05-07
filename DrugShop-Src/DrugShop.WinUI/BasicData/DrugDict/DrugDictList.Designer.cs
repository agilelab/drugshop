namespace DrugShop.WinUI
{
    partial class DrugDictList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugDictList));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGuid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAssembly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttributes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDeveloper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmDrug = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemProp = new System.Windows.Forms.ToolStripMenuItem();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbProp = new System.Windows.Forms.ToolStripButton();
            this.cbxType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tbSeach = new System.Windows.Forms.ToolStripTextBox();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChinseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isotcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmdictBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmDrug.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmdictBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chDescription
            // 
            this.chDescription.Text = "描述";
            this.chDescription.Width = 500;
            // 
            // chGuid
            // 
            this.chGuid.Text = "全局唯一标识符";
            this.chGuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chGuid.Width = 180;
            // 
            // chType
            // 
            this.chType.Text = "类名称";
            this.chType.Width = 180;
            // 
            // chAssembly
            // 
            this.chAssembly.Text = "程序集";
            this.chAssembly.Width = 150;
            // 
            // chVerson
            // 
            this.chVerson.Text = "版本";
            this.chVerson.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "名称";
            this.chName.Width = 180;
            // 
            // chAttributes
            // 
            this.chAttributes.Text = "类型";
            this.chAttributes.Width = 80;
            // 
            // chDeveloper
            // 
            this.chDeveloper.Text = "开发者";
            this.chDeveloper.Width = 150;
            // 
            // cmDrug
            // 
            this.cmDrug.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNew,
            this.toolStripMenuItem1,
            this.itemDel,
            this.toolStripMenuItem2,
            this.itemProp});
            this.cmDrug.Name = "cmElement";
            this.cmDrug.Size = new System.Drawing.Size(119, 82);
            // 
            // itemNew
            // 
            this.itemNew.Image = ((System.Drawing.Image)(resources.GetObject("itemNew.Image")));
            this.itemNew.Name = "itemNew";
            this.itemNew.Size = new System.Drawing.Size(118, 22);
            this.itemNew.Text = "添加(&N)";
            this.itemNew.Click += new System.EventHandler(this.itemNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // itemDel
            // 
            this.itemDel.Enabled = false;
            this.itemDel.Image = ((System.Drawing.Image)(resources.GetObject("itemDel.Image")));
            this.itemDel.Name = "itemDel";
            this.itemDel.Size = new System.Drawing.Size(118, 22);
            this.itemDel.Text = "删除(&D)";
            this.itemDel.Click += new System.EventHandler(this.itemDel_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(115, 6);
            // 
            // itemProp
            // 
            this.itemProp.Enabled = false;
            this.itemProp.Image = ((System.Drawing.Image)(resources.GetObject("itemProp.Image")));
            this.itemProp.Name = "itemProp";
            this.itemProp.Size = new System.Drawing.Size(118, 22);
            this.itemProp.Text = "属性(&P)";
            this.itemProp.Click += new System.EventHandler(this.itemProp_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Item16.ico");
            this.imgList.Images.SetKeyName(1, "Yes16.ico");
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "类型(&T)：";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDel
            // 
            this.tsbDel.Enabled = false;
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(52, 22);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(52, 22);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefresh,
            this.toolStripSeparator1,
            this.tsbNew,
            this.tsbDel,
            this.tsbProp,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.cbxType,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.tbSeach,
            this.tsbPrint,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1001, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(52, 22);
            this.tsbNew.Text = "添加";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbProp
            // 
            this.tsbProp.Enabled = false;
            this.tsbProp.Image = ((System.Drawing.Image)(resources.GetObject("tsbProp.Image")));
            this.tsbProp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProp.Name = "tsbProp";
            this.tsbProp.Size = new System.Drawing.Size(52, 22);
            this.tsbProp.Text = "维护";
            this.tsbProp.Click += new System.EventHandler(this.tsbProp_Click);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(87, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel3.Text = "检索：";
            // 
            // tbSeach
            // 
            this.tbSeach.Name = "tbSeach";
            this.tbSeach.Size = new System.Drawing.Size(104, 25);
            this.tbSeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSeach_KeyDown);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(52, 22);
            this.tsbPrint.Text = "打印";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.ChinseNameDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.UpLimitDataGridViewTextBoxColumn,
            this.DownLimitDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.isotcDataGridViewTextBoxColumn,
            this.effectDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.cmDrug;
            this.dataGridView1.DataSource = this.dmdictBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 564);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "编码";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ChinseNameDataGridViewTextBoxColumn
            // 
            this.ChinseNameDataGridViewTextBoxColumn.DataPropertyName = "ChinseName";
            this.ChinseNameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.ChinseNameDataGridViewTextBoxColumn.Name = "ChinseNameDataGridViewTextBoxColumn";
            this.ChinseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "Spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "规格";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            this.specDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "单位";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UpLimitDataGridViewTextBoxColumn
            // 
            this.UpLimitDataGridViewTextBoxColumn.DataPropertyName = "UpLimit";
            this.UpLimitDataGridViewTextBoxColumn.HeaderText = "库存上限";
            this.UpLimitDataGridViewTextBoxColumn.Name = "UpLimitDataGridViewTextBoxColumn";
            this.UpLimitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DownLimitDataGridViewTextBoxColumn
            // 
            this.DownLimitDataGridViewTextBoxColumn.DataPropertyName = "DownLimit";
            this.DownLimitDataGridViewTextBoxColumn.HeaderText = "库存下限";
            this.DownLimitDataGridViewTextBoxColumn.Name = "DownLimitDataGridViewTextBoxColumn";
            this.DownLimitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "药品类型";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isotcDataGridViewTextBoxColumn
            // 
            this.isotcDataGridViewTextBoxColumn.DataPropertyName = "Isotc";
            this.isotcDataGridViewTextBoxColumn.HeaderText = "是否处方";
            this.isotcDataGridViewTextBoxColumn.Name = "isotcDataGridViewTextBoxColumn";
            this.isotcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // effectDataGridViewTextBoxColumn
            // 
            this.effectDataGridViewTextBoxColumn.DataPropertyName = "Effect";
            this.effectDataGridViewTextBoxColumn.HeaderText = "药品作用";
            this.effectDataGridViewTextBoxColumn.Name = "effectDataGridViewTextBoxColumn";
            this.effectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dmdictBindingSource
            // 
            this.dmdictBindingSource.DataSource = typeof(DrugShop.Entities.Dict);
            // 
            // DrugDictList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DrugDictList";
            this.Size = new System.Drawing.Size(1001, 589);
            this.cmDrug.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmdictBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chGuid;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chAssembly;
        private System.Windows.Forms.ColumnHeader chVerson;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAttributes;
        private System.Windows.Forms.ColumnHeader chDeveloper;
        private System.Windows.Forms.ContextMenuStrip cmDrug;
        private System.Windows.Forms.ToolStripMenuItem itemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemDel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem itemProp;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripComboBox cbxType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tbSeach;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbProp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChinseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isotcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dmdictBindingSource;
    }
}
