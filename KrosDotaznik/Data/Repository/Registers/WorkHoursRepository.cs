using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class WorkHoursRepository:MainRepository
    {
        public Dictionary<int, string> GetWorkHoursData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.WorkHoursSelect, cultureInfo);
        }
    }
}
