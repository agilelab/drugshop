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
    [ServiceObject("药品报损服务")]
    [ServiceBind(typeof(IDrugLostService))]
    public class DrugLostService : BaseServiceObject, DrugShop.BLL.IDrugLostService
    {
        #region 保存

        public void DrugLostSave(IList<Store> drugStoreList, IList<Lost> drugOutList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.InternalDrugLost), drugStoreList, drugOutList);
        }

        void InternalDrugLost(IDataAccessor Accessor, params object[] parameters)
        {
            IList<Store> DrugStoreList = parameters[0] as IList<Store>;
            IList<Lost> DrugLostList = parameters[1] as IList<Lost>;

            IDrugLostService service = new DrugLostService();
            DateTime currentTime = new DateTimeService().GetCurrentTime();

            foreach (Lost drugLost in DrugLostList)
            {
                drugLost.ID = service.GetMaxID();
                drugLost.EventTime = currentTime;
                drugLost.Insert();
            }

            foreach (Store store in DrugStoreList)
            {
                store.Update();
            }
        }

        #endregion

        public List<Lost> GetDrugLostList(string cause, string keyWord, DateTime startTime, DateTime endTime)
        {
            DataEntityQuery<Lost> query = DataEntityQuery<Lost>.Create();

            var p = (from item in query
                     where (cause == string.Empty || item.Cause == cause || (item.Cause.StartsWith(cause)))
                     && (keyWord == string.Empty || (item.InputCode1.StartsWith(keyWord)))
                     && item.EventTime >= startTime
                     && item.EventTime <= endTime
                     orderby item.EventTime descending
                     select item
                     
                     //select new {item .Unit,item.Type,item.TimeLimit}
                     );

            //foreach (var i in p)
            //{
            //    DateTime t = i.TimeLimit;
            //}
            return p.ToList();
        }

        #region IMaxID 成员

        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new Lost().DbTableName);
        }

        #endregion
    }
}
