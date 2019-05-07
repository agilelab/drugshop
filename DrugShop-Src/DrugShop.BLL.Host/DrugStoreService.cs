using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Data.Linq;
using EAS.Data.Access;
using EAS.Services;
using DrugShop.Entities;using EAS.Data.ORM;

namespace DrugShop.BLL
{
    [ServiceObject("药品库存服务")]
    [ServiceBind(typeof(IDrugStoreService))]
    public class DrugStoreService : BaseServiceObject, DrugShop.BLL.IDrugStoreService
    {
        public IList<Store> GetDrugList(string keyWord)
        {
            //以下代码将以默认的数据访问访问。
            DataEntityQuery<Store> query = DataEntityQuery<Store>.Create();

            var p = (from item in query
                     where (keyWord == string.Empty || item.InputCode1.StartsWith(keyWord)||item.ChinseName.StartsWith(keyWord))
                     orderby item.ChinseName ascending
                     select item);

            var x = p.ToList();

            ////以下代码将会以自宝定义访问
            //IDataAccessor da = EAS.Objects.ContainerBuilder.BuilderDefault().GetComponentInstance("DataAccessor2") as IDataAccessor;
            ////以下代码将会以自宝定义访问
            //IOrmAccessor oa = EAS.Objects.ContainerBuilder.BuilderDefault().GetComponentInstance("IOrmAccessor2") as IOrmAccessor;

            //DataEntityQuery<Store> query2 = DataEntityQuery<Store>.Create();
            //query2.OrmAccessor = oa;
            //query2.DataAccessor = da;
            //var p2 = (from item in query2
            //          where item.InputCode1.StartsWith(keyWord)
            //          orderby item.ChinseName ascending
            //          select item);

            //x = p2.ToList();

            return x;

        }

        public IList<Store> GetDrugList(string keyWord,bool isZero)
        {
            DataEntityQuery<Store> query = DataEntityQuery<Store>.Create();

            var p = (from item in query
                     where (keyWord == string.Empty || item.InputCode1.StartsWith(keyWord))
                     && (isZero==false || item.Number==0)
                     orderby item.ChinseName ascending
                     select item);

            return p.ToList();
        }

        public IList<Store> GetDrugList(string keyWord,string provider)
        {
            DataEntityQuery<Store> query = DataEntityQuery<Store>.Create();

            //var p = (from item in query
            //         where ((item.Provider == provider.ToString()) || (provider == 0))
            //         && (keyWord == string.Empty || item.Sname.Contains(keyWord) || item.InputCode1.StartsWith(keyWord) || item.Inputcode2.StartsWith(keyWord) || item.Inputcode3.StartsWith(keyWord))
            //         && item.EventTime >= startTime
            //         && item.EventTime <= endTime
            //         orderby item.EventTime descending
            //         select item);

            //return p.ToList();

            var p = (from item in query
                     where (keyWord == string.Empty || item.InputCode1.StartsWith(keyWord))
                     && (item.Provider==string.Empty || item.Provider==provider)
                     orderby item.ChinseName ascending
                     select item);

            return p.ToList();
        }

        public IList<Store> GetDrugList(int drugType, string keyWord)
        {
            DataEntityQuery<Store> query = DataEntityQuery<Store>.Create();

            //var p = (from item in query
            //         where ((item.Provider == provider.ToString()) || (provider == 0))
            //         && (keyWord == string.Empty || item.Sname.Contains(keyWord) || item.InputCode1.StartsWith(keyWord) || item.Inputcode2.StartsWith(keyWord) || item.Inputcode3.StartsWith(keyWord))
            //         && item.EventTime >= startTime
            //         && item.EventTime <= endTime
            //         orderby item.EventTime descending
            //         select item);

            //return p.ToList();

            var p = (from item in query
                     where (item.Type==drugType || drugType==0)
                     && (keyWord == string.Empty || item.InputCode1.StartsWith(keyWord) )
                     orderby item.ChinseName ascending
                     select item);

            return p.ToList();
        }

        public IList<Store> GetDrugList(int drugType, string keyWord, bool isLimit)
        {
            DataEntityQuery<Store> query = DataEntityQuery<Store>.Create();

            var p = (from item in query
                     where (item.Type == drugType || item.Type==0)
                     && (keyWord == string.Empty || item.InputCode1.StartsWith(keyWord))
                     && (isLimit==false || item.Number>=item.DownLimit) 
                     && (isLimit==false || item.Number<=item.UpLimit)
                     orderby item.ChinseName ascending
                     select item);

            return p.ToList();
        }

        public IList<Store> GetDrugList(int drugType, string keyWord, bool isLost,int days)
        {
            DataEntityQuery<Store> query = DataEntityQuery<Store>.Create();

            DateTime currentTime = DateTime.Now.AddDays(days);

            var p = (from item in query
                     where (item.Type == drugType || drugType == 0)
                     && (keyWord == string.Empty || item.InputCode1.StartsWith(keyWord))
                     && (isLost == false || (item.TimeLimit <DateTime.Now))
                     && (days==0 || (item.TimeLimit<=currentTime && item.TimeLimit>=DateTime.Now))
                     orderby item.ChinseName ascending
                     select item);

            return p.ToList();
        }

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

        #region 批量删除

        public void DrugStoreDelete(IList<Store> DrugStoreDeleteList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.InternalDrugStoreDelete), DrugStoreDeleteList);
        }

        internal void InternalDrugStoreDelete(IDataAccessor Accessor, params object[] parameters)
        {
            IList<Store> DrugStoreDeleteList = parameters[0] as IList<Store>;

            foreach (Store drugStore in DrugStoreDeleteList)
            {
                drugStore.Delete();
            }
        }

        #endregion

        #region IMaxID 成员

        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new Store().DbTableName);
        }

        #endregion

        #region IDrugStoreService 成员


        public Store GetDrugStore(string code, string DrugID, string ChinseName, string spec, DateTime TimeLimit)
        {
            DataEntityQuery<Store> query = DataEntityQuery<Store>.Create();

            var v = (from item in query
                             where (item.Code == code || code == string.Empty)
                             && (item.ChinseName == ChinseName || ChinseName == string.Empty)
                             && (item.Spec == spec || spec == string.Empty)
                             && item.TimeLimit == TimeLimit
                             && (item.DrugID == DrugID || DrugID == string.Empty)
                             select item
                        );

            return v.FirstOrDefault();
        }

        #endregion
    }
}
