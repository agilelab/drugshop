using System;
using System.Collections.Generic;
using System.Text;
using EAS.Explorer.Entities;
using EAS.Services;
using EAS.Explorer;
using System.Linq;

namespace DrugShop.Res
{
    class NavigationProxy
    {
        /// <summary>
        /// 导航信息。
        /// </summary>
        public IList<INavigateGroup> GroupList
        {
            get;
            set;
        }

        /// <summary>
        /// 模块信息。
        /// </summary>
        public IList<INavigateModule> ModuleList
        {
            get;
            set;
        }

        /// <summary>
        /// 查一级分组。
        /// </summary>
        /// <returns></returns>
        public IList<INavigateGroup> GetGroupList()
        {
            Dictionary<string, int> gms = new Dictionary<string, int>();
            foreach (INavigateGroup var in this.GroupList)
                gms.Add(var.ID, 0);

            foreach (INavigateGroup var in this.ModuleList)
            {
                gms[var.ID] += 1;
            }

            IList<INavigateGroup> List = new List<INavigateGroup>();
            foreach (NavigateGroup var in this.GroupList)
            {
                if (gms[var.ID] > 0)
                    List.Add(var);
            }

            return List;
        }

        /// <summary>
        /// 查下载分组。
        /// </summary>
        /// <param name="parentID"></param>
        /// <returns></returns>
        public IList<INavigateGroup> GetGroupList(string parentID)
        {
            if (string.IsNullOrEmpty(parentID) || parentID == Guid.Empty.ToString())
            {
                return this.GroupList.Where(p => string.IsNullOrEmpty(p.ParentID) || p.ParentID == Guid.Empty.ToString()).ToList();
            }
            else
            {
                return this.GroupList.Where(p => p.ParentID == parentID).ToList();
            }
        }

        /// <summary>
        /// 查询导航模块。
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public IList<INavigateModule> GetModuleList(string groupID)
        {
            if (string.IsNullOrEmpty(groupID) || groupID == Guid.Empty.ToString())
            {
                return this.ModuleList.Where(p => string.IsNullOrEmpty(p.GroupID) || p.GroupID == Guid.Empty.ToString()).ToList();
            }
            else
            {
                return this.ModuleList.Where(p => p.GroupID == groupID).ToList();
            }
        }

        /// <summary>
        /// 查询导航模块/包含下级模块。
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public IList<INavigateModule> GetAllModuleList(string groupID)
        {
            IList<INavigateModule> vList = this.GetModuleList(groupID);
            IList<INavigateGroup> subList = this.GetGroupList(groupID);

            foreach (var item in subList)
            {
                var v2 = this.GetModuleList(groupID);
                foreach (var item2 in v2)
                {
                    vList.Add(item2);
                }
            }

            return vList.Distinct().ToList();
        }
    }
}
