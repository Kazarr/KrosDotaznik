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
            grBoxEmployeeData.Text = Resources.Questionnaire.lblPersonalInfo;
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
            lblException.Text = Resources.Questionnaire.lblException;

        }
        private void Jahoda()
        {
            groupBox1.Visible = false;
        }
    }
}
