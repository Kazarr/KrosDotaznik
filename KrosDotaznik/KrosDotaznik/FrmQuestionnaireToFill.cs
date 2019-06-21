using KrosDotaznik.CalendarColumnPicker;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            LoadCombos();
            BindPersonalData();
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

        private void BindRadioButtons(Control ctrl, string dataMember)
        {
            var attribute = ctrl.GetType().GetCustomAttributes(typeof(DefaultBindingPropertyAttribute), true).FirstOrDefault() as DefaultBindingPropertyAttribute;
            ctrl.DataBindings.Add(
                attribute.Name,
                _viewModel,
                dataMember,
                false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FillCombo(ComboBox combo, Object dataSource)
        {
            string info = System.Globalization.CultureInfo.CurrentCulture.ToString();
            combo.DataSource = new BindingSource(dataSource, null);
            combo.ValueMember = "Key";
            combo.DisplayMember = "Value";
        }

        private void LoadCombos()
        {
            FillCombo(cmbHealthInsurance, _viewModel.HealthInsuranceData);
            FillCombo(cmbState, _viewModel.StateData);
            FillCombo(cmbRetirement, _viewModel.RetirementData);
            FillCombo(cmbEduLevel, _viewModel.EducationLevelData);
            FillCombo(cmbCurrentEduLevel, _viewModel.EducationLevelData);
        }

        #region Set components by language
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

        //private void SetTabPagesByLanguage()
        //{
        //    tPagePersonalInfo.Text = Resources.Questionnaire.lblPersonalInfo;
        //    tPageContactAdress.Text = Resources.Questionnaire.lblContactAddress;
        //    tPagePassword.Text = Resources.Questionnaire.lblPassAndApproaches;
        //    tPageEducation.Text= Resources.Questionnaire.lblEducation;
        //    tPageChildInfo.Text = Resources.Questionnaire.lblChildInfo;
        //    tPagePreviousJob.Text = Resources.Questionnaire.lblPreviousJob;
        //}
        #endregion
        /// <summary>
        /// Allows you to enter only a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHndcpInPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (this.saveFileData = new SaveFileDialog())
            {
                saveFileData.Filter = "Questionare (*.kpq)|*.kpq";
                if (saveFileData.ShowDialog() == DialogResult.OK)
                {
                    _viewModel.Save(saveFileData.FileName);
                }
            }
        }

        private void BindPersonalData()
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
            BindDefaultControlProperty(datePickerBirth, nameof(_viewModel.BirthDate));
            BindDefaultControlProperty(cmbState, nameof(_viewModel.StringState));
            BindDefaultControlProperty(cmbRetirement, nameof(_viewModel.StringRetirement));
            BindDefaultControlProperty(datePickerRetiredSince, nameof(_viewModel.RetiredSince));
            BindDefaultControlProperty(cmbHealthInsurance, nameof(_viewModel.StringHealthInsurance));
            BindDefaultControlProperty(txtHndcpInPercentage, nameof(_viewModel.HandicapInPercentage));
            #region RadioBtns binding
            BindRadioButtons(radioBtnHandcpYes, nameof(_viewModel.Disabled));
            BindRadioButtons(radioBtnHndcpNo, nameof(_viewModel.NotDisabled));
            BindRadioButtons(radioBtnMale, nameof(_viewModel.Gender));
            BindRadioButtons(radioBtnFemale, nameof(_viewModel.Female));
            BindRadioButtons(radioBtnExceptionYes, nameof(_viewModel.RetirementInsuranceCompanyException));
            BindRadioButtons(radioBtnExceptionNo, nameof(_viewModel.NotRetirementInsuranceCompanyException));
            BindRadioButtons(radioBtnSecondPilarYes, nameof(_viewModel.ParticipatingInRetirementSaving));
            BindRadioButtons(radioBtnSecondPilarNo, nameof(_viewModel.NotParticipatingInRetirementSaving));
            #endregion
            tPagePersonalInfo.Tag = true;
        }
        private void BindContactAddress()
        {
            BindDefaultControlProperty(txtPhoneNumber, nameof(_viewModel.PhoneNumber));
            BindDefaultControlProperty(txtEmail, nameof(_viewModel.Email));
            BindDefaultControlProperty(txtStreet, nameof(_viewModel.HouseNumber));
            BindDefaultControlProperty(txtHouseNumber, nameof(_viewModel.Street));
            BindDefaultControlProperty(txtCity, nameof(_viewModel.City));
            BindDefaultControlProperty(txtPostalCode, nameof(_viewModel.PostalCode));
            BindDefaultControlProperty(txtTempStreet, nameof(_viewModel.TempHouseNumber));
            BindDefaultControlProperty(txtTempHouseNumber, nameof(_viewModel.TempStreet));
            BindDefaultControlProperty(txtTempCity, nameof(_viewModel.TempCity));
            BindDefaultControlProperty(txtTempPostalCode, nameof(_viewModel.TempPostalCode));
        }
        private void BindCredentials()
        {
            BindDefaultControlProperty(txtPassword, nameof(_viewModel.PayChechPassword));
            BindDefaultControlProperty(txtPinAlarm, nameof(_viewModel.PinAlarm));
        }
        private void BindEducation()
        {
            BindDefaultControlProperty(txtHighestSchool, nameof(_viewModel.HighestSchool));
            BindDefaultControlProperty(txtHightestSchoolMajor, nameof(_viewModel.HighestMajor));
            BindDefaultControlProperty(txtHighestSchoolEndYear, nameof(_viewModel.HighestEndYear));
            BindDefaultControlProperty(cmbEduLevel, nameof(_viewModel.StringEducationLevel));
            BindDefaultControlProperty(txtCurrentSchool, nameof(_viewModel.CurrentSchool));
            BindDefaultControlProperty(txtCurrentSchoolMajor, nameof(_viewModel.CurrentMajor));
            BindDefaultControlProperty(txtCurrentSchoolEndYear, nameof(_viewModel.CurrentEndYear));
            BindDefaultControlProperty(cmbCurrentEduLevel, nameof(_viewModel.StringCurrentEducationLevel));
        }
        private void BindPreviousJob()
        {
            BindDefaultControlProperty(dtpFrom, nameof(_viewModel.PreviousJobStartDate));
            BindDefaultControlProperty(dtpTo, nameof(_viewModel.PreviousJobEndDate));
            BindDefaultControlProperty(txtEmployeer, nameof(_viewModel.EmployerCompanyName));
            BindDefaultControlProperty(txtWorkPosition, nameof(_viewModel.Position));
        }
        private void BindChildren()
        {
            dgvChildren.DataSource = _viewModel.Children;
        }

        private void BindJobSpecification()
        {
            BindDefaultControlProperty(cmbWorkType, nameof(_viewModel.StringWorkType));
            BindDefaultControlProperty(cmbWorkHours, nameof(_viewModel.StringWorkHours));
            BindDefaultControlProperty(cmbWorkPosition, nameof(_viewModel.StringWorkPosition));
            BindDefaultControlProperty(cmbWorkExpiration, nameof(_viewModel.StringWorkExpiration));
            BindDefaultControlProperty(txtPlaceOfWork, nameof(_viewModel.PlaceOfWork));
            //BindDefaultControlProperty(cmbDivision, nameof(_viewModel.StringDepartment)); // vyriešiť automatické dopĺňanie a filtrovanie comba
            //BindDefaultControlProperty(cmbTeam, nameof(_viewModel.StringDepartment));     // vyriešiť automatické dopĺňanie a filtrovanie comba
            //BindDefaultControlProperty(txtPlaceOfWork, nameof(_viewModel.PlaceOfWork));
            BindDefaultControlProperty(dtpHireDate, nameof(_viewModel.HireDate));
            BindDefaultControlProperty(dtpStartDate, nameof(_viewModel.StartDate));
            BindDefaultControlProperty(dtpEndOfTrial, nameof(_viewModel.EndOfTrial));
            BindDefaultControlProperty(txtSalary, nameof(_viewModel.Salary));
            BindDefaultControlProperty(cmbWageCategory, nameof(_viewModel.StringWageCategory));

        }

        private void tabCntrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCntrl.SelectedTab.Tag == null)
            {
                switch (tabCntrl.SelectedTab.Name)
                {
                    case nameof(tPageContactAdress):
                        BindContactAddress();
                        break;
                    case nameof(tPagePassword):
                        BindCredentials();
                        break;
                    case nameof(tPagePreviousJob):
                        BindPreviousJob();
                        break;
                    case nameof(tPageEducation):
                        BindEducation();
                        break;
                    case nameof(tPageChildInfo):
                        BindChildren();
                        break;
                    case nameof(tPageJobSpecification):
                        BindJobSpecification();
                        break;
                }
                tabCntrl.SelectedTab.Tag = true;

            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
