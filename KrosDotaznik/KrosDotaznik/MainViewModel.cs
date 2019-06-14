using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrosDotaznik
{
    public class MainViewModel
    {
        public void OpenQuestionnaireToFill()
        {
            using (FrmQuestionnaireToFill toFill = new FrmQuestionnaireToFill())
            {
                toFill.ShowDialog();
            }
        }

        public void SetLOcalization(string language)
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo(language);
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo(language);
        }
    }
}
