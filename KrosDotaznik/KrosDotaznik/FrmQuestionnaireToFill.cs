using Data;
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
            SetVisibleTabs();
        }

        private void SetVisibleTabs()
        {
            foreach (var item in _viewModel.HiddenTabs)
            {
                tabCntrl.TabPages.RemoveByKey(Enum.GetName(typeof(Tabs),item));
            }
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
            FillCombo(cmbDivision, _viewModel.DivisionData);
            FillCombo(cmbTeam, _viewModel.DepartmentData);
            FillCombo(cmbWageCategory, _viewModel.WageCategoryData);
            FillCombo(cmbWorkExpiration, _viewModel.WorkExpirationData);
            FillCombo(cmbWorkHours, _viewModel.WorkHoursData);
            FillCombo(cmbWorkPosition, _viewModel.WorkPositionData);
            FillCombo(cmbWorkType, _viewModel.WorkTypeData);
        }
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
            BindDefaultControlProperty(cmbDivision, nameof(_viewModel.StringDivision)); // vyriešiť automatické dopĺňanie a filtrovanie comba
            BindDefaultControlProperty(cmbTeam, nameof(_viewModel.StringDepartment));     // vyriešiť automatické dopĺňanie a filtrovanie comba
            BindDefaultControlProperty(dtpHireDate, nameof(_viewModel.HireDate));
            BindDefaultControlProperty(dtpStartDate, nameof(_viewModel.StartDate));
            BindDefaultControlProperty(dtpEndOfTrial, nameof(_viewModel.EndOfTrial));
            BindDefaultControlProperty(txtSalary, nameof(_viewModel.Salary));
            BindDefaultControlProperty(cmbWageCategory, nameof(_viewModel.StringWageCategory));
            txtHoursPerWeek.DataBindings.Add(nameof(txtHoursPerWeek.Visible), _viewModel, nameof(_viewModel.VisibleHoursPerWeek), false, DataSourceUpdateMode.OnPropertyChanged);
            txtHoursPerWeek.DataBindings.Add(nameof(txtHoursPerWeek.Text), _viewModel, nameof(_viewModel.HoursPerWeek), false, DataSourceUpdateMode.OnValidation);
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

        private void tabCntrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            TabPage _tabPage = tabCntrl.TabPages[e.Index];

            Rectangle _tabBounds = tabCntrl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            Font _tabFont = new Font("Arial", 18.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
