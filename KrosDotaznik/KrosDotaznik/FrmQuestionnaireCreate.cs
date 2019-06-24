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
    public partial class FrmQuestionnaireCreate : Form
    {
        #region Fields
        private QuestionnaireCreateViewModel _viewModel;
        #endregion
        public FrmQuestionnaireCreate()
        {
            InitializeComponent();
            _viewModel = new QuestionnaireCreateViewModel();
            BindingCheckBox();            
        }
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
        #region
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
            using (this.saveFileData  = new SaveFileDialog())
            {
                saveFileData.Filter = "Questionare (*.kpq)|*.kpq";
                if (saveFileData.ShowDialog() == DialogResult.OK)
                {
                    _viewModel.SaveQuestionnaire(saveFileData.FileName);
                }
            }
            DialogResult result = MessageBox.Show(Resources.Questionnaire.msgQuestionSave, Resources.Questionnaire.msgQuestionSaveTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == result)
            {
                this.Close();
            }
        }

        #endregion

    }
}
