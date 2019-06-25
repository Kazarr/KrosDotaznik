using Data.Models;
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
    public class QuestionnaireCreateViewModel
    {
        #region  Fields
        private bool _employeeData;
        private bool _contactsAddress;
        private bool _passwordAccess;
        private bool _educationData;
        private bool _previousJob;
        private bool _childData;
        private bool _jobSpecification;
        private Dictionary<int, bool> _showQuestionGroups ;
        #endregion

        #region Constructor
        public QuestionnaireCreateViewModel()
        {
            _showQuestionGroups = new Dictionary<int, bool>();
            FillDictionary();
        }
        #endregion

        #region Properties
        public bool EmployeeData
        {
            get => _employeeData;
            set
            {
                _employeeData = value;
                _showQuestionGroups[0] = _employeeData;
                OnPropertyChange();
            }
        }
        public bool ContactsAddress
        {
            get => _contactsAddress;
            set
            {
                _contactsAddress = value;
                _showQuestionGroups[1] = _contactsAddress;
                OnPropertyChange();
            }
        }
        public bool PasswordAccess
        {
            get => _passwordAccess;
            set
            {
                _passwordAccess = value;
                _showQuestionGroups[2] = _passwordAccess;
                OnPropertyChange();
            }
        }
        public bool EducationData
        {
            get => _educationData;
            set
            {
                _educationData = value;
                _showQuestionGroups[3] = _educationData;
                OnPropertyChange();
            }
        }
        public bool PreviousJob
        {
            get => _previousJob;
            set
            {
                _previousJob = value;
                _showQuestionGroups[4] = _previousJob;
                OnPropertyChange();
            }
        }
        public bool ChildData
        {
            get => _childData;
            set
            {
                _childData = value;
                _showQuestionGroups[5] = _childData;
                OnPropertyChange();
            }
        }
        public bool JobSpecification
        {
            get => _jobSpecification;
            set
            {
                _jobSpecification = value;
                _showQuestionGroups[6] = _jobSpecification;
                OnPropertyChange();
            }
        }
        #endregion

        #region Inotify Property Change

        private void OnPropertyChange([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region FillData
        private void FillDictionary()
        {
            for (int i = 0; i < 7; i++)
            {
                _showQuestionGroups.Add(i, false);
            }
        }
        #endregion

        #region Save method
        public void SaveQuestionnaire(string filePath)
        {
            FileService fs = new FileService();
            fs.SaveJson(
                new Questionare()
                {
                    ShowQuestionGroups = _showQuestionGroups,
                }, filePath);
        }
        #endregion
    }
}
