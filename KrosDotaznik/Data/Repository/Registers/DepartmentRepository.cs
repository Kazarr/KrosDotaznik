using System.Collections.Generic;

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
