using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class RetirementRepository:MainRepository
    {
        public Dictionary<int, string> GetRetirementData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.RetirementSelect, cultureInfo);            
        }
    }
}
