using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class WorkPositionRepository:MainRepository
    {
        public Dictionary<int, string> GetWorkPositionData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.WorkPositionSelect, cultureInfo);
        }
    }
}
