﻿using System;

namespace Data.Models.Registers
{
    public class RetirementData
    {
        public int Id { get; set; }
        public bool ParticipatingInRetirementSaving { get; set; }
        public DateTime? RetiredSince { get; set; } = DateTime.Now;
        /// <summary>
        /// Only contranct work type should set this.
        /// </summary>
        public bool RetirementInsuranceCompanyException { get; set; }
        public Retirement Retirement { get; set; }
    }
}
