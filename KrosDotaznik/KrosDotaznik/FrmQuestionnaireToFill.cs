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
        }
    }
}
