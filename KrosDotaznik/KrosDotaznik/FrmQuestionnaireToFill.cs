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
        public FrmQuestionnaireToFill()
        {
            InitializeComponent();
            SetComponentsByLanguage();
            Jahoda();
        }

        private void SetComponentsByLanguage()
        {
            //grBoxEmployeeData.Text = Resources.Questionnaire.lblPersonalInfo;
            lblName.Text = Resources.Questionnaire.lblName;
            lblSurname.Text = Resources.Questionnaire.lblSurname;
            lblPreviousName.Text = Resources.Questionnaire.lblPreviousSurname;
            lblMaidenName.Text = Resources.Questionnaire.lblMaidenName;
            lblIdentityCard.Text = Resources.Questionnaire.lblIdentityCard;
            lblBirthDate.Text = Resources.Questionnaire.lblBirthDate;
            lblTitle.Text = Resources.Questionnaire.lblTitle;
            lblBankAcc.Text = Resources.Questionnaire.lblBankAcc;
            lblIBAN.Text = Resources.Questionnaire.lblIBAN;
            lblPersonalId.Text = Resources.Questionnaire.lblPersonalId;
            lblPlaceOfBirth.Text = Resources.Questionnaire.lblPlaceOfBirth;
            lblRegionOfBirth.Text = Resources.Questionnaire.lblRegionOfBirth;
            lblNationality.Text = Resources.Questionnaire.lblNationality;
            lblCitizenShip.Text = Resources.Questionnaire.lblCitizenShip;
            lblGender.Text = Resources.Questionnaire.lblGender;
            lblState.Text = Resources.Questionnaire.lblState;
            lblHealthInsurance.Text = Resources.Questionnaire.lblHealthInsurance;
            lblSecondPillar.Text = Resources.Questionnaire.lblSecondPillar;
            lblHandicap.Text = Resources.Questionnaire.lblHandicap;
            lblHandicapInPercentage.Text = Resources.Questionnaire.lblHandicapInPercentage;
            lblPensionRecipient.Text = Resources.Questionnaire.lblPensionRecipient;
            lblRetirementInsuranceCompanyException.Text = Resources.Questionnaire.lblException;
            lblStreet.Text = Resources.Questionnaire.lblAddressStreet;
            lblStreetTemp.Text = Resources.Questionnaire.lblAddressStreet;
            lblCity.Text = Resources.Questionnaire.lblAddressCity;
            lblCityTemp.Text = Resources.Questionnaire.lblAddressCity;
            lblPostalCode.Text = Resources.Questionnaire.lblAddressPostalCode;
            lblPostalCodeTemp.Text = Resources.Questionnaire.lblAddressPostalCode;
            lblPhoneNumber.Text = Resources.Questionnaire.lblPhone;
            lblEmail.Text = Resources.Questionnaire.lblMail;
            grBoxAddress.Text = Resources.Questionnaire.lblAddress;
            grBoxTemporaryAddress.Text = Resources.Questionnaire.lblTemporaryAddress;
            lblPassword.Text = Resources.Questionnaire.lblPaycheckPass;
            lblPin.Text = Resources.Questionnaire.lblAlarmPin;
            grBoxHighEducation.Text = Resources.Questionnaire.lblHighestEducation;
            grBoxCurrentEducation.Text = Resources.Questionnaire.lblCurrentStudy;
            lblSchool.Text = Resources.Questionnaire.lblSchool;
            lblCurrSchool.Text = Resources.Questionnaire.lblSchool;
            lblEndYear.Text = Resources.Questionnaire.lblYearOfEnd;
            lblCurrEndYear.Text = Resources.Questionnaire.lblYearOfEnd;
            lblMajor.Text = Resources.Questionnaire.lblMajor;
            lblCurrMajor.Text = Resources.Questionnaire.lblMajor;
            lblEducationLevel.Text = Resources.Questionnaire.lblEducationLevel;
            lblCurrEducationLevel.Text = Resources.Questionnaire.lblEducationLevel;
            lblJobFrom.Text = Resources.Questionnaire.lblJobFrom;
            lblJobTo.Text = Resources.Questionnaire.lblJobTo;
            lblEmployeer.Text = Resources.Questionnaire.lblEmployer;
            lblWorkPosition.Text = Resources.Questionnaire.lblWorkPosition;
            radioBtnMale.Text = Resources.Questionnaire.lblMale;
            radioBtnFemale.Text = Resources.Questionnaire.lblFemale;

        }
        private void Jahoda()
        {
            tPagePersonalInfo.Text = Resources.Questionnaire.lblPersonalInfo;
            tPageContactAdress.Text = Resources.Questionnaire.lblContactAddress;
            tPagePassword.Text = Resources.Questionnaire.lblPassAndApproaches;
            tPageEducation.Text= Resources.Questionnaire.lblEducation;
            tPageChildInfo.Text = Resources.Questionnaire.lblChildInfo;
            tPagePreviousJob.Text = Resources.Questionnaire.lblPreviousJob;
        }
        private void Zemiak()
        {
            tabCntrl.TabPages.Remove(tPageEducation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zemiak();
        }

    }
}
