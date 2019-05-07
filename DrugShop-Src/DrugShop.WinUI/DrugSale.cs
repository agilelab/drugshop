using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EAS.Data.Linq;
using EAS.Modularization;
using DrugShop.BLL;
using EAS.Services;
using DrugShop.Entities;
using EAS.Data.ORM;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 药品销售
    /// </summary>
    [Module("AA8930A4-CADC-403A-99F0-24539A59C99C", "药品销售", "提供药品销售功能")]
    public partial class DrugSale : UserControl
    {
        Store store;
        private IList<SOut> outList ;
        private IList<Store> updateStoreList ;
        public DrugSale()
        {
            InitializeComponent();
            this.controlAutoFocus1.NextKeys = new Keys[] { Keys.Enter };
        }

        [ModuleStart]
        public void Start()
        {
            outList = new List<SOut>();
            updateStoreList = new List<Store>();
        }
        
        #region 检索库存
        //输入编码,按【回车】
        private void txt_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string code = txt_code.Text.Trim().Trim();
                IList<Store> storeList = ServiceContainer.GetService<IDrugStoreService>().GetDrugList(code);
                if (storeList.Count == 0)
                {
                    MessageBox.Show("库存中不存在该药品，请检查输入是否正确!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_code.Focus();
                    this.txt_code.SelectAll();
                }
                else
                {
                    if (storeList.Count == 1)
                    {
                        AddStoredict(storeList[0]);
                    }
                    else
                    {
                        this.AddListViewStore(storeList);
                    }
                }
            }
        }

        // 绑定库存数据到listView
        private void AddListViewStore(IList<Store> list)
        {
            this.listView_Store.Items.Clear();
            this.listView_Store.BeginUpdate();
            foreach (Store item in list)
            {
                ListViewItem lv = new ListViewItem(new string[] { string.Empty, item.Code, item.ChinseName, item.Spec, item.Unit,item.TimeLimit.ToString("yyyy-MM-dd"),string.Format("{0:0.####}", item.Number),string.Format("{0:0.00###}", item.JobPrice),
                                     item.BatchID,item.Provider});
                lv.Tag = item;
                listView_Store.Items.Add(lv);
            }
            this.listView_Store.EndUpdate();
            this.listView_Store.Visible = true;
            this.listView_Store.Focus();
            this.listView_Store.Items[0].Focused = true;
            this.listView_Store.Items[0].Selected = true;
        }

        private void AddStoredict(Store drug)
        {
            store = drug;
            txt_code.Text = drug.Code;
            txt_name.Text = drug.ChinseName;
            txt_BUnit.Text = drug.Unit;
            txt_contents.Text = drug.Spec;
            txt_BUnit.Text = drug.Unit;
            txt_TimeLimit.Text = drug.TimeLimit.ToString("yyyy-MM-dd");
            txt_price.Text = string.Format("{0:0.00###}", drug.SalePrice);
            txt_StoreNumber.Text = string.Format("{0:0.##}", drug.Number);
            listView_Store.Visible = false;
            txt_OutNumber.Focus();
        }

          //listView_Store按【回车】
        private void listView_Store_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if(listView_Store.SelectedItems.Count>0)
                {
                    Store store=listView_Store.SelectedItems[0].Tag as Store;
                    AddStoredict(store);
                }
                
            }
            if (e.KeyValue == (char)Keys.Escape)
            {
                listView_Store.Visible = false;
                this.txt_code.Focus();
                this.txt_code.SelectAll();
            }
        }

         //双击listView_Store
        private void listView_Store_DoubleClick(object sender, EventArgs e)
        {
            if(listView_Store.SelectedItems.Count>0)
                {
                    Store store=listView_Store.SelectedItems[0].Tag as Store;
                    AddStoredict(store);
                }
        }

        #endregion

        #region 添加到出库列表
        private void txt_OutNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (!VerifyOutNumber())
                {
                    return;
                }
                else
                {
                    AddToDrugOut();
                    SelectPrice();
                    ClearText();
                }
            }
            if (e.KeyData == Keys.Up)
            {
                txt_code.Focus();
                txt_code.SelectAll();
            }

        }

        //出库量有效性校验
        private bool VerifyOutNumber()
        {
            if (this.store == null)
            {
                MessageBox.Show("请选择一个入库药品！");
                this.txt_code.Focus();
                this.txt_code.Select();
                return false
;
            }
            if (string.IsNullOrWhiteSpace(txt_OutNumber.Text))
            {
                MessageBox.Show("出库数量不能为空，请输入所要出库的数量！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_OutNumber.Focus();
                return false;
            }
            int i = 0;
            bool result = int.TryParse(this.txt_OutNumber.Text, out i);
            if (!result)
            {
                MessageBox.Show("请输入整数！");
                txt_OutNumber.Focus();
                txt_OutNumber.SelectAll();
                return false;
            }
            else if (i <= 0)
            {
                MessageBox.Show("出库数量必须要大于0！");
                txt_OutNumber.Focus();
                txt_OutNumber.SelectAll();
                return false;
            }
            else if (i > int.Parse(txt_StoreNumber.Text))
            {
                MessageBox.Show("出库数量不能大于库存量，请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_OutNumber.Focus();
                txt_OutNumber.SelectAll();
                return false;
            }

            return true;
        }

        //往界面右边传值并显示
        private void AddToDrugOut()
        {
            DrugShop.Entities.SOut drugOut = new DrugShop.Entities.SOut();
            ColumnCollection cols = store.GetColumns();
            foreach (Property prop in cols)
            {
                if (drugOut.ContainsProperty(prop.Name))
                {
                    drugOut[prop.Name] = store[prop.Name];
                }
            }
            drugOut.Number = int.Parse(this.txt_OutNumber.Text);
            drugOut.CustomName = txtCustomer.Text;
            //赋值listview
            ListViewItem lv = new ListViewItem(new string[] { string.Empty, drugOut.Code,drugOut.ChinseName, drugOut.Spec, drugOut.Unit, drugOut.TimeLimit.ToShortDateString(),store.SalePrice.ToString(), store.Number.ToString(),drugOut.Number.ToString() });
            store.Number = store.Number - drugOut.Number;
            object[] o = new object[] { drugOut, store };
            lv.Tag = o;
            listView_DrugOut.Items.Add(lv);
            this.store = null;
        }

             //自动清空所有的文本框
        public void ClearText()
        {
            foreach (Control Ctrol in panel_left.Controls)
            {
                if (Ctrol is TextBox)
                {
                    Ctrol.Text = "";
                    txt_code.Focus();
                }
            }
        }
        #endregion

        //按【Delete】键删除某条出库记录 
        private void listView_DrugOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {

                ListView lv = sender as ListView;
                if (lv.SelectedItems.Count < 1)
                {
                    return;
                }
                ListViewItem li = lv.SelectedItems[0];
                lv.Items.Remove(li);
                SelectPrice();
            }
            if (e.KeyData == Keys.Escape)
            {
                txt_code.Focus();
            }
        }

        //保存数据【确定】
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (listView_DrugOut.Items.Count == 0)
            {
                MessageBox.Show("没有要保存的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_code.Focus();
                return;
            }
            else
            {
                updateStoreList.Clear();
                outList.Clear();
                try
                {
                    foreach (ListViewItem item in listView_DrugOut.Items)
                    {
                        object[] o = item.Tag as object[];
                        outList.Add(o[0] as SOut);
                        updateStoreList.Add(o[1] as Store);
                    }
                    if (outList.Count > 0)
                    {
                        ServiceContainer.GetService<IDrugOutService>().DrugOutSave(updateStoreList, outList);
                        MessageBox.Show("发药成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "在保存出库记录数据的过程中发生了一个错误：\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.SetReportName("药品出库明细表(药店)");
            this.PrintPreview(this.outList);
        }

        // 动态显示每次药品出库的批发价和零售价的总金额
        private void SelectPrice()
        {
            decimal price = 0;
            foreach (ListViewItem item in this.listView_DrugOut.Items)
            {
                object[] o = item.Tag as object[];
                SOut dgout = o[0] as SOut;
                decimal dprice = dgout.SalePrice;
                decimal number = dgout.Number;
                price += number * dprice;
            }
            lbl_price.Text = string.Format("{0:0.00}", price) + "元";
            lbl_SelectPrice.Visible = true;
            lbl_price.Visible = true;
        }

        // 关闭
        private void btn_Close_Click(object sender, EventArgs e)
        {
            EAS.Application.Instance.CloseModule(this);
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txt_code.Focus();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.listView_DrugOut.Items.Clear();
            this.txtCustomer.Focus();
        }
      
    }
}
