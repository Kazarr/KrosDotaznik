using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class RetirementRepository:MainRepository
    {
        public Dictionary<int, string> GetRetirementData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.RetirementSelect, cultureInfo);            
        }
    }
}
