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
            MakeVisible(allowCreate);
        }
        private void MakeVisible(bool allowCreate)
        {
            if (allowCreate)
            {                
                btnCreate.Visible = true;
                this.Size = new Size(293,270);
            }
            else
            {
                this.Size = new Size(293, 180);
            }
        }
        #endregion

        #region Set components res
        private void SetComponentsByLanguage()
        {
            btnCreate.Text = Resources.MainForm.btnCreate;
            btnFill.Text = Resources.MainForm.btnFill;
        }
        #endregion

        #region Button handlers
        private void btnSvk_Click(object sender, EventArgs e)
        {
            _mainViewModel.SetLocalization("sk");
            SetComponentsByLanguage();
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            _mainViewModel.SetLocalization("en");
            SetComponentsByLanguage();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Questionare (*.kpq)|*.kpq",
                Title = "Choose Questionare",
                RestoreDirectory = true
            };
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _mainViewModel.OpenQuestionnaireToFill(openFile.FileName);
                }
                catch (Newtonsoft.Json.JsonReaderException)
                {
                    MessageBox.Show(Resources.MainForm.msgWarningText, Resources.MainForm.msgWarning, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _mainViewModel.OpenQuestionnaireCreate();
        }
        #endregion
    }
}
