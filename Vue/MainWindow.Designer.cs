namespace Wankul
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FromageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LaitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FournisseurMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxEntity = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonModif = new System.Windows.Forms.Button();
            this.buttonSuppr = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FromageMenu,
            this.LaitMenu,
            this.TypeMenu,
            this.ClientMenu,
            this.FournisseurMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(157, 554);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FromageMenu
            // 
            this.FromageMenu.BackColor = System.Drawing.Color.Gold;
            this.FromageMenu.Font = new System.Drawing.Font("Stencil", 11F);
            this.FromageMenu.Name = "FromageMenu";
            this.FromageMenu.Size = new System.Drawing.Size(144, 26);
            this.FromageMenu.Text = "Fromage";
            this.FromageMenu.Click += new System.EventHandler(this.FromageMenu_Click);
            // 
            // LaitMenu
            // 
            this.LaitMenu.Font = new System.Drawing.Font("Stencil", 11F);
            this.LaitMenu.Name = "LaitMenu";
            this.LaitMenu.Size = new System.Drawing.Size(144, 26);
            this.LaitMenu.Text = "Lait";
            this.LaitMenu.Click += new System.EventHandler(this.LaitMenu_Click);
            // 
            // TypeMenu
            // 
            this.TypeMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.TypeMenu.Font = new System.Drawing.Font("Stencil", 11F);
            this.TypeMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.TypeMenu.Name = "TypeMenu";
            this.TypeMenu.Size = new System.Drawing.Size(144, 26);
            this.TypeMenu.Text = "Type";
            this.TypeMenu.Click += new System.EventHandler(this.TypeMenu_Click);
            // 
            // ClientMenu
            // 
            this.ClientMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.ClientMenu.Font = new System.Drawing.Font("Stencil", 11F);
            this.ClientMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ClientMenu.Name = "ClientMenu";
            this.ClientMenu.Size = new System.Drawing.Size(144, 26);
            this.ClientMenu.Text = "Client";
            this.ClientMenu.Click += new System.EventHandler(this.ClientMenu_Click);
            // 
            // FournisseurMenu
            // 
            this.FournisseurMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.FournisseurMenu.Font = new System.Drawing.Font("Stencil", 11F);
            this.FournisseurMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.FournisseurMenu.Name = "FournisseurMenu";
            this.FournisseurMenu.Size = new System.Drawing.Size(144, 26);
            this.FournisseurMenu.Text = "Fournisseur";
            this.FournisseurMenu.Click += new System.EventHandler(this.FournisseurMenu_Click);
            // 
            // listBoxEntity
            // 
            this.listBoxEntity.HideSelection = false;
            this.listBoxEntity.Location = new System.Drawing.Point(204, 57);
            this.listBoxEntity.Name = "listBoxEntity";
            this.listBoxEntity.Size = new System.Drawing.Size(250, 475);
            this.listBoxEntity.TabIndex = 1;
            this.listBoxEntity.TabStop = false;
            this.listBoxEntity.UseCompatibleStateImageBehavior = false;
            this.listBoxEntity.View = System.Windows.Forms.View.Tile;
            this.listBoxEntity.SelectedIndexChanged += new System.EventHandler(this.listEntity_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(689, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(689, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 22);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(689, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(689, 340);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(206, 22);
            this.textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(689, 293);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 22);
            this.textBox6.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(689, 245);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(206, 22);
            this.textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(460, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(460, 245);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 23;
            // 
            // filterBox
            // 
            this.filterBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.filterBox.Location = new System.Drawing.Point(234, 29);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(166, 22);
            this.filterBox.TabIndex = 24;
            this.filterBox.TabStop = false;
            this.filterBox.Text = "Filtrer";
            this.filterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            this.filterBox.Enter += new System.EventHandler(this.filterBox_Enter);
            this.filterBox.Leave += new System.EventHandler(this.filterBox_Leave);
            // 
            // buttonAjout
            // 
            this.buttonAjout.BackColor = System.Drawing.Color.Gold;
            this.buttonAjout.Font = new System.Drawing.Font("Showcard Gothic", 11F);
            this.buttonAjout.Location = new System.Drawing.Point(500, 459);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(117, 46);
            this.buttonAjout.TabIndex = 25;
            this.buttonAjout.Text = "Ajouter";
            this.buttonAjout.UseVisualStyleBackColor = false;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonModif
            // 
            this.buttonModif.BackColor = System.Drawing.Color.Gold;
            this.buttonModif.Font = new System.Drawing.Font("Showcard Gothic", 11F);
            this.buttonModif.Location = new System.Drawing.Point(623, 459);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(117, 46);
            this.buttonModif.TabIndex = 26;
            this.buttonModif.Text = "Modifier";
            this.buttonModif.UseVisualStyleBackColor = false;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // buttonSuppr
            // 
            this.buttonSuppr.BackColor = System.Drawing.Color.Gold;
            this.buttonSuppr.Font = new System.Drawing.Font("Showcard Gothic", 11F);
            this.buttonSuppr.Location = new System.Drawing.Point(746, 459);
            this.buttonSuppr.Name = "buttonSuppr";
            this.buttonSuppr.Size = new System.Drawing.Size(149, 46);
            this.buttonSuppr.TabIndex = 27;
            this.buttonSuppr.Text = "Supprimer";
            this.buttonSuppr.UseVisualStyleBackColor = false;
            this.buttonSuppr.Click += new System.EventHandler(this.buttonSuppr_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.BackColor = System.Drawing.Color.Gold;
            this.buttonEffacer.Font = new System.Drawing.Font("Showcard Gothic", 11F);
            this.buttonEffacer.Location = new System.Drawing.Point(901, 459);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(117, 46);
            this.buttonEffacer.TabIndex = 28;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = false;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonSuppr);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxEntity);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FromageMenu;
        private System.Windows.Forms.ToolStripMenuItem LaitMenu;
        private System.Windows.Forms.ToolStripMenuItem TypeMenu;
        private System.Windows.Forms.ToolStripMenuItem ClientMenu;
        private System.Windows.Forms.ToolStripMenuItem FournisseurMenu;
        private System.Windows.Forms.ListView listBoxEntity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Button buttonSuppr;
        private System.Windows.Forms.Button buttonEffacer;
    }
}