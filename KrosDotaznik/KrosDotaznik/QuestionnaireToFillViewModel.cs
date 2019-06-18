using Data.Models;
using Data.Models.Registers;
using Logic;
using System;
using System.Collections.Generic;
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
        private string _placeOfBirth = string.Empty;
        private string _regionOfBirth = string.Empty;
        private string _nationality = string.Empty;
        private string _citizenShip = string.Empty;
        private string _bankAcc = string.Empty;
        private string _iban = string.Empty;
        private HealthInsurance _healthInsurance = null;
        private int _handicapInPercentage = default(int);
        private string _cultureInfo = System.Globalization.CultureInfo.CurrentCulture.ToString();

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
                _state = value;
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
