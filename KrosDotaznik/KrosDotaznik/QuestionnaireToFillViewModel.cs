using Data.Models;
using Data.Models.Registers;
using Data.Repository.Registers;
using Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrosDotaznik
{
    public class QuestionnaireToFillViewModel
    {
        #region  Fields
        private string _cultureInfo = System.Globalization.CultureInfo.CurrentCulture.ToString();

        private Employee _employee;
        private FileService _fileService = new FileService();
        private string _stringState = string.Empty;
        private string _stringHealthInsurance = string.Empty;
        private string _stringRetirement = string.Empty;
        //private string _houseNumberStreet = string.Empty;
        //private string _houseNumber = string.Empty;
        //private string _street = string.Empty;
        //private string _tempHouseNumberStreet = string.Empty;
        //private string _tempHouseNumber = string.Empty;
        //private string _tempStreet = string.Empty;
        //private string _payCheckPassword = "fero";
        private int _pinAlarm = default(int);
        private string _stringEduLevel = string.Empty;
        private string _stringCurrentEduLevel = string.Empty;

        private BindingList<Child> _children = new BindingList<Child>();
        private Dictionary<int, bool> _showQuestionGroups;

        public QuestionnaireToFillViewModel(string path)
        {
            _employee = new Employee();            
            Load(path);
            LoadCombos();
        }
        #endregion

        #region Properties

        private T SetPropertiesForCmbox<T>(Dictionary<int, string> dict, string _field)
        {
            var newModel = (T)Activator.CreateInstance(typeof(T));
            foreach (var item in dict)
            {
                if (item.Value.Equals(_field))
                {
                    typeof(T).GetProperties()[0].SetValue(newModel, item.Key);
                    typeof(T).GetProperties()[1].SetValue(newModel, item.Value);
                    return newModel;
                }
            }
            return newModel;
        }
        #region Personal Info
        public string Name 
        {
            get => _employee.Name;
            set
            {
                _employee.Name = value;
                OnPropertyChange();
            }
        }

        public string Surname
        {
            get => _employee.Surname;
            set
            {
                _employee.Surname = value;
                OnPropertyChange();
            }
        }

        public string PreviousName
        {
            get => _employee.PreviousName;
            set
            {
                _employee.PreviousName = value;
                OnPropertyChange();
            }
        }

        public string MaidenName
        {
            get => _employee.MaidenName;
            set
            {
                _employee.MaidenName = value;
                OnPropertyChange();
            }
        }

        public string Title
        {
            get => _employee.Title;
            set
            {
                _employee.Title = value;
                OnPropertyChange();
            }
        }

        public string IdentityCard
        {
            get => _employee.IdNumber;
            set
            {
                _employee.IdNumber = value;
                OnPropertyChange();
            }
        }

        public string PersonalId
        {
            get => _employee.BirthNumber;
            set
            {
                _employee.BirthNumber = value;
                OnPropertyChange();
            }
        }

        public State State
        {
            get => _employee.State;
            set
            {
                _employee.State = SetPropertiesForCmbox<State>(StateData, _stringState);
                OnPropertyChange();
            }
        }

        public string StringState
        {
            get => _stringState;
            set
            {
                _stringState = value;
                State = SetPropertiesForCmbox<State>(StateData, _stringState);
                OnPropertyChange();
            }
        }

        public DateTime BirthDate
        {
            get => _employee.BirthDate;
            set
            {
                _employee.BirthDate = value;
                OnPropertyChange();
            }
        }

        public string PlaceOfBirth
        {
            get => _employee.PlaceOfBirth;
            set
            {
                _employee.PlaceOfBirth = value;
                OnPropertyChange();
            }
        }
        public string RegionOfBirth
        {
            get => _employee.CountyOfBirth;
            set
            {
                _employee.CountyOfBirth = value;
                OnPropertyChange();
            }
        }

        public string Nationality
        {
            get => _employee.Nationality;
            set
            {
                _employee.Nationality = value;
                OnPropertyChange();
            }
        }

        public string CitizenShip
        {
            get => _employee.Citizenship;
            set
            {
                _employee.Citizenship = value;
                OnPropertyChange();
            }
        }

        public string BankAccount
        {
            get => _employee.BankAccountNumber;
            set
            {
                _employee.BankAccountNumber = value;
                OnPropertyChange();
            }
        }

        public string Iban
        {
            get => _employee.IBAN;
            set
            {
                _employee.IBAN = value;
                OnPropertyChange();
            }
        }

        public HealthInsurance HealthInsurance
        {
            get => _employee.HealthInsuranceCompany;
            set
            {
                _employee.HealthInsuranceCompany = SetPropertiesForCmbox<HealthInsurance>(HealthInsuranceData, _stringHealthInsurance); ;
                OnPropertyChange();
            }
        }

        public string StringHealthInsurance
        {
            get => _stringHealthInsurance;
            set
            {
                _stringHealthInsurance = value;
                HealthInsurance = SetPropertiesForCmbox<HealthInsurance>(HealthInsuranceData, _stringHealthInsurance);
                OnPropertyChange();
            }
        }

        public bool Handicap
        {
            get => _employee.Disabled;
            set
            {
                _employee.Disabled = value;
                OnPropertyChange();
            }
        }

        public bool Gender
        {
            get => _employee.Gender;
            set
            {
                _employee.Gender = value;
                OnPropertyChange();
            }
        }

        public int? HandicapInPercentage
        {
            get => _employee.DisabilityRate;
            set
            {
                _employee.DisabilityRate = value;
                OnPropertyChange();
            }
        }
        #endregion
        #region Contact, address
        public string PhoneNumber
        {
            get => _employee.PhoneNumber;
            set
            {
                _employee.PhoneNumber = value;
                OnPropertyChange();
            }
        }

        public string Email
        {
            get => _employee.Email;
            set
            {
                _employee.Email = value;
                OnPropertyChange();
            }
        }


        public string HouseNumber
        {
            get => _employee.AddressData.HouseNumber;
            set
            {
                _employee.AddressData.HouseNumber = value;
                OnPropertyChange();
            }
        }

        public string Street
        {
            get => _employee.AddressData.Street;
            set
            {
                _employee.AddressData.Street = value;
                OnPropertyChange();
            }
        }

        public string City
        {
            get => _employee.AddressData.City;
            set
            {
                _employee.AddressData.City = value;
                OnPropertyChange();
            }
        }

        public string PostalCode
        {
            get => _employee.AddressData.PostalCode;
            set
            {
                _employee.AddressData.PostalCode = value;
                OnPropertyChange();
            }
        }

        public string TempHouseNumber
        {
            get => _employee.TemporaryAdressDdata.HouseNumber;
            set
            {
                _employee.TemporaryAdressDdata.HouseNumber = value;
                OnPropertyChange();
            }
        }

        public string TempStreet
        {
            get => _employee.TemporaryAdressDdata.Street;
            set
            {
                _employee.TemporaryAdressDdata.Street = value;
                OnPropertyChange();
            }
        }

        public string TempCity
        {
            get => _employee.TemporaryAdressDdata.City;
            set
            {
                _employee.TemporaryAdressDdata.City = value;
                OnPropertyChange();
            }
        }

        public string TempPostalCode
        {
            get => _employee.TemporaryAdressDdata.PostalCode;
            set
            {
                _employee.TemporaryAdressDdata.PostalCode = value;
                OnPropertyChange();
            }
        }
        #endregion
        #region Credentials
        public string PayChechPassword
        {
            get =>_fileService.Decrypt(_employee.Credentials.PaycheckPassword);
            set
            {
                _employee.Credentials.PaycheckPassword = _fileService.Encrypt(value);
                OnPropertyChange();
            }
        }

        public string PinAlarm
        {
            get => _fileService.Decrypt(_employee.Credentials.PinAlarm);
            set
            {
                _employee.Credentials.PinAlarm = _fileService.Encrypt(value);
                OnPropertyChange();
            }
        }
        #endregion
        #region Education
        public string HighestSchool
        {
            get => _employee.HighestEducationData.School;
            set
            {
                _employee.HighestEducationData.School = value;
                OnPropertyChange();
            }
        }

        public string HighestMajor
        {
            get => _employee.HighestEducationData.Major;
            set
            {
                _employee.HighestEducationData.Major = value;
                OnPropertyChange();
            }
        }

        public int HighestEndYear
        {
            get => _employee.HighestEducationData.EndYear;
            set
            {
                _employee.HighestEducationData.EndYear = value;
                OnPropertyChange();
            }
        }

        public EducationLevel EducationLevel
        {
            get => _employee.HighestEducationData.EducationLevel;
            set
            {
                _employee.HighestEducationData.EducationLevel = SetPropertiesForCmbox<EducationLevel>(EducationLevelData, _stringEduLevel);
                OnPropertyChange();
            }
        }

        public string StringEducationLevel
        {
            get => _stringEduLevel;
            set
            {
                _stringEduLevel = value;
                EducationLevel = SetPropertiesForCmbox<EducationLevel>(EducationLevelData, _stringEduLevel);
                OnPropertyChange();
            }
        }

        public string CurrentSchool
        {
            get => _employee.CurrentEducationData.School;
            set
            {
                _employee.CurrentEducationData.School = value;
                OnPropertyChange();
            }
        }

        public string CurrentMajor
        {
            get => _employee.CurrentEducationData.Major;
            set
            {
                _employee.CurrentEducationData.Major = value;
                OnPropertyChange();
            }
        }

        public int CurrentEndYear
        {
            get => _employee.CurrentEducationData.EndYear;
            set
            {
                _employee.CurrentEducationData.EndYear = value;
                OnPropertyChange();
            }
        }

        public EducationLevel CurrentEducationLevel
        {
            get => _employee.CurrentEducationData.EducationLevel;
            set
            {
                _employee.CurrentEducationData.EducationLevel = SetPropertiesForCmbox<EducationLevel>(EducationLevelData, _stringCurrentEduLevel);
                OnPropertyChange();
            }
        }

        public string StringCurrentEducationLevel
        {
            get => _stringCurrentEduLevel;
            set
            {
                _stringCurrentEduLevel = value;
                CurrentEducationLevel = SetPropertiesForCmbox<EducationLevel>(EducationLevelData, _stringCurrentEduLevel);
                OnPropertyChange();
            }
        }
        #endregion
        #region Retirement
        public Retirement Retirement
        {
            get => _employee.RetirementData.Retirement;
            set
            {
                _employee.RetirementData.Retirement = SetPropertiesForCmbox<Retirement>(RetirementData, _stringRetirement);
                OnPropertyChange();
            }
        }

        public string StringRetirement
        {
            get => _stringRetirement;
            set
            {
                _stringRetirement = value;
                Retirement = SetPropertiesForCmbox<Retirement>(RetirementData, _stringRetirement);
                OnPropertyChange();
            }
        }

        public DateTime? RetiredSince
        {
            get => _employee.RetirementData.RetiredSince;
            set
            {
                _employee.RetirementData.RetiredSince = value;
                OnPropertyChange();
            }
        }

        //public bool ParticipatingInRetirementSaving
        //{
        //    get => _employee.RetirementData.ParticipatingInRetirementSaving;
        //    set
        //    {
        //        _employee.RetirementData.ParticipatingInRetirementSaving = value;
        //        OnPropertyChange();
        //    }
        //}

        //public bool? RetirementInsuranceCompanyException
        //{
        //    get => _employee.RetirementData.RetirementInsuranceCompanyException;
        //    set
        //    {
        //        _employee.RetirementData.RetirementInsuranceCompanyException = value;
        //        OnPropertyChange();
        //    }
        //}

        #endregion
        public DateTime StartDate
        {
            get => _employee.PreviousJobData.StartDate;
            set
            {
                _employee.PreviousJobData.StartDate = value;
                OnPropertyChange();
            }
        }

        public DateTime EndDate
        {
            get => _employee.PreviousJobData.EndDate;
            set
            {
                _employee.PreviousJobData.EndDate = value;
                OnPropertyChange();
            }
        }

        public string EmployerCompanyName
        {
            get => _employee.PreviousJobData.EmployerCompanyName;
            set
            {
                _employee.PreviousJobData.EmployerCompanyName = value;
                OnPropertyChange();
            }
        }

        public string Position
        {
            get => _employee.PreviousJobData.Position;
            set
            {
                _employee.PreviousJobData.Position = value;
                OnPropertyChange();
            }
        }

        public BindingList<Child> Children
        {
            get => _children;
            set
            {
                _employee.Children = value.ToList();
                OnPropertyChange();
            }
        }

        public Employee Employee
        {
            get => _employee;
            set
            {
                if(value != null)
                {
                    foreach(System.Reflection.PropertyInfo property in typeof(Employee).GetProperties())
                    {
                        property.SetValue(_employee,property.GetValue(value));
                    }
                }
            }
        }

        #endregion

        #region Combo data
        public Dictionary<int, string> CountryData { get; set; }
        public Dictionary<int, string> EducationLevelData { get; set; }
        public Dictionary<int, string> HealthInsuranceData { get; set; }
        public Dictionary<int, string> RetirementData { get; set; }
        public Dictionary<int, string> StateData { get; set; }
        public Dictionary<int, string> WageCategoryData { get; set; }
        public Dictionary<int, string> WorkExpirationData { get; set; }
        public Dictionary<int, string> WorkHoursData { get; set; }
        public Dictionary<int, string> WorkPositionData { get; set; }
        public Dictionary<int, string> WorkTypeData { get; set; }
        #endregion

        #region Inotify Property Change

        private void OnPropertyChange([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Load Combos
        private void LoadCombos()
        {
            StateRepository state = new StateRepository();
            StateData = state.GetAllState(_cultureInfo);
            HealthInsuranceRepository health = new HealthInsuranceRepository();
            HealthInsuranceData = health.GetHealthInsuranceData(_cultureInfo);
            RetirementRepository retirement = new RetirementRepository();
            RetirementData = retirement.GetRetirementData(_cultureInfo);
            EducationLevelRepository educationLevel = new EducationLevelRepository();
            EducationLevelData = educationLevel.GetEducationLevelData(_cultureInfo);
        }
        #endregion



        public void Load(string path)
        {
            FileService fs = new FileService();
            var file = fs.LoadJson<Questionare>(path);
            Employee = file.Employee;
            _showQuestionGroups = file.ShowQuestionGroups;
        }

        public void Save()
        {
            _employee.Children = _children.ToList();
            FileService fs = new FileService();
            Employee employee = _employee;
            Questionare questionare = new Questionare()
            {
                Employee = employee,
                ShowQuestionGroups = _showQuestionGroups
            };
            fs.SaveJson(questionare, "test2.kpq");
        }
    }
}
