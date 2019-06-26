namespace KrosDotaznik
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            SetLocalization("sk");
        }
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
            using (FrmQuestionnaireCreate toCreate = new FrmQuestionnaireCreate())
            {
                toCreate.ShowDialog();
            }
        }

        public void SetLocalization(string language)
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo(language);
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo(language);
        }
        #endregion
    }
}
