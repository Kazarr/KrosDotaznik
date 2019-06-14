using Data.Registers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class JobSpecificationData
    {
        public int Id { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndOfTrial { get; set; }
        public string WorkPlace { get; set; }

        public int WorkExpiration { get; set; }
        public int Department { get; set; }
        public int WorkType { get; set; }
        public int WorkHours { get; set; }
        public int WorkPosition { get; set; }
    }
}
