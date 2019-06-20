using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrosDotaznik
{
    public partial class FrmMain : Form
    {
        #region Fields
        private MainViewModel _mainViewModel;
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">Argumets for starting app for edit questionare</param>
        public FrmMain(bool allowCreate)
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel();
            SetComponentsByLanguage();
            BindingCheckBox();
            MakeVisible(allowCreate);
        }

        private void MakeVisible(bool allowCreate)
        {
            if (allowCreate)
            {
                foreach(CheckBox checkBox in Controls.OfType<CheckBox>())
                {
                    checkBox.Visible = true;
                }
                btnCreate.Visible = true;
            }
        }
        #endregion

        #region Set components res
        private void SetComponentsByLanguage() {
            btnCreate.Text = Resources.MainForm.btnCreate;
            btnFill.Text = Resources.MainForm.btnFill;
            chbxEmployeeData.Text = Resources.Questionnaire.lblPersonalInfo;
            chbxContacts.Text = Resources.Questionnaire.lblContactAddress;
            chbxPassword.Text = Resources.Questionnaire.lblPassAndApproaches;
            chbxEducation.Text = Resources.Questionnaire.lblEducation;
            chbxPrevious.Text = Resources.Questionnaire.lblPreviousJob;
            chbxChild.Text = Resources.Questionnaire.lblChildInfo;
            chbxJobSpecification.Text = Resources.Questionnaire.lblJobSpecification;
        }
        #endregion

        #region Binding components
        private void BindCheckBoxControls(CheckBox checkBox, string memberData)
        {
            checkBox.DataBindings.Add(
                nameof(checkBox.Checked),
                _mainViewModel,
                memberData,
                false,
                DataSourceUpdateMode.OnPropertyChanged);            
        }
        public void BindingCheckBox()
        {
            BindCheckBoxControls(chbxEmployeeData, nameof(_mainViewModel.EmployeeData));
            BindCheckBoxControls(chbxContacts, nameof(_mainViewModel.ContactsAddress));
            BindCheckBoxControls(chbxPassword, nameof(_mainViewModel.PasswordAccess));
            BindCheckBoxControls(chbxEducation, nameof(_mainViewModel.EducationData));
            BindCheckBoxControls(chbxPrevious, nameof(_mainViewModel.PreviousJob));
            BindCheckBoxControls(chbxChild, nameof(_mainViewModel.ChildData));
            BindCheckBoxControls(chbxJobSpecification, nameof(_mainViewModel.JobSpecification));
        }
        #endregion

        #region Button handlers
        private void btnSvk_Click(object sender, EventArgs e)
        {
            _mainViewModel.SetLOcalization("sk");
            SetComponentsByLanguage();
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            _mainViewModel.SetLOcalization("en");
            SetComponentsByLanguage();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Text files (*.json)|*.json",
                Title = "Choose Questionare",
                RestoreDirectory = true
            };
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                _mainViewModel.OpenQuestionnaireToFill(openFile.FileName);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _mainViewModel.SaveQuestionnaire();
        }
        #endregion
    }
}
