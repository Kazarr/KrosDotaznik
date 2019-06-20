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
            BindingTest();
            foreach (DataGridViewRow row in dgvChildren.Rows)
            {
                row.Cells[3].Value = DateTime.Now;
            }
            //_viewModel.Children.CollectionChanged += dgvChildren_CollectionChanged;
            //_viewModel.Children.
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

        private void FillCombo(ComboBox combo, Object dataSource)
        {
            string info = System.Globalization.CultureInfo.CurrentCulture.ToString();
            combo.DataSource = new BindingSource(dataSource, null);
            combo.ValueMember = "Key";
            combo.DisplayMember = "Value";
        }

        private void LoadCombos()
        {
            FillCombo(cmbHealthInsurance,_viewModel.HealthInsuranceData);
            FillCombo(cmbState, _viewModel.StateData);
            FillCombo(cmbRetirement, _viewModel.RetirementData);
            FillCombo(cmbEduLevel, _viewModel.EducationLevelData);
            FillCombo(cmbCurrentEduLevel, _viewModel.EducationLevelData);
        }

        public void BindingTest()
        {
            //txtName.DataBindings.Add(nameof(txtName.Text), _viewModel, nameof(_viewModel.Name), false, DataSourceUpdateMode.OnValidation);
            //txtSurname.DataBindings.Add(nameof(txtSurname.Text), _viewModel, nameof(_viewModel.Surname), false, DataSourceUpdateMode.OnValidation);
            //txtPreviousName.DataBindings.Add(nameof(txtPreviousName.Text), _viewModel, nameof(_viewModel.PreviousName), false, DataSourceUpdateMode.OnValidation);
            //txtMaidenName.DataBindings.Add(nameof(txtMaidenName.Text), _viewModel, nameof(_viewModel.MaidenName), false, DataSourceUpdateMode.OnValidation);
            //txtTitle.DataBindings.Add(nameof(txtTitle.Text), _viewModel, nameof(_viewModel.Title), false, DataSourceUpdateMode.OnValidation);
            //txtIdentityCard.DataBindings.Add(nameof(txtIdentityCard.Text), _viewModel, nameof(_viewModel.IdentityCard), false, DataSourceUpdateMode.OnValidation);
            //txtPersonalId.DataBindings.Add(nameof(txtPersonalId.Text), _viewModel, nameof(_viewModel.PersonalId), false, DataSourceUpdateMode.OnValidation);
            //txtPlaceOfBirth.DataBindings.Add(nameof(txtPlaceOfBirth.Text), _viewModel, nameof(_viewModel.PlaceOfBirth), false, DataSourceUpdateMode.OnValidation);
            //txtRegionOfBirth.DataBindings.Add(nameof(txtRegionOfBirth.Text), _viewModel, nameof(_viewModel.RegionOfBirth), false, DataSourceUpdateMode.OnValidation);
            //txtNationality.DataBindings.Add(nameof(txtNationality.Text), _viewModel, nameof(_viewModel.Nationality), false, DataSourceUpdateMode.OnValidation);
            //txtCitizenShip.DataBindings.Add(nameof(txtCitizenShip.Text), _viewModel, nameof(_viewModel.CitizenShip), false, DataSourceUpdateMode.OnValidation);
            //txtBankAcc.DataBindings.Add(nameof(txtBankAcc.Text), _viewModel, nameof(_viewModel.BankAccount), false, DataSourceUpdateMode.OnValidation);
            //txtIban.DataBindings.Add(nameof(txtIban.Text), _viewModel, nameof(_viewModel.Iban), false, DataSourceUpdateMode.OnValidation);
            //cmbState.DataBindings.Add(nameof(cmbState.Text), _viewModel, nameof(_viewModel.StringState), false, DataSourceUpdateMode.OnValidation);
            //cmbHealthInsurance.DataBindings.Add(nameof(cmbHealthInsurance.Text), _viewModel, nameof(_viewModel.HealthInsurance), false, DataSourceUpdateMode.OnValidation);
            //txtHndcpInPercentage.DataBindings.Add(nameof(txtHndcpInPercentage.Text), _viewModel, nameof(_viewModel.HandicapInPercentage), false, DataSourceUpdateMode.OnValidation);
            //txtPhoneNumber.DataBindings.Add(nameof(txtPhoneNumber.Text), _viewModel, nameof(_viewModel.PhoneNumber), false, DataSourceUpdateMode.OnValidation);
            //txtEmail.DataBindings.Add(nameof(txtEmail.Text), _viewModel, nameof(_viewModel.Email), false, DataSourceUpdateMode.OnValidation);

            //txtStreetHouseNumber.DataBindings.Add(nameof(txtStreetHouseNumber.Text), _viewModel, nameof(_viewModel.HouseNumberStreet), false, DataSourceUpdateMode.OnValidation);
            //txtCity.DataBindings.Add(nameof(txtCity.Text), _viewModel, nameof(_viewModel.City), false, DataSourceUpdateMode.OnValidation);
            //txtPostalCode.DataBindings.Add(nameof(txtPostalCode.Text), _viewModel, nameof(_viewModel.PostalCode), false, DataSourceUpdateMode.OnValidation);
            //txtTempStreetHouseNumber.DataBindings.Add(nameof(txtTempStreetHouseNumber.Text), _viewModel, nameof(_viewModel.HouseNumberStreet), false, DataSourceUpdateMode.OnValidation);
            //txtTempCity.DataBindings.Add(nameof(txtTempCity.Text), _viewModel, nameof(_viewModel.TempCity), false, DataSourceUpdateMode.OnValidation);
            //txtTempPostalCode.DataBindings.Add(nameof(txtTempPostalCode.Text), _viewModel, nameof(_viewModel.TempPostalCode), false, DataSourceUpdateMode.OnValidation);

            //txtPassword.DataBindings.Add(nameof(txtPassword.Text), _viewModel, nameof(_viewModel.PayChechPassword), false, DataSourceUpdateMode.OnValidation);
            //txtPinAlarm.DataBindings.Add(nameof(txtPinAlarm.Text), _viewModel, nameof(_viewModel.PinAlarm), false, DataSourceUpdateMode.OnValidation);

            //txtHighestSchool.DataBindings.Add(nameof(txtHighestSchool.Text), _viewModel, nameof(_viewModel.HighestSchool), false, DataSourceUpdateMode.OnValidation);
            //txtHightestSchoolMajor.DataBindings.Add(nameof(txtHightestSchoolMajor.Text), _viewModel, nameof(_viewModel.HighestMajor), false, DataSourceUpdateMode.OnValidation);
            //txtHighestSchoolEndYear.DataBindings.Add(nameof(txtHighestSchoolEndYear.Text), _viewModel, nameof(_viewModel.EndDate), false, DataSourceUpdateMode.OnValidation);
            //cmbEduLevel.DataBindings.Add(nameof(cmbEduLevel.Text), _viewModel, nameof(_viewModel.EducationLevel), false, DataSourceUpdateMode.OnValidation);
            //txtCurrentSchool.DataBindings.Add(nameof(txtCurrentSchool.Text), _viewModel, nameof(_viewModel.CurrentSchool), false, DataSourceUpdateMode.OnValidation);
            //txtCurrentSchoolMajor.DataBindings.Add(nameof(txtCurrentSchoolMajor.Text), _viewModel, nameof(_viewModel.CurrentMajor), false, DataSourceUpdateMode.OnValidation);
            //txtCurrentSchoolEndYear.DataBindings.Add(nameof(txtCurrentSchoolEndYear.Text), _viewModel, nameof(_viewModel.CurrentEndYear), false, DataSourceUpdateMode.OnValidation);
            //cmbCurrentEduLevel.DataBindings.Add(nameof(cmbCurrentEduLevel.Text), _viewModel, nameof(_viewModel.CurrentEducationLevel), false, DataSourceUpdateMode.OnValidation);

            ////dtpFrom.DataBindings.Add(nameof(dtpFrom.Value), _viewModel, nameof(_viewModel.StartDate), false, DataSourceUpdateMode.OnValidation);
            ////dtpTo.DataBindings.Add(nameof(dtpTo.Value), _viewModel, nameof(_viewModel.EndDate), false, DataSourceUpdateMode.OnValidation);
            //txtEmployeer.DataBindings.Add(nameof(txtEmployeer.Text), _viewModel, nameof(_viewModel.EmployerCompanyName), false, DataSourceUpdateMode.OnValidation);
            //txtWorkPosition.DataBindings.Add(nameof(txtWorkPosition.Text), _viewModel, nameof(_viewModel.Position), false, DataSourceUpdateMode.OnValidation);

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

            BindDefaultControlProperty(cmbState, nameof(_viewModel.StringState));

            //BindDefaultControlProperty(txtHealtInsurance, nameof(_viewModel.HealthInsurance));
            BindDefaultControlProperty(txtHndcpInPercentage, nameof(_viewModel.HandicapInPercentage));
            //BindDefaultControlProperty(txtState, nameof(_viewModel.State));

            BindDefaultControlProperty(txtPhoneNumber, nameof(_viewModel.PhoneNumber));
            BindDefaultControlProperty(txtEmail, nameof(_viewModel.Email));
            //BindDefaultControlProperty(txtStreetHouseNumber, nameof(_viewModel.HouseNumber));
            //BindDefaultControlProperty(txtStreetHouseNumber, nameof(_viewModel.Street));
            BindDefaultControlProperty(txtCity, nameof(_viewModel.City));
            BindDefaultControlProperty(txtPostalCode, nameof(_viewModel.PostalCode));
            //BindDefaultControlProperty(txtTempStreetHouseNumber, nameof(_viewModel.TempHouseNumber));
            //BindDefaultControlProperty(txtTempStreetHouseNumber, nameof(_viewModel.TempStreet));
            BindDefaultControlProperty(txtTempCity, nameof(_viewModel.TempCity));
            BindDefaultControlProperty(txtTempPostalCode, nameof(_viewModel.TempPostalCode));

            BindDefaultControlProperty(txtPassword, nameof(_viewModel.PayChechPassword));
            BindDefaultControlProperty(txtPinAlarm, nameof(_viewModel.PinAlarm));

            BindDefaultControlProperty(txtHighestSchool, nameof(_viewModel.HighestSchool));
            BindDefaultControlProperty(txtHightestSchoolMajor, nameof(_viewModel.HighestMajor));
            BindDefaultControlProperty(txtHighestSchoolEndYear, nameof(_viewModel.HighestEndYear));
            //BindDefaultControlProperty(txtHighestSchoolEducationLevel, nameof(_viewModel.EducationLevel));
            BindDefaultControlProperty(txtCurrentSchool, nameof(_viewModel.CurrentSchool));
            BindDefaultControlProperty(txtCurrentSchoolMajor, nameof(_viewModel.CurrentMajor));
            BindDefaultControlProperty(txtCurrentSchoolEndYear, nameof(_viewModel.CurrentEndYear));
            //BindDefaultControlProperty(txtCurrentSchoolEducationLevel, nameof(_viewModel.CurrentEducationLevel));

            //BindDefaultControlProperty(dtpFrom, nameof(_viewModel.StartDate));
            //BindDefaultControlProperty(dtpTo, nameof(_viewModel.EndDate));
            BindDefaultControlProperty(txtEmployeer, nameof(_viewModel.EmployerCompanyName));
            BindDefaultControlProperty(txtWorkPosition, nameof(_viewModel.Position));

            dgvChildren.DataSource = _viewModel.Children;

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

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = _viewModel.StringState;
        }
    }
}
