using System;
using EAS.Data.Access;
using EAS.Data.ORM;

namespace DrugShop.Entities
{
    /// <summary>
    /// 实体对象 Account(系统账户)。
    /// </summary>
    public partial class Account : DataEntity<Account>
    {
        public bool IsLocked
        {
            get
            {
                return (this.Attributes & 0x0010) == 0x0010;
            }
        }

        public bool IsDisabled
        {
            get
            {
                return (this.Attributes & 0x0008) == 0x0008;
            }
        }

        /// <summary>
        /// 虚拟 。
        /// </summary>
        [Column("VirtualID", "虚拟"),Virtual]
        public string VirtualID
        {
            get
            {
                return this.GetValue<string>("VirtualID");
            }
            set
            {
                this["VirtualID"] = value;
            }
        }
    }
}
