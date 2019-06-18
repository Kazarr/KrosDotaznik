﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Registers
{
    public class EducationLevelRepository:ConnectionManager
    {
        public Dictionary<TKey, TValue> GetEducationLevelData<TKey, TValue>(string cultureInfo)
        {
            return GetAllAccessData<TKey, TValue>(Properties.ResourceAccess.EducationLevelSelect, cultureInfo);
        }
    }
}
