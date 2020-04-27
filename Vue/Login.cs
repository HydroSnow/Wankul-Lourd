using RestSharp;
using System;
using System.Windows.Forms;

namespace Wankul
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            input_username.Text = "Titos";
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
            if (!CheckLogin(input_username.Text, input_password.Text))
            {
                MessageBox.Show("Le couple Login / Mot de passe est introuvable dans la base de donnée", "Authentification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                input_password.Clear();
                input_username.Focus();
                return;
            }
            this.GoToMainWindow();
        }

        private bool CheckLogin(string login, string password)
        {
            return true;
        }

        private void GoToMainWindow()
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Visible = true;
            mainWindow.Activate();
        }
    }
}
