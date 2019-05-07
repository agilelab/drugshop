using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using EAS.Data.Linq;
using DrugShop.Entities;using EAS.Data.ORM;

namespace DrugShop.BLL
{
    [ServiceObject("供应商或生产厂家信息服务")]
    [ServiceBind(typeof(IProviderService))]
    public class ProviderService : BaseServiceObject, DrugShop.BLL.IProviderService
    {
        public IList<Provider> GetProviderList( string keys)
        {
            DataEntityQuery<Provider> query = DataEntityQuery<Provider>.Create();

            var p=(from item in query
                       where (keys==string.Empty || item.Name.Contains(keys) || item.InputCode.Contains(keys))
                       orderby item.Name ascending
                       select item
                       );

            return p.ToList();
        }

        #region IMaxID 成员

        public int GetMaxID()
        {
            string sql = " select isnull(max(id),0)+1 from PROVIDER";
            return (int)this.DataAccessor.Query(sql);
        }

        #endregion
    }
}
