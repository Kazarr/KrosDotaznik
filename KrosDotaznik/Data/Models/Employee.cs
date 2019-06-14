using Data.Registers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        //Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PreviousName { get; set; }
        public string MaidenName { get; set; }
        public string Title { get; set; }
        public string IdNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthNumber { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CountyOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Citizenship { get; set; }
        public bool Gender { get; set; }
        public int BankAccountNumber { get; set; }
        public string IBAN { get; set; }
        public bool ParticipatingInRetiremenSaving { get; set; }
        public bool Disabled { get; set; }
        public int? DisablitiyRate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? RetiredSince { get; set; }
        public bool? RetirementInsuranceCompanyException { get; set; }

        public State State { get; set; }
        public HealthInsurance HealthInsuranceCompany { get; set; }
        public Retirement Retirement { get; set; }

        public Address AddressData { get; set; }
        public Address TemporaryAdressDdata { get; set; }
        public Access AccessData { get; set; }
        public Education HighEducationData { get; set; }
        public Education CurrentEducationData { get; set; }
        public PreviousJob PreviousJobData { get; set; }
        public JobSpecification JobSpecificationData { get; set; }
        public List<Child> Children { get; set; }

    }
}
