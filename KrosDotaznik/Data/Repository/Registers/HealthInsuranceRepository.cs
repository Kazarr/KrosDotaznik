using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class HealthInsuranceRepository:MainRepository
    {
        public Dictionary<int,string> GetHealthInsuranceData(string cultureInfo)
        {
            return GetAllAccessData<int,string>(Properties.ResourceAccess.HealthInsuranceSelect,cultureInfo);            
        }
    }
}
