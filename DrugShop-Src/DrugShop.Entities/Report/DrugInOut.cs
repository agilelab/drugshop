using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EAS.Data.ORM;

namespace DrugShop.Entities
{
     public partial class DrugInOut : DataEntity<DrugInOut>
    {
        /// <summary>
        /// 药品类型名称 。
        /// </summary>
        [Column("DRUGTYPENAME", "药品类型名称")]
        public string DrugTypeName
        {
            get
            {
                return this.GetValue<string>("DRUGTYPENAME");
            }
            set
            {
                this["DRUGTYPENAME"] = value;
            }
        }
    }
}
