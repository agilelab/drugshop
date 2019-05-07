using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DrugShop.Entities;
using EAS.Modularization;
using DrugShop.BLL;
using System.Linq;
using EAS;
using EAS.Services;

namespace DrugShop.WinUI
{
    /// <summary>
    /// 用于维护 DrugType 的基本类。
    /// </summary>
   [Module("97946721-D425-4F6C-B635-C9EDD8654742", "药品类型", "管理系统中的药品类型")]
    public partial class DrugTypeList : UserControl
    {
        [ModuleStart()]
        public void StartEx()
        {
            this.btnQuery_Click(this.btnQuery, new System.EventArgs());
        }

        private List<DrugType> drugTypeList;

        public DrugTypeList()
        {
            InitializeComponent();
            this.drugTypeList = new List<DrugType>();
            this.drugTypeBindingSource.DataSource = this.drugTypeList;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            using (DbEntities db = new DbEntities())
            {
                var v = db.DrugTypes.ToList();
                this.drugTypeList = v.Where(p => p.Name.ToPinYin().ToUpper().StartsWith(this.tbKey.Text.ToPinYin().ToUpper()))
                    .OrderBy(p => p.Code).ToList();

                this.drugTypeBindingSource.DataSource = this.drugTypeList;
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row != null)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.Row.Index - 1];
                IDrugTypeService service = ServiceContainer.GetService<IDrugTypeService>();
                row.Cells[0].Value = service.GetMaxID();
                row.Cells[1].Value = service.GetMaxCode();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.SetReportName("药品类型");
            this.PrintPreview(this.drugTypeList);
        }        
    }
}
