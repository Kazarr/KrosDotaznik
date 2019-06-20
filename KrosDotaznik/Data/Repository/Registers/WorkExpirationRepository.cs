using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class WorkExpirationRepository:MainRepository
    {
        public Dictionary<int, string> GetWorkExpirationData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.WorkExpirationSelect, cultureInfo);
        }
    }
}
