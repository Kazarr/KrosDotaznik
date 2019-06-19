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

namespace KrosDotaznik
{
    public class QuestionnaireToFillViewModel
    {
        #region  Fields
        private string _name = string.Empty;
        private string _surname = string.Empty;
        private string _previousName = string.Empty;
        private string _maidenName = string.Empty;
        private string _title = string.Empty;
        private string _identityCard = string.Empty;
        private string _personalId = string.Empty;
        private State _state = null;
        private string _stringState = string.Empty;
        private string _placeOfBirth = string.Empty;
        private string _regionOfBirth = string.Empty;
        private string _nationality = string.Empty;
        private string _citizenShip = string.Empty;
        private string _bankAcc = string.Empty;
        private string _iban = string.Empty;
        private HealthInsurance _healthInsurance = null;
        private int _handicapInPercentage = default(int);
        private string _cultureInfo = System.Globalization.CultureInfo.CurrentCulture.ToString();

        private string _phoneNumber = string.Empty;
        private string _email = string.Empty;
        private string _houseNumber = string.Empty;
        private string _street = string.Empty;
        private string _city = string.Empty;
        private int _postalCode = default(int);
        private string _tempHouseNumber = string.Empty;
        private string _tempStreet = string.Empty;
        private string _tempCity = string.Empty;
        private int _tempPostalCode = default(int);

        private string _payCheckPassword = string.Empty;
        private int _pinAlarm = default(int);

        private string _highestSchool = string.Empty;
        private string _highestMajor = string.Empty;
        private DateTime _highestEndYear = DateTime.Now;
        private EducationLevel _educationLevel = null;
        private string _currentSchool = string.Empty;
        private string _currentMajor = string.Empty;
        private DateTime _currentEndYear = DateTime.Now;
        private EducationLevel _currentEducationLevel = null;

        private DateTime _startDate = DateTime.Now;
        private DateTime _endDate = DateTime.Now;
        private string _employerCompanyName = string.Empty;
        private string _position = string.Empty;

        private BindingList<Child> _children = new BindingList<Child>();


        public QuestionnaireToFillViewModel()
        {
            LoadCombos();
        }
        #endregion

        #region Properties
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChange();
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChange();
            }
        }

        public string PreviousName
        {
            get => _previousName;
            set
            {
                _previousName = value;
                OnPropertyChange();
            }
        }

        public string MaidenName
        {
            get => _maidenName;
            set
            {
                _maidenName = value;
                OnPropertyChange();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChange();
            }
        }

        public string IdentityCard
        {
            get => _identityCard;
            set
            {
                _identityCard = value;
                OnPropertyChange();
            }
        }

        public string PersonalId
        {
            get => _personalId;
            set
            {
                _personalId = value;
                OnPropertyChange();
            }
        }

        public State State
        {
            get => _state;
            set
            {
                //_state = SetState();
                _state = SetPropertie<State>(StateData, _stringState);
                OnPropertyChange();
            }
        }
        private State SetState()
        {
            State query = StateData.Where(s => s.Value == _stringState)
                .Select(x => new State { Id = x.Key, EmployeeState = x.Value }).FirstOrDefault();
            return query;
        }

        private T SetPropertie<T>(Dictionary<int, string> dict, string _field)
        {
            //T NIECO = (T) Activator.CreateInstance(typeof(T));
            //T query = dict.Where(s => s.Value == _field)
            //    .Select(x =>
            //    {
            //        typeof(T).GetProperties()[0].SetValue(NIECO, x.Key);
            //        typeof(T).GetProperties()[1].SetValue(NIECO, x.Value);
            //    });
            var jahoda = (T)Activator.CreateInstance(typeof(T));
            foreach (var item in dict)
            {
                if (item.Value.Equals(_field))
                {
                    typeof(T).GetProperties()[0].SetValue(jahoda, item.Key);
                    typeof(T).GetProperties()[1].SetValue(jahoda, item.Value);
                    return jahoda;
                }
            }
            return jahoda;
        }

        private void Zemiak()
        {
            SetPropertie<State>(StateData, _stringState);
        }

    public string StringState
        {
            get => _stringState;
            set
            {
                _stringState = value;
                State = SetPropertie<State>(StateData, _stringState);
                OnPropertyChange();
            }
        }


        public string PlaceOfBirth
        {
            get => _placeOfBirth;
            set
            {
                _placeOfBirth = value;
                OnPropertyChange();
            }
        }
        public string RegionOfBirth
        {
            get => _regionOfBirth;
            set
            {
                _regionOfBirth = value;
                OnPropertyChange();
            }
        }

        public string Nationality
        {
            get => _nationality;
            set
            {
                _nationality = value;
                OnPropertyChange();
            }
        }

        public string CitizenShip
        {
            get => _citizenShip;
            set
            {
                _citizenShip = value;
                OnPropertyChange();
            }
        }

        public string BankAccount
        {
            get => _bankAcc;
            set
            {
                _bankAcc = value;
                OnPropertyChange();
            }
        }

        public string Iban
        {
            get => _iban;
            set
            {
                _iban = value;
                OnPropertyChange();
            }
        }

        public HealthInsurance HealthInsurance
        {
            get => _healthInsurance;
            set
            {
                _healthInsurance = value;
                OnPropertyChange();
            }
        }

        public int HandicapInPercentage
        {
            get => _handicapInPercentage;
            set
            {
                _handicapInPercentage = value;
                OnPropertyChange();
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChange();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChange();
            }
        }

        public string HouseNumber
        {
            get => _houseNumber;
            set
            {
                _houseNumber = value;
                OnPropertyChange();
            }
        }

        public string Street
        {
            get => _street;
            set
            {
                _street = value;
                OnPropertyChange();
            }
        }

        public string City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropertyChange();
            }
        }

        public int PostalCode
        {
            get => _postalCode;
            set
            {
                _postalCode = value;
                OnPropertyChange();
            }
        }

        public string TempHouseNumber
        {
            get => _tempHouseNumber;
            set
            {
                _tempHouseNumber = value;
                OnPropertyChange();
            }
        }

        public string TempStreet
        {
            get => _tempStreet;
            set
            {
                _tempStreet = value;
                OnPropertyChange();
            }
        }

        public string TempCity
        {
            get => _tempCity;
            set
            {
                _tempCity = value;
                OnPropertyChange();
            }
        }

        public int TempPostalCode
        {
            get => _tempPostalCode;
            set
            {
                _tempPostalCode = value;
                OnPropertyChange();
            }
        }

        public string PayChechPassword
        {
            get => _payCheckPassword;
            set
            {
                _payCheckPassword = value;
                OnPropertyChange();
            }
        }

        public int PinAlarm
        {
            get => _pinAlarm;
            set
            {
                _pinAlarm = value;
                OnPropertyChange();
            }
        }

        public string HighestSchool
        {
            get => _highestSchool;
            set
            {
                _highestSchool = value;
                OnPropertyChange();
            }
        }

        public string HighestMajor
        {
            get => _highestMajor;
            set
            {
                _highestMajor = value;
                OnPropertyChange();
            }
        }

        public DateTime HighestEndYear
        {
            get => _highestEndYear;
            set
            {
                _highestEndYear = value;
                OnPropertyChange();
            }
        }

        public EducationLevel EducationLevel
        {
            get => _educationLevel;
            set
            {
                _educationLevel = value;
                OnPropertyChange();
            }
        }

        public string CurrentSchool
        {
            get => _currentSchool;
            set
            {
                _currentSchool = value;
                OnPropertyChange();
            }
        }

        public string CurrentMajor
        {
            get => _currentMajor;
            set
            {
                _currentMajor = value;
                OnPropertyChange();
            }
        }

        public DateTime CurrentEndYear
        {
            get => _currentEndYear;
            set
            {
                _currentEndYear = value;
                OnPropertyChange();
            }
        }

        public EducationLevel CurrentEducationLevel
        {
            get => _currentEducationLevel;
            set
            {
                _currentEducationLevel = value;
                OnPropertyChange();
            }
        }

        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                OnPropertyChange();
            }
        }

        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                _endDate = value;
                OnPropertyChange();
            }
        }

        public string EmployerCompanyName
        {
            get => _employerCompanyName;
            set
            {
                _employerCompanyName = value;
                OnPropertyChange();
            }
        }

        public string Position
        {
            get => _position;
            set
            {
                _position = value;
                OnPropertyChange();
            }
        }

        public BindingList<Child> Children
        {
            get => _children;
            set
            {
                _children = value;
                OnPropertyChange();
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
            StateData = state.GetAllState<int, string>(_cultureInfo);
            HealthInsuranceRepository health = new HealthInsuranceRepository();
            HealthInsuranceData = health.GetHealthInsuranceData<int, string>(_cultureInfo);
            RetirementRepository retirement = new RetirementRepository();
            RetirementData = retirement.GetRetirementData<int, string>(_cultureInfo);
            EducationLevelRepository educationLevel = new EducationLevelRepository();
            EducationLevelData = educationLevel.GetEducationLevelData<int, string>(_cultureInfo);
        }
        #endregion

        public void Save()
        {
            FileService fs = new FileService();
            Employee employee = new Employee()
            {
                Name = _name,
                Surname = _surname,
                PreviousName = _previousName,
                MaidenName = _maidenName,
                Title = _title,
                IdNumber = _identityCard,
                BirthNumber = _personalId,
                State = _state,
                PlaceOfBirth = _placeOfBirth,
                CountyOfBirth = _regionOfBirth,
                Nationality = _nationality,
                Citizenship = _citizenShip,
                BankAccountNumber = _bankAcc,
                IBAN = _iban,
                HealthInsuranceCompany = _healthInsurance,
                DisabilityRate = _handicapInPercentage
            };
            Questionare questionare = new Questionare()
            {
                Employee = employee,
                ShowQuestionGroups = new bool[] {true, true, true, true, true,true}
            };
            fs.SaveJson(questionare, "test2.json");
        }
    }
}
