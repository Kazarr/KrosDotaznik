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

        public int IdWorkExpiration { get; set; }
        public int IdDepartment { get; set; }
        public int IdWorkType { get; set; }
        public int IdWorkHours { get; set; }
        public int IdWorkPosition { get; set; }
    }
}
