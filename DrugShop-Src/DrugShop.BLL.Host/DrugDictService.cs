using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EAS.Services;
using EAS.Data.Linq;
using DrugShop.Entities;using EAS.Data.ORM;

namespace DrugShop.BLL
{
    [ServiceObject("药品字典服务")]
    [ServiceBind(typeof(IDrugDictService))]
    public class DrugDictService : BaseServiceObject, DrugShop.BLL.IDrugDictService
    {
         #region 查询数据

         public IList<Dict> GetDrugDictList(string keyWord)
         {
             DataEntityQuery<Dict> query = DataEntityQuery<Dict>.Create();

             var p = (from item in query
                      where (keyWord == string.Empty ||  item.InputCode1.ToUpper().StartsWith(keyWord)||item.ChinseName.ToUpper().StartsWith(keyWord))
                      orderby item.ChinseName ascending
                      select item);

             return p.ToList();
         }

         public IList<Dict> GetDrugDictList(int drugType, string keyWord)
         {
             DataEntityQuery<Dict> query = new DataEntityQuery<Dict>();

             var p = from c in query
                      where (keyWord == string.Empty || c.InputCode1.StartsWith(keyWord) || c.ChinseName.StartsWith(keyWord))
                      && (drugType == 0 || c.Type == drugType)
                      orderby c.ChinseName ascending
                      select c;

             //string sql  = "select * from ds_dict where Inputode1 = 'abc'";
             //System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sql);

             return p.ToList();
         }


         #endregion

         #region IMaxID 成员

         public int GetMaxID()
         {
             return new MaxCodeService().GetMaxCode(new Dict().DbTableName);
         }

         #endregion

         #region IDrugDictService 成员

         public int GetMaxCodeIDN()
         {
             return new MaxCodeService().GetMaxCode("DictCODE");
         }

         #endregion
    }
}
