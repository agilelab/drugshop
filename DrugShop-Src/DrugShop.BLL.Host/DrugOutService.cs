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
    [ServiceObject("药品出库服务")]
    [ServiceBind(typeof(IDrugOutService))]
     public class DrugOutService : BaseServiceObject, DrugShop.BLL.IDrugOutService
    {
        #region IBillCode 成员

        public int GetBillCodeIDN()
        {
            ParameterCollection pc = new ParameterCollection();
            pc.Add("ITEMKEY", "Store");
            this.billCodeIDN = (int)this.DataAccessor.Query("exec eas.GetIdEntitysValue @itemkey=?", pc);
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

        public void DrugOutSave(IList<Store> drugStoreList, IList<SOut> drugOutList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.InternalDrugOut), drugStoreList, drugOutList);
        }

        void InternalDrugOut(IDataAccessor Accessor, params object[] parameters)
        {
            IList<Store> DrugStoreList = parameters[0] as IList<Store>;
            IList<SOut> DrugOutList = parameters[1] as IList<SOut>;

            DateTime currentTime = new DateTimeService().GetCurrentTime();

            foreach (SOut drugOut in DrugOutList)
            {
                drugOut.ID = this.GetMaxID();
                drugOut.EventTime = currentTime;
                drugOut.Insert();
            }

            foreach (Store store in DrugStoreList)
            {
                store.Update();
            }
        }

        #endregion

        public List<SOut> GetDrugOutList(string customName, string keyWord, DateTime startTime, DateTime endTime)
        {
            DataEntityQuery<SOut> query = DataEntityQuery<SOut>.Create();

            var p = (from item in query
                     where (customName == string.Empty || item.CustomName == customName || (item.CustomName.StartsWith(customName)))
                     && (keyWord == string.Empty || (item.InputCode1.StartsWith(keyWord)))
                     && item.EventTime >= startTime
                     && item.EventTime <= endTime
                     orderby item.EventTime descending
                     select item);

            return p.ToList();
        }

        public List<SOut> GetDrugOutList(string customName, string keyWord)
        {
            DataEntityQuery<SOut> query = DataEntityQuery<SOut>.Create();

            var p = (from item in query
                     where (customName == string.Empty || item.CustomName == customName || (item.CustomName.StartsWith(customName)))
                     && (keyWord == string.Empty || (item.InputCode1.StartsWith(keyWord)))
                     orderby item.EventTime descending
                     select item);

            return p.ToList();
        }

        #region IMaxID 成员

        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new SOut().DbTableName);
        }

        #endregion
    }
}
