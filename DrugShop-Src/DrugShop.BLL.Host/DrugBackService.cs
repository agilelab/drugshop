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
    [ServiceObject("药店退药服务")]
    [ServiceBind(typeof(IDrugBackService))]
    public class DrugDrugBackService : BaseServiceObject, DrugShop.BLL.IDrugBackService
    {
        public List<PBack> GetDrugBackList(string provider, string keyWord, DateTime startTime, DateTime endTime)
        {
            DataEntityQuery<PBack> query = DataEntityQuery<PBack>.Create();

            var p = (from item in query
                     where ((item.Provider == provider) || (provider == string.Empty ))
                     && ( keyWord==string.Empty || (item.InputCode1.StartsWith(keyWord)) )
                     && item.EventTime >= startTime
                     && item.EventTime <= endTime
                     orderby item.EventTime descending
                     select item);

            return p.ToList();
        }

        public List<SBack> GetDrugCustomBackList(string keyWord, DateTime startTime, DateTime endTime)
        {
            DataEntityQuery<SBack> query = DataEntityQuery<SBack>.Create();

            var p = (from item in query
                     where  (keyWord == string.Empty || (item.InputCode1.StartsWith(keyWord)))
                     && item.EventTime >= startTime
                     && item.EventTime <= endTime
                     orderby item.EventTime descending
                     select item);

            return p.ToList();
        }

        public List<SBack> GetDrugCustomBackList(string customName, string keyWord, DateTime startTime, DateTime endTime)
        {
            DataEntityQuery<SBack> query = DataEntityQuery<SBack>.Create();

            var p = (from item in query
                     where (customName == string.Empty || (item.Customname==customName))
                     && (keyWord == string.Empty || (item.InputCode1.StartsWith(keyWord)))
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
            pc.Add("ITEMKEY", "DRUGBACKPROVIDERBILLCODE");

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

        public void DrugBackSave(IList<Store> updateStoreList, IList<PBack> providerBackList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalSave), updateStoreList, providerBackList);
        }

        public void IniternalSave(IDataAccessor accessor, params object[] parameters)
        {
            IList<Store> DrugStoreList = parameters[0] as IList<Store>;
            IList<PBack> DrugProviderBackList = parameters[1] as IList<PBack>;

            DateTime currentTime = new DateTimeService().GetCurrentTime();

            foreach (PBack drugProviderBack in DrugProviderBackList)
            {
                drugProviderBack.EventTime = currentTime;
                drugProviderBack.Insert();
            }

            foreach (Store drugStore in DrugStoreList)
            {
                drugStore.Save();
            }
        }

        #endregion

        #region 保存

        public void DrugBackSave(IList<Store> updateStoreList, IList<SBack> customBackList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalCustomSave), updateStoreList, customBackList);
        }

        public void IniternalCustomSave(IDataAccessor accessor, params object[] parameters)
        {
            IList<Store> DrugStoreList = parameters[0] as IList<Store>;
            IList<SBack> DrugCustomBackList = parameters[1] as IList<SBack>;

            DateTime currentTime = new DateTimeService().GetCurrentTime();

            foreach (SBack drugProviderBack in DrugCustomBackList)
            {
                drugProviderBack.EventTime = currentTime;
                drugProviderBack.Insert();
            }

            foreach (Store drugStore in DrugStoreList)
            {
                drugStore.Save();
            }
        }

        #endregion

        #region IDrugBackService 成员

        public int GetPBackMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PBack().DbTableName);
        }

        public int GetSBackMaxID()
        {
            return new MaxCodeService().GetMaxCode(new SBack().DbTableName);
        }

        #endregion
    }
}
