using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class WorkTypeRepository:MainRepository
    {
        public Dictionary<int, string> GetWorkTypeData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.WorkTypeSelect, cultureInfo);
        }
    }
}
