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
        private MainViewModel _mainViewModel = new MainViewModel();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">Argumets for starting app for edit questionare</param>
        public FrmMain(string[] args)
        {
            InitializeComponent();
            SetComponentsByLanguage();
            _mainViewModel.SaveTest();
        }

        private void SetComponentsByLanguage() {
            btnCreate.Text = Resources.MainForm.btnCreate;
            btnFill.Text = Resources.MainForm.btnFill;
        }

        private void btnSvk_Click(object sender, EventArgs e)
        {
            _mainViewModel.SetLOcalization("sk");
            SetComponentsByLanguage();
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            _mainViewModel.SetLOcalization("en");
            SetComponentsByLanguage();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            _mainViewModel.OpenQuestionnaireToFill();
        }
    }
}
