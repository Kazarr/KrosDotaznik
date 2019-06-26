using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class HealthInsuranceRepository:MainRepository
    {
        public Dictionary<int,string> GetHealthInsuranceData(string cultureInfo)
        {
            return GetAllAccessData<int,string>(Properties.ResourceAccess.HealthInsuranceSelect,cultureInfo);            
        }
    }
}
