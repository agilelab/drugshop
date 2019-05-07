using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using EAS.Data.ORM;
using EAS.Data.Access;

using Microsoft.VisualBasic;

using EAS.Services;
using EAS.Modularization;
using DrugShop.Entities;using EAS.Data.ORM;
using DrugShop.BLL;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 药品盘存。
    /// </summary>
    [Module("94CA27D2-EA13-407E-BE9C-1B4E15A98C50", "药品盘存", "药品盘存管理")]
    public partial class DrugStoreCount : UserControl
    {
        private IList<Inventory> storeCountList = null;
        private IList<Inventory> updateStoreCountList = null;
        private IList<Inventory> printStoreCountList = null;

        public DrugStoreCount()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEX()
        {
            this.Initialize();
        }

        #region 初始化

        internal void Initialize()
        {
            this.BindStoreCountDate();

            storeCountList = new List<Inventory>();
            updateStoreCountList = new List<Inventory>();
            printStoreCountList = new List<Inventory>();
        }

        /// <summary>
        /// 加载盘存过的日期信息
        /// </summary>
        internal void BindStoreCountDate()
        {
            IList<object> dateList = ServiceContainer.GetService<IDrugStoreCountService>().GetDrugStoreCountDateList();

            this.cbxDate.Items.Clear();

            foreach (object task in dateList)
            {
                DateTime time = DateTime.Parse(task.ToString());
                this.cbxDate.Items.Add(time.ToString("yyyy-MM-dd HH:mm:ss"));
            }

            this.cbxDate.Text = string.Empty;
            this.cbxDate.SelectedIndexChanged += new EventHandler(cbxDate_SelectedIndexChanged);
        }

        #endregion

        /// <summary>
        /// 搜索盘点结果
        /// </summary>
        internal void SeachStoreCount()
        {
            if (this.cbxDate.Text == String.Empty)
            {
                MessageBox.Show("请选择一个抄库日期！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            storeCountList=  ServiceContainer.GetService<IDrugStoreCountService>().GetDrugStoreCountList(this.tbSeach.Text, Convert.ToDateTime(this.cbxDate.Text));

            this.dmrcountBindingSource1.DataSource = null;
            this.dmrcountBindingSource1.DataSource = storeCountList;

        }

        #region 保存

        private void UpdateStoreCountInfo(int index)
        {
            DataGridViewRow row = dataGridView1.Rows[index];

            DrugShop.Entities.Inventory count = row.DataBoundItem as DrugShop.Entities.Inventory;

            if (count == null)
                return;

            if (count.State == 1)
            {
                MessageBox.Show("盘点信息已进行过库存调整，无法编辑！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //弹出输入实际库存的对话框
            StoreCountNumberInput input = new StoreCountNumberInput();
            input.StoreNumber = count.Number;

            if (input.ShowDialog(this.ParentForm) != DialogResult.OK)
                return;

            //根据输入的实际值初始化相关的信息

            DrugShop.Entities.Inventory item = new Entities.Inventory();

            ColumnCollection cols = count.GetColumns();
            foreach (Property prop in cols)
            {
                if (item.ContainsProperty(prop.Name))
                    item[prop.Name] = count[prop];
            }

            item.RealNumber = input.Number;

            this.updateStoreCountList.Add(item);

            //重新绑定列表中的信息
            this.dmrcountBindingSource.DataSource = null;
            this.dmrcountBindingSource.DataSource = this.updateStoreCountList;
        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.Rows.Count <= 0)
            {
                MessageBox.Show("请选择最新抄库日期生成帐存信息！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            //执行事务
            try
            {
                ServiceContainer.GetService<IDrugStoreCountService>().DrugStoreCountSave(this.updateStoreCountList);
            }
            catch (System.Exception exc)
            {
                MessageBox.Show("在保存药品盘点时发生错误，错误信息：" + exc.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        #endregion

        #region 打印

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.SetReportName("药品盘点统计表(药店)");
            this.PrintPreview(this.printStoreCountList);
        }

        #endregion

        #region 界面相关

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            this.UpdateStoreCountInfo(e.RowIndex);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index < 0)
                return;

            this.UpdateStoreCountInfo(index);
        }

        private void cbxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Information.IsDate(this.cbxDate.Text))
            {
                this.SeachStoreCount();
            }
        }

        private void tbSeach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                  this.SeachStoreCount();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.SeachStoreCount();
        }

        #endregion

        private void btnCount_Click(object sender, EventArgs e)
        {
            //盘存
            this.Cursor = Cursors.WaitCursor;

            try
            {
                ServiceContainer.GetService<IDrugStoreCountService>().DrugStoreCount();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show("在进行库存盘存的过程中出现如下错误：" + ex.InnerException.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
