using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class WageCategoryRepository:MainRepository
    {
        public Dictionary<int, string> GetWageCategoryData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.WageCategorySelect, cultureInfo);
        }
    }
}
