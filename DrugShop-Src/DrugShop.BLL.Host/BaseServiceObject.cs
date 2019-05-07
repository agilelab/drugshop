using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;

namespace DrugShop.BLL
{
     public class BaseServiceObject : ServiceObject
    {
         public EAS.Data.Access.IDataAccessor DataAccessor
         {
             get
             {
                 return EAS.Context.ContextHelper.GetContext().Container.GetComponentInstance("DataAccessor") as EAS.Data.Access.IDataAccessor;
             }
         }
    }
}
