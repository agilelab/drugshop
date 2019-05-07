using System;
using System.Collections.Generic;
using DrugShop.Entities;using EAS.Data.ORM;
namespace DrugShop.BLL
{
    public interface IDrugTypeService:IMaxID
    {
        int GetMaxCode();

        IList<DrugType> GetDrugTypeList();
    }
}
