using System;
using DrugShop.Entities;using EAS.Data.ORM;
using System.Collections.Generic;
namespace DrugShop.BLL
{
    public interface IDrugDictService : IMaxID
    {
        int GetMaxCodeIDN();

        IList<Dict> GetDrugDictList(int drugType, string keyWord);

        IList<Dict> GetDrugDictList(string keyWord);
    }
}
