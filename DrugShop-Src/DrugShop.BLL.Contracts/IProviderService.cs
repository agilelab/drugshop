using System;
using DrugShop.Entities;
using EAS.Data.ORM;
using System.Collections.Generic;
namespace DrugShop.BLL
{
    public interface IProviderService:IMaxID
    {
        IList<Provider> GetProviderList(string keys);
    }
}
