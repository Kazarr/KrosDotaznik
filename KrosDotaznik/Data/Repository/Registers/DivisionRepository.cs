using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class DivisionRepository:MainRepository
    {
        public Dictionary<int, string> GetDivisionData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess., cultureInfo);
        }
    }
}
