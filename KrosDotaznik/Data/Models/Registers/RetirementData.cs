using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Registers
{
    public class RetirementData
    {
        public int Id { get; set; }
        public bool ParticipatingInRetirementSaving { get; set; }
        public DateTime? RetiredSince { get; set; }
        public bool? RetirementInsuranceCompanyException { get; set; }
        public Retirement Retirement { get; set; }
    }
}
