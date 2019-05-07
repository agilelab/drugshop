using System;
using DrugShop.Entities;using EAS.Data.ORM;
using System.Collections.Generic;
namespace DrugShop.BLL
{
    public interface IDrugStoreCountService:IMaxID
    {
        void DrugStoreCount();

        void DrugStoreCountAdjust(IList<Inventory> DrugStoreCountList);

        void DrugStoreCountInSert(IList<Store> DrugStoreList);

        void DrugStoreCountSave(IList<Inventory> DrugStoreCountList);

        IList<DrugInOut> GetDrugInOutList(DateTime startDate, DateTime endDate);

        IList<object> GetDrugStoreCountDateList();

        Inventory GetDrugStoreCountList(DateTime EventTime);

        IList<Inventory> GetDrugStoreCountList(DateTime startDate, DateTime endDate, string keys, int state);
       
        IList<Inventory> GetDrugStoreCountList(int chiPing, DateTime EventTime);
        
        IList<Inventory> GetDrugStoreCountList(string keyWord, DateTime EventTime);
        
        bool IsNeedUpdate(DateTime EventTime);
    }
}
