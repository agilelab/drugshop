using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DrugShop.Entities;using EAS.Data.ORM;
using DrugShop.BLL;

namespace DrugShop.WinUI
{
     public class DataConvertHelper
     {
         #region 单例模式

         private static DataConvertHelper instance;
         private static object singleInstance=new object();

         public static DataConvertHelper Instance
         {
             get
             {
                 if (instance == null)
                 {
                     lock (singleInstance)
                     {
                         if (instance == null)
                             instance = new DataConvertHelper();
                     }
                 }

                 return instance;
             }
         }

        #endregion

         #region 初始化相关变量

         /// <summary>
         /// GBCode List
         /// </summary>
         private static Dictionary<int, DrugShop.Entities.DrugType> gbCodeList = null;

         /// <summary>
         /// Provider+Factory List
         /// </summary>
         private static Dictionary<int, DrugShop.Entities.Provider> providerList = null;

         #endregion

         #region 相关方法

         /// <summary>
         /// 根据GBCode中的Code返回Code对应的名称
         /// </summary>
         /// <param name="code">Code</param>
         /// <returns>Name</returns>
         public static string GetGbCodeName(int code)
         {
             if (gbCodeList == null)
             {
                 IList<DrugType> list = EAS.Services.ServiceContainer.GetService<IDrugTypeService>().GetDrugTypeList();

                 gbCodeList = new Dictionary<int, DrugShop.Entities.DrugType>(list.Count);

                 foreach (DrugShop.Entities.DrugType _code in list)
                     gbCodeList.Add(_code.Code, _code);
             }

             if (gbCodeList.ContainsKey(code))
                 return gbCodeList[code].Name;
             else
                 return null;
         }


         /// <summary>
         /// 根据Prodvider中的ID返回ID对应的名称
         /// </summary>
         /// <param name="code">Code</param>
         /// <returns>Name</returns>
         public static string GetProviderName(int id)
         {
             if (providerList == null)
             {
                 DrugShop.Entities.Provider item = new DrugShop.Entities.Provider();
                 IList<Provider> list = item.GetAll();

                 providerList = new Dictionary<int, DrugShop.Entities.Provider>(list.Count);

                 foreach (DrugShop.Entities.Provider var in list)
                     providerList.Add(var.ID, item);
             }

             if (providerList.ContainsKey(id))
                 return providerList[id].Name;
             else
                 return null;
         }

         #endregion
     }

     public class ObjectBuilder
     {
         public static T CreateObject<T>() where T:new()
         {
             T obj = new T();

             return obj;
         }

         public static T CreateInstance<T>() where T : new()
         {
             return (T)Activator.CreateInstance(typeof(T));
         }
     }

     public class CommonHelper
     {
         public static T GetDataGridViewSelectRow<T>(DataGridView dataGridView) where T : class
         {
             int rowIndex = dataGridView.CurrentCell.RowIndex;

             if (rowIndex < 0)
             {
                 return default(T);
             }

             DataGridViewRow row = dataGridView.Rows[rowIndex];
             T dict = row.DataBoundItem as T;

             return dict;
         }

         public static void RefreshDataGridView<T>(EAS.Data.ORM.DataEntity<T> Entities, DataGridViewRow row,DataGridView gridView) where T:class,IDataEntity,new()
         {
             foreach (DataGridViewColumn column in gridView.Columns)
             {
                 string columnName=column.Name.Substring(0, column.Name.IndexOf(""));
                 if (columnName!=string.Empty)
                 {
                     EAS.Data.ORM.Column col=Entities.GetColumns()[columnName];

                     if (col == null)
                         continue;

                     switch (col.DataType)
                     {
                         case System.Data.DbType.Decimal :
                             row.Cells[column.Name].Value = Entities.GetValue<decimal>(columnName).ToString("F4");
                             break;
                         case System.Data.DbType.Boolean:
                             row.Cells[column.Name].Value = Entities.GetValue<bool>(columnName) ? "是":"否";
                             break;
                         default :
                             row.Cells[column.Name].Value = Entities.GetValue<string>(columnName);
                             break;
                     }
                 }
             }
         }
     }
}
