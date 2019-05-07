using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrugShop.WinUI.RDL
{
    class RDLHelper
    {
        internal static string GetRDLDefine(string name)
        {
            return RDLResource.ResourceManager.GetString(name, RDLResource.Culture);
        }
    }
}
