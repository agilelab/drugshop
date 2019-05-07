using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Modularization;
using System.Reflection;

namespace DrugShop.Res
{
    class MetaHelper
    {
        public static string GetTypeString(Type type)
        {
            return type.ToString();
        }

        public static string GetAssemblyString(Type type)
        {
            return Assembly.GetAssembly(type).GetName().Name;
        }

        public static string GetVersionString(Type type)
        {
            return Assembly.GetAssembly(type).GetName().Version.ToString();
        }

        public static string GetDeveloperString(Type type)
        {
            try
            {
                AssemblyCompanyAttribute aca = type.Assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), true)[0] as AssemblyCompanyAttribute;

                if (aca != null)
                {
                    return aca.Company;
                }
                else
                {
                    return "AgileLab.cn";
                }
            }
            catch
            {
                return "AgileLab.cn";
            }
        }

        public static string GetModuleGuid(Type type)
        {
            AddInAttribute ma = Attribute.GetCustomAttribute(type, typeof(AddInAttribute)) as AddInAttribute;
            if (!Object.Equals(null, ma))
            {
                return ma.Guid;
            }
            else
                return string.Empty;
        }

        public static string GetModuleName(Type type)
        {
            AddInAttribute ma = Attribute.GetCustomAttribute(type, typeof(AddInAttribute)) as AddInAttribute;
            if (!Object.Equals(null, ma))
            {
                return ma.Name;
            }
            else
                return string.Empty;
        }

        public static string GetModuleDescription(Type type)
        {
            AddInAttribute ma = Attribute.GetCustomAttribute(type, typeof(AddInAttribute)) as AddInAttribute;
            if (!Object.Equals(null, ma))
            {
                return ma.Description;
            }
            else
                return string.Empty;
        }

        public static string GetModuleName(object module)
        {
            if (module is IAddIn)
                return (module as IAddIn).Name;
            else
            {
                return GetModuleName(module.GetType());
            }
        }
    }
}
