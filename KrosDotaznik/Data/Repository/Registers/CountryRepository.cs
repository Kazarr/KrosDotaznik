using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class CountryRepository:ConnectionManager
    {
        public Dictionary<TKey, TValue> GetCountryData<TKey, TValue>(string cultureInfo)
        {
            return GetAllAccessData<TKey, TValue>(Properties.ResourceAccess.CountrySelect, cultureInfo);
        }
    }
}
