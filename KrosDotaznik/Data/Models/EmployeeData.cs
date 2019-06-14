using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class EmployeeData
    {
        //PK
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

        //číselníky
        public int State { get; set; }
        public int HealthInsuranceCompany { get; set; }
        public int? IdRetirement { get; set; }

        //FK
        public int IdAddressData { get; set; }
        public int? IdTemporaryAdressDdata { get; set; }
        public int IdAccessData { get; set; }
        public int IdHighEducationData { get; set; }
        public int? IdCurrentEducationData { get; set; }
        public int? IdPreviousJobData { get; set; }
        public int IdJobSpecificationData { get; set; }
    }
}
