using Data.Models.Registers;
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
        public DateTime HireDate { get; set; } = DateTime.Now;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndOfTrial { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public string WorkPlace { get; set; }
        public decimal Salary { get; set; }


        /// <summary>
        /// When your contract expire. Unlimitet or will expire
        /// </summary>
        public WorkExpiration WorkExpiration { get; set; }
        public Department Department { get; set; }
        public Division Division { get; set; }
        /// <summary>
        /// Employment, Contract, WorkForHire...
        /// </summary>
        public WorkType WorkType { get; set; }
        /// <summary>
        /// How many hours per week and name of HoursPerWeek
        /// </summary>
        public WorkHours WorkHours { get; set; }
        public WorkPosition WorkPosition { get; set; }
    }
}
