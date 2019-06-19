using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class RetirementRepository:ConnectionManager
    {
        public Dictionary<TKey, TValue> GetRetirementData<TKey, TValue>(string cultureInfo)
        {
            return GetAllAccessData<TKey, TValue>(Properties.ResourceAccess.RetirementSelect, cultureInfo);            
        }
    }
}
