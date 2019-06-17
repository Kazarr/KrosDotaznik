using Data.Registers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class JobSpecification
    {
        public int Id { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndOfTrial { get; set; }
        public string WorkPlace { get; set; }

        public WorkExpiration WorkExpiration { get; set; }
        public Department Department { get; set; }
        public WorkType WorkType { get; set; }
        public WorkHours WorkHours { get; set; }
        public WorkPosition WorkPosition { get; set; }
    }
}
