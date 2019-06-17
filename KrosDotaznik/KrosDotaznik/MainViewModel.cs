using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace KrosDotaznik
{
    public class MainViewModel
    {
        public void OpenQuestionnaireToFill()
        {
            using (FrmQuestionnaireToFill toFill = new FrmQuestionnaireToFill())
            {
                toFill.ShowDialog();
            }
        }

        public void SetLOcalization(string language)
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo(language);
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo(language);
        }

        public void SaveTest()
        {
            FileService fs = new FileService();
            fs.SaveJson(new Employee()
            {
                Name = "Miro",
                Surname = "Valo",
                Title = "Ing.",
                BirthDate = new DateTime(1992, 11, 26),
                Gender = true,
                BankAccountNumber = 123456798,
                State = new Data.Registers.State() { Id = 1, Name = "Married" },
                HealthInsuranceCompany = new Data.Registers.HealthInsurance() { Name = "Generali" },
                AddressData = new Address() { City = "Zilina", PostalCode = 01001, Street = "Varin", HouseNumber = "50/5" },
                AccessData = new Access() { PayPassword = "nbu123", PinAlarm = 020508 },
                HighEducationData = new Education() { EducationLevel = new Data.Registers.EducationalLevel() { Name = "Bachelor" }, EndYear = new DateTime(2000, 10, 15), Major = "Informatics", School = "Fri" },
                PreviousJobData = new PreviousJob() { Position = "Upratovac", Employer = "Upratovacia Cata", StartDate = new DateTime(1995, 5, 3), EndDate = new DateTime(2015, 8, 12) },
                JobSpecificationData = new JobSpecification()
                {
                    HireDate = new DateTime(2018, 1, 1),
                    StartDate = new DateTime(2018, 1, 2),
                    EndOfTrial = new DateTime(2018, 3, 1),
                    Department = new Data.Registers.Department() { Name = "4.1", ParentId = 4 },
                    WorkExpiration = new Data.Registers.WorkExpiration() { Name = "Unlimited" },
                    WorkHours = new Data.Registers.WorkHours() { Name = "FullTime" },
                    WorkType = new Data.Registers.WorkType() { Name = "Employment" },
                    WorkPosition = new Data.Registers.WorkPosition() { Position = "programator", WageCategory = new Data.Registers.WageCategory() { Name = "A" } },
                    WorkPlace = "Zilina",

                },
                Children = new List<Child>() { new Child() { Name = "Jozko", Surname = "Mrkvicka", Bonus = true,BirthDate = new DateTime(2000,4,1) }, new Child() { Name = "Ferko", Surname = "Mrkvicka", Bonus = true, BirthDate = new DateTime(2005,7,5)} }
            }, @"c:\Users\kardos\source\repos\KrosDotaznik\KrosDotaznik\KrosDotaznik\bin\Debug\test.json");
        }
    }
}
