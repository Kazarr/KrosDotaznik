using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class DivisionRepository:MainRepository
    {
        public Dictionary<int, string> GetDivisionData(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.DivisionSelect, cultureInfo);
        }
    }
}
