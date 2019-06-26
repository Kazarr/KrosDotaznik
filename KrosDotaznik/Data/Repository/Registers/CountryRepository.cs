using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class CountryRepository:MainRepository
    {
        public Dictionary<int, string> GetCountryData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.CountrySelect, cultureInfo);
        }
    }
}
