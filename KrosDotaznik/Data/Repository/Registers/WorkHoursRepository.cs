using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class WorkHoursRepository:ConnectionManager
    {
        public Dictionary<TKey, TValue> GetWorkHoursData<TKey, TValue>(string cultureInfo)
        {
            return GetAllAccessData<TKey, TValue>(Properties.ResourceAccess.WorkHoursSelect, cultureInfo);
        }
    }
}
