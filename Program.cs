using System;
using System.Windows.Forms;

namespace Wankul
{
    static class Program
    {
        static Login login_form;
        

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            login_form = new Login();

            Application.Run(login_form);
        }
    }
}
