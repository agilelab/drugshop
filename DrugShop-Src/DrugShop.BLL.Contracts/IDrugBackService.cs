using System;
using DrugShop.Entities;using EAS.Data.ORM;
using System.Collections.Generic;
namespace DrugShop.BLL
{
    public interface IDrugBackService
    {
        int GetPBackMaxID();
        int GetSBackMaxID();

        string GetBillCode();

        int GetBillCodeIDN();

        void DrugBackSave(IList<Store> updateStoreList, IList<PBack> providerBackList);

        void DrugBackSave(IList<Store> updateStoreList, IList<SBack> customBackList);

        List<PBack> GetDrugBackList(string provider, string keyWord, DateTime startTime, DateTime endTime);

        List<SBack> GetDrugCustomBackList(string customName, string keyWord, DateTime startTime, DateTime endTime);

        List<SBack> GetDrugCustomBackList(string keyWord, DateTime startTime, DateTime endTime);
    }
}
