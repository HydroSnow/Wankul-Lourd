using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace Wankul
{
    public partial class Login : Form
    {
        LoginService loginService = LoginService.SingleInstance;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            input_username.Text = "titos";
            input_password.Text = "girafe";
        }

        private void input_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input_password.Select();
            }
        }

        private void input_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_connect.PerformClick();
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (!CheckNetworkState())
            {
                MessageBox.Show("Veuillez vérifier votre connexion au réseau", "Network Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string responseLogin = CheckLogin(input_username.Text, input_password.Text);
            if (responseLogin.Length < 1)
            {
                MessageBox.Show("Le couple Login / Mot de passe est introuvable dans la base de donnée", "Authentification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                input_password.Clear();
                input_username.Focus();
                return;
            }
            loginService.SetToken(responseLogin);
            this.GoToMainWindow();
        }

        private string CheckLogin(string login, string password)
        {
            ResponseToken responseToken = loginService.Login(login, password);

            if (!responseToken.valid)
            {
                MessageBox.Show(responseToken.error);
                return "";
            }
            return responseToken.result.id;
        }

        private void GoToMainWindow()
        {
            Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Visible = true;
            mainWindow.Activate();
        }

        private bool CheckNetworkState()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }


    }
}
