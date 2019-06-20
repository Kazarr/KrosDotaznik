using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
