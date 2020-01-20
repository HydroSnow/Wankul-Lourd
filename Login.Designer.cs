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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_state = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(93, 87);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 3;
            this.button_connect.Text = "Connexion";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // input_username
            // 
            this.input_username.Location = new System.Drawing.Point(112, 22);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(120, 20);
            this.input_username.TabIndex = 1;
            // 
            // input_password
            // 
            this.input_password.Location = new System.Drawing.Point(112, 53);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(120, 20);
            this.input_password.TabIndex = 2;
            this.input_password.UseSystemPasswordChar = true;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(18, 25);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(84, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Nom d\'utilisateur";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(31, 56);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(71, 13);
            this.label_password.TabIndex = 0;
            this.label_password.Text = "Mot de passe";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_state);
            this.panel1.Controls.Add(this.input_password);
            this.panel1.Controls.Add(this.label_password);
            this.panel1.Controls.Add(this.button_connect);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.input_username);
            this.panel1.Location = new System.Drawing.Point(128, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 144);
            this.panel1.TabIndex = 5;
            // 
            // label_state
            // 
            this.label_state.Location = new System.Drawing.Point(3, 115);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(250, 18);
            this.label_state.TabIndex = 4;
            this.label_state.Text = "Non connecté";
            this.label_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(518, 345);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Les Fromageries Wankul";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_state;
    }
}

