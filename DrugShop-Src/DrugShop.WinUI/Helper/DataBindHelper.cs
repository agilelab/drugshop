using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DrugShop.Entities;using EAS.Data.ORM;
using DrugShop.BLL;

namespace DrugShop.WinUI
{
    internal class DataBindHelper
    {
        public static void BindFactoryCmbBox2(ComboBox comboBox)
        {
            DrugShop.Entities.Provider provider = new DrugShop.Entities.Provider();
            IList<Provider> providerList = provider.GetProviderList();

            DrugShop.Entities.Provider item = new DrugShop.Entities.Provider();
            item.ID = 0;
            item.Name = "全部";

            providerList.Insert(0, item);

            comboBox.DataSource = providerList;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "Name";

            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 药品类型
        /// </summary>
        /// <param name="comboBox"></param>
        public static void BindDrugTypeCmbBox2(ComboBox comboBox)
        {
            IList<DrugType> codeList = GetDrugTypeList();

            comboBox.DataSource = codeList;
            comboBox.ValueMember = "Code";
            comboBox.DisplayMember = "Name";

            comboBox.Tag = codeList;
        }

        /// <summary>
        /// 药品类型
        /// </summary>
        /// <param name="comboBox"></param>
        public static void BindDrugTypeCmbBox3(ComboBox comboBox)
        {
            DrugShop.Entities.DrugType code = new DrugShop.Entities.DrugType();
            IList<DrugType> codeList = EAS.Services.ServiceContainer.GetService<IDrugTypeService>().GetDrugTypeList();

            comboBox.DataSource = codeList;
            comboBox.ValueMember = "Code";
            comboBox.DisplayMember = "Name";

            comboBox.Tag = codeList;
        }

        public static IList<DrugType> GetDrugTypeList()
        {
            IList<DrugType> codeList = EAS.Services.ServiceContainer.GetService<IDrugTypeService>().GetDrugTypeList();

            DrugShop.Entities.DrugType item = new DrugShop.Entities.DrugType();
            item.Code = 0;
            item.Name = "全部";

            codeList.Insert(0, item);

            return codeList;
        }

        /// <summary>
        /// 药品类型 
        /// </summary>
        /// <param name="comboBox"></param>
        public static void BindDrugTypeCmbBox2(ToolStripComboBox comboBox)
        {
            IList<DrugType> codeList = GetDrugTypeList();

            foreach (DrugShop.Entities.DrugType var in codeList)
            {
                if (var.Name == null)
                    var.Name = "全部";

                comboBox.Items.Add(var.Name);
            }

            comboBox.Tag = codeList;
        }

    }
}
