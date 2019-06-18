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
        /// <summary>
        /// Testing method to test correctness and see output json
        /// </summary>
        public void SaveTest()
        {
            FileService fs = new FileService();
            fs.SaveJson(
                new Questionare()
                {
                    ShowQuestionGroups = new bool[10],
                    Employee = new Employee()
                    {
                        Name = "Miro",
                        Surname = "Valo",
                        Title = "Ing.",
                        BirthDate = new DateTime(1992, 11, 26),
                        Gender = true,
                        BankAccountNumber = "123456798",
                        State = new Data.Models.Registers.State() { Id = 1, EmployeeState = "Married" },
                        HealthInsuranceCompany = new Data.Models.Registers.HealthInsurance() { CompanyName = "Generali" },
                        AddressData = new Address() { City = "Zilina", PostalCode = 01001, Street = "Varin", HouseNumber = "50/5" },
                        Credentials = new Credentials() { PaycheckPassword = fs.Encrypt("nbu123"), PinAlarm = fs.Encrypt("123456") },
                        HighestEducationData = new Education() { EducationLevel = new Data.Models.Registers.EducationLevel() { EducationLevelName = "Bachelor" }, EndYear = new DateTime(2000, 10, 15), Major = "Informatics", School = "Fri" },
                        PreviousJobData = new PreviousJob() { Position = "Upratovac", EmployerCompanyName = "Upratovacia Cata", StartDate = new DateTime(1995, 5, 3), EndDate = new DateTime(2015, 8, 12) },
                        JobSpecificationData = new JobSpecification()
                        {
                            HireDate = new DateTime(2018, 1, 1),
                            StartDate = new DateTime(2018, 1, 2),
                            EndOfTrial = new DateTime(2018, 3, 1),
                            Department = new Data.Models.Registers.Department() { DepartmentName = "4.1", ParentId = 4 },
                            WorkExpiration = new Data.Models.Registers.WorkExpiration() { JobExpire = "Unlimited" },
                            WorkHours = new Data.Models.Registers.WorkHours() { NameOfHoursPerWeek = "FullTime" },
                            WorkType = new Data.Models.Registers.WorkType() { Type = "Employment" },
                            WorkPosition = new Data.Models.Registers.WorkPosition() { Position = "programator", WageCategory = new Data.Models.Registers.WageCategory() { Category = "A" } },
                            WorkPlace = "Zilina",

                        },
                        Children = new List<Child>() { new Child() { Name = "Jozko", Surname = "Mrkvicka", Bonus = true, BirthDate = new DateTime(2000, 4, 1) }, new Child() { Name = "Ferko", Surname = "Mrkvicka", Bonus = true, BirthDate = new DateTime(2005, 7, 5) } }
                    }
                }, "test.json");
        }
        /// <summary>
        /// Testing method. Testing correctness.
        /// </summary>
        /// <returns></returns>
        public Questionare LoadTest()
        {
            FileService fs = new FileService();
            return fs.LoadJson<Questionare>("test.json");
        }
    }
}
