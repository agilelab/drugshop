using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using EAS.Modularization;
using EAS;
using EAS.Explorer;
using System.Windows.Forms;
using EAS.Explorer.Entities;
using EAS.Objects;

namespace DrugShop.Res
{
    class ModuleManager
    {
        public static string GetModuleName(object module)
        {
            string name = string.Empty;

            //1.读数据库
            Guid Guid = GetModuleGuid(module);
            if (Guid != Guid.Empty)
            {
                string sGuid = Guid.ToString();
                var mx = XContext.ModuleList.Where(p => p.Guid == sGuid).FirstOrDefault();
                if (mx == null)
                {
                    mx = XContext.ModuleList.Where(p => p.Guid == sGuid.ToUpper()).FirstOrDefault();
                }
                if (mx != null)
                    name = mx.Name;
            }

            if (module is EAS.Modularization.IAddIn)
                return (module as EAS.Modularization.IAddIn).Name;
            else
            {
                AddInAttribute ma = Attribute.GetCustomAttribute(module.GetType(), typeof(AddInAttribute)) as AddInAttribute;
                if (!Object.Equals(null, ma))
                {
                    name = ma.Name;
                }
                else
                    name = string.Empty;
            }

            return name;
        }        

        public static Guid GetModuleGuid(object module)
        {
            if (module is EAS.Modularization.IModule)
                return (module as EAS.Modularization.IModule).Guid;
            else
            {
                AddInAttribute ma = Attribute.GetCustomAttribute(module.GetType(), typeof(AddInAttribute)) as AddInAttribute;
                if (!Object.Equals(null, ma))
                {
                    return new Guid(ma.Guid);
                }
                else
                    return Guid.Empty;
            }
        }

        public static string GetModuleDescription(object module)
        {
            if (module is EAS.Modularization.IModule)
                return (module as EAS.Modularization.IModule).Description;
            else
            {
                AddInAttribute ma = Attribute.GetCustomAttribute(module.GetType(), typeof(AddInAttribute)) as AddInAttribute;
                if (!Object.Equals(null, ma))
                {
                    return ma.Description;
                }
                else
                    return string.Empty;
            }
        }

        /// <summary>
        /// 取得入口方法。
        /// </summary>
        /// <param name="module">模块。</param>
        /// <returns>入口方法。</returns>
        internal static MethodInfo GetRunMethod(object module)
        {
            MethodInfo[] mis = module.GetType().GetMethods();

            foreach (MethodInfo mi in mis)
            {
                ModuleStartAttribute ms = Attribute.GetCustomAttribute(mi, typeof(ModuleStartAttribute)) as ModuleStartAttribute;
                if (!Object.Equals(null, ms))
                {
                    return mi;
                }

                AddInStartAttribute mr = Attribute.GetCustomAttribute(mi, typeof(AddInStartAttribute)) as AddInStartAttribute;
                if (!Object.Equals(null, mr))
                {
                    return mi;
                }
            }

            return null;
        }

        /// <summary>
        /// 完成模块的调用。
        /// </summary>
        /// <param name="AddIn">模块。</param>
        /// <param name="shell">容器。</param>
        public static void OpenModule(object AddIn, object shell)
        {
            if (AddIn is IAddIn)
            {
                (AddIn as IAddIn).Start(shell, EAS.Application.Instance.Session.Client as IAccount, EAS.Application.Instance.Session);
            }
            else
            {
                MethodInfo mi = ModuleManager.GetRunMethod(AddIn);
                if (mi != null)
                {
                    mi.Invoke(AddIn, new object[] { });
                }
            }
        }

        /// <summary>
        /// 完成模块的调用。
        /// </summary>
        /// <param name="AddIn">模块。</param>
        /// <param name="shell">容器。</param>
        public static void StartModule(object AddIn, object shell)
        {
            try
            {
                if (AddIn is IAddIn)
                {
                    (AddIn as IAddIn).Start(shell, EAS.Application.Instance.Session.Client as IAccount, EAS.Application.Instance.Session);
                }
                else
                {
                    MethodInfo mi = ModuleManager.GetRunMethod(AddIn);
                    if (mi != null)
                    {
                        mi.Invoke(AddIn, new object[] { });
                    }
                }
            }
            catch (System.Exception exc)
            {
                MessageBox.Show("执行模块出错:" + exc.Message);
            }
        }
    }
}
