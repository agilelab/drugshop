using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EAS.Modularization;
using EAS.Services;
using EAS.Data.ORM;
using DrugShop.Entities;
using DrugShop.BLL;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 药品入库
    /// </summary>
    [Module("97980BD3-B4EB-4CCD-A31E-B21D22AFB152", "药品入库", "提供药品入库功能")]
    public partial class DrugIn : UserControl
    {
        Dict dict;
        private IList<PIn> inList ;
        private IList<Store> storeList;
        public DrugIn()
        {
            InitializeComponent();
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Enter };
            //this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Escape };
        }

        [ModuleStart]
        public void StartEx()
        {
            inList = new List<PIn>();
            storeList = new List<Store>();
            IDateTimeService DateTimeService = ServiceContainer.GetService<IDateTimeService>();
            this.dtpTimeLimit.Value = DateTimeService.GetCurrentTime().AddDays(90);
        }

        #region 检索药品

       //选中一项后绑定详细内容 
        private void FillDrugdict(Dict dict)
        {
            this.dict = dict;
            txtSearch.Text = dict.Code;
            txtName.Text = dict.ChinseName;
            txtContens.Text = dict.Spec;
            txtInPrice.Text = dict.Price.ToString("0.00##");
            this.txtBatch.Focus();
            this.txtBatch.Select();
        }

        #endregion

        #region 填写其他信息
        //1.批号
        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpTimeLimit.Focus();
            }
        }
        //2.效期
        private void dtpTimeLimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumber.Focus();
            }
        }
        //3.数量
        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!ValidateData())
                {
                    return;
                }
                else
                {
                    //填充数据
                    AddLvwDrugInList();
                    ClearText();
                }
            }
            if (e.KeyData == Keys.Escape)
            {
                this.txtSearch.Focus();
                this.txtSearch.Select();
            }
        }
        //4.验证
        private bool ValidateData()
        {
            if (this.dict == null)
            {
                MessageBox.Show("请选择一个入库药品！");
                this.txtSearch.Focus();
                this.txtSearch.Select();
                return false
;
            }
            IDateTimeService DateTimeService = ServiceContainer.GetService<IDateTimeService>();
            DateTime dt = Convert.ToDateTime(this.dtpTimeLimit.Value);
            if (dt.Date <= DateTimeService.GetCurrentTime().Date)
            {
                MessageBox.Show("效期不能小于当前日期！");
                this.dtpTimeLimit.Focus();
                this.dtpTimeLimit.Select();
                return false;
            }
            if (txtNumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("入库数量不能为空！");
                txtNumber.Focus();
                txtNumber.SelectAll();
                return false;
            }
            int i = 0;
            bool result = int.TryParse(this.txtNumber.Text,out i);
            if (!result)
            {
                MessageBox.Show("请输入整数！");
                txtNumber.Focus();
                txtNumber.SelectAll();
                return false;
            }
            if (result && (i <= 0))
            {
                MessageBox.Show("入库数量必须要大于0！");
                txtNumber.Focus();
                txtNumber.SelectAll();
                return false;
            }
            return true;
        }
        #endregion

        #region 填充入库记录
        private void AddLvwDrugInList()
        {
            DrugShop.Entities.PIn drugIn = new DrugShop.Entities.PIn();
            ColumnCollection cols = dict.GetColumns();
            foreach (Property prop in cols)
            {
                if (drugIn.ContainsProperty(prop.Name))
                {
                    drugIn[prop.Name] = dict[prop.Name];
                }
            }
            drugIn.BatchID = txtBatch.Text;
            drugIn.Number = int.Parse(txtNumber.Text);
            drugIn.Provider = "艾康生物技术(杭州)有限公司";
            drugIn.TimeLimit = dtpTimeLimit.Value;
            var service = ServiceContainer.GetService<IDrugInService>();
            //字典中没有的属性
            drugIn.JobPrice = dict.Price;
            drugIn.SalePrice = dict.Price;
            if (!service.ExistsDrugID(drugIn.Code, drugIn.Provider, drugIn.SalePrice, drugIn.TimeLimit))
                drugIn.DrugID = service.GetMaxDrugIDN().ToString();
            drugIn.Id = service.GetMaxID();
            //赋值listview
            string typeName = DataConvertHelper.GetGbCodeName(dict.Type);
            ListViewItem lv = new ListViewItem(new string[] { string.Empty,drugIn.Code, drugIn.ChinseName,drugIn.Spec ,
                                                drugIn.Unit,drugIn.TimeLimit.ToShortDateString(),this.txtBatch.Text.Trim(),
                                               dict.Price.ToString("0.00##"),drugIn.Number.ToString(),typeName});
            lvwDrugInList.Items.Add(lv);
            lv.Tag = drugIn;
            dict = null;
        }

        private void tsbDrugInDel_Click(object sender, EventArgs e)
        {
            if (lvwDrugInList.SelectedItems != null && lvwDrugInList.SelectedItems.Count > 0)
            {
                ListViewItem li = lvwDrugInList.SelectedItems[0];
                lvwDrugInList.Items.Remove(li);
            }
        }

        private void lvwDrugInList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (lvwDrugInList.SelectedItems != null && lvwDrugInList.SelectedItems.Count > 0)
                {
                    ListViewItem li = lvwDrugInList.SelectedItems[0];
                    lvwDrugInList.Items.Remove(li);
                }
            }
        }
        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (lvwDrugInList.Items.Count == 0)
            {
                MessageBox.Show("没有要提交的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtSearch.Focus();
                return;
            }
            storeList.Clear();
            inList.Clear();
            try
            {
                var service = ServiceContainer.GetService<IDrugStoreService>();
                foreach (ListViewItem item in lvwDrugInList.Items)
                {
                    PIn rin = item.Tag as PIn;
                    Store store = service.GetDrugStore(rin.Code, rin.DrugID, rin.ChinseName, rin.Spec, rin.TimeLimit);
                    if (store != null)
                    {
                        store.Number = store.Number + rin.Number;
                    }
                    else
                    {
                        store = new Store();
                        store.Code = rin.Code;
                        store.ChinseName = rin.ChinseName;
                        store.Spec = rin.Spec;
                        store.TimeLimit = rin.TimeLimit;
                        store.DrugID = rin.DrugID;

                        ColumnCollection cols = rin.GetColumns();
                        foreach (Property prop in cols)
                        {
                            if (store.ContainsProperty(prop.Name))
                            {
                                store[prop.Name] = rin[prop.Name];
                            }
                        }
                        store.ID = ServiceContainer.GetService<IDrugStoreService>().GetMaxID();
                        store.Number = rin.Number;
                        store.DrugID = rin.DrugID;
                    }
                    storeList.Add(store);
                    inList.Add(rin);
                }
                if (inList.Count > 0)
                {
                    var s = ServiceContainer.GetService<IDrugInService>();
                    s.DrugInSave(inList, storeList);
                    MessageBox.Show("本次药房药品入库成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.lvwDrugInList.Items.Clear();
                }
                this.txtSearch.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "在保存入库记录数据的过程中发生了一个错误：\n" + ex.InnerException.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {

            if (lvwDrugInList.Items.Count > 0)
            {
                if (MessageBox.Show("您的数据还没有保存，是否退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    EAS.Application.Instance.CloseModule(this);
                }
                else
                    btnOK.Focus();
            }
            else
                EAS.Application.Instance.CloseModule(this);
        }

        public void ClearText()
        {
            foreach (Control Ctrol in panMethod.Controls)
            {
                if (Ctrol is TextBox)
                {
                    Ctrol.Text = string.Empty;
                    txtSearch.Focus();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.SetReportName("药品入库明细表(药店)");
            this.PrintPreview(this.inList);
        }

        private void textBoxAutoComplete1_InputComplete(object sender, EAS.Windows.UI.Controls.TextBoxInputEventAgrs e)
        {
            if (e.TextBox == this.txtSearch)
            {
                Dict dict = this.txtSearch.GetSelectedItem() as Dict;
                if (dict != null)
                {
                    FillDrugdict(dict);
                }
            }            
        }
    }
}
