using System.Collections.Generic;

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
