using System;
using System.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using System.Runtime.Serialization;

namespace DrugShop.Entities
{
    /// <summary>
    /// 收支报表
    /// </summary>
    [Serializable()]
    [Table(""), Index]
    partial class DrugInOut : DataEntity<DrugInOut>
    {
        public DrugInOut()
        {
        }

        protected DrugInOut(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #region O/R映射成员

        /// <summary>
        /// 起初值 。
        /// </summary>
        [Column("STARTAMOUNT", "起初值")]
        public decimal StartAmount
        {
            get
            {
                return this.GetValue<decimal>("STARTAMOUNT");
            }
            set
            {
                this["STARTAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 采购值 。
        /// </summary>
        [Column("BUYAMOUNT", "采购值")]
        public decimal BuyAmount
        {
            get
            {
                return this.GetValue<decimal>("BUYAMOUNT");
            }
            set
            {
                this["BUYAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 药品类型 。
        /// </summary>
        [Column("DRUGTYPE", "药品类型")]
        public int DrugType
        {
            get
            {
                return this.GetValue<int>("DRUGTYPE");
            }
            set
            {
                this["DRUGTYPE"] = value;
            }
        }

        /// <summary>
        /// 顾客退药 。
        /// </summary>
        [Column("CUSTOMBACKAMOUNT", "顾客退药")]
        public decimal CustomBackAmount
        {
            get
            {
                return this.GetValue<decimal>("CUSTOMBACKAMOUNT");
            }
            set
            {
                this["CUSTOMBACKAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 供应商退药 。
        /// </summary>
        [Column("PROVIDERBACKAMOUNT", "供应商退药")]
        public decimal ProviderBackAmount
        {
            get
            {
                return this.GetValue<decimal>("PROVIDERBACKAMOUNT");
            }
            set
            {
                this["PROVIDERBACKAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 调价影响金额 。
        /// </summary>
        [Column("CHANGEPRICEAMOUNT", "调价差值")]
        public decimal ChangePriceAmount
        {
            get
            {
                return this.GetValue<decimal>("CHANGEPRICEAMOUNT");
            }
            set
            {
                this["CHANGEPRICEAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 出库金额 。
        /// </summary>
        [Column("OUTAMOUNT", "出库金额")]
        public decimal OutAmount
        {
            get
            {
                return this.GetValue<decimal>("OUTAMOUNT");
            }
            set
            {
                this["OUTAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 报损金额 。
        /// </summary>
        [Column("LOSTAMOUNT", "报损金额")]
        public decimal LostAmount
        {
            get
            {
                return this.GetValue<decimal>("LOSTAMOUNT");
            }
            set
            {
                this["LOSTAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 盘盈金额 。
        /// </summary>
        [Column("YAMOUNT", "盘盈")]
        public decimal YAmount
        {
            get
            {
                return this.GetValue<decimal>("YAMOUNT");
            }
            set
            {
                this["YAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 盘亏金额 。
        /// </summary>
        [Column("KAMOUNT", "盘亏")]
        public decimal KAmount
        {
            get
            {
                return this.GetValue<decimal>("KAMOUNT");
            }
            set
            {
                this["KAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 期末金额 。
        /// </summary>
        [Column("ENDAMOUNT", "期末值")]
        public decimal EndAmount
        {
            get
            {
                return this.GetValue<decimal>("ENDAMOUNT");
            }
            set
            {
                this["ENDAMOUNT"] = value;
            }
        }

        /// <summary>
        /// 起始日期 。
        /// </summary>
        [Column("STARTDATE", "起始日期")]
        public DateTime StartDate
        {
            get
            {
                return this.GetValue<DateTime>("STARTDATE");
            }
            set
            {
                this["STARTDATE"] = value;
            }
        }

        /// <summary>
        /// 结束日期 。
        /// </summary>
        [Column("ENDDATE", "结束日期")]
        public DateTime EndDate
        {
            get
            {
                return this.GetValue<DateTime>("ENDDATE");
            }
            set
            {
                this["ENDDATE"] = value;
            }
        }

        #endregion
    }
}
