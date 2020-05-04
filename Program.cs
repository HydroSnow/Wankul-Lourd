using System;
using System.Windows.Forms;

namespace Wankul
{
    public static class Program
    {
        public const string API_ENDPOINT = "https://wankul.hydrosnow.dev/api/";
        // public const string API_ENDPOINT = "http://localhost:8000/api/";

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
