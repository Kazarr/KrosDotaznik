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
        private string _state = string.Empty;
        private string _placeOfBirth = string.Empty;
        private string _regionOfBirth = string.Empty;
        private string _nationality = string.Empty;
        private string _citizenShip = string.Empty;
        private string _bankAcc = string.Empty;
        private string _iban = string.Empty;
        private string _healthInsurance = string.Empty;
        private int _handicapInPercentage = default(int);
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

        public string State
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

        public string HealthInsurance
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

        #region Inotify Property Change

        private void OnPropertyChange([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
