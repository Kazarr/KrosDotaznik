using System.Collections.Generic;

namespace Data.Models
{
    public class Questionare 
    {
        public Dictionary<int, bool> ShowQuestionGroups { get; set;}
        public Employee Employee { get; set; }
    }
}
