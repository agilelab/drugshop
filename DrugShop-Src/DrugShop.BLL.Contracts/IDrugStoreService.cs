using System;
using DrugShop.Entities;using EAS.Data.ORM;
using System.Collections.Generic;
namespace DrugShop.BLL
{
    public interface IDrugStoreService:IMaxID
    {
        string GetBillCode();

        int GetBillCodeIDN();

        void DrugStoreDelete(IList<Store> DrugStoreDeleteList);
        
        IList<Store> GetDrugList(int drugType, string keyWord);

        IList<Store> GetDrugList(int drugType, string keyWord, bool isLimit);

        IList<Store> GetDrugList(int drugType, string keyWord, bool isLost, int days);

        IList<Store> GetDrugList(string keyWord);

        IList<Store> GetDrugList(string keyWord, bool isZero);

        IList<Store> GetDrugList(string keyWord, string provider);

        Store GetDrugStore(string code, string DrugID, string ChinseName, string spec, DateTime TimeLimit);
    }
}
