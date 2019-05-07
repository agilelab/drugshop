using System;
using System.Collections.Generic;
using DrugShop.Entities;using EAS.Data.ORM;
namespace DrugShop.BLL
{
    public interface IDrugLostService:IMaxID
    {
        void DrugLostSave(IList<Store> drugStoreList, IList<Lost> drugOutList);

        List<Lost> GetDrugLostList(string cause, string keyWord, DateTime startTime, DateTime endTime);
    }
}
