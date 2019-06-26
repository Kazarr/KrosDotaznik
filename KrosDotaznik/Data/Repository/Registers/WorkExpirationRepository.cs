using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class WorkExpirationRepository:MainRepository
    {
        public Dictionary<int, string> GetWorkExpirationData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.WorkExpirationSelect, cultureInfo);
        }
    }
}
