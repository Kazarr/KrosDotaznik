using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class DepartmentRepository:MainRepository
    {
        public Dictionary<int, string> GetDepartmentData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.DepartmentSelect, cultureInfo);
        }
    }
}
