using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class WageCategoryRepository:MainRepository
    {
        public Dictionary<int, string> GetWageCategoryData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.WageCategorySelect, cultureInfo);
        }
    }
}
