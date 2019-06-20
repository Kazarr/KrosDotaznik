using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Questionare 
    {
        public Dictionary<int, bool> ShowQuestionGroups { get; set;}
        public Employee Employee { get; set; }
    }
}
