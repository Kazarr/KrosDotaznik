using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class WorkPositionRepository:MainRepository
    {
        public Dictionary<int, string> GetWorkPositionData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.WorkPositionSelect, cultureInfo);
        }
    }
}
