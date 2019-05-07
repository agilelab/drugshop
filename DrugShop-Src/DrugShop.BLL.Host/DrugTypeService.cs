using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EAS.Services;
using EAS.Data.Linq;
using DrugShop.Entities;using EAS.Data.ORM;

namespace DrugShop.BLL
{
     [ServiceObject("基础数据信息服务")]
     [ServiceBind(typeof(IDrugTypeService))]
     public class DrugTypeService : BaseServiceObject, DrugShop.BLL.IDrugTypeService
    {
         public IList<DrugType> GetDrugTypeList()
         {
             DataEntityQuery<DrugType> query = DataEntityQuery<DrugType>.Create();

             var p = (from item in query
                      orderby item.Name ascending
                      select item
                 );

             return p.ToList();
         }

         #region IDrugTypeService 成员

         public int GetMaxCode()
         {
             string sql = " select isnull(max(CODE),0)+1 from DS_DRUGTYPE";
             return (int)this.DataAccessor.Query(sql);             
         }

         #endregion

         #region IMaxID 成员

         public int GetMaxID()
         {
             return new MaxCodeService().GetMaxCode(new DrugType().DbTableName);
         }

         #endregion
    }
}
