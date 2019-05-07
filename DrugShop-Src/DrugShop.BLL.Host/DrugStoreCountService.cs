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
    [ServiceObject("药品盘存服务")]
    [ServiceBind(typeof(IDrugStoreCountService))]
     public class DrugStoreCountService : BaseServiceObject, DrugShop.BLL.IDrugStoreCountService
    {
         public IList<Inventory> GetDrugStoreCountList(string keyWord, DateTime EventTime)
         {
             DataEntityQuery<Inventory> query = DataEntityQuery<Inventory>.Create();

             var p = (from item in query
                      where (keyWord == string.Empty || item.InputCode1.StartsWith(keyWord))
                      && item.EventTime==EventTime
                      orderby item.ChinseName ascending
                      select item);

             return p.ToList();
         }

         public IList<object> GetDrugStoreCountDateList()
         {
             string SQLText = "SELECT DISTINCT EventTime FROM DS_Inventory ";

             IList<object> objList = this.DataAccessor.QueryList(SQLText);

             return objList;
         }

         public IList<Inventory> GetDrugStoreCountList(int chiPing, DateTime EventTime)
         {
             DataEntityQuery<Inventory> query = DataEntityQuery<Inventory>.Create();

             var p = (from item in query
                      where (chiPing == 1 || item.Number !=item.RealNumber)
                      && item.EventTime == EventTime
                      orderby item.ChinseName ascending
                      select item);

             return p.ToList();
         }

         public Inventory GetDrugStoreCountList(DateTime EventTime)
         {
             DataEntityQuery<Inventory> query = DataEntityQuery<Inventory>.Create();

             var p = (from item in query
                      where  item.EventTime == EventTime
                      orderby item.ChinseName ascending
                      select item);

             return p.ToList().Count > 0 ? p.ToList()[0] : null;
         }

         public bool IsNeedUpdate(DateTime EventTime)
         {
             DataEntityQuery<Inventory> query = DataEntityQuery<Inventory>.Create();

             var p = (from item in query
                      where item.EventTime == EventTime
                      && item.Number != item.RealNumber
                      orderby item.ChinseName ascending
                      select item);

             return p.ToList().Count > 0;
         }

         public IList<Inventory> GetDrugStoreCountList(DateTime startDate, DateTime endDate,string keys,int state)
         {
             DataEntityQuery<Inventory> query = DataEntityQuery<Inventory>.Create();

             var p = (from item in query
                      where item.State == state
                      && (keys==string.Empty || item.ChinseName.StartsWith(keys) || item.InputCode1.StartsWith(keys))
                      && item.EventTime <= endDate
                      && item.EventTime >= startDate
                      orderby item.ChinseName ascending
                      select item);

             return p.ToList();
         }

         #region 保存

         public void DrugStoreCountSave(IList<Inventory> DrugStoreCountList)
         {
             this.DataAccessor.TransactionExecute(new TransactionHandler2(this.InternalDrugStoreSave), DrugStoreCountList);
         }

         void InternalDrugStoreSave(IDataAccessor Accessor, params object[] parameters)
         {
             IList<Inventory> DrugStoreCountList = parameters[0] as IList<Inventory>;

             foreach (Inventory drugStoreCount in DrugStoreCountList)
             {
                 drugStoreCount.Update();
             }
         }

         public void DrugStoreCountAdjust(IList<Inventory> DrugStoreCountList)
         {
             this.DataAccessor.TransactionExecute(new TransactionHandler2(this.InternalDrugStoreAdjust), DrugStoreCountList);
         }

         void InternalDrugStoreAdjust(IDataAccessor Accessor, params object[] parameters)
         {
             IList<Inventory> DrugStoreCountList = parameters[0] as IList<Inventory>;

             foreach (Inventory drugStoreCount in DrugStoreCountList)
             {
                 drugStoreCount.State = 1;
                 drugStoreCount.Update();
             }
         }
         #endregion

        #region 收支报表

         public IList<DrugInOut> GetDrugInOutList(DateTime startDate,DateTime endDate)
         {
             IList<DrugInOut> list = new List<DrugInOut>();

             IList<DrugType> codeList = EAS.Services.ServiceContainer.GetService<DrugShop.BLL.DrugTypeService>().GetDrugTypeList();

            foreach (DrugType drugType in codeList)
            {
                DrugInOut drugInOut = new Entities.DrugInOut();

                drugInOut.DrugType = drugType.Code;
                drugInOut.DrugTypeName = drugType.Name;
                drugInOut.StartDate = startDate;
                drugInOut.EndDate = endDate;

                list.Add(drugInOut);
            }

             #region 1、计算起初值

             string sqlText= String.Format(@" SELECT TYPE DRUGTYPE,SUM(SalePrice*NUMBER) STARTAMOUNT from DS_Inventory  WHERE EventTime>='{0}' AND EventTime<='{1}'   GROUP BY TYPE ",startDate,endDate);

             System.Data.DataTable dt= this.DataAccessor.QueryDataTable(sqlText);

             if (dt.Rows.Count > 0)
             {
                 System.Data.DataRow[] rows = null;
                 decimal outValue = 0M;

                 foreach (DrugInOut drugInOut in list)
                 {
                     rows = dt.Select(string.Format("DRUGTYPE={0}", drugInOut.DrugType));

                     if (rows.Length == 0)
                     {
                         continue;
                     }

                     decimal.TryParse(rows[0]["STARTAMOUNT"].ToString(), out outValue);

                     drugInOut.StartAmount = outValue;
                 }
             }

             #endregion

             #region  2、计算入库值

             sqlText = String.Format(@" SELECT TYPE DRUGTYPE,SUM(SalePrice*NUMBER) BUYAMOUNT FROM DS_PIn
 WHERE EventTime>='{0}' AND EventTime<='{1}'  GROUP BY TYPE ", startDate, endDate);

             System.Data.DataTable dtRin = this.DataAccessor.QueryDataTable(sqlText);

             if (dtRin.Rows.Count > 0)
             {
                 System.Data.DataRow[] rows = null;
                 decimal outValue = 0M;

                 foreach (DrugInOut drugInOut in list)
                 {
                     rows = dtRin.Select(string.Format("DRUGTYPE={0}", drugInOut.DrugType));

                     if (rows.Length == 0)
                     {
                         continue;
                     }

                     decimal.TryParse(rows[0]["BUYAMOUNT"].ToString(), out outValue);

                     drugInOut.BuyAmount = outValue;
                 }
             }

             #endregion

             #region  3、计算出库值

             sqlText = String.Format(@" SELECT TYPE DRUGTYPE,SUM(SalePrice*NUMBER) OUTAMOUNT FROM DS_SOut
 WHERE EventTime>='{0}' AND EventTime<='{1}'  GROUP BY TYPE ", startDate, endDate);

             System.Data.DataTable dtOut = this.DataAccessor.QueryDataTable(sqlText);

             if (dtOut.Rows.Count > 0)
             {
                 System.Data.DataRow[] rows = null;
                 decimal outValue = 0M;

                 foreach (DrugInOut drugInOut in list)
                 {
                     rows = dtOut.Select(string.Format("DRUGTYPE={0}", drugInOut.DrugType));

                     if (rows.Length == 0)
                     {
                         continue;
                     }

                     decimal.TryParse(rows[0]["OUTAMOUNT"].ToString(), out outValue);

                     drugInOut.OutAmount = outValue;
                 }
             }

             #endregion

             #region  4、计算顾客退药值

             sqlText = String.Format(@" SELECT TYPE DRUGTYPE,SUM(SalePrice*NUMBER) CUSTOMBACKAMOUNT FROM DS_SBACK  WHERE EventTime>='{0}' AND EventTime<='{1}'  GROUP BY TYPE ", startDate, endDate);

             System.Data.DataTable dtCustomBack = this.DataAccessor.QueryDataTable(sqlText);

             if (dtCustomBack.Rows.Count > 0)
             {
                 System.Data.DataRow[] rows = null;
                 decimal outValue = 0M;

                 foreach (DrugInOut drugInOut in list)
                 {
                     rows = dtCustomBack.Select(string.Format("DRUGTYPE={0}", drugInOut.DrugType));

                     if (rows.Length == 0)
                     {
                         continue;
                     }

                     decimal.TryParse(rows[0]["CUSTOMBACKAMOUNT"].ToString(), out outValue);

                     drugInOut.CustomBackAmount = outValue;
                 }
             }

             #endregion

             #region  5、计算退供应商值

             sqlText = String.Format(@" SELECT TYPE DRUGTYPE,SUM(SalePrice*NUMBER) PROVIDERBACKAMOUNT FROM DS_PBack  WHERE EventTime>='{0}' AND EventTime<='{1}'  GROUP BY TYPE ", startDate, endDate);

             System.Data.DataTable dtProviderBack = this.DataAccessor.QueryDataTable(sqlText);

             if (dtProviderBack.Rows.Count > 0)
             {
                 System.Data.DataRow[] rows = null;
                 decimal outValue = 0M;

                 foreach (DrugInOut drugInOut in list)
                 {
                     rows = dtProviderBack.Select(string.Format("DRUGTYPE={0}", drugInOut.DrugType));

                     if (rows.Length == 0)
                     {
                         continue;
                     }

                     decimal.TryParse(rows[0]["PROVIDERBACKAMOUNT"].ToString(), out outValue);

                     drugInOut.ProviderBackAmount = outValue;
                 }
             }

             #endregion

             #region  6、计算报损值

             sqlText = String.Format(@" SELECT TYPE DRUGTYPE,SUM(SalePrice*NUMBER) LOSTAMOUNT FROM DS_Lost  WHERE EventTime>='{0}' AND EventTime<='{1}'  GROUP BY TYPE ", startDate, endDate);

             System.Data.DataTable dtLost = this.DataAccessor.QueryDataTable(sqlText);

             if (dtLost.Rows.Count > 0)
             {
                 System.Data.DataRow[] rows = null;
                 decimal outValue = 0M;

                 foreach (DrugInOut drugInOut in list)
                 {
                     rows = dtLost.Select(string.Format("DRUGTYPE={0}", drugInOut.DrugType));

                     if (rows.Length == 0)
                     {
                         continue;
                     }

                     decimal.TryParse(rows[0]["LOSTAMOUNT"].ToString(), out outValue);

                     drugInOut.LostAmount = outValue;
                 }
             }

             #endregion

             #region  7、计算调价值

             sqlText = String.Format(@" SELECT TYPE DRUGTYPE,SUM(NSalePrice*NUMBER)-SUM(SalePrice*NUMBER) CHANGEPRICEAMOUNT FROM DS_CPrice  WHERE EventTime>='{0}' AND EventTime<='{1}'  GROUP BY TYPE ", startDate, endDate);

             System.Data.DataTable dtCPrice = this.DataAccessor.QueryDataTable(sqlText);

             if (dtCPrice.Rows.Count > 0)
             {
                 System.Data.DataRow[] rows = null;
                 decimal outValue = 0M;

                 foreach (DrugInOut drugInOut in list)
                 {
                     rows = dtCPrice.Select(string.Format("DRUGTYPE={0}", drugInOut.DrugType));

                     if (rows.Length == 0)
                     {
                         continue;
                     }

                     decimal.TryParse(rows[0]["CHANGEPRICEAMOUNT"].ToString(), out outValue);

                     drugInOut.ChangePriceAmount = outValue;
                 }
             }

             #endregion

             #region  8、计算盈亏值

             sqlText = String.Format(@" SELECT TYPE DRUGTYPE,SUM(SalePrice*RealNumber)-SUM(SalePrice*NUMBER)  YKAMOUNT FROM DS_Inventory  WHERE EventTime>='{0}' AND EventTime<='{1}'  GROUP BY TYPE ", startDate, endDate);

             System.Data.DataTable dtCount = this.DataAccessor.QueryDataTable(sqlText);

             if (dtCount.Rows.Count > 0)
             {
                 System.Data.DataRow[] rows = null;
                 decimal outValue = 0M;

                 foreach (DrugInOut drugInOut in list)
                 {
                     rows = dtCount.Select(string.Format("DRUGTYPE={0}", drugInOut.DrugType));

                     if (rows.Length == 0)
                     {
                         continue;
                     }

                     decimal.TryParse(rows[0]["YKAMOUNT"].ToString(), out outValue);

                     if (outValue > 0)
                     {
                         drugInOut.YAmount = outValue;//盘盈
                     }
                     else
                     {
                         drugInOut.KAmount = outValue;//盘亏
                     }
                 }
             }

             #endregion

             return list;
         }

        #endregion

        #region 盘存操作

         public void DrugStoreCount()
         {
             IList<Store> storeList = ServiceContainer.GetService<DrugStoreService>().GetDrugList("");
             DrugStoreCountInSert(storeList);
         }

         public void DrugStoreCountInSert(IList<Store> DrugStoreList)
         {
             this.DataAccessor.TransactionExecute(new TransactionHandler2(this.InternalDrugStoreInsert), DrugStoreList);
         }

         void InternalDrugStoreInsert(IDataAccessor Accessor, params object[] parameters)
         {
             IList<Store> DrugStoreList = parameters[0] as IList<Store>;

             IDrugStoreCountService service = new DrugStoreCountService();
             DateTime currentTime = new DateTimeService().GetCurrentTime();

             foreach (Store drugStore in DrugStoreList)
             {
                 Inventory drugCount = new Entities.Inventory();

                 drugCount.ChinseName = drugStore.ChinseName;
                 drugCount.Code = drugStore.Code;
                 drugCount.DownLimit = drugStore.DownLimit;
                 drugCount.DrugID = drugStore.DrugID;
                 drugCount.InputCode1 = drugStore.InputCode1;
                 drugCount.JobPrice = drugStore.JobPrice;
                 drugCount.Number = drugStore.Number;
                 drugCount.Provider = drugStore.Provider;
                 drugCount.RealNumber = drugStore.Number;
                 drugCount.SalePrice = drugStore.SalePrice;
                 drugCount.Spec = drugStore.Spec;
                 drugCount.State = 0;
                 drugCount.TimeLimit = drugStore.TimeLimit;
                 drugCount.Type = drugStore.Type;
                 drugCount.Unit = drugStore.Unit;
                 drugCount.UpLimit = drugStore.UpLimit;

                 drugCount.EventTime = currentTime;
                 drugCount.BatchID = drugStore.BatchID;

                 drugCount.ID = service.GetMaxID();

                 drugCount.Insert();
             }
         }

        #endregion

         #region IMaxID 成员

         public int GetMaxID()
         {
             return new MaxCodeService().GetMaxCode(new Inventory().DbTableName);
         }

         #endregion
    }
}
