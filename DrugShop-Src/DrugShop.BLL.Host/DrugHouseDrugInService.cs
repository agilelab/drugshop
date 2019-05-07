using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using EAS.Data.Linq;
using EAS.Data.Access;
using DrugShop.Entities;using EAS.Data.ORM;

namespace DrugShop.BLL
{
    [ServiceObject("药品入库服务")]
    [ServiceBind(typeof(IDrugInService))]
    public class DrugShopDrugInService : BaseServiceObject, DrugShop.BLL.IDrugInService
    {
        public IList<PIn> GetDrugInList(string provider, string keyWord, DateTime startTime, DateTime endTime)
        {
            DataEntityQuery<PIn> query = DataEntityQuery<PIn>.Create();

            var p = (from item in query
                     where ((item.Provider == provider) || (provider == string.Empty))
                     && (keyWord==string.Empty  || item.InputCode1.StartsWith(keyWord) )
                     && item.EventTime>=startTime
                     && item.EventTime<=endTime
                     orderby item.EventTime descending
                     select item);

            return p.ToList();
        }

        public IList<PIn> GetDrugProviderBackList(string provider,  string keyWord, DateTime startTime, DateTime endTime)
        {
            DataEntityQuery<PIn> query = DataEntityQuery<PIn>.Create();

            var p = (from item in query
                     where ((item.Provider == provider) || (provider == string.Empty))
                     && (keyWord == string.Empty ||  item.InputCode1.StartsWith(keyWord))
                     && item.EventTime >= startTime
                     && item.EventTime <= endTime
                     orderby item.EventTime descending
                     select item);

            return p.ToList();
        }

        #region IBillCode 成员

        public int GetBillCodeIDN()
        {
            ParameterCollection pc = new ParameterCollection();
            pc.Add("ITEMKEY", "DRUGINBILLCODE");
            this.billCodeIDN = (int)this.DataAccessor.Query("exec DS_GetIdentityValue @itemkey=?", pc);
            return this.billCodeIDN;
        }

        private int billCodeIDN;

        public string GetBillCode()
        {
            if (this.billCodeIDN == 0)
                this.GetBillCodeIDN();

            return new DateTimeService().GetCurrentTime().ToString("yyyyMMdd") + this.billCodeIDN.ToString("D6");
        }

        #endregion

        #region 保存

        public void DrugInSave(IList<PIn> DrugInList, IList<Store> storeList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.InternalDrugPlan), DrugInList, storeList);
        }

        void InternalDrugPlan(IDataAccessor Accessor, params object[] parameters)
        {
            IList<PIn> DrugPlanList = parameters[0] as IList<PIn>;
            IList<Store> DrugStoreList = parameters[1] as IList<Store>;

            DateTime currentTime = new DateTimeService().GetCurrentTime();

            foreach (PIn drugIn in DrugPlanList)
            {
                drugIn.EventTime = currentTime;
                drugIn.Insert();
            }

            foreach (Store drugStore in DrugStoreList)
            {
                drugStore.Save();
            }
        }

        #endregion

        #region IDrugInService 成员

        public int GetMaxDrugIDN()
        {
            return new MaxCodeService().GetMaxCode("DrugID");
        }

        public bool ExistsDrugID(string drugCode, string provider, decimal SalePrice, DateTime TimeLimit)
        {
            DataEntityQuery<PIn> query = DataEntityQuery<PIn>.Create();

            var p = (from item in query
                     where item.Code == drugCode
                     && (provider == null || item.Provider == provider)
                     && item.SalePrice == SalePrice
                     && item.TimeLimit == TimeLimit
                     select item);

            return p.Count()> 0;
        }

        #endregion

        #region IMaxID 成员

        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PIn().DbTableName);
        }

        #endregion
    }
}
