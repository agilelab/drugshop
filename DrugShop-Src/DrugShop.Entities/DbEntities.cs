using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using EAS.Data.Linq;

namespace DrugShop.Entities
{
   /// <summary>
   /// 数据上下文。
   /// </summary>
   public class DbEntities:DataContext
   {
        #region 字段定义

        private DataEntityQuery<Dict> m_Dicts;
        private DataEntityQuery<SBack> m_SBacks;
        private DataEntityQuery<Inventory> m_Inventorys;
        private DataEntityQuery<CPrice> m_CPrices;
        private DataEntityQuery<PIn> m_PIns;
        private DataEntityQuery<Lost> m_Losts;
        private DataEntityQuery<SOut> m_SOuts;
        private DataEntityQuery<PBack> m_PBacks;
        private DataEntityQuery<Plan> m_Plans;
        private DataEntityQuery<Store> m_Stores;
        private DataEntityQuery<DrugType> m_DrugTypes;
        private DataEntityQuery<Provider> m_Providers;
        #endregion

        #region 构造函数

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        public DbEntities()
        {
        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dbProvider">数据库访问程序提供者。</param>
        public DbEntities(IDbProvider dbProvider)
            : base(dbProvider)
        {

        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dataAccessor">数据访问器。</param>
        public DbEntities(IDataAccessor dataAccessor)
            : base(dataAccessor)
        {

        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dataAccessor">数据访问器。</param>
        /// <param name="ormAccessor">Orm访问器。</param>
        public DbEntities(IDataAccessor dataAccessor, IOrmAccessor ormAccessor)
            : base(dataAccessor, ormAccessor)
        {

        }

        #endregion

        #region 查询定义

        /// <summary>
        /// 药品字典。
        /// </summary>
        public DataEntityQuery<Dict> Dicts
        {
            get
            {
                if (this.m_Dicts == null)
                {
                    this.m_Dicts = base.CreateQuery<Dict>();
                }
                return this.m_Dicts;
            }
        }

        /// <summary>
        /// 销售退药。
        /// </summary>
        public DataEntityQuery<SBack> SBacks
        {
            get
            {
                if (this.m_SBacks == null)
                {
                    this.m_SBacks = base.CreateQuery<SBack>();
                }
                return this.m_SBacks;
            }
        }

        /// <summary>
        /// 盘存记录。
        /// </summary>
        public DataEntityQuery<Inventory> Inventorys
        {
            get
            {
                if (this.m_Inventorys == null)
                {
                    this.m_Inventorys = base.CreateQuery<Inventory>();
                }
                return this.m_Inventorys;
            }
        }

        /// <summary>
        /// 药品调价。
        /// </summary>
        public DataEntityQuery<CPrice> CPrices
        {
            get
            {
                if (this.m_CPrices == null)
                {
                    this.m_CPrices = base.CreateQuery<CPrice>();
                }
                return this.m_CPrices;
            }
        }

        /// <summary>
        /// 采购入库。
        /// </summary>
        public DataEntityQuery<PIn> PIns
        {
            get
            {
                if (this.m_PIns == null)
                {
                    this.m_PIns = base.CreateQuery<PIn>();
                }
                return this.m_PIns;
            }
        }

        /// <summary>
        /// 药品报损。
        /// </summary>
        public DataEntityQuery<Lost> Losts
        {
            get
            {
                if (this.m_Losts == null)
                {
                    this.m_Losts = base.CreateQuery<Lost>();
                }
                return this.m_Losts;
            }
        }

        /// <summary>
        /// 销售出库。
        /// </summary>
        public DataEntityQuery<SOut> SOuts
        {
            get
            {
                if (this.m_SOuts == null)
                {
                    this.m_SOuts = base.CreateQuery<SOut>();
                }
                return this.m_SOuts;
            }
        }

        /// <summary>
        /// 供应商退货。
        /// </summary>
        public DataEntityQuery<PBack> PBacks
        {
            get
            {
                if (this.m_PBacks == null)
                {
                    this.m_PBacks = base.CreateQuery<PBack>();
                }
                return this.m_PBacks;
            }
        }

        /// <summary>
        /// 采购计划。
        /// </summary>
        public DataEntityQuery<Plan> Plans
        {
            get
            {
                if (this.m_Plans == null)
                {
                    this.m_Plans = base.CreateQuery<Plan>();
                }
                return this.m_Plans;
            }
        }

        /// <summary>
        /// 药品库存。
        /// </summary>
        public DataEntityQuery<Store> Stores
        {
            get
            {
                if (this.m_Stores == null)
                {
                    this.m_Stores = base.CreateQuery<Store>();
                }
                return this.m_Stores;
            }
        }

        /// <summary>
        /// 基础编码。
        /// </summary>
        public DataEntityQuery<DrugType> DrugTypes
        {
            get
            {
                if (this.m_DrugTypes == null)
                {
                    this.m_DrugTypes = base.CreateQuery<DrugType>();
                }
                return this.m_DrugTypes;
            }
        }

        /// <summary>
        /// 供应商。
        /// </summary>
        public DataEntityQuery<Provider> Providers
        {
            get
            {
                if (this.m_Providers == null)
                {
                    this.m_Providers = base.CreateQuery<Provider>();
                }
                return this.m_Providers;
            }
        }


        #endregion

   }
}
