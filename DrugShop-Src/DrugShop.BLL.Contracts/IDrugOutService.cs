using System;
using System.Collections.Generic;
using DrugShop.Entities;using EAS.Data.ORM;
namespace DrugShop.BLL
{
    public interface IDrugOutService:IMaxID
    {
        string GetBillCode();

        int GetBillCodeIDN();

        void DrugOutSave(IList<Store> drugStoreList, IList<SOut> drugOutList);

        List<SOut> GetDrugOutList(string customName, string keyWord);

        List<SOut> GetDrugOutList(string customName, string keyWord, DateTime startTime, DateTime endTime);
    }
}
