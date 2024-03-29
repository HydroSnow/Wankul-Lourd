﻿using System;
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
            Console.WriteLine("Form loaded");
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
            this.Visible = false;
        }
    }
}
