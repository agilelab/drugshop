using System;
using System.Collections.Generic;
using DrugShop.Entities;using EAS.Data.ORM;
namespace DrugShop.BLL
{
    public interface IDrugPlanService:IMaxID
    {
        string GetBillCode();

        int GetBillCodeIDN();

        void DrugPlan(IList<Plan> DrugPlanList);
        
        IList<Plan> GetDrugPlanInList(string provider, int factory, string keyWord, DateTime startTime, DateTime endTime);
    }
}
