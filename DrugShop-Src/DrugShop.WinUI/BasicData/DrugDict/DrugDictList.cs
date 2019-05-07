using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using EAS.Modularization;
using EAS.Services;
using DrugShop.Entities;
using EAS.Data.ORM;
using DrugShop.BLL;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 药品字典列表。
    /// </summary>
    [Module("16D50FC2-41D2-4612-AE69-51A734A8CEEA", "药品字典", "管理系统中的药品字典")]
    public partial class DrugDictList : UserControl
    {
        private IList<Dict> dictList;

        [ModuleStart()]
        public void StartEx()
        {
            this.Initialize();
        }

        public DrugDictList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化。
        /// </summary>
        public void Initialize()
        {
            this.dictList = new List<Dict>();
           this.LoadBaseData();
        }

        internal void LoadBaseData()
        {
            //药品类型
            DataBindHelper.BindDrugTypeCmbBox2(this.cbxType);
            this.cbxType.SelectedIndexChanged += new EventHandler(cbxType_SelectedIndexChanged);
        }

        internal void LoadDataToListView(IList<Dict> List)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                this.dmdictBindingSource.DataSource = List; 
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        internal void LoadDrugDict()
        {
            int type = this.cbxType.SelectedIndex <= 0 ? 0 : ((DrugShop.Entities.DrugType)((List<DrugType>)this.cbxType.Tag)[this.cbxType.SelectedIndex]).Code;

            
            this.dictList=ServiceContainer.GetService<IDrugDictService>().GetDrugDictList(type,this.tbSeach.Text);

            this.LoadDataToListView(this.dictList);
        }

        internal void DrugNew()
        {
            DrugDictEditor Editor = new DrugDictEditor();
            Editor.Initialize();

            if (Editor.ShowDialog() == DialogResult.OK)
            {
                this.LoadDrugDict();
            }
        }

        internal void DrugProp()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            DrugShop.Entities.Dict dict = row.DataBoundItem as DrugShop.Entities.Dict;

            DrugShop.Entities.Dict dict1 = CommonHelper.GetDataGridViewSelectRow<Dict>(this.dataGridView1);

            DrugDictEditor Editor = new DrugDictEditor();
            Editor.Initialize();
            Editor.DrugDict = dict;
            if(Editor.ShowDialog() == DialogResult.OK)
            {
                dict = Editor.DrugDict;
                CommonHelper.RefreshDataGridView<Dict>(dict, row, dataGridView1);
            }
        }

        internal void DrugDel()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }

            if (MessageBox.Show(this, "是否确认删除所选择的药品字典？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            DrugShop.Entities.Dict dict = row.DataBoundItem as DrugShop.Entities.Dict;

            try
            {
                //删除操作
                dict.Delete();

                //删除列表中的该行记录
                this.dataGridView1.Rows.Remove(row);
            }
            catch(System.Exception exc)
            {
                MessageBox.Show(this, "在删除药品字典时出错，错误：" + exc.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            this.cbxType_SelectedIndexChanged(sender, e);
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            this.DrugNew();
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            this.DrugDel();
        }

        private void tsbProp_Click(object sender, EventArgs e)
        {
            this.DrugProp();
        }              

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxType.SelectedItem != null)
            {
                this.LoadDrugDict();
            }
        }

        private void tbSeach_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }

            if(this.tbSeach.Text.Length == 0)
            {
                return;
            }

            this.LoadDrugDict();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            //验证按钮级别权限。
            if (!EAS.Application.Instance.Demand(new Guid("6a185217-34de-4fe7-9ed5-c2cc49ba432c"))) 
                return;

            if (this.dictList != null)
            {
                EAS.GReport.Controls.PrintViewDialog ViewDialog = new EAS.GReport.Controls.PrintViewDialog();
                ViewDialog.ReportID = new Guid("F29C4C91-0791-4116-BE26-3A2A88F30A2A");
                ViewDialog.DataObject = this.dictList;
                ViewDialog.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                ViewDialog.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                ViewDialog.ShowDialog();
            }
        }

        private void itemNew_Click(object sender, EventArgs e)
        {
            this.DrugNew();
        }

        private void itemDel_Click(object sender, EventArgs e)
        {
            this.DrugDel();
        }

        private void itemProp_Click(object sender, EventArgs e)
        {
            this.DrugProp();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }

            this.CanEnableMenu(true);
        }

        private void CanEnableMenu(bool flag)
        {
            this.tsbDel.Enabled = flag;
            this.tsbProp.Enabled = flag;
            this.itemDel.Enabled = flag;
            this.itemProp.Enabled = flag;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DrugProp();
        }       
    }
}
