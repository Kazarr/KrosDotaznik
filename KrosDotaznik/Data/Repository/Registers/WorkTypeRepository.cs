using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class WorkTypeRepository:MainRepository
    {
        public Dictionary<int, string> GetWorkTypeData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.WorkTypeSelect, cultureInfo);
        }
    }
}
