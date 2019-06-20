using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
