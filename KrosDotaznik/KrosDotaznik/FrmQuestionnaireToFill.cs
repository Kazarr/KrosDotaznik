using KrosDotaznik.CalendarColumnPicker;
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
    public partial class FrmQuestionnaireToFill : Form
    {
        private QuestionnaireToFillViewModel _viewModel;
        public FrmQuestionnaireToFill(QuestionnaireToFillViewModel fillViewModel)
        {
            InitializeComponent();
            _viewModel = fillViewModel;
            //LoadCombo();
            BindingTest();
            CalendarColumn calendarColumn = new CalendarColumn();
            calendarColumn.Name = "colDateOfBirth";
            calendarColumn.HeaderText = Resources.GridResources.colDateOfBirth;
            dgvChildren.Columns.Add(calendarColumn);
            foreach(DataGridViewRow row in dgvChildren.Rows)
            {
                row.Cells[3].Value = DateTime.Now;
            }
            //SetComponentsByLanguage();
            //SetTabPagesByLanguage();
        }

        private void BindDefaultControlProperty(Control ctrl, string dataMember)
        {
            var attribute = ctrl.GetType().GetCustomAttributes(typeof(DefaultBindingPropertyAttribute), true).FirstOrDefault() as DefaultBindingPropertyAttribute;
            ctrl.DataBindings.Add(
                attribute.Name,
                _viewModel,
                dataMember,
                false,
                DataSourceUpdateMode.OnValidation);
        }

        //private void LoadCombo()
        //{
        //    string info = System.Globalization.CultureInfo.CurrentCulture.ToString();
        //    cmbState.DataSource = new BindingSource(_viewModel.StateData, null);
        //    cmbState.ValueMember = "Key";
        //    cmbState.DisplayMember = "Value";
        //}

        public void BindingTest()
        {
            BindDefaultControlProperty(txtName, nameof(_viewModel.Name));
            BindDefaultControlProperty(txtSurname, nameof(_viewModel.Surname));
            BindDefaultControlProperty(txtPreviousName, nameof(_viewModel.PreviousName));
            BindDefaultControlProperty(txtMaidenName, nameof(_viewModel.MaidenName));
            BindDefaultControlProperty(txtTitle, nameof(_viewModel.Title));
            BindDefaultControlProperty(txtIdentityCard, nameof(_viewModel.IdentityCard));
            BindDefaultControlProperty(txtPersonalId, nameof(_viewModel.PersonalId));
            BindDefaultControlProperty(txtPlaceOfBirth, nameof(_viewModel.PlaceOfBirth));
            BindDefaultControlProperty(txtRegionOfBirth, nameof(_viewModel.RegionOfBirth));
            BindDefaultControlProperty(txtNationality, nameof(_viewModel.Nationality));
            BindDefaultControlProperty(txtCitizenShip, nameof(_viewModel.CitizenShip));
            BindDefaultControlProperty(txtBankAcc, nameof(_viewModel.BankAccount));
            BindDefaultControlProperty(txtIban, nameof(_viewModel.Iban));
            BindDefaultControlProperty(txtHealtInsurance, nameof(_viewModel.HealthInsurance));
            BindDefaultControlProperty(txtHndcpInPercentage, nameof(_viewModel.HandicapInPercentage));
        }
        //#region Set components by language
        //private void SetComponentsByLanguage()
        //{
        //    //grBoxEmployeeData.Text = Resources.Questionnaire.lblPersonalInfo;
        //    lblName.Text = Resources.Questionnaire.lblName;
        //    lblSurname.Text = Resources.Questionnaire.lblSurname;
        //    lblPreviousName.Text = Resources.Questionnaire.lblPreviousSurname;
        //    lblMaidenName.Text = Resources.Questionnaire.lblMaidenName;
        //    lblIdentityCard.Text = Resources.Questionnaire.lblIdentityCard;
        //    lblBirthDate.Text = Resources.Questionnaire.lblBirthDate;
        //    lblTitle.Text = Resources.Questionnaire.lblTitle;
        //    lblBankAcc.Text = Resources.Questionnaire.lblBankAcc;
        //    lblIBAN.Text = Resources.Questionnaire.lblIBAN;
        //    lblPersonalId.Text = Resources.Questionnaire.lblPersonalId;
        //    lblPlaceOfBirth.Text = Resources.Questionnaire.lblPlaceOfBirth;
        //    lblRegionOfBirth.Text = Resources.Questionnaire.lblRegionOfBirth;
        //    lblNationality.Text = Resources.Questionnaire.lblNationality;
        //    lblCitizenShip.Text = Resources.Questionnaire.lblCitizenShip;
        //    lblGender.Text = Resources.Questionnaire.lblGender;
        //    lblState.Text = Resources.Questionnaire.lblState;
        //    lblHealthInsurance.Text = Resources.Questionnaire.lblHealthInsurance;
        //    lblSecondPillar.Text = Resources.Questionnaire.lblSecondPillar;
        //    lblHandicap.Text = Resources.Questionnaire.lblHandicap;
        //    lblHandicapInPercentage.Text = Resources.Questionnaire.lblHandicapInPercentage;
        //    lblPensionRecipient.Text = Resources.Questionnaire.lblPensionRecipient;
        //    lblRetirementInsuranceCompanyException.Text = Resources.Questionnaire.lblException;
        //    lblStreet.Text = Resources.Questionnaire.lblAddressStreet;
        //    lblStreetTemp.Text = Resources.Questionnaire.lblAddressStreet;
        //    lblCity.Text = Resources.Questionnaire.lblAddressCity;
        //    lblCityTemp.Text = Resources.Questionnaire.lblAddressCity;
        //    lblPostalCode.Text = Resources.Questionnaire.lblAddressPostalCode;
        //    lblPostalCodeTemp.Text = Resources.Questionnaire.lblAddressPostalCode;
        //    lblPhoneNumber.Text = Resources.Questionnaire.lblPhone;
        //    lblEmail.Text = Resources.Questionnaire.lblMail;
        //    grBoxAddress.Text = Resources.Questionnaire.lblAddress;
        //    grBoxTemporaryAddress.Text = Resources.Questionnaire.lblTemporaryAddress;
        //    lblPassword.Text = Resources.Questionnaire.lblPaycheckPass;
        //    lblPin.Text = Resources.Questionnaire.lblAlarmPin;
        //    grBoxHighEducation.Text = Resources.Questionnaire.lblHighestEducation;
        //    grBoxCurrentEducation.Text = Resources.Questionnaire.lblCurrentStudy;
        //    lblSchool.Text = Resources.Questionnaire.lblSchool;
        //    lblCurrSchool.Text = Resources.Questionnaire.lblSchool;
        //    lblEndYear.Text = Resources.Questionnaire.lblYearOfEnd;
        //    lblCurrEndYear.Text = Resources.Questionnaire.lblYearOfEnd;
        //    lblMajor.Text = Resources.Questionnaire.lblMajor;
        //    lblCurrMajor.Text = Resources.Questionnaire.lblMajor;
        //    lblEducationLevel.Text = Resources.Questionnaire.lblEducationLevel;
        //    lblCurrEducationLevel.Text = Resources.Questionnaire.lblEducationLevel;
        //    lblJobFrom.Text = Resources.Questionnaire.lblJobFrom;
        //    lblJobTo.Text = Resources.Questionnaire.lblJobTo;
        //    lblEmployeer.Text = Resources.Questionnaire.lblEmployer;
        //    lblWorkPosition.Text = Resources.Questionnaire.lblWorkPosition;
        //    radioBtnMale.Text = Resources.Questionnaire.lblMale;
        //    radioBtnFemale.Text = Resources.Questionnaire.lblFemale;
        //    radioBtnHandcpYes.Text = Resources.Questionnaire.lblYes;
        //    radioBtnHndcpNo.Text = Resources.Questionnaire.lblNo;
        //    radioBtnOldAge.Text = Resources.Questionnaire.lblPensionOldAge;
        //    radioBtnRetirment.Text = Resources.Questionnaire.lblPensionRetirement;
        //    radioBtnDisabled.Text = Resources.Questionnaire.lblPensionDisabled;
        //    radioBtnExceptionYes.Text = Resources.Questionnaire.lblYes;
        //    radioBtnExceptionNo.Text = Resources.Questionnaire.lblNo;
        //    radioBtnSecondPilarYes.Text = Resources.Questionnaire.lblYes;
        //    radioBtnSecondPilarNo.Text = Resources.Questionnaire.lblNo;
        //}
        //#endregion
        //private void SetTabPagesByLanguage()
        //{
        //    tPagePersonalInfo.Text = Resources.Questionnaire.lblPersonalInfo;
        //    tPageContactAdress.Text = Resources.Questionnaire.lblContactAddress;
        //    tPagePassword.Text = Resources.Questionnaire.lblPassAndApproaches;
        //    tPageEducation.Text= Resources.Questionnaire.lblEducation;
        //    tPageChildInfo.Text = Resources.Questionnaire.lblChildInfo;
        //    tPagePreviousJob.Text = Resources.Questionnaire.lblPreviousJob;
        //}

        /// <summary>
        /// Allows you to enter only a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHndcpInPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _viewModel.Save();
        }
    }
}
