using System;
using System.Collections.Generic;
using DrugShop.Entities;using EAS.Data.ORM;
namespace DrugShop.BLL
{
    public interface IDrugChangePriceService:IMaxID
    {
        string GetBillCode();

        int GetBillCodeIDN();

        void ChangePrice(IList<CPrice> drugChangePriceList, IList<Store> storeList);
        
        IList<CPrice> GetDrugChangePriceList(string backCause, string keyWord, DateTime startTime, DateTime endTime);
    }
}
