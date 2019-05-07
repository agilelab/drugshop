using System;
using System.Collections.Generic;
using DrugShop.Entities;
using EAS.Data.ORM;
namespace DrugShop.BLL
{
    public interface IDrugInService:IMaxID
    {
        int GetMaxDrugIDN();

        string GetBillCode();

        int GetBillCodeIDN();

        bool ExistsDrugID(string drugCode, string provider, decimal SalePrice, DateTime TimeLimit);

        void DrugInSave(IList<PIn> DrugInList, IList<Store> storeList);
        
        IList<PIn> GetDrugInList(string provider, string keyWord, DateTime startTime, DateTime endTime);
        
        IList<PIn> GetDrugProviderBackList(string provider, string keyWord, DateTime startTime, DateTime endTime);
    }
}
