using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class StateRepository:ConnectionManager
    {
        public DataTable GetAllState()
        {            
            return GetAllAccessData(Properties.ResourceAccess.StateSelect);
        }
    }
}
