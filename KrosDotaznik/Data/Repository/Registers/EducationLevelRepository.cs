using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class EducationLevelRepository:MainRepository
    {
        public Dictionary<int,string> GetEducationLevelData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.EducationLevelSelect, cultureInfo);
        }
    }
}
