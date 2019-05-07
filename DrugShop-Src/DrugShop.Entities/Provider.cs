using System;
using System.Data;
using System.Linq;

using EAS.Data.Access;
using EAS.Data.ORM;
using EAS.Data.Linq;
using System.Collections.Generic;

namespace DrugShop.Entities
{
   /// <summary>
   /// 实体对象 Provider(供应商)。
   /// </summary>
   public partial class Provider: DataEntity<Provider>
   {
       public IList<Provider> GetAll()
       {
           DataEntityQuery<Provider> query = DataEntityQuery<Provider>.Create();

           var p = (from item in query
                    orderby item.Name ascending
                    select item
               );

           return p.ToList();
       }

       public IList<Provider> GetProviderList()
       {
           DataEntityQuery<Provider> query = DataEntityQuery<Provider>.Create();

           var p = (from item in query
                    orderby item.Name ascending
                    select item
               );

           return p.ToList();
       }
   }
}
