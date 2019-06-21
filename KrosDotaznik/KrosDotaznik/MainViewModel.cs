using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace KrosDotaznik
{
    public class MainViewModel
    {      
        #region Form method
        public void OpenQuestionnaireToFill(string path)
        {
            using (FrmQuestionnaireToFill toFill = new FrmQuestionnaireToFill(new QuestionnaireToFillViewModel(path)))
            {
                toFill.ShowDialog();
            }
        }

        public void OpenQuestionnaireCreate()
        {
            using (FrmQuestionnaireCreate toFill = new FrmQuestionnaireCreate())
            {
                toFill.ShowDialog();
            }
        }

        public void SetLOcalization(string language)
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo(language);
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo(language);
        }
        #endregion
    }
}
