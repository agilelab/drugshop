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
    [ServiceObject("药店调价服务")]
    [ServiceBind(typeof(IDrugChangePriceService))]
    public class DrugChangePriceService : BaseServiceObject, DrugShop.BLL.IDrugChangePriceService
    {
        public IList<CPrice> GetDrugChangePriceList(string backCause, string keyWord, DateTime startTime, DateTime endTime)
        {
            DataEntityQuery<CPrice> query = DataEntityQuery<CPrice>.Create();

            var p = (from item in query
                     where (backCause.Trim().Length == 0 || item.Cause.Contains(backCause.Trim()))
                     &&  (keyWord==string.Empty || item.InputCode1.StartsWith(keyWord))
                     &&  item.EventTime>=startTime
                     &&  item.EventTime<=endTime
                     orderby item.EventTime descending
                     select item);

            return p.ToList();
        }

        #region IBillCode 成员

        public int GetBillCodeIDN()
        {
            ParameterCollection pc = new ParameterCollection();
            pc.Add("ITEMKEY", "DRUGCHANGEPRICEBILLCODE");

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

        /// <summary>
        /// 调价事务方法
        /// </summary>
        /// <param name="drugChangePriceList"></param>
        public void ChangePrice(IList<CPrice> drugChangePriceList,IList<Store> storeList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.InternalSave), drugChangePriceList, storeList);
        }
        /// <summary>
        /// 内部调价方法
        /// </summary>
        /// <param name="Accessor"></param>
        /// <param name="parameters"></param>
        void InternalSave(IDataAccessor Accessor, params object[] parameters)
        {
            IList<CPrice> changePriceList = parameters[0] as IList<CPrice>;
            IList<Store> storeList = parameters[1] as IList<Store>;

            DateTime currentTime =new DateTimeService().GetCurrentTime();

            foreach (CPrice drugCp in changePriceList)
            {
                //记录编号
                drugCp.ID = this.GetMaxID();
                //drugCp.BillCode = GetBillCode();

                drugCp.EventTime = currentTime;

                //保存调价
                drugCp.Insert();
            }

            foreach (Store store in storeList)
            {
                //更新库存价格
                store.Update();
            }
        }

        #region IMaxID 成员

        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new CPrice().DbTableName);
        }

        #endregion
    }
}
