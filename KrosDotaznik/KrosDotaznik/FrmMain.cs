﻿using System;
using System.Drawing;
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
            this.Text = Resources.MainForm.frmMain;
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
            using (openFileKpq)
            {
                openFileKpq.Filter = "Questionare (*.kpq)|*.kpq";
                openFileKpq.Title = "Choose Questionare";
                openFileKpq.FileName = "Default.kpq";
                if (openFileKpq.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _mainViewModel.OpenQuestionnaireToFill(openFileKpq.FileName);
                    }
                    catch (Newtonsoft.Json.JsonReaderException)
                    {
                        MessageBox.Show(Resources.MainForm.msgWarningText, Resources.MainForm.msgWarning, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
