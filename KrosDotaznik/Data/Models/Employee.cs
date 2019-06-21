using Data.Models.Registers;
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
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string BirthNumber { get; set; }
        public string PlaceOfBirth { get; set; }
        /// <summary>
        /// County/region of your birth
        /// </summary>
        public string CountyOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Citizenship { get; set; }
        /// <summary>
        /// True for man, false for woman
        /// </summary>
        public bool Gender { get; set; }
        public string BankAccountNumber { get; set; }
        public string IBAN { get; set; }
        public bool Disabled { get; set; }
        public int? DisabilityRate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Data of retired employees
        /// </summary>
        public RetirementData RetirementData { get; set; }
        /// <summary>
        /// Married, divorced, single...
        /// </summary>
        public State State { get; set; }
        public HealthInsurance HealthInsuranceCompany { get; set; }

        public Address AddressData { get; set; }
        public Address TemporaryAdressDdata { get; set; }
        public Credentials Credentials { get; set; }
        /// <summary>
        /// Highest educational attainment
        /// </summary>
        public Education HighestEducationData { get; set; }
        public Education CurrentEducationData { get; set; }
        public PreviousJob PreviousJobData { get; set; }
        public JobSpecification JobSpecificationData { get; set; }
        public List<Child> Children { get; set; }

        public Employee()
        {
            RetirementData = new RetirementData();
            AddressData = new Address();
            TemporaryAdressDdata = new Address();
            Credentials = new Credentials();
            HighestEducationData = new Education();
            CurrentEducationData = new Education();
            PreviousJobData = new PreviousJob();
            Children = new List<Child>();
        }
    }
}
