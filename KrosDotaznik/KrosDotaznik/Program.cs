using System;
using System.Windows.Forms;

namespace KrosDotaznik
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool allowCreate = default(bool);
            if(args.Length != 0)
            {
                if(args[0] == "monikajehviezda")
                {
                    allowCreate = true;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(allowCreate));
        }
    }
}
