using System;
using System.Windows.Forms;

namespace KrosDotaznik
{
    public partial class FrmQuestionnaireCreate : Form
    {
        #region Fields
        private QuestionnaireCreateViewModel _viewModel;
        #endregion

        #region Constructor
        public FrmQuestionnaireCreate()
        {
            InitializeComponent();
            _viewModel = new QuestionnaireCreateViewModel();
            BindingCheckBox();            
        }
        #endregion

        #region Binding components
        private void BindCheckBoxControls(CheckBox checkBox, string memberData)
        {
            checkBox.DataBindings.Add(
                nameof(checkBox.Checked),
                _viewModel,
                memberData,
                false,
                DataSourceUpdateMode.OnPropertyChanged);
        }
        public void BindingCheckBox()
        {
            BindCheckBoxControls(chbxEmployeeData, nameof(_viewModel.EmployeeData));
            BindCheckBoxControls(chbxContacts, nameof(_viewModel.ContactsAddress));
            BindCheckBoxControls(chbxPassword, nameof(_viewModel.PasswordAccess));
            BindCheckBoxControls(chbxEducation, nameof(_viewModel.EducationData));
            BindCheckBoxControls(chbxPrevious, nameof(_viewModel.PreviousJob));
            BindCheckBoxControls(chbxChild, nameof(_viewModel.ChildData));
            BindCheckBoxControls(chbxJobSpecification, nameof(_viewModel.JobSpecification));
        }
        #endregion
        
        #region Button handlers
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Resources.Questionnaire.msgQuestionCreate, Resources.Questionnaire.msgQuestionCreateTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                this.Close();
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (saveFileData)
            {
                saveFileData.Filter = "Questionare (*.kpq)|*.kpq";
                saveFileData.FileName = "NameSurname";
                if (saveFileData.ShowDialog() == DialogResult.OK)
                {
                    _viewModel.SaveQuestionnaire(saveFileData.FileName);
                    DialogResult result = MessageBox.Show(Resources.Questionnaire.msgQuestionSave, Resources.Questionnaire.msgQuestionSaveTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.No == result)
                    {
                        Close();
                    }
                }
            }
            
        }

        #endregion
    }
}
