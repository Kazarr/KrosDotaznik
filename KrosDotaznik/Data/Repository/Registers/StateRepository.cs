using System.Collections.Generic;

namespace Data.Repository.Registers
{
    public class StateRepository:MainRepository
    {
        public Dictionary<int, string> GetAllState(string cultureInfo)
        {
            return GetAllAccessData<int, string>(Properties.ResourceAccess.StateSelect, cultureInfo);
        }
    }
}
