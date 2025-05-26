namespace page_d_accueil
{
    partial class ListeDepot
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
            this.lblNumDepotRe = new System.Windows.Forms.Label();
            this.lblVilleRe = new System.Windows.Forms.Label();
            this.cbNumDepotRe = new System.Windows.Forms.ComboBox();
            this.cbVilleRe = new System.Windows.Forms.ComboBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumDepotRe
            // 
            this.lblNumDepotRe.AutoSize = true;
            this.lblNumDepotRe.Location = new System.Drawing.Point(16, 22);
            this.lblNumDepotRe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDepotRe.Name = "lblNumDepotRe";
            this.lblNumDepotRe.Size = new System.Drawing.Size(150, 16);
            this.lblNumDepotRe.TabIndex = 0;
            this.lblNumDepotRe.Text = "Recherche par numéro :";
            // 
            // lblVilleRe
            // 
            this.lblVilleRe.AutoSize = true;
            this.lblVilleRe.Location = new System.Drawing.Point(16, 54);
            this.lblVilleRe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVilleRe.Name = "lblVilleRe";
            this.lblVilleRe.Size = new System.Drawing.Size(132, 16);
            this.lblVilleRe.TabIndex = 2;
            this.lblVilleRe.Text = "Recherche par ville : ";
            // 
            // cbNumDepotRe
            // 
            this.cbNumDepotRe.FormattingEnabled = true;
            this.cbNumDepotRe.Location = new System.Drawing.Point(187, 18);
            this.cbNumDepotRe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNumDepotRe.Name = "cbNumDepotRe";
            this.cbNumDepotRe.Size = new System.Drawing.Size(51, 24);
            this.cbNumDepotRe.TabIndex = 3;
            // 
            // cbVilleRe
            // 
            this.cbVilleRe.FormattingEnabled = true;
            this.cbVilleRe.Location = new System.Drawing.Point(187, 50);
            this.cbVilleRe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVilleRe.Name = "cbVilleRe";
            this.cbVilleRe.Size = new System.Drawing.Size(140, 24);
            this.cbVilleRe.TabIndex = 4;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(419, 48);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(100, 28);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(39, 111);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 16);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(93, 107);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(128, 22);
            this.txtNom.TabIndex = 7;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(39, 153);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(39, 16);
            this.lblVille.TabIndex = 8;
            this.lblVille.Text = "Ville :";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(89, 149);
            this.txtVille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(132, 22);
            this.txtVille.TabIndex = 9;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(39, 192);
            this.lblPays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(44, 16);
            this.lblPays.TabIndex = 10;
            this.lblPays.Text = "Pays :";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(95, 188);
            this.txtPays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(127, 22);
            this.txtPays.TabIndex = 11;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(27, 297);
            this.lblLatitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(60, 16);
            this.lblLatitude.TabIndex = 12;
            this.lblLatitude.Text = "Latitude :";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(103, 297);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(180, 22);
            this.txtLatitude.TabIndex = 13;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(27, 255);
            this.lblLongitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(72, 16);
            this.lblLongitude.TabIndex = 14;
            this.lblLongitude.Text = "Longitude :";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(115, 251);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(199, 22);
            this.txtLongitude.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 385);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(607, 170);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(20, 350);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(157, 350);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(139, 28);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Text = "Ajouter un dépot";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(343, 350);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 28);
            this.btnEnregistrer.TabIndex = 19;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(493, 350);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 20;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // ListeDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 570);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.cbVilleRe);
            this.Controls.Add(this.cbNumDepotRe);
            this.Controls.Add(this.lblVilleRe);
            this.Controls.Add(this.lblNumDepotRe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListeDepot";
            this.Text = "Liste des dépots";
            this.Load += new System.EventHandler(this.ListeDepot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumDepotRe;
        private System.Windows.Forms.Label lblVilleRe;
        private System.Windows.Forms.ComboBox cbNumDepotRe;
        private System.Windows.Forms.ComboBox cbVilleRe;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
    }
}