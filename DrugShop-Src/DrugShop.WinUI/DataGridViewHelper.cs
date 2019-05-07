using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrugShop.WinUI
{
     public class DataGridViewHelper
    {
         /// <summary>
         /// 根据传入的指定的列名来转换药品类型的名称(根据编码转换为名称)
         /// </summary>
         /// <param name="dataGridView"></param>
         /// <param name="columnName"></param>
         /// <returns></returns>
         public static string GetDrugTypeName(DataGridView dataGridView,DataGridViewCellFormattingEventArgs e,string columnName)
         {
             string drugTypeName = string.Empty;

             if (dataGridView.Columns[e.ColumnIndex].Name == columnName)
             {
                 if (e.Value != null)
                 {
                     int stringValue = (int)e.Value;
                     e.Value = DataConvertHelper.GetGbCodeName(stringValue);
                 }
             }

             return drugTypeName;
         }
    }
}
