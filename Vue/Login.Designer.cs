namespace Wankul
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button_connect = new System.Windows.Forms.Button();
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.panel_input = new System.Windows.Forms.Panel();
            this.panel_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(119, 110);
            this.button_connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(100, 28);
            this.button_connect.TabIndex = 3;
            this.button_connect.Text = "Connexion";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // input_username
            // 
            this.input_username.Location = new System.Drawing.Point(149, 27);
            this.input_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(159, 22);
            this.input_username.TabIndex = 1;
            this.input_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_username_KeyDown);
            // 
            // input_password
            // 
            this.input_password.Location = new System.Drawing.Point(149, 65);
            this.input_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(159, 22);
            this.input_password.TabIndex = 2;
            this.input_password.UseSystemPasswordChar = true;
            this.input_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_password_KeyDown);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(24, 31);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(113, 17);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Nom d\'utilisateur";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(41, 69);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(93, 17);
            this.label_password.TabIndex = 0;
            this.label_password.Text = "Mot de passe";
            // 
            // panel_input
            // 
            this.panel_input.Controls.Add(this.input_password);
            this.panel_input.Controls.Add(this.label_password);
            this.panel_input.Controls.Add(this.button_connect);
            this.panel_input.Controls.Add(this.label_username);
            this.panel_input.Controls.Add(this.input_username);
            this.panel_input.Location = new System.Drawing.Point(171, 140);
            this.panel_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(341, 158);
            this.panel_input.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(691, 425);
            this.Controls.Add(this.panel_input);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Fromageries Wankul";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Panel panel_input;
    }
}

