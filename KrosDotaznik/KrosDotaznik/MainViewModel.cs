using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace KrosDotaznik
{
    public class MainViewModel
    {
        #region Fields
        //private bool[] _showQuestionGroups = new bool[7];
        private Dictionary<int, bool> _showQuestionGroups = new Dictionary<int, bool>();
        private bool _employeeData;
        private bool _contactsAddress;
        private bool _passwordAccess;
        private bool _educationData;
        private bool _previousJob;
        private bool _childData;
        private bool _jobSpecification;
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
                _childData= value;
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

        #region Form method
        public void OpenQuestionnaireToFill(string path)
        {
            using (FrmQuestionnaireToFill toFill = new FrmQuestionnaireToFill(new QuestionnaireToFillViewModel(path)))
            {
                toFill.ShowDialog();
            }
        }

        public void SetLOcalization(string language)
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo(language);
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo(language);
        }
        #endregion

        #region Save method
        public void SaveQuestionnaire()
        {
            FileService fs = new FileService();
            fs.SaveJson(
                new Questionare()
                {
                    ShowQuestionGroups = _showQuestionGroups,
                }, "test.kpq");
        }
        #endregion
    }
}
