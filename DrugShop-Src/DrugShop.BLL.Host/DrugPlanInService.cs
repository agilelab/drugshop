using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Data.Access;
using EAS.Services;
using EAS.Data.Linq;
using DrugShop.Entities;using EAS.Data.ORM;

namespace DrugShop.BLL
{
    [ServiceObject("药品计划服务")]
    [ServiceBind(typeof(IDrugPlanService))]
     public class DrugPlanInService : BaseServiceObject, DrugShop.BLL.IDrugPlanService
    {
        #region IBillCode 成员

        public int GetBillCodeIDN()
        {
            ParameterCollection pc = new ParameterCollection();
            pc.Add("ITEMKEY", "Plan");
            this.billCodeIDN = (int)this.DataAccessor.Query("exec DS_GetIdentityValue @itemkey=?", pc);
            return this.billCodeIDN;
        }

        private int billCodeIDN;

        public string GetBillCode()
        {
            if (this.billCodeIDN == 0)
            {
                this.GetBillCodeIDN();
            }

           return new DateTimeService().GetCurrentTime().ToString("yyyyMMdd") + this.billCodeIDN.ToString("D6");
        }

        #endregion

        #region 保存

        public void DrugPlan(IList<Plan> DrugPlanList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.InternalDrugPlan), DrugPlanList);
        }

        void InternalDrugPlan(IDataAccessor Accessor, params object[] parameters)
        {
            IList<Plan> DrugPlanList = parameters[0] as IList<Plan>;

            DateTime currentTime = new DateTimeService().GetCurrentTime();

            foreach (Plan drugPlan in DrugPlanList)
            {
                drugPlan.ID = this.GetMaxID();
                drugPlan.EventTime = currentTime;
                drugPlan.Insert();
            }
        }

        #endregion

        #region 查询数据

        public IList<Plan> GetDrugPlanInList(string provider, int factory, string keyWord, DateTime startTime, DateTime endTime)
        {
            DataEntityQuery<Plan> query = DataEntityQuery<Plan>.Create();

            var p = (from item in query
                     where ((item.Provider == int.Parse(provider)) || (provider == string.Empty))
                     && (keyWord == string.Empty ||  item.InputCode1.StartsWith(keyWord))
                     && item.EventTime >= startTime
                     && item.EventTime <= endTime
                     orderby item.EventTime descending
                     select item);

            return p.ToList();
        }

        #endregion

        #region IMaxID 成员

        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new Plan().DbTableName);
        }

        #endregion
    }
}
