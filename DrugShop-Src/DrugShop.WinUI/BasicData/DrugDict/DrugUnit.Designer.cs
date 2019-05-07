namespace DrugShop.WinUI
{
    partial class DrugUnit
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBUnit = new System.Windows.Forms.TextBox();
            this.tbLUnit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumber.Location = new System.Drawing.Point(0, 3);
            this.tbNumber.MaxLength = 5;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(56, 16);
            this.tbNumber.TabIndex = 0;
            this.tbNumber.Text = "1000";
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumber_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBUnit
            // 
            this.tbBUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBUnit.Location = new System.Drawing.Point(131, 3);
            this.tbBUnit.MaxLength = 5;
            this.tbBUnit.Name = "tbBUnit";
            this.tbBUnit.Size = new System.Drawing.Size(49, 16);
            this.tbBUnit.TabIndex = 4;
            this.tbBUnit.Text = "瓶子";
            this.tbBUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBUnit_KeyDown);
            // 
            // tbLUnit
            // 
            this.tbLUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLUnit.Location = new System.Drawing.Point(69, 3);
            this.tbLUnit.MaxLength = 4;
            this.tbLUnit.Name = "tbLUnit";
            this.tbLUnit.Size = new System.Drawing.Size(49, 16);
            this.tbLUnit.TabIndex = 2;
            this.tbLUnit.Text = "瓶子";
            this.tbLUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLUnit_KeyDown);
            // 
            // DrugUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tbLUnit);
            this.Controls.Add(this.tbBUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DrugUnit";
            this.Size = new System.Drawing.Size(177, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBUnit;
        private System.Windows.Forms.TextBox tbLUnit;

    }
}
