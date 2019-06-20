using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
