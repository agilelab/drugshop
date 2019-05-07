using System;
namespace DrugShop.BLL
{
    public interface IDateTimeService
    {
        DateTime GetCurrentTime();

        DateTime GetMinTime();
    }
}
